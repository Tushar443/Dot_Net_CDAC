using HTML_Helper_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helper_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id = 0)
        {
            Employee e = new Employee();
            e.EmpNo = 1;
            e.EmpName = "Tushar";
            e.DeptNo = 10;
            e.Basic = 2443;

            List<SelectListItem> objList = new List<SelectListItem> {

                new SelectListItem {Text ="IT",Value ="10" },
                new SelectListItem {Text ="EXTC",Value ="20" },
                new SelectListItem {Text ="COM",Value ="30" },
                new SelectListItem {Text ="MKG",Value ="40" },
            };

            e.DepartmentsAll = objList;
            return View(e);

        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id=0)
        {
            Employee e = new Employee();
            e.EmpNo = 1;
            e.EmpName = "Tushar";
            e.DeptNo = 10;
            e.Basic = 2443;

            List<SelectListItem> objList = new List<SelectListItem> {

                new SelectListItem {Text ="IT",Value ="10" },
                new SelectListItem {Text ="EXTC",Value ="20" },
                new SelectListItem {Text ="COM",Value ="30" },
                new SelectListItem {Text ="MKG",Value ="40" },
            };

            e.DepartmentsAll = objList;
            return View(e);
            
        }

        // POST: Employee/Edit/5
        [HttpPost]  
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
