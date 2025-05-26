using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface IClassInLoadRepository
    {
        IEnumerable<ClassInLoad> GetByLoadId(int loadId);
        void Add(ClassInLoad cil);
        void Delete(int id);
    }
}
