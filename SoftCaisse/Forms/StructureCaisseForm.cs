using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace SoftCaisse.Forms.StructureCaisse
{
    public partial class StructureCaisseForm : KryptonForm
    {
        public StructureCaisseForm()
        {
            InitializeComponent();
        }

        private void StructureCaisseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
