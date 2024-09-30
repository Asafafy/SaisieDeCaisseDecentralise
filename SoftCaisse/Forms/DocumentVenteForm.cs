using ComponentFactory.Krypton.Toolkit;
using System;
namespace SoftCaisse.Forms.DocumentVente
{
    public partial class DocumentVenteForm : KryptonForm
    {
        public DocumentVenteForm()
        {
            InitializeComponent();
        }

        private void btnCloseDocVentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Parent = null;
        }
    }
}
