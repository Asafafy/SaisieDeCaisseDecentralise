using Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresDevisesChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    public partial class ParametresDevises : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ParametresDevises(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "5000");
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



        private void dataGridView1_CellDoubleClick(object sender, EventArgs e)
        {
            btnBilletage_Click(sender, e);
        }



        private void btnBilletage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Billetage billetage = new Billetage(homeForm);
                homeForm.OpenFormInPanel(billetage);
                homeForm.formActif = billetage;
                Close();
            }
        }
    }
}
