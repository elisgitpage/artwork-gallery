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
                ArtworkTitle = "St Basils Cathedral",
                Medium = "Pencil on Paper",
                DescriptionHtml = "<p>Drawing of St Basils cathedral in Moscow.</p>",
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