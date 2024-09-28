using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using ViewToControler.databse;
using ViewToControler.Models;

namespace ViewToControler.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RegistrationByModel( Registration data)
        {
            using(var context = new MvcEntities())
            {
                var newdata = new Registration_MVC
                {
                    FIRSTNAME = data.Firstname,
                    LASTNAME = data.Lastname,
                    EMAIL = data.Email,
                    ADDRESS = data.Address,
                    PHONE = data.Phone,
                    PASSWORD = data.Password,
                    STATE = data.State,
                    CITY = data.City,
                    ZIP = data.Zip


                };

                context.Registration_MVC.Add(newdata);
                var result = context.SaveChanges();

            }

            return View(); 
          
        }



        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "Btps" && password == "1234")
            {
                return View();
            }           
            return RedirectToAction("Index");    

        }
        public ActionResult LoginByFormController(FormCollection data)
        {
            string username = data["username"];
            string password = data["password"];

            if (username == "Btps" && password == "1234")
            {
                return View();
            }
            return RedirectToAction("Index");        
        }

        public ActionResult LoginByModel(Login data)
        {
            string username = data.Username;
            string password = data.Password;
            if (username == "ram" && password == "seeta")
            {
                return View();
            }
            return RedirectToAction("Index");
        }
        public ActionResult about()
        {
            return View();
        }

        
    }
}