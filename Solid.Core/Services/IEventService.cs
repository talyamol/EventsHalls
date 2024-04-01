using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IEventService
    {
       Task< IEnumerable<Event>> GetEventsAsync();

       Task< Event> GetByIdAsync(int id);
        Task<Event> AddEventsAsync(Event event1);

       Task< Event> UpdateEventsAsync(int id, Event e);

        Task DeleteEventsAsync(int id);
    }
}
