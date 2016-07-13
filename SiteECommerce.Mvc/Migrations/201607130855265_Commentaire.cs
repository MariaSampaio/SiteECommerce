namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commentaire : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commentaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.Int(nullable: false),
                        Texte = c.String(),
                        Clients_Id = c.Int(),
                        Produits_IdProduit = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Clients_Id)
                .ForeignKey("dbo.Produits", t => t.Produits_IdProduit)
                .Index(t => t.Clients_Id)
                .Index(t => t.Produits_IdProduit);
            
            AddColumn("dbo.Produits", "Quantite", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "Prenom", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Nom", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "AdresseFacturation", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Login", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commentaires", "Produits_IdProduit", "dbo.Produits");
            DropForeignKey("dbo.Commentaires", "Clients_Id", "dbo.Clients");
            DropIndex("dbo.Commentaires", new[] { "Produits_IdProduit" });
            DropIndex("dbo.Commentaires", new[] { "Clients_Id" });
            AlterColumn("dbo.Clients", "Password", c => c.String());
            AlterColumn("dbo.Clients", "Login", c => c.String());
            AlterColumn("dbo.Clients", "AdresseFacturation", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "Nom", c => c.String());
            AlterColumn("dbo.Clients", "Prenom", c => c.String());
            DropColumn("dbo.Produits", "Quantite");
            DropTable("dbo.Commentaires");
        }
    }
}
