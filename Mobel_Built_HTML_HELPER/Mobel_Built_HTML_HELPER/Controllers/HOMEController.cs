using Mobel_Built_HTML_HELPER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobel_Built_HTML_HELPER.Controllers
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult Index()
        {
            Student student = new Student();

            return View();
        }
        public ActionResult StudentInfo()
        {
            var data = StudentData();
            return View(data);
        }
       
        public Student StudentData()
        {
            Student studentData = new Student();
            studentData.Id = 1;
            studentData.Name = "Btps";
            studentData.Age = 30;
            studentData.Phone = "432443424";


            return studentData;
        }


        public ActionResult InlineHtmlHelper()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    
}
}