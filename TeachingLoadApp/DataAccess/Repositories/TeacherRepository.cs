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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DbContext _context;

        public TeacherRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetById(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.Id == id);
        }

        public Teacher GetByUserId(int userId)
        {
            return _context.Teachers.FirstOrDefault(t => t.UserId == userId);
        }

        public void Add(Teacher teacher)
        {
            _context.Teachers.InsertOnSubmit(teacher);
            _context.SubmitChanges();
        }
        // Gj cenb j,hnrf lkz rfcrflyjuj e;fktybz ghtgjlfdfntkm - yfuheprf b pfgbcm dj dcgjvjufntkmyjq nf,kbwt
        public void Delete(int id)
        {
            using (var transaction = _context.Connection.BeginTransaction())
            {
                _context.Transaction = transaction;

                try
                {
                    var loads = _context.Loads.Where(l => l.TeacherId == id).ToList();

                    foreach (var load in loads)
                    {
                        var classLinks = _context.ClassInLoads.Where(cl => cl.LoadId == load.Id);
                        _context.ClassInLoads.DeleteAllOnSubmit(classLinks);
                    }

                    _context.Loads.DeleteAllOnSubmit(loads);

                    var teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
                    if (teacher != null)
                        _context.Teachers.DeleteOnSubmit(teacher);

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
