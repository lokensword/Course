using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface ILoadRepository
    {
        IEnumerable<Load> GetAll();
        Load GetById(int id);
        int Add(Load load);
        void Delete(int id);
        IEnumerable<Load> GetByTeacherId(int teacherId);
        void Update(Load load);

    }
}
