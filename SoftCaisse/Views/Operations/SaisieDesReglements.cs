using Soft_Caisse.Views.FonctionsViews;
using Soft_Caisse.Views.Operations.SaisieDesReglementsChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations
{
    public partial class SaisieDesReglements : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================

        public SaisieDesReglements(Home home)
        {
            homeForm = home;

            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnPanel(flowLayoutPanel1, 50);
            BorderRadius.ApplyBorderRaduisOnPanel(panel1, 50);

            BorderRadius.ApplyBorderRaduisOnButton(buttonSelectionner, 25);
            BorderRadius.ApplyBorderRaduisOnButton(buttonReglerEtImputer, 25);
            BorderRadius.ApplyBorderRaduisOnButton(buttonVisualiser, 25);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla", "dix", "onze");
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

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            btnFermerActiveForm_Click((object)sender, e);
        }

        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            UpdateReglement saisieDesReglements = new UpdateReglement(homeForm);
            homeForm.OpenFormInPanel(saisieDesReglements);
            homeForm.formActif = saisieDesReglements;
            Close();
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            CreateReglement createReglement = new CreateReglement(homeForm);
            homeForm.OpenFormInPanel(createReglement);
            homeForm.formActif = createReglement;
            Close();
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectionDesEcheancesARegler selectionDesEcheancesARegler = new SelectionDesEcheancesARegler(homeForm);
                homeForm.OpenFormInPanel(selectionDesEcheancesARegler);
                homeForm.formActif = selectionDesEcheancesARegler;
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un règlement d'abord", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonReglerEtImputer_Click(object sender, EventArgs e)
        {
            ReglerEtImputerEnMemeTemps reglerEtImputerEnMemeTemps = new ReglerEtImputerEnMemeTemps(homeForm);
            homeForm.OpenFormInPanel(reglerEtImputerEnMemeTemps);
            homeForm.formActif = reglerEtImputerEnMemeTemps;
            Close();
        }

        private void buttonVisualiser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                VisualisationDUnReglement visualisationDUnReglement = new VisualisationDUnReglement(homeForm);
                homeForm.OpenFormInPanel(visualisationDUnReglement);
                homeForm.formActif = visualisationDUnReglement;
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un règlement d'abord", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }















        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================













    }
}
