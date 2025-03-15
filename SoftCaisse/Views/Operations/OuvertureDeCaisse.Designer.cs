using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Operations
{
    partial class OuvertureDeCaisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OuvertureDeCaisse));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            dateTimePickerCustom = new DateTimePicker();
            txtBxDateTime = new TextBox();
            panel4 = new Panel();
            txtBxUtilisateur = new TextBox();
            lblMotDePasse = new Label();
            lblUtilisateur = new Label();
            lblDate = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            txtBxMotDePasse = new TextBox();
            btnEye = new Button();
            btnReset = new Button();
            btnConnecter = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(25, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 3, 60, 3);
            groupBox1.Size = new Size(549, 155);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authentification au SGBD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(lblMotDePasse, 0, 3);
            tableLayoutPanel1.Controls.Add(lblUtilisateur, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(429, 133);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dateTimePickerCustom);
            panel3.Controls.Add(txtBxDateTime);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(153, 13);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(273, 34);
            panel3.TabIndex = 24;
            // 
            // dateTimePickerCustom
            // 
            dateTimePickerCustom.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerCustom.Location = new Point(17, 34);
            dateTimePickerCustom.Name = "dateTimePickerCustom";
            dateTimePickerCustom.Size = new Size(231, 23);
            dateTimePickerCustom.TabIndex = 25;
            dateTimePickerCustom.ValueChanged += dateTimePickerCustom_ValueChanged;
            // 
            // txtBxDateTime
            // 
            txtBxDateTime.BorderStyle = BorderStyle.None;
            txtBxDateTime.Dock = DockStyle.Fill;
            txtBxDateTime.Location = new Point(20, 9);
            txtBxDateTime.Name = "txtBxDateTime";
            txtBxDateTime.Size = new Size(231, 16);
            txtBxDateTime.TabIndex = 0;
            txtBxDateTime.Click += txtBxDateTime_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBxUtilisateur);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(153, 53);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(273, 34);
            panel4.TabIndex = 20;
            // 
            // txtBxUtilisateur
            // 
            txtBxUtilisateur.BorderStyle = BorderStyle.None;
            txtBxUtilisateur.Dock = DockStyle.Fill;
            txtBxUtilisateur.Location = new Point(20, 9);
            txtBxUtilisateur.Name = "txtBxUtilisateur";
            txtBxUtilisateur.Size = new Size(231, 16);
            txtBxUtilisateur.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Dock = DockStyle.Right;
            lblMotDePasse.Location = new Point(70, 90);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(77, 40);
            lblMotDePasse.TabIndex = 6;
            lblMotDePasse.Text = "Mot de passe";
            lblMotDePasse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Dock = DockStyle.Right;
            lblUtilisateur.Location = new Point(87, 50);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(60, 40);
            lblUtilisateur.TabIndex = 4;
            lblUtilisateur.Text = "Utilisateur";
            lblUtilisateur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Right;
            lblDate.Location = new Point(116, 10);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 40);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(btnEye);
            flowLayoutPanel1.Controls.Add(btnReset);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(150, 90);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(279, 40);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxMotDePasse);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(179, 34);
            panel5.TabIndex = 21;
            // 
            // txtBxMotDePasse
            // 
            txtBxMotDePasse.BorderStyle = BorderStyle.None;
            txtBxMotDePasse.Dock = DockStyle.Fill;
            txtBxMotDePasse.Location = new Point(20, 9);
            txtBxMotDePasse.Name = "txtBxMotDePasse";
            txtBxMotDePasse.Size = new Size(137, 16);
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
            btnEye.Location = new Point(188, 3);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(40, 34);
            btnEye.TabIndex = 23;
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
            btnReset.Location = new Point(234, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(40, 34);
            btnReset.TabIndex = 24;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
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
            btnConnecter.Location = new Point(389, 205);
            btnConnecter.Margin = new Padding(144, 3, 144, 3);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Padding = new Padding(8, 0, 0, 0);
            btnConnecter.Size = new Size(185, 45);
            btnConnecter.TabIndex = 24;
            btnConnecter.Text = "Connecter";
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
            iconButtonFermer.Location = new Point(577, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 71;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // OuvertureDeCaisse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(625, 263);
            Controls.Add(iconButtonFermer);
            Controls.Add(groupBox1);
            Controls.Add(btnConnecter);
            Name = "OuvertureDeCaisse";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += OuvertureDeCaisse_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnConnecter;
        private DateTimePicker dateTimePickerCustom;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TextBox txtBxDateTime;
        private Panel panel5;
        private TextBox txtBxMotDePasse;
        private Panel panel4;
        private TextBox txtBxUtilisateur;
        private Label lblMotDePasse;
        private Label lblUtilisateur;
        private Label lblDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnEye;
        private Button btnReset;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}