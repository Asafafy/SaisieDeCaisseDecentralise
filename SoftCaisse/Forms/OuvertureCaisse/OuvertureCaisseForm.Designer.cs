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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fondCaisseCbox = new System.Windows.Forms.CheckBox();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtOuvertureCaissePwd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.OuvertureCaisseCmbx = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnOuvrCaisseClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOuvertureCaisse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.OuvertureCaissierCmbx = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fondCaisseCbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonDateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOuvertureCaissePwd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OuvertureCaisseCmbx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.OuvertureCaissierCmbx, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caisse";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cassier";
            // 
            // fondCaisseCbox
            // 
            this.fondCaisseCbox.AutoSize = true;
            this.fondCaisseCbox.Location = new System.Drawing.Point(2, 104);
            this.fondCaisseCbox.Margin = new System.Windows.Forms.Padding(2);
            this.fondCaisseCbox.Name = "fondCaisseCbox";
            this.fondCaisseCbox.Size = new System.Drawing.Size(153, 17);
            this.fondCaisseCbox.TabIndex = 8;
            this.fondCaisseCbox.Text = "Déclarer un fond de caisse";
            this.fondCaisseCbox.UseVisualStyleBackColor = true;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(205, 2);
            this.kryptonDateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(104, 25);
            this.kryptonDateTimePicker1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDateTimePicker1.StateCommon.Border.Rounding = 5;
            this.kryptonDateTimePicker1.TabIndex = 9;
            // 
            // txtOuvertureCaissePwd
            // 
            this.txtOuvertureCaissePwd.Location = new System.Drawing.Point(205, 78);
            this.txtOuvertureCaissePwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtOuvertureCaissePwd.Name = "txtOuvertureCaissePwd";
            this.txtOuvertureCaissePwd.Size = new System.Drawing.Size(190, 23);
            this.txtOuvertureCaissePwd.TabIndex = 11;
            // 
            // OuvertureCaisseCmbx
            // 
            this.OuvertureCaisseCmbx.FormattingEnabled = true;
            this.OuvertureCaisseCmbx.Location = new System.Drawing.Point(206, 32);
            this.OuvertureCaisseCmbx.Name = "OuvertureCaisseCmbx";
            this.OuvertureCaisseCmbx.Size = new System.Drawing.Size(197, 21);
            this.OuvertureCaisseCmbx.TabIndex = 12;
            this.OuvertureCaisseCmbx.SelectedIndexChanged += new System.EventHandler(this.OuvertureCaisseCmbx_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(427, 155);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
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
            // btnOuvrCaisseClose
            // 
            this.btnOuvrCaisseClose.Location = new System.Drawing.Point(328, 167);
            this.btnOuvrCaisseClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnOuvrCaisseClose.Name = "btnOuvrCaisseClose";
            this.btnOuvrCaisseClose.Palette = this.kryptonPalette1;
            this.btnOuvrCaisseClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnOuvrCaisseClose.Size = new System.Drawing.Size(88, 27);
            this.btnOuvrCaisseClose.TabIndex = 11;
            this.btnOuvrCaisseClose.Values.Text = "Annuler";
            this.btnOuvrCaisseClose.Click += new System.EventHandler(this.btnOuvrCaisseClose_Click);
            // 
            // btnOuvertureCaisse
            // 
            this.btnOuvertureCaisse.Location = new System.Drawing.Point(236, 167);
            this.btnOuvertureCaisse.Margin = new System.Windows.Forms.Padding(2);
            this.btnOuvertureCaisse.Name = "btnOuvertureCaisse";
            this.btnOuvertureCaisse.Palette = this.kryptonPalette1;
            this.btnOuvertureCaisse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnOuvertureCaisse.Size = new System.Drawing.Size(88, 27);
            this.btnOuvertureCaisse.TabIndex = 12;
            this.btnOuvertureCaisse.Values.Text = "OK";
            this.btnOuvertureCaisse.Click += new System.EventHandler(this.btnOuvertureCaisse_Click);
            // 
            // OuvertureCaissierCmbx
            // 
            this.OuvertureCaissierCmbx.FormattingEnabled = true;
            this.OuvertureCaissierCmbx.Location = new System.Drawing.Point(206, 55);
            this.OuvertureCaissierCmbx.Name = "OuvertureCaissierCmbx";
            this.OuvertureCaissierCmbx.Size = new System.Drawing.Size(197, 21);
            this.OuvertureCaissierCmbx.TabIndex = 13;
            this.OuvertureCaissierCmbx.SelectedIndexChanged += new System.EventHandler(this.OuvertureCaissierCmbx_SelectedIndexChanged);
            // 
            // OuvertureCaisseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 198);
            this.Controls.Add(this.btnOuvertureCaisse);
            this.Controls.Add(this.btnOuvrCaisseClose);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OuvertureCaisseForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouverture de caisse";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fondCaisseCbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOuvrCaisseClose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOuvertureCaisse;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOuvertureCaissePwd;
        private System.Windows.Forms.ComboBox OuvertureCaisseCmbx;
        private System.Windows.Forms.ComboBox OuvertureCaissierCmbx;
    }
}