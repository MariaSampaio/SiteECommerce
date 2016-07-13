using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce.Metier
{
    public class Commande
    {
        [Key]
        public int Id { get; set; }
        public int Quantite { get; set; }
        public decimal prixTotal { get; set; }
        public Client Clients { get; set; }

        [ForeignKey("Client")]
        public int clientId;
        public virtual Client Client { get; set; }


        public ICollection<Produit> Produits { get; set; }
   

        
    }
}
