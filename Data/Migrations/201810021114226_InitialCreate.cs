namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        DateProd = c.DateTime(),
                        Description = c.String(),
                        Name = c.String(),
                        price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        imageName = c.String(),
                        CategoryId = c.Int(),
                        Herbs = c.String(),
                        LabName = c.String(),
                        Adress_City = c.String(),
                        Adress_StreetAddress = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        ProviderKey = c.Int(nullable: false, identity: true),
                        Username = c.Int(nullable: false),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ProviderKey);
            
            CreateTable(
                "dbo.ProviderProducts",
                c => new
                    {
                        Provider_ProviderKey = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Provider_ProviderKey, t.Product_ProductId })
                .ForeignKey("dbo.Providers", t => t.Provider_ProviderKey, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Provider_ProviderKey)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProviderProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.ProviderProducts", "Provider_ProviderKey", "dbo.Providers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProviderProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.ProviderProducts", new[] { "Provider_ProviderKey" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.ProviderProducts");
            DropTable("dbo.Providers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
