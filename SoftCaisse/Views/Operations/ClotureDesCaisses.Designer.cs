using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations
{
    partial class ClotureDesCaisses
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
            groupBoxCaissesACloturer = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            comboBoxA = new ComboBox();
            panel7 = new Panel();
            comboBoxCaisseDe = new ComboBox();
            labelCaisseDe = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            comboBoxRegroupementTickets = new ComboBox();
            panel4 = new Panel();
            comboBoxSouche = new ComboBox();
            labelRegroupementTickets = new Label();
            labelSouche = new Label();
            buttonOK = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dateTimePickerDateCloture = new DateTimePicker();
            textBoxDateCloture = new TextBox();
            labelDateDeCloture = new Label();
            panel5 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBoxCaissesACloturer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCaissesACloturer
            // 
            groupBoxCaissesACloturer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCaissesACloturer.Controls.Add(tableLayoutPanel2);
            groupBoxCaissesACloturer.Location = new Point(24, 142);
            groupBoxCaissesACloturer.Name = "groupBoxCaissesACloturer";
            groupBoxCaissesACloturer.Padding = new Padding(12, 8, 12, 18);
            groupBoxCaissesACloturer.Size = new Size(464, 120);
            groupBoxCaissesACloturer.TabIndex = 24;
            groupBoxCaissesACloturer.TabStop = false;
            groupBoxCaissesACloturer.Text = "Caisses à cloturer";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(panel3, 2, 1);
            tableLayoutPanel2.Controls.Add(panel7, 0, 1);
            tableLayoutPanel2.Controls.Add(labelCaisseDe, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(440, 78);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBoxA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(245, 42);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 5, 4, 0);
            panel3.Size = new Size(192, 33);
            panel3.TabIndex = 47;
            // 
            // comboBoxA
            // 
            comboBoxA.Dock = DockStyle.Fill;
            comboBoxA.FlatStyle = FlatStyle.Flat;
            comboBoxA.FormattingEnabled = true;
            comboBoxA.Location = new Point(20, 5);
            comboBoxA.Name = "comboBoxA";
            comboBoxA.Size = new Size(166, 23);
            comboBoxA.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBoxCaisseDe);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 42);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(192, 33);
            panel7.TabIndex = 45;
            // 
            // comboBoxCaisseDe
            // 
            comboBoxCaisseDe.Dock = DockStyle.Fill;
            comboBoxCaisseDe.FlatStyle = FlatStyle.Flat;
            comboBoxCaisseDe.FormattingEnabled = true;
            comboBoxCaisseDe.Location = new Point(20, 5);
            comboBoxCaisseDe.Name = "comboBoxCaisseDe";
            comboBoxCaisseDe.Size = new Size(166, 23);
            comboBoxCaisseDe.TabIndex = 0;
            // 
            // labelCaisseDe
            // 
            labelCaisseDe.AutoSize = true;
            labelCaisseDe.Dock = DockStyle.Left;
            labelCaisseDe.Location = new Point(6, 6);
            labelCaisseDe.Margin = new Padding(6);
            labelCaisseDe.Name = "labelCaisseDe";
            labelCaisseDe.Size = new Size(56, 27);
            labelCaisseDe.TabIndex = 26;
            labelCaisseDe.Text = "Caisse de";
            labelCaisseDe.TextAlign = ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Location = new Point(24, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(12, 8, 12, 18);
            groupBox1.Size = new Size(464, 120);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paramètres de génération des factures";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel3.Controls.Add(panel2, 2, 1);
            tableLayoutPanel3.Controls.Add(panel4, 0, 1);
            tableLayoutPanel3.Controls.Add(labelRegroupementTickets, 2, 0);
            tableLayoutPanel3.Controls.Add(labelSouche, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(12, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(440, 78);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxRegroupementTickets);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(245, 42);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(192, 33);
            panel2.TabIndex = 47;
            // 
            // comboBoxRegroupementTickets
            // 
            comboBoxRegroupementTickets.Dock = DockStyle.Fill;
            comboBoxRegroupementTickets.FlatStyle = FlatStyle.Flat;
            comboBoxRegroupementTickets.FormattingEnabled = true;
            comboBoxRegroupementTickets.Location = new Point(20, 5);
            comboBoxRegroupementTickets.Name = "comboBoxRegroupementTickets";
            comboBoxRegroupementTickets.Size = new Size(166, 23);
            comboBoxRegroupementTickets.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxSouche);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 42);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(192, 33);
            panel4.TabIndex = 45;
            // 
            // comboBoxSouche
            // 
            comboBoxSouche.Dock = DockStyle.Fill;
            comboBoxSouche.FlatStyle = FlatStyle.Flat;
            comboBoxSouche.FormattingEnabled = true;
            comboBoxSouche.Location = new Point(20, 5);
            comboBoxSouche.Name = "comboBoxSouche";
            comboBoxSouche.Size = new Size(166, 23);
            comboBoxSouche.TabIndex = 0;
            // 
            // labelRegroupementTickets
            // 
            labelRegroupementTickets.AutoSize = true;
            labelRegroupementTickets.Dock = DockStyle.Left;
            labelRegroupementTickets.Location = new Point(248, 6);
            labelRegroupementTickets.Margin = new Padding(6);
            labelRegroupementTickets.Name = "labelRegroupementTickets";
            labelRegroupementTickets.Size = new Size(147, 27);
            labelRegroupementTickets.TabIndex = 28;
            labelRegroupementTickets.Text = "Regroupement des Tickets";
            labelRegroupementTickets.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelSouche
            // 
            labelSouche.AutoSize = true;
            labelSouche.Dock = DockStyle.Left;
            labelSouche.Location = new Point(6, 6);
            labelSouche.Margin = new Padding(6);
            labelSouche.Name = "labelSouche";
            labelSouche.Size = new Size(46, 27);
            labelSouche.TabIndex = 26;
            labelSouche.Text = "Souche";
            labelSouche.TextAlign = ContentAlignment.BottomLeft;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.BackColor = Color.FromArgb(129, 166, 181);
            buttonOK.Cursor = Cursors.Hand;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 11F);
            buttonOK.ForeColor = Color.White;
            buttonOK.Location = new Point(303, 441);
            buttonOK.Margin = new Padding(144, 3, 144, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new Padding(8, 0, 0, 0);
            buttonOK.Size = new Size(185, 45);
            buttonOK.TabIndex = 35;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1526489F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.84735F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(labelDateDeCloture, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(321, 40);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePickerDateCloture);
            panel1.Controls.Add(textBoxDateCloture);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(103, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(215, 34);
            panel1.TabIndex = 35;
            // 
            // dateTimePickerDateCloture
            // 
            dateTimePickerDateCloture.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateCloture.Location = new Point(1, 34);
            dateTimePickerDateCloture.Name = "dateTimePickerDateCloture";
            dateTimePickerDateCloture.Size = new Size(158, 23);
            dateTimePickerDateCloture.TabIndex = 25;
            dateTimePickerDateCloture.ValueChanged += dateTimePickerDateCloture_ValueChanged;
            // 
            // textBoxDateCloture
            // 
            textBoxDateCloture.BorderStyle = BorderStyle.None;
            textBoxDateCloture.Dock = DockStyle.Fill;
            textBoxDateCloture.Location = new Point(20, 9);
            textBoxDateCloture.Name = "textBoxDateCloture";
            //textBoxDateCloture.PlaceholderText = "DD/MM/YYYY";
            textBoxDateCloture.Size = new Size(173, 16);
            textBoxDateCloture.TabIndex = 0;
            textBoxDateCloture.Click += textBoxDateCloture_Click;
            // 
            // labelDateDeCloture
            // 
            labelDateDeCloture.AutoSize = true;
            labelDateDeCloture.Dock = DockStyle.Left;
            labelDateDeCloture.ForeColor = Color.White;
            labelDateDeCloture.Location = new Point(3, 0);
            labelDateDeCloture.Name = "labelDateDeCloture";
            labelDateDeCloture.Size = new Size(87, 40);
            labelDateDeCloture.TabIndex = 25;
            labelDateDeCloture.Text = "Date de clôture";
            labelDateDeCloture.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(84, 138, 178);
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Location = new Point(24, 55);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(12);
            panel5.Size = new Size(464, 64);
            panel5.TabIndex = 36;
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
            iconButtonFermer.Location = new Point(493, 10);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 66;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ClotureDesCaisses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(541, 498);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel5);
            Controls.Add(buttonOK);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxCaissesACloturer);
            Name = "ClotureDesCaisses";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Cloture des caisses";
            Load += ClotureDesCaisses_Load;
            groupBoxCaissesACloturer.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxCaissesACloturer;
        private Label labelDateDeCloture;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DateTimePicker dateTimePickerDateCloture;
        private TextBox textBoxDateCloture;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label labelCaisseDe;
        private Panel panel3;
        private ComboBox comboBoxA;
        private Panel panel7;
        private ComboBox comboBoxCaisseDe;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private ComboBox comboBoxRegroupementTickets;
        private Panel panel4;
        private ComboBox comboBoxSouche;
        private Label labelRegroupementTickets;
        private Label labelSouche;
        private Button buttonOK;
        private GroupBox groupBox2;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}