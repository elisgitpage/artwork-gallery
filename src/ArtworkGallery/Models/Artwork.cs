using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtworkGallery.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string ArtworkTitle { get; set; }
        public string Medium { get; set; }
        public string DescriptionHtml { get; set; }
        public Pencil[] Pencils { get; set; }
        public bool Favorite { get; set; }
    }
}