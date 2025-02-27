using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms.FondCaisse
{
    public partial class FondCaisseDevisForm : KryptonForm
    {
        private readonly AppDbContext _appDbContext;
        private readonly int _caisse;
        private readonly int _caissier;
        public FondCaisseDevisForm(int caisse,int caissier)
        {
            InitializeComponent();
            _appDbContext = new AppDbContext();
            List<P_DEVISE> dEVISEs = _appDbContext.P_DEVISE.Where(u => !string.IsNullOrEmpty(u.D_Intitule)).ToList();
            GridViewFondCaisse.ReadOnly = false;
            _caisse = caisse;
            _caissier = caissier;
            foreach (var devis in dEVISEs)
            {
                GridViewFondCaisse.Rows.Add(devis.D_Intitule, "", devis.cbMarq);
            }
        }


        private void SauvegardeButton_Click(object sender, EventArgs e)
        {
            int count = _appDbContext.F_CREGLEMENT.Max(u=>u.RG_No).Value;
            string dateString = "1753-01-01";
            DateTime dateImpaye = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
            DateTime currentTime = DateTime.Now;
            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;
            TimeSpan time = new TimeSpan(hours, minutes, seconds);
            string formattedTime = time.ToString("hhmmss");
            formattedTime = "000" + formattedTime;
            try
            {
                F_CAISSE caisse = _appDbContext.F_CAISSE.FirstOrDefault(u => u.cbMarq == _caisse);
                foreach (DataGridViewRow item in GridViewFondCaisse.Rows)
                {
                    count++;
                    string devises = item.Cells[0].Value + "";
                    string deviseId = item.Cells[2].Value + "";
                    var p_devise = _appDbContext.P_DEVISE.FirstOrDefault(c => c.cbMarq + "" == deviseId);
                    decimal total = 0;
                    decimal.TryParse(deviseId, out total);
                    decimal montant = p_devise.D_Cours.Value != 0 ? total / p_devise.D_Cours.Value : total;
                    F_CREGLEMENT regl = new F_CREGLEMENT
                    {
                        RG_No = count,
                        CT_NumPayeur = null,
                        RG_Date = DateTime.Now,
                        RG_Reference = "",
                        RG_Libelle = "Déclaration fond de caisse",
                        RG_Montant = Math.Round(montant, 2),
                        RG_MontantDev = total,
                        N_Reglement = 3,
                        RG_Impute = 0,
                        RG_Compta = 0,
                        EC_No = 0,
                        RG_Type = 2,
                        RG_Cours = p_devise.D_Cours.Value,
                        N_Devise = (short?)p_devise.cbMarq,
                        JO_Num = caisse.JO_Num,
                        RG_Impaye = dateImpaye,
                        RG_TypeReg = 2,
                        RG_Heure = formattedTime,
                        RG_Piece = "",
                        CA_No = _caisse,
                        CO_NoCaissier = _caissier,
                        RG_Banque = 0,
                        RG_Transfere = 0,
                        RG_Cloture = 0,
                        RG_Ticket = 1,
                        RG_Souche = 0,
                        CT_NumPayeurOrig = null,
                        RG_DateEchCont = dateImpaye,
                        CG_NumEcart = null,
                        JO_NumEcart = null,
                        RG_MontantEcart = (decimal?)0.000000,
                        RG_NoBonAchat = 0,
                        RG_Valide = 1,
                        RG_Anterieur = (decimal?)0.000000,
                        RG_MontantCommission = (decimal?)0.000000,
                        RG_MontantNet = (decimal?)0.000000,
                        cbProt = 0,
                        cbCreateur = "COLS",
                        cbModification = DateTime.Now,
                        cbReplication = 0,
                        cbFlag = 0,
                        cbCreation = DateTime.Now,
                        cbHashVersion = 1,
                        cbHashDate = DateTime.Now
                    };

                    _appDbContext.F_CREGLEMENT.Add(regl);
                    _appDbContext.SaveChanges();

                }
                MessageBox.Show("Opération réussie", "COMMENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message Erreur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }
    }
}
