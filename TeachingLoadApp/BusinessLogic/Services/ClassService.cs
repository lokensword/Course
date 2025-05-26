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
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public IEnumerable<Class> GetAll()
        {
            return _classRepository.GetAll();
        }

        public Class GetById(int id)
        {
            return _classRepository.GetById(id);
        }

        public int Add(Class cls)
        {
            _classRepository.Add(cls);
            return cls.Id;
        }

        public void Delete(int id)
        {
            _classRepository.Delete(id);
        }
    }
}
