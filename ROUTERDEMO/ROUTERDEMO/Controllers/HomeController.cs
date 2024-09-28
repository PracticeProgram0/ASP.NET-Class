using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROUTERDEMO.Controllers
{
    [RoutePrefix("vivek")]
    public class HomeController : Controller
    {
        //[Route("Demo")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("btps")]
        [Route("~/ji")]
        public ActionResult about()
        {
            return View();
        }
        [Route("con")]
        public ActionResult contect()
        {
            return View();
        }
    }
}