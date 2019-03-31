namespace GymApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GymApp.Data.GymAppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GymApp.Data.GymApp_db";
        }

        protected override void Seed(GymApp.Data.GymAppDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the _dbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
