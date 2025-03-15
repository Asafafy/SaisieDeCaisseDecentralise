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
    public partial class InformationsArticles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public InformationsArticles(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ROUTE ========================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            ChoixInformationsArticle choixInformationsArticle = new ChoixInformationsArticle(homeForm);
            homeForm.OpenFormInPanel(choixInformationsArticle);
            homeForm.formActif = choixInformationsArticle;
            Close();
        }



        private void btnFermer_Click(object sender, EventArgs e)
        {
            btnFermerActiveForm_Click(sender, e);
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================





    }
}
