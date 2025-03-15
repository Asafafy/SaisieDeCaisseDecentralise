using Soft_Caisse.Views.FonctionsViews;
using Soft_Caisse.Views.Operations.VenteComptoirClidForm;
using Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresGammesChildForm;
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
    public partial class VenteComptoir : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public VenteComptoir(Home home)
        {
            homeForm = home;

            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnPanel(panelEnTete, 25);
            BorderRadius.ApplyBorderRaduisOnPanel(panelTotal, 25);

            BorderRadius.ApplyBorderRaduisOnButton(buttonNumeroDocument, 25);
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

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }
        private void buttonRappelTicket_Click(object sender, EventArgs e)
        {
            RappelDocumentsEnAttente rappelDocumentsEnAttente = new RappelDocumentsEnAttente(homeForm);
            homeForm.OpenFormInPanel(rappelDocumentsEnAttente);
            homeForm.formActif = rappelDocumentsEnAttente;
            Close();
        }
        private void buttonFinDeSaisie_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
                ReglementVenteComptoir reglementVenteComptoir = new ReglementVenteComptoir(homeForm);
                homeForm.OpenFormInPanel(reglementVenteComptoir);
                homeForm.formActif = reglementVenteComptoir;
                Close();
            //}
            
        }















        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void VenteComptoir_Load(object sender, EventArgs e)
        {
            txtBxDateTime.Text = DateTime.Now.ToLongDateString();

            dateTimePickerCustom.Visible = false;
        }

        private void txtBxDateTime_Click(object sender, EventArgs e)
        {
            dateTimePickerCustom.Visible = true;
            dateTimePickerCustom.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerCustom_ValueChanged(object sender, EventArgs e)
        {
            txtBxDateTime.Text = dateTimePickerCustom.Value.ToLongDateString();
            dateTimePickerCustom.Visible = false;
        }












        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================












    }
}
