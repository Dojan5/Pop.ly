using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pop.ly.Models;
using Pop.ly.Models.Database;

namespace Pop.ly.Controllers
{
    public class ShoppingCartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        ShoppingCart cart = new ShoppingCart();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void AddToCart(int movieID)
        {
            CartItem item = new CartItem();
            Movie movie = db.Movies.Where(m => m.ID == movieID).Select(m => m).First();
            item.Movie = movie;
            item.Quantity = 1;
            cart.Items.Add(item);
            Session["Cart"] = cart;
        }
    }
}