using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pop.ly.Models.Database;

namespace Pop.ly.Models
{
    public class CartItem
    {
        public int Quantity { get; set; }
        public Movie Movie { get; set; }
        public decimal CostPerItem { get; set; }
    }

    public class ShoppingCart
    {
        public decimal TotalCost { get; set; }
        public List<CartItem> Items = new List<CartItem>();


        //Calculates the total cost of all items in the cart
        public void CalculateTotal()
        {
            TotalCost = 0;
            foreach (var i in this.Items)
            {
                TotalCost += i.Movie.Price * i.Quantity;
            }
        }
        //Method takes a cart and a customer and creates an order, as well as appropriate rows out of it.
        public static void CreateOrder(string UserID, ShoppingCart Cart)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Order NewOrder = new Order
            {

                User = db.Users.Find(UserID),
                OrderDate = DateTime.Now
            };
            NewOrder.OrderRows = new List<OrderRow>();
            foreach (var item in Cart.Items)
            {
                OrderRow row = new OrderRow
                {
                    
                    Movie = item.Movie,
                    Price = item.CostPerItem * item.Quantity,
                    Quantity = item.Quantity
                };
                NewOrder.OrderRows.Add(row);
            }


            db.Orders.Add(NewOrder);
            db.SaveChanges();
        }
    }
}