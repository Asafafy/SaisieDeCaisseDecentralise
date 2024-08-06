using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.CustomModel
{
    public enum StatType
    {
        ParArticle,
        ParFamille,
        ParReglement
    }
    public class Fstatistique
    {
        public string Reference { get; set; }
        public string Designation { get; set; }
        public double CANetHT { get; set; }
        public double Quantite { get; set; }
        public double CANet { get; set; }
        public double Marge { get; set; }
        public string Caisse { get; set; }
    }
}
