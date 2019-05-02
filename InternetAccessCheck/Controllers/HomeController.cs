using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetAccessCheck.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Stop Caching in IE
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);

            // Stop Caching in Firefox
            Response.Cache.SetNoStore();
            return View();
        }

        public string HealthCheck()
        {
            // Stop Caching in IE
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);

            // Stop Caching in Firefox
            Response.Cache.SetNoStore();
            return DateTime.Now.ToLocalTime().ToString();
        }
    }
}