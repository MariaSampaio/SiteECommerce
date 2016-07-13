﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SiteECommerce.Metier
{
    public class Produit
    {
        [Key]
        public int IdProduit { get; set; }
        public string NomProduit { get; set; }
        public string ImgProduit { get; set; }
        public decimal PrixProduit { get; set; }
        public string DescriptionProduit { get; set; }
        public int Quantite { get; set; }

        [ForeignKey("Marque")]
        public int IdMarque;
        public virtual Marque Marque { get; set; }

        [ForeignKey("Categorie")]
        public int IdCategorie;
        public virtual Categorie Categorie { get; set; }

        [ForeignKey("Fournisseur")]
        public int Idfournisseur;
        public virtual Fournisseur Fournisseurs { get; set; }

        public ICollection<Commentaire> Commentaire { get; set; }

    }
}
