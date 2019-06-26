using ArtworkGallery.Data;
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
        private ArtworkRepository _artWorkRepository = null;

        public ArtworksController()
        {
            _artWorkRepository = new ArtworkRepository();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var artWork = _artWorkRepository.GetArtwork(id.Value);

            return View(artWork);
        }
    }
}