using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.FondCaisse;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils.Global;

namespace SoftCaisse.Forms.OuvertureCaisse
{
    public partial class OuvertureCaisseForm : KryptonForm
    {
        private List<dynamic> _caisse = new List<dynamic>();
        private List<dynamic> _collabo = new List<dynamic>();
        private readonly AppDbContext _context;
        private  FCaisseRepository _fCaisseRepository;
        private readonly FCollaborateurRepository _fCollaborateurRepository;
        private int IdCaisse;
        private int IdCaissier;
        public OuvertureCaisseForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
            _fCollaborateurRepository = new FCollaborateurRepository(_context);
            var listCaisse = _fCaisseRepository.GetAll();
            var data = _fCollaborateurRepository.GetAll();
            _caisse.AddRange(listCaisse);
            _collabo.AddRange(data);
            OuvertureCaisseCmbx.DisplayMember = "Intitule";
            OuvertureCaisseCmbx.ValueMember = "Numero";
            OuvertureCaissierCmbx.DisplayMember = "NomCollabo";
            OuvertureCaissierCmbx.ValueMember = "CollaboNum";
            LoadData();
      
        }

        private void btnOuvrCaisseClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Parent = null;
        }
        public void LoadData()
        {
            var listCaisse = _caisse.Select(c => new { Numero = c.CA_No, Intitule = c.CA_Intitule }).ToArray();
            var listCollabo = _collabo.Where(c => c.CO_Caissier == 1).Select(c => new { CollaboNum = c.CO_No, NomCollabo = c.CO_Nom.ToString() + " " + c.CO_Prenom }).ToArray();
            OuvertureCaisseCmbx.Items.Clear();
            OuvertureCaissierCmbx.Items.Clear();
            OuvertureCaisseCmbx.Items.AddRange(listCaisse);
            OuvertureCaissierCmbx.Items.AddRange(listCollabo);
            var test = listCaisse[0].Intitule.ToString();
            OuvertureCaisseCmbx.SelectedIndex = 0;
            OuvertureCaissierCmbx.SelectedIndex = 0;
            OuvertureCaisseCmbx.SelectionLength = 0;
            OuvertureCaissierCmbx.SelectionLength = 0;
            txtOuvertureCaissePwd.Select();
        }
        private void OuvertureCaisseCmbx_Click(object sender, EventArgs e)
        {
            CaisseOuvert.CaisseID = OuvertureCaisseCmbx.SelectedValue.ToString();
            CaisseOuvert.CaisseText = OuvertureCaisseCmbx.SelectedText.ToString();
        }

        private void btnOuvertureCaisse_Click(object sender, EventArgs e)
        {
            if (fondCaisseCbox.Checked)
            {
                this.Close();
                FondCaisseForm fondCaisseForm = new FondCaisseForm(IdCaisse, IdCaissier);
                fondCaisseForm.Show();
            }
            else
            {
                this.Close();
                VenteComptoirForm venteComptoir = new VenteComptoirForm();
                venteComptoir.Show();
            }
           
        }

        private void OuvertureCaisseCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCaisse = Cmbx.GetValueMember(OuvertureCaisseCmbx, "Numero", "Intitule");
        }

        private void OuvertureCaissierCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCaissier = Cmbx.GetValueMember(OuvertureCaissierCmbx, "CollaboNum", "NomCollabo");
        }
    }
}
