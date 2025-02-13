using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class ChoixSuppressionENUMGAMMEDansDetailsArticle : KryptonForm
    {
        public bool? estGamme2 { get; set; }

        public ChoixSuppressionENUMGAMMEDansDetailsArticle()
        {
            InitializeComponent();

            estGamme2 = null;
        }










        private void btnSupprimerLEnumere1_Click(object sender, EventArgs e)
        {
            estGamme2 = false;
            Close();
        }





        private void btnSupprimerLEnumere2_Click(object sender, EventArgs e)
        {
            estGamme2 = true;
            Close();
        }
    }
}
