using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class NouveauDocumentDeVente : KryptonForm
    {
        private readonly AppDbContext _context;

        // ================================================ DEBUT CONSTRUCTEUR ================================================
        // ====================================================================================================================
        public NouveauDocumentDeVente()
        {
            InitializeComponent();

            _context = new AppDbContext();

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(tableLayoutPanel4, 30);
            ApplyRoundedCorners(tableLayoutPanel5, 30);

            List<F_COMPTET> listeClients = _context.F_COMPTET.ToList();
            List<F_COMPTEA> listePlanAnalitique = _context.F_COMPTEA.ToList();
            List<P_EXPEDITION> listeExpedit = _context.P_EXPEDITION.ToList();
            List<F_COLLABORATEUR> listeCollab = _context.F_COLLABORATEUR.ToList();

            comboBoxClient.DataSource = listeClients.Select(c => c.CT_Num + " - " + c.CT_Intitule).ToList();
            comboBoxClient.SelectedIndex = -1;
            comboBoxStatus.Text = "A comptabiliser";
            comboBoxAffaire.DataSource = listePlanAnalitique.Where(p => p.N_Analytique == 3).Select(p => p.CA_Num + " - " + p.CA_Intitule).ToList();
            comboBoxExpedit.DataSource = listeExpedit.Select(ex => ex.E_Intitule).ToList();
            comboBoxRepresentant.DataSource = listeCollab.Where(c => c.CO_Vendeur == 1).Select(c => c.CO_Nom + " - " + c.CO_Prenom).ToList();

            kptnBtnValider.Enabled = false;

        }
        // ================================================ FIN CONSTRUCTEUR ================================================
        // ==================================================================================================================





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
        // ================================================ FIN FONCTIONS ================================================
        // =================================================================================================================





        // ================================================ DEBUT EVENEMENTS =================================================
        // ===================================================================================================================
        private void kptAnnuler_Click(object sender, System.EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Confirmez vous l'annulation de cette facture ?", "Confirmation d'annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxClient.SelectedIndex == -1)
            {
                kptnBtnValider.Enabled = false;
            }
            else
            {
                kptnBtnValider.Enabled = true;

            }
        }

        private void kptnBtnValider_Click(object sender, System.EventArgs e)
        {

        }
        // ================================================ FIN EVENEMENTS ===================================================
        // ===================================================================================================================
    }
}
