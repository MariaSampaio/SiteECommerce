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

            var dop = new Metier.Marque { NomMarque = "Dop" };
            var oreal = new Metier.Marque { NomMarque = "L'oreal" };
            var colgate = new Metier.Marque { NomMarque = "Colgate" };
            var axe = new Metier.Marque { NomMarque = "Axe" };
            context.Marques.AddOrUpdate(m => m.NomMarque, dop, oreal, colgate);

            var cosmetique = new Metier.Categorie { NomCategorie = "Cosmetique" };
            var hygiene = new Metier.Categorie { NomCategorie = "Hygiene" };
            var soin = new Metier.Categorie { NomCategorie = "Soin" };
            context.Categories.AddOrUpdate(c => c.NomCategorie, cosmetique, hygiene, soin);

            context.SaveChanges();

            var savon = new Metier.Produit { NomProduit = "Savon", ImgProduit = "img", PrixProduit = 15, DescriptionProduit = "naturel", IdMarque = 1, IdCategorie = 1 };
            var shampoing = new Metier.Produit { NomProduit = "Shampoing", ImgProduit = "img", PrixProduit = 12, DescriptionProduit = "chimique", IdMarque = 2, IdCategorie = 2 };
            var deodorant = new Metier.Produit { NomProduit = "Deodorant", ImgProduit = "img", PrixProduit = 5, DescriptionProduit = "chimique", IdMarque = 3, IdCategorie = 2 };
            var gel_douche = new Metier.Produit { NomProduit = "Gel Douche", ImgProduit = "img", PrixProduit = 16, DescriptionProduit = "chimique", IdMarque = 4, IdCategorie = 3 };
            context.Produits.AddOrUpdate(p => p.NomProduit, savon, shampoing, deodorant, gel_douche);


           
            

        }
    }
}
