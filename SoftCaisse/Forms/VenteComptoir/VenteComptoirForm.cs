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
using SoftCaisse.Models;
using SoftCaisse.Repositories;
namespace SoftCaisse.Forms.VenteComptoir
{
    public partial class VenteComptoirForm : KryptonForm
    {
        private readonly AppDbContext _context;

        private readonly DeviseRepository _deviseRepository;
        public VenteComptoirForm()
        {
            _context = new AppDbContext();
            _deviseRepository = new DeviseRepository(_context);
            InitializeComponent();
        }

        private dynamic GetDeviseInfo(string devise)
        {
            var recuperationDevise = _context.P_DEVISE
                .Where(devises => devises.D_Intitule == devise)
                .Select(devises => new
                {
                    DeviseCours = devises.D_Cours,
                    DeviseMonnaie = devises.D_Monnaie,
                    DeviseCodeISO = devises.D_CodeISO,
                    DeviseSigle = devises.D_Sigle
                })
                .FirstOrDefault();

            return recuperationDevise;
        }

        private void VenteComptoirForm_Load(object sender, EventArgs e)
        {
            textBoxReference.Focus();
            if(dataGridViewArticle.Rows.Count < 1)
                ButtonEnregistrerDesignation.Enabled = false;
            else
                ButtonEnregistrerDesignation.Enabled = true;
        }

        private void ButtonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            ButtonEnAttente.Enabled = true;
            ButtonFinDeSaisie.Enabled = true;
            ButtonCreerDoc.Enabled = false;
            ButtonRappelTicket.Enabled = false;
            ButtonTicket.Enabled = false;
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            ButtonAnnuler.Enabled = true;
            ButtonCreerDoc.Enabled = true;
            ButtonRappelTicket.Enabled = true;
            ButtonTicket.Enabled = false;
            ButtonEnAttente.Enabled = false;
            ButtonRaccourci.Enabled = true;
            ButtonValider.Enabled = false;
            ButtonFacture.Enabled = false;

            groupBoxInvisibleEnregistrement.Visible = false;
            dataGridViewEnregistrement.Dock = DockStyle.Fill;

            labelPrixResteDu.Text = "0,00";
            labelPrixTotalHT.Text = "0,00";
            labelPrixTotalTTC.Text = "0,00";

            dataGridViewEnregistrement.Rows.Clear();
            dataGridViewArticle.Rows.Clear();
            textBoxReference.Focus();

        }

        private void textBoxReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ArticleARechercher articleARechercher = new ArticleARechercher();
                articleARechercher.ShowDialog(this);
            }
        }

        private int compteurClick = 0;

        public void AjouterArticle(string arRef, string arDesign, string faCodeFamille, int quantiteEnStock, decimal puHT, decimal puTTC, int quantiteVendue)
        {
            puTTC = puHT + (puHT * 20 / 100);

            dataGridViewArticle.Rows.Add(arRef, arDesign, faCodeFamille, quantiteEnStock, puHT, puTTC, quantiteVendue);
            dataGridViewArticle.ClearSelection();

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
        decimal variableTemporaire;
        private void ButtonFinDeSaisie_Click(object sender, EventArgs e)
        {
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            var recuperationDevise = GetDeviseInfo(devise);
            Console.WriteLine(variableTemporaire);
            compteurClick++;

            dataGridViewEnregistrement.Dock = DockStyle.Bottom;
            dataGridViewEnregistrement.Width = 677;
            dataGridViewEnregistrement.Height = 122;

            groupBoxInvisibleEnregistrement.Visible = true;

            dataGridViewEnregistrement.Enabled = true;
            ButtonFinDeSaisie.Enabled = false;
            ButtonAnnuler.Enabled = true;
            ButtonEnAttente.Enabled = true;
            ButtonRaccourci.Enabled = true;
            ButtonValider.Enabled = true;
            ButtonFacture.Enabled = true;
            ButtonSupprimerDesignation.Enabled = false;

            textBoxMontantEnregistrement.Text = labelPrixTotalTTC.Text;
            variableTemporaire = Convert.ToDecimal(textBoxMontantEnregistrement.Text);
            Console.WriteLine(variableTemporaire);
            labelPrixResteDu.Text = labelPrixTotalTTC.Text;
            label2.Text = recuperationDevise.DeviseSigle;

            textBoxLibelleEnregistrement.Text = "Ticket " + compteurClick + " du " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private decimal ChoixDevise(decimal PrixTotalAConvertir)
        {
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            var recuperation = GetDeviseInfo(devise);

            Console.WriteLine(recuperation.DeviseCours);

            if (devise == "Ariary Malgache")
            {
                PrixTotalAConvertir *= (decimal)recuperation.DeviseCours;
                Console.WriteLine(PrixTotalAConvertir);
                return PrixTotalAConvertir;
            }
            else if (devise == "Dollar US")
            {
                PrixTotalAConvertir *= (decimal)recuperation.DeviseCours;
                return PrixTotalAConvertir;
            }
            else if (devise == "Franc CFA")
            {
                PrixTotalAConvertir *= (decimal)recuperation.DeviseCours;
                return PrixTotalAConvertir;
            }
            else
                Console.WriteLine(PrixTotalAConvertir);
                return PrixTotalAConvertir;
        }

        private int cpt = 0;

        private decimal PrixTotalAConvertirInitial;
        private void textBoxMontantEnregistrement_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMontantEnregistrement.Text))
            {
               PrixTotalAConvertirInitial = Convert.ToDecimal(textBoxMontantEnregistrement.Text);
                Console.WriteLine(PrixTotalAConvertirInitial);
            }
         
            if (textBoxMontantEnregistrement.Text == "0,00" || textBoxMontantEnregistrement.Text == "")
                ButtonEnregistrerEnregistrement.Enabled = false;
            else
                ButtonEnregistrerEnregistrement.Enabled = true;

        }
        private void comboBoxDeviseEnregistrement_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpt++;
            Console.WriteLine(cpt);
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            decimal PrixTotalAConvertir;
            var recuperationDevise = GetDeviseInfo(devise);
            Console.WriteLine(recuperationDevise.DeviseCours);

            if (PrixTotalAConvertirInitial == 0)
            {
                 PrixTotalAConvertirInitial = Convert.ToDecimal(textBoxMontantEnregistrement.Text);
            }
            
            PrixTotalAConvertir = PrixTotalAConvertirInitial;
            textBoxMontantEnregistrement.Text = ChoixDevise(PrixTotalAConvertir).ToString("N2");
           
            label2.Text = recuperationDevise.DeviseSigle;
        }

        private decimal CalculerResteDu(decimal montant, decimal coursDeChange, decimal montantEnregistrement)
        {
            decimal ResteDu;

            montant *= coursDeChange;
            ResteDu = montant - montantEnregistrement;
            ResteDu /= coursDeChange;
            return ResteDu;
        }
        private void ButtonEnregistrerEnregistrement_Click(object sender, EventArgs e)
        {
            cpt++;
            ButtonSupprimerEnregistrement.Enabled = true;
            Console.WriteLine(variableTemporaire);

            string modeReception = comboBoxEspeceEnregistrement.SelectedItem.ToString();
            string libelle = textBoxLibelleEnregistrement.Text;
            decimal ResteDu;
            decimal montantEnregistrement = Convert.ToDecimal(textBoxMontantEnregistrement.Text);
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            var recuperation = GetDeviseInfo(devise);

            decimal coursDeChange = recuperation.DeviseCours;

            DateTime dateEcheance = dateTimePickerEnregistrement.Value;

            DataGridViewRow newRow = new DataGridViewRow();

            Console.WriteLine(coursDeChange);

            if (cpt == 1)
            {
                if (devise != "Euro")
                {
                    ResteDu = CalculerResteDu(variableTemporaire, coursDeChange, montantEnregistrement);
                }
                else
                {
                    ResteDu = variableTemporaire - montantEnregistrement;
                }
            }
            else
            {
                decimal resteDuAvecCpt = Convert.ToDecimal(labelPrixResteDu.Text);

                if (devise != "Euro")
                {
                    ResteDu = CalculerResteDu(resteDuAvecCpt, coursDeChange, montantEnregistrement);
                }
                else
                {
                    ResteDu = resteDuAvecCpt - montantEnregistrement;
                }
            }

            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = modeReception });
            newRow.Cells.Add(new DataGridViewTextBoxCell
            {
                Value = Convert.ToDecimal(textBoxMontantEnregistrement.Text)
            });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = libelle });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = devise });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = dateEcheance });

            dataGridViewEnregistrement.Rows.Add(newRow);

            if (Math.Round(ResteDu, 2) > 0)
            {
                labelPrixResteDu.Text = ResteDu.ToString("N2");
                labelResteDu.Text = "Reste dû";
            }
            else if (Math.Round(ResteDu, 2) < 0)
            {
                ResteDu = Math.Abs(ResteDu);
                labelPrixResteDu.Text = ResteDu.ToString("N2");
                labelResteDu.Text = "A rendre";
            }
            else
            {
                labelPrixResteDu.Text = ResteDu.ToString("N2");
                labelResteDu.Text = "Soldé";
            }

            comboBoxEspeceEnregistrement.SelectedIndex = 0;
            variableTemporaire = ResteDu;
            Console.WriteLine(variableTemporaire);
            textBoxMontantEnregistrement.Text = labelPrixResteDu.Text;
            Console.WriteLine(Convert.ToDecimal(textBoxMontantEnregistrement.Text));
            comboBoxDeviseEnregistrement.SelectedIndex = 2;
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
            decimal montantSupprimer = Convert.ToDecimal(dataGridViewEnregistrement.SelectedRows[0].Cells[1].Value);
            decimal ResteDu;
            string devise = dataGridViewEnregistrement.SelectedRows[0].Cells[3].Value.ToString();
            var recuperation = GetDeviseInfo(devise);
            decimal coursDeChange = recuperation.DeviseCours;


            if (labelResteDu.Text == "Reste dû" || labelResteDu.Text == "Soldé")
            {
                if (devise != "Euro")
                {
                    ResteDu = Convert.ToDecimal(labelPrixResteDu.Text) + montantSupprimer / coursDeChange;
                    labelResteDu.Text = "Reste dû";
                    labelPrixResteDu.Text = ResteDu.ToString("N2");
                    textBoxMontantEnregistrement.Text = labelPrixResteDu.Text;
                }
                else
                {
                    ResteDu = Convert.ToDecimal(labelPrixResteDu.Text) + montantSupprimer;
                    labelResteDu.Text = "Reste dû";
                    labelPrixResteDu.Text = ResteDu.ToString("N2");
                    textBoxMontantEnregistrement.Text = labelPrixResteDu.Text;

                }
            }
            else
            {
                if (devise != "Euro")
                {
                    ResteDu = montantSupprimer / coursDeChange - Convert.ToDecimal(labelPrixResteDu.Text);
                    labelResteDu.Text = "Reste dû";
                    labelPrixResteDu.Text = ResteDu.ToString("N2");
                    textBoxMontantEnregistrement.Text = labelPrixResteDu.Text;

                }
                else
                {
                    ResteDu = montantSupprimer - Convert.ToDecimal(labelPrixResteDu.Text);
                    labelResteDu.Text = "Reste dû";
                    labelPrixResteDu.Text = ResteDu.ToString("N2");
                    textBoxMontantEnregistrement.Text = labelPrixResteDu.Text;

                }
            }

            if (dataGridViewEnregistrement.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEnregistrement.SelectedRows[0];
                dataGridViewEnregistrement.Rows.Remove(selectedRow);
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ButtonEnregistrerDesignation.Enabled = true;

            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Référence")
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Référence";
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void comboBoxResteDu_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* labelResteDuDevise.Text = labelPrixResteDu.Text;

            decimal prixResteDuDevise = Convert.ToDecimal(labelResteDuDevise.Text);

            string devise = comboBoxResteDu.SelectedItem.ToString();
            var recuperationDevise = GetDeviseInfo(devise);

            if (devise != "Euro")
            {
                Console.WriteLine(recuperationDevise.DeviseCours);
                labelResteDuDevise.Text = ChoixDevise(prixResteDuDevise).ToString("N2");
            }
            else
            {
                labelResteDuDevise.Text = prixResteDuDevise.ToString();
            }

            labelPrixResteDu.Visible = false;
            labelResteDuDevise.Visible = true;*/

        }

        private void dataGridViewArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewArticle.SelectedRows.Count > 0)
            {
                ButtonSupprimerDesignation.Enabled = true;
            }
            else
            {
                ButtonSupprimerDesignation.Enabled = false;
            }
        }

        private void ButtonNouveauDesignation_Click(object sender, EventArgs e)
        {
            textBoxReference.Focus();
            ButtonFinDeSaisie.Enabled = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

