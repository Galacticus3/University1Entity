using BLL;
using BLL.Implementations;
using BLL.Interfaces;
using DBModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUniversity1Entity.Models;

namespace WebUniversity1Entity.Controllers
{
    
    public class StudentsController : Controller
    {
        public IStudentManager studManager;
        public IGroupManager groupManager;

        public StudentsController(IStudentManager studManager, IGroupManager groupManager)
        {
            this.studManager = studManager;
            this.groupManager = groupManager;
        }

        // GET: Groups
        public ActionResult Index()
        {
            //var students = studManager.GetStudents();

            var model = new StudentGroupsAdd();
            model.Students = studManager.GetStudents();
            model.Groups = groupManager.GetGroups().ToList(); 
            return View(model);
        }


        [HttpGet]
        public ActionResult AddStudent()
        {
            StudentGroups model = new StudentGroups();
            model.Groups = groupManager.GetGroups().ToList(); 
            return View(model);
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            studManager.InsertStudent(student);
            return RedirectToAction("Index");
            
        }

        [HttpPost]
        public ActionResult AjaxAddStudent(Student student)
        {
            studManager.InsertStudent(student);

            var model = new StudentGroupsAdd();
            model.Students = studManager.GetStudents();
            return Json(model.Students);
        }
        


        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            Student student =  studManager.GetStudentByID(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            StudentGroups model = new StudentGroups();
            model.Name = student.Name;
            model.Age = student.Age;
            model.GroupId = student.GroupId;
            model.Groups = groupManager.GetGroups().ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult EditStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                studManager.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }


        [HttpGet]
        public ActionResult DeleteStudent(int id)
        {
            Student student = studManager.GetStudentByID(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost, ActionName("DeleteStudent")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            studManager.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}