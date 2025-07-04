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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly ILoadRepository _loadRepository;
        private readonly IClassInLoadRepository _classInLoadRepository;

        public UserService( IUserRepository userRepository, 
                            ITeacherRepository teacherRepository,
                            ILoadRepository loadRepository,
                            IClassInLoadRepository classInLoadRepository)
        {
            _userRepository = userRepository;
            _teacherRepository = teacherRepository;
            _loadRepository = loadRepository;
            _classInLoadRepository = classInLoadRepository;
        }

        public IEnumerable<AppUser> GetAll()
        {
            return _userRepository.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public int Add(AppUser user)
        {
            return _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            var teacher = _teacherRepository.GetByUserId(id);
            if (teacher != null)
            {
                var loads = _loadRepository.GetByTeacherId(teacher.Id);
                foreach (var load in loads)
                {
                    _classInLoadRepository.GetByLoadId(load.Id)
                        .ToList()
                        .ForEach(cil => _classInLoadRepository.Delete(cil.Id));

                    _loadRepository.Delete(load.Id);
                }

                _teacherRepository.Delete(teacher.Id);
            }

            _userRepository.Delete(id);
        }
    }
}
