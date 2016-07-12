namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCategorie = c.Int(nullable: false, identity: true),
                        NomCategorie = c.String(),
                    })
                .PrimaryKey(t => t.IdCategorie);
            
            AddColumn("dbo.Produits", "Categorie_IdCategorie", c => c.Int());
            CreateIndex("dbo.Produits", "Categorie_IdCategorie");
            AddForeignKey("dbo.Produits", "Categorie_IdCategorie", "dbo.Categories", "IdCategorie");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "Categorie_IdCategorie", "dbo.Categories");
            DropIndex("dbo.Produits", new[] { "Categorie_IdCategorie" });
            DropColumn("dbo.Produits", "Categorie_IdCategorie");
            DropTable("dbo.Categories");
        }
    }
}
