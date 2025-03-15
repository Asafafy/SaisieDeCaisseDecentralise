using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres
{
    partial class ParametresSocietes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametresSocietes));
            btnCaisses = new Button();
            btnGammes = new Button();
            btnDevises = new Button();
            btnComptabilisation = new Button();
            lblCaisse = new Label();
            lblDevises = new Label();
            lblComptabilisation = new Label();
            lblGammes = new Label();
            panelContainerBoutons = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            panelContainerBoutons.SuspendLayout();
            SuspendLayout();
            // 
            // btnCaisses
            // 
            btnCaisses.BackColor = Color.AliceBlue;
            btnCaisses.Cursor = Cursors.Hand;
            btnCaisses.FlatAppearance.BorderColor = Color.LightGray;
            btnCaisses.FlatStyle = FlatStyle.Flat;
            btnCaisses.Image = (Image)resources.GetObject("btnCaisses.Image");
            btnCaisses.Location = new Point(117, 101);
            btnCaisses.Name = "btnCaisses";
            btnCaisses.Size = new Size(110, 110);
            btnCaisses.TabIndex = 0;
            btnCaisses.UseVisualStyleBackColor = false;
            btnCaisses.Click += btnCaisses_Click;
            // 
            // btnGammes
            // 
            btnGammes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGammes.BackColor = Color.AliceBlue;
            btnGammes.Cursor = Cursors.Hand;
            btnGammes.FlatAppearance.BorderColor = Color.LightGray;
            btnGammes.FlatStyle = FlatStyle.Flat;
            btnGammes.Image = (Image)resources.GetObject("btnGammes.Image");
            btnGammes.Location = new Point(329, 339);
            btnGammes.Name = "btnGammes";
            btnGammes.Size = new Size(110, 110);
            btnGammes.TabIndex = 1;
            btnGammes.UseVisualStyleBackColor = false;
            btnGammes.Click += btnGammes_Click;
            // 
            // btnDevises
            // 
            btnDevises.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDevises.BackColor = Color.AliceBlue;
            btnDevises.Cursor = Cursors.Hand;
            btnDevises.FlatAppearance.BorderColor = Color.LightGray;
            btnDevises.FlatStyle = FlatStyle.Flat;
            btnDevises.Image = (Image)resources.GetObject("btnDevises.Image");
            btnDevises.Location = new Point(329, 101);
            btnDevises.Name = "btnDevises";
            btnDevises.Size = new Size(110, 110);
            btnDevises.TabIndex = 2;
            btnDevises.UseVisualStyleBackColor = false;
            btnDevises.Click += btnDevises_Click;
            // 
            // btnComptabilisation
            // 
            btnComptabilisation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnComptabilisation.BackColor = Color.AliceBlue;
            btnComptabilisation.Cursor = Cursors.Hand;
            btnComptabilisation.FlatAppearance.BorderColor = Color.LightGray;
            btnComptabilisation.FlatStyle = FlatStyle.Flat;
            btnComptabilisation.Image = (Image)resources.GetObject("btnComptabilisation.Image");
            btnComptabilisation.Location = new Point(117, 339);
            btnComptabilisation.Name = "btnComptabilisation";
            btnComptabilisation.Size = new Size(110, 110);
            btnComptabilisation.TabIndex = 3;
            btnComptabilisation.UseVisualStyleBackColor = false;
            btnComptabilisation.Click += btnComptabilisation_Click;
            // 
            // lblCaisse
            // 
            lblCaisse.AutoSize = true;
            lblCaisse.BackColor = Color.Transparent;
            lblCaisse.ForeColor = Color.White;
            lblCaisse.Location = new Point(151, 217);
            lblCaisse.Name = "lblCaisse";
            lblCaisse.Size = new Size(45, 15);
            lblCaisse.TabIndex = 4;
            lblCaisse.Text = "Caisses";
            lblCaisse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDevises
            // 
            lblDevises.AutoSize = true;
            lblDevises.BackColor = Color.Transparent;
            lblDevises.ForeColor = Color.White;
            lblDevises.Location = new Point(363, 217);
            lblDevises.Name = "lblDevises";
            lblDevises.Size = new Size(46, 15);
            lblDevises.TabIndex = 5;
            lblDevises.Text = "Devises";
            lblDevises.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblComptabilisation
            // 
            lblComptabilisation.AutoSize = true;
            lblComptabilisation.BackColor = Color.Transparent;
            lblComptabilisation.ForeColor = Color.White;
            lblComptabilisation.Location = new Point(124, 455);
            lblComptabilisation.Name = "lblComptabilisation";
            lblComptabilisation.Size = new Size(98, 15);
            lblComptabilisation.TabIndex = 6;
            lblComptabilisation.Text = "Comptabilisation";
            lblComptabilisation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGammes
            // 
            lblGammes.AutoSize = true;
            lblGammes.BackColor = Color.Transparent;
            lblGammes.ForeColor = Color.White;
            lblGammes.Location = new Point(359, 455);
            lblGammes.Name = "lblGammes";
            lblGammes.Size = new Size(54, 15);
            lblGammes.TabIndex = 7;
            lblGammes.Text = "Gammes";
            lblGammes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContainerBoutons
            // 
            panelContainerBoutons.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelContainerBoutons.Controls.Add(btnCaisses);
            panelContainerBoutons.Controls.Add(btnGammes);
            panelContainerBoutons.Controls.Add(lblGammes);
            panelContainerBoutons.Controls.Add(btnDevises);
            panelContainerBoutons.Controls.Add(lblComptabilisation);
            panelContainerBoutons.Controls.Add(btnComptabilisation);
            panelContainerBoutons.Controls.Add(lblDevises);
            panelContainerBoutons.Controls.Add(lblCaisse);
            panelContainerBoutons.Location = new Point(53, 44);
            panelContainerBoutons.Name = "panelContainerBoutons";
            panelContainerBoutons.Size = new Size(550, 550);
            panelContainerBoutons.TabIndex = 18;
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
            iconButtonFermer.Location = new Point(612, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 47;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ParametresSocietes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(664, 641);
            Controls.Add(iconButtonFermer);
            Controls.Add(panelContainerBoutons);
            Name = "ParametresSocietes";
            ShowIcon = false;
            ShowInTaskbar = false;
            panelContainerBoutons.ResumeLayout(false);
            panelContainerBoutons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCaisses;
        private Button btnGammes;
        private Button btnDevises;
        private Button btnComptabilisation;
        private Label lblCaisse;
        private Label lblDevises;
        private Label lblComptabilisation;
        private Label lblGammes;
        private Panel panel1;
        private Panel panelContainerBoutons;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}