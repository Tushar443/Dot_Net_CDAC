using Model_Mapping_AND_DB_code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_Mapping_AND_DB_code.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> objEmp = new List<Employee>();
            objEmp.Add(new Employee { EmpNo=1,Basic=133,DeptN=10,Name="Tushar"});
            objEmp.Add(new Employee { EmpNo=2,Basic=133,DeptN=10,Name="kishor"});
            objEmp.Add(new Employee { EmpNo=3,Basic=133,DeptN=10,Name="subahm"});
            objEmp.Add(new Employee { EmpNo=4,Basic=133,DeptN=10,Name="rohit"});
            return View(objEmp);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id=0)
        {
            Employee emp1 = new Employee();
            emp1.Basic = 123423;
            emp1.DeptN = 1;
            emp1.EmpNo = 200;
            emp1.Name = "Tushar";
            return View(emp1);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                decimal basic =emp.Basic;
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id = 0)
        {

            Employee emp1 = new Employee();
            emp1.Basic = 123423;
            emp1.DeptN = 1;
            emp1.EmpNo = 200;
            emp1.Name = "Tushar";
            return View(emp1);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id,Employee emp)
        {
            try
            {
                int empno =emp.EmpNo;
                string name = emp.Name;
                int dept =emp.DeptN;
                decimal basic = emp.Basic;

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
            Employee emp = new Employee();
            emp.Basic = 123423;
            emp.DeptN = 1;
            emp.EmpNo = 200;
            emp.Name = "Tushar";
            return View(emp);

        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
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
