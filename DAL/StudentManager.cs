
using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentManager: IStudentManager, IDisposable
    {

        private UnivrsityContext context;
        private bool disposed = false;

        public StudentManager(UnivrsityContext context)
        {
            this.context = context;
        }

        public IEnumerable<StudentDTO> GetStudents()
        {
            var list = context.Students.Select(s => new StudentDTO()
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
            return context.Students.Find(studentId);
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
            Save();
        }

        public void DeleteStudent(int studentId)
        {
            Student student = context.Students.Find(studentId);
            context.Students.Remove(student);
            Save();
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
