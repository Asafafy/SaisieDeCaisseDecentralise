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

namespace Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm
{
    public partial class CreateDocumentsDesStocks : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateDocumentsDesStocks(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }











        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            DocumentsDesStocks documentsDesStocks = new DocumentsDesStocks(homeForm);
            homeForm.OpenFormInPanel(documentsDesStocks);
            homeForm.formActif = documentsDesStocks;
            Close();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            btnFermerActiveForm_Click((object)sender, e);
        }












        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void CreateDocumentsDesStocks_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();

            dateTimePicker1.Visible = false;
        }

        private void textBoxDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker1.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxDate.Text = dateTimePicker1.Value.ToLongDateString();
            dateTimePicker1.Visible = false;
        }












        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================










    }
}
