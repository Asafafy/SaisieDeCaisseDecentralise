using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class ChoixInformationsArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixInformationsArticle));
            panelContainerBoutons = new Panel();
            btnInterrogationDuStock = new Button();
            lblInterrogationDuStock = new Label();
            btnMedias = new Button();
            lblMedias = new Label();
            btnTarifs = new Button();
            lblTarifs = new Label();
            btnGammes = new Button();
            lblGammes = new Label();
            btnConditionnement = new Button();
            lblConditionnement = new Label();
            btnInformations = new Button();
            lblInformations = new Label();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            panelContainerBoutons.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainerBoutons
            // 
            panelContainerBoutons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainerBoutons.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelContainerBoutons.Controls.Add(btnInterrogationDuStock);
            panelContainerBoutons.Controls.Add(lblInterrogationDuStock);
            panelContainerBoutons.Controls.Add(btnMedias);
            panelContainerBoutons.Controls.Add(lblMedias);
            panelContainerBoutons.Controls.Add(btnTarifs);
            panelContainerBoutons.Controls.Add(lblTarifs);
            panelContainerBoutons.Controls.Add(btnGammes);
            panelContainerBoutons.Controls.Add(lblGammes);
            panelContainerBoutons.Controls.Add(btnConditionnement);
            panelContainerBoutons.Controls.Add(lblConditionnement);
            panelContainerBoutons.Controls.Add(btnInformations);
            panelContainerBoutons.Controls.Add(lblInformations);
            panelContainerBoutons.Location = new Point(34, 43);
            panelContainerBoutons.Name = "panelContainerBoutons";
            panelContainerBoutons.Size = new Size(650, 489);
            panelContainerBoutons.TabIndex = 19;
            // 
            // btnInterrogationDuStock
            // 
            btnInterrogationDuStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInterrogationDuStock.BackColor = Color.AliceBlue;
            btnInterrogationDuStock.Cursor = Cursors.Hand;
            btnInterrogationDuStock.FlatAppearance.BorderColor = Color.LightGray;
            btnInterrogationDuStock.FlatStyle = FlatStyle.Flat;
            btnInterrogationDuStock.Image = (Image)resources.GetObject("btnInterrogationDuStock.Image");
            btnInterrogationDuStock.Location = new Point(464, 276);
            btnInterrogationDuStock.Name = "btnInterrogationDuStock";
            btnInterrogationDuStock.Size = new Size(110, 110);
            btnInterrogationDuStock.TabIndex = 21;
            btnInterrogationDuStock.UseVisualStyleBackColor = false;
            btnInterrogationDuStock.Click += btnInterrogationDuStock_Click;
            // 
            // lblInterrogationDuStock
            // 
            lblInterrogationDuStock.AutoSize = true;
            lblInterrogationDuStock.BackColor = Color.Transparent;
            lblInterrogationDuStock.ForeColor = Color.White;
            lblInterrogationDuStock.Location = new Point(459, 392);
            lblInterrogationDuStock.Name = "lblInterrogationDuStock";
            lblInterrogationDuStock.Size = new Size(124, 15);
            lblInterrogationDuStock.TabIndex = 22;
            lblInterrogationDuStock.Text = "Interrogation du stock";
            lblInterrogationDuStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMedias
            // 
            btnMedias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMedias.BackColor = Color.AliceBlue;
            btnMedias.Cursor = Cursors.Hand;
            btnMedias.FlatAppearance.BorderColor = Color.LightGray;
            btnMedias.FlatStyle = FlatStyle.Flat;
            btnMedias.Image = (Image)resources.GetObject("btnMedias.Image");
            btnMedias.Location = new Point(275, 276);
            btnMedias.Name = "btnMedias";
            btnMedias.Size = new Size(110, 110);
            btnMedias.TabIndex = 19;
            btnMedias.UseVisualStyleBackColor = false;
            btnMedias.Click += btnMedias_Click;
            // 
            // lblMedias
            // 
            lblMedias.AutoSize = true;
            lblMedias.BackColor = Color.Transparent;
            lblMedias.ForeColor = Color.White;
            lblMedias.Location = new Point(309, 392);
            lblMedias.Name = "lblMedias";
            lblMedias.Size = new Size(45, 15);
            lblMedias.TabIndex = 20;
            lblMedias.Text = "Médias";
            lblMedias.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTarifs
            // 
            btnTarifs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTarifs.BackColor = Color.AliceBlue;
            btnTarifs.Cursor = Cursors.Hand;
            btnTarifs.FlatAppearance.BorderColor = Color.LightGray;
            btnTarifs.FlatStyle = FlatStyle.Flat;
            btnTarifs.Image = (Image)resources.GetObject("btnTarifs.Image");
            btnTarifs.Location = new Point(79, 276);
            btnTarifs.Name = "btnTarifs";
            btnTarifs.Size = new Size(110, 110);
            btnTarifs.TabIndex = 17;
            btnTarifs.UseVisualStyleBackColor = false;
            btnTarifs.Click += btnTarifs_Click;
            // 
            // lblTarifs
            // 
            lblTarifs.AutoSize = true;
            lblTarifs.BackColor = Color.Transparent;
            lblTarifs.ForeColor = Color.White;
            lblTarifs.Location = new Point(117, 392);
            lblTarifs.Name = "lblTarifs";
            lblTarifs.Size = new Size(35, 15);
            lblTarifs.TabIndex = 18;
            lblTarifs.Text = "Tarifs";
            lblTarifs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGammes
            // 
            btnGammes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGammes.BackColor = Color.AliceBlue;
            btnGammes.Cursor = Cursors.Hand;
            btnGammes.FlatAppearance.BorderColor = Color.LightGray;
            btnGammes.FlatStyle = FlatStyle.Flat;
            btnGammes.Image = (Image)resources.GetObject("btnGammes.Image");
            btnGammes.Location = new Point(464, 86);
            btnGammes.Name = "btnGammes";
            btnGammes.Size = new Size(110, 110);
            btnGammes.TabIndex = 9;
            btnGammes.UseVisualStyleBackColor = false;
            btnGammes.Click += btnGammes_Click;
            // 
            // lblGammes
            // 
            lblGammes.AutoSize = true;
            lblGammes.BackColor = Color.Transparent;
            lblGammes.ForeColor = Color.White;
            lblGammes.Location = new Point(495, 202);
            lblGammes.Name = "lblGammes";
            lblGammes.Size = new Size(54, 15);
            lblGammes.TabIndex = 10;
            lblGammes.Text = "Gammes";
            lblGammes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConditionnement
            // 
            btnConditionnement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConditionnement.BackColor = Color.AliceBlue;
            btnConditionnement.Cursor = Cursors.Hand;
            btnConditionnement.FlatAppearance.BorderColor = Color.LightGray;
            btnConditionnement.FlatStyle = FlatStyle.Flat;
            btnConditionnement.Image = (Image)resources.GetObject("btnConditionnement.Image");
            btnConditionnement.Location = new Point(275, 86);
            btnConditionnement.Name = "btnConditionnement";
            btnConditionnement.Size = new Size(110, 110);
            btnConditionnement.TabIndex = 7;
            btnConditionnement.UseVisualStyleBackColor = false;
            btnConditionnement.Click += btnConditionnement_Click;
            // 
            // lblConditionnement
            // 
            lblConditionnement.AutoSize = true;
            lblConditionnement.BackColor = Color.Transparent;
            lblConditionnement.ForeColor = Color.White;
            lblConditionnement.Location = new Point(279, 202);
            lblConditionnement.Name = "lblConditionnement";
            lblConditionnement.Size = new Size(101, 15);
            lblConditionnement.TabIndex = 8;
            lblConditionnement.Text = "Conditionnement";
            lblConditionnement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInformations
            // 
            btnInformations.BackColor = Color.AliceBlue;
            btnInformations.Cursor = Cursors.Hand;
            btnInformations.FlatAppearance.BorderColor = Color.LightGray;
            btnInformations.FlatStyle = FlatStyle.Flat;
            btnInformations.Image = (Image)resources.GetObject("btnInformations.Image");
            btnInformations.Location = new Point(79, 86);
            btnInformations.Name = "btnInformations";
            btnInformations.Size = new Size(110, 110);
            btnInformations.TabIndex = 5;
            btnInformations.UseVisualStyleBackColor = false;
            btnInformations.Click += btnInformations_Click;
            // 
            // lblInformations
            // 
            lblInformations.AutoSize = true;
            lblInformations.BackColor = Color.Transparent;
            lblInformations.ForeColor = Color.White;
            lblInformations.Location = new Point(98, 202);
            lblInformations.Name = "lblInformations";
            lblInformations.Size = new Size(75, 15);
            lblInformations.TabIndex = 6;
            lblInformations.Text = "Informations";
            lblInformations.TextAlign = ContentAlignment.MiddleCenter;
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
            iconButtonFermer.Location = new Point(688, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 40;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ChoixInformationsArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(734, 561);
            Controls.Add(iconButtonFermer);
            Controls.Add(panelContainerBoutons);
            Name = "ChoixInformationsArticle";
            ShowIcon = false;
            ShowInTaskbar = false;
            panelContainerBoutons.ResumeLayout(false);
            panelContainerBoutons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContainerBoutons;
        private Button btnInformations;
        private Label lblInformations;
        private Button btnInterrogationDuStock;
        private Label lblInterrogationDuStock;
        private Button btnMedias;
        private Label lblMedias;
        private Button btnTarifs;
        private Label lblTarifs;
        private Button btnGammes;
        private Label lblGammes;
        private Button btnConditionnement;
        private Label lblConditionnement;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}