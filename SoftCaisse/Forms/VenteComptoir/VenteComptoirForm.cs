using System;
using System.Data;
using System.Drawing;
using System.Linq;
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

            foreach (Control control in TableLayoutPanelDesignation.Controls)
            {
                if (control is TextBox)
                {
                    control.Enter += TextBox_Enter;
                    control.Leave += TextBox_Leave;

                    control.Tag = control.Text;
                }
            }
            
        }


        private void VenteComptoirForm_Load(object sender, EventArgs e)
        {
            TextBoxReference.Focus();
            if(DataGridViewArticle.Rows.Count < 1)
                BouttonEnregistrerDesignation.Enabled = false;
            else
                BouttonEnregistrerDesignation.Enabled = true;
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            BouttonAnnuler.Enabled = true;
            BouttonCreerDoc.Enabled = true;
            BouttonRappelTicket.Enabled = true;
            BouttonTicket.Enabled = false;
            BouttonEnAttente.Enabled = false;
            BouttonRaccourci.Enabled = true;
            BouttonValider.Enabled = false;
            BouttonFacture.Enabled = false;

            GroupBoxInvisibleEnregistrement.Visible = false;
            DataGridViewEnregistrement.Dock = DockStyle.Fill;

            LabelPrixResteDu.Text = "0,00";
            LabelPrixTotalHT.Text = "0,00";
            LabelPrixTotalTTC.Text = "0,00";

            DataGridViewEnregistrement.Rows.Clear();
            DataGridViewArticle.Rows.Clear();
            TextBoxReference.Focus();

        }

        public void TextBoxReference_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;

                string codeFamilleARechercher = TextBoxReference.Text;

                var codeFamilleBD = _context.F_ARTICLE.Where(a => a.FA_CodeFamille == codeFamilleARechercher).Select(a => new
                {
                    a.AR_Ref,
                    a.AR_Design,
                    a.AR_PrixAch,
                    a.AR_UnitePoids
                }).FirstOrDefault();

                if(codeFamilleBD != null)
                {
                    var infoSupplementaireArticleTaxe = _context.F_ARTCOMPTA
                    .Where(article => article.AR_Ref == codeFamilleBD.AR_Ref)
                    .Select(article => new
                    {
                        IdentifiantChamp = article.ACP_Champ,
                        CodeTaxeAComptabiliser = article.ACP_ComptaCPT_Taxe1
                    }).FirstOrDefault();

                    var infoSupplementaireTaxe = _context.F_TAXE
                    .Where(article => article.TA_Code == infoSupplementaireArticleTaxe.CodeTaxeAComptabiliser)
                    .Select(article => new
                    {
                        TauxPriseEnCompte = article.TA_Taux,
                    }).FirstOrDefault();

                    decimal puTTC = (decimal)codeFamilleBD.AR_PrixAch + (decimal)(codeFamilleBD.AR_PrixAch * infoSupplementaireTaxe.TauxPriseEnCompte / 100);
                    AjouterArticleDesigne(codeFamilleBD.AR_Ref,codeFamilleBD.AR_Design,(Int16)codeFamilleBD.AR_UnitePoids,(decimal)codeFamilleBD.AR_PrixAch,puTTC);
                }
                else
                {
                    ArticleARechercher articleARechercher = new ArticleARechercher(codeFamilleARechercher);
                    articleARechercher.ShowDialog(this);

                }
            }
        }

        private int compteurClick = 0;

        public void AjouterArticleDesigne(string arRef, string arDesign, int quantiteDisponibleEnStock, decimal puHT, decimal puTTC)
        {
            TextBoxReference.Text = arRef;
            TextBoxDesignation.Text = arDesign;
            TextBoxQuantiteDisponibleEnStock.Text = quantiteDisponibleEnStock.ToString("N0");
            TextBoxPUHT.Text = puHT.ToString("N2");
            TextBoxPUTTC.Text = puTTC.ToString("N2");
            TextBoxPUnet.Text = puTTC.ToString("N2");
            TextBoxMontantHT.Text = (puHT * quantiteDisponibleEnStock).ToString("N2");
            TextBoxMontantTTC.Text = (puTTC * quantiteDisponibleEnStock).ToString("N2");
            //textBoxConditionnement.Text = quantiteVendue.ToString("N0");
        }

        private int i = 0;

        decimal TotalPrixHT;
        decimal TotalPrixTTC;

        private void BouttonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            BouttonEnAttente.Enabled = true;
            BouttonFinDeSaisie.Enabled = true;
            BouttonSupprimerDesignation.Enabled = true;
            BouttonCreerDoc.Enabled = false;
            BouttonRappelTicket.Enabled = false;
            BouttonTicket.Enabled = false;
           
            string arRef = TextBoxReference.Text;
            string arDesign = TextBoxDesignation.Text;
            int quantiteEnStock = int.Parse(TextBoxQuantiteDisponibleEnStock.Text);
            decimal puHT = Convert.ToDecimal(TextBoxPUHT.Text);
            decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text);
            decimal puNet = Convert.ToDecimal(TextBoxPUnet.Text);
            decimal montantHT = Convert.ToDecimal(TextBoxMontantHT.Text);
            decimal montantTTC = Convert.ToDecimal(TextBoxMontantTTC.Text);
            // int quantiteVendue = int.Parse(textBoxConditionnement.Text);

            DataGridViewArticle.Rows.Add(arRef,arDesign,puHT,puTTC,quantiteEnStock,"unité",1,puNet,montantHT,montantTTC);

            if (DataGridViewArticle.Rows.Count == 1)
            {
                TotalPrixHT = Convert.ToDecimal(DataGridViewArticle.Rows[i].Cells[8].Value);
                TotalPrixTTC = Convert.ToDecimal(DataGridViewArticle.Rows[i].Cells[9].Value);
            }
            else if (DataGridViewArticle.Rows.Count == 2)
            {
                decimal TotalPrixHTPrecedent = Convert.ToDecimal(DataGridViewArticle.Rows[i - 1].Cells[8].Value);
                decimal TotalPrixTTCPrecedent = Convert.ToDecimal(DataGridViewArticle.Rows[i - 1].Cells[9].Value);

                TotalPrixHT = TotalPrixHTPrecedent + Convert.ToDecimal(DataGridViewArticle.Rows[i].Cells[8].Value);
                TotalPrixTTC = TotalPrixTTCPrecedent + Convert.ToDecimal(DataGridViewArticle.Rows[i].Cells[9].Value);

            }
            else
            {
                TotalPrixHT += Convert.ToDecimal(DataGridViewArticle.Rows[i].Cells[8].Value);
                TotalPrixTTC += Convert.ToDecimal(DataGridViewArticle.Rows[i].Cells[9].Value);
            }

            i++;
            LabelPrixTotalHT.Text = TotalPrixHT.ToString("N2");
            LabelPrixTotalTTC.Text = TotalPrixTTC.ToString("N2");

            foreach (Control control in TableLayoutPanelDesignation.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Tag.ToString();
                }
            }

            TextBoxReference.Focus();
        }

        private void TextBoxQuantiteDisponibleEnStock_TextChanged(object sender, EventArgs e)
        {
            var articleBaseDeDonneesMiseAJour = _context.F_ARTICLE.FirstOrDefault(article => article.AR_Ref == TextBoxReference.Text);
            if (TextBoxQuantiteDisponibleEnStock.Text != "")
            {
                if (Convert.ToInt16(TextBoxQuantiteDisponibleEnStock.Text) <= articleBaseDeDonneesMiseAJour.AR_UnitePoids)
                {
                    if (int.TryParse(TextBoxQuantiteDisponibleEnStock.Text, out int quantiteDisponible))
                    {
                        if (TextBoxPUHT.Text != "" && TextBoxPUTTC.Text != "")
                        {
                            decimal puHT = Convert.ToDecimal(TextBoxPUHT.Text);
                            decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text);

                            decimal montantHT = puHT * quantiteDisponible;
                            decimal montantTTC = puTTC * quantiteDisponible;
                            TextBoxMontantHT.Text = montantHT.ToString("N2");
                            TextBoxMontantTTC.Text = montantTTC.ToString("N2");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La quantité voulu dépasse la quantité en Stock.");
                    TextBoxQuantiteDisponibleEnStock.Text = articleBaseDeDonneesMiseAJour.AR_UnitePoids.ToString();
                }
            }
        }


        private dynamic GetDeviseInfo(string devise)
        {
            var recuperationDevise = _context.P_DEVISE
                .Where(devises => devises.D_Intitule == devise)
                .Select(devises => new
                {
                    devises.D_Cours,
                    devises.D_Monnaie,
                    devises.D_CodeISO,
                    devises.D_Sigle
                })
                .FirstOrDefault();

            return recuperationDevise;
        }

        decimal variableTemporaire;
        private void BouttonFinDeSaisie_Click(object sender, EventArgs e)
        {
            // string devise = comboBoxDeviseEnregistrement.SelectedItem.ToString();
            //var recuperationDevise = GetDeviseInfo(devise);

            var deviseASelectionne = _context.P_DEVISE.Select(d => d.D_Intitule).ToList();
            var modeDeReglement = _context.P_REGLEMENT.Select(r => r.R_Intitule).ToList();

            ComboBoxReglementEnregistrement.Items.Clear();
            ComboBoxDeviseEnregistrement.Items.Clear();


            foreach (var devise in deviseASelectionne)
            {
                ComboBoxDeviseEnregistrement.Items.Add(devise.ToString());
            }

            foreach (var mode in modeDeReglement)
            {
                ComboBoxReglementEnregistrement.Items.Add(mode.ToString());
            }

            Console.WriteLine(variableTemporaire);
            compteurClick++;

            DataGridViewEnregistrement.Dock = DockStyle.Bottom;
            DataGridViewEnregistrement.Width = 677;
            DataGridViewEnregistrement.Height = 122;

            GroupBoxInvisibleEnregistrement.Visible = true;

            DataGridViewEnregistrement.Enabled = true;
            BouttonFinDeSaisie.Enabled = false;
            BouttonAnnuler.Enabled = true;
            BouttonEnAttente.Enabled = true;
            BouttonRaccourci.Enabled = true;
            BouttonFacture.Enabled = true;
            BouttonSupprimerDesignation.Enabled = false;

            TextBoxMontantEnregistrement.Text = LabelPrixTotalTTC.Text;
            variableTemporaire = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);

            Console.WriteLine(variableTemporaire);
            
            LabelPrixResteDu.Text = LabelPrixTotalTTC.Text;
           // label2.Text = recuperationDevise.DeviseSigle;

            TextBoxLibelleEnregistrement.Text = "Ticket " + compteurClick + " du " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private decimal ChoixDevise(decimal PrixTotalAConvertir)
        {
            string devise = ComboBoxDeviseEnregistrement.SelectedItem.ToString();
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
        private void TextBoxMontantEnregistrement_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxMontantEnregistrement.Text))
            {
               PrixTotalAConvertirInitial = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);
                Console.WriteLine(PrixTotalAConvertirInitial);
            }
         
            if (TextBoxMontantEnregistrement.Text == "0,00" || TextBoxMontantEnregistrement.Text == "")
                BouttonEnregistrerEnregistrement.Enabled = false;
            else
                BouttonEnregistrerEnregistrement.Enabled = true;

        }
        private void ComboBoxDeviseEnregistrement_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpt++;

            var deviseUtilise = _context.P_DEVISE.Select(d => d.D_Intitule).ToList();

            ComboBoxReglementEnregistrement.Items.Clear();

            foreach (var mode in deviseUtilise)
            {
                ComboBoxReglementEnregistrement.Items.Add(mode.ToString());
            }
            var devise = ComboBoxDeviseEnregistrement.SelectedItem.ToString();
            
            decimal PrixTotalAConvertir;

            var recuperationDevise = GetDeviseInfo(devise);
            
            Console.WriteLine(recuperationDevise.DeviseCours);

            if (PrixTotalAConvertirInitial == 0)
            {
                 PrixTotalAConvertirInitial = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);
            }
            
            PrixTotalAConvertir = PrixTotalAConvertirInitial;
            TextBoxMontantEnregistrement.Text = ChoixDevise(PrixTotalAConvertir).ToString("N2");
           
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
        private void BouttonEnregistrerEnregistrement_Click(object sender, EventArgs e)
        {
            cpt++;
            BouttonSupprimerEnregistrement.Enabled = true;
            BouttonValider.Enabled = true;

            Console.WriteLine(variableTemporaire);

            string modeReception = ComboBoxReglementEnregistrement.SelectedItem.ToString();
            string libelle = TextBoxLibelleEnregistrement.Text;
            decimal ResteDu;
            decimal montantEnregistrement = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);
            string devise = ComboBoxDeviseEnregistrement.SelectedItem.ToString();
            
            var recuperation = GetDeviseInfo(devise);

            decimal coursDeChange = recuperation.DeviseCours;

            DateTime dateEcheance = DateTimePickerEnregistrement.Value;

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
                decimal resteDuAvecCpt = Convert.ToDecimal(LabelPrixResteDu.Text);

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
                Value = Convert.ToDecimal(TextBoxMontantEnregistrement.Text)
            });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = libelle });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = devise });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = dateEcheance });

            DataGridViewEnregistrement.Rows.Add(newRow);

            if (Math.Round(ResteDu, 2) > 0)
            {
                LabelPrixResteDu.Text = ResteDu.ToString("N2");
                LabelResteDu.Text = "Reste dû";
            }
            else if (Math.Round(ResteDu, 2) < 0)
            {
                ResteDu = Math.Abs(ResteDu);
                LabelPrixResteDu.Text = ResteDu.ToString("N2");
                LabelResteDu.Text = "A rendre";
            }
            else
            {
                LabelPrixResteDu.Text = ResteDu.ToString("N2");
                LabelResteDu.Text = "Soldé";
            }

            ComboBoxReglementEnregistrement.SelectedIndex = 0;
            variableTemporaire = ResteDu;
            Console.WriteLine(variableTemporaire);
            TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;
            Console.WriteLine(Convert.ToDecimal(TextBoxMontantEnregistrement.Text));
            ComboBoxDeviseEnregistrement.SelectedIndex = 2;
            DateTimePickerEnregistrement.Value = DateTime.Now;
        }

        private void BouttonSupprimerDesignation_Click(object sender, EventArgs e)
        {
            if (DataGridViewArticle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewArticle.SelectedRows[0];
                DataGridViewArticle.Rows.Remove(selectedRow);
            }
            i--;
        }

        private void BouttonSupprimerEnregistrement_Click(object sender, EventArgs e)
        {
            decimal montantSupprimer = Convert.ToDecimal(DataGridViewEnregistrement.SelectedRows[0].Cells[1].Value);
            decimal ResteDu;
            string devise = DataGridViewEnregistrement.SelectedRows[0].Cells[3].Value.ToString();
            var recuperation = GetDeviseInfo(devise);
            decimal coursDeChange = recuperation.DeviseCours;


            if (LabelResteDu.Text == "Reste dû" || LabelResteDu.Text == "Soldé")
            {
                if (devise != "Euro")
                {
                    ResteDu = Convert.ToDecimal(LabelPrixResteDu.Text) + montantSupprimer / coursDeChange;
                    LabelResteDu.Text = "Reste dû";
                    LabelPrixResteDu.Text = ResteDu.ToString("N2");
                    TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;
                }
                else
                {
                    ResteDu = Convert.ToDecimal(LabelPrixResteDu.Text) + montantSupprimer;
                    LabelResteDu.Text = "Reste dû";
                    LabelPrixResteDu.Text = ResteDu.ToString("N2");
                    TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;

                }
            }
            else
            {
                if (devise != "Euro")
                {
                    ResteDu = montantSupprimer / coursDeChange - Convert.ToDecimal(LabelPrixResteDu.Text);
                    LabelResteDu.Text = "Reste dû";
                    LabelPrixResteDu.Text = ResteDu.ToString("N2");
                    TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;

                }
                else
                {
                    ResteDu = montantSupprimer - Convert.ToDecimal(LabelPrixResteDu.Text);
                    LabelResteDu.Text = "Reste dû";
                    LabelPrixResteDu.Text = ResteDu.ToString("N2");
                    TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;

                }
            }

            if (DataGridViewEnregistrement.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewEnregistrement.SelectedRows[0];
                DataGridViewEnregistrement.Rows.Remove(selectedRow);
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            BouttonEnregistrerDesignation.Enabled = true;

            TextBox textBox = (TextBox)sender;

            if (textBox.Text == textBox.Tag.ToString())
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
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void ComboBoxDeviseReste_SelectedIndexChanged(object sender, EventArgs e)
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
        private void BouttonNouveauDesignation_Click(object sender, EventArgs e)
        {
            BouttonFinDeSaisie.Enabled = false;

            foreach (Control control in TableLayoutPanelDesignation.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Tag?.ToString();
                }
            }

            TextBoxReference.Focus();
        }

        private void BouttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BouttonValider_Click(object sender, EventArgs e)
        {
            BouttonValider.Enabled = false;

            if (DataGridViewArticle.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridViewArticle.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string afRef = row.Cells[0].Value.ToString();
                        int quantiteVendue = Convert.ToInt32(row.Cells["quantiteVendue"].Value);

                        var articleMiseAJour = _context.F_ARTICLE.FirstOrDefault(article => article.AR_Ref == afRef);

                        if (articleMiseAJour != null)
                        {
                            int nouvelleQuantiteStock = (int)articleMiseAJour.AR_UnitePoids - (int)DataGridViewArticle.Rows[0].Cells[3].Value;
                            
                            articleMiseAJour.AR_UnitePoids = (short)nouvelleQuantiteStock;

                            _context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("L'article " + afRef + " n'existe pas dans la base de données. Opération annulée.");
                            return;
                        }
                    }
                }

                MessageBox.Show("Opération validée. Stock mis à jour.");
            }
            else
            {
                MessageBox.Show("Aucun article à valider.");
            }

            DataGridViewEnregistrement.Rows.Clear();
            DataGridViewArticle.Rows.Clear();
            TextBoxReference.Focus();
        }

        private void TextBoxReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            { 
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}

