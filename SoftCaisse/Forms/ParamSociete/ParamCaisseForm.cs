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
using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Forms.ParamSociete
{
    public partial class ParamCaisseForm : KryptonForm
    {

        public ParamCaisseForm()
        {
            InitializeComponent();
        }

        private void ParamCaisse_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
