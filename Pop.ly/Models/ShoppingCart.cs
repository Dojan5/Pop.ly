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
    }
}