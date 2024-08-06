using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Models
{
    public class Fligne
    {
        public string caisse { get; set; }
        public string numero { get; set; }
        public string date { get; set; }
        public string type { get; set; }
        public string reference {  get; set; }
        public string designation { get; set; }
        public double quantite {  get; set; }
        public double prix_unitaire {  get; set; }
        public string remise {  get; set; }
        public double montant_ht {  get; set; }

    }
}
