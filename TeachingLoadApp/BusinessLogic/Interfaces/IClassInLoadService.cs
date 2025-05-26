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
        IEnumerable<ClassInLoad> GetByLoadId(int loadId);
        int Add(ClassInLoad cil);
        void Delete(int id);
    }
}
