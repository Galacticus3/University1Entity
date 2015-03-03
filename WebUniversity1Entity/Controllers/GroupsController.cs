using BLL;
using BLL.Implementations;
using DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUniversity1Entity.Models;

namespace WebUniversity1Entity.Controllers
{
    public class GroupsController : Controller
    {
        public GroupManager groupManager;
        public GroupSubjectManager groupsubjManager;

        public GroupsController()
        {
            UnitOfWork uow = new UnitOfWork();
            groupManager = new GroupManager(uow);
            groupsubjManager = new GroupSubjectManager(uow);
        }

        // GET: Groups
        public ActionResult Index()
        {
            var groups = groupManager.GetGroups();
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
            groupManager.InsertGroup(group);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditGroup(int id)
        {
            Group group =  groupManager.GetGroupByID(id);
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
                groupManager.UpdateGroup(group);
                return RedirectToAction("Index");
            }
            return View(group);
        }

        [HttpGet]
        public ActionResult DeleteGroup(int id)
        {
            Group group = groupManager.GetGroupByID(id);
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
            groupManager.DeleteGroup(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DetailsGroup(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Group group = groupManager.GetGroupByID(id.Value);
            if (group == null)
            {
                return HttpNotFound();
            }
            GroupSubjects subject = new GroupSubjects();
            subject.Id = id.Value;
            subject.Name = group.Name;
            subject.Subjects = groupsubjManager.GetSubjectsByGroupID(id.Value);

            return View(subject);
        }
    }
}