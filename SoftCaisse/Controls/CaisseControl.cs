using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Controls
{
    public partial class CaisseControl : UserControl
    {
        public List<string> _caisse;
        public List<dynamic> mode = new List<dynamic>();
        private readonly AppDbContext _context;
        private readonly ClientRepository _clientRepository;
        private readonly ModeReglementRepository _modeReglementRepository;
        public CaisseControl()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new ClientRepository(_context);
            _caisse = _clientRepository.GetCTNumF_CompteT();
            _modeReglementRepository = new ModeReglementRepository(_context);
            LoadClient();
            LoadModeReglement();
            kryptonComboBox3.SelectedIndex = 0;
            kryptonComboBox5.SelectedIndex = 0;
            kryptonComboBox7.SelectedIndex = 0;
        }

        private void btnParamCaisseClose_Click(object sender, EventArgs e)
        {
            Form ParamCaisseForm = this.FindForm();
            if (ParamCaisseForm != null)
            {
                ParamCaisseForm.Close();
            }
        }
        private void LoadClient()
        {
            ClientComptoirCmbx.Items.Clear();
            ClientComptoirCmbx.Items.AddRange(_caisse.ToArray());
            ClientComptoirCmbx.SelectedIndex = 0;

        }
        private void LoadModeReglement()
        {
            var modereglement = _modeReglementRepository.GetAll();
            var modeClean = modereglement.Where(r => r.R_Intitule != "").Select(r => new { Indice = r.cbIndice, Intitule = r.R_Intitule }).ToArray();
            modeReglementCmbx.Items.Clear();
            modeReglementCmbx.DataSource = modeClean;
            modeReglementCmbx.ValueMember = "Indice";
            modeReglementCmbx.DisplayMember = "Intitule";
            modeReglementCmbx.SelectedIndex = 0;

            var caisseModel = _context.P_SOUCHEVENTE.Where(r => r.S_Intitule != "").Select(r => new { Indice = r.cbMarq, Intitule = r.S_Intitule }).ToArray();
            kryptonComboBox4.Items.Clear();
            kryptonComboBox4.DataSource = caisseModel;
            kryptonComboBox4.ValueMember = "Indice";
            kryptonComboBox4.DisplayMember = "Intitule";
            kryptonComboBox4.SelectedIndex = 0;

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
