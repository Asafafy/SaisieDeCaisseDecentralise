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

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    public partial class TarifsArticles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public TarifsArticles(Home home)
        {
            homeForm = home;

            InitializeComponent();

            txtBxPrixDAchat.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxDernierPrixDAchat.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxCoefficient.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxCoutStandard.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            txtBxPrixDeVente.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);

            txtBxPrixDAchat.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxDernierPrixDAchat.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxCoefficient.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxCoutStandard.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            txtBxPrixDeVente.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);

            dataGridViewCategoriesTarifaires.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTarifsClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCategoriesTarifaires.Rows.Add("Grossistes", "1.5", "230HT", "");
            dataGridViewCategoriesTarifaires.Rows.Add("Détaillants", "2", "230HT", "");
            dataGridViewCategoriesTarifaires.Rows.Add("Vente comptoir", "1.5", "299HT", "");

            dataGridViewTarifsClients.Rows.Add("CARAT", "1.5", "230HT", "5%");
            dataGridViewTarifsClients.Rows.Add("COMPTOIR", "2", "230HT", "");
            dataGridViewTarifsClients.Rows.Add("CISEL", "1.5", "299HT", "");
            dataGridViewTarifsClients.Rows.Add("CISEL", "1.5", "299HT", "");
            dataGridViewTarifsClients.Rows.Add("CLEENBLIJ", "1.5", "299HT", "");
            dataGridViewTarifsClients.Rows.Add("CISEL", "1.5", "299HT", "");
            
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

    }
}
