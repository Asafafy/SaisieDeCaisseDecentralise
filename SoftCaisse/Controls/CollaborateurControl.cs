using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace SoftCaisse.Controls
{
    public partial class CollaborateurControl : UserControl
    {
        public CollaborateurControl()
        {
            InitializeComponent();
            
        }

        private void btnCollaboClose_Click(object sender, EventArgs e)
        {
            Form StructureCaisseForm = this.FindForm();
            if (StructureCaisseForm != null)
            {
                StructureCaisseForm.Close();
            }
        }
    }
}
