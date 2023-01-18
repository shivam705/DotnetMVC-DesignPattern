using DAL.Data.DbContexts;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EventDAL
    {
        private readonly AssignmenttMVCContext _context;
        public EventDAL(AssignmenttMVCContext context)
        {
            _context = context;
        }

        public Event GetEvent(int userid)
        {

            IEnumerable<Event> events = _context.Events;
            Event eventFound = null;
            var query = from evt in events where evt.UserId == userid select evt;
            if (query != null)
            {
                eventFound = query.ToList().First();
            }
            return eventFound;

        }
    }
}
