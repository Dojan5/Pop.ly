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

            return View();
        }
        public ActionResult Year(int Year)
        {
            
            
            var model = db.Movies.Where(m => m.ReleaseYear == Year).Select(m => m);
            
            return View(model);
            
         
        }
    }
}