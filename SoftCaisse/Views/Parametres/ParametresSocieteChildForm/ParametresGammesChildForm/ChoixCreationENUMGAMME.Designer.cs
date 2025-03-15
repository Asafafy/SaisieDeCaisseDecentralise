using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresGammesChildForm
{
    partial class ChoixCreationENUMGAMME
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
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButtonCreerManuellementPasAPas = new RadioButton();
            radioButtonCreerAutomatiquement = new RadioButton();
            radioButtonNon = new RadioButton();
            label1 = new Label();
            btnOK = new Button();
            panel1 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(radioButtonCreerManuellementPasAPas, 0, 2);
            tableLayoutPanel1.Controls.Add(radioButtonCreerAutomatiquement, 0, 1);
            tableLayoutPanel1.Controls.Add(radioButtonNon, 0, 0);
            tableLayoutPanel1.Location = new Point(42, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(399, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonCreerManuellementPasAPas
            // 
            radioButtonCreerManuellementPasAPas.AutoSize = true;
            radioButtonCreerManuellementPasAPas.Location = new Point(3, 83);
            radioButtonCreerManuellementPasAPas.Name = "radioButtonCreerManuellementPasAPas";
            radioButtonCreerManuellementPasAPas.Size = new Size(192, 19);
            radioButtonCreerManuellementPasAPas.TabIndex = 2;
            radioButtonCreerManuellementPasAPas.TabStop = true;
            radioButtonCreerManuellementPasAPas.Text = "Créer manuellement (pas à pas)";
            radioButtonCreerManuellementPasAPas.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreerAutomatiquement
            // 
            radioButtonCreerAutomatiquement.AutoSize = true;
            radioButtonCreerAutomatiquement.Location = new Point(3, 43);
            radioButtonCreerAutomatiquement.Name = "radioButtonCreerAutomatiquement";
            radioButtonCreerAutomatiquement.Size = new Size(152, 19);
            radioButtonCreerAutomatiquement.TabIndex = 1;
            radioButtonCreerAutomatiquement.TabStop = true;
            radioButtonCreerAutomatiquement.Text = "Créer automatiquement";
            radioButtonCreerAutomatiquement.UseVisualStyleBackColor = true;
            // 
            // radioButtonNon
            // 
            radioButtonNon.AutoSize = true;
            radioButtonNon.Location = new Point(3, 3);
            radioButtonNon.Name = "radioButtonNon";
            radioButtonNon.Size = new Size(48, 19);
            radioButtonNon.TabIndex = 0;
            radioButtonNon.TabStop = true;
            radioButtonNon.Text = "Non";
            radioButtonNon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(398, 15);
            label1.TabIndex = 1;
            label1.Text = "Créer les énumérés de gamme pour les articles disposant la gamme \"xxx\" ?";
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
            btnOK.Location = new Point(340, 309);
            btnOK.Margin = new Padding(144, 3, 144, 3);
            btnOK.Name = "btnOK";
            btnOK.Padding = new Padding(8, 0, 0, 0);
            btnOK.Size = new Size(190, 45);
            btnOK.TabIndex = 27;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(44, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 242);
            panel1.TabIndex = 28;
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
            iconButtonFermer.Location = new Point(533, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 38;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ChoixCreationENUMGAMME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(582, 381);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel1);
            Controls.Add(btnOK);
            Name = "ChoixCreationENUMGAMME";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ChoixCreationENUMGAMME";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private RadioButton radioButtonCreerManuellementPasAPas;
        private RadioButton radioButtonCreerAutomatiquement;
        private RadioButton radioButtonNon;
        private Button btnOK;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}