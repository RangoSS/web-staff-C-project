using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStaff_Mvc.Controllers
{
    public class InfosController : Controller
    {
        // GET: Infos
        public ActionResult information()
        {
            return View();
        }
    }
}