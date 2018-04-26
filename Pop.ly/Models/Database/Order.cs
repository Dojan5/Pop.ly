using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pop.ly.Models.Database
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}