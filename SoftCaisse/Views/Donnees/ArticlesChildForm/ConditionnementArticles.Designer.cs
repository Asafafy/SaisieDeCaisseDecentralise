using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.ArticlesChildForm
{
    partial class ConditionnementArticles
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
            btnModifier = new Button();
            btnAjouter = new Button();
            btnSupprimer = new Button();
            dataGridView1 = new DataGridView();
            Enumere = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            CodeBarres = new DataGridViewTextBoxColumn();
            Quantite = new DataGridViewTextBoxColumn();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnModifier.Location = new Point(138, 430);
            btnModifier.Margin = new Padding(144, 3, 144, 3);
            btnModifier.Name = "btnModifier";
            btnModifier.Padding = new Padding(8, 0, 0, 0);
            btnModifier.Size = new Size(190, 45);
            btnModifier.TabIndex = 29;
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
            btnAjouter.Location = new Point(340, 430);
            btnAjouter.Margin = new Padding(144, 3, 144, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Padding = new Padding(8, 0, 0, 0);
            btnAjouter.Size = new Size(190, 45);
            btnAjouter.TabIndex = 28;
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
            btnSupprimer.Location = new Point(543, 430);
            btnSupprimer.Margin = new Padding(144, 3, 144, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Padding = new Padding(8, 0, 0, 0);
            btnSupprimer.Size = new Size(190, 45);
            btnSupprimer.TabIndex = 27;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Enumere, Reference, CodeBarres, Quantite });
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
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(721, 366);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Enumere
            // 
            Enumere.HeaderText = "Enuméré";
            Enumere.Name = "Enumere";
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
            // Quantite
            // 
            Quantite.HeaderText = "Quantité";
            Quantite.Name = "Quantite";
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
            iconButtonFermer.Location = new Point(739, 4);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 41;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ConditionnementArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(784, 487);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnSupprimer);
            Controls.Add(dataGridView1);
            Name = "ConditionnementArticles";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnSupprimer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Enumere;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn CodeBarres;
        private DataGridViewTextBoxColumn Quantite;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}