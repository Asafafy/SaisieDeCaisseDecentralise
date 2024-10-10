using SoftCaisse.Forms.CollaboDetail;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Controls
{
    public partial class CollaborateurControl : UserControl
    {
        private readonly AppDbContext _context;
        private readonly F_COLLABORATEURRepository _fCollaborateurRepository;
        public CollaborateurControl()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCollaborateurRepository = new F_COLLABORATEURRepository(_context);
            var listCollabo = _fCollaborateurRepository.GetAll();
            var data = listCollabo.Select(collab => new { CO_No = collab.CO_No, NomCollabo = collab.CO_Nom, PrenomCollabo = collab.CO_Prenom, FonctionCollab = collab.CO_Fonction, NumCollabo = collab.CO_Caissier }).Where(collab => collab.NumCollabo == 1).ToList();
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
            if (collaboDataGridView.CurrentRow.Index != -1)
            {
                int caisse = 0;
                string Intitule = (collaboDataGridView.CurrentRow.Cells["CO_No"].Value).ToString();
                int.TryParse(Intitule, out caisse);
                CollaboDetailForm collaboDetailForm = new CollaboDetailForm(caisse);
                collaboDetailForm.Show();
            }
        }

        private void btnNouveauCaissier_Click(object sender, EventArgs e)
        {
            CollaboDetailForm collaboDetailForm = new CollaboDetailForm(0);
            collaboDetailForm.Show();
        }

        private void btnSupprCaissier_Click(object sender, EventArgs e)
        {

            if (collaboDataGridView.CurrentRow.Index != -1)
            {
                int CANum = (int)(collaboDataGridView.CurrentRow.Cells["CO_No"].Value);
                DialogResult result = MessageBox.Show("Confirmer vous la suppression de cette caisse?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    var contains = _context.F_COLLABORATEUR.Where(reg => reg.CO_No == CANum).FirstOrDefault();
                    if (contains != null)
                    {
                        MessageBox.Show("Impossibe de supprimer cette caisse car elle est rattaché à un document");
                    }
                    else
                    {
                        var caisse = _context.F_COLLABORATEUR.Where(c => c.CO_No == CANum).FirstOrDefault();
                        if (caisse != null)
                        {
                            _context.F_COLLABORATEUR.Remove(caisse);
                            _context.SaveChanges();
                            MessageBox.Show("Caisse supprimée avec succès");
                        }
                    }

                }
                var listCollabo = _fCollaborateurRepository.GetAll();
                var data = listCollabo.Select(collab => new { CO_No = collab.CO_No, NomCollabo = collab.CO_Nom, PrenomCollabo = collab.CO_Prenom, FonctionCollab = collab.CO_Fonction, NumCollabo = collab.CO_Caissier }).Where(collab => collab.NumCollabo == 1).ToList();
                collaboDataGridView.DataSource = data;
            }
        }
    }
}
