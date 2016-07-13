using System;
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

        [Required]
        [ForeignKey("Marque")]
        public int IdMarque { get; set; }
        public virtual Marque Marque { get; set; }

        [ForeignKey("Categorie")]
        public int IdCategorie { get; set; }
        public virtual Categorie Categorie { get; set; }

        [ForeignKey("Fournisseur")]
        public int Idfournisseur { get; set; }
        public virtual Fournisseur Fournisseurs { get; set; }

    }
}
