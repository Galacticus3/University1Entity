using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IGroupManager : IDisposable
    {
        IEnumerable<GroupDTO> GetGroups();
        Group GetGroupByID(int groupId);
        void InsertGroup(Group group);
        void DeleteGroup(int groupID);
        void UpdateGroup(Group group);
        void Save();
    }
}
