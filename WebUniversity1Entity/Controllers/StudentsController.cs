using BLL;
using BLL.Implementations;
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
        public StudentManager studManager;
        public GroupManager groupManager;

        public StudentsController()
        {
            UnitOfWork uow = new UnitOfWork();
            studManager = new StudentManager(uow);
            groupManager = new GroupManager(uow);
        }

        // GET: Groups
        public ActionResult Index()
        {
            var students = studManager.GetStudents();
            return View(students);
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