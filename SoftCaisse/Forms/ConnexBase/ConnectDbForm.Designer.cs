namespace SoftCaisse.Forms.ConnexBase
{
    partial class ConnectDbForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectDbForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtServBD = new System.Windows.Forms.TextBox();
            this.txtPwdBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSqlUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.DbListCmbx = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.commerciale = new System.Windows.Forms.TextBox();
            this.btnOpenSageFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comptabilite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mot_de_passe = new System.Windows.Forms.TextBox();
            this.Utilisateur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSagePath = new System.Windows.Forms.TextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnConBD = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSaveConfigBd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.ListDatabase = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de données Application";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.55914F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.44086F));
            this.tableLayoutPanel1.Controls.Add(this.txtServBD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPwdBD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSqlUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 80);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtServBD
            // 
            this.txtServBD.Location = new System.Drawing.Point(206, 2);
            this.txtServBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServBD.Name = "txtServBD";
            this.txtServBD.Size = new System.Drawing.Size(348, 22);
            this.txtServBD.TabIndex = 6;
            // 
            // txtPwdBD
            // 
            this.txtPwdBD.Location = new System.Drawing.Point(206, 54);
            this.txtPwdBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwdBD.Name = "txtPwdBD";
            this.txtPwdBD.Size = new System.Drawing.Size(348, 22);
            this.txtPwdBD.TabIndex = 5;
            this.txtPwdBD.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mot de passe";
            // 
            // txtSqlUser
            // 
            this.txtSqlUser.Location = new System.Drawing.Point(206, 28);
            this.txtSqlUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSqlUser.Name = "txtSqlUser";
            this.txtSqlUser.Size = new System.Drawing.Size(348, 22);
            this.txtSqlUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utilisateur SQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serveur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(571, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Séléctionner la base de données";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.73835F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.26165F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DbListCmbx, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListDatabase, 1, 1);
            this.tableLayoutPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 118);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = " Base de donnée Sage";
            // 
            // DbListCmbx
            // 
            this.DbListCmbx.Enabled = false;
            this.DbListCmbx.FormattingEnabled = true;
            this.DbListCmbx.Location = new System.Drawing.Point(207, 2);
            this.DbListCmbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbListCmbx.Name = "DbListCmbx";
            this.DbListCmbx.Size = new System.Drawing.Size(347, 24);
            this.DbListCmbx.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.commerciale);
            this.groupBox3.Controls.Add(this.btnOpenSageFile);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comptabilite);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Mot_de_passe);
            this.groupBox3.Controls.Add(this.Utilisateur);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(571, 179);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Séléctionner le fichier de donnée sage";
            // 
            // commerciale
            // 
            this.commerciale.Location = new System.Drawing.Point(208, 27);
            this.commerciale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commerciale.Name = "commerciale";
            this.commerciale.Size = new System.Drawing.Size(294, 22);
            this.commerciale.TabIndex = 13;
            // 
            // btnOpenSageFile
            // 
            this.btnOpenSageFile.Location = new System.Drawing.Point(508, 26);
            this.btnOpenSageFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenSageFile.Name = "btnOpenSageFile";
            this.btnOpenSageFile.Size = new System.Drawing.Size(41, 25);
            this.btnOpenSageFile.TabIndex = 12;
            this.btnOpenSageFile.Text = "...";
            this.btnOpenSageFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenSageFile.UseVisualStyleBackColor = true;
            this.btnOpenSageFile.Click += new System.EventHandler(this.btnOpenSageGestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sage 100 Commerciale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sage 100 Comptabilité";
            // 
            // comptabilite
            // 
            this.comptabilite.Location = new System.Drawing.Point(208, 67);
            this.comptabilite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comptabilite.Name = "comptabilite";
            this.comptabilite.Size = new System.Drawing.Size(294, 22);
            this.comptabilite.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOpenSageCompta_Click);
            // 
            // Mot_de_passe
            // 
            this.Mot_de_passe.Location = new System.Drawing.Point(208, 139);
            this.Mot_de_passe.Name = "Mot_de_passe";
            this.Mot_de_passe.Size = new System.Drawing.Size(256, 22);
            this.Mot_de_passe.TabIndex = 7;
            // 
            // Utilisateur
            // 
            this.Utilisateur.Location = new System.Drawing.Point(208, 104);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(256, 22);
            this.Utilisateur.TabIndex = 6;
            this.Utilisateur.Text = "<Administrateur>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Utilisateur";
            // 
            // txtBoxSagePath
            // 
            this.txtBoxSagePath.Location = new System.Drawing.Point(203, 2);
            this.txtBoxSagePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSagePath.Name = "txtBoxSagePath";
            this.txtBoxSagePath.Size = new System.Drawing.Size(294, 22);
            this.txtBoxSagePath.TabIndex = 6;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // btnConBD
            // 
            this.btnConBD.Location = new System.Drawing.Point(456, 144);
            this.btnConBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConBD.Name = "btnConBD";
            this.btnConBD.Palette = this.kryptonPalette1;
            this.btnConBD.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnConBD.Size = new System.Drawing.Size(117, 33);
            this.btnConBD.TabIndex = 7;
            this.btnConBD.Values.Text = "Connecter";
            this.btnConBD.Click += new System.EventHandler(this.btnConBD_Click);
            // 
            // btnSaveConfigBd
            // 
            this.btnSaveConfigBd.Location = new System.Drawing.Point(456, 529);
            this.btnSaveConfigBd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveConfigBd.Name = "btnSaveConfigBd";
            this.btnSaveConfigBd.Palette = this.kryptonPalette1;
            this.btnSaveConfigBd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSaveConfigBd.Size = new System.Drawing.Size(117, 33);
            this.btnSaveConfigBd.TabIndex = 8;
            this.btnSaveConfigBd.Values.Text = "Sauvegarder";
            this.btnSaveConfigBd.Click += new System.EventHandler(this.btnSaveConfigBd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogBaseSage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = " Base de donnée SoftCaisse";
            // 
            // ListDatabase
            // 
            this.ListDatabase.Enabled = false;
            this.ListDatabase.FormattingEnabled = true;
            this.ListDatabase.Location = new System.Drawing.Point(207, 59);
            this.ListDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListDatabase.Name = "ListDatabase";
            this.ListDatabase.Size = new System.Drawing.Size(347, 24);
            this.ListDatabase.TabIndex = 3;
            // 
            // ConnectDbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 580);
            this.Controls.Add(this.btnSaveConfigBd);
            this.Controls.Add(this.btnConBD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ConnectDbForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres bases de données";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPwdBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSqlUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxSagePath;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConBD;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveConfigBd;
        private System.Windows.Forms.TextBox txtServBD;
        private System.Windows.Forms.ComboBox DbListCmbx;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Mot_de_passe;
        private System.Windows.Forms.TextBox Utilisateur;
        private System.Windows.Forms.TextBox comptabilite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox commerciale;
        private System.Windows.Forms.Button btnOpenSageFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ListDatabase;
    }
}