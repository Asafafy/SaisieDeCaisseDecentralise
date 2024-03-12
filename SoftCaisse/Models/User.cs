using System.ComponentModel.DataAnnotations;

namespace SoftCaisse.Models
{
    public  class User
    {
        [Key]
        public int UserId { get; set; }
        public string Login { get; set; }

        public string UserPassword { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
