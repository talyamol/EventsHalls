using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IHallsService
    {
        List<Halls> GetHalls();

        Halls GetById(int id);
        Halls AddHalls(Halls hall);

        Halls UpdateHalls(int id, Halls hall);

        void DeleteHalls(int id);
    }
}
