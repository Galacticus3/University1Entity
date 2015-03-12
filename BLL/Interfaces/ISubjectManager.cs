using System;
namespace BLL.Interfaces
{
    public interface ISubjectManager
    {
        void DeleteSubject(int subjectId);
        DBModels.Subject GetSubjectByID(int subjectId);
        System.Collections.Generic.IEnumerable<DBModels.DTO.SubjectDTO> GetSubjects();
        void InsertSubject(DBModels.Subject subject);
        void UpdateSubject(DBModels.Subject subject); 
    }
}
