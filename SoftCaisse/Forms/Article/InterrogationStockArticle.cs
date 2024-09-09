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
        private DetailsArticle _detailsArticle;
        private F_ARTICLE _articleSelect;
        private string _uniteVente;
        private List<CMUPInterrStock> _valeursCMPU;
        private List<string> _listeDepotZones;
        private bool _haveArtGamme1;
        private bool _haveArtGamme2;


        // ======================================== DEBUT CONSTRUCTEUR ========================================
        public InterrogationStockArticle(string referenceArt, string designArt, DetailsArticle detailsArticle)
        {
            _referenceArt = referenceArt;
            _designArt = designArt;
            _context = new AppDbContext();
            _valeursCMPU = new List<CMUPInterrStock> { };
            InitializeComponent();

            _articleSelect = _context.F_ARTICLE.Where(art => art.AR_Ref == referenceArt && art.AR_Design == designArt).FirstOrDefault();
            _detailsArticle = detailsArticle;
            var listeARRef = _context.F_ARTICLE.Select(a => new { item = a.AR_Ref + " - " + a.AR_Design }).ToList();
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

            _haveArtGamme1 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 0).Count() < 1;
            _haveArtGamme2 = _context.F_ARTGAMME.Where(artgmm => artgmm.AR_Ref == _referenceArt && artgmm.AG_Type == 1).Count() < 1;
            KryptonButtonAfficher.Enabled = false;

            afficherDepot(_referenceArt);
        }
        // ======================================== FIN CONSTRUCTEUR ========================================


        // ======================================== DEBUT FONCTIONS ========================================
        private void afficherDepot(string referenceArticle)
        {
            Controle selectedDepot = (Controle)comboBoxDepot.SelectedItem;
            bool aEmplacement;

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
            if (comboBoxEmplacement.SelectedIndex > 0)
            {
                aEmplacement = true;
                List<F_ARTSTOCKEMPL> listeStockArtEmpl;
                if (selectedDepot.valeur == "0")
                {
                    listeStockArtEmpl = _context.F_ARTSTOCKEMPL.Where(art => art.AR_Ref == referenceArticle).OrderBy(art => art.DE_No).ToList();
                }
                else
                {
                    listeStockArtEmpl = _context.F_ARTSTOCKEMPL.Where(artEmpl => artEmpl.AR_Ref == referenceArticle && artEmpl.DE_No.ToString() == selectedDepot.valeur).OrderBy(art => art.DE_No).ToList();
                }
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
                        (cmup ?? 0).ToString("F2"),
                        montSto,
                        "",
                        "",
                        qtePrepa
                    );
                }
            }
            else
            {
                aEmplacement = false;
                List<F_ARTSTOCK> listeStockArt;
                if (selectedDepot.valeur == "0")
                {
                    listeStockArt = _context.F_ARTSTOCK.Where(art => art.AR_Ref == referenceArticle).OrderBy(art => art.DE_No).ToList();
                }
                else
                {
                    listeStockArt = _context.F_ARTSTOCK.Where(art => art.AR_Ref == referenceArticle && art.DE_No.ToString() == selectedDepot.valeur).OrderBy(art => art.DE_No).ToList();
                }
                foreach (var stock in listeStockArt)
                {
                    string intituleDepot = _context.F_DEPOT.Where(dpt => dpt.DE_No == stock.DE_No).Select(dpt => dpt.DE_Intitule).FirstOrDefault();
                    EmplacementsInterrStock emplacement;
                    emplacement = new EmplacementsInterrStock { DP_Code = null, DP_Intitule = null, DP_Zone = null };
                    var numUniteVente = _context.F_ARTICLE.Where(art => art.AR_Ref == _referenceArt).Select(art => art.AR_UniteVen).FirstOrDefault();
                    _uniteVente = _context.P_UNITE.Where(unit => unit.cbIndice == numUniteVente).Select(art => art.U_Intitule).FirstOrDefault();
                    var qteSto = (stock.AS_QteSto ?? 0).ToString("F2");
                    var disponible = ((stock.AS_QteSto - stock.AS_QtePrepa) ?? 0).ToString("F2");
                    var qteCom = (stock.AS_QteCom ?? 0).ToString("F2");
                    var qteRes = (stock.AS_QteRes ?? 0).ToString("F2");
                    var stockATerme = stock.AS_QteSto + stock.AS_QteCom - stock.AS_QteRes;
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
            }
            if (aEmplacement)
            {
                dataGridView1.DataSource = _bindingSource;
                dataGridView1.Columns["Commandé"].Visible = false;
                dataGridView1.Columns["Réservé"].Visible = false;
                dataGridView1.Columns["Qté Mini"].Visible = false;
                dataGridView1.Columns["Qté Maxi"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = _bindingSource;
                dataGridView1.Columns["Code emplacement"].Visible = false;
                dataGridView1.Columns["Intitulé emplacement"].Visible = false;
                dataGridView1.Columns["Zone emplacement"].Visible = false;
            }
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
            KryptonButtonAfficher.Enabled = true;
        }

        private void KryptonButtonAfficher_Click(object sender, EventArgs e)
        {
            _uniteVente = "";
            _valeursCMPU.Clear();
            comboBoxDepot.SelectedIndex = 0;
            comboBoxEmplacement.SelectedIndex = 0;
            afficherDepot(_articleSelect.AR_Ref);
            KryptonButtonAfficher.Enabled = false;
        }

        private void comboBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_articleSelect != null)
            {
                afficherDepot(_articleSelect.AR_Ref);
            }
            else
            {
                afficherDepot(_referenceArt);
            }
        }

        private void comboBoxEmplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_articleSelect != null)
            {
                afficherDepot(_articleSelect.AR_Ref);
            }
            else
            {
                afficherDepot(_referenceArt);
            }
        }
    }
}