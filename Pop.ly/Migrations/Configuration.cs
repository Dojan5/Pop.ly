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
    using System.Collections.Generic;

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

            //Seeds an administrator role if it doesn't already exist
            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Administrator" };
                manager.Create(role);
            }
            //Seeds an administrator account. Obviously this is a poor idea for an actual application
            if (!context.Users.Any(u => u.UserName == "admin@app.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var AdminUser = new ApplicationUser
                {
                    FirstName = "Admin",
                    LastName = "I. Strator",
                    UserName = "admin@app.com",
                    Email = "admin@app.com",
                };


                manager.Create(AdminUser, "P@ssword1");
                manager.AddToRole(AdminUser.Id, "Administrator");
            }

            //Seeds users/customers to the database
            if (!context.Users.Any(u => u.UserName == "hannah_rockz@hotmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var C1 = new ApplicationUser
                {
                    FirstName = "Hannah",
                    LastName = "Handlebars",
                    BillingAddress = "23 Floof Rd.",
                    BillingZip = "64477",
                    BillingCity = "Fluffington",
                    DeliveryAddress = "23 Floof Rd.",
                    DeliveryZip = "64477",
                    DeliveryCity = "Fluffington",
                    PhoneNumber = "0722267435",
                    UserName = "hannah_rockz@hotmail.com",
                    Email = "hannah_rocks@hotmail.com",
                };
                var C2 = new ApplicationUser
                {
                    FirstName = "Ronald",
                    LastName = "Racuous",
                    BillingAddress = "23 Floof Rd.",
                    BillingZip = "64477",
                    BillingCity = "Fluffington",
                    DeliveryAddress = "23 Floof Rd.",
                    DeliveryZip = "64477",
                    DeliveryCity = "Fluffington",
                    Email = "rockin_ron@aweso.me",
                    PhoneNumber = "0762458731",
                    UserName = "rockin_ron@aweso.me"
                };
                var C3 = new ApplicationUser
                {
                    FirstName = "Pia",
                    LastName = "Pajama",
                    BillingAddress = "18 Bunnyhop Ln.",
                    BillingZip = "64458",
                    BillingCity = "Fluffington",
                    DeliveryAddress = "18 Bunnyhop Ln.",
                    DeliveryZip = "64458",
                    DeliveryCity = "Fluffington",
                    Email = "pia_loves_bunnies@floof.com.au",
                    UserName = "pia_loves_bunnies@floof.com.au",
                    PhoneNumber = "0708742354"
                };
                var C4 = new ApplicationUser
                {
                    FirstName = "Marjory",
                    LastName = "Delaqua",
                    BillingAddress = "14 Grenth Plaza.",
                    BillingZip = "66645",
                    BillingCity = "Divinity's Reach",
                    DeliveryAddress = "14 Grenth Plaza",
                    DeliveryZip = "66645",
                    DeliveryCity = "Divinity's Reach",
                    Email = "srs_bznz@thepact.com",
                    UserName = "srs_bznz@thepact.com",
                    PhoneNumber = "0757896521"
                };
                var C5 = new ApplicationUser
                {
                    FirstName = "Kasmeer",
                    LastName = "Meade",
                    BillingAddress = "14 Grenth Plaza.",
                    BillingZip = "66645",
                    BillingCity = "Divinity's Reach",
                    DeliveryAddress = "14 Grenth Plaza",
                    DeliveryZip = "66645",
                    DeliveryCity = "Divinity's Reach",
                    Email = "pink_butterflies@thepact.com",
                    UserName = "pink_butterflies@thepact.com",
                    PhoneNumber = "0748942482"
                };
                var C6 = new ApplicationUser
                {
                    FirstName = "Frederique",
                    LastName = "Gaston",
                    BillingAddress = "2 Barley Ave.",
                    BillingZip = "87954",
                    BillingCity = "Thompton",
                    DeliveryAddress = "2 Barley Ave.",
                    DeliveryZip = "87954",
                    DeliveryCity = "Thompton",
                    Email = "ihatebeer@gmail.com",
                    UserName = "ihatebeer@gmail.com",
                    PhoneNumber = "0724821212"
                };
                var C7 = new ApplicationUser
                {
                    FirstName = "Eoghan",
                    LastName = "McGrath",
                    BillingAddress = "1 Spice Plaza Apts.",
                    BillingZip = "78545",
                    BillingCity = "Verilla",
                    DeliveryAddress = "1 Spice Plaza Apts.",
                    DeliveryZip = "78545",
                    DeliveryCity = "Verilla",
                    Email = "notavampire@simail.com",
                    UserName = "notavampire@simail.com",
                    PhoneNumber = "0765484852"
                };


                manager.Create(C1, "P@ssword1");
                manager.Create(C2, "P@ssword1");
                manager.Create(C3, "P@ssword1");
                manager.Create(C4, "P@ssword1");
                manager.Create(C5, "P@ssword1");
                manager.Create(C6, "P@ssword1");
                manager.Create(C7, "P@ssword1");
            }

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
             var m9 = new Movie
            {
                Title = "Game Night",
                ReleaseYear = 2018,
                Director = "John Francis Daley",
                Genre = "Comedy",
                Description ="Max and his wife, Annie, and their friends get together for 'Game Night' on a regular basis. His brother, Brooks, who's hosting the event this time, informs them that they're having a murder mystery party. Someone in the room will be kidnapped during the party. The other players must do everything they can to find him to win the grand prize. Brooks warns them that they won't know what is real or fake. When the door breaks open suddenly and Brooks is kidnapped, Max and the other players believe that it's merely the start of the mystery. What happens next proves that a real kidnapping can cause a lot of hilarious and even deadly confusion when everyone thinks it's just a game." ,
                Price = 25,
                CoverArt = @"/Content/Images/Movies/gamenight_cover.jpg",
                PromoArt = @"/Content/Images/Movies/gamenight_promo.jpg",
                TrailerURL = @"qmxMAdV6s4U"
            };
            var m10 = new Movie
            {
                Title = "Ready Player One",
                ReleaseYear = 2018,
                Director = "Steven Spielberg",
                Genre = "Action, Adventure, Sci-Fi",
                Description = "In the year 2045, the real world is a harsh place. The only time Wade Watts (Tye Sheridan) truly feels alive is when he escapes to the OASIS, an immersive virtual universe where most of humanity spends their days. In the OASIS, you can go anywhere, do anything, be anyone-the only limits are your own imagination. The OASIS was created by the brilliant and eccentric James Halliday (Mark Rylance), who left his immense fortune and total control of the Oasis to the winner of a three-part contest he designed to find a worthy heir. When Wade conquers the first challenge of the reality-bending treasure hunt, he and his friends-aka the High Five-are hurled into a fantastical universe of discovery and danger to save the OASIS.",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/readyplayerone_cover.jpg",
                PromoArt = @"/Content/Images/Movies/readyplayerone_promo.jpg",
                TrailerURL = @"cSp1dM2Vj48"
            };
            var m11 = new Movie
            {
                Title = "Show Dogs",
                ReleaseYear = 2018,
                Director = "Raja Gosnell",
                Genre = "Action, Adventure, Comedy",
                Description = "Max, a macho, solitary Rottweiler police dog is ordered to go undercover as a primped show dog in a prestigious Dog Show, along with his human partner, to avert a disaster from happening.",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/showdogs_cover.jpg",
                PromoArt = @"/Content/Images/Movies/showdogs_promo.jpg",
                TrailerURL = @"eT9eWtb7C4c"
            };
            var m12 = new Movie
            {
                Title = "Beast",
                ReleaseYear = 2017,
                Director = "Michael Pearce",
                Genre = "Drama",
                Description = "A troubled woman living in an isolated community finds herself pulled between the control of her oppressive family and the allure of a secretive outsider suspected of a series of brutal murders.",
                Price = 28,
                CoverArt = @"/Content/Images/Movies/beast2017_cover.jpg",
                PromoArt = @"/Content/Images/Movies/beast2017_promo.jpg",
                TrailerURL = @"l6CWOjYSGH8"
            };
            var m13 = new Movie
            {
                Title = "Life of the Party",
                ReleaseYear = 2018,
                Director = "Ben Falcone",
                Genre = "Comedy",
                Description = "When her husband suddenly dumps her, longtime dedicated housewife Deanna turns regret into re-set by going back to college - landing in the same class and school as her daughter, who's not entirely sold on the idea. Plunging headlong into the campus experience, the increasingly outspoken Deanna -- now Dee Rock -- embraces freedom, fun, and frat boys on her own terms, finding her true self in a senior year no one ever expected.",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/LifeOfTheParty_cover.jpg",
                PromoArt = @"/Content/Images/Movies/LifeOfTheParty_promo.jpg",
                TrailerURL = @"T1B1CxmAXLk"
            };
            var m14 = new Movie
            {
                Title = "Deadpool 2",
                ReleaseYear = 2018,
                Director = "David Leitch",
                Genre = "Action, Adventure, Comedy",
                Description = "After surviving a near fatal bovine attack, a disfigured cafeteria chef (Wade Wilson) struggles to fulfill his dream of becoming Mayberry's hottest bartender while also learning to cope with his lost sense of taste. Searching to regain his spice for life, as well as a flux capacitor, Wade must battle ninjas, the Yakuza, and a pack of sexually aggressive canines, as he journeys around the world to discover the importance of family, friendship, and flavor - finding a new taste for adventure and earning the coveted coffee mug title of World's Best Lover.",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/Deadpool2_cover.jpg",
                PromoArt = @"/Content/Images/Movies/Deadpool2_promo.jpg",
                TrailerURL = @"D86RtevtfrA"
            };
            var m15 = new Movie
            {
                Title = "Book Club",
                ReleaseYear = 2018,
                Director = "Bill Holderman",
                Genre = "Comedy",
                Description = "Four older women spend their lives attending a book club where they bond over the typical suggested literature. One day, they end up reading Fifty Shades of Grey and are turned on by the content. Viewing it as a wake up call, they decide to expand their lives and chase pleasures that have eluded them.",
                Price = 30,
                CoverArt = @"/Content/Images/Movies/BookClub_cover.jpg",
                PromoArt = @"/Content/Images/Movies/BookClub_promo.jpg",
                TrailerURL = @"LDxgPIsv6sY"
            };
            var m16 = new Movie
            {
                Title = "Alice in Wonderland",
                ReleaseYear = 1999,
                Director = "Nick Welling",
                Genre = "Adventure, Comedy, Family",
                Description = "Alice follows a white rabbit down a rabbit-hole into a whimsical Wonderland, where she meets characters like the delightful Cheshire Cat, the clumsy White Knight, a rude caterpillar, and the hot-tempered Queen of Hearts and can grow ten feet tall or shrink to three inches. But will she ever be able to return home?",
                Price = 12,
                CoverArt = @"/Content/Images/Movies/Alice1999_cover.jpg",
                PromoArt = @"/Content/Images/Movies/Alice1999_promo.jpg",
                TrailerURL = @"LDxgPIsv6sY"
            };
            var m17 = new Movie
            {
                Title = "A Fistful of Dollars",
                ReleaseYear = 1964,
                Director = "Sergio Leone",
                Genre = "Western",
                Description = "An anonymous, but deadly man rides into a town torn by war between two factions, the Baxters and the Rojo's. Instead of fleeing or dying, as most other would do, the man schemes to play the two sides off each other, getting rich in the bargain.",
                Price = 5,
                CoverArt = @"/Content/Images/Movies/FistfulOfDollars_cover.jpg",
                PromoArt = @"/Content/Images/Movies/FistfulOfDollars_promo.jpg",
                TrailerURL = @"X2DtiE7VLw"
            };
                 var m18 = new Movie
            {
                Title = "Spartacus",
                ReleaseYear = 1960,
                Director = " Stanley Kubrick",
                Genre = "Drama",
                Description = "In 73 BCE, a Thracian slave leads a revolt at a gladiatorial school run by Lentulus Batiatus. The uprising soon spreads across the Italian Peninsula involving thousand of slaves. The plan is to acquire sufficient funds to acquire ships from Silesian pirates who could then transport them to other lands from Brandisium in the south. The Roman Senator Gracchus schemes to have Marcus Publius Glabrus, Commander of the garrison of Rome, lead an army against the slaves who are living on Vesuvius. When Glabrus is defeated his mentor, Senator and General Marcus Licinius Crassus is greatly embarrassed and leads his own army against the slaves. Spartacus and the thousands of freed slaves successfully make their way to Brandisium only to find that the Silesians have abandoned them. They then turn north and must face the might of Rome.",
                Price = 5,
                CoverArt = @"/Content/Images/Movies/spartacus1960_cover.jpg",
                PromoArt = @"/Content/Images/Movies/Spartacis1960_promo.jpg",
                TrailerURL = @"HcIMY1Ah3aw"
            };
             var m19 = new Movie
            {
                Title = "Casablanca",
                ReleaseYear = 1942,
                Director = "Michael Curtiz",
                Genre = "Drama, Romance",
                Description = "The story of Rick Blaine, a cynical world-weary ex-patriate who runs a nightclub in Casablanca, Morocco during the early stages of WWII. Despite the pressure he constantly receives from the local authorities, Rick's cafe has become a kind of haven for refugees seeking to obtain illicit letters that will help them escape to America. But when Ilsa, a former lover of Rick's, and her husband, show up to his cafe one day, Rick faces a tough challenge which will bring up unforeseen complications, heartbreak and ultimately an excruciating decision to make.",
                Price = 6,
                CoverArt = @"/Content/Images/Movies/casablanca_cover.jpg",
                PromoArt = @"/Content/Images/Movies/casablanca_promo.jpg",
                TrailerURL = @"BkL9l7qovsE"
            };
            
            context.Movies.AddOrUpdate(m => m.ID, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19);

            //Seeds reviews for Interstellar
            //var rev1 = new Review
            //{
            //    Customer = c1,
            //    Movie = m1,
            //    Rating = 5,
            //    Comment = "This movie is totally awesome. It completely changed my life. Spoiler warning: when the thing happened I was just so thrilled! It's so cool to see Actors performance in this role. Director did the director stuff really well too. I can't wait for a sequel!"

            //};
            //var rev2 = new Review
            //{
            //    Customer = c2,
            //    Movie = m1,
            //    Rating = 1,
            //    Comment = "Meh... The shiny stuff wasn't as shiny as I would've hoped, and the lines were dumb. I particularly hated it when the actor went all 'Hurr durr I'm the protagonist I can do things!' That's just lazy writing."

            //};
            //var rev3 = new Review
            //{
            //    Customer = c3,
            //    Movie = m1,
            //    Rating = 3,
            //    Comment = "It's a movie. It is an OK movie. I liked it."

            //};
            //context.Reviews.AddOrUpdate(r => r.ID, rev1, rev2, rev3);
            //Creates order
            //var order1 = new Order
            //{
            //    User = C1,
            //    OrderDate = DateTime.Now
            //};
            //context.Orders.AddOrUpdate(or => or.ID, order1);
            ////Creates rows for orders
            //var or1r1 = new OrderRow
            //{
            //    Movie = m1,
            //    Order = order1,
            //    Price = m1.Price,
            //    Quantity = 1
            //};
            //var or1r2 = new OrderRow
            //{
            //    Movie = m3,
            //    Order = order1,
            //    Price = m3.Price,
            //    Quantity = 1
            //};
            //context.OrderRows.AddOrUpdate(row => row.ID, or1r1, or1r2);


        }
    }
}
