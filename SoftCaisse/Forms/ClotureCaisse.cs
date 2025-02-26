using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.FormCaisse;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms.ClotureCaisse
{
    public partial class ClotureCaisse : KryptonForm
    {
        // ======================================================================================================
        // DEBUT DECLARATION DES VARIABLES ======================================================================
        // ======================================================================================================
        private readonly AppDbContext _context;
        // ======================================================================================================
        // DEBUT DECLARATION DES VARIABLES ======================================================================
        // ======================================================================================================










        // ======================================================================================================
        // DEBUT CONSTRUCTEUR ===================================================================================
        // ======================================================================================================
        public ClotureCaisse()
        {
            _context = new AppDbContext();
            InitializeComponent();

            CmbBxCaisseDebut.DataSource =_context.F_CAISSE.Select(u=>new {Value= u.CA_No,Text = u.CA_Intitule }).ToArray();
            CmbBxCaisseFin.DataSource =_context.F_CAISSE.Select(u=>new {Value= u.CA_No,Text = u.CA_Intitule }).ToArray();
            CmbBxSouche.DataSource =_context.P_SOUCHEVENTE.Where(u=> u.S_Valide==1 ).Select(u=>new {Value= u.cbMarq,Text=u.S_Intitule}).ToArray();
            CmbBxCaisseDebut.ValueMember = "Value";
            CmbBxCaisseDebut.DisplayMember = "Text";
            CmbBxCaisseFin.ValueMember = "Value";
            CmbBxCaisseFin.DisplayMember = "Text";
            CmbBxSouche.ValueMember = "Value";
            CmbBxSouche.DisplayMember = "Text";
            CmbBxRegroupementsTickets.SelectedIndex = 1;
        }
        // ======================================================================================================
        // FIN CONSTRUCTEUR =====================================================================================
        // ======================================================================================================










        // ======================================================================================================
        // DEBUT EVENEMENTS =====================================================================================
        // ======================================================================================================
        private void cloturer_caisse(object sender, EventArgs e)
        {
            int fcaisse = 0;
            int scaisse = 0;
            Int32.TryParse(CmbBxCaisseDebut.SelectedValue.ToString(),out fcaisse);
            Int32.TryParse(CmbBxCaisseFin.SelectedValue.ToString(),out scaisse);
            List<F_DOCENTETE> liste_doc=_context.F_DOCENTETE.Where(u => u.CA_No >= fcaisse && u.CA_No <= scaisse && u.DO_Domaine == 3 && u.DO_Type == 30 && u.DO_Cloture==0).ToList();            
            DateTime currentTime=DateTime.Now;
            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;
            TimeSpan time = new TimeSpan(hours, minutes, seconds);
            string formattedTime = time.ToString("hhmmss");
            formattedTime = "000" + formattedTime;
            List<F_CREGLEMENT> list_reglement=new List<F_CREGLEMENT>();
            List<Freglement> replement_report= new List<Freglement>();
            foreach (var entete in liste_doc)
            {
                entete.DO_Cloture = 1;
                entete.DO_Type = 6;
                entete.DO_Domaine = 0;
                List<F_DOCLIGNE> liste_ligne = _context.F_DOCLIGNE.Where(u => u.DO_Piece==entete.DO_Piece).ToList();

                var reglement = _context.F_CREGLEMENT.Join(_context.F_REGLECH,post=>post.RG_No,meta=>meta.RG_No,(post,meta)=>new {Post=post,Meta=meta}).Where(u=>u.Meta.DO_Piece == entete.DO_Piece).ToList();
                F_TICKETARCHIVE f_TICKETARCHIVE = new F_TICKETARCHIVE()
                {
                    CA_No = entete.CA_No.Value,
                    CO_NoCaissier = entete.CO_NoCaissier,
                    cbCO_NoCaissier = entete.cbCO_NoCaissier,
                    TA_Date = currentTime,
                    TA_Heure = formattedTime,
                    CT_Num = entete.DO_Tiers,
                    DO_Piece = entete.DO_Piece,
                    cbProt = entete.cbProt,
                    cbCreateur = entete.cbCreateur,
                    cbModification = currentTime,
                    cbReplication = entete.cbReplication,
                    cbFlag = entete.cbFlag,
                    TA_Piece = entete.DO_Piece
                };
                _context.F_TICKETARCHIVE.Add(f_TICKETARCHIVE);
                _context.SaveChanges();
                foreach (var item in reglement)
                {
                    item.Post.RG_Cloture = 1;
                    F_REGLEARCHIVE f_REGLEARCHIVE = new F_REGLEARCHIVE()
                    {
                        CA_No = item.Post.CA_No,
                        N_Devise = item.Post.N_Devise,
                        N_Reglement = item.Post.N_Reglement,
                        RA_Date = item.Post.RG_Date,
                        RA_Montant = item.Post.RG_Montant,
                        RA_MontantDev = item.Post.RG_MontantDev,
                        cbCA_No = item.Post.cbCA_No,
                        TA_Piece = entete.DO_Piece,
                    };
                    _context.F_REGLEARCHIVE.Add(f_REGLEARCHIVE);
                    list_reglement.Add(item.Post);                    
                }
                _context.SaveChanges();
                foreach (var ligne in liste_ligne)
                {
                    F_LIGNEARCHIVE f_LigneArchive = new F_LIGNEARCHIVE()
                    {
                        AR_Ref=ligne.AR_Ref,
                        LA_Design=ligne.DL_Design,
                        LA_PrixUnitaire=ligne.DL_PrixRU,
                        LA_PUTTC=ligne.DL_PUTTC,
                        LA_TTC =ligne.DL_TTC,
                        LA_Qte=ligne.DL_Qte,
                        LA_Ligne=ligne.DL_Ligne,
                        LA_Taxe1=ligne.DL_Taxe1,
                        LA_PoidsNet=ligne.DL_PoidsNet,
                        LA_CMUP=ligne.DL_CMUP,
                        LA_PrixRU=ligne.DL_PrixRU,
                        EU_Enumere=ligne.EU_Enumere,
                        TA_Piece = entete.DO_Piece
                    };
                    _context.F_LIGNEARCHIVE.Add(f_LigneArchive);
                    _context.SaveChanges();
                }
            }
            if (CmbBxRegroupementsTickets.SelectedIndex == 0)
            {
                foreach (var item in list_reglement)
                {
                    replement_report.Add(new Freglement()
                    {
                        Date = item.RG_Date.Value.ToShortDateString(),
                        Montant = (double)item.RG_Montant,
                        Client = item.CT_NumPayeur,
                        Type = _context.P_REGLEMENT.FirstOrDefault(u => u.cbMarq == item.N_Reglement).R_Intitule,
                        Caisse = _context.F_CAISSE.FirstOrDefault(u => u.cbMarq == item.CA_No).CA_Intitule
                    });
                }
            }

            if (CmbBxRegroupementsTickets.SelectedIndex == 1)
            {
                list_reglement.GroupBy(i => new { Caisse = i.CA_No, Date = i.RG_Date, Client = i.CT_NumPayeur, Types = i.N_Reglement, semaine = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(i.RG_Date.Value, CalendarWeekRule.FirstDay, DayOfWeek.Monday) }).ToList()
                .ForEach(u =>
                {
                    replement_report.Add(new Freglement()
                    {
                        Caisse = _context.F_CAISSE.FirstOrDefault(a => a.CA_No == u.Key.Caisse).CA_Intitule,
                        Date = "Semaine " + u.Key.semaine,
                        Client = u.Key.Client,
                        Montant = (double)u.Sum(a => a.RG_Montant.Value),
                        Type = _context.P_REGLEMENT.FirstOrDefault(a => a.cbMarq + "" == u.Key.Types + "").R_Intitule
                    });
                });
            }
            if (CmbBxRegroupementsTickets.SelectedIndex == 2)
            {
                list_reglement.GroupBy(i => new { Caisse = i.CA_No, Date = i.RG_Date, Client = i.CT_NumPayeur, Types = i.N_Reglement, Month = i.RG_Date.Value.Month, Year = i.RG_Date.Value.Year }).ToList()
                .ForEach(u =>
                {
                    replement_report.Add(new Freglement()
                    {
                        Caisse = _context.F_CAISSE.FirstOrDefault(a => a.CA_No == u.Key.Caisse).CA_Intitule,
                        Date = u.Key.Month + "/" + u.Key.Year,
                        Client = u.Key.Client,
                        Montant = (double)u.Sum(i => i.RG_Montant.Value),
                        Type = _context.P_REGLEMENT.FirstOrDefault(a => a.cbMarq + "" == u.Key.Types + "").R_Intitule
                    });
                });
            }
            Close();
            if (replement_report.Count > 0)
            {
                Reporting caisse=new Reporting(replement_report);
                caisse.Show();
            }
            MessageBox.Show("Caisse Cloturé avec succès","SUCCESS",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




        // ======================================================================================================
        // FIN EVENEMENTS =======================================================================================
        // ======================================================================================================

    }
}
