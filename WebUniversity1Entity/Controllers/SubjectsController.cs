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
    public class SubjectsController : Controller
    {
        public SubjectManager mnsbj;

        public SubjectsController()
        {
            mnsbj = new SubjectManager(new UnitOfWork());
        }

        // GET: Groups
        public ActionResult Index()
        {
            var subjects = mnsbj.GetSubjects();
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
            mnsbj.InsertSubject(subject);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSubject(int id)
        {
            Subject subject = mnsbj.GetSubjectByID(id);
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
                mnsbj.UpdateSubject(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }

        [HttpGet]
        public ActionResult DeleteSubject(int id)
        {
            Subject subject = mnsbj.GetSubjectByID(id);
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
            mnsbj.DeleteSubject(id);
            return RedirectToAction("Index");
        }
    }
}