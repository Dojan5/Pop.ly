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
        [Display(Name ="Billing Address")]
        public string BillingAddress { get; set; }
        [Display(Name = "Billing Zip")]
        public string BillingZip { get; set; }
        [Display(Name = "Billing City")]
        public string BillingCity { get; set; }
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; }
        [Display(Name = "Delivery Zip")]
        public string DeliveryZip { get; set; }
        [Display(Name = "Delivery City")]
        public string DeliveryCity { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}