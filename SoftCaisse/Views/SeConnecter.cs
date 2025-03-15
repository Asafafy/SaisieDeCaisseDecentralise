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

namespace Soft_Caisse.Forms
{
    public partial class SeConnecter : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private string motDePasse = "";










        // =========================================================================================================
        // CONSTRUCTEUR DE LA CLASSE ===============================================================================
        // =========================================================================================================
        public SeConnecter()
        {
            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnButton(btnSeConnecter, 25);
            BorderRadius.ApplyBorderRaduisOnPanel(panelConteneur, 50);
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void txtBxMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Empêcher l'affichage du caractère original
            e.Handled = true;

            int positionCurseur = txtBxMotDePasse.SelectionStart; // Récupère la position actuelle du curseur

            if (!char.IsControl(e.KeyChar)) // Saisie normale
            {
                motDePasse = motDePasse.Insert(positionCurseur, e.KeyChar.ToString()); // Ajout au bon endroit
                txtBxMotDePasse.Text = new string('x', motDePasse.Length); // Affichage des *
                txtBxMotDePasse.SelectionStart = positionCurseur + 1; // Déplacer le curseur après l'ajout
            }
            else if (e.KeyChar == (char)Keys.Back && positionCurseur > 0) // Gestion du Backspace
            {
                motDePasse = motDePasse.Remove(positionCurseur - 1, 1); // Supprime le bon caractère
                txtBxMotDePasse.Text = new string('x', motDePasse.Length); // Réafficher les *
                txtBxMotDePasse.SelectionStart = positionCurseur - 1; // Déplacer le curseur après suppression
            }
            else if (e.KeyChar == (char)Keys.Delete && positionCurseur < motDePasse.Length) // Gestion du Suppr
            {
                motDePasse = motDePasse.Remove(positionCurseur, 1); // Supprime le bon caractère
                txtBxMotDePasse.Text = new string('x', motDePasse.Length); // Réafficher les *
                txtBxMotDePasse.SelectionStart = positionCurseur; // Garde le curseur au bon endroit
            }
        }



        private void btnEye_Click(object sender, EventArgs e)
        {
            txtBxMotDePasse.Text = motDePasse;
        }



        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            if (txtBxLogin.Text == "Introuvable")
            {
                MessageBox.Show("Login introuvable", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBxMotDePasse.Text == "Erreur")
            {
                MessageBox.Show("Mot de passe incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBxLogin.Text == "Admin" && motDePasse == "Admin")
            {
                MessageBox.Show("Connexion réussie", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
