using model_bulid_in_html_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace model_bulid_in_html_helper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {

            var data = new Student()
            {
                name = "BTPS",
                Age = 20,
                phone = "1212121212",
                IsPass = true,
            };
            return View(data);

           
        }
    }
}