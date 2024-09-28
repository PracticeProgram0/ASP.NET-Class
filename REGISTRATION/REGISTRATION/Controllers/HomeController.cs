using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace REGISTRATION.Controllers
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
        public ActionResult RegistrationByModel()
        {
            //Registration rag = new Registration()
            //{
            //    Firstname = data.Firstname,
            //    Lastname = data.Lastname,
            //    Email = data.Email,
            //    Phone = data.Phone,
            //    Address = data.Address,
            //    City = data.City,
            //    State = data.State,
            //    Zip = data.Zip,
            //    Password = data.Password,
            //    ConfirmPassword = data.ConfirmPassword
            //};

            return View();
        }
        [HttpPost]       

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
       

    }
}