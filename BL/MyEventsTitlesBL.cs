using DAL;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MyEventsTitlesBL
    {
        private readonly MyEventsDAL _myeventsDal;

        public MyEventsTitlesBL(MyEventsDAL myEventsDAL)
        {
            _myeventsDal = myEventsDAL;
        }

        public IEnumerable<Event> GetMyEvents(string userEmail)
        {

            return _myeventsDal.GetMyEvents(userEmail);

            //return myEvents;

        }
    }
}
