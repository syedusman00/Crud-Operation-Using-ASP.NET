using crud.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_Entities dbobj = new db_Entities();

        public ActionResult Student()
        {
            return View();
        }

       [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            obj.Name = model.Name;
            obj.Fname = model.Fname;
            obj.Email = model.Email;
            obj.Mobile = model.Mobile;
            obj.Description = model.Description;

            dbobj.tbl_Student.Add(obj);
            dbobj.SaveChanges();

            return View();
        }




    }

}