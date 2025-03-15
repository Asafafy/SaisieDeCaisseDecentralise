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
    public partial class RappelDocumentsEnAttente : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public RappelDocumentsEnAttente(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
            dataGridView1.Rows.Add("Caisse 1", "FA00009", "10/03/2025", "14:15:13", "Caissier");
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

        private void btnRappeler_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                VenteComptoir venteComptoir = new VenteComptoir(homeForm);
                homeForm.OpenFormInPanel(venteComptoir);
                homeForm.formActif = venteComptoir;
                Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRappeler_Click(sender, e);
        }












        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================










    }
}
