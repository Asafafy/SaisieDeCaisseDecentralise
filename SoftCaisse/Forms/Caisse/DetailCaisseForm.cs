using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Controls;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms.Caisse
{
    public partial class DetailCaisseForm : KryptonForm
    {
        private List<dynamic> _caissier = new List<dynamic>();
        private List<dynamic> _vendeur = new List<dynamic>();
        private List<dynamic> _caisse = new List<dynamic>();
        private List<dynamic> _vente = new List<dynamic>();
        private readonly AppDbContext _context;
        private readonly ClientRepository _clientRepository;
        private readonly FDepotRepository _depotRepository;
        private readonly FJournauxRepository _fJournauxRepository;
        public DetailCaisseForm(List<dynamic> caissier)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new ClientRepository(_context);
            _depotRepository =  new FDepotRepository(_context);
            _fJournauxRepository = new FJournauxRepository(_context);
            _caissier.Clear();
            _caissier = caissier;
            LoadAll(); 
            LoadDetailsCaisse();
            DepotCaisseCmbx.DisplayMember = "Depot";
            DepotCaisseCmbx.ValueMember = "NumDepot";
        }
        public DetailCaisseForm(List<dynamic> caissier, List<dynamic> vendeur, List<dynamic> detailCaisse, List<dynamic> soucheVente)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new ClientRepository(_context);
            _depotRepository = new FDepotRepository(_context);
            _fJournauxRepository = new FJournauxRepository(_context);
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
            LoadDetailsCaisse();
            LoadNewDetailsCaisse();
            LoadVendeur();
            DepotCaisseCmbx.DisplayMember = "Depot";
            DepotCaisseCmbx.ValueMember = "NumDepot";
            vendeurCmbx.DisplayMember = "InfoVendeur";
            vendeurCmbx.ValueMember = "NumCo";
            caissierCmbx.DisplayMember = "InfoCaisse";
            caissierCmbx.ValueMember = "NumCo";
            soucheVenteCmbx.DisplayMember = "Intitule";
            soucheVenteCmbx.ValueMember = "cbMarque";
        }
        public DetailCaisseForm(List<dynamic> caissier, List<dynamic> vendeur, List<dynamic> detailCaisse, List<dynamic> soucheVente, bool test)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new ClientRepository(_context);
            _depotRepository = new FDepotRepository(_context);
            _fJournauxRepository = new FJournauxRepository(_context);
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
            DepotCaisseCmbx.DisplayMember = "Depot";
            DepotCaisseCmbx.ValueMember = "NumDepot";
            vendeurCmbx.DisplayMember = "InfoVendeur";
            vendeurCmbx.ValueMember = "NumCo";
            caissierCmbx.DisplayMember = "InfoCaisse";
            caissierCmbx.ValueMember = "NumCo";
            soucheVenteCmbx.DisplayMember = "Intitule";
            soucheVenteCmbx.ValueMember = "cbMarque";

        }
        public void LoadVendeur()
        {
            var cmbxVendeur = _vendeur.Select(ve => new { NumCo = ve.NumCo, InfoVendeur = ve.InfoVendeur });
            var caissier = _caisse.Select(ca => new { NumCo = ca.NumCo, InfoCaisse = ca.InfoCaisse });
            var souche = _vente.Select(s => new { Intitule = s.Intitule, cbMarque = s.cbMarque });
            vendeurCmbx.Items.Clear();
            vendeurCmbx.Items.AddRange(cmbxVendeur.ToArray());
            caissierCmbx.Items.Clear();
            caissierCmbx.Items.AddRange(caissier.ToArray());
            soucheVenteCmbx.Items.Clear();
            soucheVenteCmbx.Items.AddRange(souche.ToArray());



        }
        public void LoadAll()
        {
            var listdepot = _depotRepository.GetAll();
            var cmbxDepot = listdepot.Select(depot=>new { NumDepot = depot.DE_No, Depot = depot.DE_Intitule}).ToArray();
            var listClient = _clientRepository.GetCTNumF_CompteT();
            var listJournaux = _fJournauxRepository.GetAll();
            var numJournaux = listJournaux.Select(jrn=>jrn.JO_Num).ToArray();
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
            DepotCaisseCmbx.Text = cmbxDepot[cmbxDepot.Length - 1].ToString();
            ClientCaisseCmbx.Text = caisse.Client;
        }
        public void LoadDetailsCaisse()
        {
            var caisse = _caissier.FirstOrDefault();
            txtIntituleCaisse.Text = caisse.Intitule;
            var cmbxDepot = _caissier.Select(depot=>new { NumDepot = depot.NumDepot, Depot = depot.Depot }).ToArray();
            DepotCaisseCmbx.Text = cmbxDepot[cmbxDepot.Length-1].ToString();
            ClientCaisseCmbx.Text = caisse.Client;
            CodeJournalCaisseCmbx.Text = caisse.CodeJournal;
        }
    }
}
