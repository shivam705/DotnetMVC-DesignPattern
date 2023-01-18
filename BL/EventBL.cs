
using DAL;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    public class EventBL
    {
        private readonly EventDAL _eventDal;

        public EventBL(EventDAL eventDAL)
        {
            _eventDal = eventDAL;
        }

        public Event GetEvent(int userId)
        {
            return _eventDal.GetEvent(userId);
        }
    }
}
