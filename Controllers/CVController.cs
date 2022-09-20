using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADVANCED__PROGRAMMING_WITH.NET_ASSIGNMENT_CV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Info()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }
    }
}