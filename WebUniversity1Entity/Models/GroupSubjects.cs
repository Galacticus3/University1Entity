using DBModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUniversity1Entity.Models
{
    public class GroupSubjects
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<SubjectDTO> Subjects { get; set; }
    }
}