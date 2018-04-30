using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pop.ly.Models;
using Pop.ly.Models.Database;


namespace Pop.ly.Controllers
{
    public class MovieController : Controller
    {
         ApplicationDbContext db = new ApplicationDbContext();       
        // GET: Movie
        public ActionResult Index(string T, int Y)
        {
            var Movie = new Movie();
            var dbm = db.Movies.Where(m => m.Title == T && m.ReleaseYear == Y).Select(m => m);
            Movie = dbm.First();
            return View(Movie);
        }
        public ActionResult MovieDetails()
        {
            var Movie = new Movie();
            var dbm = db.Movies.Where(m => m.ID == 3).Select(m => m);
            Movie = dbm.First();
            return View(Movie);
        }
    }
}