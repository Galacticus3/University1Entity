using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ISubjectManager : IDisposable
    {
        IEnumerable<SubjectDTO> GetSubjects();
        Student GetSubjectByID(int subjectId);
        void InsertSubject(Subject subject);
        void DeleteSubject(int subjectID);
        void UpdateSubject(Subject subject);
        void Save();
    }
}
