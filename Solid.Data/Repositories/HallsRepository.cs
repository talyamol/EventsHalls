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
    public class HallsRepository : IHallsRepository
    {
        private readonly DataContext _context;
        public HallsRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<Halls> AddHallsAsync(Halls halls)
        {
            _context.HallsList.Add(halls);
            await _context.SaveChangesAsync();
            return  halls;
        }

        public async Task DeleteHallsAsync(int id)
        {
            var h=await GetByIdAsync(id);
            _context.HallsList.Remove(h);
           await _context.SaveChangesAsync();
        }

        public async Task<Halls> GetByIdAsync(int id)
        {
            return await _context.HallsList.FindAsync( id);
        }

        public async Task< IEnumerable<Halls>> GetHallsAsync()
        {
            return await _context.HallsList.ToListAsync();
        }

        public async Task< Halls> UpdateHallsAsync(int id, Halls halls)
        {
            var updateHalls = await GetByIdAsync(id);
            if (updateHalls != null)
            {
                updateHalls.Id = halls.Id;
                updateHalls.HallPhone = halls.HallPhone;
                updateHalls.CountParticipants = halls.CountParticipants;
                updateHalls.Street = halls.Street;
                updateHalls.Name = halls.Name;
                updateHalls.City = halls.City;
                _context.SaveChangesAsync();
                
            }
            return updateHalls;
        }
    }
}
