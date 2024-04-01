using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IInvitedService
    {
        Task<IEnumerable<Invited>> GetInvitedAsync();

        Task<Invited> GetByIdAsync(int id);
        Task<Invited> AddInvitedAsync(Invited invited);

        Task<Invited> UpdateInvitedAsync(int id, Invited invited);

        Task DeleteInvitedAsync(int id);

    }
}
