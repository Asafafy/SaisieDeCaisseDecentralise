using SoftCaisse.Utils.Connection;
using System;
using System.Data.Entity;
using System.IO;
using System.Windows.Forms;

namespace SoftCaisse.Models
{
    public partial class AppDbContext : DbContext
    {
        private static string connectionString = "";
        public AppDbContext()
            : base(Db.GetConnectionString("ServeurSage.txt"))
        {
        }
        public virtual DbSet<F_DOCCURRENTPIECE> F_DOCCURRENTPIECE { get; set; }
        public virtual DbSet<F_COMPTET> F_COMPTET { get; set; }
        public virtual DbSet<F_CAISSE> F_CAISSE { get; set; }
        public virtual DbSet<F_DEPOT> F_DEPOT { get; set; }
        public virtual DbSet<F_BILLETPIECE> F_BILLETPIECE { get; set; }
        public virtual DbSet<F_TICKETARCHIVE> F_TICKETARCHIVE { get; set; }
        public virtual DbSet<F_DOCENTETE> F_DOCENTETE { get; set; }
        public virtual DbSet<F_DOCLIGNE> F_DOCLIGNE { get; set; }
        public virtual DbSet<F_JOURNAUX> F_JOURNAUX { get; set; }
        public virtual DbSet<F_COLLABORATEUR> F_COLLABORATEUR { get;set; }
        public virtual DbSet<F_ARTICLE> F_ARTICLE {  get; set; }
        public virtual DbSet<P_DEVISE> P_DEVISE { get; set; }
        public virtual DbSet<P_SOUCHEVENTE> P_SOUCHEVENTE { get; set; }
        public virtual DbSet<F_CREGLEMENT> F_CREGLEMENT { get; set; }
        public virtual DbSet<F_REGLECH> F_REGLECH { get; set; }
        public virtual DbSet<F_TAXE> F_TAXE { get; set; }
        public virtual DbSet<F_ARTCOMPTA> F_ARTCOMPTA { get; set; }
        public virtual DbSet<P_REGLEMENT> P_REGLEMENT { get; set; }
        public virtual DbSet<F_ARTSTOCK> F_ARTSTOCK { get; set; }
        public virtual DbSet<P_UNITE> P_UNITE { get; set; }
        public virtual DbSet<F_ARTCLIENT> F_ARTCLIENT { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<F_DOCCURRENTPIECE>()
                .Property(e => e.DC_Piece)
                .IsUnicode(false);

            modelBuilder.Entity<F_DOCCURRENTPIECE>()
                .Property(e => e.cbCreateur)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Num)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Intitule)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CG_NumPrinc)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Qualite)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Classement)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Complement)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_CodePostal)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Ville)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_CodeRegion)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Pays)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Raccourci)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Ape)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Identifiant)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Siret)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique01)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique02)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique03)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique04)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique05)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique06)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique07)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique08)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique09)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Statistique10)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Encours)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Assurance)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_NumPayeur)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Taux01)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Taux02)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Taux03)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Taux04)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CA_Num)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Telecopie)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_EMail)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Site)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Coface)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvFormeJuri)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvEffectif)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvCA)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvResultat)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvRegul)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvCotation)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_SvObjetMaj)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CA_NumIFRS)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_NumCentrale)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_RepresentInt)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_RepresentNIF)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_EdiCode)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_EdiCodeSage)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_LangueISO2)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.CT_LinkedIn)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.cbCreateur)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.Capital_social)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.Actionnaire_Pal)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.Score_Banque_de_France)
                .IsUnicode(false);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.Total_points_fidélité)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_COMPTET>()
                .Property(e => e.Points_fidélité_restants)
                .HasPrecision(24, 6);
        }
    }
}
