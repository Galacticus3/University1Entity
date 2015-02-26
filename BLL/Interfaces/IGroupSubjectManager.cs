using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGroupSubjectManager : IDisposable
    {
        IEnumerable<GroupSubjectDTO> GetGroupSubject();
        Student GetStudentByID(int groupSubjectId);
        void InsertGroupSubject(GroupSubject groupSubject);
        void DeleteGroupSubject(int studentID);
        void UpdateGroupSubject(GroupSubject groupSubject);
        void Save();
    }
}
