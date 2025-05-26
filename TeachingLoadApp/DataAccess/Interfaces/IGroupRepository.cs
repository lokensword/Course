using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetAll();
        Group GetById(int id);
        IEnumerable<Group> GetByFacultyId(int facultyId);
        void Add(Group group);
        void Delete(int id);
    }
}
