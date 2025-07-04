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
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILoadRepository _loadRepository;
        private readonly IClassInLoadRepository _classInLoadRepository;

        public TeacherService(  ITeacherRepository teacherRepository,
                                ILoadRepository loadRepository,
                                IClassInLoadRepository classInLoadRepository)
        {
            _teacherRepository = teacherRepository;
            _loadRepository = loadRepository;
            _classInLoadRepository = classInLoadRepository;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public Teacher GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }

        public int Add(Teacher teacher)
        {
            return _teacherRepository.Add(teacher);
        }

        public void Delete(int id)
        {
            var loads = _loadRepository.GetByTeacherId(id);

            foreach (var load in loads)
            {
                _classInLoadRepository.GetByLoadId(load.Id)
                    .ToList()
                    .ForEach(cil => _classInLoadRepository.Delete(cil.Id));

                _loadRepository.Delete(load.Id);
            }

            _teacherRepository.Delete(id);
        }

        public Teacher GetByUserId(int userId)
        {
            return _teacherRepository.GetByUserId(userId);
        }
        public void Update(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
    }
}
