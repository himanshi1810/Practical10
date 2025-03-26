using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Task4.Controllers
{
    public class ExceptionFilterController : Controller
    {
        //For handling the exception 
        //Three Steps :   1.Add [HandleError] on which you are willing to check exception
        //                2.Add Error.cshtml at View/Shared Folder for rendering if any exception come
        //                3.Add <customErrors mode = "On" /> int web.config file inside System.Web Tag
        [HandleError]
        public ActionResult Index()
        {
            int a = 0;
            int b = 10 / a;
            return View();
        }
    }
}