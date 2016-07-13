namespace SiteECommerce.Mvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SiteECommerce.DAL.SiteECommerceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SiteECommerce.DAL.SiteECommerceDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Fournisseurs.AddOrUpdate(f => f.Idfournisseur,
            new Metier.Fournisseur { Idfournisseur = 1, Nom = "valentin", Adresse = "13 rue des fleurs" }
            );

            var dop = new Metier.Marque { IdMarque = 1, NomMarque = "Dop" };
            var oreal = new Metier.Marque { IdMarque = 2, NomMarque = "L'oreal" };
            var colgate = new Metier.Marque { IdMarque = 3, NomMarque = "Colgate" };
            context.Marques.AddOrUpdate(m => m.IdMarque, dop, oreal, colgate);

            var cosmetique = new Metier.Categorie { IdCategorie = 1, NomCategorie = "Cosmetique" };
            var hygiene = new Metier.Categorie { IdCategorie = 2, NomCategorie = "Hygiene" };
            var soin = new Metier.Categorie { IdCategorie = 3, NomCategorie = "Soin" };
            context.Categories.AddOrUpdate(c => c.IdCategorie, cosmetique, hygiene, soin);

            context.SaveChanges();

            context.Produits.AddOrUpdate(p => p.IdProduit,
            new Metier.Produit { IdProduit = 1, NomProduit = "Savon", ImgProduit = "img", PrixProduit = 15, DescriptionProduit = "naturel", Quantite = 8, IdMarque = colgate.IdMarque, IdCategorie = cosmetique.IdCategorie, Idfournisseur = 1 },
            new Metier.Produit { IdProduit = 2, NomProduit = "Shampoing", ImgProduit = "img", PrixProduit = 12, DescriptionProduit = "chimique", Quantite = 9, IdMarque = dop.IdMarque, IdCategorie = soin.IdCategorie, Idfournisseur = 1 },
            new Metier.Produit { IdProduit = 3, NomProduit = "Gel Douche", ImgProduit = "img", PrixProduit = 16, DescriptionProduit = "chimique", Quantite = 10, IdMarque = oreal.IdMarque, IdCategorie = hygiene.IdCategorie, Idfournisseur = 1 });
        }
    }
}
