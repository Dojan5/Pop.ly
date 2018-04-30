namespace Pop.ly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pop.ly.Models.Database;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using Models;

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
                Title = "Interstellar",
                ReleaseYear = 2014,
                Director = " Christopher Nolan",
                Genre = "Drama",
                Description = "Earth's future has been riddled by disasters, famines, and droughts. There is only one way to ensure mankind's survival: Interstellar travel. A newly discovered wormhole in the far reaches of our solar system allows a team of astronauts to go where no man has gone before, a planet that may have the right environment to sustain human life.",
                Price = 20,
                CoverArt = @"/Content/Images/Movies/Interstellar_Cover.jpg",
                PromoArt = @"/Content/Images/Movies/Interstellar_Promo.jpg",
                TrailerURL = @"2LqzF5WauAw"
            };

            var m2 = new Movie
            {
                Title = "The Notebook",
                ReleaseYear = 2004,
                Director = "Nick Cassavetes",
                Genre = "Romance",
                Description = "In a nursing home, resident Duke reads a romance story to an old woman who has senile dementia with memory loss. In the late 1930s, wealthy seventeen year-old Allie Hamilton is spending summer vacation in Seabrook. Local worker Noah Calhoun meets Allie at a carnival and they soon fall in love with each other. One day, Noah brings Allie to an ancient house that he dreams of buying and restoring and they attempt to make love but get interrupted by their friend. Allie's parents do not approve of their romance since Noah belongs to another social class, and they move to New York with her. Noah writes 365 letters (A Year) to Allie, but her mother Anne Hamilton does not deliver them to her daughter. Three years later, the United States joins the World War II and Noah and his best friend Fin enlist in the army, and Allie works as an army nurse. She meets injured soldier Lon Hammond in the hospital. After the war, they meet each other again going on dates and then, Lon, who is wealthy and ...",
                Price = 5,
                CoverArt = @"/Content/Images/Movies/notebook_cover.jpg",
                PromoArt = @"/Content/Images/Movies/notebook_promo.jpg",
                TrailerURL = @"yDJIcYE32NU"
  
            };

            var m3 = new Movie
            {
                Title = "Ice Age 3: Dawn of the Dinosaurs",
                ReleaseYear = 2009,
                Director = "Carlos Saldanha",
                Genre = "Comedy, Adventure",
                Description = "After the events of 'Ice Age: The Meltdown', life begins to change for Manny and his friends: Scrat is still on the hunt to hold onto his beloved acorn, while finding a possible romance in a female sabre-toothed squirrel named Scratte. Manny and Ellie, having since become an item, are expecting a baby, which leaves Manny anxious to ensure that everything is perfect for when his baby arrives. Diego is fed up with being treated like a house-cat and ponders the notion that he is becoming too laid-back. Sid begins to wish for a family of his own, and so steals some dinosaur eggs which leads to Sid ending up in a strange underground world where his herd must rescue him, while dodging dinosaurs and facing danger left and right, and meeting up with a one-eyed weasel known as Buck who hunts dinosaurs intently.",
                Price = 10,
                CoverArt = @"/Content/Images/Movies/iceage3_cover.jpg",
                PromoArt = @"/Content/Images/Movies/iceage3_promo.jpg",
                TrailerURL = @"Y_nSwh2WjAM"

            };
            var m4 = new Movie
            {
                Title = "Moana",
                ReleaseYear = 2016,
                Director = "Ron Clements",
                Genre = "Comedy, Adventure",
                Description = "Moana Waialiki is a sea voyaging enthusiast and the only daughter of a chief in a long line of navigators. When her island's fishermen can't catch any fish and the crops fail, she learns that the demigod Maui caused the blight by stealing the heart of the goddess, Te Fiti. The only way to heal the island is to persuade Maui to return Te Fiti's heart, so Moana sets off on an epic journey across the Pacific. The film is based on stories from Polynesian mythology.",
                Price = 26,
                CoverArt = @"/Content/Images/Movies/moana_cover.jpg",
                PromoArt = @"/Content/Images/Movies/moana_promo.jpg",
                TrailerURL = @"LKFuXETZUsI"

            };
            var m5 = new Movie
            {
                Title = "Jurassic World",
                ReleaseYear = 2015,
                Director = "Colin Trevorrow",
                Genre = "Action, Adventure, Sci-Fi",
                Description = "22 years after the original Jurassic Park failed, the new park (also known as Jurassic World) is open for business. After years of studying genetics the scientists on the park genetically engineer a new breed of dinosaur. When everything goes horribly wrong, will our heroes make it off the island?",
                Price = 24,
                CoverArt = @"/Content/Images/Movies/jurassic_world_cover.jpg",
                PromoArt = @"/Content/Images/Movies/jurassic_world_promo.jpg",
                TrailerURL = @"RFinNxS5KN4"
            };
            var m6 = new Movie
            {
                Title = "Peter Rabbit",
                ReleaseYear = 2018,
                Director = "Will Gluck",
                Genre = "Action, Adventure, Sci-Fi",
                Description = "Based on the books by Beatrix Potter: Peter Rabbit (James Corden;) his three sisters: Flopsy (Margot Robbie,) Mopsy (Elizabeth Debicki) and Cotton Tail (Daisy Ridley) and their cousin Benjamin (Colin Moody) enjoy their days harassing Mr McGregor in his vegetable garden. Until one day he dies and no one can stop them roaming across his house and lands for a full day or so. However, when one of Mr McGregor's relatives inherits the house and goes to check it out, he finds much more than he bargained for. What ensues, is a battle of wills between the new Mr McGregor and the rabbits. But when he starts to fall in love with Bea (Rose Byrne,) a real lover of all nature, his feelings towards them begin to change. But is it too late?",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/peterrabbit_cover.jpg",
                PromoArt = @"/Content/Images/Movies/peterrabbit_promo.jpg",
                TrailerURL = @"7Pa_Weidt08"
            };
            var m7 = new Movie
            {
                Title = "The Greatest Showman",
                ReleaseYear = 2017,
                Director = "Michael Gracey",
                Genre = "Romance, Drama, Musical",
                Description = "Orphaned, penniless but ambitious and with a mind crammed with imagination and fresh ideas, the American Phineas Taylor Barnum will always be remembered as the man with the gift to effortlessly blur the line between reality and fiction. Thirsty for innovation and hungry for success, the son of a tailor will manage to open a wax museum but will soon shift focus to the unique and peculiar, introducing extraordinary, never-seen-before live acts on the circus stage. Some will call Barnum's wide collection of oddities, a freak show; however, when the obsessed showman gambles everything on the opera singer Jenny Lind to appeal to a high-brow audience, he will somehow lose sight of the most important aspect of his life: his family. Will Barnum risk it all to be accepted?",
                Price = 22,
                CoverArt = @"/Content/Images/Movies/TheGreatestShowman_cover.jpg",
                PromoArt = @"/Content/Images/Movies/TheGreatestShowman_promo.jpg",
                TrailerURL = @"AXCTMGYUg9A"
            };
            var m8 = new Movie
            {
                Title = "Tomb Raider",
                ReleaseYear = 2018,
                Director = "Roar Uthaug",
                Genre = "Action, Adventure, Drama",
                Description = "Lara Croft is the fiercely independent daughter of an eccentric adventurer who vanished when she was scarcely a teen. Now a young woman of 21 without any real focus or purpose, Lara navigates the chaotic streets of trendy East London as a bike courier, barely making the rent, and takes college courses, rarely making it to class. Determined to forge her own path, she refuses to take the reins of her father's global empire just as staunchly as she rejects the idea that he's truly gone.",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/TombRaider2018_cover.jpg",
                PromoArt = @"/Content/Images/Movies/TombRaider2018_promo.jpg",
                TrailerURL = @"rOEHpkZCc1Y"
            };
            context.Movies.AddOrUpdate(m => m.ID, m1, m2, m3, m4, m5, m6, m7, m8);
            //Seeds an administrator role if it doesn't already exist
            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Administrator" };
                manager.Create(role);
            }
            //Seeds an administrator account. Obviously this is a poor idea for an actual application
            if (!context.Users.Any(u => u.UserName == "Administrator"))
            {
                var cust = new Customer { FirstName = "Admin", LastName = "I. Strator" };
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "admin@app.com", Email="admin@app.com", Customer = cust  };
                

                manager.Create(user, "P@ssword1");
                manager.AddToRole(user.Id, "Administrator");
            }
        }
    }
}
