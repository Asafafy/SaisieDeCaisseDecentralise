using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.DTO.DetailsArticle;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace SoftCaisse.Forms.Article
{
    public partial class DetailsArticle : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;
        private string _referenceArt;
        private string _designArt;
        public F_ARTICLE _selectedArt;

        // =========================================================== FONCTIONS POUR CONSTRUCTEUR =========================================================== */
        static string ConserverChiffresApresVirgule(decimal? valeur)
        {
            string valeurString = valeur?.ToString("G29");   // "G29" permet de conserver jusqu'à 29 chiffres significatifs
            return valeurString.TrimEnd('0').TrimEnd('.');  // Supprimer les zéros inutiles après la virgule
        }
        private void ChargerImage(string nomFichier)
        {
            try
            {
                Image image = Image.FromFile("E:\\Softwell\\SCDJNM\\SoftCaisse" + nomFichier);
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                if (nomFichier != "" && nomFichier != null)
                {
                    MessageBox.Show($"Erreur lors du chargement de l'image : {ex.Message}");
                }
            }
        }





        /* ==================================================================== DÉBUT CONSTRUCTEUR ==================================================================== */
        /* ============================================================================================================================================================ */
        public DetailsArticle(string referenceArt, string designArt)
        {
            _context = new AppDbContext();
            InitializeComponent();
            F_ARTICLERepository fArtilceRepository = new F_ARTICLERepository(_context);
            _referenceArt = referenceArt;
            _designArt = designArt;
            _selectedArt = _context.F_ARTICLE.Where(art => art.AR_Ref == _referenceArt && art.AR_Design == _designArt).FirstOrDefault();

            // =========================================================== NAVIGATION ENTRE TAB PAGES =========================================================== */
            //TabControl du "Champs libres" Tab
            btnInfosLibres.Click += (sender, e) => SelectTabChampsLibres(0, btnInfosLibres);
            btnChampsStatistiques.Click += (sender, e) => SelectTabChampsLibres(1, btnChampsStatistiques);
            btnChampsAttaches.Click += (sender, e) => SelectTabChampsLibres(2, btnChampsAttaches);
            btnPhoto.Click += (sender, e) => SelectTabChampsLibres(3, btnPhoto);
            SelectTabChampsLibres(0, btnInfosLibres);

            //TabControl du "Paramètres" Tab
            btnOptTraitement.Click += (sender, e) => SelectTabParametres(0, btnOptTraitement);
            btnLogistique.Click += (sender, e) => SelectTabParametres(1, btnLogistique);
            btnDepot.Click += (sender, e) => SelectTabParametres(2, btnDepot);
            btnComptabilite.Click += (sender, e) => SelectTabParametres(3, btnComptabilite);
            btnGestProd.Click += (sender, e) => SelectTabParametres(4, btnGestProd);
            SelectTabParametres(0, btnOptTraitement);


            // =========================================================== DÉBUT TAB PAGES "IDENTIFICATION" =========================================================== */
            textBox1.Text = _selectedArt.AR_Ref;
            textBox1.Enabled = false;
            textBox2.Text = _selectedArt.AR_Design;
            textBox3.Text = ConserverChiffresApresVirgule(_selectedArt.AR_PrixAch);
            textBox5.Text = ConserverChiffresApresVirgule(_selectedArt.AR_PUNet) == "0" ? ConserverChiffresApresVirgule(_selectedArt.AR_PUNet) : null;
            textBox6.Text = ConserverChiffresApresVirgule(_selectedArt.AR_Coef);
            textBox9.Text = ConserverChiffresApresVirgule(_selectedArt.AR_PrixVen);
            textBox8.Text = ConserverChiffresApresVirgule(_selectedArt.AR_CoutStd);

            var listeFamilles = _context.F_FAMILLE.Where(famille => famille.CL_No1 != 0)
                .Select(u => new Controle() { item = u.FA_CodeFamille })
                .ToList();
            // Trouver l'élément correspondant à la famille de cette article séléctionné dans la liste des familles
            var selectedFamille = listeFamilles.FirstOrDefault(famille => famille.item == _selectedArt.FA_CodeFamille);
            // Obtenir l'index de la famille
            int selectedIndexFamille = listeFamilles.IndexOf(selectedFamille);
            comboBox3.DataSource = listeFamilles;
            comboBox3.DisplayMember = "item";
            comboBox3.SelectedIndex = selectedIndexFamille;

            List<string> listeTypes = new List<string> { "Standard", "Gamme", "Ressource unitaire", "Ressource multiple" };
            comboBox7.DataSource = listeTypes;
            comboBox7.DisplayMember = "Value";
            comboBox7.SelectedIndex = _selectedArt.AR_Type.Value;

            List<string> listeSuiviStock = new List<string> { "Aucun", "Sérialisé", "CMUP", "FIFO", "LIFO", "Par lot" };
            comboBox1.DataSource = listeSuiviStock;
            comboBox1.DisplayMember = "Value";
            comboBox1.SelectedIndex = _selectedArt.AR_SuiviStock.Value;

            List<string> listeUniteDeVente = new List<string> { "Pièce", "Douzaine", "Ecrin de 6", "Unité", "Heure", "Jour", "Demi-journée", "Kms" };
            comboBoxUniteDeVente.DataSource = listeUniteDeVente;
            comboBoxUniteDeVente.DisplayMember = "Value";
            comboBoxUniteDeVente.SelectedIndex = _selectedArt.AR_UniteVen.Value - 1;

            List<string> listeUnitePrixDeVente = new List<string> { "PV HT", "PV TTC" };
            cmbBxUnitePrixDeVente.DataSource = listeUnitePrixDeVente;
            cmbBxUnitePrixDeVente.DisplayMember = "Value";
            cmbBxUnitePrixDeVente.SelectedIndex = _selectedArt.AR_PrixTTC.Value == 0 ? 0 : 1;

            List<string> listeNomeclature = new List<string> { "Aucune", "Fabrication", "Commerciale/composé", "Commerciale/composant", "Article lié" };
            comboBox4.DataSource = listeNomeclature;
            comboBox4.DisplayMember = "Value";
            comboBox4.SelectedIndex = _selectedArt.AR_Nomencl.Value;

            List<string> listeConditionnement = new List<string> { "Aucun", "Par Ecrin" };
            comboBox2.DataSource = listeConditionnement;
            comboBox2.DisplayMember = "Value";
            comboBox2.SelectedIndex = _selectedArt.AR_Condition.Value;

            // DÉBUT SOUS-TAB "CATÉGORIES TARIFAIRES"
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Catégorie"));
            _bindingSource.Columns.Add(new DataColumn("Coefficient"));
            _bindingSource.Columns.Add(new DataColumn("Prix de vente"));
            _bindingSource.Columns.Add(new DataColumn("Remise"));
            var catTarifaires = _context.F_ARTCLIENT.Where(cat => cat.AR_Ref == _selectedArt.AR_Ref && cat.AC_Categorie != 0)
                .Select(cat => new CategoriesTarifaires { AC_Categorie = cat.AC_Categorie, AC_Coef = cat.AC_Coef, AC_PrixVen = cat.AC_PrixVen, AC_Remise = cat.AC_Remise, AC_PrixTTC = cat.AC_PrixTTC })
                .ToList();
            if (catTarifaires.Count < 3)
            {
                bool contains1 = new[] { 1 }.All(val => catTarifaires.Any(cat => cat.AC_Categorie == val));
                bool contains2 = new[] { 2 }.All(val => catTarifaires.Any(cat => cat.AC_Categorie == val));
                bool contains3 = new[] { 3 }.All(val => catTarifaires.Any(cat => cat.AC_Categorie == val));
                if (!contains1 && !contains2 && !contains3)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                if (contains1 && !contains2 && !contains3)
                {
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains2 && !contains1 && !contains3)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains3 && !contains1 && !contains2)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains1 && contains2 && !contains3)
                {
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains1 && contains3 && !contains2)
                {
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains2 & contains3 && !contains1)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
            }
            catTarifaires.OrderBy(cat => cat.AC_Categorie);
            List<string> listeACCategorie = new List<string> { "Grossistes", "Détaillants", "Clients comptoir" };
            foreach (var catTarif in catTarifaires)
            {
                var coef = "";
                var prixVente = "";
                if (catTarif.AC_Coef != 0)
                {
                    coef = ConserverChiffresApresVirgule(catTarif.AC_Coef);
                }
                else
                {
                    coef = ConserverChiffresApresVirgule(_selectedArt.AR_Coef);
                }
                if (catTarif.AC_PrixVen != 0)
                {
                    prixVente = ConserverChiffresApresVirgule(catTarif.AC_PrixVen) + (catTarif.AC_PrixTTC == 0 ? " HT" : " TTC");
                }
                else
                {
                    prixVente = ConserverChiffresApresVirgule(_selectedArt.AR_PrixVen) + (_selectedArt.AR_PrixTTC == 0 ? " HT" : " TTC");
                }
                _bindingSource.Rows.Add(listeACCategorie[(int)catTarif.AC_Categorie - 1], coef, prixVente, ConserverChiffresApresVirgule(catTarif.AC_Remise));
            }
            dataGridView1.DataSource = _bindingSource;
            // FIN SOUS-TAB "CATÉGORIES TARIFAIRES"

            // DÉBUT SOUS-TAB "TARIFS CLIENTS"
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Client"));
            _bindingSource.Columns.Add(new DataColumn("Réf. Client"));
            _bindingSource.Columns.Add(new DataColumn("Coefficient"));
            _bindingSource.Columns.Add(new DataColumn("Prix de vente"));
            _bindingSource.Columns.Add(new DataColumn("Remise"));
            var tarifsClients = _context.F_ARTCLIENT.Where(cat => cat.AR_Ref == _selectedArt.AR_Ref && cat.CT_Num != null)
                .Select(cat => new TarifsClients { CT_Num = cat.CT_Num, AC_RefClient = cat.AC_RefClient, AC_Coef = cat.AC_Coef, AC_PrixVen = cat.AC_PrixVen, AC_Remise = cat.AC_Remise })
                .OrderBy(cat => cat.CT_Num)
                .ToList();
            foreach (var catTarif in tarifsClients)
            {
                _bindingSource.Rows.Add(catTarif.CT_Num, catTarif.AC_RefClient, catTarif.AC_Coef, catTarif.AC_PrixVen, catTarif.AC_Remise);
            }
            dataGridView2.DataSource = _bindingSource;
            // =========================================================== FIN TAB PAGES "IDENTIFICATION" =========================================================== */


            // =========================================================== DÉBUT TAB PAGES "CONDITIONNEMENT" =========================================================== */
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Enuméré"));
            _bindingSource.Columns.Add(new DataColumn("Référence"));
            _bindingSource.Columns.Add(new DataColumn("Code barres"));
            _bindingSource.Columns.Add(new DataColumn("Quantité"));
            var listeConditionnements = _context.F_CONDITION.Where(cond => cond.AR_Ref == _selectedArt.AR_Ref)
                .Select(cond => new Conditionnement { EC_Enumere = cond.EC_Enumere, AR_Ref = cond.AR_Ref, CO_CodeBarre = cond.CO_CodeBarre, EC_Quantite = cond.EC_Quantite })
                .OrderBy(cond => cond.EC_Enumere)
                .ToList();
            foreach (var cond in listeConditionnements)
            {
                _bindingSource.Rows.Add(cond.EC_Enumere, cond.AR_Ref, cond.CO_CodeBarre, ConserverChiffresApresVirgule(cond.EC_Quantite));
            }
            dataGridView3.DataSource = _bindingSource;
            // =========================================================== FIN TAB PAGES "CONDITIONNEMENT" =========================================================== */


            // =========================================================== DÉBUT TAB PAGES "GAMME" =========================================================== */
            var listeGamme1 = _context.F_ARTGAMME.Where(artEnum => artEnum.AR_Ref == _selectedArt.AR_Ref && artEnum.AG_Type == 0)
                .Select(gammes => gammes.EG_Enumere)
                .ToList();
            listeGamme1.Insert(0, "Tous les énumérés");
            var listeGamme2 = _context.F_ARTGAMME.Where(artEnum => artEnum.AR_Ref == _selectedArt.AR_Ref && artEnum.AG_Type == 1)
                .Select(gammes => gammes.EG_Enumere)
                .ToList();
            listeGamme2.Insert(0, "Tous les énumérés");
            if (listeGamme1.Count < 2)
            {
                comboBox18.DataSource = new List<string> { "Aucun" };
                comboBox19.DataSource = new List<string> { "Aucun" };
            }
            else
            {
                var enmGmm1 = listeGamme1[1];
                var gamme1 = _context.F_ENUMGAMME.Where(artEnum => artEnum.EG_Enumere == enmGmm1).FirstOrDefault();
                var labelGamme1 = _context.P_GAMME.Where(gamme => gamme.cbIndice == gamme1.EG_Champ).FirstOrDefault();
                label15.Text = labelGamme1.G_Intitule;
                comboBox18.DataSource = listeGamme1;
                if (listeGamme2.Count < 2)
                {
                    comboBox19.DataSource = new List<string> { "Aucun" };
                    comboBox19.SelectedIndex = 0;
                    _bindingSource = new DataTable();
                    _bindingSource.Columns.Add(new DataColumn(labelGamme1.G_Intitule));
                    _bindingSource.Columns.Add(new DataColumn("Référence"));
                    _bindingSource.Columns.Add(new DataColumn("Code Barres"));
                    _bindingSource.Columns.Add(new DataColumn("Prix d'achat"));
                    _bindingSource.Columns.Add(new DataColumn("Mise en sommeil"));
                    var listeArtEnums = _context.F_ARTENUMREF
                        .Join(_context.F_ARTGAMME, post1 => post1.AG_No1, meta1 => meta1.AG_No, (post1, meta1) => new { Post1 = post1, Meta1 = meta1 })
                        .Where(artEnum => artEnum.Post1.AR_Ref == _selectedArt.AR_Ref)
                        .Select(artEnum => new GammeDataGridView
                        {
                            G_Intitule1 = artEnum.Meta1.EG_Enumere,
                            AR_Ref = artEnum.Post1.AR_Ref,
                            AE_CodeBarre = artEnum.Post1.AE_CodeBarre,
                            AE_PrixAch = artEnum.Post1.AE_PrixAch,
                            AE_Sommeil = artEnum.Post1.AE_Sommeil
                        })
                        .OrderBy(artEnum => artEnum.G_Intitule1)
                        .ToList();
                    foreach (var artEnum in listeArtEnums)
                    {
                        _bindingSource.Rows.Add(artEnum.G_Intitule1, artEnum.AR_Ref, artEnum.AE_CodeBarre, artEnum.AE_PrixAch, artEnum.AE_Sommeil);
                    }
                    dataGridView5.DataSource = _bindingSource;
                }
                else
                {
                    var enmGmm2 = listeGamme2[1];
                    var gamme2 = _context.F_ENUMGAMME.Where(artEnum => artEnum.EG_Enumere == enmGmm2).FirstOrDefault();
                    var labelGamme2 = _context.P_GAMME.Where(gamme => gamme.cbIndice == gamme2.EG_Champ).FirstOrDefault();
                    label16.Text = labelGamme2.G_Intitule;
                    comboBox19.DataSource = listeGamme2;
                    _bindingSource = new DataTable();
                    _bindingSource.Columns.Add(new DataColumn(labelGamme1.G_Intitule));
                    _bindingSource.Columns.Add(new DataColumn(labelGamme2.G_Intitule));
                    _bindingSource.Columns.Add(new DataColumn("Référence"));
                    _bindingSource.Columns.Add(new DataColumn("Code Barres"));
                    _bindingSource.Columns.Add(new DataColumn("Prix d'achat"));
                    _bindingSource.Columns.Add(new DataColumn("Mise en sommeil"));
                    var listeArtEnums = _context.F_ARTENUMREF
                        .Join(_context.F_ARTGAMME, post1 => post1.AG_No1, meta1 => meta1.AG_No, (post1, meta1) => new { Post1 = post1, Meta1 = meta1 })
                        .Join(_context.F_ARTGAMME, post2 => post2.Post1.AG_No2, meta2 => meta2.AG_No, (post2, meta2) => new { Post2 = post2, Meta2 = meta2 })
                        .Where(artEnum => artEnum.Post2.Post1.AR_Ref == _selectedArt.AR_Ref)
                        .Select(artEnum => new GammeDataGridView
                        {
                            G_Intitule1 = artEnum.Post2.Meta1.EG_Enumere,
                            G_Intitule2 = artEnum.Meta2.EG_Enumere,
                            AR_Ref = artEnum.Post2.Post1.AR_Ref,
                            AE_CodeBarre = artEnum.Post2.Post1.AE_CodeBarre,
                            AE_PrixAch = artEnum.Post2.Post1.AE_PrixAch,
                            AE_Sommeil = artEnum.Post2.Post1.AE_Sommeil
                        })
                        .OrderBy(artEnum => artEnum.G_Intitule1)
                        .ToList();
                    foreach (var artEnum in listeArtEnums)
                    {
                        _bindingSource.Rows.Add(artEnum.G_Intitule1, artEnum.G_Intitule2, artEnum.AR_Ref, artEnum.AE_CodeBarre, artEnum.AE_PrixAch, artEnum.AE_Sommeil);
                    }
                    dataGridView5.DataSource = _bindingSource;
                }
            }

            // =========================================================== FIN TAB PAGES "GAMME" =========================================================== */


            // =========================================================== DÉBUT TAB PAGES "DESCIRPTIF" =========================================================== */
            var listeCataloguesNo1 = _context.F_CATALOGUE.Where(u => u.CL_Niveau == 0)
                .Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No.ToString() })
                .ToList();
            var selectedCatNo1 = listeCataloguesNo1.FirstOrDefault(catal => catal.valeur == _selectedArt?.CL_No1.ToString());
            int selectedCatNo1Index = listeCataloguesNo1.IndexOf(selectedCatNo1);
            comboBoxCatal1.DataSource = listeCataloguesNo1;
            comboBoxCatal1.DisplayMember = "item";
            comboBoxCatal1.ValueMember = "valeur";
            comboBoxCatal1.SelectedIndex = selectedCatNo1Index;
            var listeCataloguesNo2 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 1 && catal.CL_NoParent.ToString() == selectedCatNo1.valeur)
                .Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No.ToString() })
                .ToList();
            var selectedCatNo2 = listeCataloguesNo2.FirstOrDefault(catal => catal.valeur == _selectedArt?.CL_No2.ToString());
            if (selectedCatNo2 == null)
            {
                comboBoxCatal2.Visible = false;
                comboBoxCatal3.Visible = false;
                comboBoxCatal4.Visible = false;
            }
            else
            {
                int selectedCatNo2Index = listeCataloguesNo2.IndexOf(selectedCatNo2);
                comboBoxCatal2.DataSource = listeCataloguesNo2;
                comboBoxCatal2.DisplayMember = "item";
                comboBoxCatal2.ValueMember = "valeur";
                comboBoxCatal2.SelectedIndex = selectedCatNo2Index;
                var listeCataloguesNo3 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 2 && catal.CL_NoParent.ToString() == selectedCatNo2.valeur)
                    .Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" })
                    .ToList();
                var selectedCatNo3 = listeCataloguesNo3.FirstOrDefault(catal => catal.valeur == _selectedArt?.CL_No3.ToString());
                if (selectedCatNo3 == null)
                {
                    comboBoxCatal3.Visible = false;
                    comboBoxCatal4.Visible = false;
                }
                else
                {
                    int selectedCatNo3Index = listeCataloguesNo3.IndexOf(selectedCatNo3);
                    comboBoxCatal3.DataSource = listeCataloguesNo3;
                    comboBoxCatal3.DisplayMember = "item";
                    comboBoxCatal3.ValueMember = "valeur";
                    comboBoxCatal3.SelectedIndex = selectedCatNo3Index;
                    var listeCataloguesNo4 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 3 && catal.CL_NoParent.ToString() == selectedCatNo3.valeur)
                        .Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" })
                        .ToList();
                    var selectedCatNo4 = listeCataloguesNo4.FirstOrDefault(catal => catal.valeur == _selectedArt?.CL_No4.ToString());
                    if (selectedCatNo4 == null)
                    {
                        comboBoxCatal4.Visible = false;
                    }
                    else
                    {
                        int selectedCatNo4Index = listeCataloguesNo4.IndexOf(selectedCatNo4);
                        comboBoxCatal4.DataSource = listeCataloguesNo4;
                        comboBoxCatal4.DisplayMember = "item";
                        comboBoxCatal4.ValueMember = "valeur";
                        comboBoxCatal4.SelectedIndex = selectedCatNo4Index;
                    }
                }
            }

            textBoxLangue1.Text = _selectedArt.AR_Langue1;
            textBoxLangue2.Text = _selectedArt.AR_Langue2;
            textBoxCodeFiscal.Text = _selectedArt.AR_CodeFiscal;
            textBoxCodeEDI.Text = _selectedArt.AR_EdiCode;
            textBoxRaccourci.Text = _selectedArt.AR_Raccourci;
            var listePays = _context.F_PAYS.Select(u => new Controle() { item = u.PA_Intitule, valeur = u.PA_No + "" }).ToList();
            var selectedPays = listePays.FirstOrDefault(pays => pays.item == _selectedArt?.AR_Pays.ToString());
            int selectedPaysIndex = listePays.IndexOf(selectedPays);
            comboBoxPaysOrigine.DataSource = listePays;
            comboBoxPaysOrigine.DisplayMember = "item";
            comboBoxPaysOrigine.ValueMember = "valeur";
            comboBoxPaysOrigine.SelectedIndex = selectedPaysIndex;

            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Intitulé"));
            _bindingSource.Columns.Add(new DataColumn("Date début application"));
            _bindingSource.Columns.Add(new DataColumn("Date fin application"));
            var listeGlossaire = _context.F_GLOSSAIRE
                .Join(_context.F_ARTGLOSS, post => post.GL_No, meta => meta.GL_No, (post, meta) => new { Post = post, Meta = meta })
                .Where(glossaire => glossaire.Meta.AR_Ref == _selectedArt.AR_Ref)
                .Select(u => new GlossaireDetailsArticle() { GL_Intitule = u.Post.GL_Intitule, GL_PeriodeDeb = u.Post.GL_PeriodeDeb, GL_PeriodeFin = u.Post.GL_PeriodeFin })
                .OrderBy(u => u.GL_Intitule)
                .ToList();
            foreach (var glossaire in listeGlossaire)
            {
                _bindingSource.Rows.Add(glossaire.GL_Intitule, glossaire.GL_PeriodeDeb, glossaire.GL_PeriodeFin);
            }
            DataGridViewGloss.DataSource = _bindingSource;
            // =========================================================== FIN TAB PAGES "DESCIRPTIF" =========================================================== */


            // =========================================================== DÉBUT TAB PAGES "CHAMPS LIBRES" =========================================================== */
            // ================= Sous-Tab "infos libres" =================
            dateTimePicker2.Value = _selectedArt.C1ère_commercialisation.Value;
            textBox11.Text = _selectedArt.Marque_commerciale;
            textBox12.Text = ConserverChiffresApresVirgule(_selectedArt.Objectif___Qtés_vendues);
            textBox13.Text = ConserverChiffresApresVirgule(_selectedArt.Pourcentage_teneur_en_or) + "%";
            // ================= Sous-Tab "champs statistiques" =================
            List<string> listeCollection = new List<string> { "Automne/Hiver", "Printemps/été" };
            comboBox5.DataSource = listeCollection;
            comboBox5.DisplayMember = "Value";
            comboBox5.SelectedIndex = listeCollection.IndexOf(_selectedArt.AR_Stat01);
            List<string> listeStyle = new List<string> { "Classique", "Fantaisie", "Moderne" };
            comboBox5.DataSource = listeStyle;
            comboBox5.DisplayMember = "Value";
            comboBox5.SelectedIndex = listeStyle.IndexOf(_selectedArt.AR_Stat02);
            // ================= Sous-Tab "documents attachés" =================
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Fichier"));
            _bindingSource.Columns.Add(new DataColumn("Intitulé"));
            var listeDocsAttaches = _context.F_ARTICLEMEDIA.Where(docAtt => docAtt.AR_Ref == _selectedArt.AR_Ref)
                .Select(docAtt => new DocsAttaches { ME_Fichier = docAtt.ME_Fichier, ME_Commentaire = docAtt.ME_Commentaire })
                .OrderBy(docAtt => docAtt.ME_Fichier)
                .ToList();
            foreach (var docAtt in listeDocsAttaches)
            {
                _bindingSource.Rows.Add(docAtt.ME_Fichier, docAtt.ME_Commentaire);
            }
            dataGridView4.DataSource = _bindingSource;
            // ================= Sous-Tab "photo" =================
            ChargerImage(_selectedArt.AR_Photo);


            // =========================================================== FIN TAB PAGES "CHAMPS LIBRES" =========================================================== */


            // =========================================================== DEBUT TAB PAGES "PARAMÈTRES" =========================================================== */
            // ================= Sous-Tab "Options de traitement" =================
            // Goupbox facturation
            chkBxFact2.Enabled = false;
            chkBxFact6.Enabled = false;
            if (_selectedArt.AR_Type != 0)
            {
                chkBxFact5.Enabled = false;
                if (_selectedArt.AR_Type != 1)
                {
                    chkBxFact4.Enabled = false;
                }
            }
            //TODO: Mbola tsy azo avy any anaty base ilay données

            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Intitulé"));
            _bindingSource.Columns.Add(new DataColumn("Domaine"));
            List<string> listeModèle = new List<string> { "Tous les domaines", "Ventes", "Achats", "Stocks", "Ventes comptoir", "Internes" };
            var listeModeleDEnregistrement = _context.F_ARTMODELE
                .Join(_context.F_MODELE, post => post.MO_No, meta => meta.MO_No, (post, meta) => new { Post = post, Meta = meta })
                .Where(modEnrg => modEnrg.Post.AR_Ref == _selectedArt.AR_Ref)
                .Select(u => new ModeleDEnregistrement() { MO_Intitule = u.Meta.MO_Intitule, AM_Domaine = u.Post.AM_Domaine })
                .OrderBy(u => u.MO_Intitule)
                .ToList();
            foreach (var modEnreg in listeModeleDEnregistrement)
            {
                _bindingSource.Rows.Add(modEnreg.MO_Intitule, listeModèle[(int)modEnreg.AM_Domaine]);
            }
            dataGridView6.DataSource = _bindingSource;
            // ================= Sous-Tab "Logistique" =================
            txtBxPdsNt.Text = ConserverChiffresApresVirgule(_selectedArt.AR_PoidsNet);
            txtBxCdBrr.Text = _selectedArt.AR_CodeBarre;
            txBxPdsBrut.Text = ConserverChiffresApresVirgule(_selectedArt.AR_PoidsBrut);
            textBox14.Text = _selectedArt.AR_Delai.ToString();
            textBox15.Text = _selectedArt.AR_DelaiFabrication.ToString();
            textBox16.Text = _selectedArt.AR_DelaiSecurite.ToString();
            textBox17.Text = _selectedArt.AR_Garantie.ToString();
            textBox18.Text = _selectedArt.AR_DelaiPeremption.ToString();
            checkBox4.Checked = _selectedArt.AR_SousTraitance == 0 ? false : true;
            List<string> listeUniteDePoids = new List<string> { "Tonne", "Quintal", "Kilogramme", "Gramme", "Milligramme" };
            comboBox8.DataSource = listeUniteDePoids;
            comboBox8.DisplayMember = "Value";
            comboBox8.SelectedIndex = (int)_selectedArt.AR_UnitePoids;
            comboBox9.DataSource = listeSuiviStock;
            comboBox9.DisplayMember = "Value";
            comboBox9.SelectedIndex = _selectedArt.AR_SuiviStock.Value;
            List<string> listeNiveauCriticite = new List<string> { "Mineur", "Majeur", "Critique" };
            comboBox10.DataSource = listeNiveauCriticite;
            comboBox10.DisplayMember = "Value";
            comboBox10.SelectedIndex = (int)_selectedArt.AR_Criticite;
            List<string> listeDesignArticle = _context.F_ARTICLE.Select(e => e.AR_Ref + " (" + e.AR_Design + ")").ToList();
            comboBox11.DataSource = listeDesignArticle;
            comboBox11.DisplayMember = "Value";
            comboBox8.SelectedIndex = listeDesignArticle.IndexOf(_selectedArt.AR_Substitut);
            //TODO: texBox Frais Fixes (Avy aiza ireo données ireo)

            // TODO: ================= Sous-Tab "Dépôt" =================
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Dépôt"));
            _bindingSource.Columns.Add(new DataColumn("Stock mini"));
            _bindingSource.Columns.Add(new DataColumn("Stock maxi"));
            _bindingSource.Columns.Add(new DataColumn("Emplacement principal"));
            _bindingSource.Columns.Add(new DataColumn("Emplacement contrôle"));
            var listeDepots = _context.F_ARTSTOCK
                .Join(_context.F_DEPOT, post => post.DE_No, meta => meta.DE_No, (post, meta) => new { Post = post, Meta = meta })
                .Where(modEnrg => modEnrg.Post.AR_Ref == _selectedArt.AR_Ref)
                .Select(u => new DepotParametres() { DE_Intitule = u.Meta.DE_Intitule, AS_QteMini = u.Post.AS_QteMini, AS_QteMaxi = u.Post.AS_QteMaxi, DP_NoPrincipal = u.Post.DP_NoPrincipal, DP_NoControle = u.Post.DP_NoControle })
                .OrderBy(u => u.DE_Intitule)
                .ToList();
            foreach (var depot in listeDepots)
            {
                var emplacementPrincipal = _context.F_DEPOTEMPL.Where(u => u.DP_No == depot.DP_NoPrincipal).Select(u => u.DP_Code).FirstOrDefault();
                var emplacementControle = _context.F_DEPOTEMPL.Where(u => u.DP_No == depot.DP_NoControle).Select(u => u.DP_Code).FirstOrDefault();
                _bindingSource.Rows.Add(depot.DE_Intitule, depot.AS_QteMini, depot.AS_QteMaxi, emplacementPrincipal == "0" ? "" : emplacementPrincipal, emplacementControle == "0" ? "" : emplacementControle);
            }
            dataGridView7.DataSource = _bindingSource;
            // ================= Sous-Tab "Comptabilité" =================
            textBox38.Text = _selectedArt.AR_NbColis.ToString();
            List<string> listeNature = new List<string> { "Composant", "Pièce détachée", "Produit fini", "Produit semi-fini", "Non-gérée" };
            comboBox16.DataSource = listeNature;
            comboBox16.DisplayMember = "Value";
            comboBox16.SelectedIndex = (int)_selectedArt.AR_Nature;
            List<string> listeTypeLancementProd = new List<string> { "Standard", "Spécifique" };
            comboBox13.DataSource = listeTypeLancementProd;
            comboBox13.DisplayMember = "Value";
            comboBox13.SelectedIndex = (int)_selectedArt.AR_TypeLancement;
            List<string> listeCycleDeVie = new List<string> { "Standard", "Spécifique" };
            comboBox13.DataSource = listeCycleDeVie;
            comboBox13.DisplayMember = "Value";
            comboBox13.SelectedIndex = (int)_selectedArt.AR_Cycle;
            checkBox5.Checked = _selectedArt.AR_Fictif == 0 ? false : true;
            // =========================================================== FIN TAB PAGES "PARAMÈTRES" =========================================================== */
        }
        /* ==================================================================== FIN CONSTRUCTEUR ==================================================================== */
        /* ========================================================================================================================================================== */



        /* =========================================================== DÉBUT DESIGN =========================================================== */
        /* ==================================================================================================================================== */
        // HOVER EFFECT TROIS BOUTONS DE NAVBAR
        private void btnNomenclature_MouseHover(object sender, System.EventArgs e)
        {
            btnNomenclature.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 234, 247);
        }
        private void btnInterroger_MouseHover(object sender, System.EventArgs e)
        {
            btnInterroger.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 234, 247);
        }
        private void btnTracabilite_MouseHover(object sender, System.EventArgs e)
        {
            btnTracabilite.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 234, 247);
        }

        // NAVIGATIONS ENTRE TABS VIA BOUTONS (TAB "CHAMPS LIBRES")
        private void SelectTabChampsLibres(int tabIndex, Button activeButton)
        {
            tabControl3.SelectedIndex = tabIndex;
            btnInfosLibres.BackColor = SystemColors.Control;
            btnChampsStatistiques.BackColor = SystemColors.Control;
            btnChampsAttaches.BackColor = SystemColors.Control;
            btnPhoto.BackColor = SystemColors.Control;
            activeButton.BackColor = Color.LightBlue;
        }

        // NAVIGATIONS ENTRE TABS VIA BOUTONS (TAB "PARAMETRES")
        private void SelectTabParametres(int tabIndex, Button activeButton)
        {
            tabControl4.SelectedIndex = tabIndex;
            btnOptTraitement.BackColor = SystemColors.Control;
            btnLogistique.BackColor = SystemColors.Control;
            btnDepot.BackColor = SystemColors.Control;
            btnComptabilite.BackColor = SystemColors.Control;
            btnGestProd.BackColor = SystemColors.Control;
            activeButton.BackColor = Color.LightBlue;
        }
        /* ================================================================================================================================== */
        /* =========================================================== FIN DESIGN =========================================================== */





        /* =========================================================== DÉBUT BACKEND =========================================================== */
        /* ===================================================================================================================================== */
        private void btnInterroger_Click(object sender, System.EventArgs e)
        {
            new InterrogationStockArticle(_referenceArt, _designArt, this).Show();
        }

        private void krptAjouterVisualiser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView4.SelectedRows[0];
                    string cheminFichier = selectedRow.Cells["Fichier"].Value.ToString();
                    System.Diagnostics.Process.Start("E:\\Softwell\\SCDJNM\\SoftCaisse" + cheminFichier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView4.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                    krptAjouterVisualiser_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\Softwell\\SCDJNM\\SoftCaisse" + _selectedArt.AR_Photo);
        }
        /* =================================================================================================================================== */
        /* =========================================================== FIN BACKEND =========================================================== */
    }
}
