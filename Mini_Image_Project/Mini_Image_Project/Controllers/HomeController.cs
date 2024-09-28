using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_Image_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 50)]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveImage(string Name, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileName = file.FileName;
                var extenstion = Path.GetExtension(fileName);
                if (extenstion == ".jpg" || extenstion == ".png")
                {
                    var minimgesize = 90 * 1024 * 1024;
                    if (minimgesize >= file.ContentLength)
                    {
                        var folderpath = Server.MapPath("~/Content/UserImg/");
                        var filePath = folderpath + fileName;
                        file.SaveAs(filePath);
                        ViewBag.ImgName = fileName;

                        //insertion Code In DB  : Name And Image Name

                    }
                    else
                    {
                        ViewBag.errormsg = " Please Upload Minimam 5 Md Images ";

                    }

                }
                else
                {
                    ViewBag.errormsg = " Please Upload jpg or png Images ";


                }
            }

            return View("Index");

        }
    }
}