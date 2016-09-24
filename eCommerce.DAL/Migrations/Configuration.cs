namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eCommerce.DAL.eCommerceDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            Database.SetInitializer(new eCommerceDatabaseInitializer());
        }

        protected override void Seed(eCommerce.DAL.eCommerceDb context)
        {
            eCommerceDatabaseInitializer.GetCategories().ForEach(c => context.Categories.Add(c));
            eCommerceDatabaseInitializer.GetProducts().ForEach(p => context.Products.Add(p));
        }
    }
}
