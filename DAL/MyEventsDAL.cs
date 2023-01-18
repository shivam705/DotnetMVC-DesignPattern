using DAL.Data.DbContexts;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyEventsDAL
    {

        private readonly AssignmenttMVCContext _context;
        public MyEventsDAL(AssignmenttMVCContext context)
        {
            _context = context;
        }

        /*public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events;
        }*/

        public IEnumerable<Event> GetMyEvents(string userEmail)
        {



            Register user = (from u in _context.Registers where u.EmailId == userEmail select u).ToList().First();

            return user.Events;


        }

    }
    
}

