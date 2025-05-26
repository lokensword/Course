using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.DataAccess.Interfaces;
using TeachingLoadApp.BusinessLogic.Interfaces;


namespace TeachingLoadApp.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Login(string login, string password)
        {
            return _userRepository.Authenticate(login, password);
        }

        public bool IsAdmin(string login)
        {
            return _userRepository.IsAdmin(login);
        }

        public int? GetUserId(string login)
        {
            return _userRepository.GetUserId(login);
        }

        public string GetRole(string login)
        {
            return _userRepository.GetRole(login);
        }
    }
}
