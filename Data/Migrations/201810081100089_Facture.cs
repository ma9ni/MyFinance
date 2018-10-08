namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        DateFacture = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.ClientId, t.ProductId, t.DateFacture })
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        CIN = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        prenom = c.String(),
                    })
                .PrimaryKey(t => t.CIN);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factures", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Factures", "ClientId", "dbo.Clients");
            DropIndex("dbo.Factures", new[] { "ProductId" });
            DropIndex("dbo.Factures", new[] { "ClientId" });
            DropTable("dbo.Clients");
            DropTable("dbo.Factures");
        }
    }
}
