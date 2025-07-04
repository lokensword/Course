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
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IClassRepository _classRepository;

        public SubjectService(ISubjectRepository subjectRepository, IClassRepository classRepository)
        {
            _subjectRepository = subjectRepository;
            _classRepository = classRepository;
        }

        public IEnumerable<Subject> GetAll()
        {
            return _subjectRepository.GetAll();
        }

        public Subject GetById(int id)
        {
            return _subjectRepository.GetById(id);
        }

        public int Add(Subject subject)
        {
            return _subjectRepository.Add(subject);
        }

        public void Delete(int id)
        {
            _classRepository.GetAll()
                .Where(c => c.SubjectId == id)
                .ToList()
                .ForEach(c => _classRepository.Delete(c.Id));

            _subjectRepository.Delete(id);
        }
        public void Update(Subject subject)
        {
            _subjectRepository.Update(subject);
        }

    }
}
