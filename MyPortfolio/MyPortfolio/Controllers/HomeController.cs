using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Skills()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
