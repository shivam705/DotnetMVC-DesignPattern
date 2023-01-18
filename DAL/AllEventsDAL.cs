
using DAL.Data.DbContexts;
using DAL.EFModels;
using System.Collections.Generic;
using System.Linq;
namespace DAL
{
    public class AllEventsDAL
    {
        private readonly AssignmenttMVCContext _context;
        public AllEventsDAL(AssignmenttMVCContext context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events;
        }
    }
}
