using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce.Metier
{
    public class Commentaire
    {
        public int Id { get; private set; }
        public int Note { get; set; }
        public string Description { get; set; }
        public Client Clients { get; set; }
        public Produit Produits { get; set; }
    }
}
