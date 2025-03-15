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
using System.Windows.Forms.VisualStyles;

namespace Soft_Caisse.Views.Statistiques
{
    public partial class StatistiquesDesCaisses : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }












        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public StatistiquesDesCaisses(Home home)
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
        private void StatistiquesDesCaisses_Load(object sender, EventArgs e)
        {
            textBoxDateDe.Text = GetDateExtensions.GetFirstDayOfMonth().ToLongDateString();
            textBoxDateA.Text = GetDateExtensions.GetLastDayOfMonth().ToLongDateString();

            dateTimePickerDateDebut.Visible = false;
            dateTimePickerDateFin.Visible = false;
        }

        private void textBoxDateDe_Click(object sender, EventArgs e)
        {
            dateTimePickerDateDebut.Visible = true;
            dateTimePickerDateDebut.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void textBoxDateA_Click(object sender, EventArgs e)
        {
            dateTimePickerDateFin.Visible = true;
            dateTimePickerDateFin.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerDateDebut_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateDe.Text = dateTimePickerDateDebut.Value.ToLongDateString();
            dateTimePickerDateDebut.Visible = false;
        }

        private void dateTimePickerDateFin_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateA.Text = dateTimePickerDateFin.Value.ToLongDateString();
            dateTimePickerDateFin.Visible = false;
        }













        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================













    }
}
