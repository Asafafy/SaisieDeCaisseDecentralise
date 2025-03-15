using System.Drawing;
using System.Windows.Forms;



namespace Soft_Caisse.Views.Donnees
{
    partial class Familles
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
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            CodeFamille = new DataGridViewTextBoxColumn();
            Intitule = new DataGridViewTextBoxColumn();
            CatalogueArticle = new DataGridViewTextBoxColumn();
            Centralisation = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel1.Location = new Point(29, 21);
            tableLayoutPanel1.Margin = new Padding(0, 3, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(334, 107);
            tableLayoutPanel1.TabIndex = 25;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Type, CodeFamille, Intitule, CatalogueArticle, Centralisation });
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
            dataGridView1.Location = new Point(29, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1078, 572);
            dataGridView1.TabIndex = 29;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // CodeFamille
            // 
            CodeFamille.HeaderText = "Code famille";
            CodeFamille.Name = "CodeFamille";
            // 
            // Intitule
            // 
            Intitule.HeaderText = "Intitulé";
            Intitule.Name = "Intitule";
            // 
            // CatalogueArticle
            // 
            CatalogueArticle.HeaderText = "Catalogue article";
            CatalogueArticle.Name = "CatalogueArticle";
            // 
            // Centralisation
            // 
            Centralisation.HeaderText = "Centralisation";
            Centralisation.Name = "Centralisation";
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
            iconButtonFermer.Location = new Point(1122, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 52;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // Familles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1174, 792);
            Controls.Add(iconButtonFermer);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "Familles";
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
        private Button btnOuvrir;
        private Button btnNouveau;
        private Button btnSupprimer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn CodeFamille;
        private DataGridViewTextBoxColumn Intitule;
        private DataGridViewTextBoxColumn CatalogueArticle;
        private DataGridViewTextBoxColumn Centralisation;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}