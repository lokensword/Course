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
    public class FacultyRepository : IFacultyRepository
    {
        private readonly DbContext _context;

        public FacultyRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Faculty> GetAll()
        {
            return _context.Faculties.ToList();
        }

        public Faculty GetById(int id)
        {
            return _context.Faculties.FirstOrDefault(f => f.Id == id);
        }

        public int Add(Faculty faculty)
        {
            return _context.InsertWithInt32Identity(faculty);
        }

        public void Delete(int id)
        {
            _context.Faculties.Delete(f => f.Id == id);
        }
        public void Update(Faculty faculty)
        {
            _context.Update(faculty);
        }

    }
}
