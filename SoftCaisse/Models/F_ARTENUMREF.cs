namespace SoftCaisse.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class F_ARTENUMREF
    {
        [Required]
        [StringLength(19)]
        public string AR_Ref { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(20)]
        public byte[] cbAR_Ref { get; set; }

        public int? AG_No1 { get; set; }

        public int? AG_No2 { get; set; }

        [StringLength(19)]
        public string AE_Ref { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(20)]
        public byte[] cbAE_Ref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AE_PrixAch { get; set; }

        [StringLength(19)]
        public string AE_CodeBarre { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(20)]
        public byte[] cbAE_CodeBarre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AE_PrixAchNouv { get; set; }

        [StringLength(45)]
        public string AE_EdiCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(46)]
        public byte[] cbAE_EdiCode { get; set; }

        public short? AE_Sommeil { get; set; }

        public short? cbProt { get; set; }

        [Key]
        public int cbMarq { get; set; }

        [StringLength(4)]
        public string cbCreateur { get; set; }

        public DateTime? cbModification { get; set; }

        public int? cbReplication { get; set; }

        public short? cbFlag { get; set; }

        public DateTime? cbCreation { get; set; }

        public Guid? cbCreationUser { get; set; }
    }
}