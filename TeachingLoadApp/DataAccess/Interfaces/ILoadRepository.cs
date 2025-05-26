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
        IEnumerable<Load> GetByTeacherId(int teacherId);
        IEnumerable<Load> GetBySemester(string semester);
        Load GetById(int id);
        void Add(Load load);
        void Delete(int id);
    }
}
