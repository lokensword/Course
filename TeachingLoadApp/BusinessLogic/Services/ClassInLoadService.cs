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

        public IEnumerable<ClassInLoad> GetByLoadId(int loadId)
        {
            return _classInLoadRepository.GetByLoadId(loadId);
        }

        public int Add(ClassInLoad cil)
        {
            _classInLoadRepository.Add(cil);
            return cil.Id;
        }

        public void Delete(int id)
        {
            _classInLoadRepository.Delete(id);
        }
    }
}
