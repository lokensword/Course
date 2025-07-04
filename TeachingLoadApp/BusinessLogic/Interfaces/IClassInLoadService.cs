using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface IClassInLoadService
    {
        IEnumerable<ClassInLoad> GetAll();
        ClassInLoad GetById(int id);
        int Add(ClassInLoad classInLoad);
        void Delete(int id);
        IEnumerable<ClassInLoad> GetByLoadId(int loadId);
    }
}
