namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class engagerVivement : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Produits", "Quantite");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produits", "Quantite", c => c.Int(nullable: false));
        }
    }
}
