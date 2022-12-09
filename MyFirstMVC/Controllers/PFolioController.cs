using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC.Controllers
{
    public class PFolioController : Controller
    {
        // GET: PFolio
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Soram()
        {
            return View();
        }
        public ActionResult Skills()
        {
            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
        public ActionResult Hobby()
        {
            return View();
        }
       
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult BasicDetail()
        {
            return View();
        }
    }
}