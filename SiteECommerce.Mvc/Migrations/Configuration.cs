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

            context.Marques.AddOrUpdate(
               new Metier.Marque { IdMarque = 1, NomMarque = "Dop" },
               new Metier.Marque { IdMarque = 2, NomMarque = "L'oreal" },
               new Metier.Marque { IdMarque = 3, NomMarque = "Colgate" }
               );


            context.Produits.AddOrUpdate(
            new Metier.Produit { IdProduit = 1, NomProduit = "Savon", ImgProduit = "img", PrixProduit = 15, DescriptionProduit = "naturel", MarqueId = 1 },
            new Metier.Produit { IdProduit = 2, NomProduit = "Shampoing", ImgProduit = "img", PrixProduit = 12, DescriptionProduit = "naturel", MarqueId = 2 },
            new Metier.Produit { IdProduit = 3, NomProduit = "Gel Douche", ImgProduit = "img", PrixProduit = 16, DescriptionProduit = "naturel", MarqueId = 1 });

           
        }
    }
}
