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

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm.ConditionnementChildForm
{
    public partial class CreateUpdateConditionnement : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateUpdateConditionnement(Home home)
        {
            homeForm = home;

            InitializeComponent();

            txtBxNombreDArticle.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandlePositiveIntegerKeyPress);

            txtBxCodeBarres.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleCodeBarresKeyPress);
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            ConditionnementArticles conditionnementArticles = new ConditionnementArticles(homeForm);
            homeForm.OpenFormInPanel(conditionnementArticles);
            homeForm.formActif = conditionnementArticles;
            Close();
        }
    }
}
