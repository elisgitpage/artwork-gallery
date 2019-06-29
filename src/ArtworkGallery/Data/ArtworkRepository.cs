using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArtworkGallery.Models;

namespace ArtworkGallery.Data
{
    public class ArtworkRepository
    {
        private static Artwork[] _artworks = new Artwork[]
        {
            new Artwork()
            {
                Id = 1,
                ArtworkTitle = "Paris Opera House",
                Medium = "pencil",
                DescriptionHtml = "<p>Drawing of Paris Opera House.</p>",
                Pencils = new Pencil[]
                {
                        new Pencil() { Name = "Graphite", Type = "2B" },
                        new Pencil() { Name = "Watercolor", Type = "4B" },
                        new Pencil() { Name = "Charcoal", Type = "4H" },

                },
                Favorite = true
            },
            new Artwork()
            {
                Id = 2,
                ArtworkTitle = "Ink Portrait no1",
                Medium = "ink",
                DescriptionHtml = "<p>Drawing of a face I found on reddit gets drawn using pen.</p>",
                Pencils = new Pencil[]
                {
                        new Pencil() { Name = "Pen", Type = "Thin marker" }
                },
                Favorite = true
            }
        };
           
        public Artwork[] GetArtworks()
        {
            return _artworks;
        }

        public Artwork GetArtwork(int id)
        {
            Artwork artworkReturned = null;

            foreach (var artWork in _artworks)
            { 
                if(artWork.Id == id)
                {
                    artworkReturned = artWork;

                    break;
                }
            }

            return artworkReturned;
        }
    }
}