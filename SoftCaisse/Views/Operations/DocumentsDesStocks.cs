using Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations
{
    public partial class DocumentsDesStocks : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public DocumentsDesStocks(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Haha", "PMMPPMP", "FJFJFJF", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Hhohohoho", "BJBJBJB", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "JFJFJFJF", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Hihihi", "EURO", "FJFJFJFJF", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "GAGAGAGA", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Hhehehehe", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
            dataGridView1.Rows.Add("Hihihihihi", "EURO", "EURO", "Haha", "PMMPPMP", "FJFJFJF");
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
                        if (cell.Value != null && cell.Value.ToString().Contains(termeARechercher))
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










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void txtBxBarreDeRecherche_TextChanged(object sender, EventArgs e)
        {
            string termeARechercher = txtBxBarreDeRecherche.Text;
            AfficherArticleRechercher(termeARechercher);
        }



        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            ChoixCreationMouvementsDesStocks choixCreationMouvementsDesStocks = new ChoixCreationMouvementsDesStocks(homeForm);
            homeForm.OpenFormInPanel(choixCreationMouvementsDesStocks);
            homeForm.formActif = choixCreationMouvementsDesStocks;
            Close();
        }



        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UpdateDocumentsDesStocks updateDocumentsDesStocks = new UpdateDocumentsDesStocks(homeForm);
                homeForm.OpenFormInPanel(updateDocumentsDesStocks);
                homeForm.formActif = updateDocumentsDesStocks;
                Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonOuvrir_Click(sender, e);
        }















    }
}
