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
       Task< IEnumerable<Halls>> GetHallsAsync();

       Task< Halls> GetByIdAsync(int id);
       Task< Halls> AddHallsAsync(Halls hall);

        Task<Halls> UpdateHallsAsync(int id, Halls hall);

        Task DeleteHallsAsync(int id);
    }
}
