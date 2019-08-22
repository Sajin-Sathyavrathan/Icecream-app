using System.Collections.Generic;
using IceCreamParlour.Data.Entities;

namespace IcecreamParlour.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IceCreamParlour.Data.Entities.IceCreamDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IceCreamParlour.Data.Entities.IceCreamDbContext context)
        {

            IList<Flavour> defaultFlavours = new List<Flavour>();

            defaultFlavours.Add(new Flavour() { FlName = "Vanilla", FlPrice = 1 });
            defaultFlavours.Add(new Flavour() { FlName = "Chocolate", FlPrice = 1.5m });
            defaultFlavours.Add(new Flavour() { FlName = "Strwaberry", FlPrice = 2 });
            defaultFlavours.Add(new Flavour() { FlName = "Cookie and Cream", FlPrice = 2.5m });
            defaultFlavours.Add(new Flavour() { FlName = "Hazel Nut ", FlPrice = 3 });

            context.Flavours.AddRange(defaultFlavours);

            IList<Topping> defaultTopings = new List<Topping>();
            defaultTopings.Add(new Topping() { Name = "ChocoChips", Price = 1 });
            defaultTopings.Add(new Topping() { Name = "Cookies", Price = 1.2m });
            defaultTopings.Add(new Topping() { Name = "Jelly", Price = 1.3m });
            defaultTopings.Add(new Topping() { Name = "Fruits", Price = 1.4m });
            defaultTopings.Add(new Topping() { Name = "Almonds", Price = 1.5m });
            defaultTopings.Add(new Topping() { Name = "Cashew", Price = 2 });
            defaultTopings.Add(new Topping() { Name = "Pista", Price = 2.3m });

            context.Toppings.AddRange(defaultTopings);

            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
