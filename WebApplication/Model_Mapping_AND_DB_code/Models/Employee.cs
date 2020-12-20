using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model_Mapping_AND_DB_code.Models
{
    public class Employee
    {
       

        [Key]
        public int EmpNo { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Name First")]
        [StringLength(30, ErrorMessage = "{0} should be less than {1} and greater than {2} ", MinimumLength = 3)]
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptN { get; set; }
    }
}