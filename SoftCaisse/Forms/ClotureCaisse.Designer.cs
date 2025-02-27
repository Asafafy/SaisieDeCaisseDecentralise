namespace SoftCaisse.Forms.ClotureCaisse
{
    partial class ClotureCaisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClotureCaisse));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kptBtnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CmbBxCaisseFin = new System.Windows.Forms.ComboBox();
            this.DateCloture = new System.Windows.Forms.ComboBox();
            this.CmbBxCaisseDebut = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CmbBxRegroupementsTickets = new System.Windows.Forms.ComboBox();
            this.CmbBxSouche = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(82, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caisse de";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(406, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "à";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 189);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(267, 24);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Paramètre de génération des factures";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(278, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "Regroupements tickets";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(370, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Souche";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // kptBtnOK
            // 
            this.kptBtnOK.Location = new System.Drawing.Point(528, 384);
            this.kptBtnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kptBtnOK.Name = "kptBtnOK";
            this.kptBtnOK.Palette = this.kryptonPalette1;
            this.kptBtnOK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kptBtnOK.Size = new System.Drawing.Size(100, 38);
            this.kptBtnOK.TabIndex = 44;
            this.kptBtnOK.Values.Text = "OK";
            this.kptBtnOK.Click += new System.EventHandler(this.cloturer_caisse);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 118);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CmbBxCaisseFin, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.DateCloture, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CmbBxCaisseDebut, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CmbBxCaisseFin
            // 
            this.CmbBxCaisseFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbBxCaisseFin.FormattingEnabled = true;
            this.CmbBxCaisseFin.Location = new System.Drawing.Point(427, 55);
            this.CmbBxCaisseFin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CmbBxCaisseFin.Name = "CmbBxCaisseFin";
            this.CmbBxCaisseFin.Size = new System.Drawing.Size(179, 24);
            this.CmbBxCaisseFin.TabIndex = 6;
            // 
            // DateCloture
            // 
            this.DateCloture.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateCloture.FormattingEnabled = true;
            this.DateCloture.Location = new System.Drawing.Point(124, 25);
            this.DateCloture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.DateCloture.Name = "DateCloture";
            this.DateCloture.Size = new System.Drawing.Size(176, 24);
            this.DateCloture.TabIndex = 7;
            // 
            // CmbBxCaisseDebut
            // 
            this.CmbBxCaisseDebut.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbBxCaisseDebut.FormattingEnabled = true;
            this.CmbBxCaisseDebut.Location = new System.Drawing.Point(124, 55);
            this.CmbBxCaisseDebut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CmbBxCaisseDebut.Name = "CmbBxCaisseDebut";
            this.CmbBxCaisseDebut.Size = new System.Drawing.Size(176, 24);
            this.CmbBxCaisseDebut.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(13, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 134);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.CmbBxRegroupementsTickets, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CmbBxSouche, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(609, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CmbBxRegroupementsTickets
            // 
            this.CmbBxRegroupementsTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbBxRegroupementsTickets.FormattingEnabled = true;
            this.CmbBxRegroupementsTickets.Location = new System.Drawing.Point(429, 55);
            this.CmbBxRegroupementsTickets.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CmbBxRegroupementsTickets.Name = "CmbBxRegroupementsTickets";
            this.CmbBxRegroupementsTickets.Size = new System.Drawing.Size(177, 24);
            this.CmbBxRegroupementsTickets.TabIndex = 14;
            // 
            // CmbBxSouche
            // 
            this.CmbBxSouche.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmbBxSouche.FormattingEnabled = true;
            this.CmbBxSouche.Location = new System.Drawing.Point(429, 25);
            this.CmbBxSouche.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CmbBxSouche.Name = "CmbBxSouche";
            this.CmbBxSouche.Size = new System.Drawing.Size(177, 24);
            this.CmbBxSouche.TabIndex = 10;
            // 
            // ClotureCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(640, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kptBtnOK);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClotureCaisse";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "ClotureCaisse";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kptBtnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CmbBxCaisseFin;
        private System.Windows.Forms.ComboBox DateCloture;
        private System.Windows.Forms.ComboBox CmbBxCaisseDebut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox CmbBxSouche;
        private System.Windows.Forms.ComboBox CmbBxRegroupementsTickets;
    }
}