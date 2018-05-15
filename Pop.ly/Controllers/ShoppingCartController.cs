using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pop.ly.Models;
using Pop.ly.Models.Database;
using Microsoft.AspNet.Identity;

namespace Pop.ly.Controllers
{
    public class ShoppingCartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart();
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            return View(cart);
        }
        //Handles adding new items to the cart, it needs the Movie's ID to function
        public ActionResult AddToCart(int movieID)
        {
            //Creates an instance of a cart
            ShoppingCart cart = new ShoppingCart();
            //Checks whether a cart exists in the session, if so it sets this new cart instance to be identical to the cart in the session
            //We do this so we don't overwrite the cart, otherwise we'd never be able to add more than one item to the cart
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            //Instantiates a movie object by using the movie ID we passed into the function to query the database
            Movie SelectedMovie = db.Movies.Where(m => m.ID == movieID).Select(m => m).First();
            //Creates a new cart item

            var existingItem = cart.Items.SingleOrDefault(i => i.Movie.ID == movieID);

            if (existingItem != null)
            {
                //filmen finns redan i cart


                existingItem.Quantity++;

            }
            else
            {
                //filmen finns INTE i cart

                CartItem item = new CartItem
                {
                    Movie = SelectedMovie,
                    Quantity = 1,
                    CostPerItem = SelectedMovie.Price
                };
                //Adds the cart item to our cart
                cart.Items.Add(item);
            }
            //Passes our cart into the session
            Session["Cart"] = cart;
            return null;
        }
        //Handles removing existing items from the cart
        public ActionResult RemoveFromCart(int index)
        {
            ShoppingCart cart = new ShoppingCart();
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            if (cart.Items.Count() >= 1)
            {
                cart.Items.RemoveAt(index);
            }
            Session["Cart"] = cart;
            return null;
        }
        //Increments an item in the cart by one
        public ActionResult IncreaseItemQuantity(int movieID)
        {
            //Creates an instance of a cart
            ShoppingCart cart = new ShoppingCart();
            //Checks whether a cart exists in the session, if so it sets this new cart instance to be identical to the cart in the session
            //We do this so we don't overwrite the cart, otherwise we'd never be able to add more than one item to the cart
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            //Instantiates a movie object by using the movie ID we passed into the function to query the database
            Movie SelectedMovie = db.Movies.Where(m => m.ID == movieID).Select(m => m).First();
            //Creates a new cart item

            var existingItem = cart.Items.SingleOrDefault(i => i.Movie.ID == movieID);

            if (existingItem != null)
            {
                //filmen finns redan i cart
                existingItem.Quantity++;
            }
            else
            {
                //filmen finns INTE i cart
                CartItem item = new CartItem
                {
                    Movie = SelectedMovie,
                    Quantity = 1,
                    CostPerItem = SelectedMovie.Price
                };
                //Adds the cart item to our cart
                cart.Items.Add(item);
            }
            //Passes our cart into the session
            Session["Cart"] = cart;
            return null;
        }

        //PlaceOrder
        public ActionResult PlaceOrder()
        {
            ShoppingCart Cart = (ShoppingCart)Session["Cart"];
            var userId = User.Identity.GetUserId();
            ShoppingCart.CreateOrder(userId, Cart);
            return View();
        }
        //Get amount of items in cart
        public ActionResult GetCartAmount()
        {
            ShoppingCart cart = new ShoppingCart();
            int model;
            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            if (cart.Items != null)
            {
                model = cart.Items.Count();
            }
            else
            {
                model = 0;
            }

            return View(model);
        }
        public ActionResult DecreaseItemQuantity(int movieID)
        {
            ShoppingCart cart = new ShoppingCart();

            if (Session["Cart"] != null)
            {
                cart = (ShoppingCart)Session["Cart"];
            }
            Movie SelectedMovie = db.Movies.Where(m => m.ID == movieID).Select(m => m).First();

            var existingItem = cart.Items.SingleOrDefault(i => i.Movie.ID == movieID);

            if (existingItem != null)
            {

                existingItem.Quantity--;
            }
            else
            {
                CartItem item = new CartItem
                {
                    Movie = SelectedMovie,
                    Quantity = 1,
                    CostPerItem = SelectedMovie.Price
                };
                cart.Items.Add(item);
            }
            Session["Cart"] = cart;
            return null;
         
        }
    }
}   




            

