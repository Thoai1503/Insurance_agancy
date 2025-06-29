using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance_Agency_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
        {
            Session["display"] = 0;
            ViewBag.Message = "Your services page.";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your privacy policy page.";
            return View();
        }
        public ActionResult Feature()
        {
            ViewBag.Message = "Your privacy policy page.";
            return View();
        }
        public ActionResult Team()
        {
            ViewBag.Message = "Your privacy policy page.";
            return View();
        }
        public ActionResult Testimonial()
        {
            ViewBag.Message = "Your privacy policy page.";
            return View();
        }
        public ActionResult DemoForm()
        {
            ViewBag.Message = "Your privacy policy page.";
            return View();
        }
        public ActionResult TextEditor()
        {
            ViewBag.Message = "Your text editor page.";
            return View();
        }
        public ActionResult Insurance()
        {
            Session["allbanner"] = 0;
         //   Session["display"] = 0;
            ViewBag.Message = "Your insurance page.";
            return View();
        }
    }
}