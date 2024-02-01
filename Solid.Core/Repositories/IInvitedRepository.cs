using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IInvitedRepository
    {
        List<Invited> GetInvited();

        Invited GetById(int id);

        Invited AddInvited(Invited invited);

        Invited UpdateInvited(int id, Invited invited);

        void DeleteInvited(int id);

    }
}
