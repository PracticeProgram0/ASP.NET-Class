using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            ViewData["Massage1"]="Data comes form ViewData";
            ViewBag.Massage2 = "Data comes form ViewBag";

            ViewData["CurrentDate"]= DateTime.Now.ToString();
            ViewBag.Current2= DateTime.Now.ToString();

            string[] games = { "Hockey", "football", "Cricket", "Baseball" };
            ViewData["GamesArray"] = games;
            ViewBag.GamesArray2 = games;


            return View();
        }
    }
}