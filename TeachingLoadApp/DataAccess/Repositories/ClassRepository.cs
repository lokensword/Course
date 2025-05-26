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

        public void Add(Class cls)
        {
            _context.Classes.InsertOnSubmit(cls);
            _context.SubmitChanges();
        }

        public void Delete(int id)
        {
            var cls = _context.Classes.FirstOrDefault(c => c.Id == id);
            if (cls != null)
            {
                _context.Classes.DeleteOnSubmit(cls);
                _context.SubmitChanges();
            }
        }
    }
}
