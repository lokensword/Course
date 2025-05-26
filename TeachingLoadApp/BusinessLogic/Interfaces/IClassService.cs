using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface IClassService
    {
        IEnumerable<Class> GetAll();
        Class GetById(int id);
        int Add(Class cls);
        void Delete(int id);
    }
}
