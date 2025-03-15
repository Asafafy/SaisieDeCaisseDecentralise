using Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm;
using Soft_Caisse.Views.Operations.DocumentsDesVentesChildForm;
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
    public partial class DocumentsDesVentes : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public DocumentsDesVentes(Home home)
        {
            homeForm = home;

            InitializeComponent();

            listBoxFiltre.Items.Add("Tous les documents");
            listBoxFiltre.Items.Add("Documents en cours");
            listBoxFiltre.Items.Add("Devis");
            listBoxFiltre.Items.Add("Bon de commande");
            listBoxFiltre.Items.Add("Préparation de livraison");
            listBoxFiltre.Items.Add("Bon de livraison");
            listBoxFiltre.Items.Add("Bon de retour");
            listBoxFiltre.Items.Add("Bon d'avoir financier");
            listBoxFiltre.Items.Add("Facture");
            listBoxFiltre.Items.Add("Facture comptabilisée");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Dollar", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("USD", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Yuan", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Roupi", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Hehe", "EURO", "EURO", "hahaha...", "Euro", "EURO", "Test eh", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Ar", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Ariary", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Dollar Canadien", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Franc", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Livre", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");
            dataGridView1.Rows.Add("Sterling", "EURO", "EURO", "hahaha...", "Euro", "EURO", "EURO", "hahaha...", "hohoho...");

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
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void listBoxFiltre_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Vérifier si un élément est sélectionné

            // Définir les couleurs
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(129, 166, 181) : listBoxFiltre.BackColor;
            Color foreColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(255, 255, 255) : listBoxFiltre.ForeColor;

            // Dessiner l'arrière-plan
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            // Définir l'alignement du texte avec un padding de 30px à gauche
            using (SolidBrush textBrush = new SolidBrush(foreColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,  // Aligné à gauche
                    LineAlignment = StringAlignment.Center // Centré verticalement
                };

                // Définir la position avec un décalage de 15px vers la droite
                Rectangle textRect = new Rectangle(e.Bounds.X + 15, e.Bounds.Y, e.Bounds.Width - 15, e.Bounds.Height);

                // Dessiner le texte avec le padding
                e.Graphics.DrawString(
                    listBoxFiltre.Items[e.Index].ToString(),
                    e.Font,
                    textBrush,
                    textRect,
                    sf
                );
            }

            // Dessiner le focus rectangle si l'élément a le focus
            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                e.DrawFocusRectangle();
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



        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            ChoixCreationDocumentDeVente choixCreationDocumentDeVente = new ChoixCreationDocumentDeVente(homeForm);
            homeForm.OpenFormInPanel(choixCreationDocumentDeVente);
            homeForm.formActif = choixCreationDocumentDeVente;
            Close();
        }













        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void txtBxBarreDeRecherche_TextChanged(object sender, EventArgs e)
        {
            string termeARechercher = txtBxBarreDeRecherche.Text;
            AfficherArticleRechercher(termeARechercher);
        }

        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UpdateDocumentDeVente updateDocumentDeVente = new UpdateDocumentDeVente(homeForm);
                homeForm.OpenFormInPanel(updateDocumentDeVente);
                homeForm.formActif = updateDocumentDeVente;
                Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonOuvrir_Click(sender, e);
        }











    }
}
