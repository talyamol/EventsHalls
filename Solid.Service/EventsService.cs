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
        public async Task< Event> GetByIdAsync(int id)
        {
            return await _eventsRepository.GetByIdAsync(id);
        }

        public async Task< IEnumerable<Event>> GetEventsAsync()
        {
            return await _eventsRepository.GetEventsAsync();
        }
        public async Task<Event> AddEventsAsync(Event event1)
        {
            return  await _eventsRepository.AddEventsAsync(event1);
        }

        public async Task< Event> UpdateEventsAsync(int id, Event e)
        {
            return await _eventsRepository.UpdateEventsAsync(id, e);
        }

        public async Task DeleteEventsAsync(int id)
        {
           await _eventsRepository.DeleteEventsAsync(id);
        }

    }
}
