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

        public int Add(Teacher teacher)
        {
            return _context.InsertWithInt32Identity(teacher);
        }

        public void Delete(int id)
        {
            _context.Teachers.Delete(t => t.Id == id);
        }

        public Teacher GetByUserId(int userId)
        {
            return _context.Teachers.FirstOrDefault(t => t.UserId == userId);
        }
        public void Update(Teacher teacher)
        {
            _context.Update(teacher);
        }
    }
}
