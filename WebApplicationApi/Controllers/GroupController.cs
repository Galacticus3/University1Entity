using BLL;
using BLL.Implementations;
using BLL.Interfaces;
using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationApi.Controllers
{
    public class GroupController : ApiController
    {
        public GroupManager groupManager;

        public GroupController()
        {
            this.groupManager = new GroupManager(new UnitOfWork());
        }

        [HttpGet]
        public IEnumerable<GroupDTO> GetGroupsApi()
        {
            return groupManager.GetGroups();
        }

        [HttpPut]
        public void InsertGroupApi(Group group)
        {
            groupManager.InsertGroup(group);
        }
    }
}
