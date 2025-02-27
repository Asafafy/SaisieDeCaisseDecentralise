namespace SoftCaisse.Forms.OuvertureCaisse
{
    partial class OuvertureCaisseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OuvertureCaisseForm));
            this.fondCaisseCbox = new System.Windows.Forms.CheckBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.OuvertureCaisseCmbx = new System.Windows.Forms.ComboBox();
            this.OuvertureCaissierCmbx = new System.Windows.Forms.ComboBox();
            this.FondCaisseType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOuvertureCaissePwd = new System.Windows.Forms.TextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnOuvertureCaisse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondCaisseCbox
            // 
            this.fondCaisseCbox.AutoSize = true;
            this.fondCaisseCbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.fondCaisseCbox.Location = new System.Drawing.Point(86, 150);
            this.fondCaisseCbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondCaisseCbox.Name = "fondCaisseCbox";
            this.fondCaisseCbox.Size = new System.Drawing.Size(189, 33);
            this.fondCaisseCbox.TabIndex = 8;
            this.fondCaisseCbox.Text = "Déclarer un fond de caisse";
            this.fondCaisseCbox.UseVisualStyleBackColor = true;
            this.fondCaisseCbox.CheckedChanged += new System.EventHandler(this.fondCaisseCbox_CheckedChanged);
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(281, 2);
            this.kryptonDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(273, 29);
            this.kryptonDateTimePicker1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDateTimePicker1.StateCommon.Border.Rounding = 5;
            this.kryptonDateTimePicker1.TabIndex = 9;
            // 
            // OuvertureCaisseCmbx
            // 
            this.OuvertureCaisseCmbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuvertureCaisseCmbx.FormattingEnabled = true;
            this.OuvertureCaisseCmbx.Location = new System.Drawing.Point(282, 43);
            this.OuvertureCaisseCmbx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.OuvertureCaisseCmbx.Name = "OuvertureCaisseCmbx";
            this.OuvertureCaisseCmbx.Size = new System.Drawing.Size(271, 24);
            this.OuvertureCaisseCmbx.TabIndex = 12;
            this.OuvertureCaisseCmbx.SelectedValueChanged += new System.EventHandler(this.OuvertureCaisseCmbx_SelectedValueChanged);
            // 
            // OuvertureCaissierCmbx
            // 
            this.OuvertureCaissierCmbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OuvertureCaissierCmbx.FormattingEnabled = true;
            this.OuvertureCaissierCmbx.Location = new System.Drawing.Point(282, 80);
            this.OuvertureCaissierCmbx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.OuvertureCaissierCmbx.Name = "OuvertureCaissierCmbx";
            this.OuvertureCaissierCmbx.Size = new System.Drawing.Size(271, 24);
            this.OuvertureCaissierCmbx.TabIndex = 13;
            // 
            // FondCaisseType
            // 
            this.FondCaisseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FondCaisseType.Enabled = false;
            this.FondCaisseType.FormattingEnabled = true;
            this.FondCaisseType.Items.AddRange(new object[] {
            "Global",
            "Par billetage"});
            this.FondCaisseType.Location = new System.Drawing.Point(282, 154);
            this.FondCaisseType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.FondCaisseType.Name = "FondCaisseType";
            this.FondCaisseType.Size = new System.Drawing.Size(271, 24);
            this.FondCaisseType.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(563, 225);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.kryptonDateTimePicker1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FondCaisseType, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.OuvertureCaisseCmbx, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.OuvertureCaissierCmbx, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtOuvertureCaissePwd, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.fondCaisseCbox, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 202);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtOuvertureCaissePwd
            // 
            this.txtOuvertureCaissePwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOuvertureCaissePwd.Location = new System.Drawing.Point(282, 117);
            this.txtOuvertureCaissePwd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtOuvertureCaissePwd.Name = "txtOuvertureCaissePwd";
            this.txtOuvertureCaissePwd.Size = new System.Drawing.Size(271, 22);
            this.txtOuvertureCaissePwd.TabIndex = 14;
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
            // btnOuvertureCaisse
            // 
            this.btnOuvertureCaisse.Location = new System.Drawing.Point(458, 252);
            this.btnOuvertureCaisse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOuvertureCaisse.Name = "btnOuvertureCaisse";
            this.btnOuvertureCaisse.Palette = this.kryptonPalette1;
            this.btnOuvertureCaisse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnOuvertureCaisse.Size = new System.Drawing.Size(117, 33);
            this.btnOuvertureCaisse.TabIndex = 12;
            this.btnOuvertureCaisse.Values.Text = "OK";
            this.btnOuvertureCaisse.Click += new System.EventHandler(this.btnOuvertureCaisse_Click);
            // 
            // OuvertureCaisseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(587, 296);
            this.Controls.Add(this.btnOuvertureCaisse);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OuvertureCaisseForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouverture de caisse";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox fondCaisseCbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOuvertureCaisse;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private System.Windows.Forms.ComboBox OuvertureCaisseCmbx;
        private System.Windows.Forms.ComboBox OuvertureCaissierCmbx;
        private System.Windows.Forms.ComboBox FondCaisseType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtOuvertureCaissePwd;
    }
}