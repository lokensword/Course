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

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public IEnumerable<Subject> GetAll()
        {
            return _subjectRepository.GetAll();
        }

        public Subject GetById(int id)
        {
            return _subjectRepository.GetById(id);
        }

        public Subject GetByName(string name)
        {
            return _subjectRepository.GetByName(name);
        }

        public int GetIdByName(string name)
        {
            return _subjectRepository.GetIdByName(name);
        }

        public int Add(Subject subject)
        {
            _subjectRepository.Add(subject);
            return subject.Id;
        }

        public void Delete(int id)
        {
            _subjectRepository.Delete(id);
        }
    }
}
