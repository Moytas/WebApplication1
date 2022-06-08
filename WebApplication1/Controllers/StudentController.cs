using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };

        public ActionResult Index()
        {
            //fetch students from the DB using Entity Framework here

            return View(studentList.OrderBy(s => s.StudentId).ToList());
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            { //checking model state

                //update student to db

                return RedirectToAction("Index");
            }
            return View(std);
        }

        //[HttpPost]
        //public ActionResult Edit(Student std)
        //{
        //    //update student in DB using EntityFramework in real-life application

        //    //update list by removing old student and adding updated student for demo purpose
        //    var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
        //    studentList.Remove(student);
        //    studentList.Add(std);

        //    return RedirectToAction("Index");
        //}
        //// GET: Student
        //public ActionResult Index()
        //{
        //    //fetch students from the DB using Entity Framework here

        //    return View(studentList);
        //}

        //[HttpPost]
        //public ActionResult Edit([Bind(Include = "StudentId, StudentName")] Student std)
        //{
        //    var name = std.StudentName;

        //    //write code to update student 

        //    return RedirectToAction("Index");
        //}


        //[HttpPost]
        //public ActionResult Edit(FormCollection collection)
        //{
        //    var id = collection["StudentName"];
        //    //var name = std.StudentName;
        //    //var age = std.Age;
        //    //var standardName = std.standard.StandardName;

        //    //update database here..

        //    return RedirectToAction("Index");
        //}
        //[HttpPost]
        //public ActionResult Edit(Student std)
        //{
        //    var id = std.StudentId;
        //    var name = std.StudentName;
        //    var age = std.Age;
        //    var standardName = std.standard.StandardName;

        //    //update database here..

        //    return RedirectToAction("Index");
        //}

        //// GET: Student
        //public string Index()
        //{
        //    return "This is Index action method of StudentController";
        //}

        //public string About()
        //{
        //    return "This is the about";
        //}

        //[AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        //public ActionResult PostAction() // handles POST requests by default
        //{
        //    return View("Index");
        //}

        //[ActionName("Find")]
        //public ActionResult GetById(int id)
        //{
        //    // get student from the database 
        //    return View();
        //}

        ////public string Home()
        ////{
        ////    return "Home";
        ////}
    }
}