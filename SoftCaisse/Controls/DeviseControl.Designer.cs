namespace SoftCaisse.Controls
{
    partial class DeviseControl
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
            this.btnDeviseClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cbMarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_ISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_ISO_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeviseClose);
            this.groupBox1.Controls.Add(this.kryptonButton4);
            this.groupBox1.Location = new System.Drawing.Point(2, 372);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(647, 45);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnDeviseClose
            // 
            this.btnDeviseClose.Location = new System.Drawing.Point(564, 12);
            this.btnDeviseClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeviseClose.Name = "btnDeviseClose";
            this.btnDeviseClose.Palette = this.kryptonPalette1;
            this.btnDeviseClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnDeviseClose.Size = new System.Drawing.Size(79, 28);
            this.btnDeviseClose.TabIndex = 27;
            this.btnDeviseClose.Values.Text = "Annuler";
            this.btnDeviseClose.Click += new System.EventHandler(this.btnDeviseClose_Click);
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
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(482, 12);
            this.kryptonButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Palette = this.kryptonPalette1;
            this.kryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton4.Size = new System.Drawing.Size(79, 28);
            this.kryptonButton4.TabIndex = 26;
            this.kryptonButton4.Values.Text = "OK";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbMarque,
            this.Devise,
            this.Code_ISO,
            this.Code_ISO_Num,
            this.Cours});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(5, 11);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(644, 357);
            this.kryptonDataGridView1.TabIndex = 26;
            this.kryptonDataGridView1.DoubleClick += new System.EventHandler(this.kryptonDataGridView1_DoubleClick);
            // 
            // cbMarque
            // 
            this.cbMarque.DataPropertyName = "cbMarque";
            this.cbMarque.HeaderText = "cbMarque";
            this.cbMarque.MinimumWidth = 6;
            this.cbMarque.Name = "cbMarque";
            this.cbMarque.Visible = false;
            // 
            // Devise
            // 
            this.Devise.DataPropertyName = "Devise";
            this.Devise.HeaderText = "Devise";
            this.Devise.MinimumWidth = 6;
            this.Devise.Name = "Devise";
            // 
            // Code_ISO
            // 
            this.Code_ISO.DataPropertyName = "Code_ISO";
            this.Code_ISO.HeaderText = "Code ISO";
            this.Code_ISO.MinimumWidth = 6;
            this.Code_ISO.Name = "Code_ISO";
            // 
            // Code_ISO_Num
            // 
            this.Code_ISO_Num.DataPropertyName = "Code_ISO_NUM";
            this.Code_ISO_Num.HeaderText = "Code ISO NUM";
            this.Code_ISO_Num.MinimumWidth = 6;
            this.Code_ISO_Num.Name = "Code_ISO_Num";
            // 
            // Cours
            // 
            this.Cours.DataPropertyName = "Cours";
            this.Cours.HeaderText = "Cours";
            this.Cours.MinimumWidth = 6;
            this.Cours.Name = "Cours";
            // 
            // DeviseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeviseControl";
            this.Size = new System.Drawing.Size(656, 427);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeviseClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_ISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_ISO_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cours;
    }
}
