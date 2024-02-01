using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class HallsRepository : IHallsRepository
    {
        private readonly DataContext _context;
        public HallsRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public Halls AddHalls(Halls halls)
        {
            _context.HallsList.Add(halls);
            _context.SaveChanges();
            return halls;
        }

        public void DeleteHalls(int id)
        {
            _context.HallsList.Remove(_context.HallsList.ToList().Find(x => x.Id == id));
            _context.SaveChanges();
        }

        public Halls GetById(int id)
        {
            return _context.HallsList.ToList().Find(x => x.Id == id);
        }

        public List<Halls> GetHalls()
        {
            return _context.HallsList.ToList();
        }

        public Halls UpdateHalls(int id, Halls halls)
        {
            var updateHalls = _context.HallsList.ToList().Find(x => x.Id == id);
            if (updateHalls != null)
            {
                updateHalls.Id = halls.Id;
                updateHalls.HallPhone = halls.HallPhone;
                updateHalls.CountParticipants = halls.CountParticipants;
                updateHalls.Street = halls.Street;
                updateHalls.Name = halls.Name;
                updateHalls.City = halls.City;
                _context.SaveChanges();
                return updateHalls;
            }
            return null;
        }
    }
}
