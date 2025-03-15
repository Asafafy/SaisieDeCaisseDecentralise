using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm.ConditionnementChildForm
{
    partial class CreateUpdateConditionnement
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
            groupBox1 = new GroupBox();
            tableLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            txtBxNombreDArticle = new TextBox();
            panel2 = new Panel();
            txtBxEnumere = new TextBox();
            lblQuantite = new Label();
            lblEnumere = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            cmbBxCodeEDI = new ComboBox();
            panel5 = new Panel();
            txtBxCodeBarres = new TextBox();
            panel6 = new Panel();
            txtBxReference = new TextBox();
            label1 = new Label();
            lblCodeBarres = new Label();
            lblReference = new Label();
            checkBoxDefinirPrincipal = new CheckBox();
            btnEnregistrer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel);
            groupBox1.Location = new Point(20, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 10, 30, 20);
            groupBox1.Size = new Size(731, 87);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enuméré de conditionnement";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(panel1, 3, 0);
            tableLayoutPanel.Controls.Add(panel2, 1, 0);
            tableLayoutPanel.Controls.Add(lblQuantite, 2, 0);
            tableLayoutPanel.Controls.Add(lblEnumere, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(15, 26);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(686, 41);
            tableLayoutPanel.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBxNombreDArticle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(482, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(201, 35);
            panel1.TabIndex = 37;
            // 
            // txtBxNombreDArticle
            // 
            txtBxNombreDArticle.BorderStyle = BorderStyle.None;
            txtBxNombreDArticle.Dock = DockStyle.Fill;
            txtBxNombreDArticle.Location = new Point(20, 9);
            txtBxNombreDArticle.Name = "txtBxNombreDArticle";
            //txtBxNombreDArticle.PlaceholderText = "Nombre d'article";
            txtBxNombreDArticle.Size = new Size(159, 16);
            txtBxNombreDArticle.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxEnumere);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(140, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(199, 35);
            panel2.TabIndex = 36;
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
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Dock = DockStyle.Right;
            lblQuantite.Location = new Point(423, 0);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new Size(53, 41);
            lblQuantite.TabIndex = 3;
            lblQuantite.Text = "Quantité";
            lblQuantite.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEnumere
            // 
            lblEnumere.AutoSize = true;
            lblEnumere.Dock = DockStyle.Right;
            lblEnumere.Location = new Point(80, 0);
            lblEnumere.Name = "lblEnumere";
            lblEnumere.Size = new Size(54, 41);
            lblEnumere.TabIndex = 1;
            lblEnumere.Text = "Enuméré";
            lblEnumere.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(20, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 10, 30, 20);
            groupBox2.Size = new Size(731, 127);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descriptions complémentaires";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCodeBarres, 2, 0);
            tableLayoutPanel1.Controls.Add(lblReference, 0, 0);
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
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbBxCodeEDI);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(140, 43);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(199, 35);
            panel3.TabIndex = 38;
            // 
            // cmbBxCodeEDI
            // 
            cmbBxCodeEDI.Dock = DockStyle.Fill;
            cmbBxCodeEDI.FlatStyle = FlatStyle.Flat;
            cmbBxCodeEDI.FormattingEnabled = true;
            cmbBxCodeEDI.Location = new Point(20, 5);
            cmbBxCodeEDI.Name = "cmbBxCodeEDI";
            cmbBxCodeEDI.Size = new Size(173, 23);
            cmbBxCodeEDI.TabIndex = 0;
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
            panel6.Controls.Add(txtBxReference);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(140, 3);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 9, 20, 10);
            panel6.Size = new Size(199, 34);
            panel6.TabIndex = 36;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(79, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 41);
            label1.TabIndex = 5;
            label1.Text = "Code EDI";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.Dock = DockStyle.Right;
            lblReference.Location = new Point(75, 0);
            lblReference.Name = "lblReference";
            lblReference.Size = new Size(59, 40);
            lblReference.TabIndex = 1;
            lblReference.Text = "Référence";
            lblReference.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkBoxDefinirPrincipal
            // 
            checkBoxDefinirPrincipal.AutoSize = true;
            checkBoxDefinirPrincipal.Location = new Point(35, 326);
            checkBoxDefinirPrincipal.Name = "checkBoxDefinirPrincipal";
            checkBoxDefinirPrincipal.Size = new Size(249, 19);
            checkBoxDefinirPrincipal.TabIndex = 26;
            checkBoxDefinirPrincipal.Text = "Définir comme conditionnement principal";
            checkBoxDefinirPrincipal.UseVisualStyleBackColor = true;
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
            btnEnregistrer.Location = new Point(561, 360);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 28;
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
            iconButtonFermer.Location = new Point(758, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 36;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateUpdateConditionnement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 417);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnEnregistrer);
            Controls.Add(checkBoxDefinirPrincipal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CreateUpdateConditionnement";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox txtBxEnumere;
        private Label lblQuantite;
        private Label lblEnumere;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TextBox textBox4;
        private Panel panel6;
        private TextBox textBox5;
        private Label label1;
        private Label lblCodeBarres;
        private Label lblReference;
        private Panel panel3;
        private ComboBox cmbBxCodeEDI;
        private CheckBox checkBoxDefinirPrincipal;
        private Button btnEnregistrer;
        private TextBox txtBxNombreDArticle;
        private TextBox txtBxCodeBarres;
        private TextBox txtBxReference;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}