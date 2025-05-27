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
        public IEnumerable<Load> GetAll()
        {
            return _context.Loads.ToList();
        }

        public LoadRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Load> GetByTeacherId(int teacherId)
        {
            return _context.Loads.Where(l => l.TeacherId == teacherId).ToList();
        }

        public IEnumerable<Load> GetBySemester(string semester)
        {
            return _context.Loads.Where(l => l.Semestr == semester).ToList();
        }

        public Load GetById(int id)
        {
            return _context.Loads.FirstOrDefault(l => l.Id == id);
        }

        public void Add(Load load)
        {
            _context.Loads.InsertOnSubmit(load);
            _context.SubmitChanges();
        }
        // Каскадное удаление Load-ClassInLoad
        public void Delete(int id)
        {
            using (var transaction = _context.Connection.BeginTransaction())
            {
                _context.Transaction = transaction;

                try
                {
                    var links = _context.ClassInLoads.Where(cl => cl.LoadId == id);
                    _context.ClassInLoads.DeleteAllOnSubmit(links);

                    var load = _context.Loads.FirstOrDefault(l => l.Id == id);
                    if (load != null)
                        _context.Loads.DeleteOnSubmit(load);

                    _context.SubmitChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
