using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamParlour.Data.Entities
{
    public partial class IceCreamDbContext : DbContext, IDisposable
    {
        public IceCreamDbContext()
            : base("name=DefaultConnection")
        {
          
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            Database.SetInitializer(new IceCreamDbInitializer());
        }

        public virtual DbSet<Flavour> Flavours { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
    }

    public class IceCreamDbInitializer : DropCreateDatabaseAlways<IceCreamDbContext>
    {
        protected override void Seed(IceCreamDbContext context)
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
        }
    }
}
