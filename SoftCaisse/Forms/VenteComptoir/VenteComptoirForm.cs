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

        //OUVERTURE DU FORMULAIRE VENTE COMPTOIR
        private void VenteComptoirForm_Load(object sender, EventArgs e)
        {
            textBoxReference.Focus();
        }

        // OPTION POUR L'ENREGISTREMENT DES INFORMATIONS SUR LE TABLEAU DE DESIGNATION
        private void ButtonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            ButtonEnAttente.Enabled = true;
            ButtonFinDeSaisie.Enabled = true;
            ButtonCreerDoc.Enabled = false;
            ButtonRappelTicket.Enabled = false;
            ButtonTicket.Enabled = false;
        }

        // OPTION POUR L'ANNULATION DE TOUTES OPERATIONS SUR LE FORMULAIRE
        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            ButtonAnnuler.Enabled=true;
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

        // OPTION POUR LE CLICK A L'INTERIEUR DU REFERENCE
        private void textBoxReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ArticleARechercher articleARechercher = new ArticleARechercher();
                articleARechercher.ShowDialog(this);
            }
        }

        private int compteurClick = 0;

        // OPTION POUR VALIDER LES INFORMATIONS DANS LA DESIGNATION - MONTRER L'OPTION DE REGLEMENT
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
            labelPrixResteDu.Text = labelPrixTotalTTC.Text;

            textBoxLibelleEnregistrement.Text = "Ticket "+compteurClick+" du "+DateTime.Now.ToString("dd/MM/yyyy");
        }

        // METHODE D'AJOUT DES AUTRES COLONNES SUPPLEMENTAIRES EN PLUS DE CELLES PROVENANT DU FORMULAIRE Article à Rechercher
        public void AjouterArticle(string arRef, string arDesign, string faCodeFamille, int quantiteEnStock, decimal puHT, decimal puTTC, int quantiteVendue)
        {
            puTTC = puHT + (puHT * 20/100);
            
            dataGridViewArticle.Rows.Add(arRef, arDesign, faCodeFamille,quantiteEnStock,puHT,puTTC,quantiteVendue);
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

        //OPTION POUR SELECTIONNER LES DEVISES A UTILISER

        private decimal ChoixDevise(decimal PrixTotalAConvertir)
        {
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            var recuperationDevise = GetDeviseInfo(devise);

            if (devise == "Ariary Malgache")
            {
                PrixTotalAConvertir *= (decimal)recuperationDevise.DeviseCours;
                /*textBoxMontantEnregistrement.Text = PrixTotalAConvertir.ToString("N2");*/
                return PrixTotalAConvertir;

            }
            else if (devise == "Dollar US")
            {
                PrixTotalAConvertir *= (decimal)recuperationDevise.DeviseCours;
                /*textBoxMontantEnregistrement.Text = PrixTotalAConvertir.ToString("N2");*/
                return PrixTotalAConvertir;

            }
            else if (devise == "Franc CFA")
            {
                PrixTotalAConvertir *= (decimal)recuperationDevise.DeviseCours;
                /*textBoxMontantEnregistrement.Text = PrixTotalAConvertir.ToString("N2");*/
                return PrixTotalAConvertir;


            }
            else
                return PrixTotalAConvertir;
        }

        private void comboBoxDeviseEnregistrement_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal PrixTotalAConvertir; /*= Convert.ToDecimal(labelPrixTotalTTC.Text);*/
            if(Convert.ToDecimal(labelPrixTotalTTC.Text) == Convert.ToDecimal(labelPrixResteDu.Text))
            {
                PrixTotalAConvertir = Convert.ToDecimal(labelPrixTotalTTC.Text);
                textBoxMontantEnregistrement.Text = ChoixDevise(PrixTotalAConvertir).ToString("N2");
            }
            else
            {
                PrixTotalAConvertir = Convert.ToDecimal(labelPrixResteDu.Text);
                textBoxMontantEnregistrement.Text = ChoixDevise(PrixTotalAConvertir).ToString("N2");

            }

        }

        //OPTION POUR ENREGISTRER L'OPTION DE REGLEMENT DANS UN TABLEAU

        private decimal CalculerResteDu(decimal montant, decimal coursDeChange, decimal montantEnregistrement)
        {
            decimal ResteDu;

            montant *= coursDeChange;
            ResteDu = montant - montantEnregistrement ;
            ResteDu /= coursDeChange;
            return ResteDu;
        }
        
        private int cpt = 0;
        private void ButtonEnregistrerEnregistrement_Click(object sender, EventArgs e)
        {
            cpt++;
            ButtonSupprimerEnregistrement.Enabled = true;

            string modeReception = comboBoxEspeceEnregistrement.SelectedItem.ToString();
            decimal montant = decimal.Parse(labelPrixTotalTTC.Text);
            string libelle = textBoxLibelleEnregistrement.Text;
            decimal ResteDu;
            decimal resteDuAvecCpt;
            decimal montantEnregistrement = Convert.ToDecimal(textBoxMontantEnregistrement.Text);
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            DateTime dateEcheance = dateTimePickerEnregistrement.Value;

            DataGridViewRow newRow = new DataGridViewRow();

            var recuperation = GetDeviseInfo(devise);

            decimal coursDeChange = recuperation.DeviseCours;
            Console.WriteLine(coursDeChange);

            if (cpt == 1)
            {
                if (devise != "Euro")
                {
                    ResteDu = CalculerResteDu(montant, coursDeChange, montantEnregistrement);
                }
                else
                {
                    ResteDu = montant - montantEnregistrement;
                }
            }
            else
            {
                resteDuAvecCpt = Convert.ToDecimal(labelPrixResteDu.Text);

                if (devise != "Euro")
                {
                    ResteDu = CalculerResteDu(resteDuAvecCpt,coursDeChange,montantEnregistrement);
                }
                else
                {
                    ResteDu = resteDuAvecCpt - montantEnregistrement;
                }
            }

            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = modeReception });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToDecimal(textBoxMontantEnregistrement.Text)/* + " " + recuperation.DeviseSigle*/
            });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = libelle });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = devise });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = dateEcheance });

            dataGridViewEnregistrement.Rows.Add(newRow);
            
            if (ResteDu > 0)
            {
                labelPrixResteDu.Text = ResteDu.ToString("N2");
                labelResteDu.Text = "Reste dû";
            }
            else if(ResteDu < 0)
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
            textBoxMontantEnregistrement.Text = labelPrixResteDu.Text;
            comboBoxDeviseEnregistrement.SelectedIndex = 2;
            dateTimePickerEnregistrement.Value = DateTime.Now;
        }

        //OPTION POUR SUPPRIMER LES LIGNES NOUVELLEMENT INSERER DANS LE TABLEAU DE DESIGNATION
        private void ButtonSupprimerDesignation_Click(object sender, EventArgs e)
        {
            if (dataGridViewArticle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewArticle.SelectedRows[0];
                dataGridViewArticle.Rows.Remove(selectedRow);

            }
        }

        //OPTION POUR SUPPRIMER LES LIGNES NOUVELLEMENT INSERER DANS LE TABLEAU D'ENREGISTREMENT
        private void ButtonSupprimerEnregistrement_Click(object sender, EventArgs e)
        {
            decimal montantSupprimer = Convert.ToDecimal(dataGridViewEnregistrement.SelectedRows[0].Cells[1].Value);
            decimal ResteDu;
           
            if(labelResteDu.Text == "Reste dû" || labelResteDu.Text == "Soldé")
            {
                ResteDu = Convert.ToDecimal(labelPrixResteDu.Text) + montantSupprimer;
                labelResteDu.Text = "Reste dû";
                labelPrixResteDu.Text = ResteDu.ToString();
            }
            else
            {
                ResteDu = montantSupprimer - Convert.ToDecimal(labelPrixResteDu.Text);
                labelResteDu.Text = "Reste dû";
                labelPrixResteDu.Text = ResteDu.ToString();
            }
            
            if (dataGridViewEnregistrement.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEnregistrement.SelectedRows[0];
                dataGridViewEnregistrement.Rows.Remove(selectedRow);
            }
        }

        // OPTION FERMER LE FORMULAIRE
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //AFFICHAGE ET SUPPRESSION DU PLACEHOLDER
        private void TextBox_Enter(object sender, EventArgs e)
        {
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
           /* decimal PrixTotalResteDu = Convert.ToDecimal(labelPrixResteDu.Text);
            string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            var recuperationDevise = GetDeviseInfo(devise);

            if (devise == "Ariary Malgache")
            {
                PrixTotalResteDu *= (decimal)recuperationDevise.DeviseCours;
                labelPrixResteDu.Text = PrixTotalResteDu.ToString("N2");
            }
            else if (devise == "Dollar US")
            {
                PrixTotalResteDu *= (decimal)recuperationDevise.DeviseCours;
                labelPrixResteDu.Text = PrixTotalResteDu.ToString("N2");
            }
            else if (devise == "Franc CFA")
            {
                PrixTotalResteDu *= (decimal)recuperationDevise.DeviseCours;
                labelPrixResteDu.Text = PrixTotalResteDu.ToString("N2");

            }
            else
                labelPrixResteDu.Text = labelPrixTotalTTC.Text;*/
        }

        private void textBoxMontantEnregistrement_TextChanged(object sender, EventArgs e)
        {
            /*if(textBoxMontantEnregistrement.Text == "0,00")
                ButtonEnregistrerEnregistrement.Enabled = false;*/
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
    }
}
