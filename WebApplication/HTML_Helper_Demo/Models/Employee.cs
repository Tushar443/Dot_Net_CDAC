using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helper_Demo.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

        public bool IsActive { get; set; }
        public IEnumerable<SelectListItem> DepartmentsAll { get; set; }
    }
}