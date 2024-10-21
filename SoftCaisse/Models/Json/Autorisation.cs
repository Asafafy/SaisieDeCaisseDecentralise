namespace SoftCaisse.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Windows.Documents;

    [Table("Autorisation")]
    public partial class Autorisation
    {
        public int Id { get; set; }
        public List<int> Autorisations { get; set; }
    }
}
