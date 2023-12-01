using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EdithTour.Models;

namespace EdithTour.Areas.Admin.Controllers
{
    public class AddController : Controller
    {
        public EdithTourEntities db  = new EdithTourEntities();
        // GET: Admin/Product
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Outside()
        {
            return View();
        }
        public ActionResult Inside()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inside(Tour_Inside inside, HttpPostedFileBase imageFile)
        {
            string filename = inside.Name + ".jpg";
            string p = Path.Combine(Server.MapPath("~/Images/Tours"), filename);
            imageFile.SaveAs(p);
            inside.Image = filename;
            db.Tour_Inside.Add(inside);
            db.SaveChanges();
            return View("Add","Add");
            
        }

        public ActionResult Trending()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Restaurant()
        {
            return View();
        }

        public ActionResult Hotel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Hotel(Hotel ht, HttpPostedFileBase imageFile)
        {
            string filename = ht.Name + ".jpg";
            string p = Path.Combine(Server.MapPath("~/Images/Hotel"), filename);
            imageFile.SaveAs(p);
            ht.Image = filename;
            db.Hotels.Add(ht);
            db.SaveChanges();
            return View("Add");

        }
    }
}