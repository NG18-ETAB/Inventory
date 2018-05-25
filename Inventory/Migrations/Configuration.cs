namespace Inventory.Migrations
{
    using Inventory.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Inventory.Models.InventoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Inventory.Models.InventoryContext";
        }

        protected override void Seed(InventoryContext db)
        {
            db.Products.AddOrUpdate(
                p => new { p.Name, p.Category },
                new Product { Name = "Toaster 1000", Price = 299, Quantity = 10, Category = Category.Appliances },
                new Product { Name = "Toaster 2100", Price = 379, Quantity = 12, Category = Category.Appliances },
                new Product { Name = "Samsung G-12", Price = 1190, Quantity = 100, Category = Category.Electronics },
                new Product { Name = "iPhone 8X", Price = 7500, Quantity = 23, Category = Category.Electronics },
                new Product { Name = "RC Hummvee", Price = 1200, Quantity = 4, Category = Category.Toys, Description = "Radio controller car" },
                new Product { Name = "Canine Robot", Price = 375, Quantity = 210, Category = Category.Toys, Description = "Autonomous toy robot" },
                new Product { Name = "Vinyl Voldemort", Price = 279, Quantity = 2, Category = Category.Toys, Description = "Vinyl doll" },
                new Product { Name = "Vinyl Harry Potter", Price = 289, Quantity = 4, Category = Category.Toys, Description = "Vinyl doll" },
                new Product { Name = "Vinyl Harry Potter", Price = 279, Quantity = 4, Category = Category.Toys, Description = "Vinyl doll" }
             );

        }
    }
}
