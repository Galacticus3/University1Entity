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
    public class SubjectManager
    {
        private UnivrsityContext context;
        private bool disposed = false;

     /*   public SubjectManager(UnivrsityContext context)
        {
            this.context = context;
        }*/

        public IEnumerable<SubjectDTO> GetSubjects()
        {
            var list = context.Subjects.Select(s => new SubjectDTO()
            {
                Id = s.Id,
                Name = s.Name
            });

            return list.ToList();
        }

        public Subject GetSubjectByID(int subjectId)
        {
            return context.Subjects.Find(subjectId);
        }

        public void InsertSubject(Subject subject)
        {
            context.Subjects.Add(subject);
           // Save();
        }

        public void DeleteSubject(int subjectId)
        {
            Subject subject = context.Subjects.Find(subjectId);
            context.Subjects.Remove(subject);
           // Save();
        }

        public void UpdateSubject(Subject subject)
        {
            context.Entry(subject).State = EntityState.Modified;
            //Save();
        }

       
    }
}
