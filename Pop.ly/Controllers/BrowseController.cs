using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pop.ly.Models.Database;
using Pop.ly.Models;

namespace Pop.ly.Controllers
{
    public class BrowseController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Browse
        public ActionResult Index()
        {
            BrowseModel model = new BrowseModel();
            model.Populate();
            return View(model);
        }
        public ActionResult Year(int Year)
        {
            BrowseModel model = new BrowseModel();
            model.movies = db.Movies.Where(m => m.ReleaseYear == Year).Select(m => m).ToList();            
            return View(model);        
         
        }
        public ActionResult SortByGenre(string Genre)
        {
            var model = db.Movies.Where(g => g.Genre.Contains(Genre)).Select(g => g);

            return PartialView(model);
        }
    }
}