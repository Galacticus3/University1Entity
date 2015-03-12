using System;
namespace BLL.Interfaces
{
    public interface IStudentManager
    {
        DBModels.Student GetStudentByID(int studentId);
        System.Collections.Generic.IEnumerable<DBModels.DTO.StudentDTO> GetStudents();
        System.Collections.Generic.IEnumerable<DBModels.Student> GetStudentsGroupId();
        void InsertStudent(DBModels.Student student);
        void UpdateStudent(DBModels.Student student);
        void DeleteStudent(int studentId);
    }
}
