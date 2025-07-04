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
        private readonly IGroupRepository _groupRepository;
        private readonly IClassRepository _classRepository;

        public FacultyService(IFacultyRepository facultyRepository, IGroupRepository groupRepository, IClassRepository classRepository)
        {
            _facultyRepository = facultyRepository;
            _groupRepository = groupRepository;
            _classRepository = classRepository;
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
            return _facultyRepository.Add(faculty);
        }

        public void Delete(int id)
        {
            var groups = _groupRepository.GetAll().Where(g => g.FacultyId == id).ToList();

            foreach (var group in groups)
            {
                _classRepository.GetAll()
                    .Where(c => c.GroupId == group.Id)
                    .ToList()
                    .ForEach(c => _classRepository.Delete(c.Id));

                _groupRepository.Delete(group.Id);
            }

            _facultyRepository.Delete(id);
        }
        public void Update(Faculty faculty)
        {
            _facultyRepository.Update(faculty);
        }

    }
}