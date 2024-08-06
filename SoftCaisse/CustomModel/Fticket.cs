using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.CustomModel
{
    public class Fticket
    {
        public string caisse {  get; set; }
        public string ticket {  get; set; }
        public string date { get; set; }
        public string heure { get; set; }
        public string caissier {  get; set; }
        public string client { get; set; }
        public double montant {  get; set; }

    }
}
