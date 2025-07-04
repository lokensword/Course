using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface IGroupService
    {
        IEnumerable<Group> GetAll();
        Group GetById(int id);
        int Add(Group group);
        void Delete(int id);
        void Update(Group group);

    }
}

