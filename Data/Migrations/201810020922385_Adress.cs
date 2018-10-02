namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Adress_City", c => c.String());
            AddColumn("dbo.Products", "Adress_StreetAddress", c => c.String());
            DropColumn("dbo.Products", "City");
            DropColumn("dbo.Products", "StreetAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "StreetAddress", c => c.String());
            AddColumn("dbo.Products", "City", c => c.String());
            DropColumn("dbo.Products", "Adress_StreetAddress");
            DropColumn("dbo.Products", "Adress_City");
        }
    }
}
