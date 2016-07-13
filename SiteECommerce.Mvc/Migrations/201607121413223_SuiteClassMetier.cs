namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuiteClassMetier : DbMigration
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
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                        Nom = c.String(),
                        Email = c.String(),
                        AdresseLivraison = c.String(),
                        AdresseFacturation = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantite = c.Int(nullable: false),
                        prixTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MoyenPaiement = c.String(),
                        paiementValid = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Client_Id = c.Int(),
                        Clients_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Clients", t => t.Clients_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Clients_Id);
            
            CreateTable(
                "dbo.Fournisseurs",
                c => new
                    {
                        Idfournisseur = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.Idfournisseur);
            
            AddColumn("dbo.Produits", "Categorie_IdCategorie", c => c.Int());
            AddColumn("dbo.Produits", "Commande_Id", c => c.Int());
            AddColumn("dbo.Produits", "Fournisseur_Idfournisseur", c => c.Int());
            CreateIndex("dbo.Produits", "Categorie_IdCategorie");
            CreateIndex("dbo.Produits", "Commande_Id");
            CreateIndex("dbo.Produits", "Fournisseur_Idfournisseur");
            AddForeignKey("dbo.Produits", "Categorie_IdCategorie", "dbo.Categories", "IdCategorie");
            AddForeignKey("dbo.Produits", "Commande_Id", "dbo.Commandes", "Id");
            AddForeignKey("dbo.Produits", "Fournisseur_Idfournisseur", "dbo.Fournisseurs", "Idfournisseur");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "Fournisseur_Idfournisseur", "dbo.Fournisseurs");
            DropForeignKey("dbo.Produits", "Commande_Id", "dbo.Commandes");
            DropForeignKey("dbo.Commandes", "Clients_Id", "dbo.Clients");
            DropForeignKey("dbo.Commandes", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Produits", "Categorie_IdCategorie", "dbo.Categories");
            DropIndex("dbo.Commandes", new[] { "Clients_Id" });
            DropIndex("dbo.Commandes", new[] { "Client_Id" });
            DropIndex("dbo.Produits", new[] { "Fournisseur_Idfournisseur" });
            DropIndex("dbo.Produits", new[] { "Commande_Id" });
            DropIndex("dbo.Produits", new[] { "Categorie_IdCategorie" });
            DropColumn("dbo.Produits", "Fournisseur_Idfournisseur");
            DropColumn("dbo.Produits", "Commande_Id");
            DropColumn("dbo.Produits", "Categorie_IdCategorie");
            DropTable("dbo.Fournisseurs");
            DropTable("dbo.Commandes");
            DropTable("dbo.Clients");
            DropTable("dbo.Categories");
        }
    }
}
