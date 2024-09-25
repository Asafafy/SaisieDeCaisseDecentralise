using System;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
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
            this.Parent = null;
        }
    }
}
