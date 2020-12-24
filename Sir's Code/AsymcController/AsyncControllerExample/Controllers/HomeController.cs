using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsyncControllerExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    ServiceReference1.Service1Client o = new ServiceReference1.Service1Client();
        //    ViewBag.retval =  o.DoWork();
        //    return View();
        //}
        public ActionResult Index()
        {
            ServiceReference1.Service1Client o = new ServiceReference1.Service1Client();

            o.DoWorkCompleted += O_DoWorkCompleted;
            o.DoWorkAsync();
            return View();
        }

        private void O_DoWorkCompleted(object sender, ServiceReference1.DoWorkCompletedEventArgs e)
        {
            ViewBag.retval = e.Result;
        }
    }
}