using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Statistiques
{
    partial class ControleDeCaisse
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
            dataGridView1 = new DataGridView();
            Intitule = new DataGridViewTextBoxColumn();
            Montant = new DataGridViewTextBoxColumn();
            panelTotal = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelValeurResteAImputer = new Label();
            labelEcart = new Label();
            labelTotalConstate = new Label();
            labelTotalReglement = new Label();
            labelValeurTotalImpute = new Label();
            labelValeurTotalReglement = new Label();
            checkBoxGenererEcart = new CheckBox();
            buttonAfficher = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            comboBoxCaisse = new ComboBox();
            panel3 = new Panel();
            comboControle = new ComboBox();
            panel7 = new Panel();
            dateTimePickerDate = new DateTimePicker();
            textBoxDate = new TextBox();
            labelCaisse = new Label();
            labelControle = new Label();
            labelDate = new Label();
            buttonOK = new Button();
            groupBoxFiltre = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBoxDevise = new ComboBox();
            panel10 = new Panel();
            comboBoxCaissier = new ComboBox();
            labelMontantConstateEnCaisse = new Label();
            labelDevise = new Label();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTotal.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            groupBoxFiltre.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Intitule, Montant });
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
            dataGridView1.Location = new Point(12, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(771, 240);
            dataGridView1.TabIndex = 42;
            // 
            // Intitule
            // 
            Intitule.HeaderText = "Intitulé";
            Intitule.Name = "Intitule";
            // 
            // Montant
            // 
            Montant.HeaderText = "Montant";
            Montant.Name = "Montant";
            // 
            // panelTotal
            // 
            panelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelTotal.BackColor = Color.FromArgb(84, 138, 178);
            panelTotal.Controls.Add(tableLayoutPanel4);
            panelTotal.Location = new Point(12, 589);
            panelTotal.Name = "panelTotal";
            panelTotal.Padding = new Padding(12);
            panelTotal.Size = new Size(473, 104);
            panelTotal.TabIndex = 52;
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
            tableLayoutPanel4.Controls.Add(labelEcart, 2, 0);
            tableLayoutPanel4.Controls.Add(labelTotalConstate, 1, 0);
            tableLayoutPanel4.Controls.Add(labelTotalReglement, 0, 0);
            tableLayoutPanel4.Controls.Add(labelValeurTotalImpute, 1, 1);
            tableLayoutPanel4.Controls.Add(labelValeurTotalReglement, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(12, 12);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(449, 80);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelValeurResteAImputer
            // 
            labelValeurResteAImputer.AutoSize = true;
            labelValeurResteAImputer.Dock = DockStyle.Fill;
            labelValeurResteAImputer.Font = new Font("Segoe UI", 9F);
            labelValeurResteAImputer.ForeColor = Color.White;
            labelValeurResteAImputer.Location = new Point(301, 40);
            labelValeurResteAImputer.Name = "labelValeurResteAImputer";
            labelValeurResteAImputer.Size = new Size(145, 40);
            labelValeurResteAImputer.TabIndex = 7;
            labelValeurResteAImputer.Text = "0";
            labelValeurResteAImputer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEcart
            // 
            labelEcart.AutoSize = true;
            labelEcart.Dock = DockStyle.Fill;
            labelEcart.Font = new Font("Segoe UI", 9F);
            labelEcart.ForeColor = Color.White;
            labelEcart.Location = new Point(301, 0);
            labelEcart.Name = "labelEcart";
            labelEcart.Size = new Size(145, 40);
            labelEcart.TabIndex = 6;
            labelEcart.Text = "Ecart";
            labelEcart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalConstate
            // 
            labelTotalConstate.AutoSize = true;
            labelTotalConstate.Dock = DockStyle.Fill;
            labelTotalConstate.Font = new Font("Segoe UI", 9F);
            labelTotalConstate.ForeColor = Color.White;
            labelTotalConstate.Location = new Point(152, 0);
            labelTotalConstate.Name = "labelTotalConstate";
            labelTotalConstate.Size = new Size(143, 40);
            labelTotalConstate.TabIndex = 5;
            labelTotalConstate.Text = "Total constaté";
            labelTotalConstate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalReglement
            // 
            labelTotalReglement.AutoSize = true;
            labelTotalReglement.Dock = DockStyle.Fill;
            labelTotalReglement.Font = new Font("Segoe UI", 9F);
            labelTotalReglement.ForeColor = Color.White;
            labelTotalReglement.Location = new Point(3, 0);
            labelTotalReglement.Name = "labelTotalReglement";
            labelTotalReglement.Size = new Size(143, 40);
            labelTotalReglement.TabIndex = 4;
            labelTotalReglement.Text = "Montant théorique en caisse";
            labelTotalReglement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValeurTotalImpute
            // 
            labelValeurTotalImpute.AutoSize = true;
            labelValeurTotalImpute.Dock = DockStyle.Fill;
            labelValeurTotalImpute.Font = new Font("Segoe UI", 9F);
            labelValeurTotalImpute.ForeColor = Color.White;
            labelValeurTotalImpute.Location = new Point(152, 40);
            labelValeurTotalImpute.Name = "labelValeurTotalImpute";
            labelValeurTotalImpute.Size = new Size(143, 40);
            labelValeurTotalImpute.TabIndex = 3;
            labelValeurTotalImpute.Text = "0";
            labelValeurTotalImpute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValeurTotalReglement
            // 
            labelValeurTotalReglement.AutoSize = true;
            labelValeurTotalReglement.Dock = DockStyle.Fill;
            labelValeurTotalReglement.Font = new Font("Segoe UI", 9F);
            labelValeurTotalReglement.ForeColor = Color.White;
            labelValeurTotalReglement.Location = new Point(3, 40);
            labelValeurTotalReglement.Name = "labelValeurTotalReglement";
            labelValeurTotalReglement.Size = new Size(143, 40);
            labelValeurTotalReglement.TabIndex = 0;
            labelValeurTotalReglement.Text = "0";
            labelValeurTotalReglement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxGenererEcart
            // 
            checkBoxGenererEcart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxGenererEcart.AutoSize = true;
            checkBoxGenererEcart.Location = new Point(8, 720);
            checkBoxGenererEcart.Name = "checkBoxGenererEcart";
            checkBoxGenererEcart.Size = new Size(311, 19);
            checkBoxGenererEcart.TabIndex = 53;
            checkBoxGenererEcart.Text = "Générer un mouvement de régularisation en cas écart ";
            checkBoxGenererEcart.UseVisualStyleBackColor = true;
            // 
            // buttonAfficher
            // 
            buttonAfficher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAfficher.BackColor = Color.FromArgb(129, 166, 181);
            buttonAfficher.Cursor = Cursors.Hand;
            buttonAfficher.FlatAppearance.BorderSize = 0;
            buttonAfficher.FlatStyle = FlatStyle.Flat;
            buttonAfficher.Font = new Font("Segoe UI", 11F);
            buttonAfficher.ForeColor = Color.White;
            buttonAfficher.Location = new Point(598, 167);
            buttonAfficher.Margin = new Padding(144, 3, 144, 3);
            buttonAfficher.Name = "buttonAfficher";
            buttonAfficher.Padding = new Padding(8, 0, 0, 0);
            buttonAfficher.Size = new Size(185, 45);
            buttonAfficher.TabIndex = 54;
            buttonAfficher.Text = "Afficher";
            buttonAfficher.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(230, 29, 64, 102);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 52);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(771, 105);
            panel1.TabIndex = 55;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel2, 3, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel7, 1, 0);
            tableLayoutPanel1.Controls.Add(labelCaisse, 2, 1);
            tableLayoutPanel1.Controls.Add(labelControle, 0, 1);
            tableLayoutPanel1.Controls.Add(labelDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(747, 81);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxCaisse);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(525, 43);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(219, 35);
            panel2.TabIndex = 48;
            // 
            // comboBoxCaisse
            // 
            comboBoxCaisse.Dock = DockStyle.Fill;
            comboBoxCaisse.FlatStyle = FlatStyle.Flat;
            comboBoxCaisse.FormattingEnabled = true;
            comboBoxCaisse.Location = new Point(20, 5);
            comboBoxCaisse.Name = "comboBoxCaisse";
            comboBoxCaisse.Size = new Size(193, 23);
            comboBoxCaisse.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboControle);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(152, 43);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(218, 35);
            panel3.TabIndex = 47;
            // 
            // comboControle
            // 
            comboControle.Dock = DockStyle.Fill;
            comboControle.FlatStyle = FlatStyle.Flat;
            comboControle.FormattingEnabled = true;
            comboControle.Location = new Point(20, 5);
            comboControle.Name = "comboControle";
            comboControle.Size = new Size(192, 23);
            comboControle.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dateTimePickerDate);
            panel7.Controls.Add(textBoxDate);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(152, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(218, 34);
            panel7.TabIndex = 40;
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
            textBoxDate.Size = new Size(176, 16);
            textBoxDate.TabIndex = 0;
            textBoxDate.Click += textBoxDate_Click;
            // 
            // labelCaisse
            // 
            labelCaisse.AutoSize = true;
            labelCaisse.Dock = DockStyle.Right;
            labelCaisse.ForeColor = Color.White;
            labelCaisse.Location = new Point(479, 40);
            labelCaisse.Name = "labelCaisse";
            labelCaisse.Size = new Size(40, 41);
            labelCaisse.TabIndex = 15;
            labelCaisse.Text = "Caisse";
            labelCaisse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelControle
            // 
            labelControle.AutoSize = true;
            labelControle.Dock = DockStyle.Right;
            labelControle.ForeColor = Color.White;
            labelControle.Location = new Point(93, 40);
            labelControle.Name = "labelControle";
            labelControle.Size = new Size(53, 41);
            labelControle.TabIndex = 13;
            labelControle.Text = "Contrôle";
            labelControle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Dock = DockStyle.Right;
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(115, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 40);
            labelDate.TabIndex = 9;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
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
            buttonOK.Location = new Point(593, 705);
            buttonOK.Margin = new Padding(144, 3, 144, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new Padding(8, 0, 0, 0);
            buttonOK.Size = new Size(190, 45);
            buttonOK.TabIndex = 58;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // groupBoxFiltre
            // 
            groupBoxFiltre.Controls.Add(tableLayoutPanel2);
            groupBoxFiltre.Location = new Point(12, 226);
            groupBoxFiltre.Name = "groupBoxFiltre";
            groupBoxFiltre.Padding = new Padding(12);
            groupBoxFiltre.Size = new Size(771, 98);
            groupBoxFiltre.TabIndex = 59;
            groupBoxFiltre.TabStop = false;
            groupBoxFiltre.Text = "Filtre";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(panel10, 3, 1);
            tableLayoutPanel2.Controls.Add(labelMontantConstateEnCaisse, 2, 1);
            tableLayoutPanel2.Controls.Add(labelDevise, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Size = new Size(747, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxDevise);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(77, 13);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(218, 34);
            panel4.TabIndex = 46;
            // 
            // comboBoxDevise
            // 
            comboBoxDevise.Dock = DockStyle.Fill;
            comboBoxDevise.FlatStyle = FlatStyle.Flat;
            comboBoxDevise.FormattingEnabled = true;
            comboBoxDevise.Location = new Point(20, 5);
            comboBoxDevise.Name = "comboBoxDevise";
            comboBoxDevise.Size = new Size(192, 23);
            comboBoxDevise.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBoxCaissier);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(525, 13);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 5, 4, 0);
            panel10.Size = new Size(219, 34);
            panel10.TabIndex = 45;
            // 
            // comboBoxCaissier
            // 
            comboBoxCaissier.Dock = DockStyle.Fill;
            comboBoxCaissier.FlatStyle = FlatStyle.Flat;
            comboBoxCaissier.FormattingEnabled = true;
            comboBoxCaissier.Location = new Point(20, 5);
            comboBoxCaissier.Name = "comboBoxCaissier";
            comboBoxCaissier.Size = new Size(193, 23);
            comboBoxCaissier.TabIndex = 0;
            // 
            // labelMontantConstateEnCaisse
            // 
            labelMontantConstateEnCaisse.AutoSize = true;
            labelMontantConstateEnCaisse.Dock = DockStyle.Right;
            labelMontantConstateEnCaisse.ForeColor = SystemColors.ControlText;
            labelMontantConstateEnCaisse.Location = new Point(368, 10);
            labelMontantConstateEnCaisse.Name = "labelMontantConstateEnCaisse";
            labelMontantConstateEnCaisse.Size = new Size(151, 40);
            labelMontantConstateEnCaisse.TabIndex = 44;
            labelMontantConstateEnCaisse.Text = "Montant constaté en caisse";
            labelMontantConstateEnCaisse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDevise
            // 
            labelDevise.AutoSize = true;
            labelDevise.Dock = DockStyle.Right;
            labelDevise.ForeColor = SystemColors.ControlText;
            labelDevise.Location = new Point(30, 10);
            labelDevise.Name = "labelDevise";
            labelDevise.Size = new Size(41, 40);
            labelDevise.TabIndex = 38;
            labelDevise.Text = "Devise";
            labelDevise.TextAlign = ContentAlignment.MiddleRight;
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
            iconButtonFermer.Location = new Point(785, 4);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 48;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ControleDeCaisse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(833, 766);
            Controls.Add(iconButtonFermer);
            Controls.Add(groupBoxFiltre);
            Controls.Add(buttonOK);
            Controls.Add(panel1);
            Controls.Add(buttonAfficher);
            Controls.Add(checkBoxGenererEcart);
            Controls.Add(panelTotal);
            Controls.Add(dataGridView1);
            Name = "ControleDeCaisse";
            Text = "Contrôle de caisse";
            Load += ControleDeCaisse_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTotal.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBoxFiltre.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Intitule;
        private DataGridViewTextBoxColumn Montant;
        private Panel panelTotal;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelValeurResteAImputer;
        private Label labelEcart;
        private Label labelTotalConstate;
        private Label labelTotalReglement;
        private Label labelValeurTotalImpute;
        private Label labelValeurTotalReglement;
        private CheckBox checkBoxGenererEcart;
        private Button buttonAfficher;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelCaisse;
        private Label labelControle;
        private Label labelDate;
        private Button buttonOK;
        private Panel panel7;
        private DateTimePicker dateTimePickerDate;
        private TextBox textBoxDate;
        private Panel panel2;
        private ComboBox comboBoxCaisse;
        private Panel panel3;
        private ComboBox comboControle;
        private GroupBox groupBoxFiltre;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private ComboBox comboBoxDevise;
        private Panel panel10;
        private ComboBox comboBoxCaissier;
        private Label labelMontantConstateEnCaisse;
        private Label labelDevise;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}