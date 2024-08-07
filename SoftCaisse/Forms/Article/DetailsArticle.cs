using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace SoftCaisse.Forms.Article
{
    public partial class DetailsArticle : KryptonForm
    {
        public DetailsArticle()
        {
            InitializeComponent();
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
    }
}
