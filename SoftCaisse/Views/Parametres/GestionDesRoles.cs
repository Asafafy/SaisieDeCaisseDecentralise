using Soft_Caisse.Views.Parametres.GestionDesRolesChildForm;
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

namespace Soft_Caisse.Views.Parametres
{
    public partial class GestionDesRoles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }









        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public GestionDesRoles(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
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



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateRoles createUpdateRoles = new CreateUpdateRoles(homeForm);
                homeForm.OpenFormInPanel(createUpdateRoles);
                homeForm.formActif = createUpdateRoles;
                Close();
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateRoles createUpdateRoles = new CreateUpdateRoles(homeForm);
                homeForm.OpenFormInPanel(createUpdateRoles);
                homeForm.formActif = createUpdateRoles;
                Close();
            }
        }
    }
}
