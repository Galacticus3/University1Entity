using BLL;
using BLL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUniversity1Entity.Controllers
{
    public class GroupSubjectController : Controller
    {
        public GroupManager groupManager;
        public SubjectManager subjManager;

        public GroupSubjectController()
        {
            UnitOfWork uow = new UnitOfWork();
            groupManager = new GroupManager(uow);
            subjManager = new SubjectManager(uow);
        }
        
        // GET: GroupSubject
        public ActionResult Index()
        {
            
            return View();
        }


    }
}