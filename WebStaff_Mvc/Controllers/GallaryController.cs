using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStaff_Mvc.Controllers
{
    public class GallaryController : Controller
    {
        // GET: Gallary   this call tne name of view
        public ActionResult pictures()
        {
            return View();
        }
    }
}