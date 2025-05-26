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

        public IEnumerable<ClassInLoad> GetByLoadId(int loadId)
        {
            return _context.ClassInLoads.Where(cl => cl.LoadId == loadId).ToList();
        }

        public void Add(ClassInLoad cil)
        {
            _context.ClassInLoads.InsertOnSubmit(cil);
            _context.SubmitChanges();
        }

        public void Delete(int id)
        {
            var cil = _context.ClassInLoads.FirstOrDefault(cl => cl.Id == id);
            if (cil != null)
            {
                _context.ClassInLoads.DeleteOnSubmit(cil);
                _context.SubmitChanges();
            }
        }
    }
}
