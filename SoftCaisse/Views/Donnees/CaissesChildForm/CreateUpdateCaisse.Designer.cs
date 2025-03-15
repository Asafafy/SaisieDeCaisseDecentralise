using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.CaissesChildForm
{
    partial class CreateUpdateCaisse
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBoxInformationsConcernantLaCaisse = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            comboBoxCodeJournal = new ComboBox();
            panel5 = new Panel();
            comboBoxClientAuComptoir = new ComboBox();
            lblCodeJournal = new Label();
            panel2 = new Panel();
            txtBxIntituleDeLaCaisse = new TextBox();
            lblMotDePasse = new Label();
            lblIntitule = new Label();
            groupBoxValeursParDefaut = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            comboBoxCaissierParDefaut = new ComboBox();
            panel1 = new Panel();
            comboBoxDepotParDefaut = new ComboBox();
            lblCaissierParDefaut = new Label();
            lblDepotParDefaut = new Label();
            panel7 = new Panel();
            comboBoxVendeurParDefaut = new ComboBox();
            lblVendeurParDefaut = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Selectionner = new DataGridViewCheckBoxColumn();
            Caissier = new DataGridViewTextBoxColumn();
            btnEnregistrer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBoxInformationsConcernantLaCaisse.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxValeursParDefaut.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInformationsConcernantLaCaisse
            // 
            groupBoxInformationsConcernantLaCaisse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInformationsConcernantLaCaisse.Controls.Add(tableLayoutPanel1);
            groupBoxInformationsConcernantLaCaisse.Location = new Point(22, 39);
            groupBoxInformationsConcernantLaCaisse.Name = "groupBoxInformationsConcernantLaCaisse";
            groupBoxInformationsConcernantLaCaisse.Padding = new Padding(60, 3, 60, 3);
            groupBoxInformationsConcernantLaCaisse.Size = new Size(730, 161);
            groupBoxInformationsConcernantLaCaisse.TabIndex = 23;
            groupBoxInformationsConcernantLaCaisse.TabStop = false;
            groupBoxInformationsConcernantLaCaisse.Text = "Informations relatives à la caisse";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 3);
            tableLayoutPanel1.Controls.Add(panel5, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCodeJournal, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblMotDePasse, 0, 2);
            tableLayoutPanel1.Controls.Add(lblIntitule, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(610, 139);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxCodeJournal);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(216, 93);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(391, 34);
            panel6.TabIndex = 33;
            // 
            // comboBoxCodeJournal
            // 
            comboBoxCodeJournal.Dock = DockStyle.Fill;
            comboBoxCodeJournal.FlatStyle = FlatStyle.Flat;
            comboBoxCodeJournal.FormattingEnabled = true;
            comboBoxCodeJournal.Location = new Point(20, 5);
            comboBoxCodeJournal.Name = "comboBoxCodeJournal";
            comboBoxCodeJournal.Size = new Size(365, 23);
            comboBoxCodeJournal.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBoxClientAuComptoir);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(216, 53);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(391, 34);
            panel5.TabIndex = 32;
            // 
            // comboBoxClientAuComptoir
            // 
            comboBoxClientAuComptoir.Dock = DockStyle.Fill;
            comboBoxClientAuComptoir.FlatStyle = FlatStyle.Flat;
            comboBoxClientAuComptoir.FormattingEnabled = true;
            comboBoxClientAuComptoir.Location = new Point(20, 5);
            comboBoxClientAuComptoir.Name = "comboBoxClientAuComptoir";
            comboBoxClientAuComptoir.Size = new Size(365, 23);
            comboBoxClientAuComptoir.TabIndex = 0;
            // 
            // lblCodeJournal
            // 
            lblCodeJournal.AutoSize = true;
            lblCodeJournal.Dock = DockStyle.Right;
            lblCodeJournal.Location = new Point(135, 90);
            lblCodeJournal.Name = "lblCodeJournal";
            lblCodeJournal.Size = new Size(75, 40);
            lblCodeJournal.TabIndex = 24;
            lblCodeJournal.Text = "Code journal";
            lblCodeJournal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxIntituleDeLaCaisse);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(216, 13);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(391, 34);
            panel2.TabIndex = 19;
            // 
            // txtBxIntituleDeLaCaisse
            // 
            txtBxIntituleDeLaCaisse.BorderStyle = BorderStyle.None;
            txtBxIntituleDeLaCaisse.Dock = DockStyle.Fill;
            txtBxIntituleDeLaCaisse.Location = new Point(20, 9);
            txtBxIntituleDeLaCaisse.Name = "txtBxIntituleDeLaCaisse";
            //txtBxIntituleDeLaCaisse.PlaceholderText = "Intitulé de la caisse";
            txtBxIntituleDeLaCaisse.Size = new Size(349, 16);
            txtBxIntituleDeLaCaisse.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Dock = DockStyle.Right;
            lblMotDePasse.Location = new Point(104, 50);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(106, 40);
            lblMotDePasse.TabIndex = 6;
            lblMotDePasse.Text = "Client au comptoir";
            lblMotDePasse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Dock = DockStyle.Right;
            lblIntitule.Location = new Point(166, 10);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(44, 40);
            lblIntitule.TabIndex = 0;
            lblIntitule.Text = "Intitulé";
            lblIntitule.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxValeursParDefaut
            // 
            groupBoxValeursParDefaut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxValeursParDefaut.Controls.Add(tableLayoutPanel2);
            groupBoxValeursParDefaut.Location = new Point(22, 235);
            groupBoxValeursParDefaut.Name = "groupBoxValeursParDefaut";
            groupBoxValeursParDefaut.Padding = new Padding(60, 3, 60, 3);
            groupBoxValeursParDefaut.Size = new Size(730, 162);
            groupBoxValeursParDefaut.TabIndex = 24;
            groupBoxValeursParDefaut.TabStop = false;
            groupBoxValeursParDefaut.Text = "Valeurs par défaut";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 3);
            tableLayoutPanel2.Controls.Add(panel1, 1, 1);
            tableLayoutPanel2.Controls.Add(lblCaissierParDefaut, 0, 3);
            tableLayoutPanel2.Controls.Add(lblDepotParDefaut, 0, 1);
            tableLayoutPanel2.Controls.Add(panel7, 1, 2);
            tableLayoutPanel2.Controls.Add(lblVendeurParDefaut, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(610, 140);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBoxCaissierParDefaut);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(216, 93);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(391, 34);
            panel3.TabIndex = 40;
            // 
            // comboBoxCaissierParDefaut
            // 
            comboBoxCaissierParDefaut.Dock = DockStyle.Fill;
            comboBoxCaissierParDefaut.FlatStyle = FlatStyle.Flat;
            comboBoxCaissierParDefaut.FormattingEnabled = true;
            comboBoxCaissierParDefaut.Location = new Point(20, 5);
            comboBoxCaissierParDefaut.Name = "comboBoxCaissierParDefaut";
            comboBoxCaissierParDefaut.Size = new Size(365, 23);
            comboBoxCaissierParDefaut.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxDepotParDefaut);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(216, 13);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 5, 4, 0);
            panel1.Size = new Size(391, 34);
            panel1.TabIndex = 39;
            // 
            // comboBoxDepotParDefaut
            // 
            comboBoxDepotParDefaut.Dock = DockStyle.Fill;
            comboBoxDepotParDefaut.FlatStyle = FlatStyle.Flat;
            comboBoxDepotParDefaut.FormattingEnabled = true;
            comboBoxDepotParDefaut.Location = new Point(20, 5);
            comboBoxDepotParDefaut.Name = "comboBoxDepotParDefaut";
            comboBoxDepotParDefaut.Size = new Size(365, 23);
            comboBoxDepotParDefaut.TabIndex = 0;
            // 
            // lblCaissierParDefaut
            // 
            lblCaissierParDefaut.AutoSize = true;
            lblCaissierParDefaut.Dock = DockStyle.Right;
            lblCaissierParDefaut.Location = new Point(106, 90);
            lblCaissierParDefaut.Name = "lblCaissierParDefaut";
            lblCaissierParDefaut.Size = new Size(104, 40);
            lblCaissierParDefaut.TabIndex = 36;
            lblCaissierParDefaut.Text = "Caissier par défaut";
            lblCaissierParDefaut.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDepotParDefaut
            // 
            lblDepotParDefaut.AutoSize = true;
            lblDepotParDefaut.Dock = DockStyle.Right;
            lblDepotParDefaut.Location = new Point(114, 10);
            lblDepotParDefaut.Name = "lblDepotParDefaut";
            lblDepotParDefaut.Size = new Size(96, 40);
            lblDepotParDefaut.TabIndex = 34;
            lblDepotParDefaut.Text = "Dépot par défaut";
            lblDepotParDefaut.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBoxVendeurParDefaut);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(216, 53);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(391, 34);
            panel7.TabIndex = 31;
            // 
            // comboBoxVendeurParDefaut
            // 
            comboBoxVendeurParDefaut.Dock = DockStyle.Fill;
            comboBoxVendeurParDefaut.FlatStyle = FlatStyle.Flat;
            comboBoxVendeurParDefaut.FormattingEnabled = true;
            comboBoxVendeurParDefaut.Location = new Point(20, 5);
            comboBoxVendeurParDefaut.Name = "comboBoxVendeurParDefaut";
            comboBoxVendeurParDefaut.Size = new Size(365, 23);
            comboBoxVendeurParDefaut.TabIndex = 0;
            // 
            // lblVendeurParDefaut
            // 
            lblVendeurParDefaut.AutoSize = true;
            lblVendeurParDefaut.Dock = DockStyle.Right;
            lblVendeurParDefaut.Location = new Point(103, 50);
            lblVendeurParDefaut.Name = "lblVendeurParDefaut";
            lblVendeurParDefaut.Size = new Size(107, 40);
            lblVendeurParDefaut.TabIndex = 4;
            lblVendeurParDefaut.Text = "Vendeur par défaut";
            lblVendeurParDefaut.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(22, 439);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 15, 60, 15);
            groupBox1.Size = new Size(730, 337);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caissiers de la caisse";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Selectionner, Caissier });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(60, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(610, 291);
            dataGridView1.TabIndex = 34;
            // 
            // Selectionner
            // 
            Selectionner.FillWeight = 76.1421356F;
            Selectionner.HeaderText = "Sélectionner";
            Selectionner.Name = "Selectionner";
            Selectionner.Resizable = DataGridViewTriState.True;
            Selectionner.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Caissier
            // 
            Caissier.FillWeight = 123.857864F;
            Caissier.HeaderText = "Caissier";
            Caissier.Name = "Caissier";
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
            btnEnregistrer.Location = new Point(562, 794);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 26;
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
            iconButtonFermer.Location = new Point(753, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 46;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateUpdateCaisse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 851);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnEnregistrer);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxValeursParDefaut);
            Controls.Add(groupBoxInformationsConcernantLaCaisse);
            Name = "CreateUpdateCaisse";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBoxInformationsConcernantLaCaisse.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxValeursParDefaut.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxInformationsConcernantLaCaisse;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TextBox txtBxIntituleDeLaCaisse;
        private Label lblMotDePasse;
        private Label lblIntitule;
        private Label lblCodeJournal;
        private Panel panel6;
        private ComboBox comboBoxCodeJournal;
        private Panel panel5;
        private ComboBox comboBoxClientAuComptoir;
        private GroupBox groupBoxValeursParDefaut;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private ComboBox comboBoxVendeurParDefaut;
        private Label lblVendeurParDefaut;
        private Panel panel3;
        private ComboBox comboBoxCaissierParDefaut;
        private Panel panel1;
        private ComboBox comboBoxDepotParDefaut;
        private Label lblCaissierParDefaut;
        private Label lblDepotParDefaut;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnEnregistrer;
        private DataGridViewCheckBoxColumn Selectionner;
        private DataGridViewTextBoxColumn Caissier;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}