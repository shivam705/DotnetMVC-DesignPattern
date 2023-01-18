using DAL.Data.DbContexts;
using DAL.EFModels;
using System;
using System.Collections.Generic;


namespace DAL
{
    public class CreateEventDAL
    {
        private readonly AssignmenttMVCContext _context;
        public CreateEventDAL(AssignmenttMVCContext context)
        {
            _context = context;
        }
        public void CreateEvent(Event evt, List<Invitation> invitations)
        {

            _context.Events.Add(evt);
            _context.SaveChanges();
            int id = evt.EventId;
            foreach (var item in invitations)
            {
                item.EventId = id;
                _context.Invitaions.Add(item);
            }
            _context.SaveChanges();




        }
    }
}
