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
    public class ClassRepository : IClassRepository
    {
        private readonly DbContext _context;

        public ClassRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Class> GetAll()
        {
            return _context.Classes.ToList();
        }

        public Class GetById(int id)
        {
            return _context.Classes.FirstOrDefault(c => c.Id == id);
        }

        public int Add(Class cls)
        {
            return _context.InsertWithInt32Identity(cls);
        }

        public void Delete(int id)
        {
            _context.Classes.Delete(c => c.Id == id);
        }
    }
}
