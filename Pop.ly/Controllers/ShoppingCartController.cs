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
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart();
            if(Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            return View(cart);
        }
        public ActionResult AddToCart(int movieID)
        {
            ShoppingCart cart = new ShoppingCart();
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            CartItem item = new CartItem();
            Movie movie = db.Movies.Where(m => m.ID == movieID).Select(m => m).First();
            item.Movie = movie;
            item.Quantity = 1;
            cart.Items.Add(item);
            Session["Cart"] = cart;
            return null;
        }
        public ActionResult RemoveFromCart(int index)
        {
            ShoppingCart cart = new ShoppingCart();
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            cart.Items.RemoveAt(index);
            return null;
        }
    }
}