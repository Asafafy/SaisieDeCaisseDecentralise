


using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Operations.VenteComptoirClidForm
{
    partial class RappelDocumentsEnAttente
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
            checkBoxAfficherTicketsToutesLesCaisses = new CheckBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            btnRappeler = new Button();
            buttonSupprimer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkBoxAfficherTicketsToutesLesCaisses
            // 
            checkBoxAfficherTicketsToutesLesCaisses.AutoSize = true;
            checkBoxAfficherTicketsToutesLesCaisses.Location = new Point(38, 50);
            checkBoxAfficherTicketsToutesLesCaisses.Name = "checkBoxAfficherTicketsToutesLesCaisses";
            checkBoxAfficherTicketsToutesLesCaisses.Size = new Size(301, 19);
            checkBoxAfficherTicketsToutesLesCaisses.TabIndex = 21;
            checkBoxAfficherTicketsToutesLesCaisses.Text = "Afficher les tickets en attente pour toutes les caisses.";
            checkBoxAfficherTicketsToutesLesCaisses.UseVisualStyleBackColor = true;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nom, Role, Statut });
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
            dataGridView1.Location = new Point(38, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(729, 340);
            dataGridView1.TabIndex = 22;
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
            // btnRappeler
            // 
            btnRappeler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRappeler.BackColor = Color.FromArgb(129, 166, 181);
            btnRappeler.Cursor = Cursors.Hand;
            btnRappeler.FlatAppearance.BorderSize = 0;
            btnRappeler.FlatStyle = FlatStyle.Flat;
            btnRappeler.Font = new Font("Segoe UI", 11F);
            btnRappeler.ForeColor = Color.White;
            btnRappeler.Location = new Point(577, 455);
            btnRappeler.Margin = new Padding(144, 3, 144, 3);
            btnRappeler.Name = "btnRappeler";
            btnRappeler.Padding = new Padding(8, 0, 0, 0);
            btnRappeler.Size = new Size(190, 45);
            btnRappeler.TabIndex = 29;
            btnRappeler.Text = "Rappeler";
            btnRappeler.UseVisualStyleBackColor = false;
            btnRappeler.Click += btnRappeler_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.FlatAppearance.BorderSize = 0;
            buttonSupprimer.FlatStyle = FlatStyle.Flat;
            buttonSupprimer.Font = new Font("Segoe UI", 11F);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(378, 455);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(190, 45);
            buttonSupprimer.TabIndex = 30;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(771, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 64;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // RappelDocumentsEnAttente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(823, 509);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonSupprimer);
            Controls.Add(btnRappeler);
            Controls.Add(dataGridView1);
            Controls.Add(checkBoxAfficherTicketsToutesLesCaisses);
            Name = "RappelDocumentsEnAttente";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Rappel des documents mis en attente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxAfficherTicketsToutesLesCaisses;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Statut;
        private Button btnRappeler;
        private Button buttonSupprimer;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}