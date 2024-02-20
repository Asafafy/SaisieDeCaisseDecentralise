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
    public partial class DeviseControl : UserControl
    {
        public DeviseControl()
        {
            InitializeComponent();
        }

        private void btnDeviseClose_Click(object sender, EventArgs e)
        {

            Form ParamCaisseForm = this.FindForm();
            if (ParamCaisseForm != null)
            {
                ParamCaisseForm.Close();
            }
        }
    }
}
