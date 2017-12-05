using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace CourseManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CheckStudentInfo()
        {
            return View();
        }
        public ActionResult CheckTeacherInfo()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }
    }
}
