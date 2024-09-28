using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Main(Cred data) 
        {
            try 
            {
                using(MvcEntities1 context = new MvcEntities1())
                {


                var user = new Cred
                {
                    Age = data.Age,
                    Email = data.Email,
                    Name = data.Name,
                };
               

                context.Cred.Add(user);
                var result = context.SaveChanges();
         
          
                }
            }

            catch { }

            return View();

        }
      

    }
}