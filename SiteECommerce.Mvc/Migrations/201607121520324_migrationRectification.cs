namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationRectification : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Produits", name: "Fournisseur_Idfournisseur", newName: "Fournisseurs_Idfournisseur");
            RenameIndex(table: "dbo.Produits", name: "IX_Fournisseur_Idfournisseur", newName: "IX_Fournisseurs_Idfournisseur");
            AddColumn("dbo.Commandes", "Client_Id1", c => c.Int());
            CreateIndex("dbo.Commandes", "Client_Id1");
            AddForeignKey("dbo.Commandes", "Client_Id1", "dbo.Clients", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commandes", "Client_Id1", "dbo.Clients");
            DropIndex("dbo.Commandes", new[] { "Client_Id1" });
            DropColumn("dbo.Commandes", "Client_Id1");
            RenameIndex(table: "dbo.Produits", name: "IX_Fournisseurs_Idfournisseur", newName: "IX_Fournisseur_Idfournisseur");
            RenameColumn(table: "dbo.Produits", name: "Fournisseurs_Idfournisseur", newName: "Fournisseur_Idfournisseur");
        }
    }
}
