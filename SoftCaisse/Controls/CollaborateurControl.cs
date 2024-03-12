using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SoftCaisse.Models;
using SoftCaisse.Repositories;

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
            var data = listCollabo.Select(collab => new { NomCollabo = collab.CO_Nom, NumCollabo = collab.CO_Caissier }).Where(collab=>collab.NumCollabo == 1).ToList();
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
    }
}
