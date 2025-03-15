using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class TarifsArticles
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelPrixDeVenteDeLArticle = new Panel();
            txtBxPrixDeVente = new TextBox();
            panel4 = new Panel();
            txtBxCoutStandard = new TextBox();
            panelCoefficient = new Panel();
            txtBxCoefficient = new TextBox();
            panel1 = new Panel();
            txtBxDernierPrixDAchat = new TextBox();
            panelPrixDAchat = new Panel();
            txtBxPrixDAchat = new TextBox();
            panel7 = new Panel();
            comboBoxHTouTTC = new ComboBox();
            panel6 = new Panel();
            comboBoxUniteDeVente = new ComboBox();
            lblUniteDeVente = new Label();
            lblPrixDeVente = new Label();
            lblCoutStandard = new Label();
            lblCoefficient = new Label();
            lblDernierPrixDAchat = new Label();
            lblPrixDAchat = new Label();
            groupBoxCategoriesTarifaires = new GroupBox();
            dataGridViewCategoriesTarifaires = new DataGridView();
            Categories = new DataGridViewTextBoxColumn();
            Coefficient = new DataGridViewTextBoxColumn();
            PrixDeVente = new DataGridViewTextBoxColumn();
            Remise = new DataGridViewTextBoxColumn();
            groupBoxTarifsClients = new GroupBox();
            dataGridViewTarifsClients = new DataGridView();
            Client = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnEnregistrer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelPrixDeVenteDeLArticle.SuspendLayout();
            panel4.SuspendLayout();
            panelCoefficient.SuspendLayout();
            panel1.SuspendLayout();
            panelPrixDAchat.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            groupBoxCategoriesTarifaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoriesTarifaires).BeginInit();
            groupBoxTarifsClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifsClients).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(30, 3, 83, 3);
            groupBox1.Size = new Size(1062, 179);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarifs par défaut";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(panelPrixDeVenteDeLArticle, 1, 3);
            tableLayoutPanel1.Controls.Add(panel4, 4, 2);
            tableLayoutPanel1.Controls.Add(panelCoefficient, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 4, 1);
            tableLayoutPanel1.Controls.Add(panelPrixDAchat, 1, 1);
            tableLayoutPanel1.Controls.Add(panel7, 2, 3);
            tableLayoutPanel1.Controls.Add(panel6, 4, 3);
            tableLayoutPanel1.Controls.Add(lblUniteDeVente, 3, 3);
            tableLayoutPanel1.Controls.Add(lblPrixDeVente, 0, 3);
            tableLayoutPanel1.Controls.Add(lblCoutStandard, 3, 2);
            tableLayoutPanel1.Controls.Add(lblCoefficient, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDernierPrixDAchat, 3, 1);
            tableLayoutPanel1.Controls.Add(lblPrixDAchat, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(949, 157);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelPrixDeVenteDeLArticle
            // 
            panelPrixDeVenteDeLArticle.BackColor = Color.White;
            panelPrixDeVenteDeLArticle.BorderStyle = BorderStyle.FixedSingle;
            panelPrixDeVenteDeLArticle.Controls.Add(txtBxPrixDeVente);
            panelPrixDeVenteDeLArticle.Dock = DockStyle.Fill;
            panelPrixDeVenteDeLArticle.Location = new Point(145, 103);
            panelPrixDeVenteDeLArticle.Name = "panelPrixDeVenteDeLArticle";
            panelPrixDeVenteDeLArticle.Padding = new Padding(20, 9, 20, 10);
            panelPrixDeVenteDeLArticle.Size = new Size(231, 34);
            panelPrixDeVenteDeLArticle.TabIndex = 40;
            // 
            // txtBxPrixDeVente
            // 
            txtBxPrixDeVente.BorderStyle = BorderStyle.None;
            txtBxPrixDeVente.Dock = DockStyle.Fill;
            txtBxPrixDeVente.Location = new Point(20, 9);
            txtBxPrixDeVente.Name = "txtBxPrixDeVente";
            //txtBxPrixDeVente.PlaceholderText = "Prix de vente de l'article";
            txtBxPrixDeVente.Size = new Size(189, 16);
            txtBxPrixDeVente.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBxCoutStandard);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(618, 63);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(328, 34);
            panel4.TabIndex = 39;
            // 
            // txtBxCoutStandard
            // 
            txtBxCoutStandard.BorderStyle = BorderStyle.None;
            txtBxCoutStandard.Dock = DockStyle.Fill;
            txtBxCoutStandard.Location = new Point(20, 9);
            txtBxCoutStandard.Name = "txtBxCoutStandard";
            //txtBxCoutStandard.PlaceholderText = "Coût standard";
            txtBxCoutStandard.Size = new Size(286, 16);
            txtBxCoutStandard.TabIndex = 0;
            // 
            // panelCoefficient
            // 
            panelCoefficient.BackColor = Color.White;
            panelCoefficient.BorderStyle = BorderStyle.FixedSingle;
            panelCoefficient.Controls.Add(txtBxCoefficient);
            panelCoefficient.Dock = DockStyle.Fill;
            panelCoefficient.Location = new Point(145, 63);
            panelCoefficient.Name = "panelCoefficient";
            panelCoefficient.Padding = new Padding(20, 9, 20, 10);
            panelCoefficient.Size = new Size(231, 34);
            panelCoefficient.TabIndex = 38;
            // 
            // txtBxCoefficient
            // 
            txtBxCoefficient.BorderStyle = BorderStyle.None;
            txtBxCoefficient.Dock = DockStyle.Fill;
            txtBxCoefficient.Location = new Point(20, 9);
            txtBxCoefficient.Name = "txtBxCoefficient";
            //txtBxCoefficient.PlaceholderText = "Coefficient";
            txtBxCoefficient.Size = new Size(189, 16);
            txtBxCoefficient.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBxDernierPrixDAchat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(618, 23);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(328, 34);
            panel1.TabIndex = 37;
            // 
            // txtBxDernierPrixDAchat
            // 
            txtBxDernierPrixDAchat.BorderStyle = BorderStyle.None;
            txtBxDernierPrixDAchat.Dock = DockStyle.Fill;
            txtBxDernierPrixDAchat.Location = new Point(20, 9);
            txtBxDernierPrixDAchat.Name = "txtBxDernierPrixDAchat";
            //txtBxDernierPrixDAchat.PlaceholderText = "Dernier prix d'achat";
            txtBxDernierPrixDAchat.Size = new Size(286, 16);
            txtBxDernierPrixDAchat.TabIndex = 0;
            // 
            // panelPrixDAchat
            // 
            panelPrixDAchat.BackColor = Color.White;
            panelPrixDAchat.BorderStyle = BorderStyle.FixedSingle;
            panelPrixDAchat.Controls.Add(txtBxPrixDAchat);
            panelPrixDAchat.Dock = DockStyle.Fill;
            panelPrixDAchat.Location = new Point(145, 23);
            panelPrixDAchat.Name = "panelPrixDAchat";
            panelPrixDAchat.Padding = new Padding(20, 9, 20, 10);
            panelPrixDAchat.Size = new Size(231, 34);
            panelPrixDAchat.TabIndex = 36;
            // 
            // txtBxPrixDAchat
            // 
            txtBxPrixDAchat.BorderStyle = BorderStyle.None;
            txtBxPrixDAchat.Dock = DockStyle.Fill;
            txtBxPrixDAchat.Location = new Point(20, 9);
            txtBxPrixDAchat.Name = "txtBxPrixDAchat";
            //txtBxPrixDAchat.PlaceholderText = "Prix d'achat";
            txtBxPrixDAchat.Size = new Size(189, 16);
            txtBxPrixDAchat.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBoxHTouTTC);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(382, 103);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(88, 34);
            panel7.TabIndex = 35;
            // 
            // comboBoxHTouTTC
            // 
            comboBoxHTouTTC.Dock = DockStyle.Fill;
            comboBoxHTouTTC.FlatStyle = FlatStyle.Flat;
            comboBoxHTouTTC.FormattingEnabled = true;
            comboBoxHTouTTC.Location = new Point(20, 5);
            comboBoxHTouTTC.Name = "comboBoxHTouTTC";
            comboBoxHTouTTC.Size = new Size(62, 23);
            comboBoxHTouTTC.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxUniteDeVente);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(618, 103);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(328, 34);
            panel6.TabIndex = 34;
            // 
            // comboBoxUniteDeVente
            // 
            comboBoxUniteDeVente.Dock = DockStyle.Fill;
            comboBoxUniteDeVente.FlatStyle = FlatStyle.Flat;
            comboBoxUniteDeVente.FormattingEnabled = true;
            comboBoxUniteDeVente.Location = new Point(20, 5);
            comboBoxUniteDeVente.Name = "comboBoxUniteDeVente";
            comboBoxUniteDeVente.Size = new Size(302, 23);
            comboBoxUniteDeVente.TabIndex = 0;
            // 
            // lblUniteDeVente
            // 
            lblUniteDeVente.AutoSize = true;
            lblUniteDeVente.Dock = DockStyle.Right;
            lblUniteDeVente.Location = new Point(529, 100);
            lblUniteDeVente.Name = "lblUniteDeVente";
            lblUniteDeVente.Size = new Size(83, 40);
            lblUniteDeVente.TabIndex = 18;
            lblUniteDeVente.Text = "Unité de vente";
            lblUniteDeVente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrixDeVente
            // 
            lblPrixDeVente.AutoSize = true;
            lblPrixDeVente.Dock = DockStyle.Right;
            lblPrixDeVente.Location = new Point(65, 100);
            lblPrixDeVente.Name = "lblPrixDeVente";
            lblPrixDeVente.Size = new Size(74, 40);
            lblPrixDeVente.TabIndex = 15;
            lblPrixDeVente.Text = "Prix de vente";
            lblPrixDeVente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCoutStandard
            // 
            lblCoutStandard.AutoSize = true;
            lblCoutStandard.Dock = DockStyle.Right;
            lblCoutStandard.Location = new Point(530, 60);
            lblCoutStandard.Name = "lblCoutStandard";
            lblCoutStandard.Size = new Size(82, 40);
            lblCoutStandard.TabIndex = 13;
            lblCoutStandard.Text = "Coût standard";
            lblCoutStandard.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCoefficient
            // 
            lblCoefficient.AutoSize = true;
            lblCoefficient.Dock = DockStyle.Right;
            lblCoefficient.Location = new Point(74, 60);
            lblCoefficient.Name = "lblCoefficient";
            lblCoefficient.Size = new Size(65, 40);
            lblCoefficient.TabIndex = 10;
            lblCoefficient.Text = "Coefficient";
            lblCoefficient.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDernierPrixDAchat
            // 
            lblDernierPrixDAchat.AutoSize = true;
            lblDernierPrixDAchat.Dock = DockStyle.Right;
            lblDernierPrixDAchat.Location = new Point(503, 20);
            lblDernierPrixDAchat.Name = "lblDernierPrixDAchat";
            lblDernierPrixDAchat.Size = new Size(109, 40);
            lblDernierPrixDAchat.TabIndex = 8;
            lblDernierPrixDAchat.Text = "Dernier prix d'achat";
            lblDernierPrixDAchat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrixDAchat
            // 
            lblPrixDAchat.AutoSize = true;
            lblPrixDAchat.Dock = DockStyle.Right;
            lblPrixDAchat.Location = new Point(71, 20);
            lblPrixDAchat.Name = "lblPrixDAchat";
            lblPrixDAchat.Size = new Size(68, 40);
            lblPrixDAchat.TabIndex = 0;
            lblPrixDAchat.Text = "Prix d'achat";
            lblPrixDAchat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxCategoriesTarifaires
            // 
            groupBoxCategoriesTarifaires.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCategoriesTarifaires.Controls.Add(dataGridViewCategoriesTarifaires);
            groupBoxCategoriesTarifaires.Location = new Point(12, 301);
            groupBoxCategoriesTarifaires.Name = "groupBoxCategoriesTarifaires";
            groupBoxCategoriesTarifaires.Padding = new Padding(60, 15, 60, 15);
            groupBoxCategoriesTarifaires.Size = new Size(1062, 211);
            groupBoxCategoriesTarifaires.TabIndex = 22;
            groupBoxCategoriesTarifaires.TabStop = false;
            groupBoxCategoriesTarifaires.Text = "Catégories tarifaires";
            // 
            // dataGridViewCategoriesTarifaires
            // 
            dataGridViewCategoriesTarifaires.AllowUserToAddRows = false;
            dataGridViewCategoriesTarifaires.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategoriesTarifaires.BackgroundColor = Color.White;
            dataGridViewCategoriesTarifaires.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCategoriesTarifaires.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewCategoriesTarifaires.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCategoriesTarifaires.ColumnHeadersHeight = 60;
            dataGridViewCategoriesTarifaires.Columns.AddRange(new DataGridViewColumn[] { Categories, Coefficient, PrixDeVente, Remise });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewCategoriesTarifaires.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCategoriesTarifaires.Dock = DockStyle.Fill;
            dataGridViewCategoriesTarifaires.EnableHeadersVisualStyles = false;
            dataGridViewCategoriesTarifaires.Location = new Point(60, 31);
            dataGridViewCategoriesTarifaires.Name = "dataGridViewCategoriesTarifaires";
            dataGridViewCategoriesTarifaires.RowHeadersVisible = false;
            dataGridViewCategoriesTarifaires.Size = new Size(942, 165);
            dataGridViewCategoriesTarifaires.TabIndex = 20;
            // 
            // Categories
            // 
            Categories.HeaderText = "Catégories";
            Categories.Name = "Categories";
            // 
            // Coefficient
            // 
            Coefficient.HeaderText = "Coefficient";
            Coefficient.Name = "Coefficient";
            // 
            // PrixDeVente
            // 
            PrixDeVente.HeaderText = "Prix de vente";
            PrixDeVente.Name = "PrixDeVente";
            // 
            // Remise
            // 
            Remise.HeaderText = "Remise";
            Remise.Name = "Remise";
            // 
            // groupBoxTarifsClients
            // 
            groupBoxTarifsClients.Controls.Add(dataGridViewTarifsClients);
            groupBoxTarifsClients.Location = new Point(15, 558);
            groupBoxTarifsClients.Name = "groupBoxTarifsClients";
            groupBoxTarifsClients.Padding = new Padding(60, 15, 60, 15);
            groupBoxTarifsClients.Size = new Size(1059, 281);
            groupBoxTarifsClients.TabIndex = 23;
            groupBoxTarifsClients.TabStop = false;
            groupBoxTarifsClients.Text = "Tarifs clients";
            // 
            // dataGridViewTarifsClients
            // 
            dataGridViewTarifsClients.AllowUserToAddRows = false;
            dataGridViewTarifsClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTarifsClients.BackgroundColor = Color.White;
            dataGridViewTarifsClients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTarifsClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewTarifsClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTarifsClients.ColumnHeadersHeight = 60;
            dataGridViewTarifsClients.Columns.AddRange(new DataGridViewColumn[] { Client, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewTarifsClients.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTarifsClients.Dock = DockStyle.Fill;
            dataGridViewTarifsClients.EnableHeadersVisualStyles = false;
            dataGridViewTarifsClients.Location = new Point(60, 31);
            dataGridViewTarifsClients.Name = "dataGridViewTarifsClients";
            dataGridViewTarifsClients.RowHeadersVisible = false;
            dataGridViewTarifsClients.Size = new Size(939, 235);
            dataGridViewTarifsClients.TabIndex = 21;
            // 
            // Client
            // 
            Client.HeaderText = "Client";
            Client.Name = "Client";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Coefficient";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Prix de vente";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Remise";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(884, 222);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 24;
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
            iconButtonFermer.Location = new Point(1076, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 45;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // TarifsArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1122, 851);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnEnregistrer);
            Controls.Add(groupBoxTarifsClients);
            Controls.Add(groupBoxCategoriesTarifaires);
            Controls.Add(groupBox1);
            Name = "TarifsArticles";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelPrixDeVenteDeLArticle.ResumeLayout(false);
            panelPrixDeVenteDeLArticle.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelCoefficient.ResumeLayout(false);
            panelCoefficient.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPrixDAchat.ResumeLayout(false);
            panelPrixDAchat.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBoxCategoriesTarifaires.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoriesTarifaires).EndInit();
            groupBoxTarifsClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifsClients).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBoxCategoriesTarifaires;
        private GroupBox groupBoxTarifsClients;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUniteDeVente;
        private Label lblPrixDeVente;
        private Label lblCoutStandard;
        private Label lblCoefficient;
        private Label lblDernierPrixDAchat;
        private Label lblPrixDAchat;
        private Panel panel7;
        private ComboBox comboBoxHTouTTC;
        private Panel panel6;
        private ComboBox comboBoxUniteDeVente;
        private Panel panelPrixDeVenteDeLArticle;
        private TextBox txtBxPrixDeVente;
        private Panel panel4;
        private TextBox txtBxCoutStandard;
        private Panel panelCoefficient;
        private TextBox txtBxCoefficient;
        private Panel panel1;
        private TextBox txtBxDernierPrixDAchat;
        private Panel panelPrixDAchat;
        private TextBox txtBxPrixDAchat;
        private Button btnEnregistrer;
        private Button button1;
        private DataGridView dataGridViewCategoriesTarifaires;
        private DataGridViewTextBoxColumn Categories;
        private DataGridViewTextBoxColumn Coefficient;
        private DataGridViewTextBoxColumn PrixDeVente;
        private DataGridViewTextBoxColumn Remise;
        private DataGridView dataGridViewTarifsClients;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}