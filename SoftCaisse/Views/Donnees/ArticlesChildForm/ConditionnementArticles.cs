using Soft_Caisse.Views.Donnees.ArticlesChildForm.ConditionnementChildForm;
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
    public partial class ConditionnementArticles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ConditionnementArticles(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT");
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



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateConditionnement createUpdateConditionnement = new CreateUpdateConditionnement(homeForm);
                homeForm.OpenFormInPanel(createUpdateConditionnement);
                homeForm.formActif = createUpdateConditionnement;
                Close();
            }
        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CreateUpdateConditionnement createUpdateConditionnement = new CreateUpdateConditionnement(homeForm);
                homeForm.OpenFormInPanel(createUpdateConditionnement);
                homeForm.formActif = createUpdateConditionnement;
                Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }











        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================











    }
}
