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
    public class LoadService : ILoadService
    {
        private readonly ILoadRepository _loadRepository;
        private readonly IClassInLoadRepository _classInLoadRepository;

        public LoadService(ILoadRepository loadRepository, IClassInLoadRepository classInLoadRepository)
        {
            _loadRepository = loadRepository;
            _classInLoadRepository = classInLoadRepository;
        }

        public IEnumerable<Load> GetAll()
        {
            return _loadRepository.GetAll();
        }

        public Load GetById(int id)
        {
            return _loadRepository.GetById(id);
        }

        public int Add(Load load)
        {
            return _loadRepository.Add(load);
        }

        public void Delete(int id)
        {
            _classInLoadRepository.GetByLoadId(id)
                .ToList()
                .ForEach(cil => _classInLoadRepository.Delete(cil.Id));

            _loadRepository.Delete(id);
        }

        public IEnumerable<Load> GetByTeacherId(int teacherId)
        {
            return _loadRepository.GetByTeacherId(teacherId);
        }
        public void Update(Load load)
        {
            _loadRepository.Update(load);
        }

    }
}
