using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModels
{
    public class GroupSubject
    {
        [Key, Column(Order = 0)]
        public int GroupId { get; set; }
        [Key, Column(Order = 1)]
        public int SubjectId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Groups { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subjects { get; set; }
    }
}
