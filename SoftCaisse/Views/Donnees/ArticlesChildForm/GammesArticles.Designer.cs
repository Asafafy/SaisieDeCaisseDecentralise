using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class GammesArticles
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
            btnModifier = new Button();
            btnAjouter = new Button();
            btnSupprimer = new Button();
            dataGridView1 = new DataGridView();
            Enumere1 = new DataGridViewTextBoxColumn();
            Enumere2 = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            CodeBarres = new DataGridViewTextBoxColumn();
            PrixDAchat = new DataGridViewTextBoxColumn();
            EnSommeil = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBoxEnumere2 = new ComboBox();
            panel2 = new Panel();
            comboBoxEnumere1 = new ComboBox();
            lblEnumeres2 = new Label();
            lblEnumeres1 = new Label();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnModifier.BackColor = Color.FromArgb(129, 166, 181);
            btnModifier.Cursor = Cursors.Hand;
            btnModifier.FlatAppearance.BorderSize = 0;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 11F);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(469, 630);
            btnModifier.Margin = new Padding(144, 3, 144, 3);
            btnModifier.Name = "btnModifier";
            btnModifier.Padding = new Padding(8, 0, 0, 0);
            btnModifier.Size = new Size(190, 45);
            btnModifier.TabIndex = 33;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAjouter.BackColor = Color.FromArgb(129, 166, 181);
            btnAjouter.Cursor = Cursors.Hand;
            btnAjouter.FlatAppearance.BorderSize = 0;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 11F);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(671, 630);
            btnAjouter.Margin = new Padding(144, 3, 144, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Padding = new Padding(8, 0, 0, 0);
            btnAjouter.Size = new Size(190, 45);
            btnAjouter.TabIndex = 32;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
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
            btnSupprimer.Location = new Point(874, 630);
            btnSupprimer.Margin = new Padding(144, 3, 144, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Padding = new Padding(8, 0, 0, 0);
            btnSupprimer.Size = new Size(190, 45);
            btnSupprimer.TabIndex = 31;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Enumere1, Enumere2, Reference, CodeBarres, PrixDAchat, EnSommeil });
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
            dataGridView1.Location = new Point(12, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1052, 427);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Enumere1
            // 
            Enumere1.HeaderText = "Enuméré 1";
            Enumere1.Name = "Enumere1";
            // 
            // Enumere2
            // 
            Enumere2.HeaderText = "Enuméré 2";
            Enumere2.Name = "Enumere2";
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.Name = "Reference";
            // 
            // CodeBarres
            // 
            CodeBarres.HeaderText = "Code barres";
            CodeBarres.Name = "CodeBarres";
            // 
            // PrixDAchat
            // 
            PrixDAchat.HeaderText = "Prix d'achat";
            PrixDAchat.Name = "PrixDAchat";
            // 
            // EnSommeil
            // 
            EnSommeil.HeaderText = "En sommeil";
            EnSommeil.Name = "EnSommeil";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(12, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(30, 10, 30, 0);
            groupBox2.Size = new Size(1052, 120);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enumérés des gammes";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(panel4, 2, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblEnumeres2, 2, 0);
            tableLayoutPanel1.Controls.Add(lblEnumeres1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(992, 94);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxEnumere2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(548, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(441, 34);
            panel4.TabIndex = 41;
            // 
            // comboBoxEnumere2
            // 
            comboBoxEnumere2.Dock = DockStyle.Fill;
            comboBoxEnumere2.FlatStyle = FlatStyle.Flat;
            comboBoxEnumere2.FormattingEnabled = true;
            comboBoxEnumere2.Location = new Point(20, 5);
            comboBoxEnumere2.Name = "comboBoxEnumere2";
            comboBoxEnumere2.Size = new Size(415, 23);
            comboBoxEnumere2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxEnumere1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 43);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 5, 4, 0);
            panel2.Size = new Size(440, 34);
            panel2.TabIndex = 40;
            // 
            // comboBoxEnumere1
            // 
            comboBoxEnumere1.Dock = DockStyle.Fill;
            comboBoxEnumere1.FlatStyle = FlatStyle.Flat;
            comboBoxEnumere1.FormattingEnabled = true;
            comboBoxEnumere1.Location = new Point(20, 5);
            comboBoxEnumere1.Name = "comboBoxEnumere1";
            comboBoxEnumere1.Size = new Size(414, 23);
            comboBoxEnumere1.TabIndex = 0;
            // 
            // lblEnumeres2
            // 
            lblEnumeres2.AutoSize = true;
            lblEnumeres2.Dock = DockStyle.Left;
            lblEnumeres2.Location = new Point(548, 0);
            lblEnumeres2.Name = "lblEnumeres2";
            lblEnumeres2.Size = new Size(68, 40);
            lblEnumeres2.TabIndex = 3;
            lblEnumeres2.Text = "Enumérés 2";
            lblEnumeres2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEnumeres1
            // 
            lblEnumeres1.AutoSize = true;
            lblEnumeres1.Dock = DockStyle.Left;
            lblEnumeres1.Location = new Point(3, 0);
            lblEnumeres1.Name = "lblEnumeres1";
            lblEnumeres1.Size = new Size(68, 40);
            lblEnumeres1.TabIndex = 1;
            lblEnumeres1.Text = "Enumérés 1";
            lblEnumeres1.TextAlign = ContentAlignment.MiddleLeft;
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
            iconButtonFermer.Location = new Point(1070, 4);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 42;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // GammesArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1115, 688);
            Controls.Add(iconButtonFermer);
            Controls.Add(groupBox2);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnSupprimer);
            Controls.Add(dataGridView1);
            Name = "GammesArticles";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnSupprimer;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblEnumeres2;
        private Label lblEnumeres1;
        private Panel panel4;
        private ComboBox comboBoxEnumere2;
        private Panel panel2;
        private ComboBox comboBoxEnumere1;
        private DataGridViewTextBoxColumn Enumere1;
        private DataGridViewTextBoxColumn Enumere2;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn CodeBarres;
        private DataGridViewTextBoxColumn PrixDAchat;
        private DataGridViewTextBoxColumn EnSommeil;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}