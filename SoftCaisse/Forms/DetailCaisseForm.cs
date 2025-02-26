using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms.Caisse
{
    public partial class DetailCaisseForm : KryptonForm
    {
        private List<dynamic> _caissier = new List<dynamic>();
        private List<dynamic> _vendeur = new List<dynamic>();
        private List<dynamic> _caisse = new List<dynamic>();
        private List<dynamic> _vente = new List<dynamic>();
        private bool modif;
        private readonly AppDbContext _context;
        private readonly F_COMPTETRepository _clientRepository;
        private readonly F_DEPOTRepository _depotRepository;
        private readonly F_JOURNAUXRepository _fJournauxRepository;
        private readonly F_CAISSE f_caisse;
        private readonly F_CAISSERepository _fCaisseRepository;
        private int IdDepot;
        private int IdCaissier;
        private int IdSouche;
        private int IdVendeur;
        private KryptonDataGridView _grid;
        public DetailCaisseForm(List<dynamic> caissier, KryptonDataGridView grid)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new F_COMPTETRepository(_context);
            _depotRepository = new F_DEPOTRepository(_context);
            _fJournauxRepository = new F_JOURNAUXRepository(_context);
            _fCaisseRepository = new F_CAISSERepository(_context);
            _caissier.Clear();
            _caissier = caissier;
            LoadAll();
            LoadDetailsCaisse();
            DepotCaisseCmbx.DisplayMember = "Depot";
            DepotCaisseCmbx.ValueMember = "NumDepot";
            _grid = grid;
        }
        public DetailCaisseForm(List<dynamic> caissier, List<dynamic> vendeur, List<dynamic> detailCaisse, List<dynamic> soucheVente, KryptonDataGridView grid)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new F_COMPTETRepository(_context);
            _depotRepository = new F_DEPOTRepository(_context);
            _fJournauxRepository = new F_JOURNAUXRepository(_context);
            _fCaisseRepository = new F_CAISSERepository(_context);
            _caissier.Clear();
            _caissier = caissier;
            _vendeur.Clear();
            _vendeur = vendeur;
            _caisse.Clear();
            _caisse = detailCaisse;
            _vente.Clear();
            _vente = soucheVente;
            LoadAll();
            LoadCaissier();
            LoadVendeur();
            DepotCaisseCmbx.DisplayMember = "Depot";
            DepotCaisseCmbx.ValueMember = "NumDepot";
            vendeurCmbx.DisplayMember = "InfoVendeur";
            vendeurCmbx.ValueMember = "NumCo";
            caissierCmbx.DisplayMember = "InfoCaisse";
            caissierCmbx.ValueMember = "NumCo";
            soucheVenteCmbx.DisplayMember = "Intitule";
            soucheVenteCmbx.ValueMember = "cbMarque";
            LoadDetailsCaisse();
            modif = false;
            _grid = grid;
        }
        public DetailCaisseForm(List<dynamic> caissier, List<dynamic> vendeur, List<dynamic> detailCaisse, List<dynamic> soucheVente, bool test, KryptonDataGridView grid)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new F_COMPTETRepository(_context);
            _depotRepository = new F_DEPOTRepository(_context);
            _fJournauxRepository = new F_JOURNAUXRepository(_context);
            _fCaisseRepository = new F_CAISSERepository(_context);
            _caissier.Clear();
            _caissier = caissier;
            _vendeur.Clear();
            _vendeur = vendeur;
            _caisse.Clear();
            _caisse = detailCaisse;
            _vente.Clear();
            _vente = soucheVente;
            LoadCaissier();
            LoadNewDetailsCaisse();
            LoadVendeur();
            LoadJournaux();
            DepotCaisseCmbx.DisplayMember = "Depot";
            DepotCaisseCmbx.ValueMember = "NumDepot";
            vendeurCmbx.DisplayMember = "InfoVendeur";
            vendeurCmbx.ValueMember = "NumCo";
            caissierCmbx.DisplayMember = "InfoCaisse";
            caissierCmbx.ValueMember = "NumCo";
            soucheVenteCmbx.DisplayMember = "Intitule";
            soucheVenteCmbx.ValueMember = "cbMarque";
            modif = test;
            _grid = grid;

        }
        public void LoadVendeur()
        {
            var cmbxVendeur = _vendeur.Select(ve => new { NumCo = ve.NumCo, InfoVendeur = ve.InfoVendeur });
            var caissier = _caisse.Select(ca => new { NumCo = ca.NumCo, InfoCaisse = ca.InfoCaisse });
            var souche = _vente.Select(s => new { cbMarque = s.cbMarque, Intitule = s.Intitule, });
            vendeurCmbx.Items.Clear();
            vendeurCmbx.Items.AddRange(cmbxVendeur.ToArray());
            caissierCmbx.Items.Clear();
            caissierCmbx.Items.AddRange(caissier.ToArray());
            soucheVenteCmbx.Items.Clear();
            soucheVenteCmbx.Items.AddRange(souche.ToArray());
        }
        public void LoadJournaux()
        {
            var listJournaux = _fJournauxRepository.GetAll();
            var numJournaux = listJournaux.Select(jrn => jrn.JO_Num).ToArray();
            CodeJournalCaisseCmbx.Items.Clear();
            CodeJournalCaisseCmbx.Items.AddRange(numJournaux);
        }
        public void LoadAll()
        {
            var listdepot = _depotRepository.GetAll();
            var cmbxDepot = listdepot.Select(depot => new { NumDepot = depot.DE_No, Depot = depot.DE_Intitule }).ToArray();
            var listClient = _clientRepository.GetCTNumF_CompteT();
            var listJournaux = _fJournauxRepository.GetAll();
            var numJournaux = listJournaux.Select(jrn => jrn.JO_Num).ToArray();
            DepotCaisseCmbx.Items.Clear();
            ClientCaisseCmbx.Items.Clear();
            CodeJournalCaisseCmbx.Items.Clear();
            DepotCaisseCmbx.Items.AddRange(cmbxDepot);
            ClientCaisseCmbx.Items.AddRange(listClient.ToArray());
            CodeJournalCaisseCmbx.Items.AddRange(numJournaux);
        }
        public void LoadCaissier()
        {
            var listdepot = _depotRepository.GetAll();
            var cmbxDepot = listdepot.Select(depot => new { NumDepot = depot.DE_No, Depot = depot.DE_Intitule }).ToArray();
            var listClient = _clientRepository.GetCTNumF_CompteT();
            DepotCaisseCmbx.Items.Clear();
            DepotCaisseCmbx.Items.AddRange(cmbxDepot);
            ClientCaisseCmbx.Items.Clear();
            ClientCaisseCmbx.Items.AddRange(listClient.ToArray());
        }
        public void LoadNewDetailsCaisse()
        {
            var caisse = _caissier.FirstOrDefault();
            var cmbxDepot = _caissier.Select(depot => new { NumDepot = depot.NumDepot, Depot = depot.Depot }).ToArray();
            var souche = _vente.Select(s => s.Intitule).FirstOrDefault();
            DepotCaisseCmbx.SelectedIndex = DepotCaisseCmbx.FindString(cmbxDepot[cmbxDepot.Length - 1].Depot);
            ClientCaisseCmbx.SelectedIndex = ClientCaisseCmbx.FindString(caisse.Client);
            soucheVenteCmbx.SelectedIndex = soucheVenteCmbx.FindString(souche);
        }
        public void LoadDetailsCaisse()
        {
            var caisse = _caissier.FirstOrDefault();

            txtIntituleCaisse.Text = caisse.Intitule;
            var cmbxDepot = _caissier.Select(depot => new { NumDepot = depot.NumDepot, Depot = depot.Depot }).ToArray();
            var souche = _vente.Where(s => s.cbMarque == caisse.SoucheVente).Select(s => s.Intitule).FirstOrDefault();
            var vendeur = _vendeur.Where(v => v.NumCo == caisse.VendeurNum).Select(v => v.InfoVendeur).FirstOrDefault();
            var detailcaisse = _caisse.Where(c => c.NumCo == caisse.NumCaissier).Select(v => v.InfoCaisse).FirstOrDefault();
            DepotCaisseCmbx.SelectedIndex = DepotCaisseCmbx.FindString(caisse.Depot);
            ClientCaisseCmbx.SelectedIndex = ClientCaisseCmbx.FindString(caisse.Client);
            CodeJournalCaisseCmbx.SelectedIndex = CodeJournalCaisseCmbx.FindString(caisse.CodeJournal);
            if (souche != null)
            {
                soucheVenteCmbx.SelectedIndex = soucheVenteCmbx.FindString(souche);
            }
            if (vendeur != null)
            {
                vendeurCmbx.SelectedIndex = vendeurCmbx.FindString(vendeur);
            }
            if (detailcaisse != null)
            {
                caissierCmbx.SelectedIndex = caissierCmbx.FindString(detailcaisse);
            }


        }

        private void btnModifCaisse_Click(object sender, EventArgs e)
        {
            if (modif)
            {
                F_CAISSE f_CAISSE = new F_CAISSE();
                f_CAISSE.CA_Intitule = txtIntituleCaisse.Text;
                f_CAISSE.DE_No = IdDepot;
                f_CAISSE.CO_No = 0;
                f_CAISSE.CO_NoCaissier = IdCaissier;
                f_CAISSE.CT_Num = ClientCaisseCmbx.Text;
                f_CAISSE.JO_Num = CodeJournalCaisseCmbx.Text;
                f_CAISSE.CA_IdentifCaissier = 0;
                f_CAISSE.N_Comptoir = 1;
                f_CAISSE.N_Clavier = 1;
                f_CAISSE.CA_LignesAfficheur = 0;
                f_CAISSE.CA_ColonnesAfficheur = 0;
                f_CAISSE.CA_ImpTicket = 1;
                f_CAISSE.CA_SaisieVendeur = 0;
                f_CAISSE.CA_Souche = (short?)IdSouche;
                f_CAISSE.cbProt = 0;
                f_CAISSE.cbCreateur = "COLS";
                f_CAISSE.cbModification = DateTime.Now;
                f_CAISSE.cbReplication = 0;
                f_CAISSE.cbFlag = 0;
                f_CAISSE.cbCreation = DateTime.Now;
                _fCaisseRepository.Add(f_CAISSE);
                MessageBox.Show("Ajout effectué avec succès");
                this.Close();
                txtIntituleCaisse.Text = "";
            }
            else
            {
                var caisse = _caissier.FirstOrDefault();
                int caisseNum = caisse.CaisseNum;
                F_CAISSE f_CAISSE = _fCaisseRepository.GetF_CAISSE_By_CA_No(caisseNum);
                f_CAISSE.CA_Intitule = txtIntituleCaisse.Text;
                f_CAISSE.DE_No = IdDepot;
                f_CAISSE.CO_No = IdVendeur;
                f_CAISSE.CO_NoCaissier = IdCaissier;
                f_CAISSE.CT_Num = ClientCaisseCmbx.Text;
                f_CAISSE.JO_Num = CodeJournalCaisseCmbx.Text;
                f_CAISSE.CA_IdentifCaissier = 0;
                f_CAISSE.N_Comptoir = 1;
                f_CAISSE.N_Clavier = 1;
                f_CAISSE.CA_LignesAfficheur = 0;
                f_CAISSE.CA_ColonnesAfficheur = 0;
                f_CAISSE.CA_ImpTicket = 1;
                f_CAISSE.CA_SaisieVendeur = 0;
                f_CAISSE.CA_Souche = (short?)IdSouche;
                f_CAISSE.cbProt = 0;
                f_CAISSE.cbCreateur = "COLS";
                f_CAISSE.cbModification = DateTime.Now;
                f_CAISSE.cbReplication = 0;
                f_CAISSE.cbFlag = 0;
                _fCaisseRepository.Update(f_CAISSE);
                MessageBox.Show("Mise à jour effectuée avec succès");
                this.Close();
                txtIntituleCaisse.Text = "";
            }
            var listCaissier = _context.F_CAISSE.Select(caissier => new { Intitule = caissier.CA_Intitule, CaisseNum = caissier.CA_No }).ToList();
            _grid.DataSource = listCaissier;
        }

        private void DepotCaisseCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdDepot = Cmbx.GetValueMember(DepotCaisseCmbx, "NumDepot", "Depot");
        }

        private void caissierCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            IdCaissier = Cmbx.GetValueMember(caissierCmbx, "NumCo", "InfoCaisse");
        }

        private void soucheVenteCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoucheVente = Cmbx.GetValueMember(soucheVenteCmbx, "cbMarque", "Intitule");
            IdSouche = SoucheVente;
        }

        private void vendeurCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdVendeur = Cmbx.GetValueMember(vendeurCmbx, "NumDepot", "InfoVendeur");
        }
    }
}
