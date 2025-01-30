using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class ChoixCreationENUMGAMME : KryptonForm
    {

        public string Resultat { get; set; }

        public ChoixCreationENUMGAMME(string EG_Enumere)
        {
            InitializeComponent();

            string labelConfirmation = "Créer les énumérés de gamme pour les articles disposant la gamme " + EG_Enumere + " ?";

            label1.Text = labelConfirmation;
        }


        private void kptAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void kptBtnOk_Click(object sender, EventArgs e)
        {
            if (radioBtnNon.Checked)
            {
                Resultat = radioBtnNon.Text;
            }
            else if (radioBtnCreerAuto.Checked)
            {
                Resultat = radioBtnCreerAuto.Text;
            }
            else
            {
                Resultat = radioBtnCreerManuel.Text;
            }
            Close();
        }
    }
}
