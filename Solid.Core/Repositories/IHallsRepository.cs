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
        Task<IEnumerable<Halls>> GetHallsAsync();

        Task<Halls> GetByIdAsync(int id);

      Task<  Halls> AddHallsAsync(Halls halls);

       Task< Halls> UpdateHallsAsync(int id, Halls halls);

        Task DeleteHallsAsync(int id);

    }
}
