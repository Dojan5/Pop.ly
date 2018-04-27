using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Fetches models used in project
using Pop.ly.Models;
using Pop.ly.Models.Database;

namespace Pop.ly.Controllers
{
    public class CustomerController : Controller
    {
        //Creates an entry point to work with the database
        ApplicationDbContext db = new ApplicationDbContext();       
        public ActionResult EditOwnDetails()
        {
            var query = db.Customers.Where(c => c.ID == 1).Select(c => c);
            Customer model = new Customer();
            model = query.First();
            return View(model);
        }
    }
}