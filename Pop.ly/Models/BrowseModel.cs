using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pop.ly.Models.Database;
using Pop.ly.Models;

namespace Pop.ly.Models
{
    public class BrowseModel
    {
        public List<Movie> movies { get; set; } = new List<Movie>();
        public List<string> genres {get; set; } = new List<string>();

        public void Populate()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            //Populates the list with movies
            this.movies = db.Movies.Select(m => m).ToList();

            //Populates the list of genres
            List<string> DGenres = new List<string>();
            string[] g = db.Movies.Select(m => m.Genre).ToArray();
            foreach (var item in g)
            {
                string[] word = item.Split(' ');
                foreach (var w in word)
                {
                    DGenres.Add(w.Trim(','));
                }
            }
            this.genres = DGenres.Distinct().ToList();
            //---
        }
    }

}