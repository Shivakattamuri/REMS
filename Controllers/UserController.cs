using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using REMS.Models;

namespace REMS.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Replace with your actual authentication logic
                if (model.Email == "admin@example.com" && model.Password == "admin123")
                {
                    // TempData or Session can be used to store login state
                    TempData["Message"] = "Login Successful!";
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid email or password.");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.RoleList = new SelectList(
                new[]
                {
                    new { Value = "Owner",             Text = "Owner" },
                    new { Value = "Buyer",             Text = "Buyer" },
                    new { Value = "PropertyManager",   Text = "Property Manager" }
                    
                },
                "Value",
                "Text"
            );

            return View(new RegisterViewModel());

        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.RoleList = new SelectList(new[] {
                        new { Value = "Owner", Text = "Owner" },
                        new { Value = "Buyer", Text = "Buyer" },
                        new { Value = "PropertyManager", Text = "Property Manager" }
                    },
                    "Value",
                    "Text",
                    model.Role);
                return View(model);
            }

            TempData["Success"] = "Registration successful!";
            return RedirectToAction("Login");
        }

        
    }
}
