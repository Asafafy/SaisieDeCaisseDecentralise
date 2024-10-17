namespace SoftCaisse.Forms.User
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModifUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAnnuler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuppr = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleCmbx = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkBoxEstActif = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.btnReinitialiserMdp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBoxInformations = new System.Windows.Forms.GroupBox();
            this.btnClean = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxInformations.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(462, 5);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Palette = this.kryptonPalette1;
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton2.Size = new System.Drawing.Size(67, 27);
            this.kryptonButton2.TabIndex = 11;
            this.kryptonButton2.Values.Text = "Fermer";
            this.kryptonButton2.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(442, 29);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Palette = this.kryptonPalette1;
            this.btnAddUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAddUser.Size = new System.Drawing.Size(71, 27);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Values.Text = "Nouveau";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnModifUser
            // 
            this.btnModifUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifUser.Location = new System.Drawing.Point(442, 62);
            this.btnModifUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifUser.Name = "btnModifUser";
            this.btnModifUser.Palette = this.kryptonPalette1;
            this.btnModifUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnModifUser.Size = new System.Drawing.Size(71, 27);
            this.btnModifUser.TabIndex = 12;
            this.btnModifUser.Values.Text = "Modifier";
            this.btnModifUser.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(341, 11);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Palette = this.kryptonPalette1;
            this.btnAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAnnuler.Size = new System.Drawing.Size(71, 27);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Values.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuppr);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.btnModifUser);
            this.groupBox1.Location = new System.Drawing.Point(11, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(11, 11, 11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(524, 300);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des utilisateurs";
            // 
            // btnSuppr
            // 
            this.btnSuppr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppr.Location = new System.Drawing.Point(442, 94);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Palette = this.kryptonPalette1;
            this.btnSuppr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSuppr.Size = new System.Drawing.Size(71, 27);
            this.btnSuppr.TabIndex = 15;
            this.btnSuppr.Values.Text = "Supprimer";
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(14, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(414, 259);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.37765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.62235F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RoleCmbx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 138);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label3.Size = new System.Drawing.Size(71, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mot de passe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(70, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(29, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rôle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(33, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoleCmbx
            // 
            this.RoleCmbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleCmbx.FormattingEnabled = true;
            this.RoleCmbx.Location = new System.Drawing.Point(103, 35);
            this.RoleCmbx.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.RoleCmbx.Name = "RoleCmbx";
            this.RoleCmbx.Size = new System.Drawing.Size(417, 21);
            this.RoleCmbx.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogin.Location = new System.Drawing.Point(103, 5);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(417, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonButton3);
            this.panel1.Controls.Add(this.checkBoxEstActif);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(101, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 45);
            this.panel1.TabIndex = 11;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton3.Location = new System.Drawing.Point(265, 11);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Palette = this.kryptonPalette1;
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton3.Size = new System.Drawing.Size(71, 27);
            this.kryptonButton3.TabIndex = 14;
            this.kryptonButton3.Values.Text = "OK";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // checkBoxEstActif
            // 
            this.checkBoxEstActif.AutoSize = true;
            this.checkBoxEstActif.Location = new System.Drawing.Point(4, 4);
            this.checkBoxEstActif.Name = "checkBoxEstActif";
            this.checkBoxEstActif.Size = new System.Drawing.Size(130, 17);
            this.checkBoxEstActif.TabIndex = 10;
            this.checkBoxEstActif.Text = "Désactiver ce compte";
            this.checkBoxEstActif.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.txtUserPassword);
            this.flowLayoutPanel2.Controls.Add(this.btnReinitialiserMdp);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(101, 60);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(421, 33);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserPassword.Location = new System.Drawing.Point(2, 8);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(2, 7, 2, 2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(269, 20);
            this.txtUserPassword.TabIndex = 6;
            // 
            // btnReinitialiserMdp
            // 
            this.btnReinitialiserMdp.Location = new System.Drawing.Point(275, 2);
            this.btnReinitialiserMdp.Margin = new System.Windows.Forms.Padding(2);
            this.btnReinitialiserMdp.Name = "btnReinitialiserMdp";
            this.btnReinitialiserMdp.Palette = this.kryptonPalette1;
            this.btnReinitialiserMdp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnReinitialiserMdp.Size = new System.Drawing.Size(137, 27);
            this.btnReinitialiserMdp.TabIndex = 15;
            this.btnReinitialiserMdp.Values.Text = "Réinitialiser mot de passe";
            this.btnReinitialiserMdp.Click += new System.EventHandler(this.btnReinitialiserMdp_Click);
            // 
            // groupBoxInformations
            // 
            this.groupBoxInformations.Controls.Add(this.btnClean);
            this.groupBoxInformations.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxInformations.Location = new System.Drawing.Point(11, 11);
            this.groupBoxInformations.Margin = new System.Windows.Forms.Padding(11);
            this.groupBoxInformations.Name = "groupBoxInformations";
            this.groupBoxInformations.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInformations.Size = new System.Drawing.Size(526, 157);
            this.groupBoxInformations.TabIndex = 16;
            this.groupBoxInformations.TabStop = false;
            this.groupBoxInformations.Text = "Informations";
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(603, 178);
            this.btnClean.Name = "btnClean";
            this.btnClean.Palette = this.kryptonPalette1;
            this.btnClean.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnClean.Size = new System.Drawing.Size(95, 33);
            this.btnClean.TabIndex = 16;
            this.btnClean.Values.Text = "Effacer";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxInformations);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 533);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonButton2);
            this.panel2.Location = new System.Drawing.Point(3, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 43);
            this.panel2.TabIndex = 17;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(548, 533);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagementForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion d\'utilisateur";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBoxInformations.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModifUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAnnuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox RoleCmbx;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.GroupBox groupBoxInformations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClean;
        private System.Windows.Forms.CheckBox checkBoxEstActif;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSuppr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReinitialiserMdp;
    }
}