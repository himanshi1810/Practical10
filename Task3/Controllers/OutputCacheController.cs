using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task3.Controllers
{
    public class OutputCacheController : Controller
    {
        //Display the current time for 5 minutes can not be refreshed
        //After 5 minutes, the page will be refreshed
        //action level filter
        [OutputCache(Duration = 60 * 5)]
        // GET: OutputCache
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}