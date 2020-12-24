using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetExam.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Rate { get; set; }

        public string  Description { get; set; }

        public int CatergoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

    }
}