using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiniProject.Models

{
    public class User
    {
       
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key()]
        public int UserId { get; set; }
        public string LogInName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }
        public string Phone { get; set; }

        public bool IsActive { get; set; }
    }
}