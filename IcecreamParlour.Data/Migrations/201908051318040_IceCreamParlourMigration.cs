namespace IcecreamParlour.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IceCreamParlourMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flavour",
                c => new
                    {
                        FlId = c.Int(nullable: false, identity: true),
                        FlName = c.String(nullable: false, maxLength: 50),
                        FlPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FlId);
            
            CreateTable(
                "dbo.Toppings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Toppings");
            DropTable("dbo.Flavour");
        }
    }
}
