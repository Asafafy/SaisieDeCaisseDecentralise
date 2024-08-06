using SoftCaisse.Utils.Connection;
using System.Data.Entity;

namespace SoftCaisse.Models
{
    public class SCDContext : DbContext
    {
        private static string connectionString = "";
        public SCDContext() : base(Db.GetConnectionString("ServeurCfg.txt")) { }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Collaborateur> Collaborateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}