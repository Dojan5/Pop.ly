﻿using System;
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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MovieDetails()
        {
            var Movie = new Movie();
            var dbm = db.Movies.Select(m => m);
            Movie = dbm.First();
            return View(Movie);
        }
    }
}