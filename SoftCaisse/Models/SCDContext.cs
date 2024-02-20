using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Models
{
    public class SCDContext : DbContext
    {
        public SCDContext():base("name=ScdDbContext") {}
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }  
    }
}
