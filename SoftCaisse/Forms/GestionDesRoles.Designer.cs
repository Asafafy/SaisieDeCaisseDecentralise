namespace SoftCaisse.Forms
{
    partial class GestionDesRoles
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Paramètre de base");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Paramètres de société");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Utilisateurs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gestion des rôles");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Autorisation d\'accès", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mise en page");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Fichier", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Article");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Caisses");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Clients");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Collaborateurs");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Famille");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Structure", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ouverture de caisse");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ventes comptoir");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Documents de ventes");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Mouvements de caisse");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Fermeture de caisse");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Gestion des règlements");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Gestion des comptes");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Contrôle de caisse");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Clôture de caisse");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Traitement", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Statistiques de caisses");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Statistiques des articles");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Statistiques des clients");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Journaux de vente");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Inventaire");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Etat", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDesRoles));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFermer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNouveau = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnModif = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSupp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblAuth = new System.Windows.Forms.Label();
            this.chckBxAuth = new System.Windows.Forms.CheckBox();
            this.txBxIntRole = new System.Windows.Forms.TextBox();
            this.lblIntRole = new System.Windows.Forms.Label();
            this.OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des profils utilisateurs existants, associés à différents rôles.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vous pouvez également en créer de nouveaux.";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(1203, 639);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Palette = this.kryptonPalette1;
            this.btnFermer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnFermer.Size = new System.Drawing.Size(100, 38);
            this.btnFermer.TabIndex = 43;
            this.btnFermer.Values.Text = "Fermer";
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(349, 117);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Palette = this.kryptonPalette1;
            this.btnNouveau.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnNouveau.Size = new System.Drawing.Size(100, 38);
            this.btnNouveau.TabIndex = 45;
            this.btnNouveau.Values.Text = "Nouveau";
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(349, 162);
            this.btnModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Palette = this.kryptonPalette1;
            this.btnModif.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnModif.Size = new System.Drawing.Size(100, 38);
            this.btnModif.TabIndex = 46;
            this.btnModif.Values.Text = "Modifier";
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(349, 208);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Palette = this.kryptonPalette1;
            this.btnSupp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSupp.Size = new System.Drawing.Size(100, 38);
            this.btnSupp.TabIndex = 47;
            this.btnSupp.Values.Text = "Supprimer";
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(17, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(313, 484);
            this.dataGridView1.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.lblAuth);
            this.groupBox1.Controls.Add(this.chckBxAuth);
            this.groupBox1.Controls.Add(this.txBxIntRole);
            this.groupBox1.Controls.Add(this.lblIntRole);
            this.groupBox1.Controls.Add(this.OK);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(495, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 12, 13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(809, 613);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(701, 521);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Palette = this.kryptonPalette1;
            this.btnAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAnnuler.Size = new System.Drawing.Size(100, 38);
            this.btnAnnuler.TabIndex = 56;
            this.btnAnnuler.Values.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(545, 116);
            this.lblAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(84, 16);
            this.lblAuth.TabIndex = 55;
            this.lblAuth.Text = "Autorisations";
            this.lblAuth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chckBxAuth
            // 
            this.chckBxAuth.AutoSize = true;
            this.chckBxAuth.Location = new System.Drawing.Point(549, 142);
            this.chckBxAuth.Margin = new System.Windows.Forms.Padding(4);
            this.chckBxAuth.Name = "chckBxAuth";
            this.chckBxAuth.Size = new System.Drawing.Size(128, 20);
            this.chckBxAuth.TabIndex = 53;
            this.chckBxAuth.Text = "Autoriser l\'accès";
            this.chckBxAuth.UseVisualStyleBackColor = true;
            this.chckBxAuth.Click += new System.EventHandler(this.chckBxAuth_Click);
            // 
            // txBxIntRole
            // 
            this.txBxIntRole.Location = new System.Drawing.Point(545, 48);
            this.txBxIntRole.Margin = new System.Windows.Forms.Padding(4);
            this.txBxIntRole.Name = "txBxIntRole";
            this.txBxIntRole.Size = new System.Drawing.Size(235, 22);
            this.txBxIntRole.TabIndex = 52;
            // 
            // lblIntRole
            // 
            this.lblIntRole.AutoSize = true;
            this.lblIntRole.Location = new System.Drawing.Point(545, 23);
            this.lblIntRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntRole.Name = "lblIntRole";
            this.lblIntRole.Size = new System.Drawing.Size(88, 16);
            this.lblIntRole.TabIndex = 0;
            this.lblIntRole.Text = "Intitule du rôle";
            this.lblIntRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(701, 565);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK.Name = "OK";
            this.OK.Palette = this.kryptonPalette1;
            this.OK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.OK.Size = new System.Drawing.Size(100, 38);
            this.OK.TabIndex = 48;
            this.OK.Values.Text = "OK";
            this.OK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 22);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "1";
            treeNode1.Text = "Paramètre de base";
            treeNode2.Name = "2";
            treeNode2.Text = "Paramètres de société";
            treeNode3.Name = "4";
            treeNode3.Text = "Utilisateurs";
            treeNode4.Name = "5";
            treeNode4.Text = "Gestion des rôles";
            treeNode5.Name = "3";
            treeNode5.Text = "Autorisation d\'accès";
            treeNode6.Name = "6";
            treeNode6.Text = "Mise en page";
            treeNode7.Name = "0";
            treeNode7.Text = "Fichier";
            treeNode8.Name = "8";
            treeNode8.Text = "Article";
            treeNode9.Name = "9";
            treeNode9.Text = "Caisses";
            treeNode10.Name = "10";
            treeNode10.Text = "Clients";
            treeNode11.Name = "11";
            treeNode11.Text = "Collaborateurs";
            treeNode12.Name = "12";
            treeNode12.Text = "Famille";
            treeNode13.Name = "7";
            treeNode13.Text = "Structure";
            treeNode14.Name = "14";
            treeNode14.Text = "Ouverture de caisse";
            treeNode15.Name = "15";
            treeNode15.Text = "Ventes comptoir";
            treeNode16.Name = "16";
            treeNode16.Text = "Documents de ventes";
            treeNode17.Name = "17";
            treeNode17.Text = "Mouvements de caisse";
            treeNode18.Name = "18";
            treeNode18.Text = "Fermeture de caisse";
            treeNode19.Name = "19";
            treeNode19.Text = "Gestion des règlements";
            treeNode20.Name = "20";
            treeNode20.Text = "Gestion des comptes";
            treeNode21.Name = "21";
            treeNode21.Text = "Contrôle de caisse";
            treeNode22.Name = "22";
            treeNode22.Text = "Clôture de caisse";
            treeNode23.Name = "13";
            treeNode23.Text = "Traitement";
            treeNode24.Name = "24";
            treeNode24.Text = "Statistiques de caisses";
            treeNode25.Name = "25";
            treeNode25.Text = "Statistiques des articles";
            treeNode26.Name = "26";
            treeNode26.Text = "Statistiques des clients";
            treeNode27.Name = "27";
            treeNode27.Text = "Journaux de vente";
            treeNode28.Name = "28";
            treeNode28.Text = "Inventaire";
            treeNode29.Name = "23";
            treeNode29.Text = "Etat";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode13,
            treeNode23,
            treeNode29});
            this.treeView1.Size = new System.Drawing.Size(499, 578);
            this.treeView1.TabIndex = 51;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSupp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnModif);
            this.groupBox2.Controls.Add(this.btnNouveau);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(13, 12, 7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(468, 613);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(15, 634);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1280, 1);
            this.panel5.TabIndex = 52;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1317, 636);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 690);
            this.panel1.TabIndex = 52;
            // 
            // GestionDesRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1317, 690);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionDesRoles";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Gestion des rôles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFermer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNouveau;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnModif;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSupp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIntRole;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txBxIntRole;
        private System.Windows.Forms.CheckBox chckBxAuth;
        private System.Windows.Forms.Label lblAuth;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAnnuler;
    }
}