using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pop.ly.Controllers
{
    public class BrowseController : Controller
    {
        // GET: Browse
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Year(int y)
        {
            var Year = new Year();
            var dbm = db.Movies.Where(m => m.ReleaseYear == Year).Select(m => m);
            Movie = dbm.First();
            return View(Movie);
            
         
        }
    }
}