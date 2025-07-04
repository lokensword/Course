using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface IUserService
    {
        IEnumerable<AppUser> GetAll();
        AppUser GetById(int id);
        int Add(AppUser user);
        void Delete(int id);
    }
}
