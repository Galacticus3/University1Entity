using System;
namespace BLL.Interfaces
{
    public interface IStudentManager
    {
        void DeleteStudent(int studentId);
        DBModels.Student GetStudentByID(int studentId);
        System.Collections.Generic.IEnumerable<DTO.StudentDTO> GetStudents();
        System.Collections.Generic.IEnumerable<DBModels.Student> GetStudentsGroupId();
        void InsertStudent(DBModels.Student student);
        void UpdateStudent(DBModels.Student student); 
    }
}
