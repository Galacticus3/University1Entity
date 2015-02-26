using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public interface IGroupManager
    {
        IEnumerable<GroupDTO> GetGroups();
        Group GetGroupByID(int groupId);
        void InsertGroup(Group group);
        void DeleteGroup(int groupID);
        void UpdateGroup(Group group);
        void Save();
    }
}
