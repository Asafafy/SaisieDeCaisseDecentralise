using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.CustomModel;
using SoftCaisse.Models;
using System.Data;
using System.Linq;

namespace SoftCaisse.Forms.Famille
{
    public partial class ListeFamillesDArticles : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;
        public ListeFamillesDArticles()
        {
            _context = new AppDbContext();
            InitializeComponent();
            var catalogues = _context.F_CATALOGUE.Where(u => u.CL_Niveau == 0).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
            catalogues.Insert(0, new Controle() { item = "Tous", valeur = "0" });
            cmbxFamille.DataSource = catalogues;
            cmbxFamille.DisplayMember = "item";
            cmbxFamille.ValueMember = "valeur";
            cmbxFamille.SelectedIndex = 0;
            afficherTous();
        }

        private void afficherTous()
        {
            var listeFamille = _context.F_FAMILLE.Select(u => new Ffamille { FA_CodeFamille = u.FA_CodeFamille, FA_Intitule = u.FA_Intitule, CL_No1 = u.CL_No1, FA_Central = u.FA_Central }).OrderBy(u => u.FA_Intitule).ToList();
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Intitulé de la famille"));
            _bindingSource.Columns.Add(new DataColumn("Code famille"));
            _bindingSource.Columns.Add(new DataColumn("Catalogue"));
            _bindingSource.Columns.Add(new DataColumn("Centralisation"));
            foreach (var famille in listeFamille)
            {
                _bindingSource.Rows.Add(famille.FA_Intitule, famille.FA_CodeFamille, famille.CL_No1, famille.FA_Central);
            }
            DataGridView1.DataSource = _bindingSource;
        }
    }
}
