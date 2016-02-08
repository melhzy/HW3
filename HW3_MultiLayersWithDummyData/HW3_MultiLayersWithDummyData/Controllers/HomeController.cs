using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataAccessLayer;
using Models;

namespace HW3_MultiLayersWithDummyData.Controllers
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

        public ActionResult DisplayData()
        {
            ViewBag.Message = "Display Individual Information";

            var IndivDemo = 
                //Demographics.GetIndividualDemographicData();

            return View();
        }
    }
}