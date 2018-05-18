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
        public Random r = new Random();
        ApplicationDbContext db = new ApplicationDbContext();
        public IEnumerable<Movie> Carousel { get; set; }
        [Display(Name ="Hot Items")]
        public IEnumerable<Movie> Popular { get; set; }
        [Display(Name = "New Releases")]
        public IEnumerable<Movie> RecentlyReleased { get; set; }
        [Display(Name = "Old Favourites")]
        public IEnumerable<Movie> OldestMovies { get; set; }
        [Display(Name = "Great Deals")]
        public IEnumerable<Movie> CheapestMovies { get; set; }


        public void Populate()
        {
            Carousel = db.Movies.OrderByDescending(m => m.ReleaseYear).Take(3);
            Popular = db.Movies.Select(m => m);
            RecentlyReleased = db.Movies.Where(m => m.ReleaseYear >= DateTime.Now.Year -1);
            OldestMovies = db.Movies.OrderBy(m => m.ReleaseYear).Select(m => m).Take(12).ToList();
            CheapestMovies = db.Movies.OrderBy(m => m.Price).Select(m => m).Take(12).ToList();
        }
    }
}