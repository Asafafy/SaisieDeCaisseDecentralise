using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SoftCaisse.Forms.ParamSociete
{
    public partial class ParamCaisseForm : KryptonForm
    {

        public ParamCaisseForm()
        {
            InitializeComponent();
        }

        private void ParamCaisse_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
