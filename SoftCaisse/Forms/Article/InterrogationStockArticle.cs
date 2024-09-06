using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace SoftCaisse.Forms.Article
{
    public partial class InterrogationStockArticle : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;
        private string _referenceArt;
        private string _designArt;
        private DetailsArticle _detailsArticle;
        private F_ARTICLE _articleSelect;
        private List<string> _listeDepotZones;
        private bool _haveArtGamme1;
        private bool _haveArtGamme2;


        // ======================================== DEBUT CONSTRUCTEUR ========================================
        public InterrogationStockArticle(string referenceArt, string designArt, DetailsArticle detailsArticle)
        {
            _referenceArt = referenceArt;
            _designArt = designArt;
            _context = new AppDbContext();
            InitializeComponent();

            _detailsArticle = detailsArticle;
            var listeARRef = _context.F_ARTICLE.Select(a => new { item = a.AR_Ref + " - " + a.AR_Design }).ToList();
            var selectedArtRef = listeARRef.FirstOrDefault(a => a.item == _referenceArt + " - " + _designArt);
            int selectedIndexFamille = listeARRef.IndexOf(selectedArtRef);
            _articleSelect = _context.F_ARTICLE.Where(art => art.AR_Ref == _referenceArt && art.AR_Design == _designArt).FirstOrDefault();
            comboBox2.DataSource = listeARRef;
            comboBox2.DisplayMember = "item";
            comboBox2.SelectedIndex = selectedIndexFamille;
            _listeDepotZones = new List<string> { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            var listeDepots = _context.F_DEPOT.Select(u => new Controle { item = u.DE_Intitule, valeur = u.DE_No.ToString() }).ToList();
            listeDepots.Insert(0, new Controle() { item = "Tous les dépôts", valeur = "0" });
            comboBoxDepot.DataSource = listeDepots;
            comboBoxDepot.DisplayMember = "item";
            comboBoxDepot.ValueMember = "valeur";
            comboBoxDepot.SelectedIndex = 0;

            List<string> listeEmplacements = new List<string> { "Aucun emplacement", "Tous les emplacements", "Emplacements mouvementés" };
            comboBoxEmplacement.DataSource = listeEmplacements;
            comboBoxEmplacement.DisplayMember = "Value";
            comboBoxEmplacement.SelectedIndex = 0;

            _haveArtGamme1 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 0).Count() < 1;
            _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 1).Count() < 1;

            afficherDepot(_referenceArt);
        }
        // ======================================== FIN CONSTRUCTEUR ========================================


        // ======================================== DEBUT FONCTIONS ========================================
        private void afficherDepot(string referenceArticle)
        {
            Controle selectedDepot = (Controle)comboBoxDepot.SelectedItem;
            List<F_ARTSTOCK> listeStockArt;
            if (selectedDepot.valeur == "0")
            {
                listeStockArt = _context.F_ARTSTOCK.Where(art => art.AR_Ref == referenceArticle).ToList();
            }
            else
            {
                listeStockArt = _context.F_ARTSTOCK.Where(art => art.AR_Ref == referenceArticle && art.DE_No.ToString() == selectedDepot.valeur).ToList();
            }
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Intitulé dépôt"));
            _bindingSource.Columns.Add(new DataColumn("Code emplacement"));
            _bindingSource.Columns.Add(new DataColumn("Intitulé emplacement"));
            _bindingSource.Columns.Add(new DataColumn("Zone emplacement"));
            _bindingSource.Columns.Add(new DataColumn("Unité de vente"));
            //_bindingSource.Columns.Add(new DataColumn("Complément série/lot"));
            //_bindingSource.Columns.Add(new DataColumn("Date fabrication"));
            //_bindingSource.Columns.Add(new DataColumn("Date péremption"));
            _bindingSource.Columns.Add(new DataColumn("Stock réel"));
            _bindingSource.Columns.Add(new DataColumn("Disponible"));
            _bindingSource.Columns.Add(new DataColumn("Commandé"));
            _bindingSource.Columns.Add(new DataColumn("Réservé"));
            _bindingSource.Columns.Add(new DataColumn("Stock à terme"));
            _bindingSource.Columns.Add(new DataColumn("CMUP"));
            _bindingSource.Columns.Add(new DataColumn("Valeur du stock"));
            _bindingSource.Columns.Add(new DataColumn("Qté Mini"));
            _bindingSource.Columns.Add(new DataColumn("Qté Maxi"));
            //_bindingSource.Columns.Add(new DataColumn("Dernier P.A."));
            _bindingSource.Columns.Add(new DataColumn("Préparé"));
            foreach (var stock in listeStockArt)
            {
                var intituleDepot = selectedDepot.item;
                EmplacementsInterrStock emplacement;
                if (comboBoxEmplacement.SelectedIndex == 0)
                {
                    emplacement = new EmplacementsInterrStock { DP_Code = null, DP_Intitule = null, DP_Zone = null };
                }
                else if (comboBoxEmplacement.SelectedIndex == 1)
                {
                    emplacement = _context.F_DEPOTEMPL.Where(dpt => dpt.DP_No == (stock.DP_NoPrincipal == 0 ? 1 : stock.DP_NoPrincipal)).Select(art => new EmplacementsInterrStock { DP_Code = art.DP_Code, DP_Intitule = art.DP_Intitule, DP_Zone = art.DP_Zone }).FirstOrDefault();
                }
                else
                {

                }

                var numUniteVente = _context.F_ARTICLE.Where(art => art.AR_Ref == _referenceArt).Select(art => art.AR_UniteVen).FirstOrDefault();
                var uniteVente = _context.P_UNITE.Where(unit => unit.cbIndice == numUniteVente).Select(art => art.U_Intitule).FirstOrDefault();
                var qteSto = stock.AS_QteSto?.ToString("F2");
                var qteCom = stock.AS_QteCom?.ToString("F2");
                var qteRes = stock.AS_QteRes?.ToString("F2");
                var stockATerme = stock.AS_QteSto + stock.AS_QteCom - stock.AS_QteRes;
                string stockATermeStr = stockATerme?.ToString("F2");
                var valeur = (stock.AS_MontSto ?? 0) / (stock.AS_QteSto < 1 ? 1 : stock.AS_QteSto);
                var cmup = valeur?.ToString("F2");
                var montSto = stock.AS_MontSto?.ToString("F2");
                var qteMini = stock.AS_QteMini?.ToString("F2");
                var qteMaxi = stock.AS_QteMaxi?.ToString("F2");
                var qtePrepa = stock.AS_QtePrepa?.ToString("F2");
                _bindingSource.Rows.Add(
                    intituleDepot,
                    emplacement.DP_Code ?? "",
                    emplacement.DP_Intitule ?? "",
                    _listeDepotZones[emplacement.DP_Zone ?? 0],
                    uniteVente,
                    qteSto,
                    stock.AS_Principal,
                    qteCom,
                    qteRes,
                    stockATerme,
                    cmup,
                    montSto,
                    qteMini,
                    qteMaxi,
                    qtePrepa
                );
            }
            dataGridView1.DataSource = _bindingSource;
        }
        // ======================================== DEBUT FONCTIONS ========================================



        // ======================================== FIN FONCTIONS ========================================
        private void linkLabel1_Click(object sender, System.EventArgs e)
        {
            if (_articleSelect.AR_Ref == _referenceArt)
            {
                if (_detailsArticle == null || _detailsArticle.IsDisposed)
                {
                    _detailsArticle = new DetailsArticle(_referenceArt, _designArt);
                    _detailsArticle.Show();
                }
                else
                {
                    _detailsArticle.BringToFront();
                    _detailsArticle.Focus();
                }
            }
            else
            {
                if (_detailsArticle != null)
                {
                    _detailsArticle.Close();
                }
                _detailsArticle = new DetailsArticle(_articleSelect.AR_Ref, _articleSelect.AR_Design);
                _detailsArticle.Show();
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _articleSelect = _context.F_ARTICLE.Where(art => art.AR_Ref + " - " + art.AR_Design == comboBox2.Text).FirstOrDefault();
        }

        private void KryptonButtonAfficher_Click(object sender, EventArgs e)
        {
            comboBoxDepot.SelectedIndex = 0;
            afficherDepot(_articleSelect.AR_Ref);

            //var listeStockArtSelect = _context.F_ARTSTOCK.Where(art => art.AR_Ref == _articleSelect.AR_Ref).ToList();

            //_bindingSource = new DataTable();
            //_bindingSource.Columns.Add(new DataColumn("Intitulé dépôt"));
            //_bindingSource.Columns.Add(new DataColumn("Code emplacement"));
            //_bindingSource.Columns.Add(new DataColumn("Intitulé emplacement"));
            //_bindingSource.Columns.Add(new DataColumn("Zone emplacement"));
            //_bindingSource.Columns.Add(new DataColumn("Unité de vente"));
            ////_bindingSource.Columns.Add(new DataColumn("Complément série/lot"));
            ////_bindingSource.Columns.Add(new DataColumn("Date fabrication"));
            ////_bindingSource.Columns.Add(new DataColumn("Date péremption"));
            //_bindingSource.Columns.Add(new DataColumn("Stock réel"));
            //_bindingSource.Columns.Add(new DataColumn("Disponible"));
            //_bindingSource.Columns.Add(new DataColumn("Commandé"));
            //_bindingSource.Columns.Add(new DataColumn("Réservé"));
            //_bindingSource.Columns.Add(new DataColumn("Stock à terme"));
            //_bindingSource.Columns.Add(new DataColumn("CMUP"));
            //_bindingSource.Columns.Add(new DataColumn("Valeur du stock"));
            //_bindingSource.Columns.Add(new DataColumn("Qté Mini"));
            //_bindingSource.Columns.Add(new DataColumn("Qté Maxi"));
            ////_bindingSource.Columns.Add(new DataColumn("Dernier P.A."));
            //_bindingSource.Columns.Add(new DataColumn("Préparé"));
            //foreach (var stock in listeStockArtSelect)
            //{
            //    var intituleDepot = _context.F_DEPOT.Where(dpt => dpt.DE_No == stock.DE_No).Select(art => art.DE_Intitule).FirstOrDefault();
            //    var emplacement = _context.F_DEPOTEMPL.Where(dpt => dpt.DP_No == (stock.DP_NoPrincipal == 0 ? 1 : stock.DP_NoPrincipal)).Select(art => new { art.DP_Code, art.DP_Intitule, art.DP_Zone }).FirstOrDefault();
            //    var numUniteVente = _context.F_ARTICLE.Where(art => art.AR_Ref == _referenceArt).Select(art => art.AR_UniteVen).FirstOrDefault();
            //    var uniteVente = _context.P_UNITE.Where(unit => unit.cbIndice == numUniteVente).Select(art => art.U_Intitule).FirstOrDefault();
            //    var qteSto = stock.AS_QteSto?.ToString("F2");
            //    var qteCom = stock.AS_QteCom?.ToString("F2");
            //    var qteRes = stock.AS_QteRes?.ToString("F2");
            //    var stockATerme = stock.AS_QteSto + stock.AS_QteCom - stock.AS_QteRes;
            //    string stockATermeStr = stockATerme?.ToString("F2");
            //    var valeur = (stock.AS_MontSto ?? 0) / (stock.AS_QteSto < 1 ? 1 : stock.AS_QteSto);
            //    var cmup = valeur?.ToString("F2");
            //    var montSto = stock.AS_MontSto?.ToString("F2");
            //    var qteMini = stock.AS_QteMini?.ToString("F2");
            //    var qteMaxi = stock.AS_QteMaxi?.ToString("F2");
            //    var qtePrepa = stock.AS_QtePrepa?.ToString("F2");
            //    _bindingSource.Rows.Add(
            //        intituleDepot,
            //        emplacement.DP_Code,
            //        emplacement.DP_Intitule,
            //        _listeDepotZones[emplacement.DP_Zone ?? 0],
            //        uniteVente,
            //        qteSto,
            //        stock.AS_Principal,
            //        qteCom,
            //        qteRes,
            //        stockATerme,
            //        cmup,
            //        montSto,
            //        qteMini,
            //        qteMaxi,
            //        qtePrepa
            //    );
            //}
            //dataGridView1.DataSource = _bindingSource;
        }

        private void comboBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherDepot(_referenceArt);
        }
    }
}