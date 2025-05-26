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
    public class SubjectRepository : ISubjectRepository
    {
        private readonly DbContext _context;

        public SubjectRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects.ToList();
        }

        public Subject GetById(int id)
        {
            return _context.Subjects.FirstOrDefault(s => s.Id == id);
        }

        public Subject GetByName(string name)
        {
            return _context.Subjects.FirstOrDefault(s => s.Name == name);
        }

        public int GetIdByName(string name)
        {
            var subject = _context.Subjects.FirstOrDefault(s => s.Name == name);
            return subject?.Id ?? -1;
        }

        public void Add(Subject subject)
        {
            _context.Subjects.InsertOnSubmit(subject);
            _context.SubmitChanges();
        }
       // Тоже каскадное удаление предмет-занятия
        public void Delete(int id)
        {
            using (var transaction = _context.Connection.BeginTransaction())
            {
                _context.Transaction = transaction;

                try
                {
                    var classes = _context.Classes.Where(c => c.SubjectId == id);
                    _context.Classes.DeleteAllOnSubmit(classes);

                    var subject = _context.Subjects.FirstOrDefault(s => s.Id == id);
                    if (subject != null)
                        _context.Subjects.DeleteOnSubmit(subject);

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
