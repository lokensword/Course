using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Context;
using TeachingLoadApp.DataAccess.Interfaces;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<AppUser> GetAll()
        {
            return _context.Users.ToList();
        }

        public AppUser GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public int Add(AppUser user)
        {
            return _context.InsertWithInt32Identity(user);
        }

        public void Delete(int id)
        {
            _context.Users.Delete(u => u.Id == id);
        }
    }
}
