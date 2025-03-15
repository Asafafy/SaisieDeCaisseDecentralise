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

namespace Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm
{
    public partial class ChoixCreationMouvementsDesStocks : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ChoixCreationMouvementsDesStocks(Home home)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            CreateDocumentsDesStocks createDocumentsDesStocks = new CreateDocumentsDesStocks(homeForm);
            homeForm.OpenFormInPanel(createDocumentsDesStocks);
            homeForm.formActif = createDocumentsDesStocks;
            Close();
        }
    }
}
