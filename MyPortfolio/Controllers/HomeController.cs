using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
         PortfolioDB DB = new PortfolioDB();
        public ActionResult Index()
        {
            ViewBag.section1 =DB.section1Divs.Find(1);
            ViewBag.workCat = DB.CategoryWork.ToList();
            ViewBag.workList = DB.MyWorksDiv.ToList();
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
    }
}