using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
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

        private readonly ModeReglementRepository _reglementRepository;

        private static string dernierCours = "Euro";

        private int i = 0;

        private int compteurClick = 0;

        private decimal TotalPrixHT;
        
        private decimal TotalPrixTTC;

        private decimal variableTemporaire;

        private int cpt = 0;

        private decimal MontantInitial;

        public VenteComptoirForm()
        {
            _context = new AppDbContext();
            _deviseRepository = new DeviseRepository(_context);
            _reglementRepository = new ModeReglementRepository(_context);
        
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

            ChargerComboBoxes();
            #region BorderRadius
            BorderRaduis(PanelTotal);
            BorderRaduis(TableLayoutPanelInfoCaissier);
            BorderRaduis(PanelEnregistrement);
            BorderRaduis(TableLayoutPanelFooter);
            BorderRaduis(PanelCommandDroite);
            BorderRaduis(TableLayoutPanelDesignation);
            BorderRaduis(TableLayouotPanelHeader);
            #endregion
        }
        //*******************************************************************************************************************FRONT*******************************************************************************************************************// 
        private void BorderRaduis(Panel panel)
        {
            int borderRadius = 20;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        private void VenteComptoirForm_Resize(object sender, EventArgs e)
        {
            BorderRaduis(PanelTotal);
            BorderRaduis(TableLayoutPanelInfoCaissier);
            BorderRaduis(PanelEnregistrement);
            BorderRaduis(TableLayoutPanelFooter);
            BorderRaduis(PanelCommandDroite);
            BorderRaduis(TableLayouotPanelHeader);
            BorderRaduis(TableLayoutPanelDesignation);
        }

        //*******************************************************************************************************************BACK*******************************************************************************************************************//
        
        private void ChargerComboBoxes()
        {
            var deviseASelectionne = _deviseRepository.GetAll();
            var deviseObtenu = deviseASelectionne.Select(d => d.D_Intitule).ToList();

            var modeDeReglement = _reglementRepository.GetAll();
            var reglementObtenu = modeDeReglement.Select(r => r.R_Intitule).ToList();

            ComboBoxReglementEnregistrement.Items.Clear();
            ComboBoxDeviseEnregistrement.Items.Clear();

            foreach (var devise in deviseObtenu)
            {
                ComboBoxDeviseEnregistrement.Items.Add(devise.ToString());
                ComboBoxDeviseReste.Items.Add(devise.ToString());
            }

            foreach (var mode in reglementObtenu)
            {
                ComboBoxReglementEnregistrement.Items.Add(mode.ToString());
            }
        }

        private void ControlTableLayoutPanel()
        {

            foreach (Control control in TableLayoutPanelDesignation.Controls)
            {

                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Tag?.ToString();
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

            PanelInvisibleEnregistrement.Enabled = false;

            LabelPrixResteDu.Text = "0,00";
            LabelPrixTotalHT.Text = "0,00";
            LabelPrixTotalTTC.Text = "0,00";

            i = 0;

            DataGridViewEnregistrement.Rows.Clear();
            DataGridViewArticle.Rows.Clear();
            TextBoxReference.Focus();

        }

        private decimal TauxPriseEnCompte(string arRef)
        {
            var infoSupplementaireArticleTaxe = _context.F_ARTCOMPTA
                            .Where(article => article.AR_Ref == arRef)
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

            return infoSupplementaireTaxe?.TauxPriseEnCompte ?? 0;
        }

        private void TextBoxReference_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        public void TextBoxReference_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                try
                {
                    e.IsInputKey = true;

                    string codeFamilleOuDesignation = TextBoxReference.Text;
                    string pattern = @"\b" + Regex.Escape(codeFamilleOuDesignation) + @"\b";

                    var articles = _context.F_ARTICLE.ToList();
                    var codeFamilleBD = articles
                        .FirstOrDefault(a => a.AR_Ref == codeFamilleOuDesignation || a.FA_CodeFamille == codeFamilleOuDesignation || Regex.IsMatch(a.AR_Design.ToUpper(), pattern));
                    
                    var artclient = _context.F_ARTCLIENT.ToList();

                    if (codeFamilleBD != null)
                    {
                        var artclientDb = artclient.FirstOrDefault(a => a.AR_Ref == codeFamilleBD.AR_Ref && a.AC_Categorie == 3);
                        
                        var UniteVente = _context.P_UNITE
                        .Where(unite => unite.cbIndice == codeFamilleBD.AR_UniteVen)
                        .Select(unite => new
                        {
                            UniteIntitule = unite.U_Intitule
                        }).FirstOrDefault();


                        decimal tauxPriseEnCompte = TauxPriseEnCompte(codeFamilleBD.AR_Ref);
                        decimal puHT = (decimal)codeFamilleBD.AR_PrixVen;
                        decimal puTTC;
                        if (artclientDb.AC_PrixVen != 0.00m) 
                        {
                            puTTC = (decimal)artclientDb.AC_PrixVen;
                            puHT = puTTC / (1 + tauxPriseEnCompte / 100);
                        }
                        else
                        {

                            puTTC = puHT + puHT * tauxPriseEnCompte / 100;
                        }
                        
                        AjouterArticleDesigne(codeFamilleBD.AR_Ref, codeFamilleBD.AR_Design, 1, puHT, puTTC, UniteVente.UniteIntitule);
                    }
                    else
                    {
                        ArticleARechercher articleARechercher = new ArticleARechercher(codeFamilleOuDesignation);
                        articleARechercher.ShowDialog(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AjouterArticleDesigne(string arRef, string arDesign, int quantiteDisponibleEnStock, decimal puHT, decimal puTTC, string UniteVente)
        {
            TextBoxReference.Text = arRef;
            TextBoxDesignation.Text = arDesign;
            TextBoxConditionnement.Text = UniteVente;
            TextBoxQuantiteDisponibleEnStock.Text = quantiteDisponibleEnStock.ToString("N0");
            TextBoxPUHT.Text = puHT.ToString("N2");
            TextBoxPUTTC.Text = puTTC.ToString("N2");
            TextBoxPUnet.Text = puHT.ToString("N2");
            TextBoxMontantHT.Text = (puHT * quantiteDisponibleEnStock).ToString("N2");
            TextBoxMontantTTC.Text = (puTTC * quantiteDisponibleEnStock).ToString("N2");
        }

        private void BouttonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            BouttonEnAttente.Enabled = true;
            BouttonFinDeSaisie.Enabled = true;
            BouttonSupprimerDesignation.Enabled = true;
            BouttonCreerDoc.Enabled = false;
            BouttonRappelTicket.Enabled = false;
            BouttonTicket.Enabled = false;

            try
            {

                var articleBaseDeDonnees = _context.F_ARTSTOCK.FirstOrDefault(a => a.AR_Ref == TextBoxReference.Text);
                if(articleBaseDeDonnees != null )
                {
                    decimal quantiteEnStock = (decimal)articleBaseDeDonnees.AS_QteSto - (decimal)articleBaseDeDonnees.AS_QteRes;

                    if (Convert.ToInt16(TextBoxQuantiteDisponibleEnStock.Text) <= quantiteEnStock)
                    {

                        if (string.IsNullOrWhiteSpace(TextBoxReference.Text) ||
                        string.IsNullOrWhiteSpace(TextBoxDesignation.Text) ||
                        string.IsNullOrWhiteSpace(TextBoxQuantiteDisponibleEnStock.Text))
                        {
                            throw new Exception("Veuillez remplir tous les champs.");
                        }

                        string arRef = TextBoxReference.Text;
                        string arDesign = TextBoxDesignation.Text;
                        string conditionnement = TextBoxConditionnement.Text;
                        int quantiteEcriteStock = int.Parse(TextBoxQuantiteDisponibleEnStock.Text);
                        decimal puHT = Convert.ToDecimal(TextBoxPUHT.Text);
                        decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text);
                        decimal puNet = Convert.ToDecimal(TextBoxPUnet.Text);
                        decimal montantHT = Convert.ToDecimal(TextBoxMontantHT.Text);
                        decimal montantTTC = Convert.ToDecimal(TextBoxMontantTTC.Text);

                        if (TextBoxRemise.Text != "")
                        {

                            if (Convert.ToInt16(TextBoxRemise.Text) != 0)
                            {
                                decimal remiseArticle = Convert.ToInt32(TextBoxRemise.Text);

                                if (remiseArticle != 0)
                                    {
                                        decimal tauxPriseEnCompte = TauxPriseEnCompte(TextBoxReference.Text);

                                        puNet *= (1 - remiseArticle / 100);
                                        montantHT *= (1 - remiseArticle / 100);
                                        montantTTC *= (1 - remiseArticle / 100);
                                    }
                            }
                            else
                            {
                                MessageBox.Show("La quantité ne doit pas être nulle");
                                TextBoxRemise.Text = "";
                                TextBoxRemise.Focus();
                            }
                        }

                        DataGridViewArticle.Rows.Add(arRef, arDesign, puHT, puTTC, quantiteEcriteStock, conditionnement , TextBoxRemise.Text, puNet ,montantHT, montantTTC);

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
                    }
                    else
                    {
                        MessageBox.Show("La valeur entrée ne doit pas être nulle");
                        ControlTableLayoutPanel();
                    }
                }
                
                else
                {
                    MessageBox.Show("Veuillez remplir tout les champs");
                    
                    ControlTableLayoutPanel();

                    TextBoxReference.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erreur de format dans les champs numériques.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxRemise.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            TextBoxReference.Focus();
        }

        private void TextBoxQuantiteDisponibleEnStock_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (TextBoxQuantiteDisponibleEnStock.Text != "")
                {
                    if (Convert.ToInt16(TextBoxQuantiteDisponibleEnStock.Text) != 0)
                    {
                        var articleBaseDeDonneesMiseAJour = _context.F_ARTSTOCK.FirstOrDefault(article => article.AR_Ref == TextBoxReference.Text);

                        if (articleBaseDeDonneesMiseAJour != null)
                        {
                            decimal quantiteEnStock = (decimal)articleBaseDeDonneesMiseAJour.AS_QteSto - (decimal)articleBaseDeDonneesMiseAJour.AS_QteRes;

                            if (Convert.ToInt16(TextBoxQuantiteDisponibleEnStock.Text) <= quantiteEnStock)
                            {

                                if (int.TryParse(TextBoxQuantiteDisponibleEnStock.Text, out int quantiteDisponible))
                                {

                                    if (TextBoxPUHT.Text != "" && TextBoxPUTTC.Text != "")
                                    {
                                        decimal puHT = Convert.ToDecimal(TextBoxPUHT.Text);
                                        decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text);

                                        decimal montantHT = puHT * quantiteDisponible;
                                        decimal montanTTC = puTTC * quantiteDisponible;

                                        TextBoxMontantHT.Text = montantHT.ToString("N2");
                                        TextBoxMontantTTC.Text = montanTTC.ToString("N2");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("La quantité voulue dépasse la quantité en Stock.");
                                TextBoxQuantiteDisponibleEnStock.Text = "";
                                TextBoxQuantiteDisponibleEnStock.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'article n'a pas été trouvé dans la base de données.");
                            ControlTableLayoutPanel();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La quantité ne doit pas être nulle");
                        TextBoxQuantiteDisponibleEnStock.Text = "";
                        TextBoxQuantiteDisponibleEnStock.Focus();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private dynamic GetDeviseInfo(string devise)
        {
            var recuperationDevise = _context.P_DEVISE
                .Where(devises => devises.D_Intitule == devise)
                .Select(devises => new
                {
                    devises.D_Intitule,
                    devises.D_Cours,
                    devises.D_Monnaie,
                    devises.D_CodeISO,
                    devises.D_Sigle
                })
                .FirstOrDefault();

            return recuperationDevise;
        }

        private void BouttonFinDeSaisie_Click(object sender, EventArgs e)
        {
            compteurClick++;

            PanelInvisibleEnregistrement.Enabled = true;

            DataGridViewEnregistrement.Enabled = true;
            BouttonFinDeSaisie.Enabled = false;
            BouttonAnnuler.Enabled = true;
            BouttonEnAttente.Enabled = true;
            BouttonRaccourci.Enabled = true;
            BouttonFacture.Enabled = true;
            BouttonSupprimerDesignation.Enabled = false;

            TextBoxMontantEnregistrement.Text = LabelPrixTotalTTC.Text;
            variableTemporaire = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);

            LabelPrixResteDu.Text = LabelPrixTotalTTC.Text;

            TextBoxLibelleEnregistrement.Text = "Ticket " + compteurClick + " du " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private decimal ChoixDevise(decimal PrixTotalAConvertir, string devise)
        {
            var coursCible = GetDeviseInfo(devise);

            if(coursCible.D_Intitule != "Euro") 
            {

                if(dernierCours == "Euro")
                {
                    PrixTotalAConvertir *= (decimal)Math.Round(coursCible.D_Cours,4);
                }
                else
                {
                    var dernierDeviseCours = GetDeviseInfo(dernierCours);

                    PrixTotalAConvertir = PrixTotalAConvertir / dernierDeviseCours.D_Cours * (decimal)Math.Round(coursCible.D_Cours,4);
                }

                dernierCours = coursCible.D_Intitule;
                
                return PrixTotalAConvertir;
            }
            
            if(dernierCours == "Euro")
            {
                return PrixTotalAConvertir;

            }

            var dernierDeviseNonEuro = GetDeviseInfo(dernierCours);

            PrixTotalAConvertir /= Math.Round(dernierDeviseNonEuro.D_Cours,4);
            dernierCours = coursCible.D_Intitule;

            return PrixTotalAConvertir;

        }

        private void TextBoxMontantEnregistrement_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TextBoxMontantEnregistrement.Text))
            {
                MontantInitial = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);
            }
         
            if (TextBoxMontantEnregistrement.Text == "0,00" || TextBoxMontantEnregistrement.Text == "")
                BouttonEnregistrerEnregistrement.Enabled = false;
            else
                BouttonEnregistrerEnregistrement.Enabled = true;

        }

        private void ComboBoxDeviseEnregistrement_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(TextBoxMontantEnregistrement.Text != "")
            {
                string devise = ComboBoxDeviseEnregistrement.SelectedItem.ToString();
                TextBoxMontantEnregistrement.Text = ChoixDevise(MontantInitial,devise).ToString("N2");
            }
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
            try
            {
                cpt++;
                BouttonSupprimerEnregistrement.Enabled = true;
                BouttonTicket.Enabled = true;
                BouttonValider.Enabled = true;
                BouttonEnregistrerDesignation.Enabled = false;

                LabelPrixResteDu.Visible = true;

                if (string.IsNullOrEmpty(ComboBoxReglementEnregistrement.Text) || string.IsNullOrEmpty(ComboBoxDeviseEnregistrement.Text))
                {
                    throw new Exception("Veuillez sélectionner une devise et un mode de règlement");
                }

                string modeReception = ComboBoxReglementEnregistrement.SelectedItem.ToString();
                string libelle = TextBoxLibelleEnregistrement.Text;
                decimal montantEnregistrement = Convert.ToDecimal(TextBoxMontantEnregistrement.Text);
                string devise = ComboBoxDeviseEnregistrement.SelectedItem.ToString();

                var recuperation = GetDeviseInfo(devise);
                decimal coursDeChange = recuperation.D_Cours;
                decimal ResteDu;

                if (cpt == 1)
                {
                    ResteDu = (devise != "Euro") ? CalculerResteDu(variableTemporaire, coursDeChange, montantEnregistrement) : variableTemporaire - montantEnregistrement;
                }
                else
                {
                    decimal resteDuAvecCpt = Convert.ToDecimal(LabelPrixResteDu.Text);
                    ResteDu = (devise != "Euro") ? CalculerResteDu(resteDuAvecCpt, coursDeChange, montantEnregistrement) : resteDuAvecCpt - montantEnregistrement;
                }

                if (Math.Round(ResteDu, 2) > 0)
                {
                    LabelResteDu.Text = "Reste dû";
                }
                else if (Math.Round(ResteDu, 2) < 0)
                {
                    ResteDu = Math.Abs(ResteDu);
                    LabelResteDu.Text = "A rendre";
                }
                else
                {
                    LabelResteDu.Text = "Soldé";
                }

                LabelPrixResteDu.Text = ResteDu.ToString("N2");

                ComboBoxReglementEnregistrement.SelectedIndex = 0;
                ComboBoxDeviseEnregistrement.SelectedIndex = 0;
                variableTemporaire = ResteDu;
                TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;
                DateTimePickerEnregistrement.Value = DateTime.Now;

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = modeReception });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = montantEnregistrement });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = libelle });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = devise });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = DateTime.Now });

                DataGridViewEnregistrement.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BouttonSupprimerDesignation_Click(object sender, EventArgs e)
        {
            BouttonFinDeSaisie.Enabled = false;

            if (DataGridViewArticle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridViewArticle.SelectedRows[0];

                TextBoxReference.Text = selectedRow.Cells[0].Value.ToString();
                TextBoxDesignation.Text = selectedRow.Cells[1].Value.ToString();
                TextBoxPUHT.Text = selectedRow.Cells[2].Value.ToString();
                TextBoxPUTTC.Text = selectedRow.Cells[3].Value.ToString();
                TextBoxRemise.Text = selectedRow.Cells[6].Value.ToString();
                TextBoxPUnet.Text = TextBoxPUHT.Text;
                TextBoxMontantHT.Text = TextBoxPUHT.Text;
                TextBoxMontantTTC.Text = TextBoxPUTTC.Text;
                TextBoxQuantiteDisponibleEnStock.Text = selectedRow.Cells[4].Value.ToString();
                TextBoxConditionnement.Text = selectedRow.Cells[5].Value.ToString();


                LabelPrixTotalHT.Text = (Convert.ToDecimal(LabelPrixTotalHT.Text) - Convert.ToDecimal(selectedRow.Cells[8].Value)).ToString("N2");
                LabelPrixTotalTTC.Text = (Convert.ToDecimal(LabelPrixTotalTTC.Text) - Convert.ToDecimal(selectedRow.Cells[9].Value)).ToString("N2");

                DataGridViewArticle.Rows.Remove(selectedRow);
            }

            i--;

            TextBoxReference.Focus();
        }

        private decimal RetirerRemise(decimal puNet, decimal remise)
        {
            return puNet * remise / 100;
        }


        private void BouttonSupprimerEnregistrement_Click(object sender, EventArgs e)
        {

            if (DataGridViewEnregistrement.SelectedRows.Count == 0)
                return;

            decimal montantSupprimer = Convert.ToDecimal(DataGridViewEnregistrement.SelectedRows[0].Cells[1].Value);
            string devise = DataGridViewEnregistrement.SelectedRows[0].Cells[3].Value.ToString();
            var recuperation = GetDeviseInfo(devise);
            decimal coursDeChange = recuperation.D_Cours;
            decimal resteDu;

            if (devise != "Euro")
            {
                resteDu = Convert.ToDecimal(LabelPrixResteDu.Text) + montantSupprimer / coursDeChange;
            }
            else
            {
                resteDu = Convert.ToDecimal(LabelPrixResteDu.Text) + montantSupprimer;
            }

            LabelResteDu.Text = "Reste dû";
            LabelPrixResteDu.Text = resteDu.ToString("N2");
            TextBoxMontantEnregistrement.Text = LabelPrixResteDu.Text;

            DataGridViewRow selectedRow = DataGridViewEnregistrement.SelectedRows[0];
            DataGridViewEnregistrement.Rows.Remove(selectedRow);
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

        private void BouttonNouveauDesignation_Click(object sender, EventArgs e)
        {
            BouttonFinDeSaisie.Enabled = false;

            ControlTableLayoutPanel();

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
                        int quantiteVendue = Convert.ToInt32(row.Cells[4].Value);

                        var articleMiseAJour = _context.F_ARTSTOCK.FirstOrDefault(article => article.AR_Ref == afRef);
                        var articlePrixMiseAJour = _context.F_ARTICLE.FirstOrDefault(article => article.AR_Ref == afRef);

                        int nouvelleQuantiteStock = (int)articleMiseAJour.AS_QteSto - (int)DataGridViewArticle.Rows[0].Cells[4].Value;
                        
                        articleMiseAJour.AS_MontSto = articlePrixMiseAJour.AR_PrixAch * nouvelleQuantiteStock;
                        articleMiseAJour.AS_QteSto = (short)nouvelleQuantiteStock;

                        _context.SaveChanges();
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

        private void ComboBoxDeviseReste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

