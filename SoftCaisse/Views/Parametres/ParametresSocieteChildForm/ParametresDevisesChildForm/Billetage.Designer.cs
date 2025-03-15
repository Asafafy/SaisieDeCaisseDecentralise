using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSocieteChildForm.ParametresDevisesChildForm
{
    partial class Billetage
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
            dataGridView1 = new DataGridView();
            Intitule = new DataGridViewTextBoxColumn();
            Valeur = new DataGridViewTextBoxColumn();
            btnBilletage = new Button();
            panel1 = new Panel();
            btnSupprimer = new Button();
            btnAjouter = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Intitule, Valeur });
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
            dataGridView1.Location = new Point(23, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(437, 545);
            dataGridView1.TabIndex = 20;
            // 
            // Intitule
            // 
            Intitule.HeaderText = "Intitulé";
            Intitule.Name = "Intitule";
            // 
            // Valeur
            // 
            Valeur.HeaderText = "Valeur";
            Valeur.Name = "Valeur";
            // 
            // btnBilletage
            // 
            btnBilletage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBilletage.BackColor = Color.FromArgb(129, 166, 181);
            btnBilletage.Cursor = Cursors.Hand;
            btnBilletage.FlatAppearance.BorderSize = 0;
            btnBilletage.FlatStyle = FlatStyle.Flat;
            btnBilletage.Font = new Font("Segoe UI", 11F);
            btnBilletage.ForeColor = Color.White;
            btnBilletage.Location = new Point(544, 662);
            btnBilletage.Margin = new Padding(144, 3, 144, 3);
            btnBilletage.Name = "btnBilletage";
            btnBilletage.Padding = new Padding(8, 0, 0, 0);
            btnBilletage.Size = new Size(190, 45);
            btnBilletage.TabIndex = 23;
            btnBilletage.Text = "Enregistrer";
            btnBilletage.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSupprimer);
            panel1.Controls.Add(btnAjouter);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(44, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 594);
            panel1.TabIndex = 25;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            btnSupprimer.Cursor = Cursors.Hand;
            btnSupprimer.FlatAppearance.BorderSize = 0;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Segoe UI", 11F);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(478, 23);
            btnSupprimer.Margin = new Padding(144, 3, 144, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Padding = new Padding(8, 0, 0, 0);
            btnSupprimer.Size = new Size(190, 45);
            btnSupprimer.TabIndex = 27;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
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
            btnAjouter.Location = new Point(498, -63);
            btnAjouter.Margin = new Padding(144, 3, 144, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Padding = new Padding(8, 0, 0, 0);
            btnAjouter.Size = new Size(190, 45);
            btnAjouter.TabIndex = 26;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(737, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 37;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // Billetage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(789, 719);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel1);
            Controls.Add(btnBilletage);
            Name = "Billetage";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBilletage;
        private Panel panel1;
        private Button btnSupprimer;
        private Button btnAjouter;
        private DataGridViewTextBoxColumn Intitule;
        private DataGridViewTextBoxColumn Valeur;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}