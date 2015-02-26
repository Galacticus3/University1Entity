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
    public class SubjectManager : BaseManager
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

        public SubjectDTO GetSubjectByID(int subjectId)
        {
            var item = uof.SubjectRepository.GetByID(subjectId);
            return new SubjectDTO()
            {
                Id = item.Id,
                Name = item.Name
            };
            
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
