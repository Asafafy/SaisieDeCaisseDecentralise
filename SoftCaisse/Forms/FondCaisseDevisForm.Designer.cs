namespace SoftCaisse.Forms.FondCaisse
{
    partial class FondCaisseDevisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FondCaisseDevisForm));
            this.GridViewFondCaisse = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMarq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SauvegardeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFondCaisse)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewFondCaisse
            // 
            this.GridViewFondCaisse.AllowUserToAddRows = false;
            this.GridViewFondCaisse.AllowUserToDeleteRows = false;
            this.GridViewFondCaisse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewFondCaisse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewFondCaisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFondCaisse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intitule,
            this.Valeur,
            this.cbMarq});
            this.GridViewFondCaisse.Location = new System.Drawing.Point(28, 27);
            this.GridViewFondCaisse.Name = "GridViewFondCaisse";
            this.GridViewFondCaisse.RowHeadersVisible = false;
            this.GridViewFondCaisse.RowHeadersWidth = 51;
            this.GridViewFondCaisse.RowTemplate.Height = 24;
            this.GridViewFondCaisse.Size = new System.Drawing.Size(562, 359);
            this.GridViewFondCaisse.TabIndex = 0;
            // 
            // Intitule
            // 
            this.Intitule.HeaderText = "Intitule";
            this.Intitule.MinimumWidth = 6;
            this.Intitule.Name = "Intitule";
            // 
            // Valeur
            // 
            this.Valeur.HeaderText = "Valeur";
            this.Valeur.MinimumWidth = 6;
            this.Valeur.Name = "Valeur";
            // 
            // cbMarq
            // 
            this.cbMarq.HeaderText = "cbMarq";
            this.cbMarq.MinimumWidth = 6;
            this.cbMarq.Name = "cbMarq";
            this.cbMarq.Visible = false;
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
            // SauvegardeButton
            // 
            this.SauvegardeButton.Location = new System.Drawing.Point(490, 458);
            this.SauvegardeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SauvegardeButton.Name = "SauvegardeButton";
            this.SauvegardeButton.Palette = this.kryptonPalette1;
            this.SauvegardeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.SauvegardeButton.Size = new System.Drawing.Size(100, 38);
            this.SauvegardeButton.TabIndex = 50;
            this.SauvegardeButton.Values.Text = "OK";
            this.SauvegardeButton.Click += new System.EventHandler(this.SauvegardeButton_Click);
            // 
            // FondCaisseDevisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(618, 530);
            this.Controls.Add(this.SauvegardeButton);
            this.Controls.Add(this.GridViewFondCaisse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FondCaisseDevisForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Declaration globale du fond de caisse";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFondCaisse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView GridViewFondCaisse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMarq;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SauvegardeButton;
    }
}