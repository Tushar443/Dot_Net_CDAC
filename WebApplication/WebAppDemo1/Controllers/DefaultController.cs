using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppDemo1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //One Parameter
        public ActionResult Index(int id=0)
        {
            ViewBag.Id = id;
            return View();
        }

        public string Thunder()
        {
            return "<h1>Hello Thunder </ h1 >";
        }

        public ActionResult MyView()
        {
            return View();
        }
        public ActionResult Multiple(int id=0,int a=0,decimal b=0,string name="")
        {
            ViewBag.Id = id;
            ViewBag.Basic = b;
            ViewBag.Name = name;
            ViewBag.EmpId = a;
            return View();
        }
    }
}