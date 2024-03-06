namespace SoftCaisse.Forms.Billetage
{
    partial class BilletageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilletageForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cbMarq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCreateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbModification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbReplication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Devise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intitulé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kryptonDataGridView1);
            this.groupBox1.Controls.Add(this.kryptonButton2);
            this.groupBox1.Controls.Add(this.kryptonButton1);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billetage";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbMarq,
            this.cbProt,
            this.cbCreateur,
            this.cbModification,
            this.cbReplication,
            this.cbFlag,
            this.N_Devise,
            this.Intitulé,
            this.Valeur});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(13, 24);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.ShowCellToolTips = false;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(500, 513);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // cbMarq
            // 
            this.cbMarq.DataPropertyName = "cbMarq";
            this.cbMarq.HeaderText = "cbMarq";
            this.cbMarq.MinimumWidth = 6;
            this.cbMarq.Name = "cbMarq";
            this.cbMarq.Visible = false;
            // 
            // cbProt
            // 
            this.cbProt.DataPropertyName = "cbProt";
            this.cbProt.HeaderText = "cbProt";
            this.cbProt.MinimumWidth = 6;
            this.cbProt.Name = "cbProt";
            this.cbProt.Visible = false;
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
            // N_Devise
            // 
            this.N_Devise.DataPropertyName = "N_Devise";
            this.N_Devise.HeaderText = "N_Devise";
            this.N_Devise.MinimumWidth = 6;
            this.N_Devise.Name = "N_Devise";
            this.N_Devise.Visible = false;
            // 
            // Intitulé
            // 
            this.Intitulé.DataPropertyName = "BI_Intitule";
            this.Intitulé.HeaderText = "Intitulé";
            this.Intitulé.MinimumWidth = 6;
            this.Intitulé.Name = "Intitulé";
            // 
            // Valeur
            // 
            this.Valeur.DataPropertyName = "BI_Valeur";
            this.Valeur.HeaderText = "Valeur";
            this.Valeur.MinimumWidth = 6;
            this.Valeur.Name = "Valeur";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(528, 67);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Palette = this.kryptonPalette1;
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton2.Size = new System.Drawing.Size(117, 33);
            this.kryptonButton2.TabIndex = 9;
            this.kryptonButton2.Values.Text = "Supprimer";
            this.kryptonButton2.Click += new System.EventHandler(this.newrow_click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(528, 24);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Palette = this.kryptonPalette1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton1.Size = new System.Drawing.Size(117, 33);
            this.kryptonButton1.TabIndex = 8;
            this.kryptonButton1.Values.Text = "Ajouter";
            this.kryptonButton1.Click += new System.EventHandler(this.focus_row);
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(432, 567);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Palette = this.kryptonPalette1;
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton4.Size = new System.Drawing.Size(97, 34);
            this.kryptonButton4.TabIndex = 27;
            this.kryptonButton4.Values.Text = "Sauvegarde";
            this.kryptonButton4.Click += new System.EventHandler(this.add_newBilletage);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(535, 567);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Palette = this.kryptonPalette1;
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton3.Size = new System.Drawing.Size(97, 34);
            this.kryptonButton3.TabIndex = 28;
            this.kryptonButton3.Values.Text = "Annuler";
            // 
            // BilletageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 606);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BilletageForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BilletageForm";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMarq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbProt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbCreateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbModification;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbReplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Devise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitulé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
    }
}