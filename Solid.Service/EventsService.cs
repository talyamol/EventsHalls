using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;
using Solid.Core.Entities;
using Solid.Core.Services;

namespace Solid.Service
{
    public class EventsService:IEventService
    {
        private readonly IEventRepository _eventsRepository;

        public EventsService(IEventRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }
        public Event GetById(int id)
        {
            return _eventsRepository.GetById(id);
        }

        public List<Event> GetEvents()
        {
            return _eventsRepository.GetEvents();
        }
        public async Task<Event> AddEventsAsync(Event event1)
        {
            return  await _eventsRepository.AddEventsAsync(event1);
        }

        public Event UpdateEvents(int id, Event e)
        {
            return _eventsRepository.UpdateEvents(id, e);
        }

        public void DeleteEvents(int id)
        {
            _eventsRepository.DeleteEvents(id);
        }

    }
}
