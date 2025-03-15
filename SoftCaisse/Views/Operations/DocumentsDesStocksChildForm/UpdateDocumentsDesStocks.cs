using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm
{
    public partial class UpdateDocumentsDesStocks : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public UpdateDocumentsDesStocks(Home home)
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
            btnFermerActiveForm_Click(sender, e);
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // ========================================================================================================= 
        private void UpdateDocumentsDesStocks_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();

            dateTimePickerDate.Visible = false;
        }

        private void textBoxDate_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Visible = true;
            dateTimePickerDate.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            textBoxDate.Text = dateTimePickerDate.Value.ToLongDateString();
            dateTimePickerDate.Visible = false;
        }









    }
}
