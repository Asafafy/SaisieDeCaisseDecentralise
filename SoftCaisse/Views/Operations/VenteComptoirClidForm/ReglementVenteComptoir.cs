using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations.VenteComptoirClidForm
{
    public partial class ReglementVenteComptoir : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ReglementVenteComptoir(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            VenteComptoir venteComptoir = new VenteComptoir(homeForm);
            homeForm.OpenFormInPanel(venteComptoir);
            homeForm.formActif = venteComptoir;
            Close();
        }








    }
}
