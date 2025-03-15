using System.Drawing;
using System.Windows.Forms;











namespace Soft_Caisse.Views.Operations.DocumentsDesVentesChildForm
{
    partial class ChoixCreationDocumentDeVente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButtonFactureDAvoir = new RadioButton();
            radioButtonFactureDeRetour = new RadioButton();
            radioButtonFacture = new RadioButton();
            radioButtonBonDAvoirFinancier = new RadioButton();
            radioButtonBonDeRetour = new RadioButton();
            radioButtonBonDeLivraison = new RadioButton();
            radioButtonPreparationDeLivraison = new RadioButton();
            radioButtonBonDeCommande = new RadioButton();
            radioButtonDevis = new RadioButton();
            btnOK = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 469);
            panel1.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(234, 15);
            label1.TabIndex = 1;
            label1.Text = "Veuillez choisir le type de document à créer";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(radioButtonFactureDAvoir, 0, 8);
            tableLayoutPanel1.Controls.Add(radioButtonFactureDeRetour, 0, 7);
            tableLayoutPanel1.Controls.Add(radioButtonFacture, 0, 6);
            tableLayoutPanel1.Controls.Add(radioButtonBonDAvoirFinancier, 0, 5);
            tableLayoutPanel1.Controls.Add(radioButtonBonDeRetour, 0, 4);
            tableLayoutPanel1.Controls.Add(radioButtonBonDeLivraison, 0, 3);
            tableLayoutPanel1.Controls.Add(radioButtonPreparationDeLivraison, 0, 2);
            tableLayoutPanel1.Controls.Add(radioButtonBonDeCommande, 0, 1);
            tableLayoutPanel1.Controls.Add(radioButtonDevis, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(288, 363);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonFactureDAvoir
            // 
            radioButtonFactureDAvoir.AutoSize = true;
            radioButtonFactureDAvoir.Location = new Point(3, 323);
            radioButtonFactureDAvoir.Name = "radioButtonFactureDAvoir";
            radioButtonFactureDAvoir.Size = new Size(103, 19);
            radioButtonFactureDAvoir.TabIndex = 8;
            radioButtonFactureDAvoir.TabStop = true;
            radioButtonFactureDAvoir.Text = "Facture d'avoir";
            radioButtonFactureDAvoir.UseVisualStyleBackColor = true;
            // 
            // radioButtonFactureDeRetour
            // 
            radioButtonFactureDeRetour.AutoSize = true;
            radioButtonFactureDeRetour.Location = new Point(3, 283);
            radioButtonFactureDeRetour.Name = "radioButtonFactureDeRetour";
            radioButtonFactureDeRetour.Size = new Size(115, 19);
            radioButtonFactureDeRetour.TabIndex = 7;
            radioButtonFactureDeRetour.TabStop = true;
            radioButtonFactureDeRetour.Text = "Facture de retour";
            radioButtonFactureDeRetour.UseVisualStyleBackColor = true;
            // 
            // radioButtonFacture
            // 
            radioButtonFacture.AutoSize = true;
            radioButtonFacture.Location = new Point(3, 243);
            radioButtonFacture.Name = "radioButtonFacture";
            radioButtonFacture.Size = new Size(64, 19);
            radioButtonFacture.TabIndex = 6;
            radioButtonFacture.TabStop = true;
            radioButtonFacture.Text = "Facture";
            radioButtonFacture.UseVisualStyleBackColor = true;
            // 
            // radioButtonBonDAvoirFinancier
            // 
            radioButtonBonDAvoirFinancier.AutoSize = true;
            radioButtonBonDAvoirFinancier.Location = new Point(3, 203);
            radioButtonBonDAvoirFinancier.Name = "radioButtonBonDAvoirFinancier";
            radioButtonBonDAvoirFinancier.Size = new Size(137, 19);
            radioButtonBonDAvoirFinancier.TabIndex = 5;
            radioButtonBonDAvoirFinancier.TabStop = true;
            radioButtonBonDAvoirFinancier.Text = "Bon d'avoir finanicier";
            radioButtonBonDAvoirFinancier.UseVisualStyleBackColor = true;
            // 
            // radioButtonBonDeRetour
            // 
            radioButtonBonDeRetour.AutoSize = true;
            radioButtonBonDeRetour.Location = new Point(3, 163);
            radioButtonBonDeRetour.Name = "radioButtonBonDeRetour";
            radioButtonBonDeRetour.Size = new Size(97, 19);
            radioButtonBonDeRetour.TabIndex = 4;
            radioButtonBonDeRetour.TabStop = true;
            radioButtonBonDeRetour.Text = "Bon de retour";
            radioButtonBonDeRetour.UseVisualStyleBackColor = true;
            // 
            // radioButtonBonDeLivraison
            // 
            radioButtonBonDeLivraison.AutoSize = true;
            radioButtonBonDeLivraison.Location = new Point(3, 123);
            radioButtonBonDeLivraison.Name = "radioButtonBonDeLivraison";
            radioButtonBonDeLivraison.Size = new Size(109, 19);
            radioButtonBonDeLivraison.TabIndex = 3;
            radioButtonBonDeLivraison.TabStop = true;
            radioButtonBonDeLivraison.Text = "Bon de livraison";
            radioButtonBonDeLivraison.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreparationDeLivraison
            // 
            radioButtonPreparationDeLivraison.AutoSize = true;
            radioButtonPreparationDeLivraison.Location = new Point(3, 83);
            radioButtonPreparationDeLivraison.Name = "radioButtonPreparationDeLivraison";
            radioButtonPreparationDeLivraison.Size = new Size(149, 19);
            radioButtonPreparationDeLivraison.TabIndex = 2;
            radioButtonPreparationDeLivraison.TabStop = true;
            radioButtonPreparationDeLivraison.Text = "Préparation de livraison";
            radioButtonPreparationDeLivraison.UseVisualStyleBackColor = true;
            // 
            // radioButtonBonDeCommande
            // 
            radioButtonBonDeCommande.AutoSize = true;
            radioButtonBonDeCommande.Location = new Point(3, 43);
            radioButtonBonDeCommande.Name = "radioButtonBonDeCommande";
            radioButtonBonDeCommande.Size = new Size(126, 19);
            radioButtonBonDeCommande.TabIndex = 1;
            radioButtonBonDeCommande.TabStop = true;
            radioButtonBonDeCommande.Text = "Bon de commande";
            radioButtonBonDeCommande.UseVisualStyleBackColor = true;
            // 
            // radioButtonDevis
            // 
            radioButtonDevis.AutoSize = true;
            radioButtonDevis.Location = new Point(3, 3);
            radioButtonDevis.Name = "radioButtonDevis";
            radioButtonDevis.Size = new Size(53, 19);
            radioButtonDevis.TabIndex = 0;
            radioButtonDevis.TabStop = true;
            radioButtonDevis.Text = "Devis";
            radioButtonDevis.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.BackColor = Color.FromArgb(129, 166, 181);
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 11F);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(201, 541);
            btnOK.Margin = new Padding(144, 3, 144, 3);
            btnOK.Name = "btnOK";
            btnOK.Padding = new Padding(8, 0, 0, 0);
            btnOK.Size = new Size(190, 45);
            btnOK.TabIndex = 31;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // iconButtonFermer
            // 
            iconButtonFermer.BackColor = Color.FromArgb(84, 138, 178);
            iconButtonFermer.Cursor = Cursors.Hand;
            iconButtonFermer.FlatAppearance.BorderColor = Color.FromArgb(29, 64, 102);
            iconButtonFermer.FlatAppearance.BorderSize = 0;
            iconButtonFermer.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButtonFermer.IconColor = Color.White;
            iconButtonFermer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonFermer.IconSize = 33;
            iconButtonFermer.Location = new Point(397, 4);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 56;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ChoixCreationDocumentDeVente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(445, 598);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel1);
            Controls.Add(btnOK);
            Name = "ChoixCreationDocumentDeVente";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Choix du document de vente à créer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButtonBonDeCommande;
        private RadioButton radioButtonDevis;
        private Button btnOK;
        private RadioButton radioButtonFactureDAvoir;
        private RadioButton radioButtonFactureDeRetour;
        private RadioButton radioButtonFacture;
        private RadioButton radioButtonBonDAvoirFinancier;
        private RadioButton radioButtonBonDeRetour;
        private RadioButton radioButtonBonDeLivraison;
        private RadioButton radioButtonPreparationDeLivraison;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}