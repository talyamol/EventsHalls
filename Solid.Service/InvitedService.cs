using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class InvitedService: IInvitedService
    {
        private readonly IInvitedRepository _invitedRepository;

        public InvitedService(IInvitedRepository invitedRepository)
        {
            _invitedRepository = invitedRepository;
        }

        public Invited AddInvited(Invited invited)
        {
            return _invitedRepository.AddInvited(invited);
        }

        public void DeleteInvited(int id)
        {
            _invitedRepository.DeleteInvited(id);
        }

        public Invited GetById(int id)
        {
            return _invitedRepository.GetById(id);
        }

        public List<Invited> GetInvited()
        {
            return _invitedRepository.GetInvited();
        }

        public Invited UpdateInvited(int id, Invited invited)
        {
            return UpdateInvited(id, invited);
        }
    }
}
