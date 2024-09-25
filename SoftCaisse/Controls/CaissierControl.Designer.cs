namespace SoftCaisse.Controls
{
    partial class CaissierControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaissierDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.CA_Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNouveauCaissier = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSupprCaissier = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCaissierClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaissierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CaissierDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(587, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caissiers";
            // 
            // CaissierDataGridView
            // 
            this.CaissierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CaissierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaissierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CA_Intitule,
            this.CANo});
            this.CaissierDataGridView.Location = new System.Drawing.Point(16, 24);
            this.CaissierDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CaissierDataGridView.Name = "CaissierDataGridView";
            this.CaissierDataGridView.RowHeadersVisible = false;
            this.CaissierDataGridView.RowHeadersWidth = 51;
            this.CaissierDataGridView.RowTemplate.Height = 24;
            this.CaissierDataGridView.Size = new System.Drawing.Size(557, 280);
            this.CaissierDataGridView.TabIndex = 0;
            this.CaissierDataGridView.DoubleClick += new System.EventHandler(this.CaissierDataGridView_DoubleClick);
            // 
            // CA_Intitule
            // 
            this.CA_Intitule.DataPropertyName = "Intitule";
            this.CA_Intitule.HeaderText = "Intitulé";
            this.CA_Intitule.MinimumWidth = 6;
            this.CA_Intitule.Name = "CA_Intitule";
            // 
            // CANo
            // 
            this.CANo.DataPropertyName = "CaisseNum";
            this.CANo.HeaderText = "CaisseNum";
            this.CANo.MinimumWidth = 6;
            this.CANo.Name = "CANo";
            this.CANo.Visible = false;
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
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(242, 336);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(79, 28);
            this.kryptonButton1.TabIndex = 18;
            this.kryptonButton1.Values.Text = "Ouvrir";
            this.kryptonButton1.Click += new System.EventHandler(this.CaissierDataGridView_DoubleClick);
            // 
            // btnNouveauCaissier
            // 
            this.btnNouveauCaissier.Location = new System.Drawing.Point(326, 336);
            this.btnNouveauCaissier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveauCaissier.Name = "btnNouveauCaissier";
            this.btnNouveauCaissier.Palette = this.kryptonPalette1;
            this.btnNouveauCaissier.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnNouveauCaissier.Size = new System.Drawing.Size(79, 28);
            this.btnNouveauCaissier.TabIndex = 19;
            this.btnNouveauCaissier.Values.Text = "Nouveau";
            this.btnNouveauCaissier.Click += new System.EventHandler(this.btnNouveauCaissier_Click);
            // 
            // btnSupprCaissier
            // 
            this.btnSupprCaissier.Location = new System.Drawing.Point(409, 336);
            this.btnSupprCaissier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprCaissier.Name = "btnSupprCaissier";
            this.btnSupprCaissier.Palette = this.kryptonPalette1;
            this.btnSupprCaissier.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSupprCaissier.Size = new System.Drawing.Size(79, 28);
            this.btnSupprCaissier.TabIndex = 20;
            this.btnSupprCaissier.Values.Text = "Supprimer";
            this.btnSupprCaissier.Click += new System.EventHandler(this.btnSupprCaissier_Click);
            // 
            // btnCaissierClose
            // 
            this.btnCaissierClose.Location = new System.Drawing.Point(492, 336);
            this.btnCaissierClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaissierClose.Name = "btnCaissierClose";
            this.btnCaissierClose.Palette = this.kryptonPalette1;
            this.btnCaissierClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnCaissierClose.Size = new System.Drawing.Size(79, 28);
            this.btnCaissierClose.TabIndex = 21;
            this.btnCaissierClose.Values.Text = "Fermer";
            this.btnCaissierClose.Click += new System.EventHandler(this.btnCaissierClose_Click);
            // 
            // CaissierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnCaissierClose);
            this.Controls.Add(this.btnSupprCaissier);
            this.Controls.Add(this.btnNouveauCaissier);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CaissierControl";
            this.Size = new System.Drawing.Size(598, 374);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CaissierDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView CaissierDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNouveauCaissier;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSupprCaissier;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCaissierClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA_Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANo;
    }
}
