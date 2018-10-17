namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApp : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            RenameColumn(table: "dbo.Providings", name: "Provider_ProviderKey", newName: "ProviderKey");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductId", newName: "ProductKey");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductId", newName: "IX_ProductKey");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_ProviderKey", newName: "IX_ProviderKey");
            DropPrimaryKey("dbo.Providings");
            AddColumn("dbo.Products", "IsBilogical", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Adress_StreetAddress", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Providings", new[] { "ProductKey", "ProviderKey" });
            CreateIndex("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.Products", "Adress_StreetAddress", c => c.String());
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            DropColumn("dbo.Products", "IsBilogical");
            AddPrimaryKey("dbo.Providings", new[] { "Provider_ProviderKey", "Product_ProductId" });
            RenameIndex(table: "dbo.Providings", name: "IX_ProviderKey", newName: "IX_Provider_ProviderKey");
            RenameIndex(table: "dbo.Providings", name: "IX_ProductKey", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "ProductKey", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "ProviderKey", newName: "Provider_ProviderKey");
            CreateIndex("dbo.Products", "CategoryId");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
