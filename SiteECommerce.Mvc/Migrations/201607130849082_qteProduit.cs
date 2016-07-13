namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qteProduit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produits", "Quantite", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produits", "Quantite");
        }
    }
}
