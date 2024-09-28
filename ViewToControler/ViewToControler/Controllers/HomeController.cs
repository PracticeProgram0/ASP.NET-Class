using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
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
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
            }





            Registration rag = new Registration()
            {
                Firstname = data.Firstname,
               Lastname= data.Lastname,
               Email=data.Email,
               Phone=data.Phone,
               Address=data.Address,
               City=data.City,
               State=data.State,
               Zip=data.Zip,
               Password=data.Password,
               ConfirmPassword=data.ConfirmPassword
            };

            


            return View(rag); 
          
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