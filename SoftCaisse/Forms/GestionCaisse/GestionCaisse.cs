using System;
using ComponentFactory.Krypton.Toolkit;
namespace SoftCaisse.Forms.GestionCaisse
{
    public partial class GestionCaisse : KryptonForm
    {
        public GestionCaisse()
        {
            InitializeComponent();
        }

        private void btnGestionCaisseClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Parent = null;
        }
    }
}
