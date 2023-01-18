using DAL;
using DAL.Data.DbContexts;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CreateEventBL
    {
        private readonly CreateEventDAL _createeventsDal;
        private readonly AllEventsDAL _alleventsDal;


        public CreateEventBL(CreateEventDAL createeventsDal, AllEventsDAL alleventsDal)
        {
            _createeventsDal = createeventsDal;
            _alleventsDal = alleventsDal;
        }
        public void CreateEvent(Event evt)
        {
            IEnumerable<Event> events = _alleventsDal.GetAllEvents();
            List<Invitation> invitations = new List<Invitation>();

            if (evt.InviteByEmail != null)
            {
                var invited = evt.InviteByEmail.Split(',');
                Invitation invitation = new Invitation();
                if (invited != null)
                {


                    foreach (var item in invited)
                    {
                        invitation.Email = item;
                        invitation.EventId = evt.EventId;
                    }

                    invitations.Add(invitation);
                }
            }
            _createeventsDal.CreateEvent(evt, invitations);


        }
    }
}

