using System.Drawing;
using System.Windows.Forms;










namespace Soft_Caisse.Views.Operations.DocumentsDesStocksChildForm
{
    partial class CreateDocumentsDesStocks
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelEnTete = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            textBoxDivers = new TextBox();
            panel6 = new Panel();
            textBoxCommentaires = new TextBox();
            panel5 = new Panel();
            txtBxReference = new TextBox();
            labelReference = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBoxDate = new TextBox();
            labelDate = new Label();
            panel8 = new Panel();
            comboBoxAffaire = new ComboBox();
            panel4 = new Panel();
            comboBoxDepot = new ComboBox();
            labelDivers = new Label();
            labelAffaire = new Label();
            labelCommentaires = new Label();
            labelDepot = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelTotal = new Panel();
            labelValeurPoidsBrut = new Label();
            labelValeurPoidsNet = new Label();
            labelPoidsBrut = new Label();
            labelPoidsNet = new Label();
            labelValeurTotalHT = new Label();
            labelTotalHT = new Label();
            buttonNumeroDocument = new Button();
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
            buttonFermer = new Button();
            buttonValiderLEnTete = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonEnregistrer = new Button();
            buttonSupprimer = new Button();
            buttonNouveau = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel31 = new Panel();
            textBoxMontantTTC = new TextBox();
            panel30 = new Panel();
            textBoxMontantHT = new TextBox();
            panel27 = new Panel();
            textBoxPUNet = new TextBox();
            panel26 = new Panel();
            textBoxRemise = new TextBox();
            panel25 = new Panel();
            textBoxConditionnement = new TextBox();
            panel24 = new Panel();
            textBoxQuantite = new TextBox();
            panel23 = new Panel();
            textBoxPUTTC = new TextBox();
            panel22 = new Panel();
            textBoxPUHT = new TextBox();
            panel21 = new Panel();
            textBoxGamme2 = new TextBox();
            panel20 = new Panel();
            textBoxGamme1 = new TextBox();
            panel19 = new Panel();
            textBoxDesignation = new TextBox();
            panel18 = new Panel();
            textBoxReference = new TextBox();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panelEnTete.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel31.SuspendLayout();
            panel30.SuspendLayout();
            panel27.SuspendLayout();
            panel26.SuspendLayout();
            panel25.SuspendLayout();
            panel24.SuspendLayout();
            panel23.SuspendLayout();
            panel22.SuspendLayout();
            panel21.SuspendLayout();
            panel20.SuspendLayout();
            panel19.SuspendLayout();
            panel18.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelEnTete, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 43);
            tableLayoutPanel1.Margin = new Padding(5, 5, 0, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1202, 194);
            tableLayoutPanel1.TabIndex = 27;
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
            panelEnTete.Size = new Size(596, 184);
            panelEnTete.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.Controls.Add(panel7, 3, 3);
            tableLayoutPanel2.Controls.Add(panel6, 3, 2);
            tableLayoutPanel2.Controls.Add(panel5, 1, 2);
            tableLayoutPanel2.Controls.Add(labelReference, 0, 2);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(labelDate, 0, 0);
            tableLayoutPanel2.Controls.Add(panel8, 1, 3);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(labelDivers, 2, 3);
            tableLayoutPanel2.Controls.Add(labelAffaire, 0, 3);
            tableLayoutPanel2.Controls.Add(labelCommentaires, 2, 2);
            tableLayoutPanel2.Controls.Add(labelDepot, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(572, 160);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(textBoxDivers);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(385, 123);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(184, 34);
            panel7.TabIndex = 41;
            // 
            // textBoxDivers
            // 
            textBoxDivers.BorderStyle = BorderStyle.None;
            textBoxDivers.Dock = DockStyle.Fill;
            textBoxDivers.Location = new Point(20, 9);
            textBoxDivers.Name = "textBoxDivers";
            textBoxDivers.Size = new Size(142, 16);
            textBoxDivers.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(textBoxCommentaires);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(385, 83);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 9, 20, 10);
            panel6.Size = new Size(184, 34);
            panel6.TabIndex = 40;
            // 
            // textBoxCommentaires
            // 
            textBoxCommentaires.BorderStyle = BorderStyle.None;
            textBoxCommentaires.Dock = DockStyle.Fill;
            textBoxCommentaires.Location = new Point(20, 9);
            textBoxCommentaires.Name = "textBoxCommentaires";
            textBoxCommentaires.Size = new Size(142, 16);
            textBoxCommentaires.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxReference);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(100, 83);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(182, 34);
            panel5.TabIndex = 39;
            // 
            // txtBxReference
            // 
            txtBxReference.BorderStyle = BorderStyle.None;
            txtBxReference.Dock = DockStyle.Fill;
            txtBxReference.Location = new Point(20, 9);
            txtBxReference.Name = "txtBxReference";
            txtBxReference.Size = new Size(140, 16);
            txtBxReference.TabIndex = 0;
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Dock = DockStyle.Right;
            labelReference.ForeColor = Color.White;
            labelReference.Location = new Point(35, 80);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(59, 40);
            labelReference.TabIndex = 38;
            labelReference.Text = "Référence";
            labelReference.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBoxDate);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(100, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(182, 34);
            panel1.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTrailingForeColor = Color.Transparent;
            dateTimePicker1.Location = new Point(1, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 23);
            dateTimePicker1.TabIndex = 25;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Dock = DockStyle.Fill;
            textBoxDate.Location = new Point(20, 9);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(140, 16);
            textBoxDate.TabIndex = 0;
            textBoxDate.Click += textBoxDate_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = DockStyle.Right;
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(63, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 40);
            labelDate.TabIndex = 33;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(comboBoxAffaire);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(100, 123);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 5, 4, 0);
            panel8.Size = new Size(182, 34);
            panel8.TabIndex = 31;
            // 
            // comboBoxAffaire
            // 
            comboBoxAffaire.Dock = DockStyle.Fill;
            comboBoxAffaire.FlatStyle = FlatStyle.Flat;
            comboBoxAffaire.FormattingEnabled = true;
            comboBoxAffaire.Location = new Point(20, 5);
            comboBoxAffaire.Name = "comboBoxAffaire";
            comboBoxAffaire.Size = new Size(156, 23);
            comboBoxAffaire.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxDepot);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(100, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(182, 34);
            panel4.TabIndex = 27;
            // 
            // comboBoxDepot
            // 
            comboBoxDepot.Dock = DockStyle.Fill;
            comboBoxDepot.FlatStyle = FlatStyle.Flat;
            comboBoxDepot.FormattingEnabled = true;
            comboBoxDepot.Location = new Point(20, 5);
            comboBoxDepot.Name = "comboBoxDepot";
            comboBoxDepot.Size = new Size(156, 23);
            comboBoxDepot.TabIndex = 0;
            // 
            // labelDivers
            // 
            labelDivers.AutoSize = true;
            labelDivers.Dock = DockStyle.Right;
            labelDivers.ForeColor = Color.White;
            labelDivers.Location = new Point(340, 120);
            labelDivers.Name = "labelDivers";
            labelDivers.Size = new Size(39, 40);
            labelDivers.TabIndex = 14;
            labelDivers.Text = "Divers";
            labelDivers.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAffaire
            // 
            labelAffaire.AutoSize = true;
            labelAffaire.Dock = DockStyle.Right;
            labelAffaire.ForeColor = Color.White;
            labelAffaire.Location = new Point(52, 120);
            labelAffaire.Name = "labelAffaire";
            labelAffaire.Size = new Size(42, 40);
            labelAffaire.TabIndex = 12;
            labelAffaire.Text = "Affaire";
            labelAffaire.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCommentaires
            // 
            labelCommentaires.AutoSize = true;
            labelCommentaires.Dock = DockStyle.Right;
            labelCommentaires.ForeColor = Color.White;
            labelCommentaires.Location = new Point(294, 80);
            labelCommentaires.Name = "labelCommentaires";
            labelCommentaires.Size = new Size(85, 40);
            labelCommentaires.TabIndex = 10;
            labelCommentaires.Text = "Commentaires";
            labelCommentaires.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDepot
            // 
            labelDepot.AutoSize = true;
            labelDepot.Dock = DockStyle.Right;
            labelDepot.ForeColor = Color.White;
            labelDepot.Location = new Point(55, 40);
            labelDepot.Name = "labelDepot";
            labelDepot.Size = new Size(39, 40);
            labelDepot.TabIndex = 8;
            labelDepot.Text = "Dépôt";
            labelDepot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panelTotal, 0, 1);
            tableLayoutPanel3.Controls.Add(buttonNumeroDocument, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(606, 5);
            tableLayoutPanel3.Margin = new Padding(5, 5, 0, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.7872334F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70.21277F));
            tableLayoutPanel3.Size = new Size(596, 184);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelTotal.Controls.Add(labelValeurPoidsBrut);
            panelTotal.Controls.Add(labelValeurPoidsNet);
            panelTotal.Controls.Add(labelPoidsBrut);
            panelTotal.Controls.Add(labelPoidsNet);
            panelTotal.Controls.Add(labelValeurTotalHT);
            panelTotal.Controls.Add(labelTotalHT);
            panelTotal.Dock = DockStyle.Fill;
            panelTotal.Location = new Point(5, 54);
            panelTotal.Margin = new Padding(5, 0, 0, 0);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(591, 130);
            panelTotal.TabIndex = 1;
            // 
            // labelValeurPoidsBrut
            // 
            labelValeurPoidsBrut.AutoSize = true;
            labelValeurPoidsBrut.BackColor = Color.Transparent;
            labelValeurPoidsBrut.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelValeurPoidsBrut.ForeColor = Color.White;
            labelValeurPoidsBrut.Location = new Point(429, 78);
            labelValeurPoidsBrut.Name = "labelValeurPoidsBrut";
            labelValeurPoidsBrut.Size = new Size(24, 32);
            labelValeurPoidsBrut.TabIndex = 6;
            labelValeurPoidsBrut.Text = "-";
            // 
            // labelValeurPoidsNet
            // 
            labelValeurPoidsNet.AutoSize = true;
            labelValeurPoidsNet.BackColor = Color.Transparent;
            labelValeurPoidsNet.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelValeurPoidsNet.ForeColor = Color.White;
            labelValeurPoidsNet.Location = new Point(141, 78);
            labelValeurPoidsNet.Name = "labelValeurPoidsNet";
            labelValeurPoidsNet.Size = new Size(24, 32);
            labelValeurPoidsNet.TabIndex = 5;
            labelValeurPoidsNet.Text = "-";
            // 
            // labelPoidsBrut
            // 
            labelPoidsBrut.AutoSize = true;
            labelPoidsBrut.BackColor = Color.Transparent;
            labelPoidsBrut.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelPoidsBrut.ForeColor = Color.White;
            labelPoidsBrut.Location = new Point(286, 78);
            labelPoidsBrut.Name = "labelPoidsBrut";
            labelPoidsBrut.Size = new Size(146, 32);
            labelPoidsBrut.TabIndex = 4;
            labelPoidsBrut.Text = "Poids brut :";
            // 
            // labelPoidsNet
            // 
            labelPoidsNet.AutoSize = true;
            labelPoidsNet.BackColor = Color.Transparent;
            labelPoidsNet.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelPoidsNet.ForeColor = Color.White;
            labelPoidsNet.Location = new Point(12, 78);
            labelPoidsNet.Name = "labelPoidsNet";
            labelPoidsNet.Size = new Size(134, 32);
            labelPoidsNet.TabIndex = 3;
            labelPoidsNet.Text = "Poids net :";
            // 
            // labelValeurTotalHT
            // 
            labelValeurTotalHT.AutoSize = true;
            labelValeurTotalHT.BackColor = Color.Transparent;
            labelValeurTotalHT.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelValeurTotalHT.ForeColor = Color.White;
            labelValeurTotalHT.Location = new Point(141, 12);
            labelValeurTotalHT.Name = "labelValeurTotalHT";
            labelValeurTotalHT.Size = new Size(63, 32);
            labelValeurTotalHT.TabIndex = 2;
            labelValeurTotalHT.Text = "0,00";
            // 
            // labelTotalHT
            // 
            labelTotalHT.AutoSize = true;
            labelTotalHT.BackColor = Color.Transparent;
            labelTotalHT.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTotalHT.ForeColor = Color.White;
            labelTotalHT.Location = new Point(12, 12);
            labelTotalHT.Name = "labelTotalHT";
            labelTotalHT.Size = new Size(123, 32);
            labelTotalHT.TabIndex = 0;
            labelTotalHT.Text = "Total HT :";
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
            buttonNumeroDocument.Location = new Point(5, 0);
            buttonNumeroDocument.Margin = new Padding(5, 0, 0, 5);
            buttonNumeroDocument.Name = "buttonNumeroDocument";
            buttonNumeroDocument.Padding = new Padding(8, 0, 0, 0);
            buttonNumeroDocument.Size = new Size(591, 44);
            buttonNumeroDocument.TabIndex = 36;
            buttonNumeroDocument.Text = "ME00010";
            buttonNumeroDocument.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Reference, Designation, Gamme1, Gamme2, PuHT, PuTTC, Quantite, Conditionnement, Remise, PuNet, MontantHT, MontantTTC });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 481);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1202, 336);
            dataGridView1.TabIndex = 31;
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
            // buttonFermer
            // 
            buttonFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFermer.BackColor = Color.FromArgb(84, 138, 178);
            buttonFermer.Cursor = Cursors.Hand;
            buttonFermer.FlatAppearance.BorderSize = 0;
            buttonFermer.FlatStyle = FlatStyle.Flat;
            buttonFermer.Font = new Font("Segoe UI", 11F);
            buttonFermer.ForeColor = Color.White;
            buttonFermer.Location = new Point(1024, 845);
            buttonFermer.Margin = new Padding(144, 3, 144, 3);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Padding = new Padding(8, 0, 0, 0);
            buttonFermer.Size = new Size(190, 45);
            buttonFermer.TabIndex = 34;
            buttonFermer.Text = "Fermer";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // buttonValiderLEnTete
            // 
            buttonValiderLEnTete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValiderLEnTete.BackColor = Color.FromArgb(129, 166, 181);
            buttonValiderLEnTete.Cursor = Cursors.Hand;
            buttonValiderLEnTete.FlatAppearance.BorderSize = 0;
            buttonValiderLEnTete.FlatStyle = FlatStyle.Flat;
            buttonValiderLEnTete.Font = new Font("Segoe UI", 11F);
            buttonValiderLEnTete.ForeColor = Color.White;
            buttonValiderLEnTete.Location = new Point(1029, 244);
            buttonValiderLEnTete.Margin = new Padding(144, 3, 144, 3);
            buttonValiderLEnTete.Name = "buttonValiderLEnTete";
            buttonValiderLEnTete.Padding = new Padding(8, 0, 0, 0);
            buttonValiderLEnTete.Size = new Size(185, 45);
            buttonValiderLEnTete.TabIndex = 37;
            buttonValiderLEnTete.Text = "Valider l'en-tête";
            buttonValiderLEnTete.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 64, 102);
            panel2.Location = new Point(12, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 5);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonEnregistrer);
            panel3.Controls.Add(buttonSupprimer);
            panel3.Controls.Add(buttonNouveau);
            panel3.Controls.Add(tableLayoutPanel4);
            panel3.Location = new Point(12, 329);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(12);
            panel3.Size = new Size(1202, 136);
            panel3.TabIndex = 39;
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
            buttonEnregistrer.Location = new Point(1003, 73);
            buttonEnregistrer.Margin = new Padding(144, 3, 144, 3);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Padding = new Padding(8, 0, 0, 0);
            buttonEnregistrer.Size = new Size(185, 45);
            buttonEnregistrer.TabIndex = 31;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
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
            buttonSupprimer.Location = new Point(808, 73);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(185, 45);
            buttonSupprimer.TabIndex = 30;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
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
            buttonNouveau.Location = new Point(614, 73);
            buttonNouveau.Margin = new Padding(144, 3, 144, 3);
            buttonNouveau.Name = "buttonNouveau";
            buttonNouveau.Padding = new Padding(8, 0, 0, 0);
            buttonNouveau.Size = new Size(185, 45);
            buttonNouveau.TabIndex = 29;
            buttonNouveau.Text = "Nouveau";
            buttonNouveau.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 12;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.342502F));
            tableLayoutPanel4.Controls.Add(panel31, 11, 1);
            tableLayoutPanel4.Controls.Add(panel30, 10, 1);
            tableLayoutPanel4.Controls.Add(panel27, 9, 1);
            tableLayoutPanel4.Controls.Add(panel26, 8, 1);
            tableLayoutPanel4.Controls.Add(panel25, 7, 1);
            tableLayoutPanel4.Controls.Add(panel24, 6, 1);
            tableLayoutPanel4.Controls.Add(panel23, 5, 1);
            tableLayoutPanel4.Controls.Add(panel22, 4, 1);
            tableLayoutPanel4.Controls.Add(panel21, 3, 1);
            tableLayoutPanel4.Controls.Add(panel20, 2, 1);
            tableLayoutPanel4.Controls.Add(panel19, 1, 1);
            tableLayoutPanel4.Controls.Add(panel18, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(12, 12);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1176, 60);
            tableLayoutPanel4.TabIndex = 26;
            // 
            // panel31
            // 
            panel31.BackColor = Color.White;
            panel31.BorderStyle = BorderStyle.FixedSingle;
            panel31.Controls.Add(textBoxMontantTTC);
            panel31.Dock = DockStyle.Fill;
            panel31.Location = new Point(1070, 13);
            panel31.Name = "panel31";
            panel31.Padding = new Padding(5, 8, 5, 10);
            panel31.Size = new Size(103, 34);
            panel31.TabIndex = 54;
            // 
            // textBoxMontantTTC
            // 
            textBoxMontantTTC.BorderStyle = BorderStyle.None;
            textBoxMontantTTC.Dock = DockStyle.Fill;
            textBoxMontantTTC.Location = new Point(5, 8);
            textBoxMontantTTC.Name = "textBoxMontantTTC";
            textBoxMontantTTC.Size = new Size(91, 16);
            textBoxMontantTTC.TabIndex = 0;
            // 
            // panel30
            // 
            panel30.BackColor = Color.White;
            panel30.BorderStyle = BorderStyle.FixedSingle;
            panel30.Controls.Add(textBoxMontantHT);
            panel30.Dock = DockStyle.Fill;
            panel30.Location = new Point(973, 13);
            panel30.Name = "panel30";
            panel30.Padding = new Padding(5, 8, 5, 10);
            panel30.Size = new Size(91, 34);
            panel30.TabIndex = 53;
            // 
            // textBoxMontantHT
            // 
            textBoxMontantHT.BorderStyle = BorderStyle.None;
            textBoxMontantHT.Dock = DockStyle.Fill;
            textBoxMontantHT.Location = new Point(5, 8);
            textBoxMontantHT.Name = "textBoxMontantHT";
            textBoxMontantHT.Size = new Size(79, 16);
            textBoxMontantHT.TabIndex = 0;
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(textBoxPUNet);
            panel27.Dock = DockStyle.Fill;
            panel27.Location = new Point(876, 13);
            panel27.Name = "panel27";
            panel27.Padding = new Padding(5, 8, 5, 10);
            panel27.Size = new Size(91, 34);
            panel27.TabIndex = 40;
            // 
            // textBoxPUNet
            // 
            textBoxPUNet.BorderStyle = BorderStyle.None;
            textBoxPUNet.Dock = DockStyle.Fill;
            textBoxPUNet.Location = new Point(5, 8);
            textBoxPUNet.Name = "textBoxPUNet";
            textBoxPUNet.Size = new Size(79, 16);
            textBoxPUNet.TabIndex = 0;
            // 
            // panel26
            // 
            panel26.BackColor = Color.White;
            panel26.BorderStyle = BorderStyle.FixedSingle;
            panel26.Controls.Add(textBoxRemise);
            panel26.Dock = DockStyle.Fill;
            panel26.Location = new Point(779, 13);
            panel26.Name = "panel26";
            panel26.Padding = new Padding(5, 8, 5, 10);
            panel26.Size = new Size(91, 34);
            panel26.TabIndex = 39;
            // 
            // textBoxRemise
            // 
            textBoxRemise.BorderStyle = BorderStyle.None;
            textBoxRemise.Dock = DockStyle.Fill;
            textBoxRemise.Location = new Point(5, 8);
            textBoxRemise.Name = "textBoxRemise";
            textBoxRemise.Size = new Size(79, 16);
            textBoxRemise.TabIndex = 0;
            // 
            // panel25
            // 
            panel25.BackColor = Color.White;
            panel25.BorderStyle = BorderStyle.FixedSingle;
            panel25.Controls.Add(textBoxConditionnement);
            panel25.Dock = DockStyle.Fill;
            panel25.Location = new Point(682, 13);
            panel25.Name = "panel25";
            panel25.Padding = new Padding(5, 8, 5, 10);
            panel25.Size = new Size(91, 34);
            panel25.TabIndex = 38;
            // 
            // textBoxConditionnement
            // 
            textBoxConditionnement.BorderStyle = BorderStyle.None;
            textBoxConditionnement.Dock = DockStyle.Fill;
            textBoxConditionnement.Location = new Point(5, 8);
            textBoxConditionnement.Name = "textBoxConditionnement";
            textBoxConditionnement.Size = new Size(79, 16);
            textBoxConditionnement.TabIndex = 0;
            // 
            // panel24
            // 
            panel24.BackColor = Color.White;
            panel24.BorderStyle = BorderStyle.FixedSingle;
            panel24.Controls.Add(textBoxQuantite);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(585, 13);
            panel24.Name = "panel24";
            panel24.Padding = new Padding(5, 8, 5, 10);
            panel24.Size = new Size(91, 34);
            panel24.TabIndex = 37;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.BorderStyle = BorderStyle.None;
            textBoxQuantite.Dock = DockStyle.Fill;
            textBoxQuantite.Location = new Point(5, 8);
            textBoxQuantite.Name = "textBoxQuantite";
            textBoxQuantite.Size = new Size(79, 16);
            textBoxQuantite.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.BackColor = Color.White;
            panel23.BorderStyle = BorderStyle.FixedSingle;
            panel23.Controls.Add(textBoxPUTTC);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(488, 13);
            panel23.Name = "panel23";
            panel23.Padding = new Padding(5, 8, 5, 10);
            panel23.Size = new Size(91, 34);
            panel23.TabIndex = 36;
            // 
            // textBoxPUTTC
            // 
            textBoxPUTTC.BorderStyle = BorderStyle.None;
            textBoxPUTTC.Dock = DockStyle.Fill;
            textBoxPUTTC.Location = new Point(5, 8);
            textBoxPUTTC.Name = "textBoxPUTTC";
            textBoxPUTTC.Size = new Size(79, 16);
            textBoxPUTTC.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.BorderStyle = BorderStyle.FixedSingle;
            panel22.Controls.Add(textBoxPUHT);
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(391, 13);
            panel22.Name = "panel22";
            panel22.Padding = new Padding(5, 8, 5, 10);
            panel22.Size = new Size(91, 34);
            panel22.TabIndex = 35;
            // 
            // textBoxPUHT
            // 
            textBoxPUHT.BorderStyle = BorderStyle.None;
            textBoxPUHT.Dock = DockStyle.Fill;
            textBoxPUHT.Location = new Point(5, 8);
            textBoxPUHT.Name = "textBoxPUHT";
            textBoxPUHT.Size = new Size(79, 16);
            textBoxPUHT.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.BackColor = Color.White;
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(textBoxGamme2);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(294, 13);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(5, 8, 5, 10);
            panel21.Size = new Size(91, 34);
            panel21.TabIndex = 34;
            // 
            // textBoxGamme2
            // 
            textBoxGamme2.BorderStyle = BorderStyle.None;
            textBoxGamme2.Dock = DockStyle.Fill;
            textBoxGamme2.Location = new Point(5, 8);
            textBoxGamme2.Name = "textBoxGamme2";
            textBoxGamme2.Size = new Size(79, 16);
            textBoxGamme2.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.BackColor = Color.White;
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(textBoxGamme1);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(197, 13);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(5, 8, 5, 10);
            panel20.Size = new Size(91, 34);
            panel20.TabIndex = 33;
            // 
            // textBoxGamme1
            // 
            textBoxGamme1.BorderStyle = BorderStyle.None;
            textBoxGamme1.Dock = DockStyle.Fill;
            textBoxGamme1.Location = new Point(5, 8);
            textBoxGamme1.Name = "textBoxGamme1";
            textBoxGamme1.Size = new Size(79, 16);
            textBoxGamme1.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.BorderStyle = BorderStyle.FixedSingle;
            panel19.Controls.Add(textBoxDesignation);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(100, 13);
            panel19.Name = "panel19";
            panel19.Padding = new Padding(5, 8, 5, 10);
            panel19.Size = new Size(91, 34);
            panel19.TabIndex = 32;
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.BorderStyle = BorderStyle.None;
            textBoxDesignation.Dock = DockStyle.Fill;
            textBoxDesignation.Location = new Point(5, 8);
            textBoxDesignation.Name = "textBoxDesignation";
            textBoxDesignation.Size = new Size(79, 16);
            textBoxDesignation.TabIndex = 0;
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
            panel18.Size = new Size(91, 34);
            panel18.TabIndex = 31;
            // 
            // textBoxReference
            // 
            textBoxReference.BorderStyle = BorderStyle.None;
            textBoxReference.Dock = DockStyle.Fill;
            textBoxReference.Location = new Point(5, 8);
            textBoxReference.Name = "textBoxReference";
            textBoxReference.Size = new Size(79, 16);
            textBoxReference.TabIndex = 0;
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
            iconButtonFermer.Location = new Point(1215, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 54;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateDocumentsDesStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1262, 902);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonValiderLEnTete);
            Controls.Add(buttonFermer);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateDocumentsDesStocks";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Création d'un document de stock";
            Load += CreateDocumentsDesStocks_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelEnTete.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTotal;
        private Label labelValeurTotalHT;
        private Label labelTotalHT;
        private Panel panelEnTete;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel8;
        private ComboBox comboBoxAffaire;
        private Panel panel6;
        private ComboBox comboBoxDepot;
        private Panel panel4;
        private Label labelDivers;
        private Label labelAffaire;
        private Label labelCommentaires;
        private Label labelDepot;
        private Label labelDate;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxDate;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonNumeroDocument;
        private Label labelPoidsNet;
        private Label labelPoidsBrut;
        private Label labelValeurPoidsBrut;
        private Label labelValeurPoidsNet;
        private Panel panelSaisieLigne;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel31;
        private TextBox textBoxMontantTTC;
        private Panel panel30;
        private TextBox textBoxMontantHT;
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
        private Button buttonEnregistrer;
        private Button buttonSupprimer;
        private Button buttonNouveau;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
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
        private Button buttonEnAttente;
        private Button buttonAnnuler;
        private Button buttonFinDeSaisie;
        private Button buttonValiderLEnTete;
        private Panel panel2;
        private Button buttonFermer;
        private Panel panel3;
        private Label labelReference;
        private Panel panel7;
        private TextBox textBoxDivers;
        private TextBox textBoxCommentaires;
        private Panel panel5;
        private TextBox txtBxReference;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}