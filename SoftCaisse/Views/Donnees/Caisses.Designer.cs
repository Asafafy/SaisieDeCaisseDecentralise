using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees
{
    partial class Caisses
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
            Depot = new DataGridViewTextBoxColumn();
            CaissierParDefaut = new DataGridViewTextBoxColumn();
            VendeurParDefaut = new DataGridViewTextBoxColumn();
            btnVoir = new Button();
            btnAjouter = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Intitule, Depot, CaissierParDefaut, VendeurParDefaut });
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
            dataGridView1.Location = new Point(30, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(887, 455);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Intitule
            // 
            Intitule.HeaderText = "Intitulé";
            Intitule.Name = "Intitule";
            // 
            // Depot
            // 
            Depot.HeaderText = "Dépôt";
            Depot.Name = "Depot";
            // 
            // CaissierParDefaut
            // 
            CaissierParDefaut.HeaderText = "Caissier par défaut";
            CaissierParDefaut.Name = "CaissierParDefaut";
            // 
            // VendeurParDefaut
            // 
            VendeurParDefaut.HeaderText = "Vendeur par défaut";
            VendeurParDefaut.Name = "VendeurParDefaut";
            // 
            // btnVoir
            // 
            btnVoir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoir.BackColor = Color.FromArgb(129, 166, 181);
            btnVoir.Cursor = Cursors.Hand;
            btnVoir.FlatAppearance.BorderSize = 0;
            btnVoir.FlatStyle = FlatStyle.Flat;
            btnVoir.Font = new Font("Segoe UI", 11F);
            btnVoir.ForeColor = Color.White;
            btnVoir.Location = new Point(727, 521);
            btnVoir.Margin = new Padding(144, 3, 144, 3);
            btnVoir.Name = "btnVoir";
            btnVoir.Padding = new Padding(8, 0, 0, 0);
            btnVoir.Size = new Size(190, 45);
            btnVoir.TabIndex = 25;
            btnVoir.Text = "Voir";
            btnVoir.UseVisualStyleBackColor = false;
            btnVoir.Click += btnVoir_Click;
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
            btnAjouter.Location = new Point(527, 521);
            btnAjouter.Margin = new Padding(144, 3, 144, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Padding = new Padding(8, 0, 0, 0);
            btnAjouter.Size = new Size(190, 45);
            btnAjouter.TabIndex = 26;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
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
            iconButtonFermer.Location = new Point(920, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 49;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // Caisses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(967, 578);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnAjouter);
            Controls.Add(btnVoir);
            Controls.Add(dataGridView1);
            Name = "Caisses";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Intitule;
        private DataGridViewTextBoxColumn Depot;
        private DataGridViewTextBoxColumn CaissierParDefaut;
        private DataGridViewTextBoxColumn VendeurParDefaut;
        private Button btnVoir;
        private Button btnAjouter;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}