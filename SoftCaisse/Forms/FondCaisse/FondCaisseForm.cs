using System;
using ComponentFactory.Krypton.Toolkit;
namespace SoftCaisse.Forms.FondCaisse
{
    public partial class FondCaisseForm : KryptonForm
    {
        public FondCaisseForm()
        {
            InitializeComponent();
        }

        private void btnFondCaisseClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Parent = null;
        }
    }
}
