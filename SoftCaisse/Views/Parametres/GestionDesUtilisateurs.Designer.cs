using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres
{
    partial class GestionDesUtilisateurs
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
            Id = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            btnModifier = new Button();
            btnNouveau = new Button();
            btnSupprimer = new Button();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nom, Role, Statut });
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
            dataGridView1.Location = new Point(39, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(710, 457);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            // 
            // Role
            // 
            Role.HeaderText = "Rôle";
            Role.Name = "Role";
            // 
            // Statut
            // 
            Statut.HeaderText = "Statut";
            Statut.Name = "Statut";
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
            btnModifier.Location = new Point(154, 520);
            btnModifier.Margin = new Padding(144, 3, 144, 3);
            btnModifier.Name = "btnModifier";
            btnModifier.Padding = new Padding(8, 0, 0, 0);
            btnModifier.Size = new Size(190, 45);
            btnModifier.TabIndex = 28;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
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
            btnNouveau.Location = new Point(356, 520);
            btnNouveau.Margin = new Padding(144, 3, 144, 3);
            btnNouveau.Name = "btnNouveau";
            btnNouveau.Padding = new Padding(8, 0, 0, 0);
            btnNouveau.Size = new Size(190, 45);
            btnNouveau.TabIndex = 27;
            btnNouveau.Text = "Nouveau";
            btnNouveau.UseVisualStyleBackColor = false;
            btnNouveau.Click += btnNouveau_Click;
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
            btnSupprimer.Location = new Point(559, 520);
            btnSupprimer.Margin = new Padding(144, 3, 144, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Padding = new Padding(8, 0, 0, 0);
            btnSupprimer.Size = new Size(190, 45);
            btnSupprimer.TabIndex = 26;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(751, 3);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 45;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // GestionDesUtilisateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 589);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnModifier);
            Controls.Add(btnNouveau);
            Controls.Add(btnSupprimer);
            Controls.Add(dataGridView1);
            Name = "GestionDesUtilisateurs";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Statut;
        private Button btnModifier;
        private Button btnNouveau;
        private Button btnSupprimer;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}