using System.Drawing;
using System.Windows.Forms;









namespace Soft_Caisse.Views.Operations.SaisieDesReglementsChildForm
{
    partial class SelectionDesEcheancesARegler
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
            panel2 = new Panel();
            comboBoxCodeJournal = new ComboBox();
            panel7 = new Panel();
            comboBoxCompteDEcart = new ComboBox();
            panel1 = new Panel();
            textBoxMontantDEcart = new TextBox();
            labelCodeJournal = new Label();
            labelMontantDEcart = new Label();
            panel4 = new Panel();
            textBoxMontantDuReglement = new TextBox();
            labelCompteDEcart = new Label();
            labelMontantDuReglement = new Label();
            checkBoxEnregistrerUnEcartDeReglement = new CheckBox();
            panel11 = new Panel();
            dateTimePickerDateReglement = new DateTimePicker();
            textBoxDateDuReglement = new TextBox();
            labelDateReglement = new Label();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            textBoxMontantRegle = new TextBox();
            labelMontantRegle = new Label();
            buttonImputer = new Button();
            dataGridView1 = new DataGridView();
            Echeance = new DataGridViewTextBoxColumn();
            NPiece = new DataGridViewTextBoxColumn();
            NClient = new DataGridViewTextBoxColumn();
            ModeDeReglement = new DataGridViewTextBoxColumn();
            Pourcentage = new DataGridViewTextBoxColumn();
            EstPaye = new DataGridViewTextBoxColumn();
            Solde = new DataGridViewTextBoxColumn();
            Reglement = new DataGridViewTextBoxColumn();
            buttonOK = new Button();
            panel14 = new Panel();
            panelTotal = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelValeurResteAImputer = new Label();
            labelResteAImputer = new Label();
            labelTotalImpute = new Label();
            labelTotalReglement = new Label();
            labelValeurTotalImpute = new Label();
            labelValeurTotalReglement = new Label();
            listBoxFiltre = new ListBox();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panelEnTete.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTotal.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Controls.Add(panelEnTete, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 41);
            tableLayoutPanel1.Margin = new Padding(5, 5, 0, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1122, 153);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // panelEnTete
            // 
            panelEnTete.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelEnTete.Controls.Add(tableLayoutPanel2);
            panelEnTete.Dock = DockStyle.Fill;
            panelEnTete.Location = new Point(5, 5);
            panelEnTete.Margin = new Padding(5);
            panelEnTete.Name = "panelEnTete";
            panelEnTete.Padding = new Padding(12);
            panelEnTete.Size = new Size(1112, 143);
            panelEnTete.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel2, 3, 2);
            tableLayoutPanel2.Controls.Add(panel7, 1, 2);
            tableLayoutPanel2.Controls.Add(panel1, 3, 1);
            tableLayoutPanel2.Controls.Add(labelCodeJournal, 2, 2);
            tableLayoutPanel2.Controls.Add(labelMontantDEcart, 2, 1);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(labelCompteDEcart, 0, 2);
            tableLayoutPanel2.Controls.Add(labelMontantDuReglement, 0, 1);
            tableLayoutPanel2.Controls.Add(checkBoxEnregistrerUnEcartDeReglement, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(1088, 119);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxCodeJournal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(819, 83);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(266, 34);
            panel2.TabIndex = 55;
            // 
            // comboBoxCodeJournal
            // 
            comboBoxCodeJournal.Dock = DockStyle.Fill;
            comboBoxCodeJournal.FlatStyle = FlatStyle.Flat;
            comboBoxCodeJournal.FormattingEnabled = true;
            comboBoxCodeJournal.Location = new Point(20, 5);
            comboBoxCodeJournal.Name = "comboBoxCodeJournal";
            comboBoxCodeJournal.Size = new Size(240, 23);
            comboBoxCodeJournal.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBoxCompteDEcart);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(275, 83);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(266, 34);
            panel7.TabIndex = 54;
            // 
            // comboBoxCompteDEcart
            // 
            comboBoxCompteDEcart.Dock = DockStyle.Fill;
            comboBoxCompteDEcart.FlatStyle = FlatStyle.Flat;
            comboBoxCompteDEcart.FormattingEnabled = true;
            comboBoxCompteDEcart.Location = new Point(20, 5);
            comboBoxCompteDEcart.Name = "comboBoxCompteDEcart";
            comboBoxCompteDEcart.Size = new Size(240, 23);
            comboBoxCompteDEcart.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxMontantDEcart);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(819, 43);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(266, 34);
            panel1.TabIndex = 53;
            // 
            // textBoxMontantDEcart
            // 
            textBoxMontantDEcart.BorderStyle = BorderStyle.None;
            textBoxMontantDEcart.Dock = DockStyle.Fill;
            textBoxMontantDEcart.Location = new Point(20, 9);
            textBoxMontantDEcart.Name = "textBoxMontantDEcart";
            textBoxMontantDEcart.Size = new Size(224, 16);
            textBoxMontantDEcart.TabIndex = 0;
            // 
            // labelCodeJournal
            // 
            labelCodeJournal.AutoSize = true;
            labelCodeJournal.Dock = DockStyle.Right;
            labelCodeJournal.ForeColor = Color.White;
            labelCodeJournal.Location = new Point(738, 80);
            labelCodeJournal.Name = "labelCodeJournal";
            labelCodeJournal.Size = new Size(75, 40);
            labelCodeJournal.TabIndex = 52;
            labelCodeJournal.Text = "Code journal";
            labelCodeJournal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMontantDEcart
            // 
            labelMontantDEcart.AutoSize = true;
            labelMontantDEcart.Dock = DockStyle.Right;
            labelMontantDEcart.ForeColor = Color.White;
            labelMontantDEcart.Location = new Point(721, 40);
            labelMontantDEcart.Name = "labelMontantDEcart";
            labelMontantDEcart.Size = new Size(92, 40);
            labelMontantDEcart.TabIndex = 50;
            labelMontantDEcart.Text = "Montant d'écart";
            labelMontantDEcart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBoxMontantDuReglement);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(275, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(266, 34);
            panel4.TabIndex = 44;
            // 
            // textBoxMontantDuReglement
            // 
            textBoxMontantDuReglement.BorderStyle = BorderStyle.None;
            textBoxMontantDuReglement.Dock = DockStyle.Fill;
            textBoxMontantDuReglement.Location = new Point(20, 9);
            textBoxMontantDuReglement.Name = "textBoxMontantDuReglement";
            textBoxMontantDuReglement.Size = new Size(224, 16);
            textBoxMontantDuReglement.TabIndex = 0;
            // 
            // labelCompteDEcart
            // 
            labelCompteDEcart.AutoSize = true;
            labelCompteDEcart.Dock = DockStyle.Right;
            labelCompteDEcart.ForeColor = Color.White;
            labelCompteDEcart.Location = new Point(180, 80);
            labelCompteDEcart.Name = "labelCompteDEcart";
            labelCompteDEcart.Size = new Size(89, 40);
            labelCompteDEcart.TabIndex = 38;
            labelCompteDEcart.Text = "Compte d'écart";
            labelCompteDEcart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMontantDuReglement
            // 
            labelMontantDuReglement.AutoSize = true;
            labelMontantDuReglement.Dock = DockStyle.Right;
            labelMontantDuReglement.ForeColor = Color.White;
            labelMontantDuReglement.Location = new Point(142, 40);
            labelMontantDuReglement.Name = "labelMontantDuReglement";
            labelMontantDuReglement.Size = new Size(127, 40);
            labelMontantDuReglement.TabIndex = 8;
            labelMontantDuReglement.Text = "Montant du règlement";
            labelMontantDuReglement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkBoxEnregistrerUnEcartDeReglement
            // 
            checkBoxEnregistrerUnEcartDeReglement.AutoSize = true;
            checkBoxEnregistrerUnEcartDeReglement.Dock = DockStyle.Left;
            checkBoxEnregistrerUnEcartDeReglement.ForeColor = Color.White;
            checkBoxEnregistrerUnEcartDeReglement.Location = new Point(20, 3);
            checkBoxEnregistrerUnEcartDeReglement.Margin = new Padding(20, 3, 3, 3);
            checkBoxEnregistrerUnEcartDeReglement.Name = "checkBoxEnregistrerUnEcartDeReglement";
            checkBoxEnregistrerUnEcartDeReglement.Size = new Size(201, 34);
            checkBoxEnregistrerUnEcartDeReglement.TabIndex = 46;
            checkBoxEnregistrerUnEcartDeReglement.Text = "Enregistrer un écart de règlement";
            checkBoxEnregistrerUnEcartDeReglement.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(dateTimePickerDateReglement);
            panel11.Controls.Add(textBoxDateDuReglement);
            panel11.Location = new Point(180, 3);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 9, 20, 10);
            panel11.Size = new Size(241, 34);
            panel11.TabIndex = 34;
            // 
            // dateTimePickerDateReglement
            // 
            dateTimePickerDateReglement.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateReglement.Location = new Point(1, 34);
            dateTimePickerDateReglement.Name = "dateTimePickerDateReglement";
            dateTimePickerDateReglement.Size = new Size(158, 23);
            dateTimePickerDateReglement.TabIndex = 25;
            dateTimePickerDateReglement.ValueChanged += dateTimePickerDateReglement_ValueChanged;
            // 
            // textBoxDateDuReglement
            // 
            textBoxDateDuReglement.BorderStyle = BorderStyle.None;
            textBoxDateDuReglement.Dock = DockStyle.Fill;
            textBoxDateDuReglement.Location = new Point(20, 9);
            textBoxDateDuReglement.Name = "textBoxDateDuReglement";
            textBoxDateDuReglement.Size = new Size(199, 16);
            textBoxDateDuReglement.TabIndex = 0;
            textBoxDateDuReglement.Click += textBoxDateDuReglement_Click;
            // 
            // labelDateReglement
            // 
            labelDateReglement.AutoSize = true;
            labelDateReglement.Dock = DockStyle.Right;
            labelDateReglement.ForeColor = Color.White;
            labelDateReglement.Location = new Point(69, 0);
            labelDateReglement.Name = "labelDateReglement";
            labelDateReglement.Size = new Size(105, 40);
            labelDateReglement.TabIndex = 33;
            labelDateReglement.Text = "Date du règlement";
            labelDateReglement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(84, 138, 178);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Location = new Point(17, 212);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(12);
            panel3.Size = new Size(910, 64);
            panel3.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(panel5, 3, 0);
            tableLayoutPanel3.Controls.Add(labelMontantRegle, 2, 0);
            tableLayoutPanel3.Controls.Add(labelDateReglement, 0, 0);
            tableLayoutPanel3.Controls.Add(panel11, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(12, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(886, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBoxMontantRegle);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(622, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(261, 34);
            panel5.TabIndex = 45;
            // 
            // textBoxMontantRegle
            // 
            textBoxMontantRegle.BorderStyle = BorderStyle.None;
            textBoxMontantRegle.Dock = DockStyle.Fill;
            textBoxMontantRegle.Location = new Point(20, 9);
            textBoxMontantRegle.Name = "textBoxMontantRegle";
            textBoxMontantRegle.Size = new Size(219, 16);
            textBoxMontantRegle.TabIndex = 0;
            // 
            // labelMontantRegle
            // 
            labelMontantRegle.AutoSize = true;
            labelMontantRegle.Dock = DockStyle.Right;
            labelMontantRegle.ForeColor = Color.White;
            labelMontantRegle.Location = new Point(534, 0);
            labelMontantRegle.Name = "labelMontantRegle";
            labelMontantRegle.Size = new Size(82, 40);
            labelMontantRegle.TabIndex = 35;
            labelMontantRegle.Text = "Montant réglé";
            labelMontantRegle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonImputer
            // 
            buttonImputer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonImputer.BackColor = Color.FromArgb(129, 166, 181);
            buttonImputer.Cursor = Cursors.Hand;
            buttonImputer.FlatAppearance.BorderSize = 0;
            buttonImputer.FlatStyle = FlatStyle.Flat;
            buttonImputer.Font = new Font("Segoe UI", 11F);
            buttonImputer.ForeColor = Color.White;
            buttonImputer.Location = new Point(939, 212);
            buttonImputer.Margin = new Padding(144, 3, 144, 3);
            buttonImputer.Name = "buttonImputer";
            buttonImputer.Padding = new Padding(8, 0, 0, 0);
            buttonImputer.Size = new Size(190, 64);
            buttonImputer.TabIndex = 47;
            buttonImputer.Text = "Imputer";
            buttonImputer.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Echeance, NPiece, NClient, ModeDeReglement, Pourcentage, EstPaye, Solde, Reglement });
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
            dataGridView1.Location = new Point(267, 304);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(862, 319);
            dataGridView1.TabIndex = 48;
            // 
            // Echeance
            // 
            Echeance.HeaderText = "Echéance";
            Echeance.Name = "Echeance";
            // 
            // NPiece
            // 
            NPiece.HeaderText = "N° Piece";
            NPiece.Name = "NPiece";
            // 
            // NClient
            // 
            NClient.HeaderText = "N° Client";
            NClient.Name = "NClient";
            // 
            // ModeDeReglement
            // 
            ModeDeReglement.HeaderText = "Mode de règlement";
            ModeDeReglement.Name = "ModeDeReglement";
            // 
            // Pourcentage
            // 
            Pourcentage.HeaderText = "%";
            Pourcentage.Name = "Pourcentage";
            // 
            // EstPaye
            // 
            EstPaye.HeaderText = "Est payé";
            EstPaye.Name = "EstPaye";
            // 
            // Solde
            // 
            Solde.HeaderText = "Solde";
            Solde.Name = "Solde";
            // 
            // Reglement
            // 
            Reglement.HeaderText = "Règlement";
            Reglement.Name = "Reglement";
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.BackColor = Color.FromArgb(84, 138, 178);
            buttonOK.Cursor = Cursors.Hand;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 11F);
            buttonOK.ForeColor = Color.White;
            buttonOK.Location = new Point(939, 733);
            buttonOK.Margin = new Padding(144, 3, 144, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new Padding(8, 0, 0, 0);
            buttonOK.Size = new Size(190, 45);
            buttonOK.TabIndex = 50;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel14.BackColor = Color.FromArgb(29, 64, 102);
            panel14.Location = new Point(17, 647);
            panel14.Name = "panel14";
            panel14.Size = new Size(1112, 5);
            panel14.TabIndex = 52;
            // 
            // panelTotal
            // 
            panelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelTotal.BackColor = Color.FromArgb(84, 138, 178);
            panelTotal.Controls.Add(tableLayoutPanel4);
            panelTotal.Location = new Point(17, 674);
            panelTotal.Name = "panelTotal";
            panelTotal.Padding = new Padding(12);
            panelTotal.Size = new Size(572, 104);
            panelTotal.TabIndex = 51;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(labelValeurResteAImputer, 2, 1);
            tableLayoutPanel4.Controls.Add(labelResteAImputer, 2, 0);
            tableLayoutPanel4.Controls.Add(labelTotalImpute, 1, 0);
            tableLayoutPanel4.Controls.Add(labelTotalReglement, 0, 0);
            tableLayoutPanel4.Controls.Add(labelValeurTotalImpute, 1, 1);
            tableLayoutPanel4.Controls.Add(labelValeurTotalReglement, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(12, 12);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(548, 80);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelValeurResteAImputer
            // 
            labelValeurResteAImputer.AutoSize = true;
            labelValeurResteAImputer.Dock = DockStyle.Fill;
            labelValeurResteAImputer.Font = new Font("Segoe UI", 10F);
            labelValeurResteAImputer.ForeColor = Color.White;
            labelValeurResteAImputer.Location = new Point(367, 40);
            labelValeurResteAImputer.Name = "labelValeurResteAImputer";
            labelValeurResteAImputer.Size = new Size(178, 40);
            labelValeurResteAImputer.TabIndex = 7;
            labelValeurResteAImputer.Text = "0";
            labelValeurResteAImputer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelResteAImputer
            // 
            labelResteAImputer.AutoSize = true;
            labelResteAImputer.Dock = DockStyle.Fill;
            labelResteAImputer.Font = new Font("Segoe UI", 10F);
            labelResteAImputer.ForeColor = Color.White;
            labelResteAImputer.Location = new Point(367, 0);
            labelResteAImputer.Name = "labelResteAImputer";
            labelResteAImputer.Size = new Size(178, 40);
            labelResteAImputer.TabIndex = 6;
            labelResteAImputer.Text = "Reste à imputer";
            labelResteAImputer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalImpute
            // 
            labelTotalImpute.AutoSize = true;
            labelTotalImpute.Dock = DockStyle.Fill;
            labelTotalImpute.Font = new Font("Segoe UI", 10F);
            labelTotalImpute.ForeColor = Color.White;
            labelTotalImpute.Location = new Point(185, 0);
            labelTotalImpute.Name = "labelTotalImpute";
            labelTotalImpute.Size = new Size(176, 40);
            labelTotalImpute.TabIndex = 5;
            labelTotalImpute.Text = "Total imputé";
            labelTotalImpute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalReglement
            // 
            labelTotalReglement.AutoSize = true;
            labelTotalReglement.Dock = DockStyle.Fill;
            labelTotalReglement.Font = new Font("Segoe UI", 10F);
            labelTotalReglement.ForeColor = Color.White;
            labelTotalReglement.Location = new Point(3, 0);
            labelTotalReglement.Name = "labelTotalReglement";
            labelTotalReglement.Size = new Size(176, 40);
            labelTotalReglement.TabIndex = 4;
            labelTotalReglement.Text = "Total règlement";
            labelTotalReglement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValeurTotalImpute
            // 
            labelValeurTotalImpute.AutoSize = true;
            labelValeurTotalImpute.Dock = DockStyle.Fill;
            labelValeurTotalImpute.Font = new Font("Segoe UI", 10F);
            labelValeurTotalImpute.ForeColor = Color.White;
            labelValeurTotalImpute.Location = new Point(185, 40);
            labelValeurTotalImpute.Name = "labelValeurTotalImpute";
            labelValeurTotalImpute.Size = new Size(176, 40);
            labelValeurTotalImpute.TabIndex = 3;
            labelValeurTotalImpute.Text = "0";
            labelValeurTotalImpute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValeurTotalReglement
            // 
            labelValeurTotalReglement.AutoSize = true;
            labelValeurTotalReglement.Dock = DockStyle.Fill;
            labelValeurTotalReglement.Font = new Font("Segoe UI", 10F);
            labelValeurTotalReglement.ForeColor = Color.White;
            labelValeurTotalReglement.Location = new Point(3, 40);
            labelValeurTotalReglement.Name = "labelValeurTotalReglement";
            labelValeurTotalReglement.Size = new Size(176, 40);
            labelValeurTotalReglement.TabIndex = 0;
            labelValeurTotalReglement.Text = "0";
            labelValeurTotalReglement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxFiltre
            // 
            listBoxFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxFiltre.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxFiltre.FormattingEnabled = true;
            listBoxFiltre.ItemHeight = 35;
            listBoxFiltre.Location = new Point(17, 304);
            listBoxFiltre.Name = "listBoxFiltre";
            listBoxFiltre.Size = new Size(241, 319);
            listBoxFiltre.TabIndex = 53;
            listBoxFiltre.DrawItem += listBoxFiltre_DrawItem;
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
            iconButtonFermer.Location = new Point(1134, 3);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 61;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // SelectionDesEcheancesARegler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1184, 788);
            Controls.Add(iconButtonFermer);
            Controls.Add(listBoxFiltre);
            Controls.Add(panel14);
            Controls.Add(panelTotal);
            Controls.Add(buttonOK);
            Controls.Add(dataGridView1);
            Controls.Add(buttonImputer);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            Name = "SelectionDesEcheancesARegler";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "SelectionDesEcheancesARegler";
            Load += SelectionDesEcheancesARegler_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelEnTete.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTotal.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelEnTete;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private TextBox textBoxMontantDuReglement;
        private Label labelCompteDEcart;
        private Label labelMontantDuReglement;
        private Button buttonNumeroDocument;
        private Panel panel11;
        private DateTimePicker dateTimePickerDateReglement;
        private TextBox textBoxDateDuReglement;
        private Label labelDateReglement;
        private CheckBox checkBoxEnregistrerUnEcartDeReglement;
        private Panel panel1;
        private TextBox textBoxMontantDEcart;
        private Label labelCodeJournal;
        private Label labelMontantDEcart;
        private Panel panel2;
        private ComboBox comboBoxCodeJournal;
        private Panel panel7;
        private ComboBox comboBoxCompteDEcart;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelMontantRegle;
        private Panel panel5;
        private TextBox textBoxMontantRegle;
        private Button buttonNouveau;
        private Button buttonImputer;
        private DataGridView dataGridView1;
        private Button buttonOK;
        private Panel panel14;
        private Panel panelTotal;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelValeurTotalImpute;
        private Label labelValeurTotalReglement;
        private Label labelValeurResteAImputer;
        private Label labelResteAImputer;
        private Label labelTotalImpute;
        private Label labelTotalReglement;
        private ListBox listBoxFiltre;
        private DataGridViewTextBoxColumn Echeance;
        private DataGridViewTextBoxColumn NPiece;
        private DataGridViewTextBoxColumn NClient;
        private DataGridViewTextBoxColumn ModeDeReglement;
        private DataGridViewTextBoxColumn Pourcentage;
        private DataGridViewTextBoxColumn EstPaye;
        private DataGridViewTextBoxColumn Solde;
        private DataGridViewTextBoxColumn Reglement;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}