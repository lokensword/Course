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
        Subject GetByName(string name);
        int GetIdByName(string name);
        int Add(Subject subject);
        void Delete(int id);
    }
}
