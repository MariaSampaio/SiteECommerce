namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategorie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produits", "Categorie_IdCategorie", "dbo.Categories");
            DropIndex("dbo.Produits", new[] { "Categorie_IdCategorie" });
            DropColumn("dbo.Produits", "Categorie_IdCategorie");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
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
    }
}
