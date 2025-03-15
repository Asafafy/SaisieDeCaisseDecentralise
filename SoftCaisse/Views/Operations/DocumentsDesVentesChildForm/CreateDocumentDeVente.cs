using Soft_Caisse.Views.Donnees;
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

namespace Soft_Caisse.Views.Operations.DocumentsDesVentesChildForm
{
    public partial class CreateDocumentDeVente : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateDocumentDeVente(Home home)
        {
            homeForm = home;

            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnPanel(flowLayoutPanel1, 50);

            BorderRadius.ApplyBorderRaduisOnButton(buttonInformations, 25);
            BorderRadius.ApplyBorderRaduisOnButton(buttonValider, 25);
            BorderRadius.ApplyBorderRaduisOnButton(buttonImprimer, 25);
        }















        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            DocumentsDesVentes documentsDesVentes = new DocumentsDesVentes(homeForm);
            homeForm.OpenFormInPanel(documentsDesVentes);
            homeForm.formActif = documentsDesVentes;
            Close();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            btnFermerActiveForm_Click((object)sender, e);
        }












        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void CreateDocumentDeVente_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxDateLivraisonPrevue.Text = "";
            textBoxDateLivraisonRealisee.Text = "";

            dateTimePickerDate.Visible = false;
            dateTimePickerDateLivraisonPrevue.Visible = false;
            dateTimePickerDateLivraisonRealisee.Visible = false;
        }

        private void textBoxDate_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Visible = true;
            dateTimePickerDate.Focus();
            SendKeys.Send("%{DOWN}");
        }


        private void textBoxDateLivraisonPrevue_Click(object sender, EventArgs e)
        {
            dateTimePickerDateLivraisonPrevue.Visible = true;
            dateTimePickerDateLivraisonPrevue.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void textBoxDateLivraisonRealisee_Click(object sender, EventArgs e)
        {
            dateTimePickerDateLivraisonRealisee.Visible = true;
            dateTimePickerDateLivraisonRealisee.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            textBoxDate.Text = dateTimePickerDate.Value.ToLongDateString();
            dateTimePickerDate.Visible = false;
        }

        private void dateTimePickerDateLivraisonPrevue_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateLivraisonPrevue.Text = dateTimePickerDateLivraisonPrevue.Value.ToLongDateString();
            dateTimePickerDateLivraisonPrevue.Visible = false;
        }

        private void dateTimePickerDateLivraisonRealisee_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateLivraisonRealisee.Text = dateTimePickerDateLivraisonRealisee.Value.ToLongDateString();
            dateTimePickerDateLivraisonRealisee.Visible = false;
        }














        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================

    }
}
