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
namespace SoftCaisse.Forms.OuvertureCaisse
{
    public partial class OuvertureCaisseForm : KryptonForm
    {
        public OuvertureCaisseForm()
        {
            InitializeComponent();
        }

        private void btnOuvrCaisseClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Parent = null;
        }
    }
}
