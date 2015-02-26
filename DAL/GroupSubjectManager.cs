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
    public class GroupSubjectManager
    {
        private UnivrsityContext context;
        private bool disposed = false;

        public GroupSubjectManager(UnivrsityContext context)
        {
            this.context = context;
        }

        public IEnumerable<GroupSubjectDTO> GetGroupSubject()
        {
            var list = context.GroupSubject.Select(s => new GroupSubjectDTO()
            {
                GrId = s.GroupId,
                SbjId = s.SubjectId,
                GroupName = s.Groups.Name,
                SubjectName = s.Subject.Name
            });

            return list.ToList();
        }
        
        public GroupSubject GetGroupByID(int groupId)
        {
          
            return context.GroupSubject.Find(groupId);
        }
    

        public void InsertGroupSubject(GroupSubject grsubj)
        {
            context.GroupSubject.Add(grsubj);
            Save();
        }

        public void DeleteGroupSubject(int groupId, int subjId)
        {
            var query = from row in context.GroupSubject                                           
                        where row.GroupId  == groupId && row.SubjectId == subjId
                        select row;

            context.GroupSubject.Remove(query.FirstOrDefault());
            Save();
        }

        public void UpdateGroup(GroupSubject grsubj)
        {
            context.Entry(grsubj).State = EntityState.Modified;
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
