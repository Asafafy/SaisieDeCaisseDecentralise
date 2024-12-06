using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
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

        public SelectionEcheancesARegler(string ct_Num)
        {
            InitializeComponent();

            _context = new AppDbContext();

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(panel2, 30);
            ApplyRoundedCorners(panel1, 30);

            _clientSelect = _context.F_COMPTET.Where(c => c.CT_Num == ct_Num).FirstOrDefault();

            List<string> listeOptionsEcheances = new List<string> { "Tous", "Echéances non réglées", "Echéances réglées" };
            _p_REGLEMENTs = _context.P_REGLEMENT.ToList();

            cmbBxOptEcheaches.DataSource = listeOptionsEcheances;

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
            _bindingSource.Columns.Add(new DataColumn("Devise"));
            _bindingSource.Columns.Add(new DataColumn("P"));
            _bindingSource.Columns.Add(new DataColumn("Solde"));
            _bindingSource.Columns.Add(new DataColumn("Règlement"));
        }


        private void afficherListeEcheances()
        {
            List<F_DOCENTETE> listeEcheances = _context.F_DOCENTETE.Where(ech => ech.DO_Tiers == _clientSelect.CT_Num && ech.DO_Piece.StartsWith("FA")).ToList();
            if (cmbBxOptEcheaches.SelectedIndex == 0) // Option "Tous"
            {
                // Ne rien faire.
            }
            else if (cmbBxOptEcheaches.SelectedIndex == 1) // Option "Echéances non réglées"
            {
                listeEcheances.Where(ech => ech.DO_MontantRegle < ech.DO_NetAPayer).ToList();
            }
            else // Option "Echéances réglées"
            {
                listeEcheances.Where(ech => ech.DO_MontantRegle == ech.DO_NetAPayer).ToList();
            }

            InitDatatables();

            foreach (F_DOCENTETE echeance in listeEcheances)
            {
                F_DOCREGL f_DOCREGL = _context.F_DOCREGL.Where(dr => dr.DO_Piece == echeance.DO_Piece).FirstOrDefault();
                F_REGLECH f_REGLECH = _context.F_REGLECH.Where(r => r.DO_Piece == echeance.DO_Piece).FirstOrDefault();
                _bindingSource.Rows.Add(
                    f_DOCREGL.DR_Date.ToString(),
                    echeance.DO_Piece,
                    echeance.CT_NumPayeur,
                    _p_REGLEMENTs.Where(r => r.cbIndice == f_DOCREGL.N_Reglement).Select(r => r.R_Intitule).FirstOrDefault()


                );
            }
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
