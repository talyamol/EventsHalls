using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEventRepository
    {
       Task< IEnumerable<Event> >GetEventsAsync();

       Task< Event> GetByIdAsync(int id);

        Task<Event> AddEventsAsync(Event event1);

        Task<Event> UpdateEventsAsync(int id, Event event1);

        Task DeleteEventsAsync(int id);

    }
}
