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
            IEnumerable<GroupDTO> groups = null;
            try
            {
                groups = groupManager.GetGroups();
            } 
            catch(Exception ex) 
            {
                this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }

            return groups;
        }

        [HttpPost]
        public HttpResponseMessage InsertGroupApi(Group group)
        {
            try
            {
                groupManager.InsertGroup(group);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut]
        public HttpResponseMessage UpdateGroupApi(Group group)
        {
            try
            {
                groupManager.UpdateGroup(group);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public HttpResponseMessage DeleteGroupApi(int id)
        {
            try
            {
                groupManager.DeleteGroup(id);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
