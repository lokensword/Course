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

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public Teacher GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }

        public Teacher GetByUserId(int userId)
        {
            return _teacherRepository.GetByUserId(userId);
        }

        public int Add(Teacher teacher)
        {
            _teacherRepository.Add(teacher);
            return teacher.Id;
        }

        public void Delete(int id)
        {
            _teacherRepository.Delete(id);
        }
    }
}
