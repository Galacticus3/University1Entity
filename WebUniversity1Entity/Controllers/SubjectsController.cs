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
    public class SubjectsController : Controller
    {
        public SubjectManager subjectManager;
        public GroupSubjectManager groupsubjManager;

        public SubjectsController()
        {
            UnitOfWork uow = new UnitOfWork();
            subjectManager = new SubjectManager(uow);
            groupsubjManager = new GroupSubjectManager(uow);
        }

        // GET: Groups
        public ActionResult Index()
        {
            var subjects = subjectManager.GetSubjects();
            return View(subjects);
        }

        [HttpGet]
        public ActionResult AddSubject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSubject(Subject subject)
        {
            subjectManager.InsertSubject(subject);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSubject(int id)
        {
            Subject subject = subjectManager.GetSubjectByID(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }
        [HttpPost]
        public ActionResult EditSubject(Subject subject)
        {
            if (ModelState.IsValid)
            {
                subjectManager.UpdateSubject(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }

        [HttpGet]
        public ActionResult DeleteSubject(int id)
        {
            Subject subject = subjectManager.GetSubjectByID(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }
        [HttpPost, ActionName("DeleteSubject")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            subjectManager.DeleteSubject(id);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult DetailsSubject(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Subject subject = subjectManager.GetSubjectByID(id.Value);
            if (subject == null)
            {
                return HttpNotFound();
            }
            SubjectGroups group = new SubjectGroups();
            group.Id = id.Value;
            group.Name = subject.Name;
            group.Groups = groupsubjManager.GetGroupsBySubjectID(id.Value);
            return View(group);
        }
    }
}