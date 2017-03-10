namespace SimpleMVC.App.Migrations
{
    using SimpleMVC.App.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleMVC.App.Data.NotesAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleMVC.App.Data.NotesAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Users.AddOrUpdate(
                  new User { Username = "Andrew",Password= "123" }
                );
            
        }
    }
}
