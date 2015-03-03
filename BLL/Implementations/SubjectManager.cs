﻿using DBModels;
using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;


namespace BLL.Implementations
{
    public class SubjectManager : BaseManager, ISubjectManager
    {
        public SubjectManager(UnitOfWork uof) : base(uof) { }     

        public IEnumerable<SubjectDTO> GetSubjects()
        {
            var list = uof.SubjectRepository.All.Select(s => new SubjectDTO()
            {
                Id = s.Id,
                Name = s.Name
            });

            return list.ToList();
        }

        public Subject GetSubjectByID(int subjectId)
        {
            return uof.SubjectRepository.GetByID(subjectId);   
        }

        public void InsertSubject(Subject subject)
        {
            uof.SubjectRepository.Insert(subject);
            uof.Save();
        }

        public void DeleteSubject(int subjectId)
        {
            uof.SubjectRepository.Delete(subjectId);
            uof.Save();
        }

        public void UpdateSubject(Subject subject)
        {
            uof.SubjectRepository.Update(subject);
            uof.Save();
        }

       
    }
}
