using AssignmenttMVC.Model;
using AutoMapper;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmenttMVC.Helper
{
    public class EventModelToEventHelper
    {
        public Event EventModelToEventMapping(EventsModel e)
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<EventsModel, Event>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<EventsModel, Event>(source);
            return destination;
        }

        public IEnumerable<Event> GetEvent(IEnumerable<EventsModel> eventModels)
        {
            List<Event> events = new List<Event>();
            foreach (var item in eventModels)
            {
                events.Add(EventModelToEventMapping(item));
            }
            return events;

        }
    }
}
