using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model08_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HelloWord()
        {
            ViewBag.message = "HelloWorld:" + DateTime.Now.ToString();
            return PartialView(); //cannot us Layout
        }

        public ActionResult HelloWord2(string username)
        {
            ViewBag.message = "HelloWorld:" +username + DateTime.Now.ToString();
            return PartialView("HelloWord"); //cannot us Layout
        }
    }
}