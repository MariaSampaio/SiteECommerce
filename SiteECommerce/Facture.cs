﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteECommerce.Metier
{
    public class Facture:Commande 
    {
       
        public string MoyenPaiement { get; set; }
        public bool paiementValid { get; set; }

    }
}
