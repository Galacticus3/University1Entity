using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGroupSubjectManager
    {
        void InsertGroupSubject(GroupSubject grsubj);
        void DeleteGroupSubject(int groupId, int subjId);
        IEnumerable<SubjectDTO> GetSubjectsByGroupID(int groupId);
        IEnumerable<GroupDTO> GetGroupsBySubjectID(int subjId); 
    }
}
