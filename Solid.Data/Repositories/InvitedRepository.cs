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
        public Invited AddInvited(Invited invited)
        {
            _context.InvitedsList.ToList().Add(invited);
            return invited;
        }

        public void DeleteInvited(int id)
        {
            _context.InvitedsList.ToList().Remove(_context.InvitedsList.ToList().Find(x => x.Id == id));
        }

        public Invited GetById(int id)
        {
            return _context.InvitedsList.ToList().Find(x => x.Id == id);
        }

        public List<Invited> GetInvited()
        {
            return _context.InvitedsList.ToList();
        }

        public Invited UpdateInvited(int id, Invited invited)
        {
            var updateInvited = _context.InvitedsList.ToList().Find(x => x.Id == id);
            if (updateInvited != null)
            {
                updateInvited.IdEvent = invited.Id;
                updateInvited.Age = invited.Age;
                updateInvited.Email = invited.Email;
                updateInvited.IdEvent = invited.IdEvent;
                updateInvited.Name = invited.Name;
                return updateInvited;
            }
            return null;
        }
    }
}
