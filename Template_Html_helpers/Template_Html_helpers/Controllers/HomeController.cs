using System;
using System.Web.Mvc;
using Template_Html_helpers.Models;

namespace Template_Html_helpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Create and initialize the Employee object
            Employee emp = new Employee
            {
                Id = 1,
                Name = "Sundaram Rsjpoot",
                DateofBirth = DateTime.Now, 
                Email = "fghgggg@gmail.com",
                Isonline = true 
            };

            // Pass the Employee object to the view
            return View(emp);
        }
    }
}
