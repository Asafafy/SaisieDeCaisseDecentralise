using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
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
