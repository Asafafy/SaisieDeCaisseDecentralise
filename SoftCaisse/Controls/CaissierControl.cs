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
        public List<dynamic> detailCaisser = new List<dynamic>();
        public CaisseInfo CaisseInfo;
        public CaissierControl()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
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
            }
            DetailCaisseForm detailCaisseForm = new DetailCaisseForm(detailCaisser);
            detailCaisseForm.Show();
        }
    }
}
