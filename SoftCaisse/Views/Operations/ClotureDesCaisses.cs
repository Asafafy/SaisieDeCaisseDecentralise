using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Soft_Caisse.Views.Operations
{
    public partial class ClotureDesCaisses : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }











        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ClotureDesCaisses(Home home)
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
        private void ClotureDesCaisses_Load(object sender, EventArgs e)
        {
            textBoxDateCloture.Text = DateTime.Now.ToLongDateString();

            dateTimePickerDateCloture.Visible = false;
        }

        private void textBoxDateCloture_Click(object sender, EventArgs e)
        {
            dateTimePickerDateCloture.Visible = true;
            dateTimePickerDateCloture.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerDateCloture_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateCloture.Text = dateTimePickerDateCloture.Value.ToLongDateString();
            dateTimePickerDateCloture.Visible = false;
        }
















    }
}
