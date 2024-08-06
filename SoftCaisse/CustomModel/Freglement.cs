using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Models
{
    public class Freglement
    {
        public string Date { get; set; }
        public string Type { get; set; }    
        public double Montant { get; set; }
        public string Caisse { get; set; }
        public string Client { get; set; }
    }
}
