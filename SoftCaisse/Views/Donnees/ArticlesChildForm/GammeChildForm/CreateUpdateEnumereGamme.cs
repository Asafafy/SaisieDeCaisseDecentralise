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

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm.GammeChildForm
{
    public partial class CreateUpdateEnumereGamme : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateUpdateEnumereGamme(Home home)
        {
            homeForm = home;

            InitializeComponent();

            txtBxPrixDAchat.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxCoutStandart.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxDernierPrixDAchat.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);

            txtBxPrixDAchat.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxCoutStandart.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxDernierPrixDAchat.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);

            txtBxCodeBarres.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleCodeBarresKeyPress);

        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            GammesArticles gammesArticles = new GammesArticles(homeForm);
            homeForm.OpenFormInPanel(gammesArticles);
            homeForm.formActif = gammesArticles;
            Close();
        }





















    }
}
