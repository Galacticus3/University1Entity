using BLL.Implementations;
using BLL;
using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;


namespace BLL.Implementations
{
    public class GroupManager : BaseManager, IGroupManager
    {
        public GroupManager(UnitOfWork uof) : base(uof) { }     
        
       public IEnumerable<GroupDTO> GetGroups()
        {
           var list = uof.GroupRepository.All.Select(s => new GroupDTO()
            {
                Id = s.Id,
                Name = s.Name
            });

            return list.ToList();
        }

        public Group GetGroupByID(int groupId)
        {
            return uof.GroupRepository.GetByID(groupId);
        }

        public void InsertGroup(Group group)
        {
            uof.GroupRepository.Insert(group);
            uof.Save();
          
        }

        public void DeleteGroup(int groupId)
        {
            uof.GroupRepository.Delete(groupId);
            uof.Save();
        }

        public void UpdateGroup(Group group)
        {
            uof.GroupRepository.Update(group);
            uof.Save();
        }
        
       
    }

}
