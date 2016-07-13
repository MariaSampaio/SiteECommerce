using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce.Metier
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set;}
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string AdresseLivraison { get; set; }
        public string AdresseFacturation { get; set; }
        
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }


    }
}
