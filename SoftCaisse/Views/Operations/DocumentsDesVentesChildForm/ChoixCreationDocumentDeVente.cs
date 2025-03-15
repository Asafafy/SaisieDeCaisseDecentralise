using Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations.DocumentsDesVentesChildForm
{
    public partial class ChoixCreationDocumentDeVente : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ChoixCreationDocumentDeVente(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            DocumentsDesVentes documentsDesVentes = new DocumentsDesVentes(homeForm);
            homeForm.OpenFormInPanel(documentsDesVentes);
            homeForm.formActif = documentsDesVentes;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CreateDocumentDeVente createDocumentDeVente = new CreateDocumentDeVente(homeForm);
            homeForm.OpenFormInPanel(createDocumentDeVente);
            homeForm.formActif = createDocumentDeVente;
            Close();
        }
    }
}
