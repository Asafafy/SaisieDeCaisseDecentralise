using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.Article;
namespace SoftCaisse.Forms.VenteComptoir
{
    public partial class VenteComptoirForm : KryptonForm
    {
        public VenteComptoirForm()
        {
            InitializeComponent();
        }

        private void ButtonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            ButtonFinDeSaisie.Enabled = true;
            ButtonSupprimerDesignation.Enabled = true;
            ButtonCreerDoc.Enabled = false;
            ButtonRappelTicket.Enabled = false;
            ButtonTicket.Enabled = false;
            ButtonEnAttente.Enabled = true;
            ButtonFinDeSaisie.Enabled = true;
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            ButtonAnnuler.Enabled=true;
            ButtonCreerDoc.Enabled = true;
            ButtonRappelTicket.Enabled = true;
            ButtonTicket.Enabled = false;
            ButtonEnAttente.Enabled = false;
           // ButtonFinDeSaisie.Enabled = true;
            ButtonRaccourci.Enabled = true;
            ButtonValider.Enabled = false;
            ButtonFacture.Enabled = false;

            groupBoxInvisibleEnregistrement.Visible = false;
            dataGridViewEnregistrement.Dock = DockStyle.Fill;

        }

        private void textBoxReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ArticleARechercher articleARechercher = new ArticleARechercher();
                articleARechercher.ShowDialog(this);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int compteurClick = 0;
        private void ButtonFinDeSaisie_Click(object sender, EventArgs e)
        {
            compteurClick++;

            dataGridViewEnregistrement.Dock = DockStyle.Bottom;
            dataGridViewEnregistrement.Width = 677;
            dataGridViewEnregistrement.Height = 122;

            groupBoxInvisibleEnregistrement.Visible = true;
           
            dataGridViewEnregistrement.Enabled = true;
            ButtonFinDeSaisie.Enabled = false;
            ButtonAnnuler.Enabled = true;
            ButtonEnAttente.Enabled=true;
            ButtonRaccourci.Enabled=true;
            ButtonValider.Enabled=true;
            ButtonFacture.Enabled = true;
            ButtonSupprimerDesignation.Enabled=false;

            textBoxMontantEnregistrement.Text = labelPrixTotalTTC.Text;

            textBoxLibelleEnregistrement.Text = "Ticket "+compteurClick+" du "+DateTime.Now.ToString("dd/mm/yyyy");
        }

        public void AjouterArticle(string arRef, string arDesign, string faCodeFamille, int quantiteEnStock, decimal puHT, decimal puTTC, int quantiteVendue)
        {
            puTTC = puHT + (puHT * 20/100);
            dataGridViewArticle.Rows.Add(arRef, arDesign, faCodeFamille,quantiteEnStock,puHT,puTTC,quantiteVendue);
            decimal TotalPrixHT = 0;
            decimal TotalPrixTTC = 0;
            foreach (DataGridViewRow row in dataGridViewArticle.Rows)
            {
                
                if (!row.IsNewRow)
                { 
                    decimal puHTCourant = Convert.ToDecimal(row.Cells[4].Value);
                    decimal puTTCCourant = Convert.ToDecimal(row.Cells[5].Value);

                    if (dataGridViewArticle.Rows.Count == 1)
                    {   
                        TotalPrixHT = puHTCourant;
                        TotalPrixTTC = puTTCCourant;
                    }

                    else if (dataGridViewArticle.Rows.Count == 2)
                    {  
                        TotalPrixHT = Convert.ToDecimal(dataGridViewArticle.Rows[0].Cells[4].Value) + puHTCourant;
                        TotalPrixTTC = Convert.ToDecimal(dataGridViewArticle.Rows[0].Cells[5].Value) + puTTCCourant;
                    }

                    else
                    {   
                        TotalPrixHT += puHTCourant;
                        TotalPrixTTC += puTTCCourant;
                    }
                }
            }

            labelPrixTotalHT.Text = TotalPrixHT.ToString("N2");
            labelPrixTotalTTC.Text = TotalPrixTTC.ToString("N2");
        }

        private void comboBoxDeviseEnregistrement_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal PrixTotalTTCEuro = Convert.ToDecimal(labelPrixTotalTTC.Text);
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();

            if (devise == "Ariary")
            {
                PrixTotalTTCEuro *= 4900;
                textBoxMontantEnregistrement.Text = PrixTotalTTCEuro.ToString();
            }
            else if(devise == "Yen")
            {
                PrixTotalTTCEuro *= 16312/100;
                textBoxMontantEnregistrement.Text = PrixTotalTTCEuro.ToString();
            }
            else if (devise == "Euro")
            {
                PrixTotalTTCEuro = Convert.ToDecimal(labelPrixTotalTTC.Text);
                textBoxMontantEnregistrement.Text = PrixTotalTTCEuro.ToString();

            }

        }

        private void ButtonEnregistrerEnregistrement_Click(object sender, EventArgs e)
        {
            ButtonSupprimerEnregistrement.Enabled = true;

            string modeReception = comboBoxEspeceEnregistrement.SelectedItem.ToString();
            decimal montant = decimal.Parse(textBoxMontantEnregistrement.Text);
            string libelle = textBoxLibelleEnregistrement.Text;
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            DateTime dateEcheance = dateTimePickerEnregistrement.Value;

            DataGridViewRow newRow = new DataGridViewRow();

            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = modeReception });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = montant });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = libelle });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = devise });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = dateEcheance });

            dataGridViewEnregistrement.Rows.Add(newRow);

            decimal ResteDu = montant - Convert.ToDecimal(labelPrixTotalTTC.Text);
            if(montant > Convert.ToDecimal(labelPrixTotalTTC.Text))
            {
                labelPrixResteDu.Text = ResteDu.ToString("N2");
                labelResteDu.Text = "A rendre";
            }
            else if(montant < Convert.ToDecimal(labelPrixTotalTTC.Text))
            {
                ResteDu = Math.Abs(ResteDu);
                labelPrixResteDu.Text = ResteDu.ToString("N2");
            }
            else
                labelPrixResteDu.Text = ResteDu.ToString("N2");

            comboBoxEspeceEnregistrement.SelectedIndex = 0;
            textBoxMontantEnregistrement.Clear();
            //textBoxLibelleEnregistrement.Clear();
            comboBoxDeviseEnregistrement.SelectedIndex = 1;
            dateTimePickerEnregistrement.Value = DateTime.Now;
        }

        private void ButtonSupprimerDesignation_Click(object sender, EventArgs e)
        {
            if (dataGridViewArticle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewArticle.SelectedRows[0];
                dataGridViewArticle.Rows.Remove(selectedRow);
            }
        }

        private void ButtonSupprimerEnregistrement_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnregistrement.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEnregistrement.SelectedRows[0];
                dataGridViewEnregistrement.Rows.Remove(selectedRow);
            }
        }
    }
}
