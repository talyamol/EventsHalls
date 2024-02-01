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
        List<Event> GetEvents();

        Event GetById(int id);

        Task<Event> AddEventsAsync(Event event1);

        Event UpdateEvents(int id, Event event1);

        void DeleteEvents(int id);

    }
}
