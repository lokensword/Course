using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface IClassRepository
    {
        IEnumerable<Class> GetAll();
        Class GetById(int id);
        int Add(Class cls);
        void Delete(int id);
    }
}
