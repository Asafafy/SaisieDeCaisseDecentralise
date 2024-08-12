using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SoftCaisse.Forms.Article
{
    public partial class DetailsArticle : KryptonForm
    {
        private readonly AppDbContext _context;

        private DataTable _bindingSource;

        public DetailsArticle()
        {
            InitializeComponent();

            //TabControl du "Champs libres" Tab
            btnInfosLibres.Click += (sender, e) => SelectTabChampsLibres(0, btnInfosLibres);
            btnChampsStatistiques.Click += (sender, e) => SelectTabChampsLibres(1, btnChampsStatistiques);
            btnChampsAttaches.Click += (sender, e) => SelectTabChampsLibres(2, btnChampsAttaches);
            btnPhoto.Click += (sender, e) => SelectTabChampsLibres(3, btnPhoto);
            SelectTabChampsLibres(0, btnInfosLibres);

            //TabControl du "Paramètres" Tab
            btnOptTraitement.Click += (sender, e) => SelectTabParametres(0, btnOptTraitement);
            btnLogistique.Click += (sender, e) => SelectTabParametres(1, btnLogistique);
            btnDepot.Click += (sender, e) => SelectTabParametres(2, btnDepot);
            btnComptabilite.Click += (sender, e) => SelectTabParametres(3, btnComptabilite);
            btnGestProd.Click += (sender, e) => SelectTabParametres(4, btnGestProd);
            SelectTabParametres(0, btnOptTraitement);

        }

        // HOVER EFFECT TROIS BOUTONS DE NAVBAR
        private void btnNomenclature_MouseHover(object sender, System.EventArgs e)
        {
            btnNomenclature.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 234, 247);
        }
        private void btnInterroger_MouseHover(object sender, System.EventArgs e)
        {
            btnInterroger.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 234, 247);
        }
        private void btnTracabilite_MouseHover(object sender, System.EventArgs e)
        {
            btnTracabilite.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 204, 234, 247);
        }

        // NAVIGATIONS ENTRE TABS VIA BOUTONS (TAB "CHAMPS LIBRES")
        private void SelectTabChampsLibres(int tabIndex, Button activeButton)
        {
            tabControl3.SelectedIndex = tabIndex;
            btnInfosLibres.BackColor = SystemColors.Control;
            btnChampsStatistiques.BackColor = SystemColors.Control;
            btnChampsAttaches.BackColor = SystemColors.Control;
            btnPhoto.BackColor = SystemColors.Control;
            activeButton.BackColor = Color.LightBlue;
        }

        // NAVIGATIONS ENTRE TABS VIA BOUTONS (TAB "PARAMETRES")
        private void SelectTabParametres(int tabIndex, Button activeButton)
        {
            tabControl4.SelectedIndex = tabIndex;
            btnOptTraitement.BackColor = SystemColors.Control;
            btnLogistique.BackColor = SystemColors.Control;
            btnDepot.BackColor = SystemColors.Control;
            btnComptabilite.BackColor = SystemColors.Control;
            btnGestProd.BackColor = SystemColors.Control;
            activeButton.BackColor = Color.LightBlue;
        }
    }
}
