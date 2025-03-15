using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations
{
    public partial class OuvertureDeCaisse : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }
        string motDePasse = "";













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public OuvertureDeCaisse(Home home)
        {
            this.homeForm = home;

            InitializeComponent();
        }










        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }










        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void OuvertureDeCaisse_Load(object sender, EventArgs e)
        {
            txtBxDateTime.Text = DateTime.Now.ToLongDateString();

            dateTimePickerCustom.Visible = false;
        }

        private void txtBxDateTime_Click(object sender, EventArgs e)
        {
            dateTimePickerCustom.Visible = true;
            dateTimePickerCustom.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerCustom_ValueChanged(object sender, EventArgs e)
        {
            txtBxDateTime.Text = dateTimePickerCustom.Value.ToLongDateString();
            dateTimePickerCustom.Visible = false;
        }

        private void txtBxMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            int positionCurseur = txtBxMotDePasse.SelectionStart;

            if (!char.IsControl(e.KeyChar)) // Saisie normale
            {
                motDePasse = motDePasse.Insert(positionCurseur, e.KeyChar.ToString());
                txtBxMotDePasse.Text = new string('*', motDePasse.Length);
                txtBxMotDePasse.SelectionStart = positionCurseur + 1;
            }
            else if (e.KeyChar == (char)Keys.Back && positionCurseur > 0)
            {
                motDePasse = motDePasse.Remove(positionCurseur - 1, 1);
                txtBxMotDePasse.Text = new string('*', motDePasse.Length);
                txtBxMotDePasse.SelectionStart = positionCurseur - 1;
            }
            else if (e.KeyChar == (char)Keys.Delete && positionCurseur < motDePasse.Length)
            {
                motDePasse = motDePasse.Remove(positionCurseur, 1);
                txtBxMotDePasse.Text = new string('*', motDePasse.Length);
                txtBxMotDePasse.SelectionStart = positionCurseur;
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










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================






    }
}
