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

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    public partial class ChoixInformationsArticle : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ChoixInformationsArticle(Home home)
        {
            homeForm = home;

            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnPanel(panelContainerBoutons, 50);

            BorderRadius.ApplyBorderRaduisOnButton(btnInformations, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnConditionnement, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnGammes, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnTarifs, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnMedias, 25);
            BorderRadius.ApplyBorderRaduisOnButton(btnInterrogationDuStock, 25);
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            Articles articles = new Articles(homeForm);
            homeForm.OpenFormInPanel(articles);
            homeForm.formActif = articles;
            Close();
        }

        private void btnInformations_Click(object sender, EventArgs e)
        {
            InformationsArticles informationsArticles = new InformationsArticles(homeForm);
            homeForm.OpenFormInPanel(informationsArticles);
            homeForm.formActif = informationsArticles;
            Close();
        }

        private void btnConditionnement_Click(object sender, EventArgs e)
        {
            ConditionnementArticles conditionnementArticles = new ConditionnementArticles(homeForm);
            homeForm.OpenFormInPanel(conditionnementArticles);
            homeForm.formActif = conditionnementArticles;
            Close();
        }

        private void btnGammes_Click(object sender, EventArgs e)
        {
            GammesArticles gammesArticles = new GammesArticles(homeForm);
            homeForm.OpenFormInPanel(gammesArticles);
            homeForm.formActif = gammesArticles;
            Close();
        }

        private void btnTarifs_Click(object sender, EventArgs e)
        {
            TarifsArticles tarifsArticles = new TarifsArticles(homeForm);
            homeForm.OpenFormInPanel(tarifsArticles);
            homeForm.formActif = tarifsArticles;
            Close();
        }

        private void btnMedias_Click(object sender, EventArgs e)
        {
            MediasArticles mediasArticles = new MediasArticles(homeForm);
            homeForm.OpenFormInPanel(mediasArticles);
            homeForm.formActif = mediasArticles;
            Close();
        }

        private void btnInterrogationDuStock_Click(object sender, EventArgs e)
        {
            InterrogationDuStockArticle interrogationDuStockArticle = new InterrogationDuStockArticle(homeForm);
            homeForm.OpenFormInPanel(interrogationDuStockArticle);
            homeForm.formActif = interrogationDuStockArticle;
            Close();
        }














        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================















    }
}
