using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public List<Order> Orders { get; set; }
        public List<OrderRow> OrderRows { get; set; }
    }
}