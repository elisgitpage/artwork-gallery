using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtworkGallery.Controllers
{
    public class ArtworksController : Controller
    {

        public ActionResult Detail()
        {
            ViewBag.ArtpieceTitle = " St Basils Cathedral";
            ViewBag.Medium = "pencil on paper";
            ViewBag.Description = "<p>Drawing of St Basils cathedral in Moscow.</p>";
            ViewBag.Pencils = new string[]
            {
            "2B",
            "4B",
            "2H"
            };

            return View();
        }
    }
}