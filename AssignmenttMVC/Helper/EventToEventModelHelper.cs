using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EFModels;
using AssignmenttMVC.Model;
using System.Threading.Tasks;
using AutoMapper;


namespace AssignmenttMVC.Helper
{
    public class EventToEventModelHelper
    {
        public EventsModel EventToEventModelMapping(Event e)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Event, EventsModel>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<Event, EventsModel>(source);
            return destination;
        }

        public IEnumerable<EventsModel> GetEventModels(IEnumerable<Event> events)
        {
            List<EventsModel> eventModels = new List<EventsModel>();
            foreach (var item in events)
            {
                eventModels.Add(EventToEventModelMapping(item));
            }
            return eventModels;

        }
    }
}
