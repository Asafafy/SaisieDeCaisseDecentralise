using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    public partial class InterrogationDuStockArticle : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public InterrogationDuStockArticle(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "5", "6", "7", "8", "9");
        }











        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            ChoixInformationsArticle choixInformationsArticle = new ChoixInformationsArticle(homeForm);
            homeForm.OpenFormInPanel(choixInformationsArticle);
            homeForm.formActif = choixInformationsArticle;
            Close();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================








    }
}
