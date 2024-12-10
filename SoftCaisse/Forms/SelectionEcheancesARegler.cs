using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.Models;
using SoftCaisse.Repositories.BIJOU;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class SelectionEcheancesARegler : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;
        private readonly F_COMPTET _clientSelect;
        private List<P_REGLEMENT> _p_REGLEMENTs;
        private ListeSelectionEcheancesRepository listeSelectionEcheancesRepository;

        public SelectionEcheancesARegler(string ct_Num)
        {
            InitializeComponent();

            _context = new AppDbContext();

            listeSelectionEcheancesRepository = new ListeSelectionEcheancesRepository(_context);

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(panel2, 30);
            ApplyRoundedCorners(panel1, 30);

            _clientSelect = _context.F_COMPTET.Where(c => c.CT_Num == ct_Num).FirstOrDefault();

            List<string> listeOptionsEcheances = new List<string> { "Tous", "Echéances non réglées", "Echéances réglées" };
            _p_REGLEMENTs = _context.P_REGLEMENT.ToList();

            cmbBxOptEcheaches.DataSource = listeOptionsEcheances;

            afficherListeEcheances();

        }




        // =============================================================================================================================================
        // ====================================================================== FONCTIONS ============================================================

        // =============================== FONCTIONS POUR LE DESIGN ===============================
        private void ApplyRoundedCorners(Control control, int borderRadius)
        {
            control.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                    path.AddArc(new Rectangle(0, control.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                    path.CloseAllFigures();

                    control.Region = new Region(path);
                }
            };

            control.Invalidate();
        }
        // =============================== FONCTIONS POUR LE DESIGN ===============================



        private void InitDatatables()
        {
            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Echéance"));
            _bindingSource.Columns.Add(new DataColumn("N° pièce"));
            _bindingSource.Columns.Add(new DataColumn("N° client"));
            _bindingSource.Columns.Add(new DataColumn("Mode règlement"));
            _bindingSource.Columns.Add(new DataColumn("A payer"));
            _bindingSource.Columns.Add(new DataColumn("Est payé"));
            _bindingSource.Columns.Add(new DataColumn("Solde"));
        }



        private void afficherListeEcheances()
        {
            List<ListeSelectionEcheances> listeEcheances = listeSelectionEcheancesRepository.ListerEcheances(_clientSelect.CT_Num);
            if (cmbBxOptEcheaches.SelectedIndex == 0) // Option "Tous"
            {
                // Ne rien faire
            }
            else if (cmbBxOptEcheaches.SelectedIndex == 1) // Option "Echéances non réglées"
            {
                listeEcheances = listeEcheances.Where(ech => ech.DR_Regle == 0).ToList();
            }
            else // Option "Echéances réglées"
            {
                listeEcheances = listeEcheances.Where(ech => ech.DR_Regle == 1).ToList();
            }

            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Echéance"));
            _bindingSource.Columns.Add(new DataColumn("N° pièce"));
            _bindingSource.Columns.Add(new DataColumn("N° client"));
            _bindingSource.Columns.Add(new DataColumn("Mode règlement"));
            _bindingSource.Columns.Add(new DataColumn("Pourcentage"));
            _bindingSource.Columns.Add(new DataColumn("A payer"));
            _bindingSource.Columns.Add(new DataColumn("Est payé"));
            _bindingSource.Columns.Add(new DataColumn("Solde"));

            foreach (ListeSelectionEcheances echeance in listeEcheances)
            {
                _bindingSource.Rows.Add(
                    echeance.DR_Date.ToString(),
                    echeance.DO_Piece,
                    echeance.CT_NumPayeur,
                    echeance.R_Intitule,
                    echeance.DR_Pourcent,
                    echeance.A_Payer,
                    echeance.DR_Regle == 0 ? "Non" : "Oui",
                    echeance.DR_Regle == 0 ? echeance.Solde : 0
                );
            }
            dataGridView1.DataSource = _bindingSource;
        }

        // ====================================================================== FONCTIONS ============================================================
        // =============================================================================================================================================






        // ==============================================================================================================================================
        // ====================================================================== EVENEMENTS ============================================================
        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        // ==============================================================================================================================================
        // ====================================================================== EVENEMENTS ============================================================
    }
}
