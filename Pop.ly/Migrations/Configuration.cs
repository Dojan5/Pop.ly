namespace Pop.ly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pop.ly.Models.Database;

    internal sealed class Configuration : DbMigrationsConfiguration<Pop.ly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pop.ly.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var c1 = new Customer
            {
                FirstName = "Hannah",
                LastName = "Handlebars",
                BillingAddress = "23 Floof Rd.",
                BillingZip = "64477",
                BillingCity = "Fluffington",
                DeliveryAddress = "23 Floof Rd.",
                DeliveryZip = "64477",
                DeliveryCity = "Fluffington",
                EmailAddress = "hannah_rockz@hotmail.com",
                PhoneNumber = "0722267435"
            };
            var c2 = new Customer
            {
                FirstName = "Ronald",
                LastName = "Racuous",
                BillingAddress = "23 Floof Rd.",
                BillingZip = "64477",
                BillingCity = "Fluffington",
                DeliveryAddress = "23 Floof Rd.",
                DeliveryZip = "64477",
                DeliveryCity = "Fluffington",
                EmailAddress = "rockin_ronald@soawesome.me",
                PhoneNumber = "0762458731"
            };
            var c3 = new Customer
            {
                FirstName = "Pia",
                LastName = "Pajama",
                BillingAddress = "18 Bunnyhop Ln.",
                BillingZip = "64458",
                BillingCity = "Fluffington",
                DeliveryAddress = "18 Bunnyhop Ln.",
                DeliveryZip = "64458",
                DeliveryCity = "Fluffington",
                EmailAddress = "pia_loves_bunnies@floof.com.au",
                PhoneNumber = "0708742354"
            };
            context.Customers.AddOrUpdate(c => c.ID, c1, c2, c3);

            var m1 = new Movie
            {

                CoverArt = @"\Content\Images\Movies\Interstellar_Cover.jpg",

            };

        }
    }
}
