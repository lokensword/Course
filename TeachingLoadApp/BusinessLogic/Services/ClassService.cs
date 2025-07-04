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
        private readonly IClassInLoadRepository _classInLoadRepository;

        public ClassService(IClassRepository classRepository, IClassInLoadRepository classInLoadRepository)
        {
            _classRepository = classRepository;
            _classInLoadRepository = classInLoadRepository;
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
            return _classRepository.Add(cls);
        }

        public void Delete(int id)
        {
            _classInLoadRepository.GetAll()
                .Where(cil => cil.ClassId == id)
                .ToList()
                .ForEach(cil => _classInLoadRepository.Delete(cil.Id));

            _classRepository.Delete(id);
        }
    }
}
