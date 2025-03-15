using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.GestionDesUtilisateursChildForm
{
    partial class CreateUpdateUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateUtilisateurs));
            groupBoxInformationsDuCompte = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            comboBoxRole = new ComboBox();
            panel2 = new Panel();
            txtBxNomDuServeur = new TextBox();
            lblMotDePasse = new Label();
            lblRole = new Label();
            lblLogin = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            txtBxMotDePasse = new TextBox();
            btnEye = new Button();
            btnReset = new Button();
            checkBoxDesactiverLeCompte = new CheckBox();
            btnConnecter = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBoxInformationsDuCompte.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInformationsDuCompte
            // 
            groupBoxInformationsDuCompte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInformationsDuCompte.Controls.Add(tableLayoutPanel1);
            groupBoxInformationsDuCompte.Location = new Point(21, 36);
            groupBoxInformationsDuCompte.Name = "groupBoxInformationsDuCompte";
            groupBoxInformationsDuCompte.Padding = new Padding(60, 3, 60, 3);
            groupBoxInformationsDuCompte.Size = new Size(554, 200);
            groupBoxInformationsDuCompte.TabIndex = 20;
            groupBoxInformationsDuCompte.TabStop = false;
            groupBoxInformationsDuCompte.Text = "Informations du compte";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblMotDePasse, 0, 3);
            tableLayoutPanel1.Controls.Add(lblRole, 0, 2);
            tableLayoutPanel1.Controls.Add(lblLogin, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBoxDesactiverLeCompte, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(434, 178);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(comboBoxRole);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(154, 63);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 5, 4, 0);
            panel4.Size = new Size(277, 34);
            panel4.TabIndex = 26;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Dock = DockStyle.Fill;
            comboBoxRole.FlatStyle = FlatStyle.Flat;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(20, 5);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(251, 23);
            comboBoxRole.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxNomDuServeur);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(154, 23);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(277, 34);
            panel2.TabIndex = 19;
            // 
            // txtBxNomDuServeur
            // 
            txtBxNomDuServeur.BorderStyle = BorderStyle.None;
            txtBxNomDuServeur.Dock = DockStyle.Fill;
            txtBxNomDuServeur.Location = new Point(20, 9);
            txtBxNomDuServeur.Name = "txtBxNomDuServeur";
            txtBxNomDuServeur.Size = new Size(235, 16);
            txtBxNomDuServeur.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Dock = DockStyle.Right;
            lblMotDePasse.Location = new Point(71, 100);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(77, 40);
            lblMotDePasse.TabIndex = 6;
            lblMotDePasse.Text = "Mot de passe";
            lblMotDePasse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Right;
            lblRole.Location = new Point(118, 60);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 40);
            lblRole.TabIndex = 4;
            lblRole.Text = "Rôle";
            lblRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Dock = DockStyle.Right;
            lblLogin.Location = new Point(111, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 40);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnEye);
            flowLayoutPanel1.Controls.Add(btnReset);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(151, 100);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 40);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxMotDePasse);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(181, 34);
            panel5.TabIndex = 21;
            // 
            // txtBxMotDePasse
            // 
            txtBxMotDePasse.BorderStyle = BorderStyle.None;
            txtBxMotDePasse.Dock = DockStyle.Fill;
            txtBxMotDePasse.Location = new Point(20, 9);
            txtBxMotDePasse.Name = "txtBxMotDePasse";
            txtBxMotDePasse.Size = new Size(139, 16);
            txtBxMotDePasse.TabIndex = 0;
            txtBxMotDePasse.KeyPress += txtBxMotDePasse_KeyPress;
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.FromArgb(29, 64, 102);
            btnEye.Cursor = Cursors.Hand;
            btnEye.FlatAppearance.BorderColor = Color.AliceBlue;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.Image = (Image)resources.GetObject("btnEye.Image");
            btnEye.Location = new Point(190, 3);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(40, 34);
            btnEye.TabIndex = 21;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(29, 64, 102);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(236, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 34);
            btnReset.TabIndex = 22;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // checkBoxDesactiverLeCompte
            // 
            checkBoxDesactiverLeCompte.AutoSize = true;
            checkBoxDesactiverLeCompte.Dock = DockStyle.Fill;
            checkBoxDesactiverLeCompte.Location = new Point(154, 143);
            checkBoxDesactiverLeCompte.Name = "checkBoxDesactiverLeCompte";
            checkBoxDesactiverLeCompte.Size = new Size(277, 34);
            checkBoxDesactiverLeCompte.TabIndex = 23;
            checkBoxDesactiverLeCompte.Text = "Désactiver ce compte";
            checkBoxDesactiverLeCompte.UseVisualStyleBackColor = true;
            // 
            // btnConnecter
            // 
            btnConnecter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConnecter.BackColor = Color.FromArgb(129, 166, 181);
            btnConnecter.Cursor = Cursors.Hand;
            btnConnecter.FlatAppearance.BorderSize = 0;
            btnConnecter.FlatStyle = FlatStyle.Flat;
            btnConnecter.Font = new Font("Segoe UI", 11F);
            btnConnecter.ForeColor = Color.White;
            btnConnecter.Location = new Point(385, 255);
            btnConnecter.Margin = new Padding(144, 3, 144, 3);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Padding = new Padding(8, 0, 0, 0);
            btnConnecter.Size = new Size(190, 45);
            btnConnecter.TabIndex = 21;
            btnConnecter.Text = "Enregistrer";
            btnConnecter.UseVisualStyleBackColor = false;
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
            iconButtonFermer.Location = new Point(575, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 36;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateUpdateUtilisateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(625, 314);
            Controls.Add(iconButtonFermer);
            Controls.Add(btnConnecter);
            Controls.Add(groupBoxInformationsDuCompte);
            Name = "CreateUpdateUtilisateurs";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBoxInformationsDuCompte.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxInformationsDuCompte;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TextBox txtBxMotDePasse;
        private Panel panel2;
        private TextBox txtBxNomDuServeur;
        private Label lblMotDePasse;
        private Label lblRole;
        private Label lblLogin;
        private Button btnEye;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxDesactiverLeCompte;
        private Button btnConnecter;
        private Button btnReset;
        private Panel panel4;
        private ComboBox comboBoxRole;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}