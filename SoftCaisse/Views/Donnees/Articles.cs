using Soft_Caisse.Views.Donnees.ArticlesChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Soft_Caisse.Views.Donnees
{
    public partial class Articles : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }









        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public Articles(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Hhohohoho", "BJBJBJB", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Euro", "JFJFJFJF", "EURO");
            dataGridView1.Rows.Add("Hihihi", "EURO", "FJFJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "GAGAGAGA");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO");
            dataGridView1.Rows.Add("Hhehehehe", "EURO", "EURO");
            dataGridView1.Rows.Add("Hihihihihi", "EURO", "EURO");
        }










        // =========================================================================================================
        // FONCTIONS ===============================================================================================
        // =========================================================================================================
        private void AfficherArticleRechercher(string termeARechercher)
        {
            termeARechercher = termeARechercher.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool isVisible = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!(cell.Value == null || !cell.Value.ToString().Contains(termeARechercher) || !cell.Value.ToString().Contains(termeARechercher)))
                        {
                            isVisible = true;
                            break;
                        }
                    }

                    row.Visible = isVisible;
                }
            }
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }



        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ChoixInformationsArticle choixInformationsArticle = new ChoixInformationsArticle(homeForm);
                homeForm.OpenFormInPanel(choixInformationsArticle);
                homeForm.formActif = choixInformationsArticle;
                Close();
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOuvrir_Click(sender, e);
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void txtBxBarreDeRecherche_TextChanged(object sender, EventArgs e)
        {
            string termeARechercher = txtBxBarreDeRecherche.Text;
            AfficherArticleRechercher(termeARechercher);
        }














    }
}
