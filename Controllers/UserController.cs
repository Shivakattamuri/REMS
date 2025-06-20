using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REMS.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Login() => View();
        public ActionResult Register() => View();


    }
}