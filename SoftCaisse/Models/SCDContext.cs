using SoftCaisse.Utils.Connection;
using System;
using System.Data.Entity;
using System.IO;
using System.Windows.Forms;

namespace SoftCaisse.Models
{
    public class SCDContext : DbContext
    {
        private static string connectionString = "";
        public SCDContext() : base("ServeurCfg.txt") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}