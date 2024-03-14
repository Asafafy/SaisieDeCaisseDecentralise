using ComponentFactory.Krypton.Toolkit;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenteComptoirForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.GroupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBoxEnregistrement = new System.Windows.Forms.GroupBox();
            this.DataGridViewEnregistrement = new System.Windows.Forms.DataGridView();
            this.ModeDeReception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEcheance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxInvisibleEnregistrement = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxReglementEnregistrement = new System.Windows.Forms.ComboBox();
            this.TextBoxMontantEnregistrement = new System.Windows.Forms.TextBox();
            this.TextBoxLibelleEnregistrement = new System.Windows.Forms.TextBox();
            this.DateTimePickerEnregistrement = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxDeviseEnregistrement = new System.Windows.Forms.ComboBox();
            this.BouttonEnregistrerEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonSupprimerEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonNouveauEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.GroupBoxCommandDroite = new System.Windows.Forms.GroupBox();
            this.GroupBoxReste = new System.Windows.Forms.GroupBox();
            this.LabelPrixResteDu = new System.Windows.Forms.Label();
            this.LabelDeviseReste = new System.Windows.Forms.Label();
            this.ComboBoxDeviseReste = new System.Windows.Forms.ComboBox();
            this.LabelResteDu = new System.Windows.Forms.Label();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BouttonValider = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonFinDeSaisie = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonCreerDoc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonAnnuler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonEnAttente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonRappelTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonRaccourci = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonFacture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BouttonTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.GroupBoxTotal = new System.Windows.Forms.GroupBox();
            this.LabelPrixTotalTTC = new System.Windows.Forms.Label();
            this.LabelPrixTotalHT = new System.Windows.Forms.Label();
            this.LabelTotalHT = new System.Windows.Forms.Label();
            this.LabelTotalTTC = new System.Windows.Forms.Label();
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
            this.GroupBoxinfoCaissier = new System.Windows.Forms.GroupBox();
            this.LabelNomCaissier = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelTitleCaissier = new System.Windows.Forms.Label();
            this.LabelAffaire = new System.Windows.Forms.Label();
            this.LabelDepot = new System.Windows.Forms.Label();
            this.LabelCentrale = new System.Windows.Forms.Label();
            this.LabelTarif = new System.Windows.Forms.Label();
            this.LabelVendeur = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.ComboBoxNumero = new System.Windows.Forms.ComboBox();
            this.ComboBoxAffaire = new System.Windows.Forms.ComboBox();
            this.ComboBoxDepot = new System.Windows.Forms.ComboBox();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.ComboBoxCentrale = new System.Windows.Forms.ComboBox();
            this.ComboBoxTarif = new System.Windows.Forms.ComboBox();
            this.ComboBoxVendeur = new System.Windows.Forms.ComboBox();
            this.pDEVISEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREGLEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BouttonFermer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.GroupBoxGeneral.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.GroupBoxEnregistrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnregistrement)).BeginInit();
            this.GroupBoxInvisibleEnregistrement.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GroupBoxCommandDroite.SuspendLayout();
            this.GroupBoxReste.SuspendLayout();
            this.groupBoxCommand.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanelDesignation.SuspendLayout();
            this.GroupBoxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArticle)).BeginInit();
            this.GroupBoxinfoCaissier.SuspendLayout();
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
            this.GroupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxGeneral.Controls.Add(this.tableLayoutPanel3);
            this.GroupBoxGeneral.Controls.Add(this.BouttonEnregistrerDesignation);
            this.GroupBoxGeneral.Controls.Add(this.TableLayoutPanelDesignation);
            this.GroupBoxGeneral.Controls.Add(this.BouttonSupprimerDesignation);
            this.GroupBoxGeneral.Controls.Add(this.BouttonNouveauDesignation);
            this.GroupBoxGeneral.Controls.Add(this.GroupBoxTotal);
            this.GroupBoxGeneral.Controls.Add(this.DataGridViewArticle);
            this.GroupBoxGeneral.Controls.Add(this.GroupBoxinfoCaissier);
            this.GroupBoxGeneral.Location = new System.Drawing.Point(-7, 0);
            this.GroupBoxGeneral.Name = "GroupBoxGeneral";
            this.GroupBoxGeneral.Size = new System.Drawing.Size(1126, 743);
            this.GroupBoxGeneral.TabIndex = 0;
            this.GroupBoxGeneral.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel3.Controls.Add(this.GroupBoxEnregistrement, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.GroupBoxCommandDroite, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 462);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1088, 275);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // GroupBoxEnregistrement
            // 
            this.GroupBoxEnregistrement.Controls.Add(this.DataGridViewEnregistrement);
            this.GroupBoxEnregistrement.Controls.Add(this.GroupBoxInvisibleEnregistrement);
            this.GroupBoxEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxEnregistrement.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxEnregistrement.Name = "GroupBoxEnregistrement";
            this.GroupBoxEnregistrement.Size = new System.Drawing.Size(587, 269);
            this.GroupBoxEnregistrement.TabIndex = 2;
            this.GroupBoxEnregistrement.TabStop = false;
            // 
            // DataGridViewEnregistrement
            // 
            this.DataGridViewEnregistrement.AllowUserToAddRows = false;
            this.DataGridViewEnregistrement.AllowUserToDeleteRows = false;
            this.DataGridViewEnregistrement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEnregistrement.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewEnregistrement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewEnregistrement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEnregistrement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewEnregistrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEnregistrement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeDeReception,
            this.Montant,
            this.Libelle,
            this.Devise,
            this.DateEcheance});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewEnregistrement.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewEnregistrement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewEnregistrement.Enabled = false;
            this.DataGridViewEnregistrement.Location = new System.Drawing.Point(3, 89);
            this.DataGridViewEnregistrement.Name = "DataGridViewEnregistrement";
            this.DataGridViewEnregistrement.ReadOnly = true;
            this.DataGridViewEnregistrement.RowHeadersVisible = false;
            this.DataGridViewEnregistrement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewEnregistrement.Size = new System.Drawing.Size(581, 177);
            this.DataGridViewEnregistrement.TabIndex = 1;
            // 
            // ModeDeReception
            // 
            this.ModeDeReception.HeaderText = "Mode de Réception";
            this.ModeDeReception.Name = "ModeDeReception";
            this.ModeDeReception.ReadOnly = true;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libellé";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Devise
            // 
            this.Devise.HeaderText = "Devise";
            this.Devise.Name = "Devise";
            this.Devise.ReadOnly = true;
            // 
            // DateEcheance
            // 
            this.DateEcheance.HeaderText = "Date d\'échéance";
            this.DateEcheance.Name = "DateEcheance";
            this.DateEcheance.ReadOnly = true;
            // 
            // GroupBoxInvisibleEnregistrement
            // 
            this.GroupBoxInvisibleEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxInvisibleEnregistrement.Controls.Add(this.tableLayoutPanel1);
            this.GroupBoxInvisibleEnregistrement.Controls.Add(this.BouttonEnregistrerEnregistrement);
            this.GroupBoxInvisibleEnregistrement.Controls.Add(this.BouttonSupprimerEnregistrement);
            this.GroupBoxInvisibleEnregistrement.Controls.Add(this.BouttonNouveauEnregistrement);
            this.GroupBoxInvisibleEnregistrement.Location = new System.Drawing.Point(3, 11);
            this.GroupBoxInvisibleEnregistrement.Name = "GroupBoxInvisibleEnregistrement";
            this.GroupBoxInvisibleEnregistrement.Size = new System.Drawing.Size(581, 80);
            this.GroupBoxInvisibleEnregistrement.TabIndex = 0;
            this.GroupBoxInvisibleEnregistrement.TabStop = false;
            this.GroupBoxInvisibleEnregistrement.Visible = false;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 30);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ComboBoxReglementEnregistrement
            // 
            this.ComboBoxReglementEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxReglementEnregistrement.DropDownHeight = 140;
            this.ComboBoxReglementEnregistrement.DropDownWidth = 120;
            this.ComboBoxReglementEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxReglementEnregistrement.FormattingEnabled = true;
            this.ComboBoxReglementEnregistrement.IntegralHeight = false;
            this.ComboBoxReglementEnregistrement.ItemHeight = 16;
            this.ComboBoxReglementEnregistrement.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxReglementEnregistrement.Name = "ComboBoxReglementEnregistrement";
            this.ComboBoxReglementEnregistrement.Size = new System.Drawing.Size(108, 24);
            this.ComboBoxReglementEnregistrement.TabIndex = 0;
            // 
            // TextBoxMontantEnregistrement
            // 
            this.TextBoxMontantEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMontantEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMontantEnregistrement.Location = new System.Drawing.Point(117, 3);
            this.TextBoxMontantEnregistrement.Name = "TextBoxMontantEnregistrement";
            this.TextBoxMontantEnregistrement.Size = new System.Drawing.Size(108, 23);
            this.TextBoxMontantEnregistrement.TabIndex = 1;
            this.TextBoxMontantEnregistrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxMontantEnregistrement.TextChanged += new System.EventHandler(this.TextBoxMontantEnregistrement_TextChanged);
            // 
            // TextBoxLibelleEnregistrement
            // 
            this.TextBoxLibelleEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLibelleEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLibelleEnregistrement.Location = new System.Drawing.Point(231, 3);
            this.TextBoxLibelleEnregistrement.Name = "TextBoxLibelleEnregistrement";
            this.TextBoxLibelleEnregistrement.Size = new System.Drawing.Size(108, 23);
            this.TextBoxLibelleEnregistrement.TabIndex = 2;
            this.TextBoxLibelleEnregistrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DateTimePickerEnregistrement
            // 
            this.DateTimePickerEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerEnregistrement.Location = new System.Drawing.Point(459, 3);
            this.DateTimePickerEnregistrement.Name = "DateTimePickerEnregistrement";
            this.DateTimePickerEnregistrement.Size = new System.Drawing.Size(111, 23);
            this.DateTimePickerEnregistrement.TabIndex = 4;
            // 
            // ComboBoxDeviseEnregistrement
            // 
            this.ComboBoxDeviseEnregistrement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDeviseEnregistrement.DropDownHeight = 120;
            this.ComboBoxDeviseEnregistrement.DropDownWidth = 120;
            this.ComboBoxDeviseEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDeviseEnregistrement.FormattingEnabled = true;
            this.ComboBoxDeviseEnregistrement.IntegralHeight = false;
            this.ComboBoxDeviseEnregistrement.Location = new System.Drawing.Point(345, 3);
            this.ComboBoxDeviseEnregistrement.Name = "ComboBoxDeviseEnregistrement";
            this.ComboBoxDeviseEnregistrement.Size = new System.Drawing.Size(108, 24);
            this.ComboBoxDeviseEnregistrement.TabIndex = 3;
            this.ComboBoxDeviseEnregistrement.TabStop = false;
            this.ComboBoxDeviseEnregistrement.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeviseEnregistrement_SelectedIndexChanged);
            // 
            // BouttonEnregistrerEnregistrement
            // 
            this.BouttonEnregistrerEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonEnregistrerEnregistrement.Location = new System.Drawing.Point(485, 47);
            this.BouttonEnregistrerEnregistrement.Name = "BouttonEnregistrerEnregistrement";
            this.BouttonEnregistrerEnregistrement.Palette = this.kryptonPalette1;
            this.BouttonEnregistrerEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonEnregistrerEnregistrement.Size = new System.Drawing.Size(90, 25);
            this.BouttonEnregistrerEnregistrement.TabIndex = 15;
            this.BouttonEnregistrerEnregistrement.Values.Text = "Enregistrer";
            this.BouttonEnregistrerEnregistrement.Click += new System.EventHandler(this.BouttonEnregistrerEnregistrement_Click);
            // 
            // BouttonSupprimerEnregistrement
            // 
            this.BouttonSupprimerEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonSupprimerEnregistrement.Enabled = false;
            this.BouttonSupprimerEnregistrement.Location = new System.Drawing.Point(371, 47);
            this.BouttonSupprimerEnregistrement.Name = "BouttonSupprimerEnregistrement";
            this.BouttonSupprimerEnregistrement.Palette = this.kryptonPalette1;
            this.BouttonSupprimerEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonSupprimerEnregistrement.Size = new System.Drawing.Size(90, 25);
            this.BouttonSupprimerEnregistrement.TabIndex = 14;
            this.BouttonSupprimerEnregistrement.Values.Text = "Supprimer";
            this.BouttonSupprimerEnregistrement.Click += new System.EventHandler(this.BouttonSupprimerEnregistrement_Click);
            // 
            // BouttonNouveauEnregistrement
            // 
            this.BouttonNouveauEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonNouveauEnregistrement.Location = new System.Drawing.Point(256, 47);
            this.BouttonNouveauEnregistrement.Name = "BouttonNouveauEnregistrement";
            this.BouttonNouveauEnregistrement.Palette = this.kryptonPalette1;
            this.BouttonNouveauEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonNouveauEnregistrement.Size = new System.Drawing.Size(90, 25);
            this.BouttonNouveauEnregistrement.TabIndex = 13;
            this.BouttonNouveauEnregistrement.Values.Text = "Nouveau";
            // 
            // GroupBoxCommandDroite
            // 
            this.GroupBoxCommandDroite.Controls.Add(this.GroupBoxReste);
            this.GroupBoxCommandDroite.Controls.Add(this.groupBoxCommand);
            this.GroupBoxCommandDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxCommandDroite.Location = new System.Drawing.Point(596, 3);
            this.GroupBoxCommandDroite.Name = "GroupBoxCommandDroite";
            this.GroupBoxCommandDroite.Size = new System.Drawing.Size(489, 269);
            this.GroupBoxCommandDroite.TabIndex = 13;
            this.GroupBoxCommandDroite.TabStop = false;
            // 
            // GroupBoxReste
            // 
            this.GroupBoxReste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxReste.Controls.Add(this.LabelPrixResteDu);
            this.GroupBoxReste.Controls.Add(this.LabelDeviseReste);
            this.GroupBoxReste.Controls.Add(this.ComboBoxDeviseReste);
            this.GroupBoxReste.Controls.Add(this.LabelResteDu);
            this.GroupBoxReste.Location = new System.Drawing.Point(6, 11);
            this.GroupBoxReste.Name = "GroupBoxReste";
            this.GroupBoxReste.Size = new System.Drawing.Size(477, 112);
            this.GroupBoxReste.TabIndex = 2;
            this.GroupBoxReste.TabStop = false;
            // 
            // LabelPrixResteDu
            // 
            this.LabelPrixResteDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrixResteDu.AutoSize = true;
            this.LabelPrixResteDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrixResteDu.Location = new System.Drawing.Point(279, 13);
            this.LabelPrixResteDu.Name = "LabelPrixResteDu";
            this.LabelPrixResteDu.Size = new System.Drawing.Size(71, 31);
            this.LabelPrixResteDu.TabIndex = 17;
            this.LabelPrixResteDu.Text = "0,00";
            this.LabelPrixResteDu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelDeviseReste
            // 
            this.LabelDeviseReste.AutoSize = true;
            this.LabelDeviseReste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeviseReste.Location = new System.Drawing.Point(8, 74);
            this.LabelDeviseReste.Name = "LabelDeviseReste";
            this.LabelDeviseReste.Size = new System.Drawing.Size(51, 17);
            this.LabelDeviseReste.TabIndex = 13;
            this.LabelDeviseReste.Text = "Devise";
            // 
            // ComboBoxDeviseReste
            // 
            this.ComboBoxDeviseReste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDeviseReste.FormattingEnabled = true;
            this.ComboBoxDeviseReste.Items.AddRange(new object[] {
            "Ariary Malgache",
            "Dollar US",
            "Euro",
            "Franc CFA"});
            this.ComboBoxDeviseReste.Location = new System.Drawing.Point(285, 74);
            this.ComboBoxDeviseReste.Name = "ComboBoxDeviseReste";
            this.ComboBoxDeviseReste.Size = new System.Drawing.Size(351, 21);
            this.ComboBoxDeviseReste.TabIndex = 13;
            // 
            // LabelResteDu
            // 
            this.LabelResteDu.AutoSize = true;
            this.LabelResteDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResteDu.Location = new System.Drawing.Point(6, 16);
            this.LabelResteDu.Name = "LabelResteDu";
            this.LabelResteDu.Size = new System.Drawing.Size(117, 29);
            this.LabelResteDu.TabIndex = 0;
            this.LabelResteDu.Text = "Reste dû";
            this.LabelResteDu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommand.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxCommand.Location = new System.Drawing.Point(6, 129);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Size = new System.Drawing.Size(483, 132);
            this.groupBoxCommand.TabIndex = 3;
            this.groupBoxCommand.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.BouttonValider, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.BouttonFinDeSaisie, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BouttonCreerDoc, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BouttonAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BouttonEnAttente, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BouttonRappelTicket, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BouttonRaccourci, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BouttonFacture, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BouttonTicket, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 113);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // BouttonValider
            // 
            this.BouttonValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonValider.Enabled = false;
            this.BouttonValider.Location = new System.Drawing.Point(320, 77);
            this.BouttonValider.Name = "BouttonValider";
            this.BouttonValider.Palette = this.kryptonPalette1;
            this.BouttonValider.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonValider.Size = new System.Drawing.Size(154, 33);
            this.BouttonValider.TabIndex = 9;
            this.BouttonValider.Values.Text = "Valider";
            this.BouttonValider.Click += new System.EventHandler(this.BouttonValider_Click);
            // 
            // BouttonFinDeSaisie
            // 
            this.BouttonFinDeSaisie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonFinDeSaisie.Enabled = false;
            this.BouttonFinDeSaisie.Location = new System.Drawing.Point(3, 3);
            this.BouttonFinDeSaisie.Name = "BouttonFinDeSaisie";
            this.BouttonFinDeSaisie.Palette = this.kryptonPalette1;
            this.BouttonFinDeSaisie.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonFinDeSaisie.Size = new System.Drawing.Size(152, 31);
            this.BouttonFinDeSaisie.TabIndex = 1;
            this.BouttonFinDeSaisie.Values.Text = "Fin de saisie";
            this.BouttonFinDeSaisie.Click += new System.EventHandler(this.BouttonFinDeSaisie_Click);
            // 
            // BouttonCreerDoc
            // 
            this.BouttonCreerDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonCreerDoc.Location = new System.Drawing.Point(161, 77);
            this.BouttonCreerDoc.Name = "BouttonCreerDoc";
            this.BouttonCreerDoc.Palette = this.kryptonPalette1;
            this.BouttonCreerDoc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonCreerDoc.Size = new System.Drawing.Size(153, 33);
            this.BouttonCreerDoc.TabIndex = 8;
            this.BouttonCreerDoc.Values.Text = "Créer doc.";
            // 
            // BouttonAnnuler
            // 
            this.BouttonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonAnnuler.Location = new System.Drawing.Point(161, 3);
            this.BouttonAnnuler.Name = "BouttonAnnuler";
            this.BouttonAnnuler.Palette = this.kryptonPalette1;
            this.BouttonAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonAnnuler.Size = new System.Drawing.Size(153, 31);
            this.BouttonAnnuler.TabIndex = 2;
            this.BouttonAnnuler.Values.Text = "Annuler";
            this.BouttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // BouttonEnAttente
            // 
            this.BouttonEnAttente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonEnAttente.Enabled = false;
            this.BouttonEnAttente.Location = new System.Drawing.Point(320, 40);
            this.BouttonEnAttente.Name = "BouttonEnAttente";
            this.BouttonEnAttente.Palette = this.kryptonPalette1;
            this.BouttonEnAttente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonEnAttente.Size = new System.Drawing.Size(154, 31);
            this.BouttonEnAttente.TabIndex = 6;
            this.BouttonEnAttente.Values.Text = "En attente";
            // 
            // BouttonRappelTicket
            // 
            this.BouttonRappelTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonRappelTicket.Location = new System.Drawing.Point(3, 77);
            this.BouttonRappelTicket.Name = "BouttonRappelTicket";
            this.BouttonRappelTicket.Palette = this.kryptonPalette1;
            this.BouttonRappelTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonRappelTicket.Size = new System.Drawing.Size(152, 33);
            this.BouttonRappelTicket.TabIndex = 7;
            this.BouttonRappelTicket.Values.Text = "Rappel Ticket";
            // 
            // BouttonRaccourci
            // 
            this.BouttonRaccourci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonRaccourci.Location = new System.Drawing.Point(161, 40);
            this.BouttonRaccourci.Name = "BouttonRaccourci";
            this.BouttonRaccourci.Palette = this.kryptonPalette1;
            this.BouttonRaccourci.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonRaccourci.Size = new System.Drawing.Size(153, 31);
            this.BouttonRaccourci.TabIndex = 5;
            this.BouttonRaccourci.Values.Text = "Raccourcis";
            // 
            // BouttonFacture
            // 
            this.BouttonFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonFacture.Enabled = false;
            this.BouttonFacture.Location = new System.Drawing.Point(320, 3);
            this.BouttonFacture.Name = "BouttonFacture";
            this.BouttonFacture.Palette = this.kryptonPalette1;
            this.BouttonFacture.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonFacture.Size = new System.Drawing.Size(154, 31);
            this.BouttonFacture.TabIndex = 3;
            this.BouttonFacture.Values.Text = "Facture";
            // 
            // BouttonTicket
            // 
            this.BouttonTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BouttonTicket.Enabled = false;
            this.BouttonTicket.Location = new System.Drawing.Point(3, 40);
            this.BouttonTicket.Name = "BouttonTicket";
            this.BouttonTicket.Palette = this.kryptonPalette1;
            this.BouttonTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonTicket.Size = new System.Drawing.Size(152, 31);
            this.BouttonTicket.TabIndex = 4;
            this.BouttonTicket.Values.Text = "Ticket";
            // 
            // BouttonEnregistrerDesignation
            // 
            this.BouttonEnregistrerDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonEnregistrerDesignation.Enabled = false;
            this.BouttonEnregistrerDesignation.Location = new System.Drawing.Point(1017, 206);
            this.BouttonEnregistrerDesignation.Name = "BouttonEnregistrerDesignation";
            this.BouttonEnregistrerDesignation.Palette = this.kryptonPalette1;
            this.BouttonEnregistrerDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonEnregistrerDesignation.Size = new System.Drawing.Size(90, 25);
            this.BouttonEnregistrerDesignation.TabIndex = 12;
            this.BouttonEnregistrerDesignation.Values.Text = "Enregistrer";
            this.BouttonEnregistrerDesignation.Click += new System.EventHandler(this.BouttonEnregistrerDesignation_Click);
            // 
            // TableLayoutPanelDesignation
            // 
            this.TableLayoutPanelDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelDesignation.AutoScroll = true;
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
            this.TableLayoutPanelDesignation.Location = new System.Drawing.Point(19, 167);
            this.TableLayoutPanelDesignation.Name = "TableLayoutPanelDesignation";
            this.TableLayoutPanelDesignation.RowCount = 1;
            this.TableLayoutPanelDesignation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelDesignation.Size = new System.Drawing.Size(1088, 31);
            this.TableLayoutPanelDesignation.TabIndex = 6;
            // 
            // TextBoxReference
            // 
            this.TextBoxReference.AccessibleName = "";
            this.TextBoxReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxReference.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxReference.Location = new System.Drawing.Point(3, 3);
            this.TextBoxReference.Name = "TextBoxReference";
            this.TextBoxReference.Size = new System.Drawing.Size(102, 25);
            this.TextBoxReference.TabIndex = 13;
            this.TextBoxReference.Text = "Référence";
            this.TextBoxReference.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReference_KeyPress);
            this.TextBoxReference.Leave += new System.EventHandler(this.TextBox_Leave);
            this.TextBoxReference.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextBoxReference_PreviewKeyDown);
            // 
            // TextBoxDesignation
            // 
            this.TextBoxDesignation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDesignation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxDesignation.Location = new System.Drawing.Point(111, 3);
            this.TextBoxDesignation.Name = "TextBoxDesignation";
            this.TextBoxDesignation.Size = new System.Drawing.Size(102, 25);
            this.TextBoxDesignation.TabIndex = 2;
            this.TextBoxDesignation.Text = "Désignation";
            // 
            // TextBoxPUHT
            // 
            this.TextBoxPUHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPUHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPUHT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxPUHT.Location = new System.Drawing.Point(219, 3);
            this.TextBoxPUHT.Name = "TextBoxPUHT";
            this.TextBoxPUHT.ReadOnly = true;
            this.TextBoxPUHT.Size = new System.Drawing.Size(102, 25);
            this.TextBoxPUHT.TabIndex = 5;
            // 
            // TextBoxPUTTC
            // 
            this.TextBoxPUTTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPUTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPUTTC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxPUTTC.Location = new System.Drawing.Point(327, 3);
            this.TextBoxPUTTC.Name = "TextBoxPUTTC";
            this.TextBoxPUTTC.ReadOnly = true;
            this.TextBoxPUTTC.Size = new System.Drawing.Size(102, 25);
            this.TextBoxPUTTC.TabIndex = 6;
            // 
            // TextBoxRemise
            // 
            this.TextBoxRemise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxRemise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRemise.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxRemise.Location = new System.Drawing.Point(651, 3);
            this.TextBoxRemise.Name = "TextBoxRemise";
            this.TextBoxRemise.ReadOnly = true;
            this.TextBoxRemise.Size = new System.Drawing.Size(102, 25);
            this.TextBoxRemise.TabIndex = 14;
            // 
            // TextBoxPUnet
            // 
            this.TextBoxPUnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPUnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPUnet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxPUnet.Location = new System.Drawing.Point(759, 3);
            this.TextBoxPUnet.Name = "TextBoxPUnet";
            this.TextBoxPUnet.ReadOnly = true;
            this.TextBoxPUnet.Size = new System.Drawing.Size(102, 25);
            this.TextBoxPUnet.TabIndex = 15;
            // 
            // TextBoxMontantHT
            // 
            this.TextBoxMontantHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMontantHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMontantHT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxMontantHT.Location = new System.Drawing.Point(867, 3);
            this.TextBoxMontantHT.Name = "TextBoxMontantHT";
            this.TextBoxMontantHT.ReadOnly = true;
            this.TextBoxMontantHT.Size = new System.Drawing.Size(102, 25);
            this.TextBoxMontantHT.TabIndex = 16;
            // 
            // TextBoxMontantTTC
            // 
            this.TextBoxMontantTTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMontantTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMontantTTC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxMontantTTC.Location = new System.Drawing.Point(975, 3);
            this.TextBoxMontantTTC.Name = "TextBoxMontantTTC";
            this.TextBoxMontantTTC.ReadOnly = true;
            this.TextBoxMontantTTC.Size = new System.Drawing.Size(110, 25);
            this.TextBoxMontantTTC.TabIndex = 17;
            // 
            // TextBoxConditionnement
            // 
            this.TextBoxConditionnement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxConditionnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxConditionnement.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxConditionnement.Location = new System.Drawing.Point(543, 3);
            this.TextBoxConditionnement.Name = "TextBoxConditionnement";
            this.TextBoxConditionnement.ReadOnly = true;
            this.TextBoxConditionnement.Size = new System.Drawing.Size(102, 25);
            this.TextBoxConditionnement.TabIndex = 7;
            // 
            // TextBoxQuantiteDisponibleEnStock
            // 
            this.TextBoxQuantiteDisponibleEnStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxQuantiteDisponibleEnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQuantiteDisponibleEnStock.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBoxQuantiteDisponibleEnStock.Location = new System.Drawing.Point(435, 3);
            this.TextBoxQuantiteDisponibleEnStock.Name = "TextBoxQuantiteDisponibleEnStock";
            this.TextBoxQuantiteDisponibleEnStock.Size = new System.Drawing.Size(102, 25);
            this.TextBoxQuantiteDisponibleEnStock.TabIndex = 4;
            this.TextBoxQuantiteDisponibleEnStock.TextChanged += new System.EventHandler(this.TextBoxQuantiteDisponibleEnStock_TextChanged);
            // 
            // BouttonSupprimerDesignation
            // 
            this.BouttonSupprimerDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonSupprimerDesignation.Enabled = false;
            this.BouttonSupprimerDesignation.Location = new System.Drawing.Point(903, 206);
            this.BouttonSupprimerDesignation.Name = "BouttonSupprimerDesignation";
            this.BouttonSupprimerDesignation.Palette = this.kryptonPalette1;
            this.BouttonSupprimerDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonSupprimerDesignation.Size = new System.Drawing.Size(90, 25);
            this.BouttonSupprimerDesignation.TabIndex = 11;
            this.BouttonSupprimerDesignation.Values.Text = "Supprimer";
            this.BouttonSupprimerDesignation.Click += new System.EventHandler(this.BouttonSupprimerDesignation_Click);
            // 
            // BouttonNouveauDesignation
            // 
            this.BouttonNouveauDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonNouveauDesignation.Location = new System.Drawing.Point(788, 206);
            this.BouttonNouveauDesignation.Name = "BouttonNouveauDesignation";
            this.BouttonNouveauDesignation.Palette = this.kryptonPalette1;
            this.BouttonNouveauDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonNouveauDesignation.Size = new System.Drawing.Size(90, 25);
            this.BouttonNouveauDesignation.TabIndex = 10;
            this.BouttonNouveauDesignation.Values.Text = "Nouveau";
            this.BouttonNouveauDesignation.Click += new System.EventHandler(this.BouttonNouveauDesignation_Click);
            // 
            // GroupBoxTotal
            // 
            this.GroupBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxTotal.Controls.Add(this.LabelPrixTotalTTC);
            this.GroupBoxTotal.Controls.Add(this.LabelPrixTotalHT);
            this.GroupBoxTotal.Controls.Add(this.LabelTotalHT);
            this.GroupBoxTotal.Controls.Add(this.LabelTotalTTC);
            this.GroupBoxTotal.Location = new System.Drawing.Point(574, 12);
            this.GroupBoxTotal.Name = "GroupBoxTotal";
            this.GroupBoxTotal.Size = new System.Drawing.Size(533, 149);
            this.GroupBoxTotal.TabIndex = 5;
            this.GroupBoxTotal.TabStop = false;
            // 
            // LabelPrixTotalTTC
            // 
            this.LabelPrixTotalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrixTotalTTC.AutoSize = true;
            this.LabelPrixTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrixTotalTTC.Location = new System.Drawing.Point(335, 102);
            this.LabelPrixTotalTTC.Name = "LabelPrixTotalTTC";
            this.LabelPrixTotalTTC.Size = new System.Drawing.Size(71, 31);
            this.LabelPrixTotalTTC.TabIndex = 16;
            this.LabelPrixTotalTTC.Text = "0,00";
            this.LabelPrixTotalTTC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPrixTotalHT
            // 
            this.LabelPrixTotalHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrixTotalHT.AutoSize = true;
            this.LabelPrixTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrixTotalHT.Location = new System.Drawing.Point(335, 39);
            this.LabelPrixTotalHT.Name = "LabelPrixTotalHT";
            this.LabelPrixTotalHT.Size = new System.Drawing.Size(71, 31);
            this.LabelPrixTotalHT.TabIndex = 15;
            this.LabelPrixTotalHT.Text = "0,00";
            this.LabelPrixTotalHT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelTotalHT
            // 
            this.LabelTotalHT.AutoSize = true;
            this.LabelTotalHT.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalHT.Location = new System.Drawing.Point(6, 34);
            this.LabelTotalHT.Name = "LabelTotalHT";
            this.LabelTotalHT.Size = new System.Drawing.Size(127, 31);
            this.LabelTotalHT.TabIndex = 2;
            this.LabelTotalHT.Text = "Total HT";
            // 
            // LabelTotalTTC
            // 
            this.LabelTotalTTC.AutoSize = true;
            this.LabelTotalTTC.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalTTC.Location = new System.Drawing.Point(6, 97);
            this.LabelTotalTTC.Name = "LabelTotalTTC";
            this.LabelTotalTTC.Size = new System.Drawing.Size(145, 31);
            this.LabelTotalTTC.TabIndex = 3;
            this.LabelTotalTTC.Text = "Total TTC";
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
            this.DataGridViewArticle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewArticle.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewArticle.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewArticle.Location = new System.Drawing.Point(19, 237);
            this.DataGridViewArticle.Name = "DataGridViewArticle";
            this.DataGridViewArticle.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewArticle.RowHeadersVisible = false;
            this.DataGridViewArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewArticle.Size = new System.Drawing.Size(1088, 219);
            this.DataGridViewArticle.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Référence article";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 109;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // prixUnitaireHT
            // 
            this.prixUnitaireHT.DataPropertyName = "prixUnitaireHT";
            this.prixUnitaireHT.HeaderText = "P.U HT";
            this.prixUnitaireHT.Name = "prixUnitaireHT";
            this.prixUnitaireHT.ReadOnly = true;
            // 
            // prixUnitaireTTC
            // 
            this.prixUnitaireTTC.DataPropertyName = "prixUnitaireTTC";
            this.prixUnitaireTTC.HeaderText = "P.U TTC";
            this.prixUnitaireTTC.Name = "prixUnitaireTTC";
            this.prixUnitaireTTC.ReadOnly = true;
            // 
            // quantiteEnStock
            // 
            this.quantiteEnStock.DataPropertyName = "quantiteEnStock";
            this.quantiteEnStock.HeaderText = "Quantité Disponible";
            this.quantiteEnStock.Name = "quantiteEnStock";
            this.quantiteEnStock.ReadOnly = true;
            // 
            // quantiteVendue
            // 
            this.quantiteVendue.DataPropertyName = "quantiteVendue";
            this.quantiteVendue.HeaderText = "Conditionnement";
            this.quantiteVendue.Name = "quantiteVendue";
            this.quantiteVendue.ReadOnly = true;
            // 
            // remise
            // 
            this.remise.HeaderText = "Remise";
            this.remise.Name = "remise";
            this.remise.ReadOnly = true;
            // 
            // punet
            // 
            this.punet.HeaderText = "P.U. net";
            this.punet.Name = "punet";
            this.punet.ReadOnly = true;
            // 
            // montantHT
            // 
            this.montantHT.HeaderText = "Montant HT";
            this.montantHT.Name = "montantHT";
            this.montantHT.ReadOnly = true;
            // 
            // montantTTC
            // 
            this.montantTTC.HeaderText = "Montant TTC";
            this.montantTTC.Name = "montantTTC";
            this.montantTTC.ReadOnly = true;
            // 
            // GroupBoxinfoCaissier
            // 
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelNomCaissier);
            this.GroupBoxinfoCaissier.Controls.Add(this.DateTimePicker1);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelTitleCaissier);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelAffaire);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelDepot);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelCentrale);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelTarif);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelVendeur);
            this.GroupBoxinfoCaissier.Controls.Add(this.LabelDate);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxNumero);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxAffaire);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxDepot);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxType);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxCentrale);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxTarif);
            this.GroupBoxinfoCaissier.Controls.Add(this.ComboBoxVendeur);
            this.GroupBoxinfoCaissier.Location = new System.Drawing.Point(19, 12);
            this.GroupBoxinfoCaissier.Name = "GroupBoxinfoCaissier";
            this.GroupBoxinfoCaissier.Size = new System.Drawing.Size(549, 149);
            this.GroupBoxinfoCaissier.TabIndex = 0;
            this.GroupBoxinfoCaissier.TabStop = false;
            // 
            // LabelNomCaissier
            // 
            this.LabelNomCaissier.AutoSize = true;
            this.LabelNomCaissier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomCaissier.Location = new System.Drawing.Point(292, 19);
            this.LabelNomCaissier.Name = "LabelNomCaissier";
            this.LabelNomCaissier.Size = new System.Drawing.Size(127, 18);
            this.LabelNomCaissier.TabIndex = 14;
            this.LabelNomCaissier.Text = "NomCaissierN1";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(6, 23);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.DateTimePicker1.TabIndex = 13;
            this.DateTimePicker1.Value = new System.DateTime(2024, 2, 21, 10, 37, 44, 0);
            // 
            // LabelTitleCaissier
            // 
            this.LabelTitleCaissier.AutoSize = true;
            this.LabelTitleCaissier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleCaissier.Location = new System.Drawing.Point(197, 19);
            this.LabelTitleCaissier.Name = "LabelTitleCaissier";
            this.LabelTitleCaissier.Size = new System.Drawing.Size(65, 20);
            this.LabelTitleCaissier.TabIndex = 6;
            this.LabelTitleCaissier.Text = "Caissier";
            // 
            // LabelAffaire
            // 
            this.LabelAffaire.AutoSize = true;
            this.LabelAffaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAffaire.Location = new System.Drawing.Point(328, 103);
            this.LabelAffaire.Name = "LabelAffaire";
            this.LabelAffaire.Size = new System.Drawing.Size(49, 17);
            this.LabelAffaire.TabIndex = 12;
            this.LabelAffaire.Text = "Affaire";
            // 
            // LabelDepot
            // 
            this.LabelDepot.AutoSize = true;
            this.LabelDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepot.Location = new System.Drawing.Point(328, 76);
            this.LabelDepot.Name = "LabelDepot";
            this.LabelDepot.Size = new System.Drawing.Size(46, 17);
            this.LabelDepot.TabIndex = 11;
            this.LabelDepot.Text = "Dépôt";
            // 
            // LabelCentrale
            // 
            this.LabelCentrale.AutoSize = true;
            this.LabelCentrale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCentrale.Location = new System.Drawing.Point(133, 106);
            this.LabelCentrale.Name = "LabelCentrale";
            this.LabelCentrale.Size = new System.Drawing.Size(61, 17);
            this.LabelCentrale.TabIndex = 10;
            this.LabelCentrale.Text = "Centrale";
            // 
            // LabelTarif
            // 
            this.LabelTarif.AutoSize = true;
            this.LabelTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTarif.Location = new System.Drawing.Point(133, 79);
            this.LabelTarif.Name = "LabelTarif";
            this.LabelTarif.Size = new System.Drawing.Size(37, 17);
            this.LabelTarif.TabIndex = 9;
            this.LabelTarif.Text = "Tarif";
            // 
            // LabelVendeur
            // 
            this.LabelVendeur.AutoSize = true;
            this.LabelVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVendeur.Location = new System.Drawing.Point(133, 52);
            this.LabelVendeur.Name = "LabelVendeur";
            this.LabelVendeur.Size = new System.Drawing.Size(62, 17);
            this.LabelVendeur.TabIndex = 8;
            this.LabelVendeur.Text = "Vendeur";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(133, 25);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(38, 17);
            this.LabelDate.TabIndex = 6;
            this.LabelDate.Text = "Date";
            // 
            // ComboBoxNumero
            // 
            this.ComboBoxNumero.FormattingEnabled = true;
            this.ComboBoxNumero.Location = new System.Drawing.Point(328, 46);
            this.ComboBoxNumero.Name = "ComboBoxNumero";
            this.ComboBoxNumero.Size = new System.Drawing.Size(129, 21);
            this.ComboBoxNumero.TabIndex = 7;
            this.ComboBoxNumero.Text = "Numéro";
            // 
            // ComboBoxAffaire
            // 
            this.ComboBoxAffaire.FormattingEnabled = true;
            this.ComboBoxAffaire.Location = new System.Drawing.Point(201, 100);
            this.ComboBoxAffaire.Name = "ComboBoxAffaire";
            this.ComboBoxAffaire.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxAffaire.TabIndex = 6;
            // 
            // ComboBoxDepot
            // 
            this.ComboBoxDepot.FormattingEnabled = true;
            this.ComboBoxDepot.Location = new System.Drawing.Point(201, 73);
            this.ComboBoxDepot.Name = "ComboBoxDepot";
            this.ComboBoxDepot.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDepot.TabIndex = 5;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Location = new System.Drawing.Point(201, 46);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxType.TabIndex = 4;
            // 
            // ComboBoxCentrale
            // 
            this.ComboBoxCentrale.FormattingEnabled = true;
            this.ComboBoxCentrale.Location = new System.Drawing.Point(6, 103);
            this.ComboBoxCentrale.Name = "ComboBoxCentrale";
            this.ComboBoxCentrale.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCentrale.TabIndex = 3;
            // 
            // ComboBoxTarif
            // 
            this.ComboBoxTarif.FormattingEnabled = true;
            this.ComboBoxTarif.Location = new System.Drawing.Point(6, 76);
            this.ComboBoxTarif.Name = "ComboBoxTarif";
            this.ComboBoxTarif.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTarif.TabIndex = 2;
            // 
            // ComboBoxVendeur
            // 
            this.ComboBoxVendeur.FormattingEnabled = true;
            this.ComboBoxVendeur.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxVendeur.Name = "ComboBoxVendeur";
            this.ComboBoxVendeur.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxVendeur.TabIndex = 1;
            // 
            // pDEVISEBindingSource
            // 
            this.pDEVISEBindingSource.DataMember = "P_DEVISE";
            // 
            // pREGLEMENTBindingSource
            // 
            this.pREGLEMENTBindingSource.DataMember = "P_REGLEMENT";
            // 
            // BouttonFermer
            // 
            this.BouttonFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BouttonFermer.Location = new System.Drawing.Point(1000, 749);
            this.BouttonFermer.Name = "BouttonFermer";
            this.BouttonFermer.Palette = this.kryptonPalette1;
            this.BouttonFermer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BouttonFermer.Size = new System.Drawing.Size(90, 25);
            this.BouttonFermer.TabIndex = 0;
            this.BouttonFermer.Values.Text = "Fermer";
            this.BouttonFermer.Click += new System.EventHandler(this.BouttonFermer_Click);
            // 
            // VenteComptoirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 776);
            this.Controls.Add(this.BouttonFermer);
            this.Controls.Add(this.GroupBoxGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VenteComptoirForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente comptoir";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VenteComptoirForm_Load);
            this.GroupBoxGeneral.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.GroupBoxEnregistrement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnregistrement)).EndInit();
            this.GroupBoxInvisibleEnregistrement.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GroupBoxCommandDroite.ResumeLayout(false);
            this.GroupBoxReste.ResumeLayout(false);
            this.GroupBoxReste.PerformLayout();
            this.groupBoxCommand.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanelDesignation.ResumeLayout(false);
            this.TableLayoutPanelDesignation.PerformLayout();
            this.GroupBoxTotal.ResumeLayout(false);
            this.GroupBoxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArticle)).EndInit();
            this.GroupBoxinfoCaissier.ResumeLayout(false);
            this.GroupBoxinfoCaissier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDEVISEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREGLEMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.GroupBox GroupBoxGeneral;
        private System.Windows.Forms.GroupBox GroupBoxinfoCaissier;
        private System.Windows.Forms.GroupBox GroupBoxReste;
        private System.Windows.Forms.GroupBox GroupBoxEnregistrement;
        private KryptonButton BouttonFermer;
        private System.Windows.Forms.DataGridView DataGridViewArticle;
        private KryptonButton BouttonValider;
        private KryptonButton BouttonCreerDoc;
        private KryptonButton BouttonRappelTicket;
        private KryptonButton BouttonEnAttente;
        private KryptonButton BouttonRaccourci;
        private KryptonButton BouttonTicket;
        private KryptonButton BouttonFacture;
        private KryptonButton BouttonAnnuler;
        private KryptonButton BouttonFinDeSaisie;
        private System.Windows.Forms.Label LabelResteDu;
        private System.Windows.Forms.Label LabelTotalTTC;
        private System.Windows.Forms.Label LabelTotalHT;
        private System.Windows.Forms.GroupBox GroupBoxTotal;
        private System.Windows.Forms.ComboBox ComboBoxAffaire;
        private System.Windows.Forms.ComboBox ComboBoxDepot;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.ComboBox ComboBoxCentrale;
        private System.Windows.Forms.ComboBox ComboBoxTarif;
        private System.Windows.Forms.ComboBox ComboBoxVendeur;
        private System.Windows.Forms.ComboBox ComboBoxDeviseReste;
        private System.Windows.Forms.Label LabelAffaire;
        private System.Windows.Forms.Label LabelDepot;
        private System.Windows.Forms.Label LabelCentrale;
        private System.Windows.Forms.Label LabelTarif;
        private System.Windows.Forms.Label LabelVendeur;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ComboBox ComboBoxNumero;
        private System.Windows.Forms.Label LabelTitleCaissier;
        private System.Windows.Forms.Label LabelDeviseReste;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelDesignation;
        private System.Windows.Forms.TextBox TextBoxDesignation;
        private System.Windows.Forms.TextBox TextBoxQuantiteDisponibleEnStock;
        private System.Windows.Forms.TextBox TextBoxPUTTC;
        private System.Windows.Forms.TextBox TextBoxConditionnement;
        private KryptonButton BouttonEnregistrerDesignation;
        private KryptonButton BouttonSupprimerDesignation;
        private KryptonButton BouttonNouveauDesignation;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label LabelNomCaissier;
        private System.Windows.Forms.Label LabelPrixTotalTTC;
        private System.Windows.Forms.Label LabelPrixTotalHT;
        private System.Windows.Forms.Label LabelPrixResteDu;
        private System.Windows.Forms.TextBox TextBoxReference;
        private System.Windows.Forms.DataGridView DataGridViewEnregistrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeDeReception;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devise;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEcheance;
        private System.Windows.Forms.GroupBox GroupBoxInvisibleEnregistrement;
        private KryptonButton BouttonEnregistrerEnregistrement;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnregistrement;
        private KryptonButton BouttonSupprimerEnregistrement;
        private KryptonButton BouttonNouveauEnregistrement;
        private System.Windows.Forms.ComboBox ComboBoxDeviseEnregistrement;
        private System.Windows.Forms.TextBox TextBoxLibelleEnregistrement;
        private System.Windows.Forms.TextBox TextBoxMontantEnregistrement;
        private System.Windows.Forms.ComboBox ComboBoxReglementEnregistrement;
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
        private System.Windows.Forms.TextBox TextBoxPUHT;
        private System.Windows.Forms.TextBox TextBoxRemise;
        private System.Windows.Forms.TextBox TextBoxPUnet;
        private System.Windows.Forms.TextBox TextBoxMontantHT;
        private System.Windows.Forms.TextBox TextBoxMontantTTC;
        private System.Windows.Forms.BindingSource pREGLEMENTBindingSource;
        private System.Windows.Forms.BindingSource pDEVISEBindingSource;
        //private BIJOUDataSet2TableAdapters.P_DEVISETableAdapter p_DEVISETableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxCommand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GroupBoxCommandDroite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}