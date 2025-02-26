using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Forms.Billetage
{
    public partial class BilletageForm : KryptonForm
    {
        // =============================================================================================
        // DECLARATION DES VARIABLES ===================================================================
        // =============================================================================================
        private readonly AppDbContext _context;
        private short _cbMarq { get; set; }
        public F_BILLETPIECERepository _fbilletageRepository { get; set; }
        // =============================================================================================
        // FIN DES VARIABLES ===========================================================================
        // =============================================================================================









        // =============================================================================================
        // DEBUT CONSTRUCTEUR ==========================================================================
        // =============================================================================================
        public BilletageForm(short cbMarq)
        {
            InitializeComponent();

            _context = new AppDbContext();
            _cbMarq = cbMarq;
            _fbilletageRepository = new F_BILLETPIECERepository(_context);
            var list_piece = _fbilletageRepository.GetAll().Where(u => u.N_Devise == cbMarq).ToList();
            List<F_BILLETPIECE> billet_piece = new List<F_BILLETPIECE>();

            foreach(var row in list_piece)
            {
                billet_piece.Add(row);
            }
            kryptonDataGridView1.DataSource = new BindingList<F_BILLETPIECE>(billet_piece);
        }
        // =============================================================================================
        // FIN CONSTRUCTEUR ============================================================================
        // =============================================================================================








        // =============================================================================================
        // DEBUT EVENEMETS =============================================================================
        // =============================================================================================
        private void newrow_click(object sender, EventArgs e)
        {
            kryptonDataGridView1.Rows.RemoveAt(kryptonDataGridView1.SelectedCells[0].RowIndex);            
            object datagrid = kryptonDataGridView1.CurrentRow.Cells["cbMarq"].Value;
            int cbMarq = Convert.ToInt32(datagrid.ToString());
            _fbilletageRepository.deleteRow(cbMarq);
        }





        private void focus_row(object sender, EventArgs e)
        {
            kryptonDataGridView1.CurrentCell = kryptonDataGridView1.Rows[kryptonDataGridView1.RowCount - 1].Cells["Intitulé"];
            kryptonDataGridView1.BeginEdit(true);
        }





        private void add_newBilletage(object sender, EventArgs e)
        {
            BindingList<F_BILLETPIECE> billet = (BindingList<F_BILLETPIECE>)kryptonDataGridView1.DataSource;
            List<F_BILLETPIECE> list_billet = billet.ToList();
            foreach (var row in list_billet)
            {
                if (row.cbMarq != 0)
                {
                    _fbilletageRepository.update(row.cbMarq, row.BI_Valeur, row.BI_Intitule);
                }
                else
                {
                    _fbilletageRepository.insert(row.cbMarq, row.BI_Valeur, row.BI_Intitule, _cbMarq);

                }
            }
            kryptonDataGridView1.DataSource = billet;
            MessageBox.Show("Enregistrement avec succès!");
            Close();
        }
        // =============================================================================================
        // FIN EVENEMETS =============================================================================
        // =============================================================================================
    }
}
