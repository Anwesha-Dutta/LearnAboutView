using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAboutView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Action Mehod
        public ActionResult Index()
        {
            //return View("Rename");
            return View("~/Views/MyView/MyNewView.cshtml");
        }

        //Action Method
        public ViewResult AboutUS()
        {
            return View();
        }

        public ActionResult WithoutView()
        {
            return View();
        }
    }
}