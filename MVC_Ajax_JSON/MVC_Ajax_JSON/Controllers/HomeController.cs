using MVC_Ajax_JSON.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;

namespace MVC_Ajax_JSON.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string AjaxCallGET()
        {
            return " AjaxCallGET call ok ";
        }
        //public string AjaxCallPost(Student data)
        //{
        //  string name=  data.Name;
        //  string city = data.City;
        //  int age = data.Age;
        //    return $" Name={name} Age={age} City={city}  ";
        //}

        public ActionResult jsonClass()
        {
            return View();
        }
        public ActionResult jsonData(Student data)
        {
            Student student = new Student()
            {
                Name="Ram",
                Age=12,
                City="Kanpur Nagar"

            };

            var json=JsonConvert.SerializeObject(student); 
            return Json(json);
        }
    }
}