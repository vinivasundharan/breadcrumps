using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeDaLs_ver01.Controllers
{
    public class HomeController : Controller
    {
        //Main page
        public ActionResult Index()
        {
            return View();
        }
        //Description for learn more
        public ActionResult About()
        {
            ViewBag.Message = "More Description";
            return View();
        }

        public ActionResult SystemFamily()
        {
            ViewBag.Message = "System Family";
            return View();
        }

        public ActionResult TechnicalCharacteristics()
        {
            ViewBag.Message = "Technical Characteristics";
            return View();
        }
        public ActionResult Views()
        {
            ViewBag.Message = "Views";
            return View();
        }
        public ActionResult RevisionHistory()
        {
            ViewBag.Message = "Revision History";
            return View();
        }
        public ActionResult Calculation()
        {
            ViewBag.Message = "Calculations";
            return View();
        }
        public ActionResult ImportSAP()
        {
            ViewBag.Message = "Import SAP Characteristics";
            return View();
        }
        public ActionResult UserRights()
        {
            ViewBag.Message = "User Rights Management";
            return View();
        }

    }
}