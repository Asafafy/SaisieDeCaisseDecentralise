using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres.ParametresSociete
{
    partial class ParametresGammes
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            btnNouvelleGamme = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            txtBxNomDuServeur = new TextBox();
            lblIntitule = new Label();
            btnSupprimer = new Button();
            btnEnregistrer = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(33, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 319);
            listBox1.TabIndex = 23;
            listBox1.DrawItem += listBox1_DrawItem;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBox2.DrawMode = DrawMode.OwnerDrawFixed;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 35;
            listBox2.Location = new Point(429, 34);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(300, 319);
            listBox2.TabIndex = 24;
            listBox2.DrawItem += listBox2_DrawItem;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(129, 166, 181);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(539, 365);
            button1.Margin = new Padding(144, 3, 144, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 0, 0, 0);
            button1.Size = new Size(190, 45);
            button1.TabIndex = 26;
            button1.Text = "Nouvelle énumération";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnNouvelleGamme
            // 
            btnNouvelleGamme.BackColor = Color.FromArgb(129, 166, 181);
            btnNouvelleGamme.Cursor = Cursors.Hand;
            btnNouvelleGamme.FlatAppearance.BorderSize = 0;
            btnNouvelleGamme.FlatStyle = FlatStyle.Flat;
            btnNouvelleGamme.Font = new Font("Segoe UI", 11F);
            btnNouvelleGamme.ForeColor = Color.White;
            btnNouvelleGamme.Location = new Point(143, 365);
            btnNouvelleGamme.Margin = new Padding(144, 3, 144, 3);
            btnNouvelleGamme.Name = "btnNouvelleGamme";
            btnNouvelleGamme.Padding = new Padding(8, 0, 0, 0);
            btnNouvelleGamme.Size = new Size(190, 45);
            btnNouvelleGamme.TabIndex = 27;
            btnNouvelleGamme.Text = "Nouvelle gamme";
            btnNouvelleGamme.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(lblIntitule, 0, 0);
            tableLayoutPanel1.Location = new Point(33, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(696, 40);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxNomDuServeur);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(177, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(516, 34);
            panel2.TabIndex = 20;
            // 
            // txtBxNomDuServeur
            // 
            txtBxNomDuServeur.BorderStyle = BorderStyle.None;
            txtBxNomDuServeur.Dock = DockStyle.Fill;
            txtBxNomDuServeur.Location = new Point(20, 9);
            txtBxNomDuServeur.Name = "txtBxNomDuServeur";
            //txtBxNomDuServeur.PlaceholderText = "Intitulé de la gamme ou énuméré de la gamme";
            txtBxNomDuServeur.Size = new Size(474, 16);
            txtBxNomDuServeur.TabIndex = 0;
            // 
            // lblIntitule
            // 
            lblIntitule.AutoSize = true;
            lblIntitule.Dock = DockStyle.Fill;
            lblIntitule.Location = new Point(3, 0);
            lblIntitule.Name = "lblIntitule";
            lblIntitule.Size = new Size(168, 40);
            lblIntitule.TabIndex = 0;
            lblIntitule.Text = "Intitulé";
            lblIntitule.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSupprimer.BackColor = Color.FromArgb(84, 138, 178);
            btnSupprimer.Cursor = Cursors.Hand;
            btnSupprimer.FlatAppearance.BorderSize = 0;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Segoe UI", 11F);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(539, 84);
            btnSupprimer.Margin = new Padding(144, 3, 144, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Padding = new Padding(8, 0, 0, 0);
            btnSupprimer.Size = new Size(190, 45);
            btnSupprimer.TabIndex = 29;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.FromArgb(84, 138, 178);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(333, 84);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 30;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(btnNouvelleGamme);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(50, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 466);
            panel1.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnEnregistrer);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(btnSupprimer);
            panel3.Location = new Point(50, 579);
            panel3.Name = "panel3";
            panel3.Size = new Size(769, 156);
            panel3.TabIndex = 32;
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
            iconButtonFermer.Location = new Point(824, 8);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 43;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ParametresGammes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(875, 758);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ParametresGammes";
            ShowIcon = false;
            ShowInTaskbar = false;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button btnNouvelleGamme;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblIntitule;
        private Panel panel2;
        private TextBox txtBxNomDuServeur;
        private Button btnSupprimer;
        private Button btnEnregistrer;
        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}