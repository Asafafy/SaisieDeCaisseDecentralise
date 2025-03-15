using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.GestionDesRolesChildForm
{
    partial class CreateUpdateRoles
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
            panel2 = new Panel();
            txtBxNomDuServeur = new TextBox();
            lblIntitule = new Label();
            btnAnnuler = new Button();
            btnEnregistrer = new Button();
            dataGridView1 = new DataGridView();
            Autorise = new DataGridViewCheckBoxColumn();
            Rubrique = new DataGridViewTextBoxColumn();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblIntitule, 0, 0);
            tableLayoutPanel1.Location = new Point(27, 694);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(361, 79);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxNomDuServeur);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 43);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(355, 34);
            panel2.TabIndex = 20;
            // 
            // txtBxNomDuServeur
            // 
            txtBxNomDuServeur.BorderStyle = BorderStyle.None;
            txtBxNomDuServeur.Dock = DockStyle.Fill;
            txtBxNomDuServeur.Location = new Point(20, 9);
            txtBxNomDuServeur.Name = "txtBxNomDuServeur";
            txtBxNomDuServeur.Size = new Size(313, 16);
            txtBxNomDuServeur.TabIndex = 0;
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Dock = DockStyle.Fill;
            lblIntitule.Location = new Point(3, 0);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(355, 40);
            lblIntitule.TabIndex = 0;
            lblIntitule.Text = "Intitulé du rôle";
            lblIntitule.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnuler.BackColor = Color.FromArgb(129, 166, 181);
            btnAnnuler.Cursor = Cursors.Hand;
            btnAnnuler.FlatAppearance.BorderSize = 0;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI", 11F);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(510, 694);
            btnAnnuler.Margin = new Padding(144, 3, 144, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Padding = new Padding(8, 0, 0, 0);
            btnAnnuler.Size = new Size(190, 45);
            btnAnnuler.TabIndex = 31;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(510, 747);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 30;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Autorise, Rubrique });
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
            dataGridView1.Location = new Point(27, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(673, 596);
            dataGridView1.TabIndex = 33;
            // 
            // Autorise
            // 
            Autorise.FillWeight = 76.1421356F;
            Autorise.HeaderText = "Autorisé";
            Autorise.Name = "Autorise";
            Autorise.Resizable = DataGridViewTriState.True;
            Autorise.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Rubrique
            // 
            Rubrique.FillWeight = 123.857864F;
            Rubrique.HeaderText = "Rubrique";
            Rubrique.Name = "Rubrique";
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
            iconButtonFermer.Location = new Point(717, 12);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 35;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateUpdateRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(769, 815);
            Controls.Add(iconButtonFermer);
            Controls.Add(dataGridView1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnEnregistrer);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateUpdateRoles";
            ShowIcon = false;
            ShowInTaskbar = false;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TextBox txtBxNomDuServeur;
        private Label lblIntitule;
        private Button btnAnnuler;
        private Button btnEnregistrer;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Autorise;
        private DataGridViewTextBoxColumn Rubrique;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}