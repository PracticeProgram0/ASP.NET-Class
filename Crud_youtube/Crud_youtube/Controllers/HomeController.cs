using Crud_youtube.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_youtube.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        { 
            EmpoyeeDBContext db = new EmpoyeeDBContext();
            List<Employee> obj = db.GetEmployees();
            return View(obj);
        }

        public ActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
           try
            {
                if (ModelState.IsValid == true)
                {
                    EmpoyeeDBContext context = new EmpoyeeDBContext();
                    bool check = context.AddEmployee(emp);
                    if (check == true)
                    {
                        TempData["InsertMassage"] = "Data has been Inserted successfuly";
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }

            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            EmpoyeeDBContext context = new EmpoyeeDBContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(int id,Employee emp)
        {

            if (ModelState.IsValid == true)
            {
                EmpoyeeDBContext context = new EmpoyeeDBContext();
                bool check = context.AddEmployee(emp);
                if (check == true)
                {
                    TempData["UpdateMassage"] = "Data has been Update successfuly";
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            EmpoyeeDBContext context = new EmpoyeeDBContext();
            var row = context.GetEmployees().Find(model =>model.id == id);
            return View(row);
        }
        [HttpPost]
        public ActionResult Delete(int id,Employee emp)
        {

            EmpoyeeDBContext context = new EmpoyeeDBContext();
            bool check = context.DeleteEmployee(id);
            if (check == true)
            {
                TempData["DeleteMassage"] = "Data has been Update successfuly";
                return RedirectToAction("Index");
            }

            return View();
        }
    }

}