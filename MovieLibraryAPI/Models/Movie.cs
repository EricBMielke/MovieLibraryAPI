using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLibraryAPI.Models
{
    public class Movie
    {
        public string Genre { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string DirectorName { get; set; }
        public string PictureURL { get; set; }
    }
}