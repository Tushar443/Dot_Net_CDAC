using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Mapping_AND_DB_code.Models
{
    public class Employee
    {
        private int empNo;
        private string empName;
        private decimal empBasic;
        private int deptNo;

        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptN { get; set; }
    }
}