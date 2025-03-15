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

namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    public partial class ParametresGammes : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        private Home homeForm { get; set; }










        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public ParametresGammes(Home home)
        {
            homeForm = home;

            InitializeComponent();

            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");
            listBox1.Items.Add("Élément 1");

            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
            listBox2.Items.Add("Élément 1");
        }











        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Vérifier si un élément est sélectionné

            // Définir les couleurs
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(129, 166, 181) : listBox1.BackColor;
            Color foreColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(255, 255, 255) :  listBox1.ForeColor;

            // Dessiner l'arrière-plan
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            // Définir l'alignement du texte avec un padding de 30px à gauche
            using (SolidBrush textBrush = new SolidBrush(foreColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,  // Aligné à gauche
                    LineAlignment = StringAlignment.Center // Centré verticalement
                };

                // Définir la position avec un décalage de 15px vers la droite
                Rectangle textRect = new Rectangle(e.Bounds.X + 15, e.Bounds.Y, e.Bounds.Width - 15, e.Bounds.Height);

                // Dessiner le texte avec le padding
                e.Graphics.DrawString(
                    listBox1.Items[e.Index].ToString(),
                    e.Font,
                    textBrush,
                    textRect,
                    sf
                );
            }

            // Dessiner le focus rectangle si l'élément a le focus
            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                e.DrawFocusRectangle();
        }



        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Vérifier si un élément est sélectionné

            // Définir les couleurs
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(129, 166, 181) : listBox1.BackColor;
            Color foreColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(255, 255, 255) : listBox1.ForeColor;

            // Dessiner l'arrière-plan
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            // Définir l'alignement du texte avec un padding de 30px à gauche
            using (SolidBrush textBrush = new SolidBrush(foreColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,  // Aligné à gauche
                    LineAlignment = StringAlignment.Center // Centré verticalement
                };

                // Définir la position avec un décalage de 15px vers la droite
                Rectangle textRect = new Rectangle(e.Bounds.X + 15, e.Bounds.Y, e.Bounds.Width - 15, e.Bounds.Height);

                // Dessiner le texte avec le padding
                e.Graphics.DrawString(
                    listBox2.Items[e.Index].ToString(),
                    e.Font,
                    textBrush,
                    textRect,
                    sf
                );
            }

            // Dessiner le focus rectangle si l'élément a le focus
            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                e.DrawFocusRectangle();
        }










        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            homeForm.formActif = null;
            homeForm.ShowBackgroundImage();
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ChoixCreationENUMGAMME choixCreationENUMGAMME = new ChoixCreationENUMGAMME(homeForm);
            homeForm.OpenFormInPanel(choixCreationENUMGAMME);
            homeForm.formActif = choixCreationENUMGAMME;
            Close();
        }
    }
}
