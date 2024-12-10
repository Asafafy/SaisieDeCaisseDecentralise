using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.DTO
{
    internal class ListeSelectionEcheances
    {
        public DateTime? DR_Date { get; set; }
        [StringLength(13)]
        public string DO_Piece { get; set; }
        [StringLength(17)]
        public string CT_NumPayeur { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? DR_Pourcent { get; set; }
        [StringLength(35)]
        public string R_Intitule { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? A_Payer { get; set; }
        public short? DR_Regle { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Solde { get; set; }
    }
}
