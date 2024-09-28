using Crud_in_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_in_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult jsonData()
        {
            student student = new student()
            {
                Name= "sundaram rajpoot",
                Age = 34,
                Phone = "1338665656",
                IsPass = "true"
            };
            var 
            return View();
        }
    }
}