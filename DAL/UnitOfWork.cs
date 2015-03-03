using DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnitOfWork
    {
        private UnivrsityContext context;

        private GenericRepository<Group> groupRep;
        private GenericRepository<Subject> subjRep;
        private GenericRepository<Student> studRep;
        //private GenericRepository<GroupSubject> grsubjRep;
        private GroupSubjectRepository grsubjRep;

        public UnitOfWork()
        {
            context = new UnivrsityContext();
            groupRep = new GenericRepository<Group>(context);
            subjRep = new GenericRepository<Subject>(context);
            studRep = new GenericRepository<Student>(context);
            grsubjRep = new GroupSubjectRepository(context);
        }

        public GenericRepository<Group> GroupRepository
        {
            get
            {
                if (groupRep == null) groupRep = new GenericRepository<Group>(context);
                return groupRep;
            }
        }

        public GenericRepository<Subject> SubjectRepository
        {
            get
            {
                if (subjRep == null) subjRep = new GenericRepository<Subject>(context);
                return subjRep;
            }
        }

        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (studRep == null) studRep = new GenericRepository<Student>(context);
                return studRep;
            }
        }

        public GroupSubjectRepository GroupSubjectRepository
        {
            get
            {
                if (grsubjRep == null) grsubjRep = new GroupSubjectRepository(context);
                return grsubjRep;
            }
        }

              
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

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
