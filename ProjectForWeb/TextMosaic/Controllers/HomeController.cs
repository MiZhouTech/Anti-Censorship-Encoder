using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextMosaic.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "如何使用文字打码器？";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "如果遇到任何bug或疑问，请联系开发者。";

            return View();
        }
    }
}