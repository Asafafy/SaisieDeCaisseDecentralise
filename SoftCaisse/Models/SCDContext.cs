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
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAutorisation> RoleAutorisation { get; set; }
        public virtual DbSet<Rubrique> Rubrique { get; set; }
        public virtual DbSet<CurrentRGPiece> CurrentRGPiece { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}