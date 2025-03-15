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

namespace Soft_Caisse.Views.Donnees.CaissesChildForm
{
    public partial class CreateUpdateCaisse : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }









        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateUpdateCaisse(Home home)
        {
            homeForm = home;

            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add(true, "Paramètres");
            dataGridView1.Rows.Add(true, "Paramètres de la base");
            dataGridView1.Rows.Add(true, "Paramètres société");
            dataGridView1.Rows.Add(true, "Gestion des utilisateurs");
            dataGridView1.Rows.Add(true, "Gestion des rôles");
            dataGridView1.Rows.Add(true, "Données");
            dataGridView1.Rows.Add(true, "Articles");
            dataGridView1.Rows.Add(true, "Caisses");
            dataGridView1.Rows.Add(true, "Clients");
            dataGridView1.Rows.Add(true, "Collaborateurs");
            dataGridView1.Rows.Add(true, "Familles");
            dataGridView1.Rows.Add(true, "Opérations");
            dataGridView1.Rows.Add(true, "Ouverture de caisse");
            dataGridView1.Rows.Add(true, "Vente comptoir");
            dataGridView1.Rows.Add(true, "Mouvements de caisse");
            dataGridView1.Rows.Add(true, "Fermeture de caisse");
            dataGridView1.Rows.Add(true, "Documents des stocks");
            dataGridView1.Rows.Add(true, "Documents des ventes");
            dataGridView1.Rows.Add(true, "Saisie des règlements");
            dataGridView1.Rows.Add(true, "Clôture des caisses");
            dataGridView1.Rows.Add(true, "Statistiques");
        }









        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            Caisses caisses = new Caisses(homeForm);
            homeForm.OpenFormInPanel(caisses);
            homeForm.formActif = caisses;
            Close();
        }












    }
}
