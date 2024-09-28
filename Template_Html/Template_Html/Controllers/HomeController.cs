using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template_Html.Models;

namespace Template_Html.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = new student()
            {
                name = "btps",
                age=14,
                city="panki "

            };
            return View(data);
        }
        

        public ActionResult StudentInfo(int id)
        {
            return View();
        }



    }
}