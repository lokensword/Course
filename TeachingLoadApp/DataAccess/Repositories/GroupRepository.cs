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
    public class GroupRepository : IGroupRepository
    {
        private readonly DbContext _context;

        public GroupRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<Group> GetAll()
        {
            return _context.Groups.ToList();
        }

        public Group GetById(int id)
        {
            return _context.Groups.FirstOrDefault(g => g.Id == id);
        }

        public int Add(Group group)
        {
            return _context.InsertWithInt32Identity(group);
        }

        public void Delete(int id)
        {
            _context.Groups.Delete(g => g.Id == id);
        }
        public void Update(Group group)
        {
            _context.Update(group);
        }

    }
}
