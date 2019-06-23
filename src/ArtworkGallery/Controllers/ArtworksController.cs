using ArtworkGallery.Models;
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
            var artwork = new Artwork()
            {
                ArtworkTitle = "Paris Opera House",
                Medium = "pencil",
                DescriptionHtml = "<p>Drawing of Paris Opera House.</p>",
                Pencils = new Pencil[]
                {
                        new Pencil() { Name = "Graphite", Type = "2B" },
                        new Pencil() { Name = "Watercolor", Type = "4B" },
                        new Pencil() { Name = "Charcoal", Type = "4H" },
                
                }
            };

            return View(artwork);
        }
    }
}