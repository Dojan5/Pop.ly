using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pop.ly.Models;
using Pop.ly.Models.Database;
using System.ComponentModel.DataAnnotations;

namespace Pop.ly.Models
{
    public class HomeIndexVieWModel
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IEnumerable<Movie> Carousel { get; set; }
        [Display(Name ="Hot Items")]
        public IEnumerable<Movie> Popular { get; set; }
        [Display(Name = "New Releases")]
        public IEnumerable<Movie> RecentlyReleased { get; set; }

        public void Populate()
        {
            Carousel = db.Movies.Select(m => m).Take(3);
            Popular = db.Movies.Select(m => m);
            RecentlyReleased = db.Movies.Where(m => m.ReleaseYear == DateTime.Now.Year);
        }
    }
}