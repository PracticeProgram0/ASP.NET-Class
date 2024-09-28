using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCB2.Controllers
{
    public class HometController : Controller
    {
        public ActionResult Index()
        {
            TempData["U1"] = "User1";
            return View();
        }

        public ActionResult About()
        {
            var userCount = TempData["U1"];
            TempData.Keep("U1");
            ViewBag.userCount = userCount;
            return View();
        }

        public ActionResult Contact()
        {
            var userCount = TempData.Peek("U1");
            ViewBag.userCount = userCount;
            return View();
        }
    }
}