using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    public partial class ParametresComptabilisation : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ParametresComptabilisation(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }

        private void btnBilletage_Click(object sender, EventArgs e)
        {
            // TODO: Enregistrement des modifications

            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }



        private void checkBoxComptabiliserLesMouvementsDeCaisse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComptabiliserLesMouvementsDeCaisse.Checked == true)
            {
                groupBoxComptabilisationMouvementsDeCaisse.Enabled = true;
                cmbBxCompteDebit.Visible = true;
                cmbBxCompteCredit.Visible = true;
            } else
            {
                groupBoxComptabilisationMouvementsDeCaisse.Enabled = false;
                cmbBxCompteDebit.Visible = false;
                cmbBxCompteCredit.Visible = false;
            }
        }
    }
}
