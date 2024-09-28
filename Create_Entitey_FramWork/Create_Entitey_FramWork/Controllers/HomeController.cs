using Create_Entitey_FramWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Create_Entitey_FramWork.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student data)
        {   using (var DbContext = new MvcEntities())
            {
                var entitydata = new Entitey()
                {
                    name = data.name,
                    age = data.age,
                    phone = data.phone,
                };
                DbContext.Entiteys.Add(entitydata);
                DbContext.SaveChanges();

            }
                return View();
        }
    }
}