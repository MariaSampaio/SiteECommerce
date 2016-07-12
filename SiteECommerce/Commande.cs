using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce.Metier
{
    public class Commande
    {
        [Key]
        public int Id { get; set; }
        public Client Clients { get; set; }
        public ICollection<Produit> Produits { get; set; }
        public int Quantite { get; set; }
        public decimal prixTotal { get; set; }
    }
}
