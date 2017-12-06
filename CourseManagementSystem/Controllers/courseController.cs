using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult CourseInfoUI()
        {
            return View();
        }
        public ActionResult CourseUI()
        {
            return View();
        }
    }
}