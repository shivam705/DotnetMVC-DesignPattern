using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.EFModels;

namespace BL
{
    public class AllEventsBL
    {
        private readonly AllEventsDAL _alleventsDal;

        public AllEventsBL(AllEventsDAL allEventsDAL)
        {
            _alleventsDal = allEventsDAL;
        }


        public IEnumerable<Event> GetAllEvents()
        {
            return _alleventsDal.GetAllEvents();
        }

    }
}
