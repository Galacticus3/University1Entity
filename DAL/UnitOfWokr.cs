using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWokr
    {
        private UnivrsityContext context;

        private GroupManager groupRep;
        private SubjectManager subjRep;
        private StudentManager studRep;
        private GroupSubjectManager grsubjRep;

        public UnitOfWokr()
        {
            context = new UnivrsityContext();
            groupRep = new GroupManager(context);
            subjRep = new SubjectManager(context);
            studRep = new StudentManager(context);
            grsubjRep = new GroupSubjectManager(context);
        }

        public GroupManager GroupManager
        {
            get { return this.groupRep; }
        }

        public SubjectManager SubjectManager
        {
            get { return this.subjRep; }
        }

        public StudentManager StudentManager
        {
            get { return this.studRep; }
        }

        public GroupSubjectManager GroupSubjectManager
        {
            get { return this.grsubjRep; }
        }

    }
}
