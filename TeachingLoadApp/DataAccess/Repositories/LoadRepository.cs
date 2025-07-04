using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Context;
using TeachingLoadApp.DataAccess.Interfaces;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Repositories
{
    public class LoadRepository : ILoadRepository
    {
        private readonly DbContext _context;

        public LoadRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Load> GetAll()
        {
            return _context.Loads.ToList();
        }

        public Load GetById(int id)
        {
            return _context.Loads.FirstOrDefault(l => l.Id == id);
        }

        public int Add(Load load)
        {
            return _context.InsertWithInt32Identity(load);
        }

        public void Delete(int id)
        {
            _context.Loads.Delete(l => l.Id == id);
        }

        public IEnumerable<Load> GetByTeacherId(int teacherId)
        {
            return _context.Loads.Where(l => l.TeacherId == teacherId).ToList();
        }
        public void Update(Load load)
        {
            _context.Update(load);
        }

    }
}
