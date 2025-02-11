using m1g2_2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace m1g2_2025.Controllers
{
    public class Employees1Controller : Controller
    {
        m1gl2Context db = new m1gl2Context();
        // GET: Home 
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(db.employees.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Employee emp)
        {
            db.employees.Add(emp);
            db.SaveChanges();
            return Json(1, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetbyID(int ID)
        {
            var Employee = db.employees.ToList().Find(x => x.EmployeeID.Equals(ID));
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Employee emp)
        {
            Employee e = db.employees.Find(emp.EmployeeID);
            e.Age = emp.Age;
            e.Country = emp.Country;
            e.State = emp.State;
            e.Name = emp.Name;
            db.SaveChanges();
            return Json(1, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int ID)
        {
            Employee e = db.employees.Find(ID);
            db.employees.Remove(e);
            db.SaveChanges();
            return Json(0, JsonRequestBehavior.AllowGet);
        }
    }
}