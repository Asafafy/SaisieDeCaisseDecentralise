using Soft_Caisse.Views.FonctionsViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations.SaisieDesReglementsChildForm
{
    public partial class VisualisationDUnReglement : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }











        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public VisualisationDUnReglement(Home home)
        {
            homeForm = home;

            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnPanel(panelTotal, 50);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            SaisieDesReglements saisieDesReglements = new SaisieDesReglements(homeForm);
            homeForm.OpenFormInPanel(saisieDesReglements);
            homeForm.formActif = saisieDesReglements;
            Close();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            btnFermerActiveForm_Click(sender, e);
        }












    }
}
