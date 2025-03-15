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
    public partial class CreateReglement : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }















        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateReglement(Home home)
        {
            homeForm = home;

            InitializeComponent();

            textBoxMontant.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            textBoxMontantDevise.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            textBoxCours.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandlePositiveNumericOnlyKeyPress);

            textBoxMontant.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            textBoxMontantDevise.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            textBoxCours.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
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



        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            btnFermerActiveForm_Click(sender, e);
        }










        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void CreateReglement_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxDateimpaye.Text = "";
            textBoxEcheanceContrepartie.Text = "";

            dateTimePickerDate.Visible = false;
            dateTimePickerDateImpaye.Visible = false;
            dateTimePickerEcheanceContrepartie.Visible = false;
        }



        private void textBoxDate_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Visible = true;
            dateTimePickerDate.Focus();
            SendKeys.Send("%{DOWN}");
        }



        private void textBoxDateimpaye_Click(object sender, EventArgs e)
        {
            dateTimePickerDateImpaye.Visible = true;
            dateTimePickerDateImpaye.Focus();
            SendKeys.Send("%{DOWN}");
        }



        private void textBoxEcheanceContrepartie_Click(object sender, EventArgs e)
        {
            dateTimePickerEcheanceContrepartie.Visible = true;
            dateTimePickerEcheanceContrepartie.Focus();
            SendKeys.Send("%{DOWN}");
        }



        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            textBoxDate.Text = dateTimePickerDate.Value.ToLongDateString();
            dateTimePickerDate.Visible = false;
        }



        private void dateTimePickerDateImpaye_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateimpaye.Text = dateTimePickerDateImpaye.Value.ToLongDateString();
            dateTimePickerDateImpaye.Visible = false;
        }



        private void dateTimePickerEcheanceContrepartie_ValueChanged(object sender, EventArgs e)
        {
            textBoxEcheanceContrepartie.Text = dateTimePickerEcheanceContrepartie.Value.ToLongDateString();
            dateTimePickerEcheanceContrepartie.Visible = false;
        }























    }
}
