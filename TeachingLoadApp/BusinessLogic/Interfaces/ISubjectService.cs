using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface ISubjectService
    {
        IEnumerable<Subject> GetAll();
        Subject GetById(int id);
        int Add(Subject subject);
        void Delete(int id);
        void Update(Subject subject);
    }
}
