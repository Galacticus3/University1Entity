using DBModels;
using DBModels.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroupSubjectRepository
    {
        private UnivrsityContext context;

        public GroupSubjectRepository(UnivrsityContext context)
        {
            this.context = context;
        }

        public virtual void Insert(GroupSubject grsubj)
        {
            context.GroupSubject.Add(grsubj);
            context.SaveChanges();
        }

        public virtual void Delete(int groupId, int subjId)
        {
            var query = from row in context.GroupSubject
                        where row.GroupId == groupId && row.SubjectId == subjId
                        select row;
            context.GroupSubject.Remove(query.FirstOrDefault());
            context.SaveChanges();
        }
        
        public IEnumerable<SubjectDTO> SubjectsByGroupID(int groupId)
        {
            var list = context.GroupSubject.Where(s => s.GroupId == groupId).Select(s => new SubjectDTO()
            {
                Name = s.Subjects.Name
            });
            return list.ToList();
        }

        public IEnumerable<GroupDTO> GroupsBySubjectID(int subjId)
        {
            var list = context.GroupSubject.Where(s => s.SubjectId == subjId).Select(s => new GroupDTO()
            {
                Name = s.Groups.Name
            });
            return list.ToList();
        }
        
    }
}
