using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
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

        // =========================================================== FONCTIONS POUR CONSTRUCTEUR =========================================================== */
        static string ConserverChiffresApresVirgule(decimal? valeur)
        {
            string valeurString = valeur?.ToString("G29");   // "G29" permet de conserver jusqu'à 29 chiffres significatifs
            return valeurString.TrimEnd('0').TrimEnd('.');  // Supprimer les zéros inutiles après la virgule
        }

        public DetailsArticle(string referenceArt, string designArt)
        {
            _context = new AppDbContext();
            InitializeComponent();
            FArtilceRepository fArtilceRepository = new FArtilceRepository(_context);
            _referenceArt = referenceArt;
            _designArt = designArt;
            var selectedArt = fArtilceRepository.GetByRefDes(_referenceArt, _designArt);

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
            textBox1.Text = selectedArt.AR_Ref;
            textBox1.Enabled = false;
            textBox2.Text = selectedArt.AR_Design;
            textBox3.Text = ConserverChiffresApresVirgule(selectedArt.AR_PrixAch);
            textBox5.Text = ConserverChiffresApresVirgule(selectedArt.AR_PUNet) == "0" ? ConserverChiffresApresVirgule(selectedArt.AR_PUNet) : null;
            textBox6.Text = ConserverChiffresApresVirgule(selectedArt.AR_Coef);
            textBox9.Text = ConserverChiffresApresVirgule(selectedArt.AR_PrixVen);
            textBox8.Text = ConserverChiffresApresVirgule(selectedArt.AR_CoutStd);

            var listeFamilles = _context.F_FAMILLE.Where(famille => famille.CL_No1 != 0).Select(u => new Controle() { item = u.FA_CodeFamille }).ToList();
            // Trouver l'élément correspondant à la famille de cette article séléctionné dans la liste des familles
            var selectedFamille = listeFamilles.FirstOrDefault(famille => famille.item == selectedArt.FA_CodeFamille);
            // Obtenir l'index de la famille
            int selectedIndexFamille = listeFamilles.IndexOf(selectedFamille);
            comboBox3.DataSource = listeFamilles;
            comboBox3.DisplayMember = "item";
            comboBox3.SelectedIndex = selectedIndexFamille;

            List<string> listeTypes = new List<string> { "Standard", "Gamme", "Ressource unitaire", "Ressource multiple" };
            comboBox7.DataSource = listeTypes;
            comboBox7.DisplayMember = "Value";
            comboBox7.SelectedIndex = selectedArt.AR_Type.Value;

            List<string> listeSuiviStock = new List<string> { "Aucun", "Sérialisé", "CMUP", "FIFO", "LIFO", "Par lot" };
            comboBox1.DataSource = listeSuiviStock;
            comboBox1.DisplayMember = "Value";
            comboBox1.SelectedIndex = selectedArt.AR_SuiviStock.Value;

            List<string> listeUniteDeVente = new List<string> { "Pièce", "Douzaine", "Ecrin de 6", "Unité", "Heure", "Jour", "Demi-journée", "Kms" };
            comboBoxUniteDeVente.DataSource = listeUniteDeVente;
            comboBoxUniteDeVente.DisplayMember = "Value";
            comboBoxUniteDeVente.SelectedIndex = selectedArt.AR_UniteVen.Value - 1;

            List<string> listeUnitePrixDeVente = new List<string> { "PV HT", "PV TTC" };
            cmbBxUnitePrixDeVente.DataSource = listeUnitePrixDeVente;
            cmbBxUnitePrixDeVente.DisplayMember = "Value";
            cmbBxUnitePrixDeVente.SelectedIndex = selectedArt.AR_PrixTTC.Value == 0 ? 0 : 1;

            List<string> listeNomeclature = new List<string> { "Aucune", "Fabrication", "Commerciale/composé", "Commerciale/composant", "Article lié" };
            comboBox4.DataSource = listeNomeclature;
            comboBox4.DisplayMember = "Value";
            comboBox4.SelectedIndex = selectedArt.AR_Nomencl.Value;

            List<string> listeConditionnement = new List<string> { "Aucun", "Par Ecrin" };
            comboBox2.DataSource = listeConditionnement;
            comboBox2.DisplayMember = "Value";
            comboBox2.SelectedIndex = selectedArt.AR_Condition.Value;

            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Catégorie"));
            _bindingSource.Columns.Add(new DataColumn("Coefficient"));
            _bindingSource.Columns.Add(new DataColumn("Prix de vente"));
            _bindingSource.Columns.Add(new DataColumn("Remise"));
            // TODO: Tsy haiko hoe taiza ireo données ireo.
            //foreach (var article in listeArticlesSousFamille)
            //{
            //    _bindingSource.Rows.Add(article.AR_Design, article.AR_Ref, article.FA_CodeFamille);
            //}
            dataGridView1.DataSource = _bindingSource;
            // =========================================================== FIN TAB PAGES "IDENTIFICATION" =========================================================== */


            // =========================================================== DÉBUT TAB PAGES "DESCIRPTIF" =========================================================== */
            //TODO: ETO IZAO: REHEFA MISELECTIONNE AVY EO AMIN'NY TOUS AN'NY CAT1 DIA MISY ERREUR
            //var listeCataloguesNo1 = _context.F_CATALOGUE.Where(u => u.CL_Niveau == 0).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
            //var selectedCatNo1 = listeCataloguesNo1.FirstOrDefault(catal => catal.valeur == selectedArt?.CL_No1.ToString());
            //int selectedCatNo1Index = listeCataloguesNo1.IndexOf(selectedCatNo1);
            //comboBoxCatal1.DataSource = listeCataloguesNo1;
            //comboBoxCatal1.DisplayMember = "item";
            //comboBoxCatal1.ValueMember = "valeur";
            //comboBoxCatal1.SelectedIndex = selectedCatNo1Index;

            //var listeCataloguesNo2 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 1 && catal.CL_NoParent.ToString() == selectedCatNo1.valeur).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
            //var selectedCatNo2 = listeCataloguesNo2.FirstOrDefault(catal => catal.valeur == selectedArt?.CL_No2.ToString());
            //if (listeCataloguesNo2.IndexOf(selectedCatNo2) == -1)
            //{
            //    comboBoxCatal2.Visible = false;
            //}
            //else
            //{
            //    int selectedCatNo2Index = listeCataloguesNo2.IndexOf(selectedCatNo2);
            //    comboBoxCatal2.DataSource = listeCataloguesNo2;
            //    comboBoxCatal2.DisplayMember = "item";
            //    comboBoxCatal2.ValueMember = "valeur";
            //    comboBoxCatal2.SelectedIndex = selectedCatNo2Index;
            //}

            //var listeCataloguesNo3 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 2 && catal.CL_NoParent.ToString() == selectedCatNo2.valeur).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
            //var selectedCatNo3 = listeCataloguesNo3.FirstOrDefault(catal => catal.valeur == selectedArt?.CL_No3.ToString());
            //if (listeCataloguesNo3.IndexOf(selectedCatNo3) == -1)
            //{
            //    comboBoxCatal3.Visible = false;
            //}
            //else
            //{
            //    int selectedCatNo3Index = listeCataloguesNo3.IndexOf(selectedCatNo3);
            //    comboBoxCatal3.DataSource = listeCataloguesNo3;
            //    comboBoxCatal3.DisplayMember = "item";
            //    comboBoxCatal3.ValueMember = "valeur";
            //    comboBoxCatal3.SelectedIndex = selectedCatNo3Index;
            //}

            //var listeCataloguesNo4 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 3 && catal.CL_NoParent.ToString() == selectedCatNo3.valeur).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
            //var selectedCatNo4 = listeCataloguesNo4.FirstOrDefault(catal => catal.valeur == selectedArt?.CL_No4.ToString());
            //if (listeCataloguesNo4.IndexOf(selectedCatNo4) == -1)
            //{
            //    comboBoxCatal4.Visible = false;
            //}
            //else
            //{
            //    int selectedCatNo4Index = listeCataloguesNo4.IndexOf(selectedCatNo4);
            //    comboBoxCatal4.DataSource = listeCataloguesNo4;
            //    comboBoxCatal4.DisplayMember = "item";
            //    comboBoxCatal4.ValueMember = "valeur";
            //    comboBoxCatal4.SelectedIndex = selectedCatNo4Index;
            //}


            // =========================================================== FIN TAB PAGES "DESCIRPTIF" =========================================================== */



        }


        /* =========================================================== DÉBUT DESIGN =========================================================== */
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
        /* =========================================================== FIN DESIGN =========================================================== */





        /* =========================================================== DÉBUT BACKEND =========================================================== */

        /* =========================================================== DÉBUT BACKEND =========================================================== */
    }
}
