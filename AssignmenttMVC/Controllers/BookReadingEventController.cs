
using AssignmenttMVC.Helper;
using BL;
using DAL.EFModels;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AssignmenttMVC.Model;
using DAL.Data.DbContexts;

namespace AssignmenttMVC.Controllers
{
    public class BookReadingEventController : Controller
    {
       
        public string UserId { get; private set; }
        private readonly AssignmenttMVCContext _db;
        private readonly AllEventsBL _allEvents;
        private readonly MyEventsTitlesBL _myEvent;
        private readonly UserEmailBL _userEmail;
        private readonly EventBL _events;
        private readonly CreateEventBL _createevent;

        public BookReadingEventController(AllEventsBL allEvents,MyEventsTitlesBL myEvent,UserEmailBL userEmail,EventBL events, CreateEventBL createevent, AssignmenttMVCContext db)
        {
           
            _allEvents = allEvents;
            _myEvent=myEvent;
            _userEmail = userEmail;
            _events = events;
            _db = db;
            _createevent = createevent;
        }

        string UserEmail;
        public string GetUserEmail
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    UserEmail = _userEmail.GetUserEmail(User.Identity.Name);
                }
                return UserEmail;
            }

        }

        public ActionResult AllEvents()
        {

            IEnumerable<Event> events = _allEvents.GetAllEvents();

            return View(new EventToEventModelHelper().GetEventModels(events));
          

        }



        public ActionResult MyEvents()
        {
            string UserEmail = GetUserEmail;
            IEnumerable<Event> myEvents = _myEvent.GetMyEvents(UserEmail);
            return View(new EventToEventModelHelper().GetEventModels(myEvents));
            //return View(_db.Events.ToList());
            
        }


        public ActionResult EventsInvitedTo()
        {
            
            return View();
        }



        [HttpGet]
        public ActionResult CreateEvent()
        {

            return View();
        }

        [ActionName("CreateEvent")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEvent(EventsModel models)
        {
            if (ModelState.IsValid)
            {
                //models.UserId = UserModel.Identity.Name;

                Event evt = new EventModelToEventHelper().EventModelToEventMapping(models);

                _createevent.CreateEvent(evt);

                return RedirectToAction("Index", "Home");

            }
            return View(models);
        }


        [HttpGet]
        public ActionResult ViewEvent(int Userid,Event model)
        {


            //EventsModel eventModel = _db.Event.Where(usr => usr.InviteByEmail == model.InviteByEmail).SingleOrDefault();
            EventsModel eventModel = new EventToEventModelHelper().EventToEventModelMapping(_events.GetEvent(Userid));
            if (eventModel.InviteByEmail != null)
            {
                eventModel.Count = eventModel.InviteByEmail.Split(',').Length;
            }
            else
            {
                eventModel.Count = 0;
            }
            ViewBag.DisplayDescription = (eventModel.Description != null) ? true : false;
            ViewBag.DisplayOtherDetails = (eventModel.OtherDetails != null) ? true : false;
            ViewBag.DisplayDuration = (eventModel.Duration != null) ? true : false;
            ViewBag.DisplayCount = (eventModel.Count != 0) ? true : false;
            ViewBag.DisplayEditLink = ((eventModel.Date < DateTime.Now.Date) || (eventModel.StartTime.TimeOfDay <= DateTime.Now.TimeOfDay)) ? false : true;
            // model.Title = _db.Event.Add("Title");
            return View(model);

           
        }

        [HttpGet]

        public ActionResult EditEvent(int userid, Event eventModel)
        {
            var edevent = _db.Events.FirstOrDefault(x => x.UserId == userid);
            
            
            if (ModelState.IsValid && edevent != null)
            {

                edevent.Title = eventModel.Title;
                edevent.Date = eventModel.Date;
                edevent.Location = eventModel.Location;
                edevent.StartTime = eventModel.StartTime;
                edevent.Type = eventModel.Type;
                edevent.Duration = eventModel.Duration;
                edevent.Description = eventModel.Description;
                edevent.OtherDetails = eventModel.OtherDetails;
                edevent.InviteByEmail = eventModel.InviteByEmail;
                //edevent.Count = eventModel.Count;

            }
            return View(eventModel);

        }


        [HttpPost]
        [ActionName("EditEvent")]

        public ActionResult EditEventPost(int id,Event eventModel)
        {
            var edevent = _db.Events.FirstOrDefault(x => x.UserId == id);
            if (ModelState.IsValid && edevent!=null)
            {

                edevent.Title = eventModel.Title;
                edevent.Date = eventModel.Date;
                edevent.Location = eventModel.Location;
                edevent.StartTime =eventModel.StartTime;
                edevent.Type = eventModel.Type;
                edevent.Duration = eventModel.Duration;
                edevent.Description = eventModel.Description;
                edevent.OtherDetails = eventModel.OtherDetails;
                edevent.InviteByEmail = eventModel.InviteByEmail;
                //edevent.Count = eventModel.Count;
              
            }
            _db.SaveChanges();
             return View(RedirectToAction("AllEvents", "BookReadingEvent"));
            

        }

        public ActionResult DeleteEvent(int eventId)
        {
            
             /*_db.Events.Remove(UserId);
             return RedirectToAction("About", "Home");*/
            return View();
        }

        [HttpGet]
        public ActionResult Comments(Comment model)
        {
            
            
            return View(_db.Comments.ToList());
        }



        [HttpPost]
        public ActionResult AddCommentsPost(Comment commentModel)
        {
            commentModel.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                _db.Comments.Add(commentModel);
                _db.SaveChanges();
            }
            return RedirectToAction("ViewEvent", new { commentModel.CommentId });
            
        }
    }
}
