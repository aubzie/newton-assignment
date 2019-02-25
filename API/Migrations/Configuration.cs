namespace API.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using API.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<API.Models.NewtonAssignmentAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(API.Models.NewtonAssignmentAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*
             public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public Publisher Publisher { get; set; }
        */
            context.Genres.AddOrUpdate(x => x.Id,
                new Genre() { Id = 1, Name = "Action" },
                new Genre() { Id = 2, Name = "Adventure" },
                new Genre() { Id = 3, Name = "Role Playing" },
                new Genre() { Id = 4, Name = "Sports" },
                new Genre() { Id = 5, Name = "Simulation" },
                new Genre() { Id = 6, Name = "Strategy" },
                new Genre() { Id = 7, Name = "Racing" }
            );
            context.Publishers.AddOrUpdate(x => x.Id,
                new Publisher() { Id = 1, Name = "Square-Enix" },
                new Publisher() { Id = 2, Name = "Blizzard Entertainment" },
                new Publisher() { Id = 3, Name = "Capcom" },
                new Publisher() { Id = 4, Name = "Electronic Arts" },
                new Publisher() { Id = 5, Name = "Rockstar" },
                new Publisher() { Id = 6, Name = "Activision" }
            );

            context.VideoGames.AddOrUpdate(x => x.Id,
                new VideoGame() { Id = 1, Title = "Kingdom Hearts 3", Description = "", Year = 2019, PublisherId = 1,  },
                new VideoGame() { Id = 2, Title = "World Of Warcraft - Battle for Azeroth", Description = "", Year = 2018, PublisherId = 2 },
                new VideoGame() { Id = 3, Title = "Resident Evil 2", Description = "", Year = 2019, PublisherId = 3 },
                new VideoGame() { Id = 4, Title = "Red Dead Redemption 2", Description = "", Year = 2018, PublisherId = 5 },
                new VideoGame() { Id = 5, Title = "Call of Duty - Black Ops 4", Description = "", Year = 2018, PublisherId = 6 },
                new VideoGame() { Id = 6, Title = "Anthem", Description = "", Year = 2019, PublisherId = 4 },
                new VideoGame() { Id = 7, Title = "NHL 2019", Description = "", Year = 2018, PublisherId = 4 }
            );
        }
    }
}
