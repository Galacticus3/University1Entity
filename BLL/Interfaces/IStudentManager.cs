using System;
namespace BLL.Interfaces
{
    public interface IStudentManager
    {
        void DeleteStudent(int studentId);
        DBModels.Student GetStudentByID(int studentId);
        System.Collections.Generic.IEnumerable<DTO.StudentDTO> GetStudents();
        void InsertStudent(DBModels.Student student);
        void UpdateStudent(DBModels.Student student); 
    }
}
