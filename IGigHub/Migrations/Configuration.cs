using IGigHub.Models;

namespace IGigHub.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IGigHub.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "IGigHub.Models.ApplicationDbContext";
        }

        protected override void Seed(IGigHub.Models.ApplicationDbContext context)
        {
            context.Genres.AddOrUpdate(
                new Genre { Id = 1 , Name = "Jazz"},
                new Genre { Id = 2, Name = "Rock" },
                new Genre { Id = 3, Name = "Blues" },
                new Genre { Id = 4, Name = "Trap" }

                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
