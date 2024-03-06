using SoftCaisse.DTO;
using SoftCaisse.Forms.Caisse;
using SoftCaisse.Migrations;
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

namespace SoftCaisse.Controls
{
    public partial class CaissierControl : UserControl
    {
        private readonly AppDbContext _context;
        private readonly FCaisseRepository _fCaisseRepository;
        private readonly FDepotRepository _fDepotRepository;
        private readonly FCollaborateurRepository _fCollaborateurRepository;
        private readonly PSoucheVenteRepository _pSoucheVenteRepository;
        public List<dynamic> detailCaisser = new List<dynamic>();
        public List<dynamic> detailVendeur = new List<dynamic>();
        public List<dynamic> detailCaisse = new List<dynamic>();
        public List<dynamic> soucheVente = new List<dynamic>();
        public CaisseInfo CaisseInfo;
        public CaissierControl()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
            _fCollaborateurRepository = new FCollaborateurRepository(_context);
            _pSoucheVenteRepository =  new PSoucheVenteRepository(_context);
            var data = _fCaisseRepository.GetAll();
            var listCaissier  = data.Select(caissier=> new { Intitule = caissier.CA_Intitule }).ToList();

            CaissierDataGridView.DataSource = listCaissier;
        }

        private void btnCaissierClose_Click(object sender, EventArgs e)
        {
            Form StructureCaisseForm = this.FindForm();
            if (StructureCaisseForm != null)
            {
                StructureCaisseForm.Close();
            }
        }

        private void CaissierDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
            if (CaissierDataGridView.CurrentRow.Index != -1)
            {
                string Intitule = (CaissierDataGridView.CurrentRow.Cells["CA_Intitule"].Value).ToString();
                var query = _context.F_CAISSE.Join(_context.F_DEPOT, caisse => caisse.DE_No, depot => depot.DE_No, (caisse, depot) => new { Intitule = caisse.CA_Intitule, NumDepot = caisse.DE_No, Depot = depot.DE_Intitule, Client = caisse.CT_Num, CodeJournal = caisse.JO_Num}).Where(result=> result.Intitule == Intitule).ToList();
                detailCaisser.Clear();
                detailCaisser.AddRange(query);
                detailVendeurCaisse();
                detailCaissier();
                detailSoucheVente();
            }
            DetailCaisseForm detailCaisseForm = new DetailCaisseForm(detailCaisser, detailVendeur, detailCaisse, soucheVente);
            detailCaisseForm.Show();
        }

        private void btnNouveauCaissier_Click(object sender, EventArgs e)
        {
            string Intitule = (CaissierDataGridView.CurrentRow.Cells["CA_Intitule"].Value).ToString();
            var query = _context.F_CAISSE.Join(_context.F_DEPOT, caisse => caisse.DE_No, depot => depot.DE_No, (caisse, depot) => new { Intitule = caisse.CA_Intitule, NumDepot = caisse.DE_No, Depot = depot.DE_Intitule, Client = caisse.CT_Num, CodeJournal = caisse.JO_Num }).Where(result => result.Intitule == Intitule).ToList();
            detailCaisser.Clear();
            detailCaisser.AddRange(query);
            detailVendeurCaisse();
            detailCaissier();
            detailSoucheVente();
            bool test = true;
            DetailCaisseForm detailCaisseForm = new DetailCaisseForm(detailCaisser, detailVendeur, detailCaisse, soucheVente, test);
            detailCaisseForm.Show();
        }
        public void detailVendeurCaisse()
        {
            var vendeur = _context.F_COLLABORATEUR
              .Where(ve => ve.CO_Vendeur == 1)
              .Select(ve => new {
                  NumCo = ve.CO_No,
                  InfoVendeur = ve.CO_Nom + " " + ve.CO_Prenom
              }).ToList();
            detailVendeur.Clear();
            detailVendeur.AddRange(vendeur);
        }
        public void detailCaissier()
        {
            var cassier = _context.F_COLLABORATEUR
            .Where(ve => ve.CO_Caissier == 1)
            .Select(ve => new {
                NumCo = ve.CO_No,
                InfoCaisse = ve.CO_Nom + " " + ve.CO_Prenom
            }).ToList();
            detailCaisse.Clear();
            detailCaisse.AddRange(cassier);
        }
        public void detailSoucheVente()
        {
            var souche = _context.P_SOUCHEVENTE
                .Where(s => s.S_Valide == 1)
                .Select(s => new {
                        Intitule = s.S_Intitule,
                        cbMarque = s.cbMarq
                    }).ToList();
            soucheVente.Clear();
            soucheVente.AddRange(souche);
        }
    }
}
