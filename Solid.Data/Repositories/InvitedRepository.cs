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
    public class InvitedRepository : IInvitedRepository
    {
        private readonly DataContext _context;
        public InvitedRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<Invited> AddInvitedAsync(Invited invited)
        {
            _context.InvitedsList.Add(invited);
            await _context.SaveChangesAsync();
            return invited;
        }

        public async Task DeleteInvitedAsync(int id)
        {
            var i = await GetByIdAsync(id);
            _context.InvitedsList.Remove(i);
            await _context.SaveChangesAsync();
        }

        public async Task<Invited> GetByIdAsync(int id)
        {
            return await _context.InvitedsList.FindAsync(id);
        }

        public async Task<IEnumerable<Invited>> GetInvitedAsync()
        {
            return await _context.InvitedsList.ToListAsync();
        }

        public async Task<Invited> UpdateInvitedAsync(int id, Invited invited)
        {
            var updateInvited = await GetByIdAsync(id);
            if (updateInvited != null)
            {
                updateInvited.IdEvent = invited.Id;
                updateInvited.Age = invited.Age;
                updateInvited.Email = invited.Email;
                updateInvited.IdEvent = invited.IdEvent;
                updateInvited.Name = invited.Name;

            }
            return updateInvited;
        }
    }
}
