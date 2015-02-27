using BLL;
using BLL.Implementations;
using DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUniversity1Entity.Controllers
{
    public class GroupsController : Controller
    {
        public GroupManager mngr;

        public GroupsController()
        {
            mngr = new GroupManager(new UnitOfWork());
        }

        // GET: Groups
        public ActionResult Index()
        {
            var groups = mngr.GetGroups();
            return View(groups);
        }

        [HttpGet]
        public ActionResult AddGroup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGroup(Group group)
        {
            mngr.InsertGroup(group);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditGroup(int id)
        {
            Group group =  mngr.GetGroupByID(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }
        [HttpPost]
        public ActionResult EditGroup(Group group)
        {
            if (ModelState.IsValid)
            {
                mngr.UpdateGroup(group);
                return RedirectToAction("Index");
            }
            return View(group);
        }

        [HttpGet]
        public ActionResult DeleteGroup(int id)
        {
            Group group = mngr.GetGroupByID(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }
        [HttpPost, ActionName("DeleteGroup")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mngr.DeleteGroup(id);
            return RedirectToAction("Index");
        }
        

    }
}