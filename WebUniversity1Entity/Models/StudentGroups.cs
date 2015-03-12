using DBModels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUniversity1Entity.Models
{
    public class StudentGroups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        public List<GroupDTO> Groups { get; set; }
    }
}