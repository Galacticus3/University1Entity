﻿using DBModels.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DBModels;

namespace BLL.Implementations
{
    public class StudentManager : BaseManager, IStudentManager
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

        public IEnumerable<Student> GetStudentsGroupId()
        {
            return uof.StudentRepository.Get();
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
