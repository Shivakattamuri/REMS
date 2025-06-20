using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REMS.Controllers
{
    public class PropertyController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }// Add new property
        public ActionResult PropertyList()
        {
            return View();
        }
    }

}