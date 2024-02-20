namespace SoftCaisse.Forms.VenteComptoir
{
    partial class VenteComptoirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenteComptoirForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.CArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGame1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGamme2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPuHt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPuTtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CConditionnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRemise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPuNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMontantHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMontantTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.kryptonDataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 594);
            this.panel1.TabIndex = 0;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.ColumnHeadersHeight = 29;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CArticle,
            this.CDesignation,
            this.CGame1,
            this.CGamme2,
            this.CPuHt,
            this.CPuTtc,
            this.CQuantite,
            this.CConditionnement,
            this.CRemise,
            this.CPuNet,
            this.CMontantHT,
            this.CMontantTTC});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(12, 166);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1001, 204);
            this.kryptonDataGridView1.TabIndex = 1;
            // 
            // CArticle
            // 
            this.CArticle.FillWeight = 150F;
            this.CArticle.HeaderText = "Référence article";
            this.CArticle.MinimumWidth = 6;
            this.CArticle.Name = "CArticle";
            this.CArticle.ReadOnly = true;
            this.CArticle.Width = 125;
            // 
            // CDesignation
            // 
            this.CDesignation.FillWeight = 136.6342F;
            this.CDesignation.HeaderText = "Désignation";
            this.CDesignation.MinimumWidth = 6;
            this.CDesignation.Name = "CDesignation";
            this.CDesignation.ReadOnly = true;
            this.CDesignation.Width = 114;
            // 
            // CGame1
            // 
            this.CGame1.FillWeight = 124.9391F;
            this.CGame1.HeaderText = "Gamme 1";
            this.CGame1.MinimumWidth = 6;
            this.CGame1.Name = "CGame1";
            this.CGame1.ReadOnly = true;
            this.CGame1.Width = 104;
            // 
            // CGamme2
            // 
            this.CGamme2.FillWeight = 114.7059F;
            this.CGamme2.HeaderText = "Gamme 2";
            this.CGamme2.MinimumWidth = 6;
            this.CGamme2.Name = "CGamme2";
            this.CGamme2.ReadOnly = true;
            this.CGamme2.Width = 96;
            // 
            // CPuHt
            // 
            this.CPuHt.FillWeight = 105.7519F;
            this.CPuHt.HeaderText = "P.U. HT";
            this.CPuHt.MinimumWidth = 6;
            this.CPuHt.Name = "CPuHt";
            this.CPuHt.ReadOnly = true;
            this.CPuHt.Width = 88;
            // 
            // CPuTtc
            // 
            this.CPuTtc.FillWeight = 97.9171F;
            this.CPuTtc.HeaderText = "P.U.TTC";
            this.CPuTtc.MinimumWidth = 6;
            this.CPuTtc.Name = "CPuTtc";
            this.CPuTtc.ReadOnly = true;
            this.CPuTtc.Width = 81;
            // 
            // CQuantite
            // 
            this.CQuantite.FillWeight = 91.06168F;
            this.CQuantite.HeaderText = "Quantité";
            this.CQuantite.MinimumWidth = 6;
            this.CQuantite.Name = "CQuantite";
            this.CQuantite.ReadOnly = true;
            this.CQuantite.Width = 76;
            // 
            // CConditionnement
            // 
            this.CConditionnement.FillWeight = 85.06316F;
            this.CConditionnement.HeaderText = "Conditionnement";
            this.CConditionnement.MinimumWidth = 6;
            this.CConditionnement.Name = "CConditionnement";
            this.CConditionnement.ReadOnly = true;
            this.CConditionnement.Width = 71;
            // 
            // CRemise
            // 
            this.CRemise.FillWeight = 79.81447F;
            this.CRemise.HeaderText = "Remise";
            this.CRemise.MinimumWidth = 6;
            this.CRemise.Name = "CRemise";
            this.CRemise.ReadOnly = true;
            this.CRemise.Width = 67;
            // 
            // CPuNet
            // 
            this.CPuNet.FillWeight = 75.22186F;
            this.CPuNet.HeaderText = "P.U. net";
            this.CPuNet.MinimumWidth = 6;
            this.CPuNet.Name = "CPuNet";
            this.CPuNet.ReadOnly = true;
            this.CPuNet.Width = 62;
            // 
            // CMontantHT
            // 
            this.CMontantHT.FillWeight = 71.20335F;
            this.CMontantHT.HeaderText = "Montant HT";
            this.CMontantHT.MinimumWidth = 6;
            this.CMontantHT.Name = "CMontantHT";
            this.CMontantHT.ReadOnly = true;
            this.CMontantHT.Width = 60;
            // 
            // CMontantTTC
            // 
            this.CMontantTTC.FillWeight = 67.68713F;
            this.CMontantTTC.HeaderText = "Montant TTC";
            this.CMontantTTC.MinimumWidth = 6;
            this.CMontantTTC.Name = "CMontantTTC";
            this.CMontantTTC.ReadOnly = true;
            this.CMontantTTC.Width = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(500, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total TTC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total HT";
            // 
            // VenteComptoirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 594);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VenteComptoirForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente comptoir";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGame1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGamme2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuHt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuTtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConditionnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRemise;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMontantHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMontantTTC;
    }
}