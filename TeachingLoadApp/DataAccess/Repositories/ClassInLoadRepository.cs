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
    public class ClassInLoadRepository : IClassInLoadRepository
    {
        private readonly DbContext _context;

        public ClassInLoadRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<ClassInLoad> GetAll()
        {
            return _context.ClassInLoads.ToList();
        }

        public ClassInLoad GetById(int id)
        {
            return _context.ClassInLoads.FirstOrDefault(c => c.Id == id);
        }

        public int Add(ClassInLoad classInLoad)
        {
            return _context.InsertWithInt32Identity(classInLoad);
        }

        public void Delete(int id)
        {
            _context.ClassInLoads.Delete(c => c.Id == id);
        }

        public IEnumerable<ClassInLoad> GetByLoadId(int loadId)
        {
            return _context.ClassInLoads.Where(c => c.LoadId == loadId).ToList();
        }
    }
}
