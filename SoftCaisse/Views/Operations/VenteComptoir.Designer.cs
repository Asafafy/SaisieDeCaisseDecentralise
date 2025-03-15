using System.Drawing;
using System.Windows.Forms;







namespace Soft_Caisse.Views.Operations
{
    partial class VenteComptoir
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTotal = new Panel();
            labelValeurTotalTTC = new Label();
            labelValeurTotalHT = new Label();
            labelTotalTTC = new Label();
            labelTotalHT = new Label();
            panelEnTete = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            comboBoxCentrale = new ComboBox();
            panel8 = new Panel();
            comboBoxAffaire = new ComboBox();
            panel7 = new Panel();
            comboBoxTarif = new ComboBox();
            panel6 = new Panel();
            comboBoxDepot = new ComboBox();
            panel5 = new Panel();
            comboBoxVendeur = new ComboBox();
            panel4 = new Panel();
            comboBoxClient = new ComboBox();
            panel3 = new Panel();
            dateTimePickerCustom = new DateTimePicker();
            txtBxDateTime = new TextBox();
            labelCaissierVal = new Label();
            labelCentrale = new Label();
            labelAffaire = new Label();
            labelTarif = new Label();
            labelDepot = new Label();
            labelVendeur = new Label();
            labelClient = new Label();
            labelCaissier = new Label();
            labelDate = new Label();
            panel18 = new Panel();
            textBoxReference = new TextBox();
            panel19 = new Panel();
            textBoxDesignation = new TextBox();
            panel20 = new Panel();
            textBoxGamme1 = new TextBox();
            panel21 = new Panel();
            textBoxGamme2 = new TextBox();
            panel22 = new Panel();
            textBoxPUHT = new TextBox();
            panel23 = new Panel();
            textBoxPUTTC = new TextBox();
            panel24 = new Panel();
            textBoxQuantite = new TextBox();
            panel25 = new Panel();
            textBoxConditionnement = new TextBox();
            panel26 = new Panel();
            textBoxRemise = new TextBox();
            panel27 = new Panel();
            textBoxPUNet = new TextBox();
            panel30 = new Panel();
            textBoxMontantHT = new TextBox();
            panel31 = new Panel();
            textBoxMontantTTC = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonNouveau = new Button();
            buttonSupprimer = new Button();
            buttonEnregistrer = new Button();
            panelSaisieLigne = new Panel();
            dataGridView1 = new DataGridView();
            Reference = new DataGridViewTextBoxColumn();
            Designation = new DataGridViewTextBoxColumn();
            Gamme1 = new DataGridViewTextBoxColumn();
            Gamme2 = new DataGridViewTextBoxColumn();
            PuHT = new DataGridViewTextBoxColumn();
            PuTTC = new DataGridViewTextBoxColumn();
            Quantite = new DataGridViewTextBoxColumn();
            Conditionnement = new DataGridViewTextBoxColumn();
            Remise = new DataGridViewTextBoxColumn();
            PuNet = new DataGridViewTextBoxColumn();
            MontantHT = new DataGridViewTextBoxColumn();
            MontantTTC = new DataGridViewTextBoxColumn();
            buttonFinDeSaisie = new Button();
            buttonAnnuler = new Button();
            buttonEnAttente = new Button();
            buttonRappelTicket = new Button();
            buttonNumeroDocument = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panelTotal.SuspendLayout();
            panelEnTete.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel30.SuspendLayout();
            panel31.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelSaisieLigne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelTotal, 1, 0);
            tableLayoutPanel1.Controls.Add(panelEnTete, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 91);
            tableLayoutPanel1.Margin = new Padding(3, 3, 0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1174, 194);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelTotal.Controls.Add(labelValeurTotalTTC);
            panelTotal.Controls.Add(labelValeurTotalHT);
            panelTotal.Controls.Add(labelTotalTTC);
            panelTotal.Controls.Add(labelTotalHT);
            panelTotal.Dock = DockStyle.Fill;
            panelTotal.Location = new Point(592, 5);
            panelTotal.Margin = new Padding(5, 5, 0, 5);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(582, 184);
            panelTotal.TabIndex = 1;
            // 
            // labelValeurTotalTTC
            // 
            labelValeurTotalTTC.AutoSize = true;
            labelValeurTotalTTC.BackColor = Color.Transparent;
            labelValeurTotalTTC.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelValeurTotalTTC.ForeColor = Color.White;
            labelValeurTotalTTC.Location = new Point(276, 115);
            labelValeurTotalTTC.Name = "labelValeurTotalTTC";
            labelValeurTotalTTC.Size = new Size(77, 41);
            labelValeurTotalTTC.TabIndex = 3;
            labelValeurTotalTTC.Text = "0,00";
            // 
            // labelValeurTotalHT
            // 
            labelValeurTotalHT.AutoSize = true;
            labelValeurTotalHT.BackColor = Color.Transparent;
            labelValeurTotalHT.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelValeurTotalHT.ForeColor = Color.White;
            labelValeurTotalHT.Location = new Point(276, 28);
            labelValeurTotalHT.Name = "labelValeurTotalHT";
            labelValeurTotalHT.Size = new Size(77, 41);
            labelValeurTotalHT.TabIndex = 2;
            labelValeurTotalHT.Text = "0,00";
            // 
            // labelTotalTTC
            // 
            labelTotalTTC.AutoSize = true;
            labelTotalTTC.BackColor = Color.Transparent;
            labelTotalTTC.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTotalTTC.ForeColor = Color.White;
            labelTotalTTC.Location = new Point(28, 115);
            labelTotalTTC.Name = "labelTotalTTC";
            labelTotalTTC.Size = new Size(167, 41);
            labelTotalTTC.TabIndex = 1;
            labelTotalTTC.Text = "Total TTC :";
            // 
            // labelTotalHT
            // 
            labelTotalHT.AutoSize = true;
            labelTotalHT.BackColor = Color.Transparent;
            labelTotalHT.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTotalHT.ForeColor = Color.White;
            labelTotalHT.Location = new Point(28, 28);
            labelTotalHT.Name = "labelTotalHT";
            labelTotalHT.Size = new Size(153, 41);
            labelTotalHT.TabIndex = 0;
            labelTotalHT.Text = "Total HT :";
            // 
            // panelEnTete
            // 
            panelEnTete.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelEnTete.Controls.Add(tableLayoutPanel2);
            panelEnTete.Dock = DockStyle.Fill;
            panelEnTete.Location = new Point(0, 5);
            panelEnTete.Margin = new Padding(0, 5, 5, 5);
            panelEnTete.Name = "panelEnTete";
            panelEnTete.Padding = new Padding(12);
            panelEnTete.Size = new Size(582, 184);
            panelEnTete.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(panel9, 3, 3);
            tableLayoutPanel2.Controls.Add(panel8, 1, 3);
            tableLayoutPanel2.Controls.Add(panel7, 3, 2);
            tableLayoutPanel2.Controls.Add(panel6, 1, 2);
            tableLayoutPanel2.Controls.Add(panel5, 3, 1);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(panel3, 3, 0);
            tableLayoutPanel2.Controls.Add(labelCaissierVal, 1, 0);
            tableLayoutPanel2.Controls.Add(labelCentrale, 2, 3);
            tableLayoutPanel2.Controls.Add(labelAffaire, 0, 3);
            tableLayoutPanel2.Controls.Add(labelTarif, 2, 2);
            tableLayoutPanel2.Controls.Add(labelDepot, 0, 2);
            tableLayoutPanel2.Controls.Add(labelVendeur, 2, 1);
            tableLayoutPanel2.Controls.Add(labelClient, 0, 1);
            tableLayoutPanel2.Controls.Add(labelCaissier, 0, 0);
            tableLayoutPanel2.Controls.Add(labelDate, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(558, 160);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(comboBoxCentrale);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(364, 123);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 5, 4, 0);
            panel9.Size = new Size(191, 34);
            panel9.TabIndex = 32;
            // 
            // comboBoxCentrale
            // 
            comboBoxCentrale.Dock = DockStyle.Fill;
            comboBoxCentrale.FlatStyle = FlatStyle.Flat;
            comboBoxCentrale.FormattingEnabled = true;
            comboBoxCentrale.Location = new Point(20, 5);
            comboBoxCentrale.Name = "comboBoxCentrale";
            comboBoxCentrale.Size = new Size(165, 23);
            comboBoxCentrale.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(comboBoxAffaire);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(86, 123);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 5, 4, 0);
            panel8.Size = new Size(189, 34);
            panel8.TabIndex = 31;
            // 
            // comboBoxAffaire
            // 
            comboBoxAffaire.Dock = DockStyle.Fill;
            comboBoxAffaire.FlatStyle = FlatStyle.Flat;
            comboBoxAffaire.FormattingEnabled = true;
            comboBoxAffaire.Location = new Point(20, 5);
            comboBoxAffaire.Name = "comboBoxAffaire";
            comboBoxAffaire.Size = new Size(163, 23);
            comboBoxAffaire.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBoxTarif);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(364, 83);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(191, 34);
            panel7.TabIndex = 30;
            // 
            // comboBoxTarif
            // 
            comboBoxTarif.Dock = DockStyle.Fill;
            comboBoxTarif.FlatStyle = FlatStyle.Flat;
            comboBoxTarif.FormattingEnabled = true;
            comboBoxTarif.Location = new Point(20, 5);
            comboBoxTarif.Name = "comboBoxTarif";
            comboBoxTarif.Size = new Size(165, 23);
            comboBoxTarif.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxDepot);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(86, 83);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(189, 34);
            panel6.TabIndex = 29;
            // 
            // comboBoxDepot
            // 
            comboBoxDepot.Dock = DockStyle.Fill;
            comboBoxDepot.FlatStyle = FlatStyle.Flat;
            comboBoxDepot.FormattingEnabled = true;
            comboBoxDepot.Location = new Point(20, 5);
            comboBoxDepot.Name = "comboBoxDepot";
            comboBoxDepot.Size = new Size(163, 23);
            comboBoxDepot.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBoxVendeur);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(364, 43);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(191, 34);
            panel5.TabIndex = 28;
            // 
            // comboBoxVendeur
            // 
            comboBoxVendeur.Dock = DockStyle.Fill;
            comboBoxVendeur.FlatStyle = FlatStyle.Flat;
            comboBoxVendeur.FormattingEnabled = true;
            comboBoxVendeur.Location = new Point(20, 5);
            comboBoxVendeur.Name = "comboBoxVendeur";
            comboBoxVendeur.Size = new Size(165, 23);
            comboBoxVendeur.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxClient);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(86, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(189, 34);
            panel4.TabIndex = 27;
            // 
            // comboBoxClient
            // 
            comboBoxClient.Dock = DockStyle.Fill;
            comboBoxClient.FlatStyle = FlatStyle.Flat;
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(20, 5);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(163, 23);
            comboBoxClient.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dateTimePickerCustom);
            panel3.Controls.Add(txtBxDateTime);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(364, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(191, 34);
            panel3.TabIndex = 25;
            // 
            // dateTimePickerCustom
            // 
            dateTimePickerCustom.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerCustom.Location = new Point(1, 34);
            dateTimePickerCustom.Name = "dateTimePickerCustom";
            dateTimePickerCustom.Size = new Size(158, 23);
            dateTimePickerCustom.TabIndex = 25;
            dateTimePickerCustom.ValueChanged += dateTimePickerCustom_ValueChanged;
            // 
            // txtBxDateTime
            // 
            txtBxDateTime.BorderStyle = BorderStyle.None;
            txtBxDateTime.Dock = DockStyle.Fill;
            txtBxDateTime.Location = new Point(20, 9);
            txtBxDateTime.Name = "txtBxDateTime";
            //txtBxDateTime.PlaceholderText = "DD/MM/YYYY";
            txtBxDateTime.Size = new Size(149, 16);
            txtBxDateTime.TabIndex = 0;
            txtBxDateTime.Click += txtBxDateTime_Click;
            // 
            // labelCaissierVal
            // 
            labelCaissierVal.AutoSize = true;
            labelCaissierVal.Dock = DockStyle.Left;
            labelCaissierVal.ForeColor = Color.White;
            labelCaissierVal.Location = new Point(86, 0);
            labelCaissierVal.Name = "labelCaissierVal";
            labelCaissierVal.Padding = new Padding(20, 0, 0, 0);
            labelCaissierVal.Size = new Size(67, 40);
            labelCaissierVal.TabIndex = 15;
            labelCaissierVal.Text = "Caissier";
            labelCaissierVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCentrale
            // 
            labelCentrale.AutoSize = true;
            labelCentrale.Dock = DockStyle.Right;
            labelCentrale.ForeColor = Color.White;
            labelCentrale.Location = new Point(307, 120);
            labelCentrale.Name = "labelCentrale";
            labelCentrale.Size = new Size(51, 40);
            labelCentrale.TabIndex = 14;
            labelCentrale.Text = "Centrale";
            labelCentrale.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAffaire
            // 
            labelAffaire.AutoSize = true;
            labelAffaire.Dock = DockStyle.Right;
            labelAffaire.ForeColor = Color.White;
            labelAffaire.Location = new Point(38, 120);
            labelAffaire.Name = "labelAffaire";
            labelAffaire.Size = new Size(42, 40);
            labelAffaire.TabIndex = 12;
            labelAffaire.Text = "Affaire";
            labelAffaire.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTarif
            // 
            labelTarif.AutoSize = true;
            labelTarif.Dock = DockStyle.Right;
            labelTarif.ForeColor = Color.White;
            labelTarif.Location = new Point(328, 80);
            labelTarif.Name = "labelTarif";
            labelTarif.Size = new Size(30, 40);
            labelTarif.TabIndex = 10;
            labelTarif.Text = "Tarif";
            labelTarif.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDepot
            // 
            labelDepot.AutoSize = true;
            labelDepot.Dock = DockStyle.Right;
            labelDepot.ForeColor = Color.White;
            labelDepot.Location = new Point(41, 80);
            labelDepot.Name = "labelDepot";
            labelDepot.Size = new Size(39, 40);
            labelDepot.TabIndex = 8;
            labelDepot.Text = "Dépôt";
            labelDepot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelVendeur
            // 
            labelVendeur.AutoSize = true;
            labelVendeur.Dock = DockStyle.Right;
            labelVendeur.ForeColor = Color.White;
            labelVendeur.Location = new Point(308, 40);
            labelVendeur.Name = "labelVendeur";
            labelVendeur.Size = new Size(50, 40);
            labelVendeur.TabIndex = 6;
            labelVendeur.Text = "Vendeur";
            labelVendeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Dock = DockStyle.Right;
            labelClient.ForeColor = Color.White;
            labelClient.Location = new Point(42, 40);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(38, 40);
            labelClient.TabIndex = 4;
            labelClient.Text = "Client";
            labelClient.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCaissier
            // 
            labelCaissier.AutoSize = true;
            labelCaissier.Dock = DockStyle.Right;
            labelCaissier.ForeColor = Color.White;
            labelCaissier.Location = new Point(33, 0);
            labelCaissier.Name = "labelCaissier";
            labelCaissier.Size = new Size(47, 40);
            labelCaissier.TabIndex = 1;
            labelCaissier.Text = "Caissier";
            labelCaissier.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = DockStyle.Right;
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(327, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 40);
            labelDate.TabIndex = 0;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(textBoxReference);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(3, 13);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(5, 8, 5, 10);
            panel18.Size = new Size(89, 34);
            panel18.TabIndex = 31;
            // 
            // textBoxReference
            // 
            textBoxReference.BorderStyle = BorderStyle.None;
            textBoxReference.Dock = DockStyle.Fill;
            textBoxReference.Location = new Point(5, 8);
            textBoxReference.Name = "textBoxReference";
            //textBoxReference.PlaceholderText = "Référence";
            textBoxReference.Size = new Size(77, 16);
            textBoxReference.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.BorderStyle = BorderStyle.FixedSingle;
            panel19.Controls.Add(textBoxDesignation);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(98, 13);
            panel19.Name = "panel19";
            panel19.Padding = new Padding(5, 8, 5, 10);
            panel19.Size = new Size(89, 34);
            panel19.TabIndex = 32;
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.BorderStyle = BorderStyle.None;
            textBoxDesignation.Dock = DockStyle.Fill;
            textBoxDesignation.Location = new Point(5, 8);
            textBoxDesignation.Name = "textBoxDesignation";
            //textBoxDesignation.PlaceholderText = "Désignation";
            textBoxDesignation.Size = new Size(77, 16);
            textBoxDesignation.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.BackColor = Color.White;
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(textBoxGamme1);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(193, 13);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(5, 8, 5, 10);
            panel20.Size = new Size(89, 34);
            panel20.TabIndex = 33;
            // 
            // textBoxGamme1
            // 
            textBoxGamme1.BorderStyle = BorderStyle.None;
            textBoxGamme1.Dock = DockStyle.Fill;
            textBoxGamme1.Location = new Point(5, 8);
            textBoxGamme1.Name = "textBoxGamme1";
            //textBoxGamme1.PlaceholderText = "Gamme 1";
            textBoxGamme1.Size = new Size(77, 16);
            textBoxGamme1.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.BackColor = Color.White;
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(textBoxGamme2);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(288, 13);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(5, 8, 5, 10);
            panel21.Size = new Size(89, 34);
            panel21.TabIndex = 34;
            // 
            // textBoxGamme2
            // 
            textBoxGamme2.BorderStyle = BorderStyle.None;
            textBoxGamme2.Dock = DockStyle.Fill;
            textBoxGamme2.Location = new Point(5, 8);
            textBoxGamme2.Name = "textBoxGamme2";
            //textBoxGamme2.PlaceholderText = "Gamme 2";
            textBoxGamme2.Size = new Size(77, 16);
            textBoxGamme2.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.BorderStyle = BorderStyle.FixedSingle;
            panel22.Controls.Add(textBoxPUHT);
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(383, 13);
            panel22.Name = "panel22";
            panel22.Padding = new Padding(5, 8, 5, 10);
            panel22.Size = new Size(89, 34);
            panel22.TabIndex = 35;
            // 
            // textBoxPUHT
            // 
            textBoxPUHT.BorderStyle = BorderStyle.None;
            textBoxPUHT.Dock = DockStyle.Fill;
            textBoxPUHT.Location = new Point(5, 8);
            textBoxPUHT.Name = "textBoxPUHT";
            //textBoxPUHT.PlaceholderText = "Pu HT";
            textBoxPUHT.Size = new Size(77, 16);
            textBoxPUHT.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.BackColor = Color.White;
            panel23.BorderStyle = BorderStyle.FixedSingle;
            panel23.Controls.Add(textBoxPUTTC);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(478, 13);
            panel23.Name = "panel23";
            panel23.Padding = new Padding(5, 8, 5, 10);
            panel23.Size = new Size(89, 34);
            panel23.TabIndex = 36;
            // 
            // textBoxPUTTC
            // 
            textBoxPUTTC.BorderStyle = BorderStyle.None;
            textBoxPUTTC.Dock = DockStyle.Fill;
            textBoxPUTTC.Location = new Point(5, 8);
            textBoxPUTTC.Name = "textBoxPUTTC";
            //textBoxPUTTC.PlaceholderText = "Pu TTC";
            textBoxPUTTC.Size = new Size(77, 16);
            textBoxPUTTC.TabIndex = 0;
            // 
            // panel24
            // 
            panel24.BackColor = Color.White;
            panel24.BorderStyle = BorderStyle.FixedSingle;
            panel24.Controls.Add(textBoxQuantite);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(573, 13);
            panel24.Name = "panel24";
            panel24.Padding = new Padding(5, 8, 5, 10);
            panel24.Size = new Size(89, 34);
            panel24.TabIndex = 37;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.BorderStyle = BorderStyle.None;
            textBoxQuantite.Dock = DockStyle.Fill;
            textBoxQuantite.Location = new Point(5, 8);
            textBoxQuantite.Name = "textBoxQuantite";
            //textBoxQuantite.PlaceholderText = "Quantité";
            textBoxQuantite.Size = new Size(77, 16);
            textBoxQuantite.TabIndex = 0;
            // 
            // panel25
            // 
            panel25.BackColor = Color.White;
            panel25.BorderStyle = BorderStyle.FixedSingle;
            panel25.Controls.Add(textBoxConditionnement);
            panel25.Dock = DockStyle.Fill;
            panel25.Location = new Point(668, 13);
            panel25.Name = "panel25";
            panel25.Padding = new Padding(5, 8, 5, 10);
            panel25.Size = new Size(89, 34);
            panel25.TabIndex = 38;
            // 
            // textBoxConditionnement
            // 
            textBoxConditionnement.BorderStyle = BorderStyle.None;
            textBoxConditionnement.Dock = DockStyle.Fill;
            textBoxConditionnement.Location = new Point(5, 8);
            textBoxConditionnement.Name = "textBoxConditionnement";
            //textBoxConditionnement.PlaceholderText = "Conditionnement";
            textBoxConditionnement.Size = new Size(77, 16);
            textBoxConditionnement.TabIndex = 0;
            // 
            // panel26
            // 
            panel26.BackColor = Color.White;
            panel26.BorderStyle = BorderStyle.FixedSingle;
            panel26.Controls.Add(textBoxRemise);
            panel26.Dock = DockStyle.Fill;
            panel26.Location = new Point(763, 13);
            panel26.Name = "panel26";
            panel26.Padding = new Padding(5, 8, 5, 10);
            panel26.Size = new Size(89, 34);
            panel26.TabIndex = 39;
            // 
            // textBoxRemise
            // 
            textBoxRemise.BorderStyle = BorderStyle.None;
            textBoxRemise.Dock = DockStyle.Fill;
            textBoxRemise.Location = new Point(5, 8);
            textBoxRemise.Name = "textBoxRemise";
            //textBoxRemise.PlaceholderText = "Remise";
            textBoxRemise.Size = new Size(77, 16);
            textBoxRemise.TabIndex = 0;
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(textBoxPUNet);
            panel27.Dock = DockStyle.Fill;
            panel27.Location = new Point(858, 13);
            panel27.Name = "panel27";
            panel27.Padding = new Padding(5, 8, 5, 10);
            panel27.Size = new Size(89, 34);
            panel27.TabIndex = 40;
            // 
            // textBoxPUNet
            // 
            textBoxPUNet.BorderStyle = BorderStyle.None;
            textBoxPUNet.Dock = DockStyle.Fill;
            textBoxPUNet.Location = new Point(5, 8);
            textBoxPUNet.Name = "textBoxPUNet";
            //textBoxPUNet.PlaceholderText = "Pu Net";
            textBoxPUNet.Size = new Size(77, 16);
            textBoxPUNet.TabIndex = 0;
            // 
            // panel30
            // 
            panel30.BackColor = Color.White;
            panel30.BorderStyle = BorderStyle.FixedSingle;
            panel30.Controls.Add(textBoxMontantHT);
            panel30.Dock = DockStyle.Fill;
            panel30.Location = new Point(953, 13);
            panel30.Name = "panel30";
            panel30.Padding = new Padding(5, 8, 5, 10);
            panel30.Size = new Size(89, 34);
            panel30.TabIndex = 53;
            // 
            // textBoxMontantHT
            // 
            textBoxMontantHT.BorderStyle = BorderStyle.None;
            textBoxMontantHT.Dock = DockStyle.Fill;
            textBoxMontantHT.Location = new Point(5, 8);
            textBoxMontantHT.Name = "textBoxMontantHT";
            //textBoxMontantHT.PlaceholderText = "Montant HT";
            textBoxMontantHT.Size = new Size(77, 16);
            textBoxMontantHT.TabIndex = 0;
            // 
            // panel31
            // 
            panel31.BackColor = Color.White;
            panel31.BorderStyle = BorderStyle.FixedSingle;
            panel31.Controls.Add(textBoxMontantTTC);
            panel31.Dock = DockStyle.Fill;
            panel31.Location = new Point(1048, 13);
            panel31.Name = "panel31";
            panel31.Padding = new Padding(5, 8, 5, 10);
            panel31.Size = new Size(97, 34);
            panel31.TabIndex = 54;
            // 
            // textBoxMontantTTC
            // 
            textBoxMontantTTC.BorderStyle = BorderStyle.None;
            textBoxMontantTTC.Dock = DockStyle.Fill;
            textBoxMontantTTC.Location = new Point(5, 8);
            textBoxMontantTTC.Name = "textBoxMontantTTC";
            //textBoxMontantTTC.PlaceholderText = "Montant TTC";
            textBoxMontantTTC.Size = new Size(85, 16);
            textBoxMontantTTC.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 12;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.342502F));
            tableLayoutPanel3.Controls.Add(panel31, 11, 1);
            tableLayoutPanel3.Controls.Add(panel30, 10, 1);
            tableLayoutPanel3.Controls.Add(panel27, 9, 1);
            tableLayoutPanel3.Controls.Add(panel26, 8, 1);
            tableLayoutPanel3.Controls.Add(panel25, 7, 1);
            tableLayoutPanel3.Controls.Add(panel24, 6, 1);
            tableLayoutPanel3.Controls.Add(panel23, 5, 1);
            tableLayoutPanel3.Controls.Add(panel22, 4, 1);
            tableLayoutPanel3.Controls.Add(panel21, 3, 1);
            tableLayoutPanel3.Controls.Add(panel20, 2, 1);
            tableLayoutPanel3.Controls.Add(panel19, 1, 1);
            tableLayoutPanel3.Controls.Add(panel18, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(12, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1148, 60);
            tableLayoutPanel3.TabIndex = 25;
            // 
            // buttonNouveau
            // 
            buttonNouveau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNouveau.BackColor = Color.FromArgb(129, 166, 181);
            buttonNouveau.Cursor = Cursors.Hand;
            buttonNouveau.FlatAppearance.BorderSize = 0;
            buttonNouveau.FlatStyle = FlatStyle.Flat;
            buttonNouveau.Font = new Font("Segoe UI", 11F);
            buttonNouveau.ForeColor = Color.White;
            buttonNouveau.Location = new Point(586, 73);
            buttonNouveau.Margin = new Padding(144, 3, 144, 3);
            buttonNouveau.Name = "buttonNouveau";
            buttonNouveau.Padding = new Padding(8, 0, 0, 0);
            buttonNouveau.Size = new Size(185, 45);
            buttonNouveau.TabIndex = 26;
            buttonNouveau.Text = "Nouveau";
            buttonNouveau.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.FlatAppearance.BorderSize = 0;
            buttonSupprimer.FlatStyle = FlatStyle.Flat;
            buttonSupprimer.Font = new Font("Segoe UI", 11F);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(780, 73);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(185, 45);
            buttonSupprimer.TabIndex = 27;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            buttonEnregistrer.Cursor = Cursors.Hand;
            buttonEnregistrer.FlatAppearance.BorderSize = 0;
            buttonEnregistrer.FlatStyle = FlatStyle.Flat;
            buttonEnregistrer.Font = new Font("Segoe UI", 11F);
            buttonEnregistrer.ForeColor = Color.White;
            buttonEnregistrer.Location = new Point(975, 73);
            buttonEnregistrer.Margin = new Padding(144, 3, 144, 3);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Padding = new Padding(8, 0, 0, 0);
            buttonEnregistrer.Size = new Size(185, 45);
            buttonEnregistrer.TabIndex = 28;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
            // 
            // panelSaisieLigne
            // 
            panelSaisieLigne.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSaisieLigne.BackColor = Color.Transparent;
            panelSaisieLigne.BorderStyle = BorderStyle.FixedSingle;
            panelSaisieLigne.Controls.Add(tableLayoutPanel3);
            panelSaisieLigne.Controls.Add(buttonEnregistrer);
            panelSaisieLigne.Controls.Add(buttonSupprimer);
            panelSaisieLigne.Controls.Add(buttonNouveau);
            panelSaisieLigne.Location = new Point(12, 314);
            panelSaisieLigne.Name = "panelSaisieLigne";
            panelSaisieLigne.Padding = new Padding(12);
            panelSaisieLigne.Size = new Size(1174, 135);
            panelSaisieLigne.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Reference, Designation, Gamme1, Gamme2, PuHT, PuTTC, Quantite, Conditionnement, Remise, PuNet, MontantHT, MontantTTC });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 466);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1174, 336);
            dataGridView1.TabIndex = 30;
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.Name = "Reference";
            // 
            // Designation
            // 
            Designation.HeaderText = "Désignation";
            Designation.Name = "Designation";
            // 
            // Gamme1
            // 
            Gamme1.HeaderText = "Gamme 1";
            Gamme1.Name = "Gamme1";
            // 
            // Gamme2
            // 
            Gamme2.HeaderText = "Gamme 2";
            Gamme2.Name = "Gamme2";
            // 
            // PuHT
            // 
            PuHT.HeaderText = "Pu HT";
            PuHT.Name = "PuHT";
            // 
            // PuTTC
            // 
            PuTTC.HeaderText = "Pu TTC";
            PuTTC.Name = "PuTTC";
            // 
            // Quantite
            // 
            Quantite.HeaderText = "Quantité";
            Quantite.Name = "Quantite";
            // 
            // Conditionnement
            // 
            Conditionnement.HeaderText = "Conditionnement";
            Conditionnement.Name = "Conditionnement";
            // 
            // Remise
            // 
            Remise.HeaderText = "Remise";
            Remise.Name = "Remise";
            // 
            // PuNet
            // 
            PuNet.HeaderText = "Pu Net";
            PuNet.Name = "PuNet";
            // 
            // MontantHT
            // 
            MontantHT.HeaderText = "Montant HT";
            MontantHT.Name = "MontantHT";
            // 
            // MontantTTC
            // 
            MontantTTC.HeaderText = "Montant TTC";
            MontantTTC.Name = "MontantTTC";
            // 
            // buttonFinDeSaisie
            // 
            buttonFinDeSaisie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFinDeSaisie.BackColor = Color.FromArgb(84, 138, 178);
            buttonFinDeSaisie.Cursor = Cursors.Hand;
            buttonFinDeSaisie.FlatAppearance.BorderSize = 0;
            buttonFinDeSaisie.FlatStyle = FlatStyle.Flat;
            buttonFinDeSaisie.Font = new Font("Segoe UI", 11F);
            buttonFinDeSaisie.ForeColor = Color.White;
            buttonFinDeSaisie.Location = new Point(797, 837);
            buttonFinDeSaisie.Margin = new Padding(144, 3, 144, 3);
            buttonFinDeSaisie.Name = "buttonFinDeSaisie";
            buttonFinDeSaisie.Padding = new Padding(8, 0, 0, 0);
            buttonFinDeSaisie.Size = new Size(190, 45);
            buttonFinDeSaisie.TabIndex = 31;
            buttonFinDeSaisie.Text = "Fin de saisie";
            buttonFinDeSaisie.UseVisualStyleBackColor = false;
            buttonFinDeSaisie.Click += buttonFinDeSaisie_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAnnuler.BackColor = Color.FromArgb(84, 138, 178);
            buttonAnnuler.Cursor = Cursors.Hand;
            buttonAnnuler.FlatAppearance.BorderSize = 0;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Font = new Font("Segoe UI", 11F);
            buttonAnnuler.ForeColor = Color.White;
            buttonAnnuler.Location = new Point(996, 837);
            buttonAnnuler.Margin = new Padding(144, 3, 144, 3);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Padding = new Padding(8, 0, 0, 0);
            buttonAnnuler.Size = new Size(190, 45);
            buttonAnnuler.TabIndex = 32;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonEnAttente
            // 
            buttonEnAttente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEnAttente.BackColor = Color.FromArgb(84, 138, 178);
            buttonEnAttente.Cursor = Cursors.Hand;
            buttonEnAttente.FlatAppearance.BorderSize = 0;
            buttonEnAttente.FlatStyle = FlatStyle.Flat;
            buttonEnAttente.Font = new Font("Segoe UI", 11F);
            buttonEnAttente.ForeColor = Color.White;
            buttonEnAttente.Location = new Point(598, 837);
            buttonEnAttente.Margin = new Padding(144, 3, 144, 3);
            buttonEnAttente.Name = "buttonEnAttente";
            buttonEnAttente.Padding = new Padding(8, 0, 0, 0);
            buttonEnAttente.Size = new Size(190, 45);
            buttonEnAttente.TabIndex = 33;
            buttonEnAttente.Text = "En attente";
            buttonEnAttente.UseVisualStyleBackColor = false;
            // 
            // buttonRappelTicket
            // 
            buttonRappelTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRappelTicket.BackColor = Color.FromArgb(84, 138, 178);
            buttonRappelTicket.Cursor = Cursors.Hand;
            buttonRappelTicket.FlatAppearance.BorderSize = 0;
            buttonRappelTicket.FlatStyle = FlatStyle.Flat;
            buttonRappelTicket.Font = new Font("Segoe UI", 11F);
            buttonRappelTicket.ForeColor = Color.White;
            buttonRappelTicket.Location = new Point(400, 837);
            buttonRappelTicket.Margin = new Padding(144, 3, 144, 3);
            buttonRappelTicket.Name = "buttonRappelTicket";
            buttonRappelTicket.Padding = new Padding(8, 0, 0, 0);
            buttonRappelTicket.Size = new Size(190, 45);
            buttonRappelTicket.TabIndex = 34;
            buttonRappelTicket.Text = "Rappel ticket";
            buttonRappelTicket.UseVisualStyleBackColor = false;
            buttonRappelTicket.Click += buttonRappelTicket_Click;
            // 
            // buttonNumeroDocument
            // 
            buttonNumeroDocument.BackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroDocument.FlatAppearance.BorderSize = 0;
            buttonNumeroDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroDocument.FlatStyle = FlatStyle.Flat;
            buttonNumeroDocument.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNumeroDocument.ForeColor = Color.White;
            buttonNumeroDocument.Location = new Point(11, 33);
            buttonNumeroDocument.Margin = new Padding(144, 3, 144, 3);
            buttonNumeroDocument.Name = "buttonNumeroDocument";
            buttonNumeroDocument.Padding = new Padding(8, 0, 0, 0);
            buttonNumeroDocument.Size = new Size(582, 45);
            buttonNumeroDocument.TabIndex = 35;
            buttonNumeroDocument.Text = "FA00010";
            buttonNumeroDocument.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(1182, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 73;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // VenteComptoir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1234, 901);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonNumeroDocument);
            Controls.Add(buttonRappelTicket);
            Controls.Add(buttonEnAttente);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonFinDeSaisie);
            Controls.Add(dataGridView1);
            Controls.Add(panelSaisieLigne);
            Controls.Add(tableLayoutPanel1);
            Name = "VenteComptoir";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Vente comptoir";
            Load += VenteComptoir_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelEnTete.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panelSaisieLigne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTotal;
        private Panel panelEnTete;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelCentrale;
        private Label labelAffaire;
        private Label labelTarif;
        private Label labelDepot;
        private Label labelVendeur;
        private Label labelClient;
        private Label labelCaissier;
        private Label labelDate;
        private Label labelCaissierVal;
        private Panel panel3;
        private DateTimePicker dateTimePickerCustom;
        private TextBox txtBxDateTime;
        private Panel panel9;
        private ComboBox comboBoxCentrale;
        private Panel panel8;
        private ComboBox comboBoxAffaire;
        private Panel panel7;
        private ComboBox comboBoxTarif;
        private Panel panel6;
        private ComboBox comboBoxDepot;
        private Panel panel5;
        private ComboBox comboBoxVendeur;
        private Panel panel4;
        private ComboBox comboBoxClient;
        private Label labelTotalHT;
        private Label labelTotalTTC;
        private Label labelValeurTotalTTC;
        private Label labelValeurTotalHT;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel27;
        private TextBox textBoxPUNet;
        private Panel panel26;
        private TextBox textBoxRemise;
        private Panel panel25;
        private TextBox textBoxConditionnement;
        private Panel panel24;
        private TextBox textBoxQuantite;
        private Panel panel23;
        private TextBox textBoxPUTTC;
        private Panel panel22;
        private TextBox textBoxPUHT;
        private Panel panel21;
        private TextBox textBoxGamme2;
        private Panel panel20;
        private TextBox textBoxGamme1;
        private Panel panel19;
        private TextBox textBoxDesignation;
        private Panel panel18;
        private TextBox textBoxReference;
        private Panel panel30;
        private TextBox textBoxMontantHT;
        private Panel panel31;
        private TextBox textBoxMontantTTC;
        private Button buttonNouveau;
        private Button buttonSupprimer;
        private Button buttonEnregistrer;
        private Panel panelSaisieLigne;
        private DataGridView dataGridView1;
        private Button btnModifier;
        private Button buttonNumeroDocument;
        private Button buttonEnAttente;
        private Button buttonRappelTicket;
        private Button buttonFinDeSaisie;
        private Button buttonAnnuler;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn Gamme1;
        private DataGridViewTextBoxColumn Gamme2;
        private DataGridViewTextBoxColumn PuHT;
        private DataGridViewTextBoxColumn PuTTC;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn Conditionnement;
        private DataGridViewTextBoxColumn Remise;
        private DataGridViewTextBoxColumn PuNet;
        private DataGridViewTextBoxColumn MontantHT;
        private DataGridViewTextBoxColumn MontantTTC;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}