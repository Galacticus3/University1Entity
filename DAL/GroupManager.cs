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
    public class GroupManager : IGroupManager, IDisposable
    {
        private UnivrsityContext context;
        private bool disposed = false;

        public GroupManager(UnivrsityContext context)
        {
            this.context = context;
        }

        public IEnumerable<GroupDTO> GetGroups()
        {
            var list = context.Groups.Select(s => new GroupDTO()
            {
                Id = s.Id,
                Name = s.Name
            });

            return list.ToList();
        }

        public Group GetGroupByID(int groupId)
        {
            return context.Groups.Find(groupId);
        }

        public void InsertGroup(Group group)
        {
            context.Groups.Add(group);
            Save();
        }

        public void DeleteGroup(int groupId)
        {
            Group group = context.Groups.Find(groupId);
            context.Groups.Remove(group);
            Save();
        }

        public void UpdateGroup(Group group)
        {
            context.Entry(group).State = EntityState.Modified;
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
