using Soft_Caisse.Views.Donnees.CaissesChildForm;
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
    public partial class Caisses : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }









        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public Caisses(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Haha", "PMMPPMP", "FJFJFJF", "Haha");
            dataGridView1.Rows.Add("Hhohohoho", "BJBJBJB", "EURO", "Hhohohoho");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro");
            dataGridView1.Rows.Add("Euro", "JFJFJFJF", "EURO", "Euro");
            dataGridView1.Rows.Add("Hihihi", "EURO", "FJFJFJFJF", "Hihihi");
            dataGridView1.Rows.Add("Euro", "EURO", "GAGAGAGA", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro");
            dataGridView1.Rows.Add("Hhehehehe", "EURO", "EURO", "Hhehehehe");
            dataGridView1.Rows.Add("Hihihihihi", "EURO", "EURO", "Hihihihihi");
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



        private void btnVoir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateCaisse createUpdateCaisse = new CreateUpdateCaisse(homeForm);
                homeForm.OpenFormInPanel(createUpdateCaisse);
                homeForm.formActif = createUpdateCaisse;
                Close();
            }
        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateCaisse createUpdateCaisse = new CreateUpdateCaisse(homeForm);
                homeForm.OpenFormInPanel(createUpdateCaisse);
                homeForm.formActif = createUpdateCaisse;
                Close();
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVoir_Click(sender, e);
        }







    }
}
