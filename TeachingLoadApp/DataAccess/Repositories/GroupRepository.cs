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

        public IEnumerable<Group> GetByFacultyId(int facultyId)
        {
            return _context.Groups.Where(g => g.FacultyId == facultyId).ToList();
        }

        public void Add(Group group)
        {
            _context.Groups.InsertOnSubmit(group);
            _context.SubmitChanges();
        }
        // Удаление группы - удаление занятий (конкретных, я бы даже сказал дискретных) группы
        public void Delete(int id)
        {
            using (var transaction = _context.Connection.BeginTransaction())
            {
                _context.Transaction = transaction;

                try
                {
                    var classes = _context.Classes.Where(c => c.GroupId == id);
                    _context.Classes.DeleteAllOnSubmit(classes);

                    var group = _context.Groups.FirstOrDefault(g => g.Id == id);
                    if (group != null)
                        _context.Groups.DeleteOnSubmit(group);

                    _context.SubmitChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
