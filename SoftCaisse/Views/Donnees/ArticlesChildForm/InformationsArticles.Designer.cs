using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class InformationsArticles
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
            tableLayoutPanel = new TableLayoutPanel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            txtBxNomDuServeur = new TextBox();
            lblDesignation = new Label();
            lblType = new Label();
            lblReference = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            comboBox8 = new ComboBox();
            panel13 = new Panel();
            comboBox9 = new ComboBox();
            panel14 = new Panel();
            comboBox11 = new ComboBox();
            panel16 = new Panel();
            comboBox12 = new ComboBox();
            panel17 = new Panel();
            comboBox13 = new ComboBox();
            panel21 = new Panel();
            comboBox14 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel15 = new Panel();
            textBox7 = new TextBox();
            panel18 = new Panel();
            textBox8 = new TextBox();
            panel19 = new Panel();
            textBox9 = new TextBox();
            panel20 = new Panel();
            textBox10 = new TextBox();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnFermer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel21.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel15.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(panel3, 1, 1);
            tableLayoutPanel.Controls.Add(panel1, 3, 0);
            tableLayoutPanel.Controls.Add(panel2, 1, 0);
            tableLayoutPanel.Controls.Add(lblDesignation, 0, 1);
            tableLayoutPanel.Controls.Add(lblType, 2, 0);
            tableLayoutPanel.Controls.Add(lblReference, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(15, 26);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(686, 81);
            tableLayoutPanel.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(140, 43);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(199, 35);
            panel3.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(20, 9);
            textBox2.Name = "textBox2";
            //textBox2.PlaceholderText = "Désignation";
            textBox2.Size = new Size(157, 16);
            textBox2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(482, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(201, 34);
            panel1.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(20, 9);
            textBox1.Name = "textBox1";
            //textBox1.PlaceholderText = "Type de l'article";
            textBox1.Size = new Size(159, 16);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxNomDuServeur);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(140, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(199, 34);
            panel2.TabIndex = 36;
            // 
            // txtBxNomDuServeur
            // 
            txtBxNomDuServeur.BorderStyle = BorderStyle.None;
            txtBxNomDuServeur.Dock = DockStyle.Fill;
            txtBxNomDuServeur.Location = new Point(20, 9);
            txtBxNomDuServeur.Name = "txtBxNomDuServeur";
            //txtBxNomDuServeur.PlaceholderText = "Référence";
            txtBxNomDuServeur.Size = new Size(157, 16);
            txtBxNomDuServeur.TabIndex = 0;
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Dock = DockStyle.Right;
            lblDesignation.Location = new Point(64, 40);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(70, 41);
            lblDesignation.TabIndex = 5;
            lblDesignation.Text = "Désignation";
            lblDesignation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Dock = DockStyle.Right;
            lblType.Location = new Point(444, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(32, 40);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleRight;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel5, 3, 2);
            tableLayoutPanel1.Controls.Add(panel13, 1, 2);
            tableLayoutPanel1.Controls.Add(panel14, 3, 1);
            tableLayoutPanel1.Controls.Add(panel16, 1, 1);
            tableLayoutPanel1.Controls.Add(panel17, 3, 0);
            tableLayoutPanel1.Controls.Add(panel21, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(label10, 2, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(686, 121);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBox8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(482, 83);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 5, 4, 0);
            panel5.Size = new Size(201, 35);
            panel5.TabIndex = 64;
            // 
            // comboBox8
            // 
            comboBox8.Dock = DockStyle.Fill;
            comboBox8.FlatStyle = FlatStyle.Flat;
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(20, 5);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(175, 23);
            comboBox8.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(comboBox9);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(140, 83);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(20, 5, 4, 0);
            panel13.Size = new Size(199, 35);
            panel13.TabIndex = 63;
            // 
            // comboBox9
            // 
            comboBox9.Dock = DockStyle.Fill;
            comboBox9.FlatStyle = FlatStyle.Flat;
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(20, 5);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(173, 23);
            comboBox9.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.BackColor = Color.White;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(comboBox11);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(482, 43);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(20, 5, 4, 0);
            panel14.Size = new Size(201, 34);
            panel14.TabIndex = 62;
            // 
            // comboBox11
            // 
            comboBox11.Dock = DockStyle.Fill;
            comboBox11.FlatStyle = FlatStyle.Flat;
            comboBox11.FormattingEnabled = true;
            comboBox11.Location = new Point(20, 5);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(175, 23);
            comboBox11.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.BackColor = Color.White;
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Controls.Add(comboBox12);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(140, 43);
            panel16.Name = "panel16";
            panel16.Padding = new Padding(20, 5, 4, 0);
            panel16.Size = new Size(199, 34);
            panel16.TabIndex = 61;
            // 
            // comboBox12
            // 
            comboBox12.Dock = DockStyle.Fill;
            comboBox12.FlatStyle = FlatStyle.Flat;
            comboBox12.FormattingEnabled = true;
            comboBox12.Location = new Point(20, 5);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(173, 23);
            comboBox12.TabIndex = 0;
            // 
            // panel17
            // 
            panel17.BackColor = Color.White;
            panel17.BorderStyle = BorderStyle.FixedSingle;
            panel17.Controls.Add(comboBox13);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(482, 3);
            panel17.Name = "panel17";
            panel17.Padding = new Padding(20, 5, 4, 0);
            panel17.Size = new Size(201, 34);
            panel17.TabIndex = 60;
            // 
            // comboBox13
            // 
            comboBox13.Dock = DockStyle.Fill;
            comboBox13.FlatStyle = FlatStyle.Flat;
            comboBox13.FormattingEnabled = true;
            comboBox13.Location = new Point(20, 5);
            comboBox13.Name = "comboBox13";
            comboBox13.Size = new Size(175, 23);
            comboBox13.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.BackColor = Color.White;
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(comboBox14);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(140, 3);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(20, 5, 4, 0);
            panel21.Size = new Size(199, 34);
            panel21.TabIndex = 59;
            // 
            // comboBox14
            // 
            comboBox14.Dock = DockStyle.Fill;
            comboBox14.FlatStyle = FlatStyle.Flat;
            comboBox14.FormattingEnabled = true;
            comboBox14.Location = new Point(20, 5);
            comboBox14.Name = "comboBox14";
            comboBox14.Size = new Size(173, 23);
            comboBox14.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Location = new Point(418, 80);
            label6.Name = "label6";
            label6.Size = new Size(58, 41);
            label6.TabIndex = 19;
            label6.Text = "Gamme 2";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(76, 80);
            label7.Name = "label7";
            label7.Size = new Size(58, 41);
            label7.TabIndex = 17;
            label7.Text = "Gamme 1";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(375, 40);
            label8.Name = "label8";
            label8.Size = new Size(101, 40);
            label8.TabIndex = 15;
            label8.Text = "Conditionnement";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Right;
            label9.Location = new Point(55, 40);
            label9.Name = "label9";
            label9.Size = new Size(79, 40);
            label9.TabIndex = 13;
            label9.Text = "Suivi de stock";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Right;
            label10.Location = new Point(393, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 40);
            label10.TabIndex = 11;
            label10.Text = "Nomenclature";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Right;
            label11.Location = new Point(89, 0);
            label11.Name = "label11";
            label11.Size = new Size(45, 40);
            label11.TabIndex = 9;
            label11.Text = "Famille";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel);
            groupBox1.Location = new Point(22, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 10, 30, 20);
            groupBox1.Size = new Size(731, 127);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identification";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel4, 3, 0);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Controls.Add(panel15, 1, 3);
            tableLayoutPanel2.Controls.Add(panel18, 1, 2);
            tableLayoutPanel2.Controls.Add(panel19, 1, 1);
            tableLayoutPanel2.Controls.Add(panel20, 1, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 3);
            tableLayoutPanel2.Controls.Add(label14, 0, 2);
            tableLayoutPanel2.Controls.Add(label15, 0, 1);
            tableLayoutPanel2.Controls.Add(label16, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(15, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(686, 161);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(482, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(201, 34);
            panel4.TabIndex = 69;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(405, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 40);
            label1.TabIndex = 68;
            label1.Text = "Pays origine";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(textBox7);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(140, 123);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(20, 9, 20, 10);
            panel15.Size = new Size(199, 35);
            panel15.TabIndex = 55;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(20, 9);
            textBox7.Name = "textBox7";
            //textBox7.PlaceholderText = "Code EDI de l'article";
            textBox7.Size = new Size(157, 16);
            textBox7.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(textBox8);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(140, 83);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(20, 9, 20, 10);
            panel18.Size = new Size(199, 34);
            panel18.TabIndex = 53;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Dock = DockStyle.Fill;
            textBox8.Location = new Point(20, 9);
            textBox8.Name = "textBox8";
            //textBox8.PlaceholderText = "Code fiscal";
            textBox8.Size = new Size(157, 16);
            textBox8.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.BorderStyle = BorderStyle.FixedSingle;
            panel19.Controls.Add(textBox9);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(140, 43);
            panel19.Name = "panel19";
            panel19.Padding = new Padding(20, 9, 20, 10);
            panel19.Size = new Size(199, 34);
            panel19.TabIndex = 50;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Dock = DockStyle.Fill;
            textBox9.Location = new Point(20, 9);
            textBox9.Name = "textBox9";
            //textBox9.PlaceholderText = "Description avec la langue 2";
            textBox9.Size = new Size(157, 16);
            textBox9.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.BackColor = Color.White;
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(textBox10);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(140, 3);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(20, 9, 20, 10);
            panel20.Size = new Size(199, 34);
            panel20.TabIndex = 47;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Dock = DockStyle.Fill;
            textBox10.Location = new Point(20, 9);
            textBox10.Name = "textBox10";
            //textBox10.PlaceholderText = "Description avec la langue 2";
            textBox10.Size = new Size(157, 16);
            textBox10.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Right;
            label12.Location = new Point(79, 120);
            label12.Name = "label12";
            label12.Size = new Size(55, 41);
            label12.TabIndex = 33;
            label12.Text = "Code EDI";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Right;
            label14.Location = new Point(69, 80);
            label14.Name = "label14";
            label14.Size = new Size(65, 40);
            label14.TabIndex = 29;
            label14.Text = "Code fiscal";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Right;
            label15.Location = new Point(79, 40);
            label15.Name = "label15";
            label15.Size = new Size(55, 40);
            label15.TabIndex = 25;
            label15.Text = "Langue 2";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Right;
            label16.Location = new Point(79, 0);
            label16.Name = "label16";
            label16.Size = new Size(55, 40);
            label16.TabIndex = 21;
            label16.Text = "Langue 1";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(22, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 10, 30, 20);
            groupBox2.Size = new Size(731, 167);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Classifications";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tableLayoutPanel2);
            groupBox3.Location = new Point(22, 418);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 10, 30, 20);
            groupBox3.Size = new Size(731, 207);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Descriptions";
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFermer.BackColor = Color.FromArgb(129, 166, 181);
            btnFermer.Cursor = Cursors.Hand;
            btnFermer.FlatAppearance.BorderSize = 0;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Segoe UI", 11F);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(563, 653);
            btnFermer.Margin = new Padding(144, 3, 144, 3);
            btnFermer.Name = "btnFermer";
            btnFermer.Padding = new Padding(8, 0, 0, 0);
            btnFermer.Size = new Size(190, 45);
            btnFermer.TabIndex = 27;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
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
            iconButtonFermer.Location = new Point(755, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 43;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // InformationsArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 721);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnFermer);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "InformationsArticles";
            ShowIcon = false;
            ShowInTaskbar = false;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel21.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel;
        private Label lblDesignation;
        private Label lblType;
        private Label lblReference;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox txtBxNomDuServeur;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private ComboBox comboBox8;
        private Panel panel13;
        private ComboBox comboBox9;
        private Panel panel14;
        private ComboBox comboBox11;
        private Panel panel16;
        private ComboBox comboBox12;
        private Panel panel17;
        private ComboBox comboBox13;
        private Panel panel21;
        private ComboBox comboBox14;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel15;
        private TextBox textBox7;
        private Panel panel18;
        private TextBox textBox8;
        private Panel panel19;
        private TextBox textBox9;
        private Panel panel20;
        private TextBox textBox10;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnFermer;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}