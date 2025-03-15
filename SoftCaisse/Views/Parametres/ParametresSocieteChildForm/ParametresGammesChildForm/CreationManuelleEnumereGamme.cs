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

namespace Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresGammesChildForm
{
    public partial class CreationManuelleEnumereGamme : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreationManuelleEnumereGamme(Home home)
        {
            homeForm = home;

            InitializeComponent();

            txtBxPrixDAchatDeLEnumere.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxPrixPourGrossistes.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxPrixPourLesDetaillants.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxPrixPourLesClientsAuComptoir.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);

            txtBxPrixDAchatDeLEnumere.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxPrixPourGrossistes.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxPrixPourLesDetaillants.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxPrixPourLesClientsAuComptoir.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);

            txtBxCodeBarres.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleCodeBarresKeyPress);
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            ParametresGammes parametresGammes = new ParametresGammes(homeForm);
            homeForm.OpenFormInPanel(parametresGammes);
            homeForm.formActif = parametresGammes;
            Close();
        }





    }
}
