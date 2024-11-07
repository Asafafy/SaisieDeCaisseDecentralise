namespace SoftCaisse.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Role")]
    public partial class Role
    {
        [Key]
        public int IdRole { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleIntitule { get; set; }
    }
}
