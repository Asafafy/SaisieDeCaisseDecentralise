using Soft_Caisse.Views.FonctionsViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations
{
    public partial class MouvementDeCaisse : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public MouvementDeCaisse(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }











        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void MouvementDeCaisse_Load(object sender, EventArgs e)
        {
            textBoxDateTime.Text = DateTime.Now.ToLongDateString();

            dateTimePickerCustom.Visible = false;
        }

        private void textBoxDateTime_Click(object sender, EventArgs e)
        {
            dateTimePickerCustom.Visible = true;
            dateTimePickerCustom.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerCustom_ValueChanged_1(object sender, EventArgs e)
        {
            textBoxDateTime.Text = dateTimePickerCustom.Value.ToLongDateString();
            dateTimePickerCustom.Visible = false;
        }
















        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================













    }
}
