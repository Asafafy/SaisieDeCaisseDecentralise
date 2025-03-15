using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class InterrogationDuStockArticle
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
            panel15 = new Panel();
            comboBoxEnumere2 = new ComboBox();
            panel13 = new Panel();
            comboBoxEmplacement = new ComboBox();
            panel12 = new Panel();
            comboBoxConditionnement = new ComboBox();
            panel10 = new Panel();
            comboBoxEnumere1 = new ComboBox();
            panel8 = new Panel();
            comboBoxDepot = new ComboBox();
            lblConditionnement = new Label();
            lblGammes = new Label();
            lblDepot = new Label();
            dataGridView1 = new DataGridView();
            Depot = new DataGridViewTextBoxColumn();
            Enumere = new DataGridViewTextBoxColumn();
            StockReel = new DataGridViewTextBoxColumn();
            Commande = new DataGridViewTextBoxColumn();
            Reserve = new DataGridViewTextBoxColumn();
            StockATerme = new DataGridViewTextBoxColumn();
            CMUP = new DataGridViewTextBoxColumn();
            ValeurDuStock = new DataGridViewTextBoxColumn();
            Prepare = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblArticle = new Label();
            panel2 = new Panel();
            comboBoxArticle = new ComboBox();
            panel1 = new Panel();
            btnAfficher = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel15.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel15, 2, 3);
            tableLayoutPanel1.Controls.Add(panel13, 0, 3);
            tableLayoutPanel1.Controls.Add(panel12, 4, 2);
            tableLayoutPanel1.Controls.Add(panel10, 2, 2);
            tableLayoutPanel1.Controls.Add(panel8, 0, 2);
            tableLayoutPanel1.Controls.Add(lblConditionnement, 4, 1);
            tableLayoutPanel1.Controls.Add(lblGammes, 2, 1);
            tableLayoutPanel1.Controls.Add(lblDepot, 0, 1);
            tableLayoutPanel1.Location = new Point(21, 174);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(1170, 151);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(comboBoxEnumere2);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(412, 98);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(20, 5, 4, 0);
            panel15.Size = new Size(345, 34);
            panel15.TabIndex = 43;
            panel15.Paint += panel15_Paint;
            // 
            // comboBoxEnumere2
            // 
            comboBoxEnumere2.Dock = DockStyle.Fill;
            comboBoxEnumere2.FlatStyle = FlatStyle.Flat;
            comboBoxEnumere2.FormattingEnabled = true;
            comboBoxEnumere2.Location = new Point(20, 5);
            comboBoxEnumere2.Name = "comboBoxEnumere2";
            comboBoxEnumere2.Size = new Size(319, 23);
            comboBoxEnumere2.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(comboBoxEmplacement);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 98);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(20, 5, 4, 0);
            panel13.Size = new Size(345, 34);
            panel13.TabIndex = 41;
            // 
            // comboBoxEmplacement
            // 
            comboBoxEmplacement.Dock = DockStyle.Fill;
            comboBoxEmplacement.FlatStyle = FlatStyle.Flat;
            comboBoxEmplacement.FormattingEnabled = true;
            comboBoxEmplacement.Location = new Point(20, 5);
            comboBoxEmplacement.Name = "comboBoxEmplacement";
            comboBoxEmplacement.Size = new Size(319, 23);
            comboBoxEmplacement.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(comboBoxConditionnement);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(821, 58);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(20, 5, 4, 0);
            panel12.Size = new Size(346, 34);
            panel12.TabIndex = 40;
            // 
            // comboBoxConditionnement
            // 
            comboBoxConditionnement.Dock = DockStyle.Fill;
            comboBoxConditionnement.FlatStyle = FlatStyle.Flat;
            comboBoxConditionnement.FormattingEnabled = true;
            comboBoxConditionnement.Location = new Point(20, 5);
            comboBoxConditionnement.Name = "comboBoxConditionnement";
            comboBoxConditionnement.Size = new Size(320, 23);
            comboBoxConditionnement.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBoxEnumere1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(412, 58);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 5, 4, 0);
            panel10.Size = new Size(345, 34);
            panel10.TabIndex = 38;
            // 
            // comboBoxEnumere1
            // 
            comboBoxEnumere1.Dock = DockStyle.Fill;
            comboBoxEnumere1.FlatStyle = FlatStyle.Flat;
            comboBoxEnumere1.FormattingEnabled = true;
            comboBoxEnumere1.Location = new Point(20, 5);
            comboBoxEnumere1.Name = "comboBoxEnumere1";
            comboBoxEnumere1.Size = new Size(319, 23);
            comboBoxEnumere1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(comboBoxDepot);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 58);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 5, 4, 0);
            panel8.Size = new Size(345, 34);
            panel8.TabIndex = 36;
            // 
            // comboBoxDepot
            // 
            comboBoxDepot.Dock = DockStyle.Fill;
            comboBoxDepot.FlatStyle = FlatStyle.Flat;
            comboBoxDepot.FormattingEnabled = true;
            comboBoxDepot.Location = new Point(20, 5);
            comboBoxDepot.Name = "comboBoxDepot";
            comboBoxDepot.Size = new Size(319, 23);
            comboBoxDepot.TabIndex = 0;
            // 
            // lblConditionnement
            // 
            lblConditionnement.AutoSize = true;
            lblConditionnement.Dock = DockStyle.Left;
            lblConditionnement.Location = new Point(821, 15);
            lblConditionnement.Name = "lblConditionnement";
            lblConditionnement.Size = new Size(101, 40);
            lblConditionnement.TabIndex = 9;
            lblConditionnement.Text = "Conditionnement";
            lblConditionnement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGammes
            // 
            lblGammes.AutoSize = true;
            lblGammes.Dock = DockStyle.Left;
            lblGammes.Location = new Point(412, 15);
            lblGammes.Name = "lblGammes";
            lblGammes.Size = new Size(54, 40);
            lblGammes.TabIndex = 7;
            lblGammes.Text = "Gammes";
            lblGammes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDepot
            // 
            lblDepot.AutoSize = true;
            lblDepot.Dock = DockStyle.Left;
            lblDepot.Location = new Point(3, 15);
            lblDepot.Name = "lblDepot";
            lblDepot.Size = new Size(39, 40);
            lblDepot.TabIndex = 0;
            lblDepot.Text = "Dépôt";
            lblDepot.TextAlign = ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Depot, Enumere, StockReel, Commande, Reserve, StockATerme, CMUP, ValeurDuStock, Prepare });
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
            dataGridView1.Location = new Point(21, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1170, 457);
            dataGridView1.TabIndex = 22;
            // 
            // Depot
            // 
            Depot.HeaderText = "Dépôt";
            Depot.Name = "Depot";
            // 
            // Enumere
            // 
            Enumere.HeaderText = "Enuméré";
            Enumere.Name = "Enumere";
            // 
            // StockReel
            // 
            StockReel.HeaderText = "Stock réel";
            StockReel.Name = "StockReel";
            // 
            // Commande
            // 
            Commande.HeaderText = "Commandé";
            Commande.Name = "Commande";
            // 
            // Reserve
            // 
            Reserve.HeaderText = "Réservé";
            Reserve.Name = "Reserve";
            // 
            // StockATerme
            // 
            StockATerme.HeaderText = "Stock à terme";
            StockATerme.Name = "StockATerme";
            // 
            // CMUP
            // 
            CMUP.HeaderText = "CMUP";
            CMUP.Name = "CMUP";
            // 
            // ValeurDuStock
            // 
            ValeurDuStock.HeaderText = "Valeur du stock";
            ValeurDuStock.Name = "ValeurDuStock";
            // 
            // Prepare
            // 
            Prepare.HeaderText = "Préparé";
            Prepare.Name = "Prepare";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel2.Controls.Add(lblArticle, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 1, 1);
            tableLayoutPanel2.Location = new Point(21, 44);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(348, 67);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Dock = DockStyle.Left;
            lblArticle.Location = new Point(3, 15);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(41, 40);
            lblArticle.TabIndex = 39;
            lblArticle.Text = "Article";
            lblArticle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxArticle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(61, 18);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(284, 34);
            panel2.TabIndex = 38;
            // 
            // comboBoxArticle
            // 
            comboBoxArticle.Dock = DockStyle.Fill;
            comboBoxArticle.FlatStyle = FlatStyle.Flat;
            comboBoxArticle.FormattingEnabled = true;
            comboBoxArticle.Location = new Point(20, 5);
            comboBoxArticle.Name = "comboBoxArticle";
            comboBoxArticle.Size = new Size(258, 23);
            comboBoxArticle.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 64, 102);
            panel1.Location = new Point(21, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 5);
            panel1.TabIndex = 24;
            // 
            // btnAfficher
            // 
            btnAfficher.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAfficher.BackColor = Color.FromArgb(129, 166, 181);
            btnAfficher.Cursor = Cursors.Hand;
            btnAfficher.FlatAppearance.BorderSize = 0;
            btnAfficher.FlatStyle = FlatStyle.Flat;
            btnAfficher.Font = new Font("Segoe UI", 11F);
            btnAfficher.ForeColor = Color.White;
            btnAfficher.Location = new Point(377, 62);
            btnAfficher.Margin = new Padding(144, 3, 144, 3);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Padding = new Padding(8, 0, 0, 0);
            btnAfficher.Size = new Size(190, 34);
            btnAfficher.TabIndex = 28;
            btnAfficher.Text = "Afficher";
            btnAfficher.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(1187, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 44;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // InterrogationDuStockArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1239, 841);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnAfficher);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "InterrogationDuStockArticle";
            ShowIcon = false;
            ShowInTaskbar = false;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel15.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblConditionnement;
        private Label lblGammes;
        private Label lblDepot;
        private Panel panel15;
        private ComboBox comboBoxEnumere2;
        private Panel panel13;
        private ComboBox comboBoxEmplacement;
        private Panel panel12;
        private ComboBox comboBoxConditionnement;
        private Panel panel10;
        private ComboBox comboBoxEnumere1;
        private Panel panel8;
        private ComboBox comboBoxDepot;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblArticle;
        private Panel panel2;
        private ComboBox comboBoxArticle;
        private Panel panel1;
        private Button btnAfficher;
        private DataGridViewTextBoxColumn Depot;
        private DataGridViewTextBoxColumn Enumere;
        private DataGridViewTextBoxColumn StockReel;
        private DataGridViewTextBoxColumn Commande;
        private DataGridViewTextBoxColumn Reserve;
        private DataGridViewTextBoxColumn StockATerme;
        private DataGridViewTextBoxColumn CMUP;
        private DataGridViewTextBoxColumn ValeurDuStock;
        private DataGridViewTextBoxColumn Prepare;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}