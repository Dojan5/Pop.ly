﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pop.ly.Models.Database;
using Pop.ly.Models;

namespace Pop.ly.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministrationController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Administration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageOrders()
        {
            OrderAdminViewModel model = new OrderAdminViewModel();
            model.Populate();
            return View(model);
        }
        public ActionResult ManageMovies()
        {
            var model = db.Movies.Select(m => m);
            return View(model);
        }
        [HttpGet]
        public ActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMovie(Movie obj)
        {
            Movie.SaveMovieToDB(obj);
            return View();
        }
    }
}