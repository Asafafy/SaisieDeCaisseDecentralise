using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils;

namespace SoftCaisse.Forms.FondCaisse
{
    public partial class FondCaisseForm : KryptonForm
    {
        private readonly AppDbContext _context;
        private readonly DeviseRepository _deviseRepository;
        private readonly FBilletageRepository _fbilletageRepository;
        private readonly FCReglementRepository _fcreglementRepository;
        public List<dynamic> devise = new List<dynamic>();
        public List<dynamic> coursDevise = new List<dynamic>();
        public List<dynamic> billetage = new List<dynamic>();
        public List<dynamic> freglement = new List<dynamic>();
        private int NDevise;
        private int IdCaisse;
        private int IdCaissier;
        public FondCaisseForm(int idCaisse, int idCaissier)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _deviseRepository = new DeviseRepository(_context);
            _fbilletageRepository = new FBilletageRepository(_context);
            _fcreglementRepository = new FCReglementRepository(_context);
            var dataDevise = _deviseRepository.GetAll();
            var deviseCombobox = dataDevise.Where(d=>d.D_Intitule !="").Select(d=>new {NumDevise = d.cbMarq, Intitule = d.D_Intitule});
            var courDevise = dataDevise.Select(d => new { NumDevise = d.cbMarq, Cours = d.D_Cours });
            var dataBillet = _fbilletageRepository.GetAll();
            var dataGridBillet = dataBillet.Select(b=>new {NumDevise = b.N_Devise,IntituleBillet = b.BI_Intitule}).ToList();
            var dataReglement = _fcreglementRepository.GetAll();
            devise.AddRange(deviseCombobox);
            freglement.AddRange(dataReglement);
            coursDevise.AddRange(courDevise);
            deviseCmbx.DisplayMember = "Intitule";
            deviseCmbx.ValueMember = "NumDevise";
            IdCaisse = idCaisse;
            IdCaissier = idCaissier;
            LoadDevise();
        }
        private void LoadDevise()
        {
            deviseCmbx.Items.Clear();
            deviseCmbx.Items.AddRange(devise.ToArray());
        }
        private void btnFondCaisseClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Parent = null;
        }

        private void deviseCmbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            NDevise = Cmbx.GetValueMember(deviseCmbx, "NumDevise", "Intitule");
            if(NDevise != 0)
            {
                var list_piece = _fbilletageRepository.GetAll().Where(u => u.N_Devise == NDevise).ToList();
                List<F_BILLETPIECE> billet_piece = new List<F_BILLETPIECE>();
                billet_piece.AddRange((IEnumerable<F_BILLETPIECE>)list_piece);
                fondCaisseDatagridView.DataSource = billet_piece;
            }
        }

        private void fondCaisseDatagridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (fondCaisseDatagridView.Columns[e.ColumnIndex].Name == "Quantite")
            {
                int sum = 0;
                fondCaisseDatagridView["Valeur", e.RowIndex].Value = Convert.ToString(Convert.ToInt32(fondCaisseDatagridView["Quantite", e.RowIndex].Value) * Convert.ToInt32(fondCaisseDatagridView["ValeurSansQté", e.RowIndex].Value));
                foreach (DataGridViewRow row in fondCaisseDatagridView.Rows)
                {
                    sum += Convert.ToInt32(row.Cells[fondCaisseDatagridView.Columns["Valeur"].Index].Value);
                }
                montantTotalLbl.Text = sum.ToString();
            }
        }

        private void montantTotalLbl_TextChanged(object sender, EventArgs e)
        {
            btnValiderFondCaisse.Enabled = true;
        }

        private void btnValiderFondCaisse_Click(object sender, EventArgs e)
        {
            string dateString = "1753-01-01";
            DateTime dateImpaye = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);

            // Get the current date and time
            DateTime currentTime = DateTime.Now;

            // Extract the hour, minute, and second components
            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;

            // Create a TimeSpan object
            TimeSpan time = new TimeSpan(hours, minutes, seconds);

            // Format the time as a string with the desired format: 000203359
            string formattedTime = time.ToString("hhmmss");

            // Add three leading zeros before the formatted time
            formattedTime = "000" + formattedTime;

            int count = freglement.Count();
            var cours = coursDevise.Where(c => c.NumDevise == NDevise).Select(c=>c.Cours).FirstOrDefault();
            decimal total = decimal.Parse(montantTotalLbl.Text);
            decimal montant = (decimal)total / (decimal)cours;
            try
            {
                F_CREGLEMENT regl = new F_CREGLEMENT
                {
                    RG_No = count + 1,
                    CT_NumPayeur = null,
                    RG_Date = DateTime.Now,
                    RG_Reference = "",
                    RG_Libelle = "Déclaration fond de caisse",
                    RG_Montant = Math.Round(montant, 2),
                    RG_MontantDev = total,
                    N_Reglement = 3,
                    RG_Impute = 0,
                    RG_Compta= 0,
                    EC_No = 0,
                    RG_Type = 2,
                    RG_Cours = cours,
                    N_Devise = (short?)NDevise,
                    JO_Num = "CAIS",
                    RG_Impaye = dateImpaye,
                    RG_TypeReg = 2,
                    RG_Heure = formattedTime,
                    RG_Piece = "",
                    CA_No = IdCaisse,
                    CO_NoCaissier = IdCaissier,
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
                    cbCreationUser = null,
                    cbHash = null,
                    cbHashVersion = 1,
                    cbHashDate = DateTime.Now,
                    cbHashOrder = null

                };
                _context.F_CREGLEMENT.Add(regl);
                _context.SaveChanges();
                this.Close();
                MessageBox.Show("Opération réussie");
            }
            catch (Exception message)
            {

                MessageBox.Show(message.ToString());
            }
           
            
        }

    }
}
