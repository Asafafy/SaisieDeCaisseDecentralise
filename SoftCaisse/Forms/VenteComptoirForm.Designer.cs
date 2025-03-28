﻿using ComponentFactory.Krypton.Toolkit;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenteComptoirForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.GroupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewArticle = new System.Windows.Forms.DataGridView();
            this.Column1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteVendue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
            this.PanelEnregistrement = new System.Windows.Forms.Panel();
            this.PanelInvisibleEnregistrement = new System.Windows.Forms.Panel();
            this.BouttonEnregistrerEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxReglementEnregistrement = new System.Windows.Forms.ComboBox();
            this.TextBoxMontantEnregistrement = new System.Windows.Forms.TextBox();
            this.TextBoxLibelleEnregistrement = new System.Windows.Forms.TextBox();
            this.DateTimePickerEnregistrement = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxDeviseEnregistrement = new System.Windows.Forms.ComboBox();
            this.BouttonSupprimerEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonNouveauEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataGridViewEnregistrement = new System.Windows.Forms.DataGridView();
            this.ModeDeReception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEcheance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelCommandDroite = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelReste = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxDeviseReste = new System.Windows.Forms.ComboBox();
            this.ComboboxSouche = new System.Windows.Forms.ComboBox();
            this.DeviseLabel = new System.Windows.Forms.Label();
            this.LabelResteDu = new System.Windows.Forms.Label();
            this.LabelDeviseReste = new System.Windows.Forms.Label();
            this.LabelPrixResteDu = new System.Windows.Forms.Label();
            this.TableLayoutPanelCommand = new System.Windows.Forms.TableLayoutPanel();
            this.BouttonValider = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonFinDeSaisie = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonCreerDoc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonAnnuler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonEnAttente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonRappelTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonRaccourci = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonFacture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TableLayouotPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTotal = new System.Windows.Forms.Panel();
            this.NumTicket = new System.Windows.Forms.Label();
            this.LabelPrixTotalTTC = new System.Windows.Forms.Label();
            this.LabelMontantlHT = new System.Windows.Forms.Label();
            this.LabelPrixTotalHT = new System.Windows.Forms.Label();
            this.LabelMontantTTC = new System.Windows.Forms.Label();
            this.TableLayoutPanelInfoCaissier = new System.Windows.Forms.TableLayoutPanel();
            this.LabelNomCaissier = new System.Windows.Forms.Label();
            this.LabelTitleCaissier = new System.Windows.Forms.Label();
            this.LabelTarif = new System.Windows.Forms.Label();
            this.LabelCentrale = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.DateTimePickerInfoCaissier = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxNumero = new System.Windows.Forms.ComboBox();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.ComboBoxDepot = new System.Windows.Forms.ComboBox();
            this.ComboBoxAffaire = new System.Windows.Forms.ComboBox();
            this.LabelAffaire = new System.Windows.Forms.Label();
            this.ComboBoxCentrale = new System.Windows.Forms.ComboBox();
            this.LabelDepot = new System.Windows.Forms.Label();
            this.ComboBoxTarif = new System.Windows.Forms.ComboBox();
            this.LabelVendeur = new System.Windows.Forms.Label();
            this.ComboBoxVendeur = new System.Windows.Forms.ComboBox();
            this.BouttonEnregistrerDesignation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TableLayoutPanelDesignation = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxReference = new System.Windows.Forms.TextBox();
            this.TextBoxDesignation = new System.Windows.Forms.TextBox();
            this.TextBoxPUHT = new System.Windows.Forms.TextBox();
            this.TextBoxPUTTC = new System.Windows.Forms.TextBox();
            this.TextBoxRemise = new System.Windows.Forms.TextBox();
            this.TextBoxPUnet = new System.Windows.Forms.TextBox();
            this.TextBoxMontantHT = new System.Windows.Forms.TextBox();
            this.TextBoxMontantTTC = new System.Windows.Forms.TextBox();
            this.TextBoxConditionnement = new System.Windows.Forms.TextBox();
            this.TextBoxQuantiteDisponibleEnStock = new System.Windows.Forms.TextBox();
            this.BouttonSupprimerDesignation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonNouveauDesignation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pDEVISEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREGLEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupBoxGeneral.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArticle)).BeginInit();
            this.TableLayoutPanelFooter.SuspendLayout();
            this.PanelEnregistrement.SuspendLayout();
            this.PanelInvisibleEnregistrement.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnregistrement)).BeginInit();
            this.PanelCommandDroite.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.PanelReste.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TableLayoutPanelCommand.SuspendLayout();
            this.TableLayouotPanelHeader.SuspendLayout();
            this.PanelTotal.SuspendLayout();
            this.TableLayoutPanelInfoCaissier.SuspendLayout();
            this.TableLayoutPanelDesignation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDEVISEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGLEMENTBindingSource)).BeginInit();
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
            // GroupBoxGeneral
            // 
            this.GroupBoxGeneral.BackColor = System.Drawing.Color.AliceBlue;
            this.GroupBoxGeneral.Controls.Add(this.tableLayoutPanel2);
            this.GroupBoxGeneral.Controls.Add(this.TableLayouotPanelHeader);
            this.GroupBoxGeneral.Controls.Add(this.BouttonEnregistrerDesignation);
            this.GroupBoxGeneral.Controls.Add(this.TableLayoutPanelDesignation);
            this.GroupBoxGeneral.Controls.Add(this.BouttonSupprimerDesignation);
            this.GroupBoxGeneral.Controls.Add(this.BouttonNouveauDesignation);
            this.GroupBoxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxGeneral.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxGeneral.Name = "GroupBoxGeneral";
            this.GroupBoxGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxGeneral.Size = new System.Drawing.Size(1620, 955);
            this.GroupBoxGeneral.TabIndex = 0;
            this.GroupBoxGeneral.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewArticle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TableLayoutPanelFooter, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 293);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1568, 655);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // DataGridViewArticle
            // 
            this.DataGridViewArticle.AllowUserToAddRows = false;
            this.DataGridViewArticle.AllowUserToDeleteRows = false;
            this.DataGridViewArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewArticle.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.prixUnitaireHT,
            this.prixUnitaireTTC,
            this.quantiteEnStock,
            this.quantiteVendue,
            this.remise,
            this.punet,
            this.montantHT,
            this.montantTTC});
            this.DataGridViewArticle.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewArticle.Location = new System.Drawing.Point(4, 4);
            this.DataGridViewArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewArticle.Name = "DataGridViewArticle";
            this.DataGridViewArticle.ReadOnly = true;
            this.DataGridViewArticle.RowHeadersVisible = false;
            this.DataGridViewArticle.RowHeadersWidth = 51;
            this.DataGridViewArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewArticle.Size = new System.Drawing.Size(1560, 306);
            this.DataGridViewArticle.TabIndex = 4;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Référence article";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 156;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Désignation";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // prixUnitaireHT
            // 
            this.prixUnitaireHT.DataPropertyName = "prixUnitaireHT";
            this.prixUnitaireHT.HeaderText = "P.U HT";
            this.prixUnitaireHT.MinimumWidth = 6;
            this.prixUnitaireHT.Name = "prixUnitaireHT";
            this.prixUnitaireHT.ReadOnly = true;
            // 
            // prixUnitaireTTC
            // 
            this.prixUnitaireTTC.DataPropertyName = "prixUnitaireTTC";
            this.prixUnitaireTTC.HeaderText = "P.U TTC";
            this.prixUnitaireTTC.MinimumWidth = 6;
            this.prixUnitaireTTC.Name = "prixUnitaireTTC";
            this.prixUnitaireTTC.ReadOnly = true;
            // 
            // quantiteEnStock
            // 
            this.quantiteEnStock.DataPropertyName = "quantiteEnStock";
            this.quantiteEnStock.HeaderText = "Quantité";
            this.quantiteEnStock.MinimumWidth = 6;
            this.quantiteEnStock.Name = "quantiteEnStock";
            this.quantiteEnStock.ReadOnly = true;
            // 
            // quantiteVendue
            // 
            this.quantiteVendue.DataPropertyName = "quantiteVendue";
            this.quantiteVendue.HeaderText = "Conditionnement";
            this.quantiteVendue.MinimumWidth = 6;
            this.quantiteVendue.Name = "quantiteVendue";
            this.quantiteVendue.ReadOnly = true;
            // 
            // remise
            // 
            this.remise.HeaderText = "Remise";
            this.remise.MinimumWidth = 6;
            this.remise.Name = "remise";
            this.remise.ReadOnly = true;
            // 
            // punet
            // 
            this.punet.HeaderText = "P.U. net";
            this.punet.MinimumWidth = 6;
            this.punet.Name = "punet";
            this.punet.ReadOnly = true;
            // 
            // montantHT
            // 
            this.montantHT.HeaderText = "Montant HT";
            this.montantHT.MinimumWidth = 6;
            this.montantHT.Name = "montantHT";
            this.montantHT.ReadOnly = true;
            // 
            // montantTTC
            // 
            this.montantTTC.HeaderText = "Montant TTC";
            this.montantTTC.MinimumWidth = 6;
            this.montantTTC.Name = "montantTTC";
            this.montantTTC.ReadOnly = true;
            // 
            // TableLayoutPanelFooter
            // 
            this.TableLayoutPanelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelFooter.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelFooter.ColumnCount = 2;
            this.TableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.TableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.TableLayoutPanelFooter.Controls.Add(this.PanelEnregistrement, 0, 0);
            this.TableLayoutPanelFooter.Controls.Add(this.PanelCommandDroite, 1, 0);
            this.TableLayoutPanelFooter.Location = new System.Drawing.Point(4, 318);
            this.TableLayoutPanelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanelFooter.Name = "TableLayoutPanelFooter";
            this.TableLayoutPanelFooter.RowCount = 1;
            this.TableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.TableLayoutPanelFooter.Size = new System.Drawing.Size(1560, 333);
            this.TableLayoutPanelFooter.TabIndex = 14;
            // 
            // PanelEnregistrement
            // 
            this.PanelEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelEnregistrement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelEnregistrement.Controls.Add(this.PanelInvisibleEnregistrement);
            this.PanelEnregistrement.Controls.Add(this.DataGridViewEnregistrement);
            this.PanelEnregistrement.Location = new System.Drawing.Point(4, 4);
            this.PanelEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelEnregistrement.Name = "PanelEnregistrement";
            this.PanelEnregistrement.Size = new System.Drawing.Size(842, 325);
            this.PanelEnregistrement.TabIndex = 2;
            // 
            // PanelInvisibleEnregistrement
            // 
            this.PanelInvisibleEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInvisibleEnregistrement.Controls.Add(this.BouttonEnregistrerEnregistrement);
            this.PanelInvisibleEnregistrement.Controls.Add(this.tableLayoutPanel1);
            this.PanelInvisibleEnregistrement.Controls.Add(this.BouttonSupprimerEnregistrement);
            this.PanelInvisibleEnregistrement.Controls.Add(this.BouttonNouveauEnregistrement);
            this.PanelInvisibleEnregistrement.Enabled = false;
            this.PanelInvisibleEnregistrement.Location = new System.Drawing.Point(1, 7);
            this.PanelInvisibleEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelInvisibleEnregistrement.Name = "PanelInvisibleEnregistrement";
            this.PanelInvisibleEnregistrement.Size = new System.Drawing.Size(838, 98);
            this.PanelInvisibleEnregistrement.TabIndex = 17;
            // 
            // BouttonEnregistrerEnregistrement
            // 
            this.BouttonEnregistrerEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonEnregistrerEnregistrement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonEnregistrerEnregistrement.Location = new System.Drawing.Point(698, 59);
            this.BouttonEnregistrerEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonEnregistrerEnregistrement.Name = "BouttonEnregistrerEnregistrement";
            this.BouttonEnregistrerEnregistrement.Palette = this.kryptonPalette1;
            this.BouttonEnregistrerEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonEnregistrerEnregistrement.Size = new System.Drawing.Size(120, 31);
            this.BouttonEnregistrerEnregistrement.TabIndex = 15;
            this.BouttonEnregistrerEnregistrement.Values.Text = "Enregistrer";
            this.BouttonEnregistrerEnregistrement.Click += new System.EventHandler(this.BouttonEnregistrerEnregistrement_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxReglementEnregistrement, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxMontantEnregistrement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxLibelleEnregistrement, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateTimePickerEnregistrement, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxDeviseEnregistrement, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 37);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ComboBoxReglementEnregistrement
            // 
            this.ComboBoxReglementEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxReglementEnregistrement.DropDownHeight = 140;
            this.ComboBoxReglementEnregistrement.DropDownWidth = 120;
            this.ComboBoxReglementEnregistrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxReglementEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxReglementEnregistrement.FormattingEnabled = true;
            this.ComboBoxReglementEnregistrement.IntegralHeight = false;
            this.ComboBoxReglementEnregistrement.ItemHeight = 20;
            this.ComboBoxReglementEnregistrement.Location = new System.Drawing.Point(4, 4);
            this.ComboBoxReglementEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxReglementEnregistrement.Name = "ComboBoxReglementEnregistrement";
            this.ComboBoxReglementEnregistrement.Size = new System.Drawing.Size(155, 28);
            this.ComboBoxReglementEnregistrement.TabIndex = 0;
            // 
            // TextBoxMontantEnregistrement
            // 
            this.TextBoxMontantEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMontantEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMontantEnregistrement.Location = new System.Drawing.Point(167, 4);
            this.TextBoxMontantEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxMontantEnregistrement.Name = "TextBoxMontantEnregistrement";
            this.TextBoxMontantEnregistrement.Size = new System.Drawing.Size(155, 26);
            this.TextBoxMontantEnregistrement.TabIndex = 1;
            this.TextBoxMontantEnregistrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxMontantEnregistrement.TextChanged += new System.EventHandler(this.TextBoxMontantEnregistrement_TextChanged);
            // 
            // TextBoxLibelleEnregistrement
            // 
            this.TextBoxLibelleEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLibelleEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLibelleEnregistrement.Location = new System.Drawing.Point(330, 4);
            this.TextBoxLibelleEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxLibelleEnregistrement.Name = "TextBoxLibelleEnregistrement";
            this.TextBoxLibelleEnregistrement.Size = new System.Drawing.Size(155, 26);
            this.TextBoxLibelleEnregistrement.TabIndex = 2;
            this.TextBoxLibelleEnregistrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DateTimePickerEnregistrement
            // 
            this.DateTimePickerEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerEnregistrement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerEnregistrement.Location = new System.Drawing.Point(656, 4);
            this.DateTimePickerEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePickerEnregistrement.Name = "DateTimePickerEnregistrement";
            this.DateTimePickerEnregistrement.Size = new System.Drawing.Size(159, 26);
            this.DateTimePickerEnregistrement.TabIndex = 4;
            // 
            // ComboBoxDeviseEnregistrement
            // 
            this.ComboBoxDeviseEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDeviseEnregistrement.DropDownHeight = 120;
            this.ComboBoxDeviseEnregistrement.DropDownWidth = 120;
            this.ComboBoxDeviseEnregistrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDeviseEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDeviseEnregistrement.FormattingEnabled = true;
            this.ComboBoxDeviseEnregistrement.IntegralHeight = false;
            this.ComboBoxDeviseEnregistrement.Location = new System.Drawing.Point(493, 4);
            this.ComboBoxDeviseEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxDeviseEnregistrement.Name = "ComboBoxDeviseEnregistrement";
            this.ComboBoxDeviseEnregistrement.Size = new System.Drawing.Size(155, 28);
            this.ComboBoxDeviseEnregistrement.TabIndex = 3;
            this.ComboBoxDeviseEnregistrement.TabStop = false;
            this.ComboBoxDeviseEnregistrement.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeviseEnregistrement_SelectedIndexChanged);
            // 
            // BouttonSupprimerEnregistrement
            // 
            this.BouttonSupprimerEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonSupprimerEnregistrement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonSupprimerEnregistrement.Enabled = false;
            this.BouttonSupprimerEnregistrement.Location = new System.Drawing.Point(546, 59);
            this.BouttonSupprimerEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonSupprimerEnregistrement.Name = "BouttonSupprimerEnregistrement";
            this.BouttonSupprimerEnregistrement.Palette = this.kryptonPalette1;
            this.BouttonSupprimerEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonSupprimerEnregistrement.Size = new System.Drawing.Size(120, 31);
            this.BouttonSupprimerEnregistrement.TabIndex = 14;
            this.BouttonSupprimerEnregistrement.Values.Text = "Supprimer";
            this.BouttonSupprimerEnregistrement.Click += new System.EventHandler(this.BouttonSupprimerEnregistrement_Click);
            // 
            // BouttonNouveauEnregistrement
            // 
            this.BouttonNouveauEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonNouveauEnregistrement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonNouveauEnregistrement.Location = new System.Drawing.Point(392, 59);
            this.BouttonNouveauEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonNouveauEnregistrement.Name = "BouttonNouveauEnregistrement";
            this.BouttonNouveauEnregistrement.Palette = this.kryptonPalette1;
            this.BouttonNouveauEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonNouveauEnregistrement.Size = new System.Drawing.Size(120, 31);
            this.BouttonNouveauEnregistrement.TabIndex = 13;
            this.BouttonNouveauEnregistrement.Values.Text = "Nouveau";
            // 
            // DataGridViewEnregistrement
            // 
            this.DataGridViewEnregistrement.AllowUserToAddRows = false;
            this.DataGridViewEnregistrement.AllowUserToDeleteRows = false;
            this.DataGridViewEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewEnregistrement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEnregistrement.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewEnregistrement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewEnregistrement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewEnregistrement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnregistrement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewEnregistrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEnregistrement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeDeReception,
            this.Montant,
            this.Libelle,
            this.Devise,
            this.DateEcheance});
            this.DataGridViewEnregistrement.Enabled = false;
            this.DataGridViewEnregistrement.Location = new System.Drawing.Point(4, 107);
            this.DataGridViewEnregistrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewEnregistrement.Name = "DataGridViewEnregistrement";
            this.DataGridViewEnregistrement.ReadOnly = true;
            this.DataGridViewEnregistrement.RowHeadersVisible = false;
            this.DataGridViewEnregistrement.RowHeadersWidth = 51;
            this.DataGridViewEnregistrement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewEnregistrement.Size = new System.Drawing.Size(834, 212);
            this.DataGridViewEnregistrement.TabIndex = 1;
            // 
            // ModeDeReception
            // 
            this.ModeDeReception.HeaderText = "Mode de Réception";
            this.ModeDeReception.MinimumWidth = 6;
            this.ModeDeReception.Name = "ModeDeReception";
            this.ModeDeReception.ReadOnly = true;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.MinimumWidth = 6;
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libellé";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Devise
            // 
            this.Devise.HeaderText = "Devise";
            this.Devise.MinimumWidth = 6;
            this.Devise.Name = "Devise";
            this.Devise.ReadOnly = true;
            // 
            // DateEcheance
            // 
            this.DateEcheance.HeaderText = "Date d\'échéance";
            this.DateEcheance.MinimumWidth = 6;
            this.DateEcheance.Name = "DateEcheance";
            this.DateEcheance.ReadOnly = true;
            // 
            // PanelCommandDroite
            // 
            this.PanelCommandDroite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCommandDroite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelCommandDroite.Controls.Add(this.tableLayoutPanel3);
            this.PanelCommandDroite.Location = new System.Drawing.Point(854, 4);
            this.PanelCommandDroite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelCommandDroite.Name = "PanelCommandDroite";
            this.PanelCommandDroite.Size = new System.Drawing.Size(702, 325);
            this.PanelCommandDroite.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.PanelReste, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TableLayoutPanelCommand, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(692, 321);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // PanelReste
            // 
            this.PanelReste.Controls.Add(this.tableLayoutPanel4);
            this.PanelReste.Controls.Add(this.DeviseLabel);
            this.PanelReste.Controls.Add(this.LabelResteDu);
            this.PanelReste.Controls.Add(this.LabelDeviseReste);
            this.PanelReste.Controls.Add(this.LabelPrixResteDu);
            this.PanelReste.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelReste.Location = new System.Drawing.Point(4, 4);
            this.PanelReste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelReste.Name = "PanelReste";
            this.PanelReste.Size = new System.Drawing.Size(684, 121);
            this.PanelReste.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.ComboBoxDeviseReste, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ComboboxSouche, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(181, 76);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 33);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // ComboBoxDeviseReste
            // 
            this.ComboBoxDeviseReste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDeviseReste.DropDownHeight = 100;
            this.ComboBoxDeviseReste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDeviseReste.FormattingEnabled = true;
            this.ComboBoxDeviseReste.IntegralHeight = false;
            this.ComboBoxDeviseReste.Items.AddRange(new object[] {
            "Ariary Malgache",
            "Dollar US",
            "Euro",
            "Franc CFA"});
            this.ComboBoxDeviseReste.Location = new System.Drawing.Point(4, 5);
            this.ComboBoxDeviseReste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxDeviseReste.Name = "ComboBoxDeviseReste";
            this.ComboBoxDeviseReste.Size = new System.Drawing.Size(184, 24);
            this.ComboBoxDeviseReste.TabIndex = 13;
            this.ComboBoxDeviseReste.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeviseReste_SelectedIndexChanged);
            // 
            // ComboboxSouche
            // 
            this.ComboboxSouche.DropDownHeight = 100;
            this.ComboboxSouche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboboxSouche.FormattingEnabled = true;
            this.ComboboxSouche.IntegralHeight = false;
            this.ComboboxSouche.Items.AddRange(new object[] {
            "Ariary Malgache",
            "Dollar US",
            "Euro",
            "Franc CFA"});
            this.ComboboxSouche.Location = new System.Drawing.Point(196, 4);
            this.ComboboxSouche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboboxSouche.Name = "ComboboxSouche";
            this.ComboboxSouche.Size = new System.Drawing.Size(183, 24);
            this.ComboboxSouche.TabIndex = 18;
            this.ComboboxSouche.SelectedValueChanged += new System.EventHandler(this.ComboboxSouche_SelectedValueChanged);
            // 
            // DeviseLabel
            // 
            this.DeviseLabel.AutoSize = true;
            this.DeviseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviseLabel.Location = new System.Drawing.Point(57, 84);
            this.DeviseLabel.Name = "DeviseLabel";
            this.DeviseLabel.Size = new System.Drawing.Size(66, 25);
            this.DeviseLabel.TabIndex = 14;
            this.DeviseLabel.Text = "Devis";
            // 
            // LabelResteDu
            // 
            this.LabelResteDu.AutoSize = true;
            this.LabelResteDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResteDu.Location = new System.Drawing.Point(13, 18);
            this.LabelResteDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelResteDu.Name = "LabelResteDu";
            this.LabelResteDu.Size = new System.Drawing.Size(176, 42);
            this.LabelResteDu.TabIndex = 0;
            this.LabelResteDu.Text = "Reste dû";
            this.LabelResteDu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDeviseReste
            // 
            this.LabelDeviseReste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDeviseReste.AutoSize = true;
            this.LabelDeviseReste.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeviseReste.Location = new System.Drawing.Point(16, 21);
            this.LabelDeviseReste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDeviseReste.Name = "LabelDeviseReste";
            this.LabelDeviseReste.Size = new System.Drawing.Size(67, 25);
            this.LabelDeviseReste.TabIndex = 13;
            this.LabelDeviseReste.Text = "Devise";
            // 
            // LabelPrixResteDu
            // 
            this.LabelPrixResteDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrixResteDu.AutoSize = true;
            this.LabelPrixResteDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrixResteDu.Location = new System.Drawing.Point(396, 21);
            this.LabelPrixResteDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrixResteDu.Name = "LabelPrixResteDu";
            this.LabelPrixResteDu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPrixResteDu.Size = new System.Drawing.Size(95, 42);
            this.LabelPrixResteDu.TabIndex = 17;
            this.LabelPrixResteDu.Text = "0,00";
            this.LabelPrixResteDu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TableLayoutPanelCommand
            // 
            this.TableLayoutPanelCommand.ColumnCount = 3;
            this.TableLayoutPanelCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelCommand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonValider, 2, 2);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonFinDeSaisie, 0, 0);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonCreerDoc, 1, 2);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonAnnuler, 1, 0);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonEnAttente, 2, 1);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonRappelTicket, 0, 2);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonRaccourci, 1, 1);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonFacture, 2, 0);
            this.TableLayoutPanelCommand.Controls.Add(this.BouttonTicket, 0, 1);
            this.TableLayoutPanelCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelCommand.Location = new System.Drawing.Point(4, 164);
            this.TableLayoutPanelCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanelCommand.Name = "TableLayoutPanelCommand";
            this.TableLayoutPanelCommand.RowCount = 3;
            this.TableLayoutPanelCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelCommand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelCommand.Size = new System.Drawing.Size(684, 153);
            this.TableLayoutPanelCommand.TabIndex = 10;
            // 
            // BouttonValider
            // 
            this.BouttonValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonValider.Enabled = false;
            this.BouttonValider.Location = new System.Drawing.Point(459, 104);
            this.BouttonValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Palette = this.kryptonPalette1;
            this.BouttonValider.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonValider.Size = new System.Drawing.Size(221, 45);
            this.BouttonValider.TabIndex = 9;
            this.BouttonValider.Values.Text = "Valider";
            this.BouttonValider.Click += new System.EventHandler(this.BouttonValider_Click);
            // 
            // BouttonFinDeSaisie
            // 
            this.BouttonFinDeSaisie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonFinDeSaisie.Enabled = false;
            this.BouttonFinDeSaisie.Location = new System.Drawing.Point(4, 4);
            this.BouttonFinDeSaisie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonFinDeSaisie.Name = "BouttonFinDeSaisie";
            this.BouttonFinDeSaisie.Palette = this.kryptonPalette1;
            this.BouttonFinDeSaisie.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonFinDeSaisie.Size = new System.Drawing.Size(219, 42);
            this.BouttonFinDeSaisie.TabIndex = 1;
            this.BouttonFinDeSaisie.Values.Text = "Fin de saisie";
            this.BouttonFinDeSaisie.Click += new System.EventHandler(this.BouttonFinDeSaisie_Click);
            // 
            // BouttonCreerDoc
            // 
            this.BouttonCreerDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonCreerDoc.Location = new System.Drawing.Point(231, 104);
            this.BouttonCreerDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonCreerDoc.Name = "BouttonCreerDoc";
            this.BouttonCreerDoc.Palette = this.kryptonPalette1;
            this.BouttonCreerDoc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonCreerDoc.Size = new System.Drawing.Size(220, 45);
            this.BouttonCreerDoc.TabIndex = 8;
            this.BouttonCreerDoc.Values.Text = "Créer doc.";
            // 
            // BouttonAnnuler
            // 
            this.BouttonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonAnnuler.Location = new System.Drawing.Point(231, 4);
            this.BouttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonAnnuler.Name = "BouttonAnnuler";
            this.BouttonAnnuler.Palette = this.kryptonPalette1;
            this.BouttonAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonAnnuler.Size = new System.Drawing.Size(220, 42);
            this.BouttonAnnuler.TabIndex = 2;
            this.BouttonAnnuler.Values.Text = "Annuler";
            this.BouttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // BouttonEnAttente
            // 
            this.BouttonEnAttente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonEnAttente.Enabled = false;
            this.BouttonEnAttente.Location = new System.Drawing.Point(459, 54);
            this.BouttonEnAttente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonEnAttente.Name = "BouttonEnAttente";
            this.BouttonEnAttente.Palette = this.kryptonPalette1;
            this.BouttonEnAttente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonEnAttente.Size = new System.Drawing.Size(221, 42);
            this.BouttonEnAttente.TabIndex = 6;
            this.BouttonEnAttente.Values.Text = "En attente";
            this.BouttonEnAttente.Click += new System.EventHandler(this.BouttonEnAttente_Click);
            // 
            // BouttonRappelTicket
            // 
            this.BouttonRappelTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonRappelTicket.Location = new System.Drawing.Point(4, 104);
            this.BouttonRappelTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonRappelTicket.Name = "BouttonRappelTicket";
            this.BouttonRappelTicket.Palette = this.kryptonPalette1;
            this.BouttonRappelTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonRappelTicket.Size = new System.Drawing.Size(219, 45);
            this.BouttonRappelTicket.TabIndex = 7;
            this.BouttonRappelTicket.Values.Text = "Rappel Ticket";
            this.BouttonRappelTicket.Click += new System.EventHandler(this.BouttonRappelTicket_Click);
            // 
            // BouttonRaccourci
            // 
            this.BouttonRaccourci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonRaccourci.Location = new System.Drawing.Point(231, 54);
            this.BouttonRaccourci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonRaccourci.Name = "BouttonRaccourci";
            this.BouttonRaccourci.Palette = this.kryptonPalette1;
            this.BouttonRaccourci.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonRaccourci.Size = new System.Drawing.Size(220, 42);
            this.BouttonRaccourci.TabIndex = 5;
            this.BouttonRaccourci.Values.Text = "Raccourcis";
            // 
            // BouttonFacture
            // 
            this.BouttonFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonFacture.Enabled = false;
            this.BouttonFacture.Location = new System.Drawing.Point(459, 4);
            this.BouttonFacture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonFacture.Name = "BouttonFacture";
            this.BouttonFacture.Palette = this.kryptonPalette1;
            this.BouttonFacture.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonFacture.Size = new System.Drawing.Size(221, 42);
            this.BouttonFacture.TabIndex = 3;
            this.BouttonFacture.Values.Text = "Facture";
            this.BouttonFacture.Click += new System.EventHandler(this.creation_facture);
            // 
            // BouttonTicket
            // 
            this.BouttonTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonTicket.Enabled = false;
            this.BouttonTicket.Location = new System.Drawing.Point(4, 54);
            this.BouttonTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonTicket.Name = "BouttonTicket";
            this.BouttonTicket.Palette = this.kryptonPalette1;
            this.BouttonTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonTicket.Size = new System.Drawing.Size(219, 42);
            this.BouttonTicket.TabIndex = 4;
            this.BouttonTicket.Values.Text = "Ticket";
            this.BouttonTicket.Click += new System.EventHandler(this.BouttonTicket_Click);
            // 
            // TableLayouotPanelHeader
            // 
            this.TableLayouotPanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayouotPanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.TableLayouotPanelHeader.ColumnCount = 2;
            this.TableLayouotPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.55F));
            this.TableLayouotPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45F));
            this.TableLayouotPanelHeader.Controls.Add(this.PanelTotal, 1, 0);
            this.TableLayouotPanelHeader.Controls.Add(this.TableLayoutPanelInfoCaissier, 0, 0);
            this.TableLayouotPanelHeader.Location = new System.Drawing.Point(25, 15);
            this.TableLayouotPanelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayouotPanelHeader.Name = "TableLayouotPanelHeader";
            this.TableLayouotPanelHeader.RowCount = 1;
            this.TableLayouotPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayouotPanelHeader.Size = new System.Drawing.Size(1568, 183);
            this.TableLayouotPanelHeader.TabIndex = 15;
            // 
            // PanelTotal
            // 
            this.PanelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelTotal.Controls.Add(this.NumTicket);
            this.PanelTotal.Controls.Add(this.LabelPrixTotalTTC);
            this.PanelTotal.Controls.Add(this.LabelMontantlHT);
            this.PanelTotal.Controls.Add(this.LabelPrixTotalHT);
            this.PanelTotal.Controls.Add(this.LabelMontantTTC);
            this.PanelTotal.Location = new System.Drawing.Point(859, 4);
            this.PanelTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelTotal.Name = "PanelTotal";
            this.PanelTotal.Size = new System.Drawing.Size(705, 175);
            this.PanelTotal.TabIndex = 17;
            // 
            // NumTicket
            // 
            this.NumTicket.AutoSize = true;
            this.NumTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTicket.Location = new System.Drawing.Point(465, 25);
            this.NumTicket.Name = "NumTicket";
            this.NumTicket.Size = new System.Drawing.Size(0, 29);
            this.NumTicket.TabIndex = 17;
            // 
            // LabelPrixTotalTTC
            // 
            this.LabelPrixTotalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrixTotalTTC.AutoSize = true;
            this.LabelPrixTotalTTC.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrixTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrixTotalTTC.Location = new System.Drawing.Point(299, 102);
            this.LabelPrixTotalTTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrixTotalTTC.Name = "LabelPrixTotalTTC";
            this.LabelPrixTotalTTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPrixTotalTTC.Size = new System.Drawing.Size(95, 42);
            this.LabelPrixTotalTTC.TabIndex = 16;
            this.LabelPrixTotalTTC.Text = "0,00";
            this.LabelPrixTotalTTC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMontantlHT
            // 
            this.LabelMontantlHT.AutoSize = true;
            this.LabelMontantlHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMontantlHT.Location = new System.Drawing.Point(21, 25);
            this.LabelMontantlHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMontantlHT.Name = "LabelMontantlHT";
            this.LabelMontantlHT.Size = new System.Drawing.Size(70, 42);
            this.LabelMontantlHT.TabIndex = 2;
            this.LabelMontantlHT.Text = "HT";
            // 
            // LabelPrixTotalHT
            // 
            this.LabelPrixTotalHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrixTotalHT.AutoSize = true;
            this.LabelPrixTotalHT.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrixTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrixTotalHT.Location = new System.Drawing.Point(299, 25);
            this.LabelPrixTotalHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrixTotalHT.Name = "LabelPrixTotalHT";
            this.LabelPrixTotalHT.Size = new System.Drawing.Size(95, 42);
            this.LabelPrixTotalHT.TabIndex = 15;
            this.LabelPrixTotalHT.Text = "0,00";
            this.LabelPrixTotalHT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMontantTTC
            // 
            this.LabelMontantTTC.AutoSize = true;
            this.LabelMontantTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMontantTTC.Location = new System.Drawing.Point(21, 102);
            this.LabelMontantTTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMontantTTC.Name = "LabelMontantTTC";
            this.LabelMontantTTC.Size = new System.Drawing.Size(94, 42);
            this.LabelMontantTTC.TabIndex = 3;
            this.LabelMontantTTC.Text = "TTC";
            // 
            // TableLayoutPanelInfoCaissier
            // 
            this.TableLayoutPanelInfoCaissier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TableLayoutPanelInfoCaissier.ColumnCount = 4;
            this.TableLayoutPanelInfoCaissier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.70089F));
            this.TableLayoutPanelInfoCaissier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.54499F));
            this.TableLayoutPanelInfoCaissier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58935F));
            this.TableLayoutPanelInfoCaissier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelNomCaissier, 2, 0);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelTitleCaissier, 3, 0);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelTarif, 0, 2);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelCentrale, 0, 3);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelDate, 0, 0);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.DateTimePickerInfoCaissier, 1, 0);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxNumero, 0, 1);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxType, 1, 1);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxDepot, 1, 2);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxAffaire, 1, 3);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelAffaire, 2, 3);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxCentrale, 3, 3);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelDepot, 2, 2);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxTarif, 3, 2);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.LabelVendeur, 2, 1);
            this.TableLayoutPanelInfoCaissier.Controls.Add(this.ComboBoxVendeur, 3, 1);
            this.TableLayoutPanelInfoCaissier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelInfoCaissier.Location = new System.Drawing.Point(4, 4);
            this.TableLayoutPanelInfoCaissier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanelInfoCaissier.Name = "TableLayoutPanelInfoCaissier";
            this.TableLayoutPanelInfoCaissier.RowCount = 4;
            this.TableLayoutPanelInfoCaissier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanelInfoCaissier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanelInfoCaissier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanelInfoCaissier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanelInfoCaissier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelInfoCaissier.Size = new System.Drawing.Size(847, 175);
            this.TableLayoutPanelInfoCaissier.TabIndex = 15;
            // 
            // LabelNomCaissier
            // 
            this.LabelNomCaissier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNomCaissier.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomCaissier.Location = new System.Drawing.Point(464, 5);
            this.LabelNomCaissier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNomCaissier.Name = "LabelNomCaissier";
            this.LabelNomCaissier.Size = new System.Drawing.Size(115, 33);
            this.LabelNomCaissier.TabIndex = 14;
            this.LabelNomCaissier.Text = "NomCaissierN1";
            this.LabelNomCaissier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTitleCaissier
            // 
            this.LabelTitleCaissier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitleCaissier.AutoSize = true;
            this.LabelTitleCaissier.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleCaissier.Location = new System.Drawing.Point(692, 12);
            this.LabelTitleCaissier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitleCaissier.Name = "LabelTitleCaissier";
            this.LabelTitleCaissier.Size = new System.Drawing.Size(55, 19);
            this.LabelTitleCaissier.TabIndex = 6;
            this.LabelTitleCaissier.Text = "Caissier";
            // 
            // LabelTarif
            // 
            this.LabelTarif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelTarif.AutoSize = true;
            this.LabelTarif.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTarif.Location = new System.Drawing.Point(4, 98);
            this.LabelTarif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTarif.Name = "LabelTarif";
            this.LabelTarif.Size = new System.Drawing.Size(47, 19);
            this.LabelTarif.TabIndex = 9;
            this.LabelTarif.Text = "Dépôt";
            // 
            // LabelCentrale
            // 
            this.LabelCentrale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelCentrale.AutoSize = true;
            this.LabelCentrale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCentrale.Location = new System.Drawing.Point(4, 142);
            this.LabelCentrale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCentrale.Name = "LabelCentrale";
            this.LabelCentrale.Size = new System.Drawing.Size(60, 19);
            this.LabelCentrale.TabIndex = 10;
            this.LabelCentrale.Text = "Centrale";
            // 
            // LabelDate
            // 
            this.LabelDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(4, 12);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(38, 19);
            this.LabelDate.TabIndex = 6;
            this.LabelDate.Text = "Date";
            // 
            // DateTimePickerInfoCaissier
            // 
            this.DateTimePickerInfoCaissier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerInfoCaissier.Enabled = false;
            this.DateTimePickerInfoCaissier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerInfoCaissier.Location = new System.Drawing.Point(205, 8);
            this.DateTimePickerInfoCaissier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePickerInfoCaissier.Name = "DateTimePickerInfoCaissier";
            this.DateTimePickerInfoCaissier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePickerInfoCaissier.Size = new System.Drawing.Size(251, 26);
            this.DateTimePickerInfoCaissier.TabIndex = 13;
            this.DateTimePickerInfoCaissier.Value = new System.DateTime(2024, 2, 21, 10, 37, 44, 0);
            // 
            // ComboBoxNumero
            // 
            this.ComboBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxNumero.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxNumero.FormattingEnabled = true;
            this.ComboBoxNumero.Items.AddRange(new object[] {
            "Numéro",
            "Abrégé",
            "Code postal"});
            this.ComboBoxNumero.Location = new System.Drawing.Point(4, 51);
            this.ComboBoxNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxNumero.Name = "ComboBoxNumero";
            this.ComboBoxNumero.Size = new System.Drawing.Size(193, 27);
            this.ComboBoxNumero.TabIndex = 7;
            this.ComboBoxNumero.Text = "Numéro";
            this.ComboBoxNumero.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNumero_SelectedIndexChanged_1);
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Location = new System.Drawing.Point(205, 51);
            this.ComboBoxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(251, 27);
            this.ComboBoxType.TabIndex = 4;
            this.ComboBoxType.SelectedValueChanged += new System.EventHandler(this.ComboBoxType_SelectedValueChanged);
            // 
            // ComboBoxDepot
            // 
            this.ComboBoxDepot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDepot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDepot.FormattingEnabled = true;
            this.ComboBoxDepot.Location = new System.Drawing.Point(205, 94);
            this.ComboBoxDepot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxDepot.Name = "ComboBoxDepot";
            this.ComboBoxDepot.Size = new System.Drawing.Size(251, 27);
            this.ComboBoxDepot.TabIndex = 5;
            // 
            // ComboBoxAffaire
            // 
            this.ComboBoxAffaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAffaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxAffaire.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAffaire.FormattingEnabled = true;
            this.ComboBoxAffaire.Location = new System.Drawing.Point(205, 138);
            this.ComboBoxAffaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxAffaire.Name = "ComboBoxAffaire";
            this.ComboBoxAffaire.Size = new System.Drawing.Size(251, 27);
            this.ComboBoxAffaire.TabIndex = 6;
            // 
            // LabelAffaire
            // 
            this.LabelAffaire.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelAffaire.AutoSize = true;
            this.LabelAffaire.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAffaire.Location = new System.Drawing.Point(464, 140);
            this.LabelAffaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAffaire.Name = "LabelAffaire";
            this.LabelAffaire.Size = new System.Drawing.Size(59, 23);
            this.LabelAffaire.TabIndex = 12;
            this.LabelAffaire.Text = "Affaire";
            // 
            // ComboBoxCentrale
            // 
            this.ComboBoxCentrale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCentrale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxCentrale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCentrale.FormattingEnabled = true;
            this.ComboBoxCentrale.Location = new System.Drawing.Point(596, 138);
            this.ComboBoxCentrale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxCentrale.Name = "ComboBoxCentrale";
            this.ComboBoxCentrale.Size = new System.Drawing.Size(247, 27);
            this.ComboBoxCentrale.TabIndex = 3;
            this.ComboBoxCentrale.SelectedValueChanged += new System.EventHandler(this.change_tarif);
            // 
            // LabelDepot
            // 
            this.LabelDepot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelDepot.AutoSize = true;
            this.LabelDepot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepot.Location = new System.Drawing.Point(464, 96);
            this.LabelDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDepot.Name = "LabelDepot";
            this.LabelDepot.Size = new System.Drawing.Size(41, 23);
            this.LabelDepot.TabIndex = 11;
            this.LabelDepot.Text = "Tarif";
            // 
            // ComboBoxTarif
            // 
            this.ComboBoxTarif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxTarif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTarif.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTarif.FormattingEnabled = true;
            this.ComboBoxTarif.Location = new System.Drawing.Point(596, 94);
            this.ComboBoxTarif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxTarif.Name = "ComboBoxTarif";
            this.ComboBoxTarif.Size = new System.Drawing.Size(247, 27);
            this.ComboBoxTarif.TabIndex = 2;
            // 
            // LabelVendeur
            // 
            this.LabelVendeur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelVendeur.AutoSize = true;
            this.LabelVendeur.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVendeur.Location = new System.Drawing.Point(464, 55);
            this.LabelVendeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVendeur.Name = "LabelVendeur";
            this.LabelVendeur.Size = new System.Drawing.Size(60, 19);
            this.LabelVendeur.TabIndex = 8;
            this.LabelVendeur.Text = "Vendeur";
            // 
            // ComboBoxVendeur
            // 
            this.ComboBoxVendeur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxVendeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxVendeur.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxVendeur.FormattingEnabled = true;
            this.ComboBoxVendeur.Location = new System.Drawing.Point(596, 51);
            this.ComboBoxVendeur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxVendeur.Name = "ComboBoxVendeur";
            this.ComboBoxVendeur.Size = new System.Drawing.Size(247, 27);
            this.ComboBoxVendeur.TabIndex = 1;
            // 
            // BouttonEnregistrerDesignation
            // 
            this.BouttonEnregistrerDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonEnregistrerDesignation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonEnregistrerDesignation.Enabled = false;
            this.BouttonEnregistrerDesignation.Location = new System.Drawing.Point(1473, 254);
            this.BouttonEnregistrerDesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonEnregistrerDesignation.Name = "BouttonEnregistrerDesignation";
            this.BouttonEnregistrerDesignation.Palette = this.kryptonPalette1;
            this.BouttonEnregistrerDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonEnregistrerDesignation.Size = new System.Drawing.Size(120, 31);
            this.BouttonEnregistrerDesignation.TabIndex = 12;
            this.BouttonEnregistrerDesignation.Values.Text = "Enregistrer";
            this.BouttonEnregistrerDesignation.Click += new System.EventHandler(this.BouttonEnregistrerDesignation_Click);
            // 
            // TableLayoutPanelDesignation
            // 
            this.TableLayoutPanelDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelDesignation.AutoScroll = true;
            this.TableLayoutPanelDesignation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TableLayoutPanelDesignation.ColumnCount = 10;
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxReference, 0, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxDesignation, 1, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxPUHT, 2, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxPUTTC, 3, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxRemise, 6, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxPUnet, 7, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxMontantHT, 8, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxMontantTTC, 9, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxConditionnement, 5, 0);
            this.TableLayoutPanelDesignation.Controls.Add(this.TextBoxQuantiteDisponibleEnStock, 4, 0);
            this.TableLayoutPanelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLayoutPanelDesignation.Location = new System.Drawing.Point(25, 204);
            this.TableLayoutPanelDesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanelDesignation.Name = "TableLayoutPanelDesignation";
            this.TableLayoutPanelDesignation.RowCount = 1;
            this.TableLayoutPanelDesignation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelDesignation.Size = new System.Drawing.Size(1568, 43);
            this.TableLayoutPanelDesignation.TabIndex = 6;
            // 
            // TextBoxReference
            // 
            this.TextBoxReference.AccessibleName = "";
            this.TextBoxReference.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxReference.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxReference.Location = new System.Drawing.Point(4, 4);
            this.TextBoxReference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxReference.Name = "TextBoxReference";
            this.TextBoxReference.Size = new System.Drawing.Size(147, 36);
            this.TextBoxReference.TabIndex = 13;
            this.TextBoxReference.Text = "Référence";
            this.TextBoxReference.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReference_KeyPress);
            this.TextBoxReference.Leave += new System.EventHandler(this.TextBox_Leave);
            this.TextBoxReference.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextBoxReference_PreviewKeyDown);
            // 
            // TextBoxDesignation
            // 
            this.TextBoxDesignation.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDesignation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxDesignation.Location = new System.Drawing.Point(160, 4);
            this.TextBoxDesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxDesignation.Name = "TextBoxDesignation";
            this.TextBoxDesignation.Size = new System.Drawing.Size(147, 36);
            this.TextBoxDesignation.TabIndex = 2;
            this.TextBoxDesignation.Text = "Désignation";
            // 
            // TextBoxPUHT
            // 
            this.TextBoxPUHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPUHT.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBoxPUHT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPUHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPUHT.Location = new System.Drawing.Point(316, 4);
            this.TextBoxPUHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPUHT.Name = "TextBoxPUHT";
            this.TextBoxPUHT.ReadOnly = true;
            this.TextBoxPUHT.Size = new System.Drawing.Size(148, 36);
            this.TextBoxPUHT.TabIndex = 5;
            // 
            // TextBoxPUTTC
            // 
            this.TextBoxPUTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPUTTC.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBoxPUTTC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPUTTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPUTTC.Location = new System.Drawing.Point(472, 4);
            this.TextBoxPUTTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPUTTC.Name = "TextBoxPUTTC";
            this.TextBoxPUTTC.ReadOnly = true;
            this.TextBoxPUTTC.Size = new System.Drawing.Size(148, 36);
            this.TextBoxPUTTC.TabIndex = 6;
            // 
            // TextBoxRemise
            // 
            this.TextBoxRemise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRemise.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRemise.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRemise.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxRemise.Location = new System.Drawing.Point(940, 4);
            this.TextBoxRemise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxRemise.Name = "TextBoxRemise";
            this.TextBoxRemise.Size = new System.Drawing.Size(148, 36);
            this.TextBoxRemise.TabIndex = 14;
            this.TextBoxRemise.TextChanged += new System.EventHandler(this.TextBoxRemise_TextChanged);
            // 
            // TextBoxPUnet
            // 
            this.TextBoxPUnet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPUnet.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBoxPUnet.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPUnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPUnet.Location = new System.Drawing.Point(1096, 4);
            this.TextBoxPUnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPUnet.Name = "TextBoxPUnet";
            this.TextBoxPUnet.ReadOnly = true;
            this.TextBoxPUnet.Size = new System.Drawing.Size(148, 36);
            this.TextBoxPUnet.TabIndex = 15;
            // 
            // TextBoxMontantHT
            // 
            this.TextBoxMontantHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMontantHT.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBoxMontantHT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMontantHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxMontantHT.Location = new System.Drawing.Point(1252, 4);
            this.TextBoxMontantHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxMontantHT.Name = "TextBoxMontantHT";
            this.TextBoxMontantHT.ReadOnly = true;
            this.TextBoxMontantHT.Size = new System.Drawing.Size(148, 36);
            this.TextBoxMontantHT.TabIndex = 16;
            // 
            // TextBoxMontantTTC
            // 
            this.TextBoxMontantTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMontantTTC.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBoxMontantTTC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMontantTTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxMontantTTC.Location = new System.Drawing.Point(1408, 4);
            this.TextBoxMontantTTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxMontantTTC.Name = "TextBoxMontantTTC";
            this.TextBoxMontantTTC.ReadOnly = true;
            this.TextBoxMontantTTC.Size = new System.Drawing.Size(156, 36);
            this.TextBoxMontantTTC.TabIndex = 17;
            // 
            // TextBoxConditionnement
            // 
            this.TextBoxConditionnement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConditionnement.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBoxConditionnement.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxConditionnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxConditionnement.Location = new System.Drawing.Point(784, 4);
            this.TextBoxConditionnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxConditionnement.Name = "TextBoxConditionnement";
            this.TextBoxConditionnement.ReadOnly = true;
            this.TextBoxConditionnement.Size = new System.Drawing.Size(148, 36);
            this.TextBoxConditionnement.TabIndex = 7;
            // 
            // TextBoxQuantiteDisponibleEnStock
            // 
            this.TextBoxQuantiteDisponibleEnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxQuantiteDisponibleEnStock.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQuantiteDisponibleEnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxQuantiteDisponibleEnStock.Location = new System.Drawing.Point(628, 4);
            this.TextBoxQuantiteDisponibleEnStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxQuantiteDisponibleEnStock.Name = "TextBoxQuantiteDisponibleEnStock";
            this.TextBoxQuantiteDisponibleEnStock.Size = new System.Drawing.Size(148, 36);
            this.TextBoxQuantiteDisponibleEnStock.TabIndex = 4;
            this.TextBoxQuantiteDisponibleEnStock.TextChanged += new System.EventHandler(this.TextBoxQuantiteDisponibleEnStock_TextChanged);
            // 
            // BouttonSupprimerDesignation
            // 
            this.BouttonSupprimerDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonSupprimerDesignation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonSupprimerDesignation.Enabled = false;
            this.BouttonSupprimerDesignation.Location = new System.Drawing.Point(1321, 254);
            this.BouttonSupprimerDesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonSupprimerDesignation.Name = "BouttonSupprimerDesignation";
            this.BouttonSupprimerDesignation.Palette = this.kryptonPalette1;
            this.BouttonSupprimerDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonSupprimerDesignation.Size = new System.Drawing.Size(120, 31);
            this.BouttonSupprimerDesignation.TabIndex = 11;
            this.BouttonSupprimerDesignation.Values.Text = "Supprimer";
            this.BouttonSupprimerDesignation.Click += new System.EventHandler(this.BouttonSupprimerDesignation_Click);
            // 
            // BouttonNouveauDesignation
            // 
            this.BouttonNouveauDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonNouveauDesignation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BouttonNouveauDesignation.Location = new System.Drawing.Point(1168, 254);
            this.BouttonNouveauDesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BouttonNouveauDesignation.Name = "BouttonNouveauDesignation";
            this.BouttonNouveauDesignation.Palette = this.kryptonPalette1;
            this.BouttonNouveauDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonNouveauDesignation.Size = new System.Drawing.Size(120, 31);
            this.BouttonNouveauDesignation.TabIndex = 10;
            this.BouttonNouveauDesignation.Values.Text = "Nouveau";
            this.BouttonNouveauDesignation.Click += new System.EventHandler(this.BouttonNouveauDesignation_Click);
            // 
            // pDEVISEBindingSource
            // 
            this.pDEVISEBindingSource.DataMember = "P_DEVISE";
            // 
            // pREGLEMENTBindingSource
            // 
            this.pREGLEMENTBindingSource.DataMember = "P_REGLEMENT";
            // 
            // VenteComptoirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1620, 955);
            this.Controls.Add(this.GroupBoxGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VenteComptoirForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente comptoir";
            this.Load += new System.EventHandler(this.VenteComptoirForm_Load);
            this.Resize += new System.EventHandler(this.VenteComptoirForm_Resize);
            this.GroupBoxGeneral.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArticle)).EndInit();
            this.TableLayoutPanelFooter.ResumeLayout(false);
            this.PanelEnregistrement.ResumeLayout(false);
            this.PanelInvisibleEnregistrement.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnregistrement)).EndInit();
            this.PanelCommandDroite.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.PanelReste.ResumeLayout(false);
            this.PanelReste.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanelCommand.ResumeLayout(false);
            this.TableLayouotPanelHeader.ResumeLayout(false);
            this.PanelTotal.ResumeLayout(false);
            this.PanelTotal.PerformLayout();
            this.TableLayoutPanelInfoCaissier.ResumeLayout(false);
            this.TableLayoutPanelInfoCaissier.PerformLayout();
            this.TableLayoutPanelDesignation.ResumeLayout(false);
            this.TableLayoutPanelDesignation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDEVISEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGLEMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.GroupBox GroupBoxGeneral;
        private System.Windows.Forms.DataGridView DataGridViewArticle;
        private System.Windows.Forms.Label LabelMontantTTC;
        private System.Windows.Forms.Label LabelMontantlHT;
        private System.Windows.Forms.ComboBox ComboBoxAffaire;
        private System.Windows.Forms.ComboBox ComboBoxDepot;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.ComboBox ComboBoxCentrale;
        private System.Windows.Forms.ComboBox ComboBoxTarif;
        private System.Windows.Forms.ComboBox ComboBoxVendeur;
        private System.Windows.Forms.Label LabelAffaire;
        private System.Windows.Forms.Label LabelDepot;
        private System.Windows.Forms.Label LabelCentrale;
        private System.Windows.Forms.Label LabelTarif;
        private System.Windows.Forms.Label LabelVendeur;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ComboBox ComboBoxNumero;
        private System.Windows.Forms.Label LabelTitleCaissier;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelDesignation;
        private System.Windows.Forms.TextBox TextBoxDesignation;
        private System.Windows.Forms.TextBox TextBoxQuantiteDisponibleEnStock;
        private System.Windows.Forms.TextBox TextBoxPUTTC;
        private System.Windows.Forms.TextBox TextBoxConditionnement;
        private KryptonButton BouttonEnregistrerDesignation;
        private KryptonButton BouttonSupprimerDesignation;
        private KryptonButton BouttonNouveauDesignation;
        private System.Windows.Forms.DateTimePicker DateTimePickerInfoCaissier;
        private System.Windows.Forms.Label LabelNomCaissier;
        private System.Windows.Forms.Label LabelPrixTotalTTC;
        private System.Windows.Forms.Label LabelPrixTotalHT;
        private System.Windows.Forms.TextBox TextBoxReference;
        private System.Windows.Forms.DataGridView DataGridViewEnregistrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeDeReception;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devise;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEcheance;
        private KryptonButton BouttonEnregistrerEnregistrement;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnregistrement;
        private KryptonButton BouttonSupprimerEnregistrement;
        private KryptonButton BouttonNouveauEnregistrement;
        private System.Windows.Forms.ComboBox ComboBoxDeviseEnregistrement;
        private System.Windows.Forms.TextBox TextBoxLibelleEnregistrement;
        private System.Windows.Forms.TextBox TextBoxMontantEnregistrement;
        private System.Windows.Forms.ComboBox ComboBoxReglementEnregistrement;
        private System.Windows.Forms.TextBox TextBoxPUHT;
        private System.Windows.Forms.TextBox TextBoxRemise;
        private System.Windows.Forms.TextBox TextBoxPUnet;
        private System.Windows.Forms.TextBox TextBoxMontantHT;
        private System.Windows.Forms.TextBox TextBoxMontantTTC;
        private System.Windows.Forms.BindingSource pREGLEMENTBindingSource;
        private System.Windows.Forms.BindingSource pDEVISEBindingSource;
        //private BIJOUDataSet2TableAdapters.P_DEVISETableAdapter p_DEVISETableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelFooter;
        private System.Windows.Forms.TableLayoutPanel TableLayouotPanelHeader;
        private System.Windows.Forms.Panel PanelTotal;
        private System.Windows.Forms.Panel PanelEnregistrement;
        private System.Windows.Forms.Panel PanelInvisibleEnregistrement;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelInfoCaissier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCommand;
        private KryptonButton BouttonValider;
        private KryptonButton BouttonFinDeSaisie;
        private KryptonButton BouttonCreerDoc;
        private KryptonButton BouttonAnnuler;
        private KryptonButton BouttonEnAttente;
        private KryptonButton BouttonRappelTicket;
        private KryptonButton BouttonRaccourci;
        private KryptonButton BouttonFacture;
        private KryptonButton BouttonTicket;
        private System.Windows.Forms.Panel PanelReste;
        private System.Windows.Forms.Label LabelPrixResteDu;
        private System.Windows.Forms.Label LabelResteDu;
        private System.Windows.Forms.Label LabelDeviseReste;
        private System.Windows.Forms.ComboBox ComboBoxDeviseReste;
        private System.Windows.Forms.Panel PanelCommandDroite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private KryptonDataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteEnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteVendue;
        private System.Windows.Forms.DataGridViewTextBoxColumn remise;
        private System.Windows.Forms.DataGridViewTextBoxColumn punet;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantTTC;
        private System.Windows.Forms.ComboBox ComboboxSouche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label DeviseLabel;
        private System.Windows.Forms.Label NumTicket;
    }
}