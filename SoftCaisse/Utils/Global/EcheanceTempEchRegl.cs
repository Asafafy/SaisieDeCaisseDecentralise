using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Utils.Global
{
    internal class EcheanceTempEchRegl
    {
        public int DR_No { get; set; }
        public int RG_No { get; set; }
        public decimal? RC_Montant { get; set; }
        public decimal? soldeEchInit { get; set; }
        public string doPieceNo { get; set; }
    }
}
