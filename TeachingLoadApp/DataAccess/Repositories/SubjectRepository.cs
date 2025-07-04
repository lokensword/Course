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

        public int Add(Subject subject)
        {
            return _context.InsertWithInt32Identity(subject);
        }

        public void Delete(int id)
        {
            _context.Subjects.Delete(s => s.Id == id);
        }
        public void Update(Subject subject)
        {
            _context.Update(subject);
        }
    }
}
