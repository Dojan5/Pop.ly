using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Pop.ly.Models.Database
{
    public class Customer
    {
        public int ID { get; set; }
        [Display(Name ="First Name"),Required]
        public string FirstName { get; set; }
        [Display(Name ="Last Name"),Required]
        public string LastName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingZip { get; set; }
        public string BillingCity { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryZip { get; set; }
        public string DeliveryCity { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        /* Don't uncomment this yet. I have no idea how to do this yet. Needs research!
         * 
         * public virtual ApplicationUser User { get; set; }
        */
    }
}