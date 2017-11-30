using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Student_MainUI()
        { return View(); }

        public ActionResult Teacher_MainUI()
        { return View(); }

    }
}