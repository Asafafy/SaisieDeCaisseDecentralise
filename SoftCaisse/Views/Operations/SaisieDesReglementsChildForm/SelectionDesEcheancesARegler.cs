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
using System.Windows.Forms.VisualStyles;

namespace Soft_Caisse.Views.Operations.SaisieDesReglementsChildForm
{
    public partial class SelectionDesEcheancesARegler : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Home homeForm { get; set; }













        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public SelectionDesEcheancesARegler(Home home)
        {
            homeForm = home;

            InitializeComponent();

            textBoxMontantDuReglement.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            textBoxMontantDEcart.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);
            textBoxMontantRegle.KeyPress += new KeyPressEventHandler(TextBoxKeyPressHandler.HandleNumericOnlyKeyPress);

            textBoxMontantDuReglement.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            textBoxMontantDEcart.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);
            textBoxMontantRegle.Leave += new EventHandler(TextBoxKeyPressHandler.PreventVirguleAtTheEndOfNumber_Leave);

            BorderRadius.ApplyBorderRaduisOnPanel(panelTotal, 50);
            BorderRadius.ApplyBorderRaduisOnPanel(panelEnTete, 50);

            listBoxFiltre.Items.Add("Élément 1");
            listBoxFiltre.Items.Add("Élément 1");
            listBoxFiltre.Items.Add("Élément 1");
            listBoxFiltre.Items.Add("Élément 1");
            listBoxFiltre.Items.Add("Élément 1");
            listBoxFiltre.Items.Add("Élément 1");
            listBoxFiltre.Items.Add("Élément 1");

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");
            dataGridView1.Rows.Add("Euro", "EURO", "EURO", "hahaha...", "CAIS", "12000", "Vingt", "houhou", "Blabla");

        }


















        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnFermerActiveForm_Click(object sender, EventArgs e)
        {
            SaisieDesReglements saisieDesReglements = new SaisieDesReglements(homeForm);
            homeForm.OpenFormInPanel(saisieDesReglements);
            homeForm.formActif = saisieDesReglements;
            Close();
        }



















        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void listBoxFiltre_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Vérifier si un élément est sélectionné

            // Définir les couleurs
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(129, 166, 181) : listBoxFiltre.BackColor;
            Color foreColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.FromArgb(255, 255, 255) : listBoxFiltre.ForeColor;

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
                    listBoxFiltre.Items[e.Index].ToString(),
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



        private void SelectionDesEcheancesARegler_Load(object sender, EventArgs e)
        {
            textBoxDateDuReglement.Text = DateTime.Now.ToLongDateString();

            dateTimePickerDateReglement.Visible = false;
        }

        private void textBoxDateDuReglement_Click(object sender, EventArgs e)
        {
            dateTimePickerDateReglement.Visible = true;
            dateTimePickerDateReglement.Focus();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePickerDateReglement_ValueChanged(object sender, EventArgs e)
        {
            textBoxDateDuReglement.Text = dateTimePickerDateReglement.Value.ToLongDateString();
            dateTimePickerDateReglement.Visible = false;
        }

























        // =========================================================================================================
        // EVENEMENTS ==============================================================================================
        // =========================================================================================================















    }
}
