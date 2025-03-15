using Soft_Caisse.Views.FonctionsViews;
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
    public partial class ParametresSocietes : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }








        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ParametresSocietes(Home home)
        {
            this.homeForm = home;

            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnPanel(panelContainerBoutons, 50);

            BorderRadius.ApplyBorderRaduisOnButton(btnCaisses, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnDevises, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnComptabilisation, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnGammes, 25);

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

        private void btnCaisses_Click(object sender, EventArgs e)
        {
            ParametresCaisses parametresCaisses = new ParametresCaisses(homeForm);
            homeForm.OpenFormInPanel(parametresCaisses);
            homeForm.formActif = parametresCaisses;
            Close();
        }

        private void btnDevises_Click(object sender, EventArgs e)
        {
            ParametresDevises parametresDevises = new ParametresDevises(homeForm);
            homeForm.OpenFormInPanel(parametresDevises);
            homeForm.formActif = parametresDevises;
            Close();
        }

        private void btnComptabilisation_Click(object sender, EventArgs e)
        {
            ParametresComptabilisation parametresComptabilisation = new ParametresComptabilisation(homeForm);
            homeForm.OpenFormInPanel(parametresComptabilisation);
            homeForm.formActif = parametresComptabilisation;
            Close();
        }

        private void btnGammes_Click(object sender, EventArgs e)
        {
            ParametresGammes parametresGammes = new ParametresGammes(homeForm);
            homeForm.OpenFormInPanel(parametresGammes);
            homeForm.formActif = parametresGammes;
            Close();
        }
    }
}
