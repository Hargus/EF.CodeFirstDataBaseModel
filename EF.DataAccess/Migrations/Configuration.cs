namespace EF.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF.DataAccess.Models.NORTHWNDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EF.DataAccess.Models.NORTHWNDContext context)
        {
            
        }
    }
}
