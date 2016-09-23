namespace eCommerce.DAL.Migrations
{
    using eCommerce.Core;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eCommerce.DAL.eCommerceDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "eCommerce.DAL.eCommerceDb";
        }

        protected override void Seed(eCommerce.DAL.eCommerceDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.Name,
              new Product { Name = "Products", Id = 1 },
              new Product { Name = "Productn", Id = 2 },
              new Product { Name = "Product" , Id = 3}
            );
            
        }
    }
}
