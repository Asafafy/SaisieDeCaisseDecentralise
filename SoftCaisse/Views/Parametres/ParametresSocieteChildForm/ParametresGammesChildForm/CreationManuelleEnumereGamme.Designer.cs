using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresGammesChildForm
{
    partial class CreationManuelleEnumereGamme
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
            labelEnumere = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            txtBxEnumere = new TextBox();
            panel5 = new Panel();
            txtBxPrixDAchatDeLEnumere = new TextBox();
            panel4 = new Panel();
            txtBxCodeBarres = new TextBox();
            panel3 = new Panel();
            txtBxReferenceDeLEnumereDArtcile = new TextBox();
            lblPrixDAchats = new Label();
            lblCodeBarres = new Label();
            lblReference = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            txtBxPrixPourLesClientsAuComptoir = new TextBox();
            panel2 = new Panel();
            txtBxPrixPourLesDetaillants = new TextBox();
            panel6 = new Panel();
            txtBxPrixPourGrossistes = new TextBox();
            lblClientsComptoir = new Label();
            lblDetaillants = new Label();
            lblGrossistes = new Label();
            btnEnregistrer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // labelEnumere
            // 
            labelEnumere.AutoSize = true;
            labelEnumere.Dock = DockStyle.Fill;
            labelEnumere.Location = new Point(3, 0);
            labelEnumere.Name = "labelEnumere";
            labelEnumere.Size = new Size(145, 40);
            labelEnumere.TabIndex = 0;
            labelEnumere.Text = "Enuméré";
            labelEnumere.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(32, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 8, 60, 3);
            groupBox1.Size = new Size(554, 200);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identification";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel7, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 3);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPrixDAchats, 0, 3);
            tableLayoutPanel1.Controls.Add(labelEnumere, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCodeBarres, 0, 2);
            tableLayoutPanel1.Controls.Add(lblReference, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(434, 173);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtBxEnumere);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(154, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(277, 34);
            panel7.TabIndex = 33;
            // 
            // txtBxEnumere
            // 
            txtBxEnumere.BorderStyle = BorderStyle.None;
            txtBxEnumere.Dock = DockStyle.Fill;
            txtBxEnumere.Location = new Point(20, 9);
            txtBxEnumere.Name = "txtBxEnumere";
            //txtBxEnumere.PlaceholderText = "Référence de l'énuméré";
            txtBxEnumere.Size = new Size(235, 16);
            txtBxEnumere.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxPrixDAchatDeLEnumere);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(154, 123);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(277, 34);
            panel5.TabIndex = 32;
            // 
            // txtBxPrixDAchatDeLEnumere
            // 
            txtBxPrixDAchatDeLEnumere.BorderStyle = BorderStyle.None;
            txtBxPrixDAchatDeLEnumere.Dock = DockStyle.Fill;
            txtBxPrixDAchatDeLEnumere.Location = new Point(20, 9);
            txtBxPrixDAchatDeLEnumere.Name = "txtBxPrixDAchatDeLEnumere";
            //txtBxPrixDAchatDeLEnumere.PlaceholderText = "Prix d'achat de l'énuméré";
            txtBxPrixDAchatDeLEnumere.Size = new Size(235, 16);
            txtBxPrixDAchatDeLEnumere.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBxCodeBarres);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(154, 83);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(277, 34);
            panel4.TabIndex = 31;
            // 
            // txtBxCodeBarres
            // 
            txtBxCodeBarres.BorderStyle = BorderStyle.None;
            txtBxCodeBarres.Dock = DockStyle.Fill;
            txtBxCodeBarres.Location = new Point(20, 9);
            txtBxCodeBarres.Name = "txtBxCodeBarres";
            //txtBxCodeBarres.PlaceholderText = "Code barres de l'énuméré";
            txtBxCodeBarres.Size = new Size(235, 16);
            txtBxCodeBarres.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtBxReferenceDeLEnumereDArtcile);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(154, 43);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(277, 34);
            panel3.TabIndex = 30;
            // 
            // txtBxReferenceDeLEnumereDArtcile
            // 
            txtBxReferenceDeLEnumereDArtcile.BorderStyle = BorderStyle.None;
            txtBxReferenceDeLEnumereDArtcile.Dock = DockStyle.Fill;
            txtBxReferenceDeLEnumereDArtcile.Location = new Point(20, 9);
            txtBxReferenceDeLEnumereDArtcile.Name = "txtBxReferenceDeLEnumereDArtcile";
            //txtBxReferenceDeLEnumereDArtcile.PlaceholderText = "Référence de l'énuméré d'article";
            txtBxReferenceDeLEnumereDArtcile.Size = new Size(235, 16);
            txtBxReferenceDeLEnumereDArtcile.TabIndex = 0;
            // 
            // lblPrixDAchats
            // 
            lblPrixDAchats.AutoSize = true;
            lblPrixDAchats.Dock = DockStyle.Right;
            lblPrixDAchats.Location = new Point(75, 120);
            lblPrixDAchats.Name = "lblPrixDAchats";
            lblPrixDAchats.Size = new Size(73, 40);
            lblPrixDAchats.TabIndex = 27;
            lblPrixDAchats.Text = "Prix d'achats";
            lblPrixDAchats.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCodeBarres
            // 
            lblCodeBarres.AutoSize = true;
            lblCodeBarres.Dock = DockStyle.Right;
            lblCodeBarres.Location = new Point(78, 80);
            lblCodeBarres.Name = "lblCodeBarres";
            lblCodeBarres.Size = new Size(70, 40);
            lblCodeBarres.TabIndex = 24;
            lblCodeBarres.Text = "Code barres";
            lblCodeBarres.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.Dock = DockStyle.Right;
            lblReference.Location = new Point(89, 40);
            lblReference.Name = "lblReference";
            lblReference.Size = new Size(59, 40);
            lblReference.TabIndex = 0;
            lblReference.Text = "Référence";
            lblReference.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(32, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(60, 3, 60, 3);
            groupBox2.Size = new Size(554, 162);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Catégories tarifaires";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 3);
            tableLayoutPanel2.Controls.Add(panel2, 1, 2);
            tableLayoutPanel2.Controls.Add(panel6, 1, 1);
            tableLayoutPanel2.Controls.Add(lblClientsComptoir, 0, 3);
            tableLayoutPanel2.Controls.Add(lblDetaillants, 0, 2);
            tableLayoutPanel2.Controls.Add(lblGrossistes, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(434, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBxPrixPourLesClientsAuComptoir);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(154, 93);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(277, 34);
            panel1.TabIndex = 32;
            // 
            // txtBxPrixPourLesClientsAuComptoir
            // 
            txtBxPrixPourLesClientsAuComptoir.BorderStyle = BorderStyle.None;
            txtBxPrixPourLesClientsAuComptoir.Dock = DockStyle.Fill;
            txtBxPrixPourLesClientsAuComptoir.Location = new Point(20, 9);
            txtBxPrixPourLesClientsAuComptoir.Name = "txtBxPrixPourLesClientsAuComptoir";
            //txtBxPrixPourLesClientsAuComptoir.PlaceholderText = "Prix pour les clients au comptoir";
            txtBxPrixPourLesClientsAuComptoir.Size = new Size(235, 16);
            txtBxPrixPourLesClientsAuComptoir.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxPrixPourLesDetaillants);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(154, 53);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(277, 34);
            panel2.TabIndex = 31;
            // 
            // txtBxPrixPourLesDetaillants
            // 
            txtBxPrixPourLesDetaillants.BorderStyle = BorderStyle.None;
            txtBxPrixPourLesDetaillants.Dock = DockStyle.Fill;
            txtBxPrixPourLesDetaillants.Location = new Point(20, 9);
            txtBxPrixPourLesDetaillants.Name = "txtBxPrixPourLesDetaillants";
            //txtBxPrixPourLesDetaillants.PlaceholderText = "Prix pour les détaillants";
            txtBxPrixPourLesDetaillants.Size = new Size(235, 16);
            txtBxPrixPourLesDetaillants.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtBxPrixPourGrossistes);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(154, 13);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 9, 20, 10);
            panel6.Size = new Size(277, 34);
            panel6.TabIndex = 30;
            // 
            // txtBxPrixPourGrossistes
            // 
            txtBxPrixPourGrossistes.BorderStyle = BorderStyle.None;
            txtBxPrixPourGrossistes.Dock = DockStyle.Fill;
            txtBxPrixPourGrossistes.Location = new Point(20, 9);
            txtBxPrixPourGrossistes.Name = "txtBxPrixPourGrossistes";
            //txtBxPrixPourGrossistes.PlaceholderText = "Prix pour les grossistes";
            txtBxPrixPourGrossistes.Size = new Size(235, 16);
            txtBxPrixPourGrossistes.TabIndex = 0;
            // 
            // lblClientsComptoir
            // 
            lblClientsComptoir.AutoSize = true;
            lblClientsComptoir.Dock = DockStyle.Right;
            lblClientsComptoir.Location = new Point(37, 90);
            lblClientsComptoir.Name = "lblClientsComptoir";
            lblClientsComptoir.Size = new Size(111, 40);
            lblClientsComptoir.TabIndex = 27;
            lblClientsComptoir.Text = "Clients au comptoir";
            lblClientsComptoir.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetaillants
            // 
            lblDetaillants.AutoSize = true;
            lblDetaillants.Dock = DockStyle.Right;
            lblDetaillants.Location = new Point(86, 50);
            lblDetaillants.Name = "lblDetaillants";
            lblDetaillants.Size = new Size(62, 40);
            lblDetaillants.TabIndex = 24;
            lblDetaillants.Text = "Détaillants";
            lblDetaillants.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGrossistes
            // 
            lblGrossistes.AutoSize = true;
            lblGrossistes.Dock = DockStyle.Right;
            lblGrossistes.Location = new Point(89, 10);
            lblGrossistes.Name = "lblGrossistes";
            lblGrossistes.Size = new Size(59, 40);
            lblGrossistes.TabIndex = 0;
            lblGrossistes.Text = "Grossistes";
            lblGrossistes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(396, 528);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 27;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(590, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 39;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreationManuelleEnumereGamme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(642, 596);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnEnregistrer);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CreationManuelleEnumereGamme";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "CreationManuelleEnumereGamme";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelEnumere;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPrixDAchats;
        private Label lblCodeBarres;
        private Label lblReference;
        private Panel panel5;
        private TextBox textBox4;
        private Panel panel4;
        private TextBox textBox3;
        private Panel panel3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TextBox txtBxPrixPourLesClientsAuComptoir;
        private Panel panel2;
        private TextBox txtBxPrixPourLesDetaillants;
        private Panel panel6;
        private TextBox txtBxPrixPourGrossistes;
        private Label lblClientsComptoir;
        private Label lblDetaillants;
        private Label lblGrossistes;
        private Button btnEnregistrer;
        private Panel panel7;
        private TextBox textBox1;
        private TextBox txtBxEnumere;
        private TextBox txtBxPrixDAchatDeLEnumere;
        private TextBox txtBxCodeBarres;
        private TextBox txtBxReferenceDeLEnumereDArtcile;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}