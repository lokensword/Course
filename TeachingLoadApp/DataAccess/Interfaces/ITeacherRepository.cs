using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetById(int id);
        int Add(Teacher teacher);
        void Delete(int id);
        Teacher GetByUserId(int userId);
        void Update(Teacher teacher);
    }
}
