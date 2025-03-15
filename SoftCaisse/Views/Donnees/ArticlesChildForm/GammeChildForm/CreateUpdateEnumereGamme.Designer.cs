using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm.GammeChildForm
{
    partial class CreateUpdateEnumereGamme
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
            btnEnregistrer = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtBxReference = new TextBox();
            panel7 = new Panel();
            txtBxCodeEDI = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            txtBxCodeBarres = new TextBox();
            panel6 = new Panel();
            txtBxEnumere = new TextBox();
            lblReference = new Label();
            lblCodeBarres = new Label();
            lblEnumere = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            txtBxCoutStandart = new TextBox();
            panel3 = new Panel();
            txtBxDernierPrixDAchat = new TextBox();
            panel4 = new Panel();
            txtBxPrixDAchat = new TextBox();
            lblDernierPrixDAchat = new Label();
            lblCoutStandard = new Label();
            lblPrixDAchat = new Label();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(562, 373);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 34;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(21, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 10, 30, 20);
            groupBox2.Size = new Size(731, 127);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Identification";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel7, 3, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(lblReference, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCodeBarres, 2, 0);
            tableLayoutPanel1.Controls.Add(lblEnumere, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(686, 81);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBxReference);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(140, 43);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(199, 35);
            panel1.TabIndex = 44;
            // 
            // txtBxReference
            // 
            txtBxReference.BorderStyle = BorderStyle.None;
            txtBxReference.Dock = DockStyle.Fill;
            txtBxReference.Location = new Point(20, 9);
            txtBxReference.Name = "txtBxReference";
            //txtBxReference.PlaceholderText = "Référence";
            txtBxReference.Size = new Size(157, 16);
            txtBxReference.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtBxCodeEDI);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(482, 43);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(201, 35);
            panel7.TabIndex = 43;
            // 
            // txtBxCodeEDI
            // 
            txtBxCodeEDI.BorderStyle = BorderStyle.None;
            txtBxCodeEDI.Dock = DockStyle.Fill;
            txtBxCodeEDI.Location = new Point(20, 9);
            txtBxCodeEDI.Name = "txtBxCodeEDI";
            //txtBxCodeEDI.PlaceholderText = "Code EDI";
            txtBxCodeEDI.Size = new Size(159, 16);
            txtBxCodeEDI.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(421, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 41);
            label1.TabIndex = 42;
            label1.Text = "Code EDI";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxCodeBarres);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(482, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(201, 34);
            panel5.TabIndex = 37;
            // 
            // txtBxCodeBarres
            // 
            txtBxCodeBarres.BorderStyle = BorderStyle.None;
            txtBxCodeBarres.Dock = DockStyle.Fill;
            txtBxCodeBarres.Location = new Point(20, 9);
            txtBxCodeBarres.Name = "txtBxCodeBarres";
            //txtBxCodeBarres.PlaceholderText = "Code barres";
            txtBxCodeBarres.Size = new Size(159, 16);
            txtBxCodeBarres.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtBxEnumere);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(140, 3);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 9, 20, 10);
            panel6.Size = new Size(199, 34);
            panel6.TabIndex = 36;
            // 
            // txtBxEnumere
            // 
            txtBxEnumere.BorderStyle = BorderStyle.None;
            txtBxEnumere.Dock = DockStyle.Fill;
            txtBxEnumere.Location = new Point(20, 9);
            txtBxEnumere.Name = "txtBxEnumere";
            //txtBxEnumere.PlaceholderText = "Enuméré";
            txtBxEnumere.Size = new Size(157, 16);
            txtBxEnumere.TabIndex = 0;
            // 
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.Dock = DockStyle.Right;
            lblReference.Location = new Point(75, 40);
            lblReference.Name = "lblReference";
            lblReference.Size = new Size(59, 41);
            lblReference.TabIndex = 5;
            lblReference.Text = "Référence";
            lblReference.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCodeBarres
            // 
            lblCodeBarres.AutoSize = true;
            lblCodeBarres.Dock = DockStyle.Right;
            lblCodeBarres.Location = new Point(406, 0);
            lblCodeBarres.Name = "lblCodeBarres";
            lblCodeBarres.Size = new Size(70, 40);
            lblCodeBarres.TabIndex = 3;
            lblCodeBarres.Text = "Code barres";
            lblCodeBarres.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEnumere
            // 
            lblEnumere.AutoSize = true;
            lblEnumere.Dock = DockStyle.Right;
            lblEnumere.Location = new Point(80, 0);
            lblEnumere.Name = "lblEnumere";
            lblEnumere.Size = new Size(54, 40);
            lblEnumere.TabIndex = 1;
            lblEnumere.Text = "Enuméré";
            lblEnumere.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(21, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 10, 30, 20);
            groupBox1.Size = new Size(731, 127);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identification";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel2, 3, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 1);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(lblDernierPrixDAchat, 0, 1);
            tableLayoutPanel2.Controls.Add(lblCoutStandard, 2, 0);
            tableLayoutPanel2.Controls.Add(lblPrixDAchat, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(15, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(686, 81);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxCoutStandart);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(482, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(201, 34);
            panel2.TabIndex = 39;
            // 
            // txtBxCoutStandart
            // 
            txtBxCoutStandart.BorderStyle = BorderStyle.None;
            txtBxCoutStandart.Dock = DockStyle.Fill;
            txtBxCoutStandart.Location = new Point(20, 9);
            txtBxCoutStandart.Name = "txtBxCoutStandart";
            //txtBxCoutStandart.PlaceholderText = "Coût standard";
            txtBxCoutStandart.Size = new Size(159, 16);
            txtBxCoutStandart.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtBxDernierPrixDAchat);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(140, 43);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(199, 35);
            panel3.TabIndex = 38;
            // 
            // txtBxDernierPrixDAchat
            // 
            txtBxDernierPrixDAchat.BorderStyle = BorderStyle.None;
            txtBxDernierPrixDAchat.Dock = DockStyle.Fill;
            txtBxDernierPrixDAchat.Location = new Point(20, 9);
            txtBxDernierPrixDAchat.Name = "txtBxDernierPrixDAchat";
            //txtBxDernierPrixDAchat.PlaceholderText = "Dernier prix d'achat";
            txtBxDernierPrixDAchat.Size = new Size(157, 16);
            txtBxDernierPrixDAchat.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBxPrixDAchat);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(140, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(199, 34);
            panel4.TabIndex = 36;
            // 
            // txtBxPrixDAchat
            // 
            txtBxPrixDAchat.BorderStyle = BorderStyle.None;
            txtBxPrixDAchat.Dock = DockStyle.Fill;
            txtBxPrixDAchat.Location = new Point(20, 9);
            txtBxPrixDAchat.Name = "txtBxPrixDAchat";
            //txtBxPrixDAchat.PlaceholderText = "Prix d'achat";
            txtBxPrixDAchat.Size = new Size(157, 16);
            txtBxPrixDAchat.TabIndex = 0;
            // 
            // lblDernierPrixDAchat
            // 
            lblDernierPrixDAchat.AutoSize = true;
            lblDernierPrixDAchat.Dock = DockStyle.Right;
            lblDernierPrixDAchat.Location = new Point(25, 40);
            lblDernierPrixDAchat.Name = "lblDernierPrixDAchat";
            lblDernierPrixDAchat.Size = new Size(109, 41);
            lblDernierPrixDAchat.TabIndex = 5;
            lblDernierPrixDAchat.Text = "Dernier prix d'achat";
            lblDernierPrixDAchat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCoutStandard
            // 
            lblCoutStandard.AutoSize = true;
            lblCoutStandard.Dock = DockStyle.Right;
            lblCoutStandard.Location = new Point(394, 0);
            lblCoutStandard.Name = "lblCoutStandard";
            lblCoutStandard.Size = new Size(82, 40);
            lblCoutStandard.TabIndex = 3;
            lblCoutStandard.Text = "Coût standard";
            lblCoutStandard.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrixDAchat
            // 
            lblPrixDAchat.AutoSize = true;
            lblPrixDAchat.Dock = DockStyle.Right;
            lblPrixDAchat.Location = new Point(66, 0);
            lblPrixDAchat.Name = "lblPrixDAchat";
            lblPrixDAchat.Size = new Size(68, 40);
            lblPrixDAchat.TabIndex = 1;
            lblPrixDAchat.Text = "Prix d'achat";
            lblPrixDAchat.TextAlign = ContentAlignment.MiddleRight;
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
            iconButtonFermer.Location = new Point(755, 5);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 39;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateUpdateEnumereGamme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 430);
            Controls.Add(iconButtonFermer);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnEnregistrer);
            Name = "CreateUpdateEnumereGamme";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnEnregistrer;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TextBox txtBxCodeBarres;
        private Panel panel6;
        private TextBox txtBxEnumere;
        private Label lblReference;
        private Label lblCodeBarres;
        private Label lblEnumere;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Panel panel4;
        private TextBox txtBxPrixDAchat;
        private Label lblDernierPrixDAchat;
        private Label lblCoutStandard;
        private Label lblPrixDAchat;
        private Label label1;
        private Panel panel1;
        private TextBox txtBxReference;
        private Panel panel7;
        private TextBox txtBxCodeEDI;
        private Panel panel2;
        private TextBox txtBxCoutStandart;
        private Panel panel3;
        private TextBox txtBxDernierPrixDAchat;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}