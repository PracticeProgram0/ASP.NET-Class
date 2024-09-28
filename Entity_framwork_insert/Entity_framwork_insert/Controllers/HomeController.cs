using Entity_framwork_insert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Entity_framwork_insert;



namespace Entity_framwork_insert.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home
        public ActionResult Details()
        {
            using(var context = new MvcEntities1())
            {
               var data = context.@base.ToList();
               return View(data);
            }
        }


/*

        [HttpPost]
        public ActionResult Index(Student data)
        {
            DataLayar dl = new DataLayar();
            if (data != null)
            {
                int result = dl.DataInsert(data);
                if (result > 0)
                {
                    ViewBag.name = "data insert";
                }

               
            }
            return View();
        }

        public ActionResult GetAllData()
        { 
          DataLayar dL = new DataLayar();
            var data = dL.SelectallData();
            return View(dL);
        }*/
    }
}