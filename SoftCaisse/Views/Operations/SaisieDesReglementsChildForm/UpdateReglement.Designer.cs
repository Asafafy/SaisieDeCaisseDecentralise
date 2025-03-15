using System.Drawing;
using System.Windows.Forms;



namespace Soft_Caisse.Views.Operations.SaisieDesReglementsChildForm
{
    partial class UpdateReglement
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
            buttonNumeroReglement = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            dateTimePickerEcheanceContrepartie = new DateTimePicker();
            textBoxEcheanceContrepartie = new TextBox();
            panel1 = new Panel();
            dateTimePickerDateImpaye = new DateTimePicker();
            textBoxDateimpaye = new TextBox();
            panel7 = new Panel();
            dateTimePickerDate = new DateTimePicker();
            textBoxDate = new TextBox();
            labelEcheanceContrepartie = new Label();
            labelDateImpaye = new Label();
            labelDate = new Label();
            groupBoxInformationsDeCaisse = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            comboBoxCaisse = new ComboBox();
            panel10 = new Panel();
            comboBoxCaissier = new ComboBox();
            labelCaissier = new Label();
            labelCaisse = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel14 = new Panel();
            comboBoxCompteGeneral = new ComboBox();
            labelCompteGeneral = new Label();
            panel8 = new Panel();
            textBoxReference = new TextBox();
            panel6 = new Panel();
            comboBoxCodeJournal = new ComboBox();
            panel5 = new Panel();
            comboBoxContrepartie = new ComboBox();
            labelContrepartie = new Label();
            panel4 = new Panel();
            txtBxLibelle = new TextBox();
            labelCodeJournal = new Label();
            labelReference = new Label();
            labelLibelle = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel12 = new Panel();
            comboBoxModeDeReglement = new ComboBox();
            labelModeDeReglement = new Label();
            panel11 = new Panel();
            textBoxCours = new TextBox();
            panel15 = new Panel();
            comboBoxDevise = new ComboBox();
            panel9 = new Panel();
            textBoxMontantDevise = new TextBox();
            labelMontantDevise = new Label();
            panel13 = new Panel();
            textBoxMontant = new TextBox();
            labelCours = new Label();
            labelDevise = new Label();
            labelMontant = new Label();
            buttonReinitialiserLesChamps = new Button();
            buttonEnregistrer = new Button();
            buttonAnnuler = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            groupBoxInformationsDeCaisse.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel14.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel15.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNumeroReglement
            // 
            buttonNumeroReglement.BackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroReglement.FlatAppearance.BorderSize = 0;
            buttonNumeroReglement.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroReglement.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroReglement.FlatStyle = FlatStyle.Flat;
            buttonNumeroReglement.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNumeroReglement.ForeColor = Color.White;
            buttonNumeroReglement.Location = new Point(9, 40);
            buttonNumeroReglement.Margin = new Padding(0);
            buttonNumeroReglement.Name = "buttonNumeroReglement";
            buttonNumeroReglement.Size = new Size(362, 39);
            buttonNumeroReglement.TabIndex = 38;
            buttonNumeroReglement.Text = "N° Pièce :                    10";
            buttonNumeroReglement.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(9, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(12);
            groupBox1.Size = new Size(737, 139);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dates";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel2, 3, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(panel7, 1, 1);
            tableLayoutPanel1.Controls.Add(labelEcheanceContrepartie, 2, 2);
            tableLayoutPanel1.Controls.Add(labelDateImpaye, 0, 2);
            tableLayoutPanel1.Controls.Add(labelDate, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(12, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(713, 99);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateTimePickerEcheanceContrepartie);
            panel2.Controls.Add(textBoxEcheanceContrepartie);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(500, 53);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(210, 34);
            panel2.TabIndex = 40;
            // 
            // dateTimePickerEcheanceContrepartie
            // 
            dateTimePickerEcheanceContrepartie.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerEcheanceContrepartie.Location = new Point(1, 34);
            dateTimePickerEcheanceContrepartie.Name = "dateTimePickerEcheanceContrepartie";
            dateTimePickerEcheanceContrepartie.Size = new Size(158, 23);
            dateTimePickerEcheanceContrepartie.TabIndex = 25;
            dateTimePickerEcheanceContrepartie.ValueChanged += dateTimePickerEcheanceContrepartie_ValueChanged;
            // 
            // textBoxEcheanceContrepartie
            // 
            textBoxEcheanceContrepartie.BorderStyle = BorderStyle.None;
            textBoxEcheanceContrepartie.Dock = DockStyle.Fill;
            textBoxEcheanceContrepartie.Location = new Point(20, 9);
            textBoxEcheanceContrepartie.Name = "textBoxEcheanceContrepartie";
            //textBoxEcheanceContrepartie.PlaceholderText = "DD/MM/YYYY";
            textBoxEcheanceContrepartie.Size = new Size(168, 16);
            textBoxEcheanceContrepartie.TabIndex = 0;
            textBoxEcheanceContrepartie.Click += textBoxEcheanceContrepartie_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePickerDateImpaye);
            panel1.Controls.Add(textBoxDateimpaye);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(145, 53);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(207, 34);
            panel1.TabIndex = 40;
            // 
            // dateTimePickerDateImpaye
            // 
            dateTimePickerDateImpaye.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateImpaye.Location = new Point(1, 34);
            dateTimePickerDateImpaye.Name = "dateTimePickerDateImpaye";
            dateTimePickerDateImpaye.Size = new Size(158, 23);
            dateTimePickerDateImpaye.TabIndex = 25;
            dateTimePickerDateImpaye.ValueChanged += dateTimePickerDateImpaye_ValueChanged;
            // 
            // textBoxDateimpaye
            // 
            textBoxDateimpaye.BorderStyle = BorderStyle.None;
            textBoxDateimpaye.Dock = DockStyle.Fill;
            textBoxDateimpaye.Location = new Point(20, 9);
            textBoxDateimpaye.Name = "textBoxDateimpaye";
            //textBoxDateimpaye.PlaceholderText = "DD/MM/YYYY";
            textBoxDateimpaye.Size = new Size(165, 16);
            textBoxDateimpaye.TabIndex = 0;
            textBoxDateimpaye.Click += textBoxDateimpaye_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dateTimePickerDate);
            panel7.Controls.Add(textBoxDate);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(145, 13);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(207, 34);
            panel7.TabIndex = 39;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDate.Location = new Point(1, 34);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(158, 23);
            dateTimePickerDate.TabIndex = 25;
            dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Dock = DockStyle.Fill;
            textBoxDate.Location = new Point(20, 9);
            textBoxDate.Name = "textBoxDate";
            //textBoxDate.PlaceholderText = "DD/MM/YYYY";
            textBoxDate.Size = new Size(165, 16);
            textBoxDate.TabIndex = 0;
            textBoxDate.Click += textBoxDate_Click;
            // 
            // labelEcheanceContrepartie
            // 
            labelEcheanceContrepartie.AutoSize = true;
            labelEcheanceContrepartie.Dock = DockStyle.Right;
            labelEcheanceContrepartie.ForeColor = SystemColors.ControlText;
            labelEcheanceContrepartie.Location = new Point(370, 50);
            labelEcheanceContrepartie.Name = "labelEcheanceContrepartie";
            labelEcheanceContrepartie.Size = new Size(124, 40);
            labelEcheanceContrepartie.TabIndex = 44;
            labelEcheanceContrepartie.Text = "Echéance contrepartie";
            labelEcheanceContrepartie.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDateImpaye
            // 
            labelDateImpaye.AutoSize = true;
            labelDateImpaye.Dock = DockStyle.Right;
            labelDateImpaye.ForeColor = SystemColors.ControlText;
            labelDateImpaye.Location = new Point(66, 50);
            labelDateImpaye.Name = "labelDateImpaye";
            labelDateImpaye.Size = new Size(73, 40);
            labelDateImpaye.TabIndex = 42;
            labelDateImpaye.Text = "Date impayé";
            labelDateImpaye.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = DockStyle.Right;
            labelDate.ForeColor = SystemColors.ControlText;
            labelDate.Location = new Point(108, 10);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 40);
            labelDate.TabIndex = 38;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxInformationsDeCaisse
            // 
            groupBoxInformationsDeCaisse.Controls.Add(tableLayoutPanel2);
            groupBoxInformationsDeCaisse.Location = new Point(9, 259);
            groupBoxInformationsDeCaisse.Name = "groupBoxInformationsDeCaisse";
            groupBoxInformationsDeCaisse.Padding = new Padding(12);
            groupBoxInformationsDeCaisse.Size = new Size(737, 98);
            groupBoxInformationsDeCaisse.TabIndex = 40;
            groupBoxInformationsDeCaisse.TabStop = false;
            groupBoxInformationsDeCaisse.Text = "Informations de caisse";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 1);
            tableLayoutPanel2.Controls.Add(panel10, 3, 1);
            tableLayoutPanel2.Controls.Add(labelCaissier, 2, 1);
            tableLayoutPanel2.Controls.Add(labelCaisse, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(713, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBoxCaisse);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(145, 13);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(207, 34);
            panel3.TabIndex = 46;
            // 
            // comboBoxCaisse
            // 
            comboBoxCaisse.Dock = DockStyle.Fill;
            comboBoxCaisse.FlatStyle = FlatStyle.Flat;
            comboBoxCaisse.FormattingEnabled = true;
            comboBoxCaisse.Location = new Point(20, 5);
            comboBoxCaisse.Name = "comboBoxCaisse";
            comboBoxCaisse.Size = new Size(181, 23);
            comboBoxCaisse.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBoxCaissier);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(500, 13);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 5, 4, 0);
            panel10.Size = new Size(210, 34);
            panel10.TabIndex = 45;
            // 
            // comboBoxCaissier
            // 
            comboBoxCaissier.Dock = DockStyle.Fill;
            comboBoxCaissier.FlatStyle = FlatStyle.Flat;
            comboBoxCaissier.FormattingEnabled = true;
            comboBoxCaissier.Location = new Point(20, 5);
            comboBoxCaissier.Name = "comboBoxCaissier";
            comboBoxCaissier.Size = new Size(184, 23);
            comboBoxCaissier.TabIndex = 0;
            // 
            // labelCaissier
            // 
            labelCaissier.AutoSize = true;
            labelCaissier.Dock = DockStyle.Right;
            labelCaissier.ForeColor = SystemColors.ControlText;
            labelCaissier.Location = new Point(423, 10);
            labelCaissier.Name = "labelCaissier";
            labelCaissier.Size = new Size(71, 40);
            labelCaissier.TabIndex = 44;
            labelCaissier.Text = "Caissier(ère)";
            labelCaissier.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCaisse
            // 
            labelCaisse.AutoSize = true;
            labelCaisse.Dock = DockStyle.Right;
            labelCaisse.ForeColor = SystemColors.ControlText;
            labelCaisse.Location = new Point(99, 10);
            labelCaisse.Name = "labelCaisse";
            labelCaisse.Size = new Size(40, 40);
            labelCaisse.TabIndex = 38;
            labelCaisse.Text = "Caisse";
            labelCaisse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Location = new Point(9, 385);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(12);
            groupBox2.Size = new Size(737, 179);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations de caisse";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(panel14, 3, 3);
            tableLayoutPanel3.Controls.Add(labelCompteGeneral, 2, 3);
            tableLayoutPanel3.Controls.Add(panel8, 1, 2);
            tableLayoutPanel3.Controls.Add(panel6, 3, 2);
            tableLayoutPanel3.Controls.Add(panel5, 1, 3);
            tableLayoutPanel3.Controls.Add(labelContrepartie, 0, 3);
            tableLayoutPanel3.Controls.Add(panel4, 1, 1);
            tableLayoutPanel3.Controls.Add(labelCodeJournal, 2, 2);
            tableLayoutPanel3.Controls.Add(labelReference, 0, 2);
            tableLayoutPanel3.Controls.Add(labelLibelle, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(12, 28);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(713, 139);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.BackColor = Color.White;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(comboBoxCompteGeneral);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(500, 93);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(20, 5, 4, 0);
            panel14.Size = new Size(210, 34);
            panel14.TabIndex = 48;
            // 
            // comboBoxCompteGeneral
            // 
            comboBoxCompteGeneral.Dock = DockStyle.Fill;
            comboBoxCompteGeneral.FlatStyle = FlatStyle.Flat;
            comboBoxCompteGeneral.FormattingEnabled = true;
            comboBoxCompteGeneral.Location = new Point(20, 5);
            comboBoxCompteGeneral.Name = "comboBoxCompteGeneral";
            comboBoxCompteGeneral.Size = new Size(184, 23);
            comboBoxCompteGeneral.TabIndex = 0;
            // 
            // labelCompteGeneral
            // 
            labelCompteGeneral.AutoSize = true;
            labelCompteGeneral.Dock = DockStyle.Right;
            labelCompteGeneral.ForeColor = SystemColors.ControlText;
            labelCompteGeneral.Location = new Point(402, 90);
            labelCompteGeneral.Name = "labelCompteGeneral";
            labelCompteGeneral.Size = new Size(92, 40);
            labelCompteGeneral.TabIndex = 43;
            labelCompteGeneral.Text = "Compte général";
            labelCompteGeneral.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBoxReference);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(145, 53);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 9, 4, 0);
            panel8.Size = new Size(207, 34);
            panel8.TabIndex = 47;
            // 
            // textBoxReference
            // 
            textBoxReference.BorderStyle = BorderStyle.None;
            textBoxReference.Dock = DockStyle.Fill;
            textBoxReference.Location = new Point(20, 9);
            textBoxReference.Name = "textBoxReference";
            //textBoxReference.PlaceholderText = "Référence";
            textBoxReference.Size = new Size(181, 16);
            textBoxReference.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxCodeJournal);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(500, 53);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(210, 34);
            panel6.TabIndex = 48;
            // 
            // comboBoxCodeJournal
            // 
            comboBoxCodeJournal.Dock = DockStyle.Fill;
            comboBoxCodeJournal.FlatStyle = FlatStyle.Flat;
            comboBoxCodeJournal.FormattingEnabled = true;
            comboBoxCodeJournal.Location = new Point(20, 5);
            comboBoxCodeJournal.Name = "comboBoxCodeJournal";
            comboBoxCodeJournal.Size = new Size(184, 23);
            comboBoxCodeJournal.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBoxContrepartie);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(145, 93);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(207, 34);
            panel5.TabIndex = 47;
            // 
            // comboBoxContrepartie
            // 
            comboBoxContrepartie.Dock = DockStyle.Fill;
            comboBoxContrepartie.FlatStyle = FlatStyle.Flat;
            comboBoxContrepartie.FormattingEnabled = true;
            comboBoxContrepartie.Location = new Point(20, 5);
            comboBoxContrepartie.Name = "comboBoxContrepartie";
            comboBoxContrepartie.Size = new Size(181, 23);
            comboBoxContrepartie.TabIndex = 0;
            // 
            // labelContrepartie
            // 
            labelContrepartie.AutoSize = true;
            labelContrepartie.Dock = DockStyle.Right;
            labelContrepartie.ForeColor = SystemColors.ControlText;
            labelContrepartie.Location = new Point(66, 90);
            labelContrepartie.Name = "labelContrepartie";
            labelContrepartie.Size = new Size(73, 40);
            labelContrepartie.TabIndex = 43;
            labelContrepartie.Text = "Contrepartie";
            labelContrepartie.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel3.SetColumnSpan(panel4, 3);
            panel4.Controls.Add(txtBxLibelle);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(145, 13);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 4, 0);
            panel4.Size = new Size(565, 34);
            panel4.TabIndex = 46;
            // 
            // txtBxLibelle
            // 
            txtBxLibelle.BorderStyle = BorderStyle.None;
            txtBxLibelle.Dock = DockStyle.Fill;
            txtBxLibelle.Location = new Point(20, 9);
            txtBxLibelle.Name = "txtBxLibelle";
            //txtBxLibelle.PlaceholderText = "Libellé";
            txtBxLibelle.Size = new Size(539, 16);
            txtBxLibelle.TabIndex = 1;
            // 
            // labelCodeJournal
            // 
            labelCodeJournal.AutoSize = true;
            labelCodeJournal.Dock = DockStyle.Right;
            labelCodeJournal.ForeColor = SystemColors.ControlText;
            labelCodeJournal.Location = new Point(419, 50);
            labelCodeJournal.Name = "labelCodeJournal";
            labelCodeJournal.Size = new Size(75, 40);
            labelCodeJournal.TabIndex = 42;
            labelCodeJournal.Text = "Code journal";
            labelCodeJournal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Dock = DockStyle.Right;
            labelReference.ForeColor = SystemColors.ControlText;
            labelReference.Location = new Point(80, 50);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(59, 40);
            labelReference.TabIndex = 41;
            labelReference.Text = "Référence";
            labelReference.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelLibelle
            // 
            labelLibelle.AutoSize = true;
            labelLibelle.Dock = DockStyle.Right;
            labelLibelle.ForeColor = SystemColors.ControlText;
            labelLibelle.Location = new Point(98, 10);
            labelLibelle.Name = "labelLibelle";
            labelLibelle.Size = new Size(41, 40);
            labelLibelle.TabIndex = 38;
            labelLibelle.Text = "Libellé";
            labelLibelle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Location = new Point(9, 590);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(12);
            groupBox3.Size = new Size(737, 175);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informations de caisse";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Controls.Add(panel12, 1, 3);
            tableLayoutPanel4.Controls.Add(labelModeDeReglement, 0, 3);
            tableLayoutPanel4.Controls.Add(panel11, 3, 2);
            tableLayoutPanel4.Controls.Add(panel15, 1, 2);
            tableLayoutPanel4.Controls.Add(panel9, 3, 1);
            tableLayoutPanel4.Controls.Add(labelMontantDevise, 2, 1);
            tableLayoutPanel4.Controls.Add(panel13, 1, 1);
            tableLayoutPanel4.Controls.Add(labelCours, 2, 2);
            tableLayoutPanel4.Controls.Add(labelDevise, 0, 2);
            tableLayoutPanel4.Controls.Add(labelMontant, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(12, 28);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.Size = new Size(713, 135);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(comboBoxModeDeReglement);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(145, 93);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(20, 5, 4, 0);
            panel12.Size = new Size(207, 34);
            panel12.TabIndex = 49;
            // 
            // comboBoxModeDeReglement
            // 
            comboBoxModeDeReglement.Dock = DockStyle.Fill;
            comboBoxModeDeReglement.FlatStyle = FlatStyle.Flat;
            comboBoxModeDeReglement.FormattingEnabled = true;
            comboBoxModeDeReglement.Location = new Point(20, 5);
            comboBoxModeDeReglement.Name = "comboBoxModeDeReglement";
            comboBoxModeDeReglement.Size = new Size(181, 23);
            comboBoxModeDeReglement.TabIndex = 0;
            // 
            // labelModeDeReglement
            // 
            labelModeDeReglement.AutoSize = true;
            labelModeDeReglement.Dock = DockStyle.Right;
            labelModeDeReglement.ForeColor = SystemColors.ControlText;
            labelModeDeReglement.Location = new Point(28, 90);
            labelModeDeReglement.Name = "labelModeDeReglement";
            labelModeDeReglement.Size = new Size(111, 40);
            labelModeDeReglement.TabIndex = 45;
            labelModeDeReglement.Text = "Mode de règlement";
            labelModeDeReglement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(textBoxCours);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(500, 53);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 9, 4, 0);
            panel11.Size = new Size(210, 34);
            panel11.TabIndex = 48;
            // 
            // textBoxCours
            // 
            textBoxCours.BorderStyle = BorderStyle.None;
            textBoxCours.Dock = DockStyle.Fill;
            textBoxCours.Location = new Point(20, 9);
            textBoxCours.Name = "textBoxCours";
            //textBoxCours.PlaceholderText = "Cours du devise";
            textBoxCours.Size = new Size(184, 16);
            textBoxCours.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(comboBoxDevise);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(145, 53);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(20, 5, 4, 0);
            panel15.Size = new Size(207, 34);
            panel15.TabIndex = 48;
            // 
            // comboBoxDevise
            // 
            comboBoxDevise.Dock = DockStyle.Fill;
            comboBoxDevise.FlatStyle = FlatStyle.Flat;
            comboBoxDevise.FormattingEnabled = true;
            comboBoxDevise.Location = new Point(20, 5);
            comboBoxDevise.Name = "comboBoxDevise";
            comboBoxDevise.Size = new Size(181, 23);
            comboBoxDevise.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(textBoxMontantDevise);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(500, 13);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 9, 4, 0);
            panel9.Size = new Size(210, 34);
            panel9.TabIndex = 47;
            // 
            // textBoxMontantDevise
            // 
            textBoxMontantDevise.BorderStyle = BorderStyle.None;
            textBoxMontantDevise.Dock = DockStyle.Fill;
            textBoxMontantDevise.Location = new Point(20, 9);
            textBoxMontantDevise.Name = "textBoxMontantDevise";
            //textBoxMontantDevise.PlaceholderText = "Montant avec devise";
            textBoxMontantDevise.Size = new Size(184, 16);
            textBoxMontantDevise.TabIndex = 1;
            // 
            // labelMontantDevise
            // 
            labelMontantDevise.AutoSize = true;
            labelMontantDevise.Dock = DockStyle.Right;
            labelMontantDevise.ForeColor = SystemColors.ControlText;
            labelMontantDevise.Location = new Point(405, 10);
            labelMontantDevise.Name = "labelMontantDevise";
            labelMontantDevise.Size = new Size(89, 40);
            labelMontantDevise.TabIndex = 45;
            labelMontantDevise.Text = "Montant devise";
            labelMontantDevise.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(textBoxMontant);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(145, 13);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(20, 9, 4, 0);
            panel13.Size = new Size(207, 34);
            panel13.TabIndex = 46;
            // 
            // textBoxMontant
            // 
            textBoxMontant.BorderStyle = BorderStyle.None;
            textBoxMontant.Dock = DockStyle.Fill;
            textBoxMontant.Location = new Point(20, 9);
            textBoxMontant.Name = "textBoxMontant";
            //textBoxMontant.PlaceholderText = "Montant";
            textBoxMontant.Size = new Size(181, 16);
            textBoxMontant.TabIndex = 1;
            // 
            // labelCours
            // 
            labelCours.AutoSize = true;
            labelCours.Dock = DockStyle.Right;
            labelCours.ForeColor = SystemColors.ControlText;
            labelCours.Location = new Point(456, 50);
            labelCours.Name = "labelCours";
            labelCours.Size = new Size(38, 40);
            labelCours.TabIndex = 42;
            labelCours.Text = "Cours";
            labelCours.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDevise
            // 
            labelDevise.AutoSize = true;
            labelDevise.Dock = DockStyle.Right;
            labelDevise.ForeColor = SystemColors.ControlText;
            labelDevise.Location = new Point(98, 50);
            labelDevise.Name = "labelDevise";
            labelDevise.Size = new Size(41, 40);
            labelDevise.TabIndex = 41;
            labelDevise.Text = "Devise";
            labelDevise.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Dock = DockStyle.Right;
            labelMontant.ForeColor = SystemColors.ControlText;
            labelMontant.Location = new Point(86, 10);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(53, 40);
            labelMontant.TabIndex = 38;
            labelMontant.Text = "Montant";
            labelMontant.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonReinitialiserLesChamps
            // 
            buttonReinitialiserLesChamps.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonReinitialiserLesChamps.BackColor = Color.FromArgb(129, 166, 181);
            buttonReinitialiserLesChamps.Cursor = Cursors.Hand;
            buttonReinitialiserLesChamps.FlatAppearance.BorderSize = 0;
            buttonReinitialiserLesChamps.FlatStyle = FlatStyle.Flat;
            buttonReinitialiserLesChamps.Font = new Font("Segoe UI", 11F);
            buttonReinitialiserLesChamps.ForeColor = Color.White;
            buttonReinitialiserLesChamps.Location = new Point(168, 808);
            buttonReinitialiserLesChamps.Margin = new Padding(144, 3, 144, 3);
            buttonReinitialiserLesChamps.Name = "buttonReinitialiserLesChamps";
            buttonReinitialiserLesChamps.Padding = new Padding(8, 0, 0, 0);
            buttonReinitialiserLesChamps.Size = new Size(185, 45);
            buttonReinitialiserLesChamps.TabIndex = 47;
            buttonReinitialiserLesChamps.Text = "Réinitialise les champs";
            buttonReinitialiserLesChamps.UseVisualStyleBackColor = false;
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
            buttonEnregistrer.Location = new Point(364, 808);
            buttonEnregistrer.Margin = new Padding(144, 3, 144, 3);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Padding = new Padding(8, 0, 0, 0);
            buttonEnregistrer.Size = new Size(185, 45);
            buttonEnregistrer.TabIndex = 46;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAnnuler.BackColor = Color.FromArgb(129, 166, 181);
            buttonAnnuler.Cursor = Cursors.Hand;
            buttonAnnuler.FlatAppearance.BorderSize = 0;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Font = new Font("Segoe UI", 11F);
            buttonAnnuler.ForeColor = Color.White;
            buttonAnnuler.Location = new Point(561, 808);
            buttonAnnuler.Margin = new Padding(144, 3, 144, 3);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Padding = new Padding(8, 0, 0, 0);
            buttonAnnuler.Size = new Size(185, 45);
            buttonAnnuler.TabIndex = 45;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
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
            iconButtonFermer.Location = new Point(748, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 62;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // UpdateReglement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 862);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonReinitialiserLesChamps);
            Controls.Add(buttonEnregistrer);
            Controls.Add(buttonAnnuler);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxInformationsDeCaisse);
            Controls.Add(groupBox1);
            Controls.Add(buttonNumeroReglement);
            Name = "UpdateReglement";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Mise à jour d'un règlement";
            Load += UpdateReglement_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBoxInformationsDeCaisse.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel14.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel15.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonNumeroReglement;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private DateTimePicker dateTimePickerEcheanceContrepartie;
        private TextBox textBoxEcheanceContrepartie;
        private Panel panel1;
        private DateTimePicker dateTimePickerDateImpaye;
        private TextBox textBoxDateimpaye;
        private Panel panel7;
        private DateTimePicker dateTimePickerDate;
        private TextBox textBoxDate;
        private Label labelEcheanceContrepartie;
        private Label labelDateImpaye;
        private Label labelDate;
        private GroupBox groupBoxInformationsDeCaisse;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private ComboBox comboBoxCaisse;
        private Panel panel10;
        private ComboBox comboBoxCaissier;
        private Label labelCaissier;
        private Label labelCaisse;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel14;
        private ComboBox comboBoxCompteGeneral;
        private Label labelCompteGeneral;
        private Panel panel8;
        private TextBox textBoxReference;
        private Panel panel6;
        private ComboBox comboBoxCodeJournal;
        private Panel panel5;
        private ComboBox comboBoxContrepartie;
        private Label labelContrepartie;
        private Panel panel4;
        private TextBox txtBxLibelle;
        private Label labelCodeJournal;
        private Label labelReference;
        private Label labelLibelle;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel12;
        private ComboBox comboBoxModeDeReglement;
        private Label labelModeDeReglement;
        private Panel panel11;
        private TextBox textBoxCours;
        private Panel panel15;
        private ComboBox comboBoxDevise;
        private Panel panel9;
        private TextBox textBoxMontantDevise;
        private Label labelMontantDevise;
        private Panel panel13;
        private TextBox textBoxMontant;
        private Label labelCours;
        private Label labelDevise;
        private Label labelMontant;
        private Button buttonReinitialiserLesChamps;
        private Button buttonEnregistrer;
        private Button buttonAnnuler;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}