using Soft_Caisse.Views.Parametres.ParametresSociete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresGammesChildForm
{
    public partial class ChoixCreationENUMGAMME : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ChoixCreationENUMGAMME(Home home)
        {
            homeForm = home;

            InitializeComponent();

            radioButtonNon.Checked = true;
        }











        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            ParametresGammes parametresGammes = new ParametresGammes(homeForm);
            homeForm.OpenFormInPanel(parametresGammes);
            homeForm.formActif = parametresGammes;
            Close();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioButtonNon.Checked)
            {
                // TODO:
            } else if (radioButtonCreerAutomatiquement.Checked)
            {
                // TODO:
            } else
            {
                CreationManuelleEnumereGamme creationManuelleEnumereGamme = new CreationManuelleEnumereGamme(homeForm);
                homeForm.OpenFormInPanel(creationManuelleEnumereGamme);
                homeForm.formActif = creationManuelleEnumereGamme;
                Close();
            }
        }
    }
}
