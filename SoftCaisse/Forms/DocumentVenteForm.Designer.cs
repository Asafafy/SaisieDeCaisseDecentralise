namespace SoftCaisse.Forms.DocumentVente
{
    partial class DocumentVenteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentVenteForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonButtonSuppr = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kptBtnNouveau = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonRechercherArticle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TextBoxBarreDeRecherche = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnDocsEnCours = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.btnBonCommande = new System.Windows.Forms.Button();
            this.btnPrepLivr = new System.Windows.Forms.Button();
            this.btnBonLivr = new System.Windows.Forms.Button();
            this.btnBnRetour = new System.Windows.Forms.Button();
            this.btnBnAvrFinancier = new System.Windows.Forms.Button();
            this.btnFacture = new System.Windows.Forms.Button();
            this.btnFactCompt = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // kryptonButtonSuppr
            // 
            this.kryptonButtonSuppr.Location = new System.Drawing.Point(1186, 453);
            this.kryptonButtonSuppr.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButtonSuppr.Name = "kryptonButtonSuppr";
            this.kryptonButtonSuppr.Palette = this.kryptonPalette1;
            this.kryptonButtonSuppr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButtonSuppr.Size = new System.Drawing.Size(79, 28);
            this.kryptonButtonSuppr.TabIndex = 24;
            this.kryptonButtonSuppr.Values.Text = "Supprimer";
            this.kryptonButtonSuppr.Click += new System.EventHandler(this.kryptonButtonSuppr_Click);
            // 
            // kptBtnNouveau
            // 
            this.kptBtnNouveau.Location = new System.Drawing.Point(1093, 453);
            this.kptBtnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.kptBtnNouveau.Name = "kptBtnNouveau";
            this.kptBtnNouveau.Palette = this.kryptonPalette1;
            this.kptBtnNouveau.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kptBtnNouveau.Size = new System.Drawing.Size(79, 28);
            this.kptBtnNouveau.TabIndex = 23;
            this.kptBtnNouveau.Values.Text = "Nouveau";
            this.kptBtnNouveau.Click += new System.EventHandler(this.kptBtnNouveau_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1001, 453);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(79, 28);
            this.kryptonButton1.TabIndex = 22;
            this.kryptonButton1.Values.Text = "Ouvrir";
            // 
            // BouttonRechercherArticle
            // 
            this.BouttonRechercherArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonRechercherArticle.AutoSize = true;
            this.BouttonRechercherArticle.Location = new System.Drawing.Point(1177, -59);
            this.BouttonRechercherArticle.Margin = new System.Windows.Forms.Padding(2);
            this.BouttonRechercherArticle.Name = "BouttonRechercherArticle";
            this.BouttonRechercherArticle.Palette = this.kryptonPalette1;
            this.BouttonRechercherArticle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonRechercherArticle.Size = new System.Drawing.Size(84, 31);
            this.BouttonRechercherArticle.TabIndex = 30;
            this.BouttonRechercherArticle.Values.Text = "Rechercher";
            // 
            // TextBoxBarreDeRecherche
            // 
            this.TextBoxBarreDeRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBarreDeRecherche.Location = new System.Drawing.Point(565, 25);
            this.TextBoxBarreDeRecherche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxBarreDeRecherche.Name = "TextBoxBarreDeRecherche";
            this.TextBoxBarreDeRecherche.Size = new System.Drawing.Size(602, 23);
            this.TextBoxBarreDeRecherche.TabIndex = 29;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel10.Controls.Add(this.btnTous);
            this.flowLayoutPanel10.Controls.Add(this.btnDocsEnCours);
            this.flowLayoutPanel10.Controls.Add(this.btnDevis);
            this.flowLayoutPanel10.Controls.Add(this.btnBonCommande);
            this.flowLayoutPanel10.Controls.Add(this.btnPrepLivr);
            this.flowLayoutPanel10.Controls.Add(this.btnBonLivr);
            this.flowLayoutPanel10.Controls.Add(this.btnBnRetour);
            this.flowLayoutPanel10.Controls.Add(this.btnBnAvrFinancier);
            this.flowLayoutPanel10.Controls.Add(this.btnFacture);
            this.flowLayoutPanel10.Controls.Add(this.btnFactCompt);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(20, 76);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(185, 339);
            this.flowLayoutPanel10.TabIndex = 31;
            // 
            // btnTous
            // 
            this.btnTous.FlatAppearance.BorderSize = 0;
            this.btnTous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTous.Location = new System.Drawing.Point(0, 0);
            this.btnTous.Margin = new System.Windows.Forms.Padding(0);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(185, 27);
            this.btnTous.TabIndex = 9;
            this.btnTous.Text = "Tous les documents";
            this.btnTous.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTous.UseVisualStyleBackColor = true;
            this.btnTous.Click += new System.EventHandler(this.btnTous_Click);
            // 
            // btnDocsEnCours
            // 
            this.btnDocsEnCours.FlatAppearance.BorderSize = 0;
            this.btnDocsEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocsEnCours.Location = new System.Drawing.Point(0, 27);
            this.btnDocsEnCours.Margin = new System.Windows.Forms.Padding(0);
            this.btnDocsEnCours.Name = "btnDocsEnCours";
            this.btnDocsEnCours.Size = new System.Drawing.Size(185, 27);
            this.btnDocsEnCours.TabIndex = 0;
            this.btnDocsEnCours.Text = "Documents en cours";
            this.btnDocsEnCours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocsEnCours.UseVisualStyleBackColor = true;
            this.btnDocsEnCours.Click += new System.EventHandler(this.btnDocsEnCours_Click);
            // 
            // btnDevis
            // 
            this.btnDevis.FlatAppearance.BorderSize = 0;
            this.btnDevis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevis.Location = new System.Drawing.Point(0, 54);
            this.btnDevis.Margin = new System.Windows.Forms.Padding(0);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(185, 27);
            this.btnDevis.TabIndex = 1;
            this.btnDevis.Text = "Devis";
            this.btnDevis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevis.UseVisualStyleBackColor = true;
            this.btnDevis.Click += new System.EventHandler(this.btnDevis_Click);
            // 
            // btnBonCommande
            // 
            this.btnBonCommande.FlatAppearance.BorderSize = 0;
            this.btnBonCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBonCommande.Location = new System.Drawing.Point(0, 81);
            this.btnBonCommande.Margin = new System.Windows.Forms.Padding(0);
            this.btnBonCommande.Name = "btnBonCommande";
            this.btnBonCommande.Size = new System.Drawing.Size(185, 27);
            this.btnBonCommande.TabIndex = 2;
            this.btnBonCommande.Text = "Bon de commande";
            this.btnBonCommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBonCommande.UseVisualStyleBackColor = true;
            this.btnBonCommande.Click += new System.EventHandler(this.btnBonCommande_Click);
            // 
            // btnPrepLivr
            // 
            this.btnPrepLivr.FlatAppearance.BorderSize = 0;
            this.btnPrepLivr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepLivr.Location = new System.Drawing.Point(0, 108);
            this.btnPrepLivr.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrepLivr.Name = "btnPrepLivr";
            this.btnPrepLivr.Size = new System.Drawing.Size(185, 27);
            this.btnPrepLivr.TabIndex = 3;
            this.btnPrepLivr.Text = "Préparation de livraison";
            this.btnPrepLivr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrepLivr.UseVisualStyleBackColor = true;
            this.btnPrepLivr.Click += new System.EventHandler(this.btnPrepLivr_Click);
            // 
            // btnBonLivr
            // 
            this.btnBonLivr.FlatAppearance.BorderSize = 0;
            this.btnBonLivr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBonLivr.Location = new System.Drawing.Point(0, 135);
            this.btnBonLivr.Margin = new System.Windows.Forms.Padding(0);
            this.btnBonLivr.Name = "btnBonLivr";
            this.btnBonLivr.Size = new System.Drawing.Size(185, 27);
            this.btnBonLivr.TabIndex = 4;
            this.btnBonLivr.Text = "Bon de livraison";
            this.btnBonLivr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBonLivr.UseVisualStyleBackColor = true;
            this.btnBonLivr.Click += new System.EventHandler(this.btnBonLivr_Click);
            // 
            // btnBnRetour
            // 
            this.btnBnRetour.FlatAppearance.BorderSize = 0;
            this.btnBnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBnRetour.Location = new System.Drawing.Point(0, 162);
            this.btnBnRetour.Margin = new System.Windows.Forms.Padding(0);
            this.btnBnRetour.Name = "btnBnRetour";
            this.btnBnRetour.Size = new System.Drawing.Size(185, 27);
            this.btnBnRetour.TabIndex = 5;
            this.btnBnRetour.Text = "Bon de retour";
            this.btnBnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBnRetour.UseVisualStyleBackColor = true;
            this.btnBnRetour.Click += new System.EventHandler(this.btnBnRetour_Click);
            // 
            // btnBnAvrFinancier
            // 
            this.btnBnAvrFinancier.FlatAppearance.BorderSize = 0;
            this.btnBnAvrFinancier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBnAvrFinancier.Location = new System.Drawing.Point(0, 189);
            this.btnBnAvrFinancier.Margin = new System.Windows.Forms.Padding(0);
            this.btnBnAvrFinancier.Name = "btnBnAvrFinancier";
            this.btnBnAvrFinancier.Size = new System.Drawing.Size(185, 27);
            this.btnBnAvrFinancier.TabIndex = 6;
            this.btnBnAvrFinancier.Text = "Bon d\'avoir financier";
            this.btnBnAvrFinancier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBnAvrFinancier.UseVisualStyleBackColor = true;
            this.btnBnAvrFinancier.Click += new System.EventHandler(this.btnBnAvrFinancier_Click);
            // 
            // btnFacture
            // 
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Location = new System.Drawing.Point(0, 216);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(0);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(185, 27);
            this.btnFacture.TabIndex = 7;
            this.btnFacture.Text = "Facture";
            this.btnFacture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacture.UseVisualStyleBackColor = true;
            this.btnFacture.Click += new System.EventHandler(this.btnFacture_Click);
            // 
            // btnFactCompt
            // 
            this.btnFactCompt.FlatAppearance.BorderSize = 0;
            this.btnFactCompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactCompt.Location = new System.Drawing.Point(0, 243);
            this.btnFactCompt.Margin = new System.Windows.Forms.Padding(0);
            this.btnFactCompt.Name = "btnFactCompt";
            this.btnFactCompt.Size = new System.Drawing.Size(185, 27);
            this.btnFactCompt.TabIndex = 8;
            this.btnFactCompt.Text = "Facture comptabilisée";
            this.btnFactCompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactCompt.UseVisualStyleBackColor = true;
            this.btnFactCompt.Click += new System.EventHandler(this.btnFactCompt_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(21, 435);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1240, 1);
            this.panel5.TabIndex = 32;
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(1186, 21);
            this.kryptonButton4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Palette = this.kryptonPalette1;
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton4.Size = new System.Drawing.Size(79, 28);
            this.kryptonButton4.TabIndex = 33;
            this.kryptonButton4.Values.Text = "Rechercher";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(222, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 339);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DocumentVenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1281, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel10);
            this.Controls.Add(this.BouttonRechercherArticle);
            this.Controls.Add(this.TextBoxBarreDeRecherche);
            this.Controls.Add(this.kryptonButtonSuppr);
            this.Controls.Add(this.kptBtnNouveau);
            this.Controls.Add(this.kryptonButton1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocumentVenteForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents des ventes";
            this.flowLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonSuppr;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kptBtnNouveau;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BouttonRechercherArticle;
        private System.Windows.Forms.TextBox TextBoxBarreDeRecherche;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Button btnDocsEnCours;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Button btnBonCommande;
        private System.Windows.Forms.Button btnPrepLivr;
        private System.Windows.Forms.Button btnBonLivr;
        private System.Windows.Forms.Button btnBnRetour;
        private System.Windows.Forms.Button btnBnAvrFinancier;
        private System.Windows.Forms.Button btnFacture;
        private System.Windows.Forms.Button btnFactCompt;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}