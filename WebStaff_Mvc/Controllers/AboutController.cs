using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStaff_Mvc.Controllers
{
    public class AboutController : Controller
    {
        // GET: About this actions calls the name of the view
        public ActionResult About_us()
        {

            ViewBag.Message = "yhgffdgbbfffvfd";
            return View();
        }
    }
}