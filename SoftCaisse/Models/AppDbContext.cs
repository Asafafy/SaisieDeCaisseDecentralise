using SoftCaisse.Utils.Connection;
using System.Data.Entity;

namespace SoftCaisse.Models
{
    public partial class AppDbContext : DbContext
    {
        private static string connectionString = "";
        public AppDbContext()
            : base(Db.GetConnectionString("ServeurSage.txt"))
        {
        }
        public virtual DbSet<P_PREFERENCES> P_PREFERENCES { get; set; }
        public virtual DbSet<F_DOCREGL> F_DOCREGL { get; set; }
        public virtual DbSet<F_CATALOGUE> F_CATALOGUE { get; set; }
        public virtual DbSet<F_LIGNEARCHIVE> F_LIGNEARCHIVE { get; set; }
        public virtual DbSet<F_REGLEARCHIVE> F_REGLEARCHIVE { get; set; }
        public virtual DbSet<P_ANALYTIQUE> P_ANALYTIQUE { get; set; }
        public virtual DbSet<F_DOCCURRENTPIECE> F_DOCCURRENTPIECE { get; set; }
        public virtual DbSet<F_FAMILLE> F_FAMILLE { get; set; }
        public virtual DbSet<F_COMPTET> F_COMPTET { get; set; }
        public virtual DbSet<F_COMPTEA> F_COMPTEA { get; set; }
        public virtual DbSet<F_CAISSE> F_CAISSE { get; set; }
        public virtual DbSet<F_DEPOT> F_DEPOT { get; set; }
        public virtual DbSet<F_BILLETPIECE> F_BILLETPIECE { get; set; }
        public virtual DbSet<F_TICKETARCHIVE> F_TICKETARCHIVE { get; set; }
        public virtual DbSet<F_DOCENTETE> F_DOCENTETE { get; set; }
        public virtual DbSet<F_DOCLIGNE> F_DOCLIGNE { get; set; }
        public virtual DbSet<F_JOURNAUX> F_JOURNAUX { get; set; }
        public virtual DbSet<F_COLLABORATEUR> F_COLLABORATEUR { get; set; }
        public virtual DbSet<F_ARTICLE> F_ARTICLE { get; set; }
        public virtual DbSet<P_DEVISE> P_DEVISE { get; set; }
        public virtual DbSet<P_SOUCHEVENTE> P_SOUCHEVENTE { get; set; }
        public virtual DbSet<F_CREGLEMENT> F_CREGLEMENT { get; set; }
        public virtual DbSet<F_REGLECH> F_REGLECH { get; set; }
        public virtual DbSet<F_TAXE> F_TAXE { get; set; }
        public virtual DbSet<F_ARTCOMPTA> F_ARTCOMPTA { get; set; }
        public virtual DbSet<P_REGLEMENT> P_REGLEMENT { get; set; }
        public virtual DbSet<P_UNITE> P_UNITE { get; set; }
        public virtual DbSet<F_ARTCLIENT> F_ARTCLIENT { get; set; }
        public virtual DbSet<P_CATTARIF> P_CATTARIF { get; set; }
        public virtual DbSet<F_PAYS> F_PAYS { get; set; }
        public virtual DbSet<F_GLOSSAIRE> F_GLOSSAIRE { get; set; }
        public virtual DbSet<F_ARTGLOSS> F_ARTGLOSS { get; set; }
        public virtual DbSet<F_ARTICLEMEDIA> F_ARTICLEMEDIA { get; set; }
        public virtual DbSet<F_MODELE> F_MODELE { get; set; }
        public virtual DbSet<F_ARTMODELE> F_ARTMODELE { get; set; }
        public virtual DbSet<F_DEPOTEMPL> F_DEPOTEMPL { get; set; }
        public virtual DbSet<F_CONDITION> F_CONDITION { get; set; }
        public virtual DbSet<P_GAMME> P_GAMME { get; set; }
        public virtual DbSet<F_ARTGAMME> F_ARTGAMME { get; set; }
        public virtual DbSet<F_ARTENUMREF> F_ARTENUMREF { get; set; }
        public virtual DbSet<F_ENUMGAMME> F_ENUMGAMME { get; set; }
        public virtual DbSet<F_ARTSTOCK> F_ARTSTOCK { get; set; }
        public virtual DbSet<F_ARTSTOCKEMPL> F_ARTSTOCKEMPL { get; set; }
        public virtual DbSet<F_GAMSTOCK> F_GAMSTOCK { get; set; }
        public virtual DbSet<F_GAMSTOCKEMPL> F_GAMSTOCKEMPL { get; set; }
        public virtual DbSet<P_PARAMETRECIAL> P_PARAMETRECIAL { get; set; }
        public virtual DbSet<F_COMPTEG> F_COMPTEG { get; set; }
        public virtual DbSet<P_EXPEDITION> P_EXPEDITION { get; set; }
        public virtual DbSet<F_LIVRAISON> F_LIVRAISON { get; set; }
        public virtual DbSet<P_CONDLIVR> P_CONDLIVR { get; set; }
        public virtual DbSet<P_CATCOMPTA> P_CATCOMPTA { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<P_PREFERENCES>()
            .Property(e => e.PR_RefEsc)
            .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.PR_RefTaxeNP)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.CG_NumCli)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.CG_NumFrs)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.CT_Num)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.CG_NumVirement)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.PR_EMail)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.CG_NumComptoirDebit)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.CG_NumComptoirCredit)
                .IsUnicode(false);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.PR_MontantMaxTicket)
                .HasPrecision(24, 6);

            modelBuilder.Entity<P_PREFERENCES>()
                .Property(e => e.PR_Certificat)
                .IsUnicode(false);
            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.DO_Piece)
                .IsUnicode(false);

            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.DR_Libelle)
                .IsUnicode(false);

            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.DR_Pourcent)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.DR_Montant)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.DR_MontantDev)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.cbCreateur)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F_DOCREGL>()
                .Property(e => e.DR_AdressePaiement)
                .IsUnicode(false);

            modelBuilder.Entity<P_CATTARIF>()
                .Property(e => e.CT_Intitule)
                .IsUnicode(false);
            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Intitule)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Rupture01A_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Rupture02A_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Rupture03A_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Rupture04A_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Rupture05A_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.A_Rupture06A_Nom)
                .IsUnicode(false);

            modelBuilder.Entity<P_ANALYTIQUE>()
                .Property(e => e.CA_Num)
                .IsUnicode(false);
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
            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.TA_Piece)
                .IsUnicode(false);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.AR_Ref)
                .IsUnicode(false);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Design)
                .IsUnicode(false);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_PrixUnitaire)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_PUTTC)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Qte)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Remise01REM_Valeur)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Remise02REM_Valeur)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Remise03REM_Valeur)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Taxe1)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Taxe2)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_Taxe3)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LS_NoSerie)
                .IsUnicode(false);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_PoidsNet)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_PrixRU)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LA_CMUP)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.EU_Enumere)
                .IsUnicode(false);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.EU_Qte)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.LS_Complement)
                .IsUnicode(false);

            modelBuilder.Entity<F_LIGNEARCHIVE>()
                .Property(e => e.cbCreateur)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<F_REGLEARCHIVE>()
                .Property(e => e.TA_Piece)
                .IsUnicode(false);

            modelBuilder.Entity<F_REGLEARCHIVE>()
                .Property(e => e.RA_Montant)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_REGLEARCHIVE>()
                .Property(e => e.RA_MontantDev)
                .HasPrecision(24, 6);

            modelBuilder.Entity<F_REGLEARCHIVE>()
                .Property(e => e.cbCreateur)
                .IsFixedLength()
                .IsUnicode(false);
            modelBuilder.Entity<F_CATALOGUE>()
                .Property(e => e.CL_Intitule)
                .IsUnicode(false);

            modelBuilder.Entity<F_CATALOGUE>()
                .Property(e => e.CL_Code)
                .IsUnicode(false);

            modelBuilder.Entity<F_CATALOGUE>()
                .Property(e => e.cbCreateur)
                .IsFixedLength()
                .IsUnicode(false);

        }
    }
}
