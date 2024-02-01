using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IHallsRepository
    {
        List<Halls> GetHalls();

        Halls GetById(int id);

        Halls AddHalls(Halls halls);

        Halls UpdateHalls(int id, Halls halls);

        void DeleteHalls(int id);

    }
}
