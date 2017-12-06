using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManagementSystem.Models;

namespace CourseManagementSystem.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult ChooseSchool()
        {
            
            return View();
        }
        public ActionResult ChooseSchool1()
        {
            return View();
        }
        public ActionResult ChooseSchool2()
        {
            return View();
        }
        public ActionResult CreateSchoolUI()
        {
            return View();
        }

    }
}