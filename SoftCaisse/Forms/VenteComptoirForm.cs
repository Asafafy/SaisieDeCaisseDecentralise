using ComponentFactory.Krypton.Toolkit;
using Objets100cLib;
using SoftCaisse.CustomModel;
using SoftCaisse.Forms.Article;
using SoftCaisse.Forms.AttenteTicket;
using SoftCaisse.Forms.FormCaisse;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;





namespace SoftCaisse.Forms.VenteComptoir
{
    public partial class VenteComptoirForm : KryptonForm
    {
        private readonly AppDbContext _context;
        private readonly SageContexte _sageObj;
        private readonly DeviseRepository _deviseRepository;
        private readonly P_REGLEMENTRepository _reglementRepository;
        private static string dernierCours = "Euro";
        private int compteurClick = 0;
        private F_CAISSE _caisse;
        private F_COLLABORATEUR _caissier;
        private decimal _totalPrixHT;
        private decimal _totalPrixTTC;
        private decimal variableTemporaire;
        private int cpt = 0;
        private decimal MontantInitial;
        private string refDoc;
        private int changedIndex = -1;
        private decimal pourcentageRemise;





        // ======================================================================================================
        // ============================================ CONSTRUCTEUR ============================================
        public VenteComptoirForm(int caisse, int caissier, F_DOCENTETE entete, List<F_DOCLIGNE> ligne)
        {
            _context = new AppDbContext();
            _deviseRepository = new DeviseRepository(_context);
            _reglementRepository = new P_REGLEMENTRepository(_context);
            _caisse = _context.F_CAISSE.FirstOrDefault(u => u.CA_No == caisse);
            _caissier = _context.F_COLLABORATEUR.FirstOrDefault(u => u.CO_No == caissier);

            _sageObj = new SageContexte();

            InitializeComponent();
            TextBoxRemise.KeyPress += new KeyPressEventHandler(TextBoxRemise_KeyPress);

            LabelNomCaissier.Text = CaisseOuvert.CaissierText;
            LabelTitleCaissier.Text = CaisseOuvert.CaisseText;

            foreach (Control control in TableLayoutPanelDesignation.Controls)
            {
                if (control is TextBox)
                {
                    control.Enter += TextBox_Enter;
                    control.Leave += TextBox_Leave;
                    control.Tag = control.Text;
                }
            }

            ComboBoxType.DataSource = _context.F_COMPTET.Where(u => u.CG_NumPrinc == "4110000").Select(u => new Controle() { item = u.CT_Num + "  " + u.CT_Intitule, valeur = u.CT_Num }).ToList();
            ComboBoxVendeur.DataSource = _context.F_COLLABORATEUR.Where(u => u.CO_Vendeur == 1).Select(u => new Controle() { item = u.CO_Nom + "  " + u.CO_Prenom, valeur = u.CO_No.ToString() }).ToList();
            ComboBoxCentrale.DataSource = _context.F_COMPTET.Where(u => u.CG_NumPrinc == "4110000").Select(u => new Controle() { item = u.CT_Num + "  " + u.CT_Intitule, valeur = u.CT_Num }).ToList();
            ComboBoxDepot.DataSource = _context.F_DEPOT.Select(u => new Controle() { item = u.DE_Intitule, valeur = u.DE_Intitule }).ToList();
            ComboBoxTarif.DataSource = _context.P_CATTARIF.Where(u => !string.IsNullOrEmpty(u.CT_Intitule)).Select(u => new Controle() { item = u.CT_Intitule, valeur = u.cbMarq.ToString() }).ToList();
            ComboboxSouche.DataSource = _context.P_SOUCHEVENTE.Where(u => !string.IsNullOrEmpty(u.S_Intitule)).Select(u => new Controle() { item = u.S_Intitule, valeur = u.S_Intitule }).ToList();
            ComboBoxAffaire.DataSource = _context.F_COMPTEA.Where(u => u.N_Analytique == 3).Select(u => new { Label = u.CA_Num + "  " + u.CA_Intitule, Valeur = u.CA_Num }).ToList();

            ComboboxSouche.DisplayMember = "item";
            ComboboxSouche.ValueMember = "valeur";
            if (_caisse.CA_Souche != 0)
            {
                P_SOUCHEVENTE vente = _context.P_SOUCHEVENTE.FirstOrDefault(u => u.cbMarq == _caisse.CA_Souche);
                ComboboxSouche.SelectedIndex = ComboboxSouche.FindString(vente.S_Intitule);
            }
            ComboBoxAffaire.DisplayMember = "item";
            ComboBoxAffaire.ValueMember = "valeur";
            ComboBoxTarif.DisplayMember = "item";
            ComboBoxTarif.ValueMember = "valeur";
            ComboBoxDepot.DisplayMember = "item";
            ComboBoxDepot.ValueMember = "valeur";
            ComboBoxType.DisplayMember = "item";
            ComboBoxType.ValueMember = "valeur";
            ComboBoxVendeur.DisplayMember = "item";
            ComboBoxVendeur.ValueMember = "valeur";
            ComboBoxCentrale.DisplayMember = "item";
            ComboBoxCentrale.ValueMember = "valeur";
            if (entete != null)
            {
                ComboBoxVendeur.SelectedValue = entete.CO_No;
                ComboBoxCentrale.SelectedValue = entete.DO_Tiers;
                ComboBoxType.SelectedValue = entete.DO_Tiers;
                ComboBoxAffaire.SelectedValue = entete.CA_Num;
                ComboBoxDepot.SelectedValue = _context.F_DEPOT.FirstOrDefault(u => u.cbMarq == entete.DE_No).DE_Intitule;
                BouttonEnAttente.Enabled = true;
                BouttonFinDeSaisie.Enabled = true;
                BouttonSupprimerDesignation.Enabled = true;
                BouttonCreerDoc.Enabled = false;
                BouttonRappelTicket.Enabled = false;
                BouttonTicket.Enabled = false;
                refDoc = entete.DO_Piece;
                NumTicket.Text = "Numero de Ticket Rappel : " + entete.DO_Piece;
            }
            if (ligne != null)
            {
                decimal _totalPrixHT = 0;
                decimal _totalPrixTTC = 0;
                foreach (var cin in ligne)
                {
                    DataGridViewArticle.Rows.Add(cin.AR_Ref, cin.DL_Design, cin.DL_PrixUnitaire, cin.DL_PrixUnitaire * 1.2m, cin.DL_Qte, cin.EU_Enumere, "", cin.DL_PrixUnitaire, cin.DL_MontantHT, cin.DL_MontantTTC);
                    _totalPrixHT += cin.DL_MontantHT.Value;
                    _totalPrixTTC += cin.DL_MontantTTC.Value;
                }
                LabelPrixTotalHT.Text = _totalPrixHT.ToString("N2");
                LabelPrixTotalTTC.Text = _totalPrixTTC.ToString("N2");
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
        // ============================================ CONSTRUCTEUR ============================================
        // ======================================================================================================





        // ===================================================================================================
        // ============================================ FONCTIONS ============================================
        // ******************************************** FRONT ************************************************ 
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

        //*********************************************** BACK ***************************************************
        private void ChargerComboBoxes()
        {
            var deviseASelectionne = _deviseRepository.GetAll();
            var deviseObtenu = deviseASelectionne.Select(d => d.D_Intitule).ToList();
            var modeDeReglement = _reglementRepository.GetAll();
            var reglementObtenu = modeDeReglement.Select(r => r.R_Intitule).ToList();

            ComboBoxDeviseEnregistrement.Items.Clear();
            ComboBoxDeviseReste.Items.Clear();
            foreach (var devise in deviseObtenu)
            {
                ComboBoxDeviseEnregistrement.Items.Add(devise.ToString());
                ComboBoxDeviseReste.Items.Add(devise.ToString());
            }

            ComboBoxDeviseEnregistrement.SelectedIndex = 0;
            ComboBoxDeviseReste.SelectedIndex = 0;

            ComboBoxReglementEnregistrement.Items.Clear();
            foreach (var mode in reglementObtenu)
            {
                ComboBoxReglementEnregistrement.Items.Add(mode.ToString());
            }

            ComboBoxReglementEnregistrement.SelectedIndex = 0;

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

        private void creation_facture(object sender, EventArgs e)
        {
            Controle tier = (Controle)ComboBoxType.SelectedItem;
            Controle payeur = (Controle)ComboBoxCentrale.SelectedItem;
            List<Fligne> fligne = new List<Fligne>();
            List<Freglement> freglement = new List<Freglement>();
            Fentete fentete = new Fentete()
            {
                caisse = LabelTitleCaissier.Text,
                type = "Facture",
                date = DateTime.Now.ToShortDateString(),
                numero = refDoc
            };

            foreach (DataGridViewRow ligne in DataGridViewArticle.Rows)
            {

                string reduct = string.IsNullOrEmpty(ligne.Cells[6].Value.ToString()) ? "0%" : ligne.Cells[6].Value.ToString() + "%";
                fligne.Add(new Fligne()
                {
                    reference = ligne.Cells[0].FormattedValue.ToString(),
                    designation = ligne.Cells[1].FormattedValue.ToString(),
                    montant_ht = double.Parse(ligne.Cells[2].FormattedValue.ToString()),
                    prix_unitaire = double.Parse(ligne.Cells[3].FormattedValue.ToString()),
                    quantite = double.Parse(ligne.Cells[4].FormattedValue.ToString()),
                    remise = reduct
                });
            }
            var tiers = _context.F_COMPTEA.FirstOrDefault(u => u.CA_Num == ComboBoxAffaire.SelectedValue.ToString());
            var nAnalytique = _context.P_ANALYTIQUE.FirstOrDefault(u => u.cbMarq == tiers.N_Analytique);
            string regl_libelle = TextBoxLibelleEnregistrement.Text;
            regl_libelle = regl_libelle.Replace("ticket", "facture");

            if (refDoc == null)
            {
                IBODocument3 type = _sageObj.CreateFACTURE(ComboBoxDeviseReste.Text, ComboBoxDepot.SelectedValue.ToString(), nAnalytique.A_Intitule, tiers.CA_Num, _caissier.CO_Nom, _caissier.CO_Prenom, tier.valeur, payeur.valeur, fligne);
                if (type != null)
                {
                    fentete.numero = type.DO_Piece;
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + " , CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " ,DO_Valide=1 where DO_Piece like '" + type.DO_Piece + "'");
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + " , CO_No=" + _caissier.CO_No + " ,cbCO_No=" + _caissier.CO_No + " where DO_Piece like '" + type.DO_Piece + "'");
                    foreach (DataGridViewRow obj in DataGridViewEnregistrement.Rows)
                    {
                        double valeur = Double.Parse(obj.Cells[1].FormattedValue.ToString());
                        IBODocumentReglement docuement = _sageObj.createReglement(regl_libelle, DateTime.Now, valeur, obj.Cells[0].FormattedValue.ToString(), type.DO_Piece, obj.Cells[3].FormattedValue.ToString(), _caisse.JO_Num);
                        freglement.Add(new Freglement()
                        {
                            Date = DateTime.Now.ToShortDateString(),
                            Montant = Double.Parse(obj.Cells[1].FormattedValue.ToString()),
                            Type = obj.Cells[0].FormattedValue.ToString()
                        });
                        _context.Database.ExecuteSqlCommand("UPDATE F_CREGLEMENT set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + ", CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " where RG_Piece =" + docuement.RG_Piece);
                    }
                }
            }
            else
            {
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Domaine=0 , DO_Type=6 , DO_DocType=6 , DO_Escompte=0, DO_Valide=0 where DO_Piece like '" + refDoc + "'");
                foreach (DataGridViewRow obj in DataGridViewEnregistrement.Rows)
                {
                    double valeur = Double.Parse(obj.Cells[1].FormattedValue.ToString());
                    IBODocumentReglement docuement = _sageObj.createReglement(regl_libelle, DateTime.Now, valeur, obj.Cells[0].FormattedValue.ToString(), refDoc, obj.Cells[3].FormattedValue.ToString(), _caisse.JO_Num);
                    freglement.Add(new Freglement()
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        Montant = Double.Parse(obj.Cells[1].FormattedValue.ToString()),
                        Type = obj.Cells[0].FormattedValue.ToString()
                    });
                    _context.Database.ExecuteSqlCommand("UPDATE F_CREGLEMENT set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + ", CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " where RG_Piece =" + docuement.RG_Piece);
                }
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Attente=0 where DO_Piece like '" + refDoc + "'");
            }
            Close();
            P_DEVISE devise = _context.P_DEVISE.FirstOrDefault(u => u.D_Intitule + "" == ComboBoxDeviseReste.SelectedItem.ToString());
            string deviseInt = devise.D_Intitule;
            Reporting report = new Reporting(fentete, fligne, freglement, deviseInt);
            report.BringToFront();
            report.Show();
            report.Focus();
        }

        private void change_tarif(object sender, EventArgs e)
        {
            Controle obj = (Controle)ComboBoxCentrale.SelectedItem;
            F_COMPTET valeur = _context.F_COMPTET.FirstOrDefault(u => u.CT_Num == obj.valeur);
            P_CATTARIF tarif = _context.P_CATTARIF.FirstOrDefault(u => u.cbMarq == valeur.N_CatTarif);
            if (valeur != null)
            {
                ComboBoxTarif.SelectedIndex = ComboBoxTarif.FindString(tarif.CT_Intitule);
            }
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
        // ============================================ FONCTIONS ============================================
        // ===================================================================================================





        // ====================================================================================================
        // ============================================ EVENEMENTS ============================================
        private void TextBoxRemise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void TextBoxRemise_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"^\d+\.$");
                if (regex.IsMatch(TextBoxRemise.Text))
                {
                    // Ne rien faire.
                }
                else
                {
                    string cultureName = "en-EN"; // Exemple pour la culture française
                    CultureInfo culture = new CultureInfo(cultureName);
                    if (decimal.TryParse(TextBoxRemise.Text, NumberStyles.Number, culture, out pourcentageRemise))
                    {
                        //decimal pourcentageRemise = Convert.ToDecimal(TextBoxRemise.Text == "" ? "0" : TextBoxRemise.Text);
                        decimal puHTSansRemise = Convert.ToDecimal(TextBoxPUHT?.Text == "" ? "0" : TextBoxPUHT?.Text);
                        decimal puTTCSansRemise = Convert.ToDecimal(TextBoxPUTTC?.Text == "" ? "0" : TextBoxPUTTC?.Text);
                        MettreAJourMontants(1, puHTSansRemise, puTTCSansRemise, pourcentageRemise);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void VenteComptoirForm_Load(object sender, EventArgs e)
        {
            TextBoxReference.Focus();
            if (DataGridViewArticle.Rows.Count < 1)
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

            DataGridViewEnregistrement.Rows.Clear();
            DataGridViewArticle.Rows.Clear();
            TextBoxReference.Focus();
            if (refDoc != null)
            {
                var entete = _context.F_DOCENTETE.FirstOrDefault(u => u.DO_Piece == refDoc);
                var ligne = _context.F_DOCLIGNE.Where(u => u.DO_Piece == refDoc).ToList();
                var reglement = _context.F_CREGLEMENT.Where(u => u.RG_Libelle.Contains(refDoc)).ToList();
                foreach (var items in ligne)
                {
                    _context.Database.ExecuteSqlCommand("delete from F_DOCLIGNEEMPL where DL_No=" + items.DL_No);
                }
                _context.Database.ExecuteSqlCommand("delete from F_DOCLIGNE where DO_Piece like '" + refDoc + "'");
                _context.Database.ExecuteSqlCommand("delete from F_REGLECH where DO_Piece like '" + refDoc + "'");
                foreach (var items in reglement)
                {
                    _context.Database.ExecuteSqlCommand("delete from F_DOCREGL where DO_Piece like '" + refDoc + "'");
                }
                foreach (var items in reglement)
                {
                    _context.Database.ExecuteSqlCommand("delete from F_CREGLEMENT where RG_Libelle like '%" + refDoc + "%'");
                    _context.Database.ExecuteSqlCommand("delete from F_DOCENTETE where DO_Piece like '" + refDoc + "'");
                }
                MessageBox.Show("Suppression Document avec succès !", "Mouvement Document", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

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
                decimal puHT;
                decimal puTTC;
                Controle selectedCategTarifaire = (Controle)ComboBoxTarif.SelectedItem;
                try
                {
                    e.IsInputKey = true;

                    string codeFamilleOuDesignation = TextBoxReference.Text.ToLower();

                    var articleSaisie = _context.F_ARTICLE.Where(a => a.AR_Ref.ToLower() == codeFamilleOuDesignation || a.FA_CodeFamille.ToLower() == codeFamilleOuDesignation).FirstOrDefault();
                    if (articleSaisie != null)
                    {
                        var artClient = _context.F_ARTCLIENT.Where(artCli => artCli.AR_Ref == articleSaisie.AR_Ref && artCli.AC_Categorie.ToString() == selectedCategTarifaire.valeur).FirstOrDefault();
                        var artCompta = _context.F_ARTCOMPTA.Where(artCmpt => artCmpt.AR_Ref == articleSaisie.AR_Ref && artCmpt.ACP_TypeFacture == 0 && artCmpt.ACP_Type == 0 && artCmpt.ACP_Champ == 1).FirstOrDefault();
                        var taxe1 = _context.F_TAXE.Where(taxe => taxe.TA_Code == artCompta.ACP_ComptaCPT_Taxe1).FirstOrDefault();
                        var taxe2 = _context.F_TAXE.Where(taxe => taxe.TA_Code == artCompta.ACP_ComptaCPT_Taxe2).FirstOrDefault();
                        var taxe3 = _context.F_TAXE.Where(taxe => taxe.TA_Code == artCompta.ACP_ComptaCPT_Taxe3).FirstOrDefault();
                        decimal taux1 = taxe1?.TA_Taux ?? 0;
                        decimal taux2 = taxe2?.TA_Taux ?? 0;
                        decimal taux3 = taxe3?.TA_Taux ?? 0;
                        bool estHorsTaxe;

                        if (artClient != null)
                        {
                            estHorsTaxe = artClient.AC_PrixTTC == 0 ? true : false;
                            bool prixVenteEstZero = artClient.AC_PrixVen == 0 ? true : false;
                            if (!prixVenteEstZero)
                            {
                                if (estHorsTaxe)
                                {
                                    puHT = (decimal)artClient.AC_PrixVen;
                                    puTTC = puHT * (taux1 + taux2 + taux3 + 100) / 100;
                                }
                                else
                                {
                                    puTTC = (decimal)artClient.AC_PrixVen;
                                    puHT = 100 * puTTC / (100 + taux1 + taux2 + taux3);
                                }
                            }
                            else
                            {
                                bool prixVenteArtEstHorsTaxe = articleSaisie.AR_PrixTTC == 0 ? true : false;
                                if (prixVenteArtEstHorsTaxe)
                                {
                                    puHT = (decimal)articleSaisie.AR_PrixVen;
                                    puTTC = puHT * (taux1 + taux2 + taux3 + 100) / 100;
                                }
                                else
                                {
                                    puTTC = (decimal)articleSaisie.AR_PrixVen;
                                    puHT = 100 * puTTC / (100 + taux1 + taux2 + taux3);
                                }
                            }
                        }
                        else
                        {
                            estHorsTaxe = articleSaisie.AR_PrixTTC == 0 ? true : false;
                            if (estHorsTaxe)
                            {
                                puHT = (decimal)articleSaisie.AR_PrixVen;
                                puTTC = puHT * (taux1 + taux2 + taux3 + 100) / 100;
                            }
                            else
                            {
                                puTTC = (decimal)articleSaisie.AR_PrixVen;
                                puHT = 100 * puTTC / (100 + taux1 + taux2 + taux3);
                            }
                        }
                        AjouterPrix(articleSaisie.AR_Ref, articleSaisie.AR_Design, 1, puHT, puTTC, estHorsTaxe ? "HT" : "TTC");
                        MettreAJourMontants(1, puHT, puTTC, pourcentageRemise);
                    }
                    else
                    {
                        ListeArticles articleARechercher = new ListeArticles(codeFamilleOuDesignation, true, false, selectedCategTarifaire.valeur, pourcentageRemise);
                        articleARechercher.ShowDialog(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AjouterPrix(string arRef, string arDesign, int quantite, decimal puHT, decimal puTTC, string UniteVente)
        {
            TextBoxReference.Text = arRef;
            TextBoxDesignation.Text = arDesign;
            TextBoxConditionnement.Text = UniteVente;
            TextBoxQuantiteDisponibleEnStock.Text = quantite.ToString("N0");
            TextBoxPUnet.Text = puHT.ToString("N2");
            TextBoxPUHT.Text = puHT.ToString("N2");
            TextBoxPUTTC.Text = puTTC.ToString("N2");
        }
        public void MettreAJourMontants(int quantite, decimal puHT, decimal puTTC, decimal remisePourcent)
        {
            var montantPuHT = puHT - (puHT * remisePourcent / 100);
            var montantPuTTC = puTTC - (puTTC * remisePourcent / 100);
            TextBoxMontantHT.Text = (montantPuHT * quantite).ToString("N2");
            TextBoxPUnet.Text = (montantPuHT).ToString("N2");
            TextBoxMontantTTC.Text = (montantPuTTC * quantite).ToString("N2");
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
                if (articleBaseDeDonnees != null)
                {
                    decimal quantiteEnStock = (decimal)articleBaseDeDonnees.AS_QteSto - (decimal)articleBaseDeDonnees.AS_QteRes;

                    if (Convert.ToInt16(TextBoxQuantiteDisponibleEnStock.Text) <= quantiteEnStock)
                    {
                        if (string.IsNullOrWhiteSpace(TextBoxReference.Text) || string.IsNullOrWhiteSpace(TextBoxDesignation.Text) || string.IsNullOrWhiteSpace(TextBoxQuantiteDisponibleEnStock.Text))
                        {
                            MessageBox.Show("Veuillez remplir tous les champs.");
                            return;
                        }

                        string arRef = TextBoxReference.Text;
                        string arDesign = TextBoxDesignation.Text;
                        string conditionnement = TextBoxConditionnement.Text;
                        int quantiteEcriteStock = int.Parse(TextBoxQuantiteDisponibleEnStock.Text);
                        decimal puHT = Convert.ToDecimal(TextBoxPUHT?.Text ?? "0");
                        decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text ?? "0");
                        decimal puNet = Convert.ToDecimal(TextBoxPUnet.Text ?? "0");
                        decimal montantHT = Convert.ToDecimal(TextBoxMontantHT.Text ?? "0");
                        decimal montantTTC = Convert.ToDecimal(TextBoxMontantTTC.Text ?? "0");
                        if (changedIndex == -1)
                        {
                            DataGridViewArticle.Rows.Add(arRef, arDesign, puHT, puTTC, quantiteEcriteStock, conditionnement, TextBoxRemise.Text, puNet, montantHT, montantTTC);
                        }
                        else
                        {
                            DataGridViewArticle.Rows[changedIndex].Cells[0].Value = arRef;
                            DataGridViewArticle.Rows[changedIndex].Cells[1].Value = arDesign;
                            DataGridViewArticle.Rows[changedIndex].Cells[2].Value = puHT;
                            DataGridViewArticle.Rows[changedIndex].Cells[3].Value = puTTC;
                            DataGridViewArticle.Rows[changedIndex].Cells[4].Value = quantiteEcriteStock;
                            DataGridViewArticle.Rows[changedIndex].Cells[5].Value = conditionnement;
                            DataGridViewArticle.Rows[changedIndex].Cells[6].Value = TextBoxRemise.Text;
                            DataGridViewArticle.Rows[changedIndex].Cells[7].Value = puNet;
                            DataGridViewArticle.Rows[changedIndex].Cells[8].Value = montantHT;
                            DataGridViewArticle.Rows[changedIndex].Cells[9].Value = montantTTC;
                            changedIndex = -1;
                        }

                        _totalPrixHT += montantHT;
                        _totalPrixTTC += montantTTC;

                        LabelPrixTotalHT.Text = _totalPrixHT.ToString("N2");
                        LabelPrixTotalTTC.Text = _totalPrixTTC.ToString("N2");

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
            Controle valeur = (Controle)ComboboxSouche.SelectedItem;
            string count = _sageObj.get_current_piece(valeur.item);
            TextBoxLibelleEnregistrement.Text = "Règlt ticket " + count + " " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private decimal ChoixDevise(decimal PrixTotalAConvertir, string devise)
        {
            var coursCible = GetDeviseInfo(devise);

            if (coursCible.D_Intitule != "Euro")
            {

                if (dernierCours == "Euro")
                {
                    PrixTotalAConvertir *= (decimal)Math.Round(coursCible.D_Cours, 4);
                }
                else
                {
                    var dernierDeviseCours = GetDeviseInfo(dernierCours);

                    PrixTotalAConvertir = PrixTotalAConvertir / dernierDeviseCours.D_Cours * (decimal)Math.Round(coursCible.D_Cours, 4);
                }

                dernierCours = coursCible.D_Intitule;

                return PrixTotalAConvertir;
            }

            if (dernierCours == "Euro")
            {
                return PrixTotalAConvertir;

            }

            var dernierDeviseNonEuro = GetDeviseInfo(dernierCours);

            PrixTotalAConvertir /= Math.Round(dernierDeviseNonEuro.D_Cours, 4);
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

            if (TextBoxMontantEnregistrement.Text != "")
            {
                string devise = ComboBoxDeviseEnregistrement.SelectedItem.ToString();
                TextBoxMontantEnregistrement.Text = ChoixDevise(MontantInitial, devise).ToString("N2");
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
                    MessageBox.Show("Veuillez sélectionner une devise et un mode de règlement");
                    return;
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


            TextBoxReference.Focus();
        }

        // DEBUT FAFANA RAHA TSY ILAINA FA METHODE TSY MIASA AKORY
        private decimal RetirerRemise(decimal puNet, decimal remise)
        {
            return puNet * remise / 100;
        }
        // FIN FAFANA RAHA TSY ILAINA FA METHODE TSY MIASA AKORY


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
            Close();
        }

        private void BouttonValider_Click(object sender, EventArgs e)
        {

            BouttonValider.Enabled = false;
            if (DataGridViewArticle.Rows.Count > 0)
            {
                Controle tier = (Controle)ComboBoxType.SelectedItem;
                Controle payeur = (Controle)ComboBoxCentrale.SelectedItem;
                List<Fligne> article = new List<Fligne>();
                foreach (DataGridViewRow ligne in DataGridViewArticle.Rows)
                {
                    string reduct = string.IsNullOrEmpty(ligne.Cells[6].Value.ToString()) ? "0%" : ligne.Cells[6].Value.ToString() + "%";
                    article.Add(
                        new Fligne()
                        {
                            reference = ligne.Cells[0].Value + "",
                            quantite = double.Parse(ligne.Cells[4].Value + ""),
                            remise = reduct
                        }
                    );
                }
                Controle valeurs = (Controle)ComboboxSouche.SelectedItem;
                var tiers = _context.F_COMPTEA.FirstOrDefault(u => u.CA_Num == ComboBoxAffaire.SelectedValue.ToString());
                var nAnalytique = _context.P_ANALYTIQUE.FirstOrDefault(u => u.cbMarq == tiers.N_Analytique);
                string regl_libelle = TextBoxLibelleEnregistrement.Text;
                if (refDoc == null)
                {
                    IBODocument3 type = _sageObj.createTicket(ComboBoxDeviseReste.SelectedItem.ToString(), valeurs.item, nAnalytique.A_Intitule, tiers.CA_Num, ComboBoxDepot.SelectedValue.ToString(), _caissier.CO_Nom, _caissier.CO_Prenom, tier.valeur, payeur.valeur, article);
                    if (type != null)
                    {
                        _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + " , CO_NoCaissier=" + _caissier.CO_No + " , cbCO_NoCaissier = " + _caissier.CO_No + ", DO_Valide=1 where DO_Piece like '" + type.DO_Piece + "'");
                        _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + " , CO_No=" + _caissier.CO_No + " , cbCO_No = " + _caissier.CO_No + " where DO_Piece like '" + type.DO_Piece + "'");

                        foreach (DataGridViewRow obj in DataGridViewEnregistrement.Rows)
                        {
                            double valeur = Double.Parse(obj.Cells[1].FormattedValue.ToString());
                            IBODocumentReglement docuement = _sageObj.createReglement(regl_libelle, DateTime.Now, valeur, obj.Cells[0].FormattedValue.ToString(), type.DO_Piece, obj.Cells[3].FormattedValue.ToString(), _caisse.JO_Num);
                            _context.Database.ExecuteSqlCommand("UPDATE F_CREGLEMENT set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + ", CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " where RG_Piece =" + docuement.RG_Piece);
                        }
                        MessageBox.Show("Opération validée. Stock mis à jour.");
                    }
                }
                else
                {
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Domaine=0 , DO_Type=6 , DO_DocType=6 , DO_Escompte=0, DO_Valide=0 where DO_Piece like '" + refDoc + "'");

                    foreach (DataGridViewRow obj in DataGridViewEnregistrement.Rows)
                    {
                        double valeur = Double.Parse(obj.Cells[1].FormattedValue.ToString());
                        IBODocumentReglement docuement = _sageObj.createReglement(regl_libelle, DateTime.Now, valeur, obj.Cells[0].FormattedValue.ToString(), refDoc, obj.Cells[3].FormattedValue.ToString(), _caisse.JO_Num);
                        _context.Database.ExecuteSqlCommand("UPDATE F_CREGLEMENT set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + ", CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " where RG_Piece =" + docuement.RG_Piece);
                    }

                    _context.Database.ExecuteSqlCommand("UPDATE F_REGLECH set DO_Domaine=3 , DO_Type=30 where DO_Piece like '" + refDoc + "'");
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Attente=0 , DO_Domaine=3, DO_Type=30, DO_DocType=30 , DO_Escompte=0  where DO_Piece like '" + refDoc + "'");
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set DO_Domaine=3 , DO_Type=30, DO_DocType=30 , DL_Escompte=0 where DO_Piece like '" + refDoc + "'");
                }

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

        private void ComboBoxNumero_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((string)ComboBoxNumero.SelectedValue == "1")
            {
                ComboBoxType.DataSource = _context.F_COMPTET.Select(u => new { Label = u.CT_Num + "  " + u.CT_Intitule, Valeur = u.CT_Num }).ToList();
            }
            if ((string)ComboBoxNumero.SelectedValue == "2")
            {
                ComboBoxType.DataSource = _context.F_COMPTET.Select(u => new { Label = u.CT_Intitule, Valeur = u.CT_Num }).ToList();
            }
            if ((string)ComboBoxNumero.SelectedValue == "3")
            {
                ComboBoxType.DataSource = _context.F_COMPTET.Select(u => new { Label = u.CT_CodePostal + "  " + u.CT_Intitule, Valeur = u.CT_Num }).ToList();
            }
        }



        private void BouttonTicket_Click(object sender, EventArgs e)
        {
            Controle tier = (Controle)ComboBoxType.SelectedItem;
            List<Fligne> fligne = new List<Fligne>();
            List<Freglement> freglement = new List<Freglement>();
            Controle payeur = (Controle)ComboBoxCentrale.SelectedItem;

            Controle valeurs = (Controle)ComboboxSouche.SelectedItem;

            foreach (DataGridViewRow ligne in DataGridViewArticle.Rows)
            {

                string reduct = string.IsNullOrEmpty(ligne.Cells[6].Value.ToString()) ? "0%" : ligne.Cells[6].Value.ToString() + "%";
                fligne.Add(new Fligne()
                {
                    reference = ligne.Cells[0].FormattedValue.ToString(),
                    designation = ligne.Cells[1].FormattedValue.ToString(),
                    montant_ht = double.Parse(ligne.Cells[2].FormattedValue.ToString()),
                    prix_unitaire = double.Parse(ligne.Cells[3].FormattedValue.ToString()),
                    quantite = double.Parse(ligne.Cells[4].FormattedValue.ToString()),
                    remise = reduct
                });
            }
            Fentete fentete = new Fentete()
            {
                caisse = LabelTitleCaissier.Text,
                date = DateTime.Now.ToShortDateString(),
                numero = refDoc,
                type = "Ticket"
            };
            string regl_libelle = TextBoxLibelleEnregistrement.Text;
            if (refDoc == null)
            {
                var tiers = _context.F_COMPTEA.FirstOrDefault(u => u.CA_Num == ComboBoxAffaire.SelectedValue.ToString());
                var nAnalytique = _context.P_ANALYTIQUE.FirstOrDefault(u => u.cbMarq == tiers.N_Analytique);
                IBODocument3 type = _sageObj.createTicket(ComboBoxDeviseReste.SelectedItem.ToString(), valeurs.item, nAnalytique.A_Intitule, tiers.CA_Num, ComboBoxDepot.SelectedValue.ToString(), _caissier.CO_Nom, _caissier.CO_Prenom, tier.valeur, payeur.valeur, fligne);
                if (type != null)
                {
                    fentete.numero = type.DO_Piece;
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set CA_No = " + _caisse.CA_No + " , cbCA_No = " + _caisse.CA_No + " , CO_NoCaissier = " + _caissier.CO_No + " , cbCO_NoCaissier = " + _caissier.CO_No + ", DO_Valide=1 where DO_Piece like '" + type.DO_Piece + "'");
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set CA_No = " + _caisse.CA_No + " , cbCA_No = " + _caisse.CA_No + " , CO_No = " + _caissier.CO_No + " , cbCO_No = " + _caissier.CO_No + " where DO_Piece like '" + type.DO_Piece + "'");
                    foreach (DataGridViewRow obj in DataGridViewEnregistrement.Rows)
                    {

                        double valeur = Double.Parse(obj.Cells[1].FormattedValue.ToString());
                        IBODocumentReglement docuement = _sageObj.createReglement(regl_libelle, DateTime.Now, valeur, obj.Cells[0].FormattedValue.ToString(), type.DO_Piece, obj.Cells[3].FormattedValue.ToString(), _caisse.JO_Num);
                        freglement.Add(new Freglement()
                        {
                            Date = DateTime.Now.ToShortDateString(),
                            Montant = Double.Parse(obj.Cells[1].FormattedValue.ToString()),
                            Type = obj.Cells[0].FormattedValue.ToString()
                        });
                        if (docuement != null)
                        {
                            _context.Database.ExecuteSqlCommand("UPDATE F_CREGLEMENT set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + ", CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " where RG_Piece =" + docuement.RG_Piece);
                        }
                    }
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Domaine=3 , DO_Type=30, DO_DocType=30 , DO_Escompte=0 where DO_Piece like '" + type.DO_Piece + "'");
                    _context.Database.ExecuteSqlCommand("UPDATE F_REGLECH set DO_Domaine=3 , DO_Type=30 where DO_Piece like '" + type.DO_Piece + "'");
                    _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set DO_Domaine=3 , DO_Type=30, DO_DocType=30 , DL_Escompte=0 where DO_Piece like '" + type.DO_Piece + "'");
                }
            }
            else
            {

                _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Domaine=0 , DO_Type=6 , DO_DocType=6 , DO_Escompte=0, DO_Valide=1, DO_Attente=0  where DO_Piece like '" + refDoc + "'");
                foreach (DataGridViewRow obj in DataGridViewEnregistrement.Rows)
                {
                    double valeur = Double.Parse(obj.Cells[1].FormattedValue.ToString());
                    IBODocumentReglement docuement = _sageObj.createReglement(regl_libelle, DateTime.Now, valeur, obj.Cells[0].FormattedValue.ToString(), refDoc, obj.Cells[3].FormattedValue.ToString(), _caisse.JO_Num);
                    freglement.Add(new Freglement()
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        Montant = Double.Parse(obj.Cells[1].FormattedValue.ToString()),
                        Type = obj.Cells[0].FormattedValue.ToString()
                    });
                    _context.Database.ExecuteSqlCommand("UPDATE F_CREGLEMENT set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + ", CO_NoCaissier=" + _caissier.CO_No + " ,cbCO_NoCaissier=" + _caissier.CO_No + " where RG_Piece =" + docuement.RG_Piece);
                }
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set  DO_Domaine=3, DO_Type=30, DO_DocType=30 , DO_Escompte=0  where DO_Piece like '" + refDoc + "'");
                _context.Database.ExecuteSqlCommand("UPDATE F_REGLECH set DO_Domaine=3 , DO_Type=30 where DO_Piece like '" + refDoc + "'");
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set DO_Domaine=3 , DO_Type=30, DO_DocType=30 , DL_Escompte=0 where DO_Piece like '" + refDoc + "'");

            }
            this.Close();
            Reporting report = new Reporting(fentete, fligne, freglement, ComboBoxDeviseReste.SelectedItem.ToString());
            report.BringToFront();
            report.Show();
            report.Focus();
        }

        private void BouttonEnAttente_Click(object sender, EventArgs e)
        {
            Controle tier = (Controle)ComboBoxType.SelectedItem;
            Controle payeur = (Controle)ComboBoxCentrale.SelectedItem;
            List<Fligne> fligne = new List<Fligne>();
            List<Freglement> freglement = new List<Freglement>();
            Controle valeurs = (Controle)ComboboxSouche.SelectedItem;
            foreach (DataGridViewRow ligne in DataGridViewArticle.Rows)
            {
                string reduct = string.IsNullOrEmpty(ligne.Cells[6].Value.ToString()) ? "0%" : ligne.Cells[6].Value.ToString() + "%";
                fligne.Add(new Fligne()
                {
                    reference = ligne.Cells[0].FormattedValue.ToString(),
                    designation = ligne.Cells[1].FormattedValue.ToString(),
                    montant_ht = double.Parse(ligne.Cells[2].FormattedValue.ToString()),
                    prix_unitaire = double.Parse(ligne.Cells[3].FormattedValue.ToString()),
                    quantite = double.Parse(ligne.Cells[4].FormattedValue.ToString()),
                    remise = reduct
                });
            }
            var tiers = _context.F_COMPTEA.FirstOrDefault(u => u.CA_Num == ComboBoxAffaire.SelectedValue.ToString());
            var nAnalytique = _context.P_ANALYTIQUE.FirstOrDefault(u => u.cbMarq == tiers.N_Analytique);
            IBODocument3 type = _sageObj.createTicket(ComboBoxDeviseReste.SelectedItem.ToString(), valeurs.item, nAnalytique.A_Intitule, tiers.CA_Num, ComboBoxDepot.SelectedValue.ToString(), _caissier.CO_Nom, _caissier.CO_Prenom, tier.valeur, payeur.valeur, fligne);
            if (type != null)
            {
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + " , CO_NoCaissier=" + _caissier.CO_No + " , cbCO_NoCaissier=" + _caissier.CO_No + ", DO_Attente=1 where DO_Piece like '" + type.DO_Piece + "'");
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCLIGNE set CA_No=" + _caisse.CA_No + " , cbCA_No=" + _caisse.CA_No + " , CO_No=" + _caissier.CO_No + " , cbCO_No=" + _caissier.CO_No + " where DO_Piece like '" + type.DO_Piece + "'");
                _context.Database.ExecuteSqlCommand("UPDATE F_DOCENTETE set DO_Domaine=3 , DO_Type=30, DO_DocType=30 , DO_Escompte=0 where DO_Piece like '" + type.DO_Piece + "'");
                ButtonAnnuler_Click(sender, e);
                MessageBox.Show("Ticket Mis en Attente", "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BouttonRappelTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            ListAttenteForm attente = new ListAttenteForm();
            attente.Show();
        }

        private void ComboboxSouche_SelectedValueChanged(object sender, EventArgs e)
        {
            Controle valeur = (Controle)ComboboxSouche.SelectedItem;

            string count = _sageObj.get_current_piece(valeur.item);
            TextBoxLibelleEnregistrement.Text = "Règlt ticket " + count + " " + DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void ComboBoxType_SelectedValueChanged(object sender, EventArgs e)
        {
            Controle selected = (Controle)ComboBoxType.SelectedItem;
            if (selected != null)
            {
                F_COMPTET valeur = _context.F_COMPTET.FirstOrDefault(f => f.CT_Num == selected.valeur);
                ComboBoxAffaire.SelectedValue = valeur.CA_Num;
            }
        }


        // ========================================= ILAINA ARY VE ITO ZAVATRA ITO =========================================
        //private void DataGridViewArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        changedIndex = e.RowIndex;
        //        string reference = DataGridViewArticle.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        //        var codeFamilleBD = _context.F_ARTICLE
        //            .FirstOrDefault(a => a.AR_Ref == reference);
        //        var UniteVente = _context.P_UNITE
        //            .Where(unite => unite.cbIndice == codeFamilleBD.AR_UniteVen)
        //            .Select(unite => new
        //            {
        //                UniteIntitule = unite.U_Intitule
        //            }).FirstOrDefault();


        //        decimal tauxPriseEnCompte = TauxPriseEnCompte(codeFamilleBD.AR_Ref);
        //        decimal puHT = (decimal)codeFamilleBD.AR_PrixVen;
        //        decimal puTTC;
        //        var artclientDb = _context.F_ARTCLIENT.FirstOrDefault(a => a.AR_Ref == codeFamilleBD.AR_Ref && a.AC_Categorie == 3);
        //        if (artclientDb.AC_PrixVen != 0.00m)
        //        {
        //            puTTC = (decimal)artclientDb.AC_PrixVen;
        //            puHT = puTTC / (1 + tauxPriseEnCompte / 100);
        //        }
        //        else
        //        {
        //            puTTC = puHT + puHT * tauxPriseEnCompte / 100;
        //        }
        //        //AjouterArticleDesigne(codeFamilleBD.AR_Ref, codeFamilleBD.AR_Design, 1, puHT, puTTC, UniteVente.UniteIntitule);
        //    }
        //}
        // ========================================= FIN ILAINA ARY VE ITO ZAVATRA ITO =========================================

        // ============================================ EVENEMENTS ============================================
        // ====================================================================================================

    }
}

