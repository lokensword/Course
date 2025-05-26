using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.BusinessLogic.Interfaces;
using TeachingLoadApp.DataAccess.Interfaces;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly IFacultyRepository _facultyRepository;

        public FacultyService(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public IEnumerable<Faculty> GetAll()
        {
            return _facultyRepository.GetAll();
        }

        public Faculty GetById(int id)
        {
            return _facultyRepository.GetById(id);
        }

        public int Add(Faculty faculty)
        {
            _facultyRepository.Add(faculty);
            return faculty.Id;
        }

        public void Delete(int id)
        {
            _facultyRepository.Delete(id);
        }
    }
}