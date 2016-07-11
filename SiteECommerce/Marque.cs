using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce
{
    public class Marque
    {
        public int IdMarque { get; set; }
        public string NomMarque { get; set; }

        public virtual ICollection<Produit> Produits { get; set; }
    }
}
