using System.Drawing;
using System.Windows.Forms;


namespace Soft_Caisse.Views.Donnees
{
    partial class Collaborateurs
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Nom = new DataGridViewTextBoxColumn();
            Prenom = new DataGridViewTextBoxColumn();
            Fonction = new DataGridViewTextBoxColumn();
            btnSupprimer = new Button();
            btnNouveau = new Button();
            btnOuvrir = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(25, 9);
            tableLayoutPanel1.Margin = new Padding(0, 3, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(334, 109);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 58);
            panel2.Margin = new Padding(0, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(331, 34);
            panel2.TabIndex = 37;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(305, 23);
            comboBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 15);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 40);
            label1.TabIndex = 38;
            label1.Text = "Filtre";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nom, Prenom, Fonction });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(723, 492);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            // 
            // Prenom
            // 
            Prenom.HeaderText = "Prénom(s)";
            Prenom.Name = "Prenom";
            // 
            // Fonction
            // 
            Fonction.HeaderText = "Fonction";
            Fonction.Name = "Fonction";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            btnSupprimer.Cursor = Cursors.Hand;
            btnSupprimer.FlatAppearance.BorderSize = 0;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Segoe UI", 11F);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(558, 661);
            btnSupprimer.Margin = new Padding(144, 3, 144, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Padding = new Padding(8, 0, 0, 0);
            btnSupprimer.Size = new Size(190, 45);
            btnSupprimer.TabIndex = 26;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnNouveau
            // 
            btnNouveau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNouveau.BackColor = Color.FromArgb(129, 166, 181);
            btnNouveau.Cursor = Cursors.Hand;
            btnNouveau.FlatAppearance.BorderSize = 0;
            btnNouveau.FlatStyle = FlatStyle.Flat;
            btnNouveau.Font = new Font("Segoe UI", 11F);
            btnNouveau.ForeColor = Color.White;
            btnNouveau.Location = new Point(358, 661);
            btnNouveau.Margin = new Padding(144, 3, 144, 3);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.Padding = new Padding(8, 0, 0, 0);
            btnNouveau.Size = new Size(190, 45);
            btnNouveau.TabIndex = 27;
            btnNouveau.Text = "Nouveau";
            btnNouveau.UseVisualStyleBackColor = false;
            btnNouveau.Click += btnNouveau_Click;
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
            btnOuvrir.Location = new Point(158, 661);
            btnOuvrir.Margin = new Padding(144, 3, 144, 3);
            btnOuvrir.Name = "btnOuvrir";
            btnOuvrir.Padding = new Padding(8, 0, 0, 0);
            btnOuvrir.Size = new Size(190, 45);
            btnOuvrir.TabIndex = 28;
            btnOuvrir.Text = "Ouvrir";
            btnOuvrir.UseVisualStyleBackColor = false;
            btnOuvrir.Click += btnOuvrir_Click;
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
            iconButtonFermer.TabIndex = 51;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // Collaborateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 718);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnOuvrir);
            Controls.Add(btnNouveau);
            Controls.Add(btnSupprimer);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "Collaborateurs";
            ShowIcon = false;
            ShowInTaskbar = false;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSupprimer;
        private Button btnNouveau;
        private Button btnOuvrir;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Prenom;
        private DataGridViewTextBoxColumn Fonction;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}