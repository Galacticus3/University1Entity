using DBModels;
using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class StudentManager : BaseManager
    {

        public StudentManager(UnitOfWork uof) : base(uof) { }     

        public IEnumerable<StudentDTO> GetStudents()
        {
            var list = uof.StudentRepository.All.Select(s => new StudentDTO()
            {
                Id = s.Id,
                Name = s.Name,
                Age = s.Age,
                GroupName = s.Groups.Name
            });
            return list.ToList();
        }

        public Student GetStudentByID(int studentId)
        {
            return uof.StudentRepository.GetByID(studentId);
        }

        public void InsertStudent(Student student)
        {
            uof.StudentRepository.Insert(student);
            uof.Save();
        }

        public void DeleteStudent(int studentId)
        {
            uof.StudentRepository.Delete(studentId);
            uof.Save();
        }

        public void UpdateStudent(Student student)
        {
            uof.StudentRepository.Update(student);
            uof.Save();
        }

      
        
    }
}
