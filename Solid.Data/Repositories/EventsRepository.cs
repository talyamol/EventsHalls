using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EventsRepository: IEventRepository
    {
        private readonly DataContext _context;
        public EventsRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<Event> AddEventsAsync(Event event1)
        {
            _context.EventList.Add(event1);
          await  _context.SaveChangesAsync();
            return event1;
        }

        public async Task DeleteEventsAsync(int id)
        {
            var e=await GetByIdAsync(id);
            _context.EventList.Remove(e);
           await _context.SaveChangesAsync();
        }

        public async Task<Event> GetByIdAsync(int id)
        {
            return await _context.EventList.FindAsync(id);
        }

        public async Task< IEnumerable<Event>> GetEventsAsync()
        {
            return await _context.EventList.ToListAsync();
            //return _context.EventList.Include(e => e.Inviteds);

        }

        public async Task< Event> UpdateEventsAsync(int id, Event event1)
        {
            var updateEvents = await GetByIdAsync(id);
            if (updateEvents != null)
            {
              //  updateEvents.StartHour = event1.StartHour;
                updateEvents.CountInvited = event1.CountInvited;
                updateEvents.MinAge = event1.MinAge;
               // updateEvents.Date = event1.Date;
                updateEvents.HallId = event1.HallId;
                updateEvents.Id = event1.Id;
                updateEvents.Name = event1.Name;
                _context.SaveChangesAsync();
                
            }
            return updateEvents;
        }
    }
}
