namespace SoftCaisse.Forms
{
    partial class CreationManuelleEnumgamme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationManuelleEnumgamme));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.labelEnumere = new System.Windows.Forms.Label();
            this.groupBoxIdentification = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCodeBarres = new System.Windows.Forms.Label();
            this.lblPrixDAchat = new System.Windows.Forms.Label();
            this.txtBxReference = new System.Windows.Forms.TextBox();
            this.txtBxCodeBarres = new System.Windows.Forms.TextBox();
            this.txtBxPrixAch = new System.Windows.Forms.TextBox();
            this.groupBoxCategoriesTarifaires = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBxClientsComptoir = new System.Windows.Forms.TextBox();
            this.txtBxDetaillants = new System.Windows.Forms.TextBox();
            this.txtBxGrossistes = new System.Windows.Forms.TextBox();
            this.lblClientsComptoir = new System.Windows.Forms.Label();
            this.lblDetaillants = new System.Windows.Forms.Label();
            this.lblGrossistes = new System.Windows.Forms.Label();
            this.kryptonButtonAnnuler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBoxIdentification.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxCategoriesTarifaires.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // labelEnumere
            // 
            this.labelEnumere.AutoSize = true;
            this.labelEnumere.Location = new System.Drawing.Point(41, 33);
            this.labelEnumere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnumere.Name = "labelEnumere";
            this.labelEnumere.Size = new System.Drawing.Size(70, 16);
            this.labelEnumere.TabIndex = 0;
            this.labelEnumere.Text = "Enuméré : ";
            // 
            // groupBoxIdentification
            // 
            this.groupBoxIdentification.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxIdentification.Location = new System.Drawing.Point(16, 74);
            this.groupBoxIdentification.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIdentification.Name = "groupBoxIdentification";
            this.groupBoxIdentification.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIdentification.Size = new System.Drawing.Size(569, 161);
            this.groupBoxIdentification.TabIndex = 1;
            this.groupBoxIdentification.TabStop = false;
            this.groupBoxIdentification.Text = "Identification";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.73402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.26598F));
            this.tableLayoutPanel1.Controls.Add(this.lblReference, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCodeBarres, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPrixDAchat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBxReference, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBxCodeBarres, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBxPrixAch, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 132);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReference.Location = new System.Drawing.Point(70, 18);
            this.lblReference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(70, 37);
            this.lblReference.TabIndex = 0;
            this.lblReference.Text = "Référence";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodeBarres
            // 
            this.lblCodeBarres.AutoSize = true;
            this.lblCodeBarres.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCodeBarres.Location = new System.Drawing.Point(58, 55);
            this.lblCodeBarres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeBarres.Name = "lblCodeBarres";
            this.lblCodeBarres.Size = new System.Drawing.Size(82, 37);
            this.lblCodeBarres.TabIndex = 1;
            this.lblCodeBarres.Text = "Code barres";
            this.lblCodeBarres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrixDAchat
            // 
            this.lblPrixDAchat.AutoSize = true;
            this.lblPrixDAchat.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrixDAchat.Location = new System.Drawing.Point(64, 92);
            this.lblPrixDAchat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixDAchat.Name = "lblPrixDAchat";
            this.lblPrixDAchat.Size = new System.Drawing.Size(76, 40);
            this.lblPrixDAchat.TabIndex = 2;
            this.lblPrixDAchat.Text = "Prix d\'achat";
            this.lblPrixDAchat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxReference
            // 
            this.txtBxReference.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBxReference.Location = new System.Drawing.Point(148, 24);
            this.txtBxReference.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtBxReference.Name = "txtBxReference";
            this.txtBxReference.Size = new System.Drawing.Size(359, 22);
            this.txtBxReference.TabIndex = 3;
            this.txtBxReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxReference_KeyPress);
            // 
            // txtBxCodeBarres
            // 
            this.txtBxCodeBarres.Location = new System.Drawing.Point(148, 61);
            this.txtBxCodeBarres.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtBxCodeBarres.Name = "txtBxCodeBarres";
            this.txtBxCodeBarres.Size = new System.Drawing.Size(359, 22);
            this.txtBxCodeBarres.TabIndex = 4;
            this.txtBxCodeBarres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxCodeBarres_KeyPress);
            // 
            // txtBxPrixAch
            // 
            this.txtBxPrixAch.Location = new System.Drawing.Point(148, 98);
            this.txtBxPrixAch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtBxPrixAch.Name = "txtBxPrixAch";
            this.txtBxPrixAch.Size = new System.Drawing.Size(359, 22);
            this.txtBxPrixAch.TabIndex = 5;
            // 
            // groupBoxCategoriesTarifaires
            // 
            this.groupBoxCategoriesTarifaires.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxCategoriesTarifaires.Location = new System.Drawing.Point(16, 271);
            this.groupBoxCategoriesTarifaires.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCategoriesTarifaires.Name = "groupBoxCategoriesTarifaires";
            this.groupBoxCategoriesTarifaires.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCategoriesTarifaires.Size = new System.Drawing.Size(569, 164);
            this.groupBoxCategoriesTarifaires.TabIndex = 6;
            this.groupBoxCategoriesTarifaires.TabStop = false;
            this.groupBoxCategoriesTarifaires.Text = "Catégories tarifaires";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21589F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.78411F));
            this.tableLayoutPanel2.Controls.Add(this.txtBxClientsComptoir, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtBxDetaillants, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBxGrossistes, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblClientsComptoir, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDetaillants, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblGrossistes, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 130);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtBxClientsComptoir
            // 
            this.txtBxClientsComptoir.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBxClientsComptoir.Location = new System.Drawing.Point(145, 98);
            this.txtBxClientsComptoir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtBxClientsComptoir.Name = "txtBxClientsComptoir";
            this.txtBxClientsComptoir.Size = new System.Drawing.Size(359, 22);
            this.txtBxClientsComptoir.TabIndex = 12;
            this.txtBxClientsComptoir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxClientsComptoir_KeyPress);
            // 
            // txtBxDetaillants
            // 
            this.txtBxDetaillants.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBxDetaillants.Location = new System.Drawing.Point(145, 61);
            this.txtBxDetaillants.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtBxDetaillants.Name = "txtBxDetaillants";
            this.txtBxDetaillants.Size = new System.Drawing.Size(359, 22);
            this.txtBxDetaillants.TabIndex = 11;
            this.txtBxDetaillants.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxDetaillants_KeyPress);
            // 
            // txtBxGrossistes
            // 
            this.txtBxGrossistes.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBxGrossistes.Location = new System.Drawing.Point(145, 24);
            this.txtBxGrossistes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.txtBxGrossistes.Name = "txtBxGrossistes";
            this.txtBxGrossistes.Size = new System.Drawing.Size(359, 22);
            this.txtBxGrossistes.TabIndex = 10;
            this.txtBxGrossistes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxGrossistes_KeyPress);
            // 
            // lblClientsComptoir
            // 
            this.lblClientsComptoir.AutoSize = true;
            this.lblClientsComptoir.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClientsComptoir.Location = new System.Drawing.Point(35, 92);
            this.lblClientsComptoir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientsComptoir.Name = "lblClientsComptoir";
            this.lblClientsComptoir.Size = new System.Drawing.Size(102, 38);
            this.lblClientsComptoir.TabIndex = 7;
            this.lblClientsComptoir.Text = "Clients comptoir";
            this.lblClientsComptoir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetaillants
            // 
            this.lblDetaillants.AutoSize = true;
            this.lblDetaillants.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetaillants.Location = new System.Drawing.Point(67, 55);
            this.lblDetaillants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetaillants.Name = "lblDetaillants";
            this.lblDetaillants.Size = new System.Drawing.Size(70, 37);
            this.lblDetaillants.TabIndex = 5;
            this.lblDetaillants.Text = "Détaillants";
            this.lblDetaillants.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrossistes
            // 
            this.lblGrossistes.AutoSize = true;
            this.lblGrossistes.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGrossistes.Location = new System.Drawing.Point(66, 18);
            this.lblGrossistes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrossistes.Name = "lblGrossistes";
            this.lblGrossistes.Size = new System.Drawing.Size(71, 37);
            this.lblGrossistes.TabIndex = 3;
            this.lblGrossistes.Text = "Grossistes";
            this.lblGrossistes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kryptonButtonAnnuler
            // 
            this.kryptonButtonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButtonAnnuler.Location = new System.Drawing.Point(473, 476);
            this.kryptonButtonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButtonAnnuler.Name = "kryptonButtonAnnuler";
            this.kryptonButtonAnnuler.Palette = this.kryptonPalette1;
            this.kryptonButtonAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButtonAnnuler.Size = new System.Drawing.Size(112, 38);
            this.kryptonButtonAnnuler.TabIndex = 32;
            this.kryptonButtonAnnuler.Values.Text = "Annuler";
            this.kryptonButtonAnnuler.Click += new System.EventHandler(this.kryptonButtonAnnuler_Click);
            // 
            // kryptonButtonOK
            // 
            this.kryptonButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButtonOK.Location = new System.Drawing.Point(352, 476);
            this.kryptonButtonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButtonOK.Name = "kryptonButtonOK";
            this.kryptonButtonOK.Palette = this.kryptonPalette1;
            this.kryptonButtonOK.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButtonOK.Size = new System.Drawing.Size(112, 38);
            this.kryptonButtonOK.TabIndex = 31;
            this.kryptonButtonOK.Values.Text = "OK";
            this.kryptonButtonOK.Click += new System.EventHandler(this.kryptonButtonOK_Click);
            // 
            // CreationManuelleEnumgamme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(601, 530);
            this.Controls.Add(this.kryptonButtonAnnuler);
            this.Controls.Add(this.kryptonButtonOK);
            this.Controls.Add(this.groupBoxCategoriesTarifaires);
            this.Controls.Add(this.groupBoxIdentification);
            this.Controls.Add(this.labelEnumere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreationManuelleEnumgamme";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Création manuelle des énumérées des gammes";
            this.groupBoxIdentification.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxCategoriesTarifaires.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label labelEnumere;
        private System.Windows.Forms.GroupBox groupBoxIdentification;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblCodeBarres;
        private System.Windows.Forms.Label lblPrixDAchat;
        private System.Windows.Forms.TextBox txtBxReference;
        private System.Windows.Forms.TextBox txtBxCodeBarres;
        private System.Windows.Forms.TextBox txtBxPrixAch;
        private System.Windows.Forms.GroupBox groupBoxCategoriesTarifaires;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonAnnuler;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtBxClientsComptoir;
        private System.Windows.Forms.TextBox txtBxDetaillants;
        private System.Windows.Forms.TextBox txtBxGrossistes;
        private System.Windows.Forms.Label lblClientsComptoir;
        private System.Windows.Forms.Label lblDetaillants;
        private System.Windows.Forms.Label lblGrossistes;
    }
}