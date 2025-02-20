using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System.Collections.Generic;
using System.Data;

namespace SoftCaisse.Forms.Clients
{
    public partial class ListeClients : KryptonForm
    {
        private DataTable _bindingSource;
        private List<F_COMPTET> listeClients;

        private readonly AppDbContext _context;
        private readonly F_COMPTETRepository _f_COMPTETRepository;





        // =====================================================================================
        // ==================================== CONSTRUCTEUR ===================================
        public ListeClients()
        {
            InitializeComponent();


            _context = new AppDbContext();
            _f_COMPTETRepository = new F_COMPTETRepository(_context);

            _bindingSource = new DataTable();

            LoadData();

        }
        // ==================================== CONSTRUCTEUR ===================================
        // =====================================================================================





        // ==================================================================================
        // ==================================== FONCTIONS ===================================
        public void LoadData()
        {
            _bindingSource.Clear();
            listeClients = _f_COMPTETRepository.GetAll_F_COMPTET_Zero();
            if (_bindingSource.Columns.Count < 1)
            {
                _bindingSource.Columns.Add(new DataColumn("Numéro"));
                _bindingSource.Columns.Add(new DataColumn("Intitulé"));
            }
            foreach (var cli in listeClients)
            {
                _bindingSource.Rows.Add(cli.CT_Num, cli.CT_Intitule);
            }
            DataGridViewArticle.DataSource = _bindingSource;
        }
        // ==================================== FONCTIONS ===================================
        // ==================================================================================





        // ==================================================================================
        // ==================================== EVENEMENTS ==================================
        private void kryptonButtonFermer_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        // ==================================== EVENEMENTS ==================================
        // ==================================================================================

    }
}
