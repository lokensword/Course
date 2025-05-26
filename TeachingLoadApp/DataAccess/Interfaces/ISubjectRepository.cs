using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();
        Subject GetById(int id);
        Subject GetByName(string name);
        int GetIdByName(string name);
        void Add(Subject subject);
        void Delete(int id);
    }
}
