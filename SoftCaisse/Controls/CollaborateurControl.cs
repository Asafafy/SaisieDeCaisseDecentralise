using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Forms.CollaboDetail;

namespace SoftCaisse.Controls
{
    public partial class CollaborateurControl : UserControl
    {
        private readonly AppDbContext context;
        private readonly FCollaborateurRepository _fCollaborateurRepository;
        public CollaborateurControl()
        {
            InitializeComponent();
            context = new AppDbContext();
            _fCollaborateurRepository = new FCollaborateurRepository(context);
            var listCollabo = _fCollaborateurRepository.GetAll();
            var data = listCollabo.Select(collab => new { NomCollabo = collab.CO_Nom, PrenomCollabo = collab.CO_Prenom, FonctionCollab = collab.CO_Fonction, NumCollabo = collab.CO_Caissier }).Where(collab=>collab.NumCollabo == 1).ToList();
            collaboDataGridView.DataSource = data;
        }

        private void btnCollaboClose_Click(object sender, EventArgs e)
        {
            Form StructureCaisseForm = this.FindForm();
            if (StructureCaisseForm != null)
            {
                StructureCaisseForm.Close();
            }
        }

        private void collaboDataGridView_DoubleClick(object sender, EventArgs e)
        {
            CollaboDetailForm collaboDetailForm = new CollaboDetailForm();
            collaboDetailForm.Show();
        }
    }
}
