using Solid.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;


namespace Solid.Service
{
    public class HallsService:IHallsService
    {
        private readonly IHallsRepository _hallsRepository;

        public HallsService(IHallsRepository hallsRepository)
        {
            _hallsRepository = hallsRepository;
        }
        public async Task< Halls> GetByIdAsync(int id)
        {
            return await _hallsRepository.GetByIdAsync(id);
        }

        public async Task< IEnumerable<Halls>> GetHallsAsync()
        {
            return await _hallsRepository.GetHallsAsync();
        }
        public async Task< Halls> AddHallsAsync(Halls hall)
        {
            return await _hallsRepository.AddHallsAsync(hall);
        }

        public async Task< Halls> UpdateHallsAsync(int id, Halls h)
        {
            return await _hallsRepository.UpdateHallsAsync(id, h);
        }

        public async Task DeleteHallsAsync(int id)
        {
           await _hallsRepository.DeleteHallsAsync(id);
        }
    }
}
