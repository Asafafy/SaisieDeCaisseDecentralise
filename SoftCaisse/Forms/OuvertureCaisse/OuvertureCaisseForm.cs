using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftCaisse.Forms.OuvertureCaisse
{
    public partial class OuvertureCaisseForm : KryptonForm
    {
        private List<dynamic> _caisse = new List<dynamic>();
        private List<dynamic> _collabo = new List<dynamic>();
        private readonly AppDbContext _context;
        private  FCaisseRepository _fCaisseRepository;
        private readonly FCollaborateurRepository _fCollaborateurRepository;
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
           
        }
    }
}
