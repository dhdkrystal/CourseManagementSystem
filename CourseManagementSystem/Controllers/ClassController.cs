using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManagementSystem.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult ClassManage()
        {
            ViewBag.ClassNum = 3;
            ViewBag.CourseName = "OOAD";
            ViewBag.SeminarName = "讨论课4";
            ViewBag.Time = "11月6日-11月12日";
            ViewBag.GroupType = "固定分组";
            return View();
        }

        public ActionResult Class(string GroupType)
        {
            if (GroupType == "随机分组")
                Response.Redirect("RandomRollStartCall");
            else
                Response.Redirect("FixedRollStartCall");
            return View();
        }
        public ActionResult FixedRollStartCall()
        {
            return View();
        }
        public ActionResult CheckGroup()
        {
            Response.Redirect("FixedGroupInfo");
            return View();
        }
        public ActionResult FixedGroupInfo()
        {
            return View();
        }
        public ActionResult Start()
        {
            Response.Redirect("FixedRollCall");
            return View();
        }

        public ActionResult FixedRollCall()
        {
            return View();
        }
        public ActionResult CheckListTmp()
        {
            Response.Redirect("RollCallList");
            return View();
        }
        public ActionResult RollCallList()
        {
            return View();
        }
        public ActionResult End()
        {
            Response.Redirect("FixedEndRollCall");
            return View();
        }
        public ActionResult FixedEndRollCall()
        {
            return View();
        }
        public ActionResult CheckList()
        {
            Response.Redirect("FixedRollCallEnd");
            return View();
        }
        public ActionResult FixedRollCallEnd()
        {
            return View();
        }
        public ActionResult GroupInfo()
        {
            return View();
        }
        public ActionResult RandomRollStartCall()
        {
            return View();
        }
        public ActionResult RandomEndRollCall()
        {
            return View();
        }
        public ActionResult RandomRollCall()
        {
            return View();
        }
    }
}