using SoftCaisse.Utils.Controls;
using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace SoftCaisse.Forms.ParamSociete
{
    public partial class ParamSocForm : KryptonForm
    {
        //Définition des contrôles
        Controls.CaisseControl caisseControl = new Controls.CaisseControl();
        Controls.DeviseControl deviseControl = new Controls.DeviseControl();
        
        public ParamSocForm()
        {
            InitializeComponent();
        }

        private void CaissesParam_MouseMove(object sender, MouseEventArgs e)
        {
            CaissesParam.Cursor = Cursors.Hand;
        }

        private void DevisesParam_MouseMove(object sender, MouseEventArgs e)
        {
            DevisesParam.Cursor = Cursors.Hand;
        }

        private void CaissesParam_Click(object sender, EventArgs e)
        {
            ParamCaisseForm paramCaisse = new ParamCaisseForm();
            AddControl.ToForm(paramCaisse, caisseControl);
        }

        private void DevisesParam_Click(object sender, EventArgs e)
        {
            ParamCaisseForm paramDevise = new ParamCaisseForm();
            AddControl.ToForm(paramDevise, deviseControl);
        }
       
    }
}
