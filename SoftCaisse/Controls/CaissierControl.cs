using SoftCaisse.DTO;
using SoftCaisse.Forms.Caisse;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private readonly FCReglementRepository _fReglementRepository;
        public List<dynamic> detailCaisser = new List<dynamic>();
        public List<dynamic> detailVendeur = new List<dynamic>();
        public List<dynamic> detailCaisse = new List<dynamic>();
        public List<dynamic> soucheVente = new List<dynamic>();
        public List<dynamic> listRegelement = new List<dynamic>();
        public CaisseInfo CaisseInfo;
        public CaissierControl()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
            _fReglementRepository = new FCReglementRepository(_context);    
            var data = _fCaisseRepository.GetAll();
            var reglement = _fReglementRepository.GetAll();
            var listCaissier  = data.Select(caissier=> new { Intitule = caissier.CA_Intitule , CaisseNum = caissier.CA_No }).ToList();
            listRegelement.AddRange(reglement);
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
                var query = _context.F_CAISSE.Join(_context.F_DEPOT, caisse => caisse.DE_No, depot => depot.DE_No, (caisse, depot) => new { CaisseNum = caisse.CA_No, Intitule = caisse.CA_Intitule, NumDepot = caisse.DE_No, Depot = depot.DE_Intitule, Client = caisse.CT_Num, CodeJournal = caisse.JO_Num, SoucheVente = caisse.CA_Souche, VendeurNum = caisse.CO_No, NumCaissier = caisse.CO_NoCaissier }).Where(result=> result.Intitule == Intitule).ToList();
                detailCaisser.Clear();
                detailCaisser.AddRange(query);
                detailVendeurCaisse();
                detailCaissier();
                detailSoucheVente();
            }
            DetailCaisseForm detailCaisseForm = new DetailCaisseForm(detailCaisser, detailVendeur, detailCaisse, soucheVente, CaissierDataGridView);
            detailCaisseForm.Show();
        }

        private void btnNouveauCaissier_Click(object sender, EventArgs e)
        {
            string Intitule = (CaissierDataGridView.CurrentRow.Cells["CA_Intitule"].Value).ToString();
            var query = _context.F_CAISSE.Join(_context.F_DEPOT, caisse => caisse.DE_No, depot => depot.DE_No, (caisse, depot) => new { CaisseNum = caisse.CA_No,Intitule = caisse.CA_Intitule, NumDepot = caisse.DE_No, Depot = depot.DE_Intitule, Client = caisse.CT_Num, CodeJournal = caisse.JO_Num, SoucheVente = caisse.CA_Souche, VendeurNum = caisse.CO_No, NumCaissier = caisse.CO_NoCaissier }).Where(result => result.Intitule == Intitule).ToList();
            detailCaisser.Clear();
            detailCaisser.AddRange(query);
            detailVendeurCaisse();
            detailCaissier();
            detailSoucheVente();
            bool test = true;
            DetailCaisseForm detailCaisseForm = new DetailCaisseForm(detailCaisser, detailVendeur, detailCaisse, soucheVente, test, CaissierDataGridView);
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
                        cbMarque = s.cbIndice
                    }).ToList();
            soucheVente.Clear();
            soucheVente.AddRange(souche);
        }

        private void btnSupprCaissier_Click(object sender, EventArgs e)
        {

            if (CaissierDataGridView.CurrentRow.Index != -1)
            {
                int CANum = (int)(CaissierDataGridView.CurrentRow.Cells["CANo"].Value);
                DialogResult result = MessageBox.Show("Confirmer vous la suppression de cette caisse?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    var contains = listRegelement.Where(reg=>reg.CA_No == CANum).FirstOrDefault();
                    if (contains != null)
                    {
                        MessageBox.Show("Impossibe de supprimer cette caisse car elle est rattaché à un document");
                    }
                    else
                    {
                        var caisse = _context.F_CAISSE.Where(c => c.CA_No == CANum).FirstOrDefault();
                        if (caisse!=null)
                        {
                            _context.F_CAISSE.Remove(caisse);
                            _context.SaveChanges();
                            MessageBox.Show("Caisse supprimée avec succès");
                        }
                    }
                    
                }
                var listCaissier = _context.F_CAISSE.Select(caissier => new { Intitule = caissier.CA_Intitule, CaisseNum = caissier.CA_No }).ToList();
                CaissierDataGridView.DataSource =listCaissier;
            }
        }
    }
}
