using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
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
        public InterrogationStockArticle(string referenceArt, string designArt)
        {
            _referenceArt = referenceArt;
            _designArt = designArt;
            _context = new AppDbContext();
            InitializeComponent();
            List<string> refOuDes = new List<string> { "Référence", "Désignation" };
            comboBox1.DataSource = refOuDes;
            comboBox1.DisplayMember = "Value";
            comboBox1.SelectedIndex = 0;

            var listeARRef = _context.F_ARTICLE.Select(a => new Controle() { item = a.AR_Ref }).ToList();
            var selectedArt = listeARRef.FirstOrDefault(a => a.item == _referenceArt);
            int selectedIndexFamille = listeARRef.IndexOf(selectedArt);
            comboBox2.DataSource = listeARRef;
            comboBox2.DisplayMember = "item";
            comboBox2.SelectedIndex = selectedIndexFamille;

            var listeStockArt = _context.F_ARTSTOCK.Where(u => u.AR_Ref == _referenceArt).ToList();

            //var listeARDesign = _context.F_ARTICLE.Select(u => new Controle() { item = u.AR_Design }).ToList();
            //var selectedArt = listeARDesign.FirstOrDefault(article => article.item == _designArt);
            //int selectedIndexFamille = listeARDesign.IndexOf(selectedArt);
            //comboBox2.DataSource = listeARDesign;
            //comboBox2.DisplayMember = "item";
            //comboBox2.SelectedIndex = selectedIndexFamille;

            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("CMUP"));
            _bindingSource.Columns.Add(new DataColumn("Code emplacement"));
            _bindingSource.Columns.Add(new DataColumn("Commandé"));
            _bindingSource.Columns.Add(new DataColumn("Complément série/lot"));
            _bindingSource.Columns.Add(new DataColumn("Date fabrication"));
            _bindingSource.Columns.Add(new DataColumn("Dernier P.A."));
            _bindingSource.Columns.Add(new DataColumn("Disponible"));
            _bindingSource.Columns.Add(new DataColumn("Intitulé dépôt"));
            _bindingSource.Columns.Add(new DataColumn("Intitulé emplacement"));
            _bindingSource.Columns.Add(new DataColumn("Préparé"));
            _bindingSource.Columns.Add(new DataColumn("Qté Maxi"));
            _bindingSource.Columns.Add(new DataColumn("Qté Mini"));
            _bindingSource.Columns.Add(new DataColumn("Réservé"));
            _bindingSource.Columns.Add(new DataColumn("Stock à terme"));
            _bindingSource.Columns.Add(new DataColumn("Stock réel"));
            _bindingSource.Columns.Add(new DataColumn("Unité de vente"));
            _bindingSource.Columns.Add(new DataColumn("Valeur du stock"));
            _bindingSource.Columns.Add(new DataColumn("Zone emplacement"));
            foreach (var stock in listeStockArt)
            {
                // TODO: Avy aiza ireo données ireo???
                //_bindingSource.Rows.Add(stock.AR_Ref, );
            }
            dataGridView1.DataSource = _bindingSource;
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedRefDes = comboBox1.SelectedItem;
            if (selectedRefDes.ToString() == "Référence")
            {
                comboBox1.SelectedIndex = 0;
                var listeARRef = _context.F_ARTICLE.Select(a => new Controle() { item = a.AR_Ref }).ToList();
                var selectedArt = listeARRef.FirstOrDefault(a => a.item == _referenceArt);
                int selectedIndexFamille = listeARRef.IndexOf(selectedArt);
                comboBox2.DataSource = listeARRef;
                comboBox2.DisplayMember = "item";
                comboBox2.SelectedIndex = selectedIndexFamille;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
                var listeARDes = _context.F_ARTICLE.Select(a => new Controle() { item = a.AR_Design }).ToList();
                var selectedArt = listeARDes.FirstOrDefault(a => a.item == _designArt);
                int selectedIndexFamille = listeARDes.IndexOf(selectedArt);
                comboBox2.DataSource = listeARDes;
                comboBox2.DisplayMember = "item";
                comboBox2.SelectedIndex = selectedIndexFamille;
            }
        }
    }
}