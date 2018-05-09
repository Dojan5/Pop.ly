using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pop.ly.Models.Database;
using Pop.ly.Models;

namespace Pop.ly.Models
{
    public class AdministrationViewModels
    {
    }
    public class OrderAdminViewModel
    {
        public List<OrderViewModel> AllOrders = new List<OrderViewModel>();

        public void Populate()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var AllOrders = db.Orders.Select(o => o.ID);
            foreach (var ID in AllOrders)
            {
                OrderViewModel obj = new OrderViewModel();
                obj.FillOrder(ID);
                this.AllOrders.Add(obj);
            }
        }
    }
}