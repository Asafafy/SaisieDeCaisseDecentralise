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
    public partial class Familles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public Familles(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Haha", "PMMPPMP", "FJFJFJF", "Haha", "Haha");
            dataGridView1.Rows.Add("Hhohohoho", "BJBJBJB", "EURO", "Hhohohoho", "Hhohohoho");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro", "Euro");
            dataGridView1.Rows.Add("Euro", "JFJFJFJF", "EURO", "Euro", "Euro");
            dataGridView1.Rows.Add("Hihihi", "EURO", "FJFJFJFJF", "Hihihi", "Hihihi");
            dataGridView1.Rows.Add("Euro", "EURO", "GAGAGAGA", "Euro", "Euro");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Euro", "Euro");
            dataGridView1.Rows.Add("Hhehehehe", "EURO", "EURO", "Hhehehehe", "Hhehehehe");
            dataGridView1.Rows.Add("Hihihihihi", "EURO", "EURO", "Hihihihihi", "Hihihihihi");
        }








        // =========================================================================================================
        // EVENEMENTS ============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }







    }
}
