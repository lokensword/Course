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
        private readonly IClassRepository _classRepository;

        public GroupService(IGroupRepository groupRepository, IClassRepository classRepository)
        {
            _groupRepository = groupRepository;
            _classRepository = classRepository;
        }

        public IEnumerable<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }

        public Group GetById(int id)
        {
            return _groupRepository.GetById(id);
        }

        public int Add(Group group)
        {
            return _groupRepository.Add(group);
        }

        public void Delete(int id)
        {
            _classRepository.GetAll()
                .Where(c => c.GroupId == id)
                .ToList()
                .ForEach(c => _classRepository.Delete(c.Id));

            _groupRepository.Delete(id);
        }
        public void Update(Group group)
        {
            _groupRepository.Update(group);
        }

    }
}
