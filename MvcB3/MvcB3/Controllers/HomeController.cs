using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcB3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // ViewBag
            ViewBag.Username = "SUNDARAM";
            
            ViewData["Password"] = "RAJPOOT";
            var Userstatus = 7;
            if (Userstatus == 7)
            {
                ViewBag.User = "ok";
            }
            else
            {
                ViewBag.User = "Not ok"; 
            }




            return View("about");
        }
        
        public ActionResult about()
        {
            return View("~/views/Homet/index.cshtml");
        }

        public ActionResult Contact() {
        
        return View("about");
        }
        public string emp(string name)
        {
            return name;
        }
        public string student(string id, string name)
        {
            return $"id is :{id} and name is :{name}";
        }
        public string student1(int id,string name,string roll)
        {
            return $"id is {id} and name is {name} and roll no is{roll}";
        }
    }

}