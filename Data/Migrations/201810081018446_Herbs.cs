namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Herbs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Herbel", c => c.Int());
            DropColumn("dbo.Products", "Herbs");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Herbs", c => c.String());
            DropColumn("dbo.Products", "Herbel");
        }
    }
}
