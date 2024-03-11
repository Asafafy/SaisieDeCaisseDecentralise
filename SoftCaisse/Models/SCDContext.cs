using System.Data.Entity;

namespace SoftCaisse.Models
{
    public class SCDContext : DbContext
    {
        public SCDContext():base("name=ScdDbContext") {}
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }  
    }
}
