using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetById(int id);
        Teacher GetByUserId(int userId);
        int Add(Teacher teacher);
        void Delete(int id);
    }
}
