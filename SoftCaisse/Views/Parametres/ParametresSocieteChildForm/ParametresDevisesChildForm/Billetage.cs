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

namespace Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresDevisesChildForm
{
    public partial class Billetage : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public Billetage(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            ParametresDevises parametresDevises = new ParametresDevises(homeForm);
            homeForm.OpenFormInPanel(parametresDevises);
            homeForm.formActif = parametresDevises;
            Close();
        }
    }
}
