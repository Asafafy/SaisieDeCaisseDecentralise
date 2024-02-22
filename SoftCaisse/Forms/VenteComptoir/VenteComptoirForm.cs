using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.Article;
namespace SoftCaisse.Forms.VenteComptoir
{
    public partial class VenteComptoirForm : KryptonForm
    {
        public VenteComptoirForm()
        {
            InitializeComponent();
        }

        private void ButtonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            ButtonFinDeSaisie.Enabled = true;
            ButtonSupprimerDesignation.Enabled = true;
            ButtonCreerDoc.Enabled = false;
            ButtonRappelTicket.Enabled = false;
            ButtonTicket.Enabled = false;
            ButtonEnAttente.Enabled = true;
            ButtonFinDeSaisie.Enabled = true;

        }

        private void ButtonEnregistrerEnregistrement_Click(object sender, EventArgs e)
        {
            ButtonSupprimerEnregistrement.Enabled = true;
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            ButtonAnnuler.Enabled=true;
            ButtonCreerDoc.Enabled = true;
            ButtonRappelTicket.Enabled = true;
            ButtonTicket.Enabled = false;
            ButtonEnAttente.Enabled = false;
           // ButtonFinDeSaisie.Enabled = true;
            ButtonRaccourci.Enabled = true;
            ButtonValider.Enabled = false;
            ButtonFacture.Enabled = false;

            groupBoxInvisibleEnregistrement.Visible = false;
            dataGridViewEnregistrement.Dock = DockStyle.Fill;

        }

        private void textBoxReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ArticleARechercher articleARechercher = new ArticleARechercher();
                articleARechercher.ShowDialog(this);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFinDeSaisie_Click(object sender, EventArgs e)
        {
            dataGridViewEnregistrement.Dock = DockStyle.Bottom;
            dataGridViewEnregistrement.Width = 627;
            dataGridViewEnregistrement.Height = 153;

            groupBoxInvisibleEnregistrement.Visible = true;
            dataGridViewEnregistrement.Enabled = true;

            ButtonFinDeSaisie.Enabled = false;
            ButtonAnnuler.Enabled = true;
            ButtonEnAttente.Enabled=true;
            ButtonRaccourci.Enabled=true;
            ButtonValider.Enabled=true;
            ButtonFacture.Enabled=true;

        }
    }
}
