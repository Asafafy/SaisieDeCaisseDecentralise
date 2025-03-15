using Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresGammesChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Parametres.GestionDesUtilisateursChildForm
{
    public partial class CreateUpdateUtilisateurs : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }
        string motDePasse = "";










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public CreateUpdateUtilisateurs(Home home)
        {
            homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================












        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            GestionDesUtilisateurs gestionDesUtilisateurs = new GestionDesUtilisateurs(homeForm);
            homeForm.OpenFormInPanel(gestionDesUtilisateurs);
            homeForm.formActif = gestionDesUtilisateurs;
            Close();
        }



        private void txtBxMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Empêcher l'affichage du caractère original
            e.Handled = true;

            int positionCurseur = txtBxMotDePasse.SelectionStart; // Récupère la position actuelle du curseur

            if (!char.IsControl(e.KeyChar)) // Saisie normale
            {
                motDePasse = motDePasse.Insert(positionCurseur, e.KeyChar.ToString()); // Ajout au bon endroit
                txtBxMotDePasse.Text = new string('*', motDePasse.Length); // Affichage des *
                txtBxMotDePasse.SelectionStart = positionCurseur + 1; // Déplacer le curseur après l'ajout
            }
            else if (e.KeyChar == (char)Keys.Back && positionCurseur > 0) // Gestion du Backspace
            {
                motDePasse = motDePasse.Remove(positionCurseur - 1, 1); // Supprime le bon caractère
                txtBxMotDePasse.Text = new string('*', motDePasse.Length); // Réafficher les *
                txtBxMotDePasse.SelectionStart = positionCurseur - 1; // Déplacer le curseur après suppression
            }
            else if (e.KeyChar == (char)Keys.Delete && positionCurseur < motDePasse.Length) // Gestion du Suppr
            {
                motDePasse = motDePasse.Remove(positionCurseur, 1); // Supprime le bon caractère
                txtBxMotDePasse.Text = new string('*', motDePasse.Length); // Réafficher les *
                txtBxMotDePasse.SelectionStart = positionCurseur; // Garde le curseur au bon endroit
            }
        }



        private void btnEye_Click(object sender, EventArgs e)
        {
            txtBxMotDePasse.Text = motDePasse;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            motDePasse = "";
            txtBxMotDePasse.Text = "";
        }
    }
}
