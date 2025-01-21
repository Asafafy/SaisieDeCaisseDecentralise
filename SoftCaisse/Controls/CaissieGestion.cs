using SoftCaisse.DTO;
using SoftCaisse.Forms.Caisse;
using SoftCaisse.Forms.GestionCaisse;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Controls
{
    public partial class CaissieGestion : UserControl
    {
        private readonly AppDbContext _context;
        private readonly F_CAISSERepository _fCaisseRepository;
        private readonly F_DEPOTRepository _fDepotRepository;
        private readonly F_COLLABORATEURRepository _fCollaborateurRepository;
        private readonly P_SOUCHEVENTERepository _pSoucheVenteRepository;
        private readonly F_CREGLEMENTRepository _fReglementRepository;
        public List<dynamic> detailCaisser = new List<dynamic>();
        public List<dynamic> detailVendeur = new List<dynamic>();
        public List<dynamic> detailCaisse = new List<dynamic>();
        public List<dynamic> soucheVente = new List<dynamic>();
        public List<dynamic> listRegelement = new List<dynamic>();
        public CaisseInfo CaisseInfo;
        public CaissieGestion()
        {
            InitializeComponent();

            _context = new AppDbContext();
            _fCaisseRepository = new F_CAISSERepository(_context);
            _fReglementRepository = new F_CREGLEMENTRepository(_context);

            var data = _fCaisseRepository.GetAll();
            var reglement = _fReglementRepository.GetAll();
            var listCaissier  = data.Select(caissier => new { Intitule = caissier.CA_Intitule , CaisseNum = caissier.CA_No }).ToList();
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
                MouvementCaisse detailCaisseForm = new MouvementCaisse(Intitule);
                detailCaisseForm.Show();
            }
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
    }
}
