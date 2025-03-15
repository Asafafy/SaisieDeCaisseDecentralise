using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Forms
{
    partial class SeConnecter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeConnecter));
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBxMotDePasse = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBxLogin = new System.Windows.Forms.TextBox();
            this.btnEye = new System.Windows.Forms.Button();
            this.panelConteneur = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelConteneur.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnSeConnecter.Image")));
            this.btnSeConnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeConnecter.Location = new System.Drawing.Point(128, 491);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(123, 3, 123, 3);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSeConnecter.Size = new System.Drawing.Size(268, 50);
            this.btnSeConnecter.TabIndex = 8;
            this.btnSeConnecter.Text = "         Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.pictureBox1.Size = new System.Drawing.Size(226, 161);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(20, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 5);
            this.panel1.TabIndex = 10;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(142, 274);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 19);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMotDePasse.ForeColor = System.Drawing.Color.White;
            this.lblMotDePasse.Location = new System.Drawing.Point(142, 353);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(92, 19);
            this.lblMotDePasse.TabIndex = 14;
            this.lblMotDePasse.Text = "Mot de passe";
            this.lblMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtBxMotDePasse);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(146, 381);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(17, 12, 17, 11);
            this.panel2.Size = new System.Drawing.Size(226, 40);
            this.panel2.TabIndex = 15;
            // 
            // txtBxMotDePasse
            // 
            this.txtBxMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxMotDePasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBxMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMotDePasse.Location = new System.Drawing.Point(17, 12);
            this.txtBxMotDePasse.Name = "txtBxMotDePasse";
            this.txtBxMotDePasse.Size = new System.Drawing.Size(192, 14);
            this.txtBxMotDePasse.TabIndex = 0;
            this.txtBxMotDePasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxMotDePasse_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtBxLogin);
            this.panel3.Location = new System.Drawing.Point(146, 302);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(17, 12, 17, 12);
            this.panel3.Size = new System.Drawing.Size(226, 40);
            this.panel3.TabIndex = 16;
            // 
            // txtBxLogin
            // 
            this.txtBxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLogin.Location = new System.Drawing.Point(17, 12);
            this.txtBxLogin.Name = "txtBxLogin";
            this.txtBxLogin.Size = new System.Drawing.Size(192, 14);
            this.txtBxLogin.TabIndex = 0;
            // 
            // btnEye
            // 
            this.btnEye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.Image = ((System.Drawing.Image)(resources.GetObject("btnEye.Image")));
            this.btnEye.Location = new System.Drawing.Point(378, 381);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(44, 40);
            this.btnEye.TabIndex = 50;
            this.btnEye.UseVisualStyleBackColor = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // panelConteneur
            // 
            this.panelConteneur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.panelConteneur.Controls.Add(this.pictureBox1);
            this.panelConteneur.Controls.Add(this.btnEye);
            this.panelConteneur.Controls.Add(this.btnSeConnecter);
            this.panelConteneur.Controls.Add(this.panel3);
            this.panelConteneur.Controls.Add(this.lblMotDePasse);
            this.panelConteneur.Controls.Add(this.panel2);
            this.panelConteneur.Controls.Add(this.labelLogin);
            this.panelConteneur.Controls.Add(this.panel1);
            this.panelConteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteneur.Location = new System.Drawing.Point(12, 12);
            this.panelConteneur.Name = "panelConteneur";
            this.panelConteneur.Size = new System.Drawing.Size(525, 591);
            this.panelConteneur.TabIndex = 0;
            // 
            // SeConnecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(549, 615);
            this.Controls.Add(this.panelConteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeConnecter";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeConnecter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelConteneur.ResumeLayout(false);
            this.panelConteneur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSeConnecter;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelLogin;
        private Label lblMotDePasse;
        private Panel panel2;
        private TextBox txtBxMotDePasse;
        private Panel panel3;
        private TextBox txtBxLogin;
        private Button btnEye;
        private Panel panelConteneur;
    }
}