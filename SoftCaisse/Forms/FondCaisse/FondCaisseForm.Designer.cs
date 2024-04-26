namespace SoftCaisse.Forms.FondCaisse
{
    partial class FondCaisseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deviseCmbx = new System.Windows.Forms.ComboBox();
            this.btnValiderFondCaisse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.fondCaisseDatagridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMarq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCreateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbModification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbReplication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValeurSansQté = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDevise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFondCaisseClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.montantTotalLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondCaisseDatagridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deviseCmbx);
            this.panel1.Controls.Add(this.btnValiderFondCaisse);
            this.panel1.Controls.Add(this.fondCaisseDatagridView);
            this.panel1.Controls.Add(this.btnFondCaisseClose);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 531);
            this.panel1.TabIndex = 0;
            // 
            // deviseCmbx
            // 
            this.deviseCmbx.FormattingEnabled = true;
            this.deviseCmbx.Location = new System.Drawing.Point(70, 12);
            this.deviseCmbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deviseCmbx.Name = "deviseCmbx";
            this.deviseCmbx.Size = new System.Drawing.Size(112, 21);
            this.deviseCmbx.TabIndex = 13;
            this.deviseCmbx.SelectedIndexChanged += new System.EventHandler(this.deviseCmbx_SelectedIndexChanged_1);
            // 
            // btnValiderFondCaisse
            // 
            this.btnValiderFondCaisse.Enabled = false;
            this.btnValiderFondCaisse.Location = new System.Drawing.Point(303, 498);
            this.btnValiderFondCaisse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValiderFondCaisse.Name = "btnValiderFondCaisse";
            this.btnValiderFondCaisse.Palette = this.kryptonPalette1;
            this.btnValiderFondCaisse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnValiderFondCaisse.Size = new System.Drawing.Size(69, 28);
            this.btnValiderFondCaisse.TabIndex = 12;
            this.btnValiderFondCaisse.Values.Text = "OK";
            this.btnValiderFondCaisse.Click += new System.EventHandler(this.btnValiderFondCaisse_Click);
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
            // fondCaisseDatagridView
            // 
            this.fondCaisseDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fondCaisseDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fondCaisseDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intitule,
            this.cbProt,
            this.cbMarq,
            this.cbCreateur,
            this.cbModification,
            this.cbReplication,
            this.cbFlag,
            this.Quantite,
            this.ValeurSansQté,
            this.Valeur,
            this.NumDevise});
            this.fondCaisseDatagridView.Location = new System.Drawing.Point(16, 46);
            this.fondCaisseDatagridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fondCaisseDatagridView.Name = "fondCaisseDatagridView";
            this.fondCaisseDatagridView.RowHeadersVisible = false;
            this.fondCaisseDatagridView.RowHeadersWidth = 51;
            this.fondCaisseDatagridView.Size = new System.Drawing.Size(429, 387);
            this.fondCaisseDatagridView.TabIndex = 10;
            this.fondCaisseDatagridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.fondCaisseDatagridView_CellValueChanged);
            // 
            // Intitule
            // 
            this.Intitule.DataPropertyName = "BI_Intitule";
            this.Intitule.HeaderText = "Intitulé";
            this.Intitule.MinimumWidth = 6;
            this.Intitule.Name = "Intitule";
            this.Intitule.ReadOnly = true;
            // 
            // cbProt
            // 
            this.cbProt.DataPropertyName = "cbProt";
            this.cbProt.HeaderText = "cbProt";
            this.cbProt.MinimumWidth = 6;
            this.cbProt.Name = "cbProt";
            this.cbProt.Visible = false;
            // 
            // cbMarq
            // 
            this.cbMarq.DataPropertyName = "cbMarq";
            this.cbMarq.HeaderText = "cbMarq";
            this.cbMarq.MinimumWidth = 6;
            this.cbMarq.Name = "cbMarq";
            this.cbMarq.Visible = false;
            // 
            // cbCreateur
            // 
            this.cbCreateur.DataPropertyName = "cbCreateur";
            this.cbCreateur.HeaderText = "cbCreateur";
            this.cbCreateur.MinimumWidth = 6;
            this.cbCreateur.Name = "cbCreateur";
            this.cbCreateur.Visible = false;
            // 
            // cbModification
            // 
            this.cbModification.DataPropertyName = "cbModification";
            this.cbModification.HeaderText = "cbModification";
            this.cbModification.MinimumWidth = 6;
            this.cbModification.Name = "cbModification";
            this.cbModification.Visible = false;
            // 
            // cbReplication
            // 
            this.cbReplication.DataPropertyName = "cbReplication";
            this.cbReplication.HeaderText = "cbReplication";
            this.cbReplication.MinimumWidth = 6;
            this.cbReplication.Name = "cbReplication";
            this.cbReplication.Visible = false;
            // 
            // cbFlag
            // 
            this.cbFlag.DataPropertyName = "cbFlag";
            this.cbFlag.HeaderText = "cbFlag";
            this.cbFlag.MinimumWidth = 6;
            this.cbFlag.Name = "cbFlag";
            this.cbFlag.Visible = false;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.MinimumWidth = 6;
            this.Quantite.Name = "Quantite";
            // 
            // ValeurSansQté
            // 
            this.ValeurSansQté.DataPropertyName = "BI_Valeur";
            this.ValeurSansQté.HeaderText = "ValeurSansQté";
            this.ValeurSansQté.MinimumWidth = 6;
            this.ValeurSansQté.Name = "ValeurSansQté";
            this.ValeurSansQté.ReadOnly = true;
            this.ValeurSansQté.Visible = false;
            // 
            // Valeur
            // 
            this.Valeur.HeaderText = "Valeur";
            this.Valeur.MinimumWidth = 6;
            this.Valeur.Name = "Valeur";
            this.Valeur.ReadOnly = true;
            // 
            // NumDevise
            // 
            this.NumDevise.DataPropertyName = "N_Devise";
            this.NumDevise.HeaderText = "NumDevise";
            this.NumDevise.MinimumWidth = 6;
            this.NumDevise.Name = "NumDevise";
            this.NumDevise.Visible = false;
            // 
            // btnFondCaisseClose
            // 
            this.btnFondCaisseClose.Location = new System.Drawing.Point(376, 497);
            this.btnFondCaisseClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFondCaisseClose.Name = "btnFondCaisseClose";
            this.btnFondCaisseClose.Palette = this.kryptonPalette1;
            this.btnFondCaisseClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnFondCaisseClose.Size = new System.Drawing.Size(69, 28);
            this.btnFondCaisseClose.TabIndex = 9;
            this.btnFondCaisseClose.Values.Text = "Annuler";
            this.btnFondCaisseClose.Click += new System.EventHandler(this.btnFondCaisseClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.montantTotalLbl);
            this.groupBox1.Location = new System.Drawing.Point(199, 441);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(247, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Montant Déclaré";
            // 
            // montantTotalLbl
            // 
            this.montantTotalLbl.Location = new System.Drawing.Point(139, 17);
            this.montantTotalLbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.montantTotalLbl.Name = "montantTotalLbl";
            this.montantTotalLbl.Size = new System.Drawing.Size(17, 22);
            this.montantTotalLbl.TabIndex = 0;
            this.montantTotalLbl.Values.Text = "0";
            this.montantTotalLbl.TextChanged += new System.EventHandler(this.montantTotalLbl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devise";
            // 
            // FondCaisseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 541);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FondCaisseForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Déclaration de fond de caisse";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondCaisseDatagridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFondCaisseClose;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView fondCaisseDatagridView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnValiderFondCaisse;
        private System.Windows.Forms.ComboBox deviseCmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbProt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMarq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbCreateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbModification;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbReplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValeurSansQté;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDevise;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel montantTotalLbl;
    }
}