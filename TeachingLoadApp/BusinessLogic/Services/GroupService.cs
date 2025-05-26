using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.BusinessLogic.Interfaces;
using TeachingLoadApp.DataAccess.Interfaces;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.BusinessLogic.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public IEnumerable<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }

        public Group GetById(int id)
        {
            return _groupRepository.GetById(id);
        }

        public IEnumerable<Group> GetByFacultyId(int facultyId)
        {
            return _groupRepository.GetByFacultyId(facultyId);
        }

        public int Add(Group group)
        {
            _groupRepository.Add(group);
            return group.Id;
        }

        public void Delete(int id)
        {
            _groupRepository.Delete(id);
        }
    }
}
