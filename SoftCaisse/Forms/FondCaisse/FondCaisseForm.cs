using System;
using System.Collections.Generic;
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
        public List<dynamic> devise = new List<dynamic>();
        public List<dynamic> billetage = new List<dynamic>();
        
        private int NDevise;
        public FondCaisseForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _deviseRepository = new DeviseRepository(_context);
            _fbilletageRepository = new FBilletageRepository(_context);
         
            var dataDevise = _deviseRepository.GetAll();
            var deviseCombobox = dataDevise.Where(d=>d.D_Intitule !="").Select(d=>new {NumDevise = d.cbMarq, Intitule = d.D_Intitule});
            var dataBillet = _fbilletageRepository.GetAll();
            var dataGridBillet = dataBillet.Select(b=>new {NumDevise = b.N_Devise,IntituleBillet = b.BI_Intitule}).ToList();
            devise.AddRange(deviseCombobox);
            deviseCmbx.DisplayMember = "Intitule";
            deviseCmbx.ValueMember = "NumDevise";
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

        }

    }
}
