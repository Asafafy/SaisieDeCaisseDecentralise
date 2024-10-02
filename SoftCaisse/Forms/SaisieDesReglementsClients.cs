using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class SaisieDesReglementsClients : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;

        // =============================== CONSTRUCTEUR ===============================
        public SaisieDesReglementsClients()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Date"));
            _bindingSource.Columns.Add(new DataColumn("Caisse"));
            _bindingSource.Columns.Add(new DataColumn("Caissier"));
            _bindingSource.Columns.Add(new DataColumn("N° pièce"));
            _bindingSource.Columns.Add(new DataColumn("Type"));
            _bindingSource.Columns.Add(new DataColumn("Libellé"));
            _bindingSource.Columns.Add(new DataColumn("Référence"));
            _bindingSource.Columns.Add(new DataColumn("Mode règlement"));
            _bindingSource.Columns.Add(new DataColumn("N° tiers origine"));
            _bindingSource.Columns.Add(new DataColumn("Intitulé tiers origine"));
            _bindingSource.Columns.Add(new DataColumn("Compte général"));
            _bindingSource.Columns.Add(new DataColumn("Montant"));
            _bindingSource.Columns.Add(new DataColumn("Devise"));
            _bindingSource.Columns.Add(new DataColumn("Cours"));
            _bindingSource.Columns.Add(new DataColumn("Montant devise"));
            _bindingSource.Columns.Add(new DataColumn("Code journal"));
            _bindingSource.Columns.Add(new DataColumn("Date impayé"));
            _bindingSource.Columns.Add(new DataColumn("Contrepartie"));
            _bindingSource.Columns.Add(new DataColumn("Etat"));
            _bindingSource.Columns.Add(new DataColumn("Solde"));
            _bindingSource.Columns.Add(new DataColumn("Clôturé"));
            _bindingSource.Columns.Add(new DataColumn("Mise en banque"));
            _bindingSource.Columns.Add(new DataColumn("Echéance contrepartie"));
            _bindingSource.Columns.Add(new DataColumn("Validé"));
            _bindingSource.Columns.Add(new DataColumn("Imputé antérieur"));
            _bindingSource.Columns.Add(new DataColumn("Commission"));
            _bindingSource.Columns.Add(new DataColumn("Montant net"));



            ApplyRoundedCorners(tableLayoutPanel1, 30);
            ApplyRoundedCorners(tableLayoutPanel12, 30);
            ApplyRoundedCorners(panel2, 30);

            List<F_COMPTET> listeClients = _context.F_COMPTET.OrderBy(c => c.CT_Num).ToList();

            comboBox3.DataSource = listeClients.Select(c => c.CT_Num + " - " + c.CT_Intitule).ToList();
            comboBox3.SelectedIndex = -1;
        }




        // ================================================ DEBUT FONCTIONS ================================================
        // =================================================================================================================
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




        // =============================== EVENEMENTS ===============================
        private void btnNomenclature_Click(object sender, System.EventArgs e)
        {
            HistoriqueReglements historiqueReglements = new HistoriqueReglements();
            historiqueReglements.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SelectionEcheancesARegler selectionEcheancesARegler = new SelectionEcheancesARegler();
            selectionEcheancesARegler.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            EcheancesRattacheesAuxReglements echeancesRattacheesAuxReglements = new EcheancesRattacheesAuxReglements();
            echeancesRattacheesAuxReglements.Show();
        }

        private void kryptonButton3_Click(object sender, System.EventArgs e)
        {
            NouveauReglement nouveauReglement = new NouveauReglement();
            nouveauReglement.Show();
        }
    }
}
