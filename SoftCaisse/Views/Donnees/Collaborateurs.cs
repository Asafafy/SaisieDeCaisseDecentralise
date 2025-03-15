using Soft_Caisse.Views.Donnees.CollaborateursChildForm;
using Soft_Caisse.Views.Parametres.ParametresSociete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees
{
    public partial class Collaborateurs : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public Collaborateurs(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Hhohohoho", "BJBJBJB", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "JFJFJFJF", "EURO");
            dataGridView1.Rows.Add("Hihihi", "EURO", "FJFJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "GAGAGAGA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Hhehehehe", "EURO", "EURO");
            dataGridView1.Rows.Add("Hihihihihi", "EURO", "EURO");
        }











        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }



        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateCollaborateurs createUpdateCollaborateurs = new CreateUpdateCollaborateurs(homeForm);
                homeForm.OpenFormInPanel(createUpdateCollaborateurs);
                homeForm.formActif = createUpdateCollaborateurs;
                Close();
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            CreateUpdateCollaborateurs createUpdateCollaborateurs = new CreateUpdateCollaborateurs(homeForm);
            homeForm.OpenFormInPanel(createUpdateCollaborateurs);
            homeForm.formActif = createUpdateCollaborateurs;
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOuvrir_Click(sender, e);
        }
    }
}
