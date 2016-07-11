namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        IdProduit = c.Int(nullable: false, identity: true),
                        NomProduit = c.String(),
                        ImgProduit = c.String(),
                        PrixProduit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescriptionProduit = c.String(),
                        Categorie_IdCategorie = c.Int(),
                        Marque_IdMarque = c.Int(),
                    })
                .PrimaryKey(t => t.IdProduit)
                .ForeignKey("dbo.Categories", t => t.Categorie_IdCategorie)
                .ForeignKey("dbo.Marques", t => t.Marque_IdMarque)
                .Index(t => t.Categorie_IdCategorie)
                .Index(t => t.Marque_IdMarque);
            
            CreateTable(
                "dbo.Marques",
                c => new
                    {
                        IdMarque = c.Int(nullable: false, identity: true),
                        NomMarque = c.String(),
                    })
                .PrimaryKey(t => t.IdMarque);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "Marque_IdMarque", "dbo.Marques");
            DropForeignKey("dbo.Produits", "Categorie_IdCategorie", "dbo.Categories");
            DropIndex("dbo.Produits", new[] { "Marque_IdMarque" });
            DropIndex("dbo.Produits", new[] { "Categorie_IdCategorie" });
            DropTable("dbo.Marques");
            DropTable("dbo.Produits");
            DropTable("dbo.Categories");
        }
    }
}
