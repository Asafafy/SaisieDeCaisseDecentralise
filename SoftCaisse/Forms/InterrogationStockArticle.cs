using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.DTO.DetailsArticle.InterrogationStock;
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
        private string _initRefArt;
        private DetailsArticle _detailsArticle;
        private F_ARTICLE _articleSelect;
        private string _uniteVente;
        private List<CMUPInterrStock> _valeursCMPU;
        private List<string> _listeDepotZones;
        private bool _haveArtGamme1;
        private bool _haveArtGamme2;
        private int _selectedIndexGamme1;
        private int _selectedIndexGamme2;





        // ======================================== DEBUT CONSTRUCTEUR ========================================
        public InterrogationStockArticle(string referenceArt, string designArt, DetailsArticle detailsArticle)
        {
            _referenceArt = referenceArt;
            _designArt = designArt;
            _initRefArt = referenceArt;
            _context = new AppDbContext();
            _valeursCMPU = new List<CMUPInterrStock> { };
            InitializeComponent();

            _detailsArticle = detailsArticle;
            var listeARRef = _context.F_ARTICLE.Select(a => new { item = a.AR_Ref + " - " + a.AR_Design }).OrderBy(elt => elt.item).ToList();
            var selectedArtRef = listeARRef.FirstOrDefault(a => a.item == _referenceArt + " - " + _designArt);
            int selectedIndexFamille = listeARRef.IndexOf(selectedArtRef);
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

            gererAffichageComboBoxConditionnement(referenceArt, 0);

            _articleSelect = _context.F_ARTICLE.Where(art => art.AR_Ref == referenceArt && art.AR_Design == designArt).FirstOrDefault();

            afficherArticleDeSubstitution(referenceArt);

            afficherDepot(referenceArt);
        }
        // ======================================== FIN CONSTRUCTEUR ========================================



        // ======================================== DEBUT FONCTIONS ========================================
        private void afficherDepot(string referenceArticle)
        {
            /* ===================================== Début affichage stock des articles sans emplacements - sans gammes 1 et 2 ===================================== */
            List<F_ARTSTOCK> listeStockArt;
            Controle selectedDepot = (Controle)comboBoxDepot.SelectedItem;
            if (selectedDepot.valeur == "0")
            {
                listeStockArt = _context.F_ARTSTOCK.Where(art => art.AR_Ref == referenceArticle).OrderBy(art => art.DE_No).ToList();
            }
            else
            {
                listeStockArt = _context.F_ARTSTOCK.Where(art => art.AR_Ref == referenceArticle && art.DE_No.ToString() == selectedDepot.valeur).OrderBy(art => art.DE_No).ToList();
            }
            bool haveConditionnement = comboBoxConditionnement.SelectedIndex > 0;
            F_CONDITION conditionnement = _context.F_CONDITION.Where(cond => cond.AR_Ref == referenceArticle && cond.EC_Enumere == comboBoxConditionnement.Text).FirstOrDefault();
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
                string intituleDepot = _context.F_DEPOT.Where(dpt => dpt.DE_No == stock.DE_No).Select(dpt => dpt.DE_Intitule).FirstOrDefault();
                EmplacementsInterrStock emplacement;
                emplacement = new EmplacementsInterrStock { DP_Code = null, DP_Intitule = null, DP_Zone = null };
                var numUniteVente = _context.F_ARTICLE.Where(art => art.AR_Ref == referenceArticle).Select(art => art.AR_UniteVen).FirstOrDefault();
                _uniteVente = _context.P_UNITE.Where(unit => unit.cbIndice == numUniteVente).Select(art => art.U_Intitule).FirstOrDefault();
                string uniteDeVente = _uniteVente;
                var qteSto = (stock.AS_QteSto ?? 0).ToString("F2");
                var disponible = ((stock.AS_QteSto - stock.AS_QtePrepa) ?? 0).ToString("F2");
                var qteCom = (stock.AS_QteCom ?? 0).ToString("F2");
                var qteRes = (stock.AS_QteRes ?? 0).ToString("F2");
                var stockATerme = stock.AS_QteSto + stock.AS_QteCom - stock.AS_QteRes - stock.AS_QtePrepa;
                decimal? cMUPactu = (stock.AS_MontSto ?? 0) / (stock.AS_QteSto < 1 ? 1 : stock.AS_QteSto);
                if (_valeursCMPU.Count() < 1)
                {
                    _valeursCMPU.Add(new CMUPInterrStock { NumeroDepot = stock.DE_No, CMUP = cMUPactu });
                }
                else
                {
                    if (!_valeursCMPU.Any(val => val.NumeroDepot == stock.DE_No))
                    {
                        _valeursCMPU.Add(new CMUPInterrStock { NumeroDepot = stock.DE_No, CMUP = cMUPactu });
                    }
                }
                var montSto = (stock.AS_MontSto ?? 0).ToString("F2");
                var qteMini = (stock.AS_QteMini ?? 0).ToString("F2");
                var qteMaxi = (stock.AS_QteMaxi ?? 0).ToString("F2");
                var qtePrepa = (stock.AS_QtePrepa ?? 0).ToString("F2");
                if (haveConditionnement == true && conditionnement != null)
                {
                    uniteDeVente = conditionnement.EC_Enumere;
                    var quantiteStock = (stock.AS_QteSto) / conditionnement.EC_Quantite;
                    qteSto = ((quantiteStock) ?? 0).ToString("F2");
                    disponible = (((stock.AS_QteSto - stock.AS_QtePrepa) / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                    qteCom = ((stock.AS_QteCom / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                    qteRes = ((stock.AS_QteRes / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                    stockATerme = (stockATerme / conditionnement.EC_Quantite) ?? 0;
                    cMUPactu = (cMUPactu / conditionnement.EC_Quantite) ?? 0;
                    montSto = (((stock.AS_MontSto ?? 0) / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                    qteMini = "";
                    qteMaxi = "";
                    qtePrepa = (((stock.AS_QtePrepa ?? 0) / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                }
                _bindingSource.Rows.Add(
                    intituleDepot,
                    emplacement.DP_Code ?? "",
                    emplacement.DP_Intitule ?? "",
                    _listeDepotZones[emplacement.DP_Zone ?? 0],
                    uniteDeVente,
                    qteSto,
                    disponible,
                    qteCom,
                    qteRes,
                    (stockATerme ?? 0).ToString("F2"),
                    (cMUPactu ?? 0).ToString("F2"),
                    montSto,
                    qteMini,
                    qteMaxi,
                    qtePrepa
                );
            }
            dataGridView1.DataSource = _bindingSource;
            /* ===================================== Fin affichage stock des articles sans emplacements - sans gamme 1 et 2 ===================================== */
        }


        private void afficherArtEmplacement(string referenceArticle)
        {
            /* ===================================== Début affichage stock des articles avec emplacements ===================================== */
            Controle selectedDepot = (Controle)comboBoxDepot.SelectedItem;
            List<F_ARTSTOCKEMPL> listeStockArtEmpl;
            if (selectedDepot.valeur == "0")
            {
                listeStockArtEmpl = _context.F_ARTSTOCKEMPL.Where(art => art.AR_Ref == referenceArticle).OrderBy(art => art.DE_No).ToList();
            }
            else
            {
                listeStockArtEmpl = _context.F_ARTSTOCKEMPL.Where(artEmpl => artEmpl.AR_Ref == referenceArticle && artEmpl.DE_No.ToString() == selectedDepot.valeur).OrderBy(art => art.DE_No).ToList();
            }
            bool haveConditionnement = comboBoxConditionnement.SelectedIndex > 0;
            F_CONDITION conditionnement = _context.F_CONDITION.Where(cond => cond.AR_Ref == referenceArticle && cond.EC_Enumere == comboBoxConditionnement.Text).FirstOrDefault();
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
            foreach (var stock in listeStockArtEmpl)
            {
                string intituleDepot = _context.F_DEPOT.Where(dpt => dpt.DE_No == stock.DE_No).Select(dpt => dpt.DE_Intitule).FirstOrDefault();
                EmplacementsInterrStock emplacement;
                emplacement = _context.F_DEPOTEMPL.Where(dpt => dpt.DP_No == (stock.DP_No == 0 ? 1 : stock.DP_No)).Select(art => new EmplacementsInterrStock { DP_Code = art.DP_Code, DP_Intitule = art.DP_Intitule, DP_Zone = art.DP_Zone }).FirstOrDefault();
                var qteSto = (stock.AE_QteSto ?? 0).ToString("F2");
                var disponible = ((stock.AE_QteSto - stock.AE_QtePrepa) ?? 0).ToString("F2");
                var stockATerme = stock.AE_QteSto - stock.AE_QtePrepa;
                var cmup = _valeursCMPU[stock.DE_No - 1].CMUP;
                var montSto = ((cmup * stock.AE_QteSto) ?? 0).ToString("F2");
                var qtePrepa = (stock.AE_QtePrepa ?? 0).ToString("F2");
                string uniteDeVente = _uniteVente;
                if (haveConditionnement == true && conditionnement != null)
                {
                    uniteDeVente = conditionnement.EC_Enumere;
                    var quantiteStock = (stock.AE_QteSto) / conditionnement.EC_Quantite;
                    qteSto = ((quantiteStock) ?? 0).ToString("F2");
                    disponible = (((stock.AE_QteSto - stock.AE_QtePrepa) / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                    stockATerme = (stockATerme / conditionnement.EC_Quantite) ?? 0;
                    cmup = (((_valeursCMPU[stock.DE_No - 1].CMUP) ?? 0) / conditionnement.EC_Quantite) ?? 0;
                    montSto = ((((cmup * stock.AE_QteSto) ?? 0) / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                    qtePrepa = (((stock.AE_QtePrepa ?? 0) / conditionnement.EC_Quantite) ?? 0).ToString("F2");
                }
                _bindingSource.Rows.Add(
                intituleDepot,
                emplacement.DP_Code ?? "",
                emplacement.DP_Intitule ?? "",
                _listeDepotZones[emplacement.DP_Zone ?? 0],
                uniteDeVente,
                qteSto,
                disponible,
                "",
                "",
                (stockATerme ?? 0).ToString("F2"),
                (cmup ?? 0).ToString("F2"),
                montSto,
                "",
                "",
                qtePrepa
            );
            }
            dataGridView1.DataSource = _bindingSource;
            /* ===================================== Fin affichage stock des articles avec emplacements ===================================== */
        }

        private void afficherGammes(List<F_GAMSTOCK> listeGamstock, string referenceArticle)
        {
            bool aDepot = comboBoxDepot.SelectedIndex > 0;
            if (aDepot == true)
            {
                listeGamstock.RemoveAll(stock => stock.DE_No != comboBoxDepot.SelectedIndex);
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
            foreach (var stock in listeGamstock)
            {
                string intituleDepot = _context.F_DEPOT.Where(dpt => dpt.DE_No == stock.DE_No).Select(dpt => dpt.DE_Intitule).FirstOrDefault();
                EmplacementsInterrStock emplacement;
                emplacement = new EmplacementsInterrStock { DP_Code = null, DP_Intitule = null, DP_Zone = null };
                var numUniteVente = _context.F_ARTICLE.Where(art => art.AR_Ref == referenceArticle).Select(art => art.AR_UniteVen).FirstOrDefault();
                _uniteVente = _context.P_UNITE.Where(unit => unit.cbIndice == numUniteVente).Select(art => art.U_Intitule).FirstOrDefault();
                var qteSto = (stock.GS_QteSto ?? 0).ToString("F2");
                var disponible = ((stock.GS_QteSto - stock.GS_QtePrepa) ?? 0).ToString("F2");
                var qteCom = (stock.GS_QteCom ?? 0).ToString("F2");
                var qteRes = (stock.GS_QteRes ?? 0).ToString("F2");
                var stockATerme = stock.GS_QteSto + stock.GS_QteCom - stock.GS_QteRes - stock.GS_QtePrepa;
                decimal? cMUPactu = (stock.GS_MontSto ?? 0) / (stock.GS_QteSto < 1 ? 1 : stock.GS_QteSto);
                if (_valeursCMPU.Count() < 1)
                {
                    _valeursCMPU.Add(new CMUPInterrStock { NumeroDepot = stock.DE_No, CMUP = cMUPactu });
                }
                else
                {
                    if (!_valeursCMPU.Any(val => val.NumeroDepot == stock.DE_No))
                    {
                        _valeursCMPU.Add(new CMUPInterrStock { NumeroDepot = stock.DE_No, CMUP = cMUPactu });
                    }
                }
                var montSto = (stock.GS_MontSto ?? 0).ToString("F2");
                var qteMini = (stock.GS_QteMini ?? 0).ToString("F2");
                var qteMaxi = (stock.GS_QteMaxi ?? 0).ToString("F2");
                var qtePrepa = (stock.GS_QtePrepa ?? 0).ToString("F2");
                _bindingSource.Rows.Add(
                    intituleDepot,
                    emplacement.DP_Code ?? "",
                    emplacement.DP_Intitule ?? "",
                    _listeDepotZones[emplacement.DP_Zone ?? 0],
                    _uniteVente,
                    qteSto,
                    disponible,
                    qteCom,
                    qteRes,
                    (stockATerme ?? 0).ToString("F2"),
                    (cMUPactu ?? 0).ToString("F2"),
                    montSto,
                    qteMini,
                    qteMaxi,
                    qtePrepa
                );
            }
            dataGridView1.DataSource = _bindingSource;
        }

        private void afficherArtGammes(string referenceArticle)
        {
            /* ===================================== Début affichage stock des articles sans emplacements - avec gamme 1 et 2 ===================================== */
            Controle selectedGamme1 = (Controle)comboBoxGamme1.SelectedItem;
            Controle selectedGamme2 = (Controle)comboBoxGamme2.SelectedItem;
            List<F_GAMSTOCK> listeGamstock = new List<F_GAMSTOCK> { };
            _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == referenceArticle && artgmm.AG_Type == 1).Count() >= 1;
            if (_haveArtGamme2 && selectedGamme2 != null)
            {
                if (selectedGamme1.item == "Aucun détail" && selectedGamme2.item == "Aucun détail")
                {
                    afficherDepot(referenceArticle);
                }
                else
                {
                    if (selectedGamme1.item == "Aucun détail" && selectedGamme2.item == "Tous les énumérés")
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && gmStck.AG_No2 != 0).ToList();
                    }
                    else if (selectedGamme1.item == "Aucun détail" && int.Parse(selectedGamme2.valeur) > 1)
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && (gmStck.AG_No2 + 1).ToString() == selectedGamme2.valeur).ToList();
                    }
                    else if (selectedGamme1.item == "Tous les énumérés" && selectedGamme2.item == "Aucun détail")
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && gmStck.AG_No1 != 0).ToList();
                    }
                    else if (selectedGamme1.item == "Tous les énumérés" && selectedGamme2.item == "Tous les énumérés")
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && gmStck.AG_No1 != 0 && gmStck.AG_No2 != 0).ToList();
                    }
                    else if (selectedGamme1.item == "Tous les énumérés" && int.Parse(selectedGamme2.valeur) > 1)
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && gmStck.AG_No1 != 0 && (gmStck.AG_No2 + 1).ToString() == selectedGamme2.valeur).ToList();
                    }
                    else if (int.Parse(selectedGamme1.valeur) > 1 && selectedGamme2.item == "Aucun détail")
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && (gmStck.AG_No1 + 1).ToString() == selectedGamme1.valeur).ToList();
                    }
                    else if (int.Parse(selectedGamme1.valeur) > 1 && selectedGamme2.item == "Tous les énumérés")
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && (gmStck.AG_No1 + 1).ToString() == selectedGamme1.valeur && gmStck.AG_No2 != 0).ToList();
                    }
                    else if (int.Parse(selectedGamme1.valeur) > 1 && int.Parse(selectedGamme2.valeur) > 1)
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && (gmStck.AG_No1 + 1).ToString() == selectedGamme1.valeur && (gmStck.AG_No2 + 1).ToString() == selectedGamme2.valeur).ToList();
                    }
                    else
                    {
                        // Ne rien faire
                    }
                    afficherGammes(listeGamstock, referenceArticle);

                }
            }
            else
            {
                if (selectedGamme1.item == "Aucun détail")
                {
                    afficherDepot(referenceArticle);
                }
                else
                {
                    if (selectedGamme1.item == "Tous les énumérés")
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle).ToList();
                    }
                    else
                    {
                        listeGamstock = _context.F_GAMSTOCK.Where(gmStck => gmStck.AR_Ref == referenceArticle && (gmStck.AG_No1 + 1).ToString() == selectedGamme1.valeur).ToList();
                    }
                    afficherGammes(listeGamstock, referenceArticle);
                }
            }
            /* ===================================== Fin affichage stock des articles sans emplacements - avec gamme 1 et 2 ===================================== */
        }

        private void afficherGammesStckEmpl(List<F_GAMSTOCKEMPL> listeGamstockEmpl, string referenceArticle)
        {
            bool aDepot = comboBoxDepot.SelectedIndex > 0;
            if (aDepot == true)
            {
                listeGamstockEmpl.RemoveAll(stock => stock.DE_No != comboBoxDepot.SelectedIndex);
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
            foreach (var stock in listeGamstockEmpl)
            {
                string intituleDepot = _context.F_DEPOT.Where(dpt => dpt.DE_No == stock.DE_No).Select(dpt => dpt.DE_Intitule).FirstOrDefault();
                F_DEPOTEMPL emplacement;
                emplacement = _context.F_DEPOTEMPL.Where(dptEmpl => dptEmpl.DP_No == stock.DP_No).FirstOrDefault();
                var numUniteVente = _context.F_ARTICLE.Where(art => art.AR_Ref == referenceArticle).Select(art => art.AR_UniteVen).FirstOrDefault();
                _uniteVente = _context.P_UNITE.Where(unit => unit.cbIndice == numUniteVente).Select(art => art.U_Intitule).FirstOrDefault();
                var qteSto = (stock.GE_QteSto ?? 0).ToString("F2");
                var disponible = ((stock.GE_QteSto - stock.GE_QtePrepa) ?? 0).ToString("F2");
                var stockATerme = stock.GE_QteSto - stock.GE_QtePrepa;
                var montSto = ((_valeursCMPU[stock.DE_No - 1].CMUP * stock.GE_QteSto) ?? 0).ToString("F2");
                decimal? cMUPactu = _valeursCMPU[stock.DE_No].CMUP ?? 0;
                var qtePrepa = (stock.GE_QtePrepa ?? 0).ToString("F2");
                _bindingSource.Rows.Add(
                    intituleDepot,
                    emplacement.DP_Code ?? "",
                    emplacement.DP_Intitule ?? "",
                    _listeDepotZones[emplacement.DP_Zone ?? 0],
                    _uniteVente,
                    qteSto,
                    disponible,
                    "",
                    "",
                    (stockATerme ?? 0).ToString("F2"),
                    (cMUPactu ?? 0).ToString("F2"),
                    montSto,
                    "",
                    "",
                    qtePrepa
                );
            }
            dataGridView1.DataSource = _bindingSource;
        }

        private void afficherGammesEmplacements(string referenceArticle)
        {
            Controle selectedGamme1 = (Controle)comboBoxGamme1.SelectedItem;
            Controle selectedGamme2 = (Controle)comboBoxGamme2.SelectedItem;
            List<F_GAMSTOCKEMPL> listeGamstockEmplacement = new List<F_GAMSTOCKEMPL> { };
            _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == referenceArticle && artgmm.AG_Type == 1).Count() >= 1;
            if (_haveArtGamme2)
            {
                if (selectedGamme1.item == "Aucun détail" && selectedGamme2.item == "Aucun détail")
                {
                    afficherArtEmplacement(referenceArticle);
                }
                else
                {
                    if (selectedGamme1.item == "Aucun détail" && selectedGamme2.item == "Tous les énumérés")
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && gmStckEmpl.AG_No2 != 0).ToList();
                    }
                    else if (selectedGamme1.item == "Aucun détail" && int.Parse(selectedGamme2.valeur) > 1)
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && (gmStckEmpl.AG_No2 + 1).ToString() == selectedGamme2.valeur).ToList();
                    }
                    else if (selectedGamme1.item == "Tous les énumérés" && selectedGamme2.item == "Aucun détail")
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && gmStckEmpl.AG_No1 != 0).ToList();
                    }
                    else if (selectedGamme1.item == "Tous les énumérés" && selectedGamme2.item == "Tous les énumérés")
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && gmStckEmpl.AG_No1 != 0 && gmStckEmpl.AG_No2 != 0).ToList();
                    }
                    else if (selectedGamme1.item == "Tous les énumérés" && int.Parse(selectedGamme2.valeur) > 1)
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && gmStckEmpl.AG_No1 != 0 && (gmStckEmpl.AG_No2 + 1).ToString() == selectedGamme2.valeur).ToList();
                    }
                    else if (int.Parse(selectedGamme1.valeur) > 1 && selectedGamme2.item == "Aucun détail")
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && (gmStckEmpl.AG_No1 + 1).ToString() == selectedGamme1.valeur).ToList();
                    }
                    else if (int.Parse(selectedGamme1.valeur) > 1 && selectedGamme2.item == "Tous les énumérés")
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && (gmStckEmpl.AG_No1 + 1).ToString() == selectedGamme1.valeur && gmStckEmpl.AG_No2 != 0).ToList();
                    }
                    else if (int.Parse(selectedGamme1.valeur) > 1 && int.Parse(selectedGamme2.valeur) > 1)
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && (gmStckEmpl.AG_No1 + 1).ToString() == selectedGamme1.valeur && (gmStckEmpl.AG_No2 + 1).ToString() == selectedGamme2.valeur).ToList();
                    }
                    else
                    {
                        // Ne rien faire
                    }
                    afficherGammesStckEmpl(listeGamstockEmplacement, referenceArticle);
                }
            }
            else
            {
                if (selectedGamme1.item == "Aucun détail")
                {
                    afficherArtEmplacement(referenceArticle);
                }
                else
                {
                    if (selectedGamme1.item == "Tous les énumérés")
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle).ToList();
                    }
                    else
                    {
                        listeGamstockEmplacement = _context.F_GAMSTOCKEMPL.Where(gmStckEmpl => gmStckEmpl.AR_Ref == referenceArticle && (gmStckEmpl.AG_No1 + 1).ToString() == selectedGamme1.valeur).ToList();
                    }
                    afficherGammesStckEmpl(listeGamstockEmplacement, referenceArticle);
                }
            }
        }

        public void gererAffichageComboBoxGamme1(string referenceArticle, bool haveGamme1, int selectedIndex)
        {
            if (haveGamme1 == false)
            {
                labelGammes.Visible = false;
                comboBoxGamme1.Visible = false;
                comboBoxGamme2.Visible = false;
            }
            else
            {
                List<Controle> listeGamme1 = _context.F_ARTGAMME.Where(artGam1 => artGam1.AR_Ref == referenceArticle && artGam1.AG_Type == 0).Select(artGam1 => new Controle { item = artGam1.EG_Enumere, valeur = (artGam1.AG_No + 1).ToString() }).ToList();
                listeGamme1.InsertRange(0, new[] { new Controle() { item = "Aucun détail", valeur = "0" }, new Controle { item = "Tous les énumérés", valeur = "1" } });
                comboBoxGamme1.DataSource = listeGamme1;
                comboBoxGamme1.DisplayMember = "item";
                comboBoxGamme1.ValueMember = "valeur";
                comboBoxGamme1.SelectedIndex = selectedIndex;
                labelGammes.Visible = true;
                comboBoxGamme1.Visible = true;
                comboBoxGamme2.Visible = false;
            }
        }

        public void gererAffichageComboBoxGamme2(string referenceArticle, bool haveGamme2, int selectedIndex)
        {
            if (haveGamme2 == false)
            {
                comboBoxGamme2.Visible = false;
            }
            else
            {
                List<Controle> listeGamme2 = _context.F_ARTGAMME.Where(artGam2 => artGam2.AR_Ref == referenceArticle && artGam2.AG_Type == 1).Select(artGam2 => new Controle { item = artGam2.EG_Enumere, valeur = (artGam2.AG_No + 1).ToString() }).ToList();
                listeGamme2.InsertRange(0, new[] { new Controle() { item = "Aucun détail", valeur = "0" }, new Controle { item = "Tous les énumérés", valeur = "1" } });
                comboBoxGamme2.DataSource = listeGamme2;
                comboBoxGamme2.DisplayMember = "item";
                comboBoxGamme2.ValueMember = "valeur";
                comboBoxGamme2.SelectedIndex = selectedIndex;
                comboBoxGamme2.Visible = true;
            }
        }

        public void gererAffichageComboBoxConditionnement(string referenceArticle, int selectedIndex)
        {
            List<Controle> listeConditionnement = _context.F_CONDITION.Where(cond => cond.AR_Ref == referenceArticle).Select(cond => new Controle { item = cond.EC_Enumere, valeur = cond.CO_No.ToString() }).ToList();
            if (listeConditionnement.Count() < 1)
            {
                labelConditionnement.Visible = false;
                comboBoxConditionnement.Visible = false;
            }
            else
            {
                listeConditionnement.InsertRange(0, new[] { new Controle() { item = "Pièce", valeur = "0" } });
                comboBoxConditionnement.DataSource = listeConditionnement;
                comboBoxConditionnement.DisplayMember = "item";
                comboBoxConditionnement.ValueMember = "valeur";
                comboBoxConditionnement.SelectedIndex = selectedIndex;
                labelConditionnement.Visible = true;
                comboBoxConditionnement.Visible = true;
            }
        }
        // ======================================== FIN FONCTIONS ========================================





        // ======================================== DEBUT EVENEMENTS ========================================
        private void linkLabel1_Click(object sender, System.EventArgs e)
        {
            if (_articleSelect.AR_Ref == _initRefArt)
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
            if (_articleSelect == null)
            {
                KryptonButtonAfficher.Enabled = false;
            }
            else if (_articleSelect.AR_Ref == _referenceArt)
            {
                KryptonButtonAfficher.Enabled = false;
            }
            else
            {
                _referenceArt = _articleSelect.AR_Ref;
                _designArt = _articleSelect.AR_Design;
                KryptonButtonAfficher.Enabled = true;
            }
        }

        private void KryptonButtonAfficher_Click(object sender, EventArgs e)
        {
            _uniteVente = "";
            _valeursCMPU.Clear();
            _selectedIndexGamme1 = 0;
            _selectedIndexGamme2 = 0;
            _haveArtGamme1 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 0).Count() >= 1;
            _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 1).Count() >= 1;
            gererAffichageComboBoxGamme1(_articleSelect.AR_Ref, _haveArtGamme1, 0);
            gererAffichageComboBoxGamme2(_articleSelect.AR_Ref, _haveArtGamme2, 0);
            gererAffichageComboBoxConditionnement(_articleSelect.AR_Ref, 0);
            afficherDepot(_articleSelect.AR_Ref);
            afficherArticleDeSubstitution(_articleSelect.AR_Ref);
            KryptonButtonAfficher.Enabled = false;
        }

        private void comboBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_articleSelect != null)
            {
                _haveArtGamme1 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 0).Count() >= 1;
                _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 1).Count() >= 1;
                bool haveEmplacement = comboBoxEmplacement.SelectedIndex > 0;
                _selectedIndexGamme1 = (comboBoxGamme1.SelectedIndex == -1) ? 0 : comboBoxGamme1.SelectedIndex;
                gererAffichageComboBoxGamme1(_articleSelect.AR_Ref, _haveArtGamme1, _selectedIndexGamme1);
                if (_haveArtGamme1)
                {
                    _selectedIndexGamme2 = (comboBoxGamme2.SelectedIndex == -1) ? 0 : comboBoxGamme2.SelectedIndex;
                    gererAffichageComboBoxGamme2(_articleSelect.AR_Ref, _haveArtGamme2, _selectedIndexGamme2);
                    if (_haveArtGamme2)
                    {
                        if (haveEmplacement)
                        {
                            afficherGammesEmplacements(_articleSelect.AR_Ref);
                        }
                        else
                        {
                            afficherArtGammes(_articleSelect.AR_Ref);
                        }
                    }
                    else
                    {
                        if (haveEmplacement)
                        {
                            afficherGammesEmplacements(_articleSelect.AR_Ref);
                        }
                        else
                        {
                            afficherArtGammes(_articleSelect.AR_Ref);
                        }
                    }
                }
                else
                {
                    if (haveEmplacement)
                    {
                        afficherArtEmplacement(_articleSelect.AR_Ref);
                    }
                    else
                    {
                        afficherDepot(_articleSelect.AR_Ref);
                    }
                }
            }
            else
            {
                _selectedIndexGamme1 = (comboBoxGamme1.SelectedIndex == -1) ? 0 : comboBoxGamme1.SelectedIndex;
                _selectedIndexGamme2 = (comboBoxGamme2.SelectedIndex == -1) ? 0 : comboBoxGamme2.SelectedIndex;
                gererAffichageComboBoxGamme1(_referenceArt, _haveArtGamme1, _selectedIndexGamme1);
                gererAffichageComboBoxGamme2(_referenceArt, _haveArtGamme2, _selectedIndexGamme2);
                afficherDepot(_referenceArt);
            }
        }

        private void comboBoxEmplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_articleSelect != null && comboBoxEmplacement.SelectedIndex > 0)
            {
                _haveArtGamme1 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 0).Count() >= 1;
                _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 1).Count() >= 1;
                _selectedIndexGamme1 = (comboBoxGamme1.SelectedIndex == -1) ? 0 : comboBoxGamme1.SelectedIndex;
                gererAffichageComboBoxGamme1(_articleSelect.AR_Ref, _haveArtGamme1, _selectedIndexGamme1);
                if (_haveArtGamme1)
                {
                    _selectedIndexGamme2 = (comboBoxGamme2.SelectedIndex == -1) ? 0 : comboBoxGamme2.SelectedIndex;
                    gererAffichageComboBoxGamme2(_articleSelect.AR_Ref, _haveArtGamme2, _selectedIndexGamme2);
                    if (_haveArtGamme2)
                    {
                        if (comboBoxDepot.SelectedIndex < 1)
                        {
                            afficherGammesEmplacements(_articleSelect.AR_Ref);
                        }
                        else
                        {
                            afficherGammesEmplacements(_articleSelect.AR_Ref);
                        }
                    }
                    else
                    {
                        if (comboBoxDepot.SelectedIndex < 1)
                        {
                            afficherGammesEmplacements(_articleSelect.AR_Ref);
                        }
                        else
                        {
                            afficherGammesEmplacements(_articleSelect.AR_Ref);
                        }
                    }
                }
                else
                {
                    afficherArtEmplacement(_articleSelect.AR_Ref);
                }
            }
            else
            {
                afficherDepot(_referenceArt);
            }
        }

        private void comboBoxGamme1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_articleSelect != null)
            {
                bool haveEmpl = comboBoxEmplacement.SelectedIndex > 0;
                if (haveEmpl == true)
                {
                    afficherGammesEmplacements(_articleSelect.AR_Ref);
                }
                else
                {
                    afficherArtGammes(_articleSelect.AR_Ref);
                }
            }
            else
            {
                afficherDepot(_referenceArt);
            }
        }

        private void comboBoxGamme2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_articleSelect != null)
            {
                bool haveEmpl = comboBoxEmplacement.SelectedIndex > 0;
                if (haveEmpl == true)
                {
                    afficherGammesEmplacements(_articleSelect.AR_Ref);
                }
                else
                {
                    afficherArtGammes(_articleSelect.AR_Ref);
                }
            }
            else
            {
                afficherDepot(_referenceArt);
            }
        }

        private void comboBoxConditionnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool haveEmpl = comboBoxEmplacement.SelectedIndex > 0;
            if (_articleSelect != null)
            {
                if (haveEmpl == true)
                {
                    afficherArtEmplacement(_articleSelect.AR_Ref);
                }
                else
                {
                    afficherDepot(_articleSelect.AR_Ref);
                }
            }
            else
            {
                afficherDepot(_referenceArt);
            }
        }

        private void afficherArticleDeSubstitution(string referenceArt)
        {
            F_ARTICLE articleSubstitut = _context.F_ARTICLE.Where(art => art.AR_Ref == referenceArt).Join(_context.F_ARTICLE, art => art.AR_Substitut, substitut => substitut.AR_Ref, (art, substitut) => substitut).FirstOrDefault();
            if (articleSubstitut != null)
            {
                textBoxArtSubstitution.Text = articleSubstitut + " - " + articleSubstitut.AR_Design;
            }
        }




        // ======================================== FIN EVENEMENTS ========================================
    }
}