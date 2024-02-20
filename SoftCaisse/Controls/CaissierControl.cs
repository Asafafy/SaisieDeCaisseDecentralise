using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Controls
{
    public partial class CaissierControl : UserControl
    {
        public CaissierControl()
        {
            InitializeComponent();
        }

        private void btnCaissierClose_Click(object sender, EventArgs e)
        {
            Form StructureCaisseForm = this.FindForm();
            if (StructureCaisseForm != null)
            {
                StructureCaisseForm.Close();
            }
        }
    }
}
