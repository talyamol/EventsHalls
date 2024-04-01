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

        public async Task< Invited > AddInvitedAsync(Invited invited)
        {
            return await _invitedRepository.AddInvitedAsync(invited);
        }

        public async Task DeleteInvitedAsync(int id)
        {
          await  _invitedRepository.DeleteInvitedAsync(id);
        }

        public async Task< Invited> GetByIdAsync(int id)
        {
            return await _invitedRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Invited>> GetInvitedAsync()
        {
            return await _invitedRepository.GetInvitedAsync();
        }

        public async Task< Invited> UpdateInvitedAsync(int id, Invited invited)
        {
            return await UpdateInvitedAsync(id, invited);
        }
    }
}
