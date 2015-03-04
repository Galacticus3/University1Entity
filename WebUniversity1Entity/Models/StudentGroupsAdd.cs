using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUniversity1Entity.Models
{
    public class StudentGroupsAdd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public IEnumerable<GroupDTO> Groups { get; set; }
        public IEnumerable<StudentDTO> Students { get; set; }
    }
}