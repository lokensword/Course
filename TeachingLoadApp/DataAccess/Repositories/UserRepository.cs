using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Context;
using TeachingLoadApp.DataAccess.Interfaces;

namespace TeachingLoadApp.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public bool Authenticate(string login, string password)
        {
            return _context.Users.Any(u => u.Login == login && u.Password == password);
        }

        public bool IsAdmin(string login)
        {
            return _context.Users.Any(u => u.Login == login && u.Role == "admin");
        }

        public int? GetUserId(string login)
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == login);
            return user?.Id;
        }

        public string GetRole(string login)
        {
            return _context.Users
                .Where(u => u.Login == login)
                .Select(u => u.Role)
                .FirstOrDefault();
        }
    }
}
