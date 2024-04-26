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
            modeReglementCmbx.DisplayMember = "Intitule";
            modeReglementCmbx.ValueMember = "Indice";
        }

        private void btnParamCaisseClose_Click(object sender, EventArgs e)
        {
            Form ParamCaisseForm = this.FindForm();
            if(ParamCaisseForm !=null) 
            { 
                ParamCaisseForm.Close();
            }
        }
        private void LoadClient()
        {
            ClientComptoirCmbx.Items.Clear();
            ClientComptoirCmbx.Items.AddRange(_caisse.ToArray());
        }
        private void LoadModeReglement()
        {
            var modereglement = _modeReglementRepository.GetAll();
            var modeClean = modereglement.Select(r => new { Indice = r.cbIndice, Intitule = r.R_Intitule }).Where(r => r.Intitule!="").ToArray();
            //mode.Clear();
            //mode.AddRange(modeClean);
            //var arrayMode = mode.ToArray();
            modeReglementCmbx.Items.Clear();
            modeReglementCmbx.Items.AddRange(modeClean);
        }
    }
}
