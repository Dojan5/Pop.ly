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
        public ActionResult Index(string T, int Y)
        {
            //Creates an object out of the view model, you can find it in Models/Database/Movies
            MovieIndexViewController model = new MovieIndexViewController();
            //Fetches a movie object from database
            Movie movieObject = db.Movies.Where(m => m.Title == T && m.ReleaseYear == Y).Select(m => m).First();
            //Fetches list of reviews from database
            var movieReviews = db.Reviews.Where(r => r.MovieID == movieObject.ID).Select(r => r).ToList();
            //Adds the movie object into the view model object
            model.Movie = movieObject;
            //Adds the list of reviews into the view model object
            model.Reviews = movieReviews;
            //Passes the view model object into the view
            return View(model);
        }
    }
}