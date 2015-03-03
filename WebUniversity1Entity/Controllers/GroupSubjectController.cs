using BLL;
using BLL.Implementations;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUniversity1Entity.Controllers
{
    public class GroupSubjectController : Controller
    {
        public IGroupManager groupManager;
        public ISubjectManager subjManager;

        public GroupSubjectController(IGroupManager groupManager, ISubjectManager subjManager)
        {
            this.groupManager = groupManager;
            this.subjManager = subjManager;
        }
        
        // GET: GroupSubject
        public ActionResult Index()
        {
            
            return View();
        }


    }
}