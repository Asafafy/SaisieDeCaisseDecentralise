using Soft_Caisse.Views.Parametres.GestionDesUtilisateursChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Parametres
{
    public partial class GestionDesUtilisateurs : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public GestionDesUtilisateurs(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...");
        }











        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }

        
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateUtilisateurs createUpdateUtilisateurs = new CreateUpdateUtilisateurs(homeForm);
                homeForm.OpenFormInPanel(createUpdateUtilisateurs);
                homeForm.formActif = createUpdateUtilisateurs;
                Close();
            }
        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateUtilisateurs createUpdateUtilisateurs = new CreateUpdateUtilisateurs(homeForm);
                homeForm.OpenFormInPanel(createUpdateUtilisateurs);
                homeForm.formActif = createUpdateUtilisateurs;
                Close();
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }

    }
}
