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
    public class ClassInLoadService : IClassInLoadService
    {
        private readonly IClassInLoadRepository _classInLoadRepository;

        public ClassInLoadService(IClassInLoadRepository classInLoadRepository)
        {
            _classInLoadRepository = classInLoadRepository;
        }

        public IEnumerable<ClassInLoad> GetAll()
        {
            return _classInLoadRepository.GetAll();
        }

        public ClassInLoad GetById(int id)
        {
            return _classInLoadRepository.GetById(id);
        }

        public int Add(ClassInLoad classInLoad)
        {
            return _classInLoadRepository.Add(classInLoad);
        }

        public void Delete(int id)
        {
            _classInLoadRepository.Delete(id);
        }

        public IEnumerable<ClassInLoad> GetByLoadId(int loadId)
        {
            return _classInLoadRepository.GetByLoadId(loadId);
        }
    }
}
