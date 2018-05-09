using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pop.ly.Models;
using Pop.ly.Models.Database;

namespace Pop.ly.Models.Database
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<OrderRow> OrderRows { get; set; }
    }

    public class OrderViewModel
    {
        public Order Order { get; set; }
        public decimal TotalCost { get; set; } = 0;
        public List<OrderRow> OrderRows { get; set; }

        public void FillOrder(int OrderID)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            this.Order = db.Orders.Where(o => o.ID == OrderID).Select(o => o).SingleOrDefault();
            this.OrderRows = db.OrderRows.Where(o => o.Order.ID == OrderID).Select(o => o).ToList();
            foreach (var row in OrderRows)
            {
                this.TotalCost = this.TotalCost + row.Price;
            }
        }
    }
}