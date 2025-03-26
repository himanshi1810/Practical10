using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task2.Controllers
{
    public class ActionResultController : Controller
    {
        //ContentResult
        public ContentResult ContentResultDemo()
        {
            return Content("Hello this is content result Demo");
        }

        //FileResult
        public FileResult FileResultDemo()
        {
            string filePath = Server.MapPath("~/App_Data/SampleText.txt");

            if (System.IO.File.Exists(filePath))
            {
                return File(filePath, "text/plain", "SampleText.txt"); 
            }
            else
            {
                return null; 
            }
        }

        //EmptyResult
        public EmptyResult EmptyResultDemo()
        {
            return new EmptyResult();
        }

        //JavaScriptResult
        public JavaScriptResult JavaScriptResultDemo()
        {
            return JavaScript("alert('Hello this is JavaScriptResult Demo')");
        }

        //JsonResult
        public JsonResult JsonResultDemo()
        {
            var data = new { Name = "Himanshi", Age = 21, City = "Ahmedabad" };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //RedirectResult
        public RedirectResult RedirectResultDemo()
        {
            return Redirect("https://www.google.com");
        }

        //RedirectToRouteResult
        public RedirectToRouteResult RedirectToRouteResultDemo()
        {
            return RedirectToAction("ContentResultDemo");
        }
        //ViewResult
        public ViewResult ViewResultDemo()
        {
            return View();
        }
        //This is parent class from this we can call any action result
        //ActionResult
        public ActionResult ActionResultDemo()
        {
            return Content("Hello this is ActionResult Demo");
        }
    }
}