using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees
{
    partial class Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel10 = new Panel();
            comboBox9 = new ComboBox();
            panel9 = new Panel();
            comboBox8 = new ComboBox();
            panel8 = new Panel();
            comboBox7 = new ComboBox();
            panel7 = new Panel();
            comboBox6 = new ComboBox();
            panel6 = new Panel();
            comboBox5 = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            txtBxBarreDeRecherche = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Designation = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Famille = new DataGridViewTextBoxColumn();
            btnOuvrir = new Button();
            panel1 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20, 3, 20, 3);
            groupBox1.Size = new Size(1226, 91);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtre selon les catalogues d'articles";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel10, 4, 1);
            tableLayoutPanel1.Controls.Add(panel9, 3, 1);
            tableLayoutPanel1.Controls.Add(panel8, 2, 1);
            tableLayoutPanel1.Controls.Add(panel7, 1, 1);
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1186, 69);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBox9);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(951, 23);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 5, 4, 0);
            panel10.Size = new Size(232, 34);
            panel10.TabIndex = 38;
            // 
            // comboBox9
            // 
            comboBox9.Dock = DockStyle.Fill;
            comboBox9.FlatStyle = FlatStyle.Flat;
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(20, 5);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(206, 23);
            comboBox9.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(comboBox8);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(714, 23);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 5, 4, 0);
            panel9.Size = new Size(231, 34);
            panel9.TabIndex = 37;
            // 
            // comboBox8
            // 
            comboBox8.Dock = DockStyle.Fill;
            comboBox8.FlatStyle = FlatStyle.Flat;
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(20, 5);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(205, 23);
            comboBox8.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(comboBox7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(477, 23);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 5, 4, 0);
            panel8.Size = new Size(231, 34);
            panel8.TabIndex = 36;
            // 
            // comboBox7
            // 
            comboBox7.Dock = DockStyle.Fill;
            comboBox7.FlatStyle = FlatStyle.Flat;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(20, 5);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(205, 23);
            comboBox7.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBox6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(240, 23);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(231, 34);
            panel7.TabIndex = 35;
            // 
            // comboBox6
            // 
            comboBox6.Dock = DockStyle.Fill;
            comboBox6.FlatStyle = FlatStyle.Flat;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(20, 5);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(205, 23);
            comboBox6.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBox5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 23);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(231, 34);
            panel6.TabIndex = 34;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Fill;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(20, 5);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(205, 23);
            comboBox5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(button3, 1, 1);
            tableLayoutPanel2.Location = new Point(746, 164);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(472, 60);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxBarreDeRecherche);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 10);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 11, 20, 10);
            panel2.Size = new Size(427, 40);
            panel2.TabIndex = 26;
            // 
            // txtBxBarreDeRecherche
            // 

            txtBxBarreDeRecherche.BorderStyle = BorderStyle.None;
            txtBxBarreDeRecherche.Dock = DockStyle.Fill;
            txtBxBarreDeRecherche.Location = new Point(20, 11);
            txtBxBarreDeRecherche.Name = "txtBxBarreDeRecherche";
            //txtBxBarreDeRecherche.PlaceholderText = "Nom ou référence d'article";
            txtBxBarreDeRecherche.Size = new Size(385, 16);
            txtBxBarreDeRecherche.TabIndex = 0;
            txtBxBarreDeRecherche.TextChanged += txtBxBarreDeRecherche_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 64, 102);
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = Color.AliceBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(427, 10);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(45, 40);
            button3.TabIndex = 25;
            button3.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Designation, Reference, Famille });
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
            dataGridView1.Location = new Point(32, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1186, 534);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Designation
            // 
            Designation.HeaderText = "Désignation";
            Designation.Name = "Designation";
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.Name = "Reference";
            // 
            // Famille
            // 
            Famille.HeaderText = "Famille";
            Famille.Name = "Famille";
            // 
            // btnOuvrir
            // 
            btnOuvrir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOuvrir.BackColor = Color.FromArgb(129, 166, 181);
            btnOuvrir.Cursor = Cursors.Hand;
            btnOuvrir.FlatAppearance.BorderSize = 0;
            btnOuvrir.FlatStyle = FlatStyle.Flat;
            btnOuvrir.Font = new Font("Segoe UI", 11F);
            btnOuvrir.ForeColor = Color.White;
            btnOuvrir.Location = new Point(1028, 783);
            btnOuvrir.Margin = new Padding(144, 3, 144, 3);
            btnOuvrir.Name = "btnOuvrir";
            btnOuvrir.Padding = new Padding(8, 0, 0, 0);
            btnOuvrir.Size = new Size(190, 45);
            btnOuvrir.TabIndex = 24;
            btnOuvrir.Text = "Ouvrir";
            btnOuvrir.UseVisualStyleBackColor = false;
            btnOuvrir.Click += btnOuvrir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 64, 102);
            panel1.Location = new Point(12, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 5);
            panel1.TabIndex = 25;
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
            iconButtonFermer.Location = new Point(1238, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 48;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // Articles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1284, 842);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel1);
            Controls.Add(btnOuvrir);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(groupBox1);
            Name = "Articles";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel10;
        private ComboBox comboBox9;
        private Panel panel9;
        private ComboBox comboBox8;
        private Panel panel8;
        private ComboBox comboBox7;
        private Panel panel7;
        private ComboBox comboBox6;
        private Panel panel6;
        private ComboBox comboBox5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button3;
        private Panel panel2;
        private TextBox txtBxBarreDeRecherche;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Famille;
        private Button btnOuvrir;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}