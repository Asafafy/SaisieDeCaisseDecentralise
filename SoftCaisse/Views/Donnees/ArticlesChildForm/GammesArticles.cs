using Soft_Caisse.Views.Donnees.ArticlesChildForm.GammeChildForm;
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
    public partial class GammesArticles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public GammesArticles(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "CONDITIONNEMENT", "ASAFA", "ASAFA");
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            CreateUpdateEnumereGamme createUpdateEnumereGamme = new CreateUpdateEnumereGamme(homeForm);
            homeForm.OpenFormInPanel(createUpdateEnumereGamme);
            homeForm.formActif = createUpdateEnumereGamme;
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            CreateUpdateEnumereGamme createUpdateEnumereGamme = new CreateUpdateEnumereGamme(homeForm);
            homeForm.OpenFormInPanel(createUpdateEnumereGamme);
            homeForm.formActif = createUpdateEnumereGamme;
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }


    }
}
