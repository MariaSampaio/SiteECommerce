using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce.Metier
{
    public class Commentaire
    {
        public int Id { get; private set; }
        public int Note { get; set; }
        public string Texte { get; set; }

        [ForeignKey("Client")]
        public int idClient;
        public virtual Client Clients { get; set; }
      
        [ForeignKey("Produit")]
        public int IdProduit;
        public virtual Produit Produits { get; set; }
    }
}
