using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using REMS.Models;

namespace REMS.Controllers
{
    public class PropertyController : Controller
    {
        private REMSDBContext db = new REMSDBContext();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Property property, string[] Features, HttpPostedFileBase Image1, HttpPostedFileBase Image2, HttpPostedFileBase Image3)
        {
            if (ModelState.IsValid)
            {
                // Save features
                if (Features != null && Features.Any())
                    property.Features = string.Join(",", Features);

                // Handle image uploads
                string imageFolder = Server.MapPath("~/Content/images/uploads/");
                if (!Directory.Exists(imageFolder))
                    Directory.CreateDirectory(imageFolder);

                if (Image1 != null)
                {
                    string fileName1 = Path.GetFileName(Image1.FileName);
                    Image1.SaveAs(Path.Combine(imageFolder, fileName1));
                    property.Image1 = "/Content/images/uploads/" + fileName1;
                }

                if (Image2 != null)
                {
                    string fileName2 = Path.GetFileName(Image2.FileName);
                    Image2.SaveAs(Path.Combine(imageFolder, fileName2));
                    property.Image2 = "/Content/images/uploads/" + fileName2;
                }

                if (Image3 != null)
                {
                    string fileName3 = Path.GetFileName(Image3.FileName);
                    Image3.SaveAs(Path.Combine(imageFolder, fileName3));
                    property.Image3 = "/Content/images/uploads/" + fileName3;
                }

                db.Properties.Add(property);
                db.SaveChanges();

                TempData["Success"] = "Property added successfully!";
                return RedirectToAction("Create");
            }

            return View(property);
        }
        public ActionResult Properties()
        {
            var properties = db.Properties.ToList();
            return View(properties);
        }

    }
}
