using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.BusinessLogic.Interfaces
{
    public interface IUserService
    {
        bool Login(string login, string password);
        bool IsAdmin(string login);
        int? GetUserId(string login);
        string GetRole(string login);
    }
}
