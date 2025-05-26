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

        public LoadService(ILoadRepository loadRepository)
        {
            _loadRepository = loadRepository;
        }

        public IEnumerable<Load> GetByTeacherId(int teacherId)
        {
            return _loadRepository.GetByTeacherId(teacherId);
        }

        public IEnumerable<Load> GetBySemester(string semester)
        {
            return _loadRepository.GetBySemester(semester);
        }

        public Load GetById(int id)
        {
            return _loadRepository.GetById(id);
        }

        public int Add(Load load)
        {
            _loadRepository.Add(load);
            return load.Id;
        }

        public void Delete(int id)
        {
            _loadRepository.Delete(id);
        }
    }
}
