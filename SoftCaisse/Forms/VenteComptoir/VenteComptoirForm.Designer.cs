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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.ButtonEnregistrerDesignation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanelDesignation = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxGamme1 = new System.Windows.Forms.TextBox();
            this.textBoxNumLot = new System.Windows.Forms.TextBox();
            this.textBoxPUHT = new System.Windows.Forms.TextBox();
            this.textBoxPUTTC = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.ButtonSupprimerDesignation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonNouveauDesignation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.labelPrixTotalTTC = new System.Windows.Forms.Label();
            this.labelPrixTotalHT = new System.Windows.Forms.Label();
            this.labelTotalHT = new System.Windows.Forms.Label();
            this.labelTotalTTC = new System.Windows.Forms.Label();
            this.dataGridViewArticle = new System.Windows.Forms.DataGridView();
            this.Column1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeFamille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteVendue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEnregistrement = new System.Windows.Forms.GroupBox();
            this.dataGridViewEnregistrement = new System.Windows.Forms.DataGridView();
            this.ModeDeReception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEcheance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInvisibleEnregistrement = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonEnregistrerEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonSupprimerEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonNouveauEnregistrement = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dateTimePickerEnregistrement = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDeviseEnregistrement = new System.Windows.Forms.ComboBox();
            this.textBoxLibelleEnregistrement = new System.Windows.Forms.TextBox();
            this.comboBoxEspeceEnregistrement = new System.Windows.Forms.ComboBox();
            this.textBoxMontantEnregistrement = new System.Windows.Forms.TextBox();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.ButtonValider = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonCreerDoc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonRappelTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonEnAttente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonRaccourci = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonFacture = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonAnnuler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonFinDeSaisie = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBoxReste = new System.Windows.Forms.GroupBox();
            this.labelPrixResteDu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxResteDu = new System.Windows.Forms.ComboBox();
            this.labelResteDu = new System.Windows.Forms.Label();
            this.labelResteDuDevise = new System.Windows.Forms.Label();
            this.groupBoxinfoCaissier = new System.Windows.Forms.GroupBox();
            this.labelNomCaissier = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTitleCaissier = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCentrale = new System.Windows.Forms.Label();
            this.labelTarif = new System.Windows.Forms.Label();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxNumero = new System.Windows.Forms.ComboBox();
            this.comboBoxAffaire = new System.Windows.Forms.ComboBox();
            this.comboBoxDepot = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCentrale = new System.Windows.Forms.ComboBox();
            this.comboBoxTarif = new System.Windows.Forms.ComboBox();
            this.comboBoxVendeur = new System.Windows.Forms.ComboBox();
            this.ButtonClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBoxGeneral.SuspendLayout();
            this.tableLayoutPanelDesignation.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticle)).BeginInit();
            this.groupBoxEnregistrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnregistrement)).BeginInit();
            this.groupBoxInvisibleEnregistrement.SuspendLayout();
            this.groupBoxCommand.SuspendLayout();
            this.groupBoxReste.SuspendLayout();
            this.groupBoxinfoCaissier.SuspendLayout();
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
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.ButtonEnregistrerDesignation);
            this.groupBoxGeneral.Controls.Add(this.tableLayoutPanelDesignation);
            this.groupBoxGeneral.Controls.Add(this.ButtonSupprimerDesignation);
            this.groupBoxGeneral.Controls.Add(this.ButtonNouveauDesignation);
            this.groupBoxGeneral.Controls.Add(this.groupBoxTotal);
            this.groupBoxGeneral.Controls.Add(this.dataGridViewArticle);
            this.groupBoxGeneral.Controls.Add(this.groupBoxEnregistrement);
            this.groupBoxGeneral.Controls.Add(this.groupBoxCommand);
            this.groupBoxGeneral.Controls.Add(this.groupBoxReste);
            this.groupBoxGeneral.Controls.Add(this.groupBoxinfoCaissier);
            this.groupBoxGeneral.Location = new System.Drawing.Point(-7, 0);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(1126, 727);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            // 
            // ButtonEnregistrerDesignation
            // 
            this.ButtonEnregistrerDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEnregistrerDesignation.Enabled = false;
            this.ButtonEnregistrerDesignation.Location = new System.Drawing.Point(1017, 214);
            this.ButtonEnregistrerDesignation.Name = "ButtonEnregistrerDesignation";
            this.ButtonEnregistrerDesignation.Palette = this.kryptonPalette1;
            this.ButtonEnregistrerDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonEnregistrerDesignation.Size = new System.Drawing.Size(90, 25);
            this.ButtonEnregistrerDesignation.TabIndex = 12;
            this.ButtonEnregistrerDesignation.Values.Text = "Enregistrer";
            this.ButtonEnregistrerDesignation.Click += new System.EventHandler(this.ButtonEnregistrerDesignation_Click);
            // 
            // tableLayoutPanelDesignation
            // 
            this.tableLayoutPanelDesignation.AutoScroll = true;
            this.tableLayoutPanelDesignation.ColumnCount = 7;
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDesignation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxReference, 0, 0);
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxDesignation, 1, 0);
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxGamme1, 2, 0);
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxNumLot, 3, 0);
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxPUHT, 4, 0);
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxPUTTC, 5, 0);
            this.tableLayoutPanelDesignation.Controls.Add(this.textBoxQuantite, 6, 0);
            this.tableLayoutPanelDesignation.Location = new System.Drawing.Point(19, 167);
            this.tableLayoutPanelDesignation.Name = "tableLayoutPanelDesignation";
            this.tableLayoutPanelDesignation.RowCount = 1;
            this.tableLayoutPanelDesignation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDesignation.Size = new System.Drawing.Size(1088, 36);
            this.tableLayoutPanelDesignation.TabIndex = 6;
            // 
            // textBoxReference
            // 
            this.textBoxReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReference.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxReference.Location = new System.Drawing.Point(3, 3);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(100, 25);
            this.textBoxReference.TabIndex = 13;
            this.textBoxReference.Text = "Référence";
            this.textBoxReference.Enter += new System.EventHandler(this.TextBox_Enter);
            this.textBoxReference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReference_KeyDown);
            this.textBoxReference.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesignation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxDesignation.Location = new System.Drawing.Point(111, 3);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(320, 25);
            this.textBoxDesignation.TabIndex = 2;
            this.textBoxDesignation.Text = "Désignation";
            // 
            // textBoxGamme1
            // 
            this.textBoxGamme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGamme1.Location = new System.Drawing.Point(437, 3);
            this.textBoxGamme1.Name = "textBoxGamme1";
            this.textBoxGamme1.ReadOnly = true;
            this.textBoxGamme1.Size = new System.Drawing.Size(102, 25);
            this.textBoxGamme1.TabIndex = 3;
            // 
            // textBoxNumLot
            // 
            this.textBoxNumLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumLot.Location = new System.Drawing.Point(545, 3);
            this.textBoxNumLot.Name = "textBoxNumLot";
            this.textBoxNumLot.ReadOnly = true;
            this.textBoxNumLot.Size = new System.Drawing.Size(102, 25);
            this.textBoxNumLot.TabIndex = 4;
            // 
            // textBoxPUHT
            // 
            this.textBoxPUHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPUHT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPUHT.Location = new System.Drawing.Point(653, 3);
            this.textBoxPUHT.Name = "textBoxPUHT";
            this.textBoxPUHT.Size = new System.Drawing.Size(102, 25);
            this.textBoxPUHT.TabIndex = 5;
            this.textBoxPUHT.Text = "P.U. HT";
            // 
            // textBoxPUTTC
            // 
            this.textBoxPUTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPUTTC.Location = new System.Drawing.Point(761, 3);
            this.textBoxPUTTC.Name = "textBoxPUTTC";
            this.textBoxPUTTC.ReadOnly = true;
            this.textBoxPUTTC.Size = new System.Drawing.Size(157, 25);
            this.textBoxPUTTC.TabIndex = 6;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantite.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxQuantite.Location = new System.Drawing.Point(924, 3);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(161, 25);
            this.textBoxQuantite.TabIndex = 7;
            this.textBoxQuantite.Text = "Quantité";
            // 
            // ButtonSupprimerDesignation
            // 
            this.ButtonSupprimerDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSupprimerDesignation.Enabled = false;
            this.ButtonSupprimerDesignation.Location = new System.Drawing.Point(903, 214);
            this.ButtonSupprimerDesignation.Name = "ButtonSupprimerDesignation";
            this.ButtonSupprimerDesignation.Palette = this.kryptonPalette1;
            this.ButtonSupprimerDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonSupprimerDesignation.Size = new System.Drawing.Size(90, 25);
            this.ButtonSupprimerDesignation.TabIndex = 11;
            this.ButtonSupprimerDesignation.Values.Text = "Supprimer";
            this.ButtonSupprimerDesignation.Click += new System.EventHandler(this.ButtonSupprimerDesignation_Click);
            // 
            // ButtonNouveauDesignation
            // 
            this.ButtonNouveauDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNouveauDesignation.Location = new System.Drawing.Point(788, 214);
            this.ButtonNouveauDesignation.Name = "ButtonNouveauDesignation";
            this.ButtonNouveauDesignation.Palette = this.kryptonPalette1;
            this.ButtonNouveauDesignation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonNouveauDesignation.Size = new System.Drawing.Size(90, 25);
            this.ButtonNouveauDesignation.TabIndex = 10;
            this.ButtonNouveauDesignation.Values.Text = "Nouveau";
            this.ButtonNouveauDesignation.Click += new System.EventHandler(this.ButtonNouveauDesignation_Click);
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTotal.Controls.Add(this.labelPrixTotalTTC);
            this.groupBoxTotal.Controls.Add(this.labelPrixTotalHT);
            this.groupBoxTotal.Controls.Add(this.labelTotalHT);
            this.groupBoxTotal.Controls.Add(this.labelTotalTTC);
            this.groupBoxTotal.Location = new System.Drawing.Point(574, 12);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(533, 149);
            this.groupBoxTotal.TabIndex = 5;
            this.groupBoxTotal.TabStop = false;
            // 
            // labelPrixTotalTTC
            // 
            this.labelPrixTotalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrixTotalTTC.AutoSize = true;
            this.labelPrixTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotalTTC.Location = new System.Drawing.Point(335, 102);
            this.labelPrixTotalTTC.Name = "labelPrixTotalTTC";
            this.labelPrixTotalTTC.Size = new System.Drawing.Size(71, 31);
            this.labelPrixTotalTTC.TabIndex = 16;
            this.labelPrixTotalTTC.Text = "0,00";
            this.labelPrixTotalTTC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrixTotalHT
            // 
            this.labelPrixTotalHT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrixTotalHT.AutoSize = true;
            this.labelPrixTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixTotalHT.Location = new System.Drawing.Point(335, 39);
            this.labelPrixTotalHT.Name = "labelPrixTotalHT";
            this.labelPrixTotalHT.Size = new System.Drawing.Size(71, 31);
            this.labelPrixTotalHT.TabIndex = 15;
            this.labelPrixTotalHT.Text = "0,00";
            this.labelPrixTotalHT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalHT
            // 
            this.labelTotalHT.AutoSize = true;
            this.labelTotalHT.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHT.Location = new System.Drawing.Point(6, 34);
            this.labelTotalHT.Name = "labelTotalHT";
            this.labelTotalHT.Size = new System.Drawing.Size(127, 31);
            this.labelTotalHT.TabIndex = 2;
            this.labelTotalHT.Text = "Total HT";
            // 
            // labelTotalTTC
            // 
            this.labelTotalTTC.AutoSize = true;
            this.labelTotalTTC.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTTC.Location = new System.Drawing.Point(6, 97);
            this.labelTotalTTC.Name = "labelTotalTTC";
            this.labelTotalTTC.Size = new System.Drawing.Size(145, 31);
            this.labelTotalTTC.TabIndex = 3;
            this.labelTotalTTC.Text = "Total TTC";
            // 
            // dataGridViewArticle
            // 
            this.dataGridViewArticle.AllowUserToAddRows = false;
            this.dataGridViewArticle.AllowUserToDeleteRows = false;
            this.dataGridViewArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.CodeFamille,
            this.quantiteEnStock,
            this.prixUnitaireHT,
            this.prixUnitaireTTC,
            this.quantiteVendue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArticle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArticle.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewArticle.Location = new System.Drawing.Point(19, 254);
            this.dataGridViewArticle.Name = "dataGridViewArticle";
            this.dataGridViewArticle.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArticle.RowHeadersVisible = false;
            this.dataGridViewArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticle.Size = new System.Drawing.Size(1088, 224);
            this.dataGridViewArticle.TabIndex = 4;
            this.dataGridViewArticle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticle_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Référence article";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 155;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // CodeFamille
            // 
            this.CodeFamille.HeaderText = "Famille";
            this.CodeFamille.Name = "CodeFamille";
            this.CodeFamille.ReadOnly = true;
            // 
            // quantiteEnStock
            // 
            this.quantiteEnStock.DataPropertyName = "quantiteEnStock";
            this.quantiteEnStock.HeaderText = "Quantité en Stock";
            this.quantiteEnStock.Name = "quantiteEnStock";
            this.quantiteEnStock.ReadOnly = true;
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
            // quantiteVendue
            // 
            this.quantiteVendue.DataPropertyName = "quantiteVendue";
            this.quantiteVendue.HeaderText = "Quantité vendue";
            this.quantiteVendue.Name = "quantiteVendue";
            this.quantiteVendue.ReadOnly = true;
            // 
            // groupBoxEnregistrement
            // 
            this.groupBoxEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnregistrement.Controls.Add(this.dataGridViewEnregistrement);
            this.groupBoxEnregistrement.Controls.Add(this.groupBoxInvisibleEnregistrement);
            this.groupBoxEnregistrement.Location = new System.Drawing.Point(25, 484);
            this.groupBoxEnregistrement.Name = "groupBoxEnregistrement";
            this.groupBoxEnregistrement.Size = new System.Drawing.Size(683, 233);
            this.groupBoxEnregistrement.TabIndex = 2;
            this.groupBoxEnregistrement.TabStop = false;
            // 
            // dataGridViewEnregistrement
            // 
            this.dataGridViewEnregistrement.AllowUserToAddRows = false;
            this.dataGridViewEnregistrement.AllowUserToDeleteRows = false;
            this.dataGridViewEnregistrement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEnregistrement.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEnregistrement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEnregistrement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEnregistrement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnregistrement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeDeReception,
            this.Montant,
            this.Libelle,
            this.Devise,
            this.DateEcheance});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEnregistrement.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEnregistrement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewEnregistrement.Enabled = false;
            this.dataGridViewEnregistrement.Location = new System.Drawing.Point(3, 108);
            this.dataGridViewEnregistrement.Name = "dataGridViewEnregistrement";
            this.dataGridViewEnregistrement.ReadOnly = true;
            this.dataGridViewEnregistrement.RowHeadersVisible = false;
            this.dataGridViewEnregistrement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEnregistrement.Size = new System.Drawing.Size(677, 122);
            this.dataGridViewEnregistrement.TabIndex = 1;
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
            // groupBoxInvisibleEnregistrement
            // 
            this.groupBoxInvisibleEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.label2);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.ButtonEnregistrerEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.ButtonSupprimerEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.ButtonNouveauEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.dateTimePickerEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.comboBoxDeviseEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.textBoxLibelleEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.comboBoxEspeceEnregistrement);
            this.groupBoxInvisibleEnregistrement.Controls.Add(this.textBoxMontantEnregistrement);
            this.groupBoxInvisibleEnregistrement.Location = new System.Drawing.Point(3, 16);
            this.groupBoxInvisibleEnregistrement.Name = "groupBoxInvisibleEnregistrement";
            this.groupBoxInvisibleEnregistrement.Size = new System.Drawing.Size(677, 80);
            this.groupBoxInvisibleEnregistrement.TabIndex = 0;
            this.groupBoxInvisibleEnregistrement.TabStop = false;
            this.groupBoxInvisibleEnregistrement.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 17;
            // 
            // ButtonEnregistrerEnregistrement
            // 
            this.ButtonEnregistrerEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEnregistrerEnregistrement.Location = new System.Drawing.Point(572, 47);
            this.ButtonEnregistrerEnregistrement.Name = "ButtonEnregistrerEnregistrement";
            this.ButtonEnregistrerEnregistrement.Palette = this.kryptonPalette1;
            this.ButtonEnregistrerEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonEnregistrerEnregistrement.Size = new System.Drawing.Size(90, 25);
            this.ButtonEnregistrerEnregistrement.TabIndex = 15;
            this.ButtonEnregistrerEnregistrement.Values.Text = "Enregistrer";
            this.ButtonEnregistrerEnregistrement.Click += new System.EventHandler(this.ButtonEnregistrerEnregistrement_Click);
            // 
            // ButtonSupprimerEnregistrement
            // 
            this.ButtonSupprimerEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSupprimerEnregistrement.Enabled = false;
            this.ButtonSupprimerEnregistrement.Location = new System.Drawing.Point(458, 47);
            this.ButtonSupprimerEnregistrement.Name = "ButtonSupprimerEnregistrement";
            this.ButtonSupprimerEnregistrement.Palette = this.kryptonPalette1;
            this.ButtonSupprimerEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonSupprimerEnregistrement.Size = new System.Drawing.Size(90, 25);
            this.ButtonSupprimerEnregistrement.TabIndex = 14;
            this.ButtonSupprimerEnregistrement.Values.Text = "Supprimer";
            this.ButtonSupprimerEnregistrement.Click += new System.EventHandler(this.ButtonSupprimerEnregistrement_Click);
            // 
            // ButtonNouveauEnregistrement
            // 
            this.ButtonNouveauEnregistrement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNouveauEnregistrement.Location = new System.Drawing.Point(343, 47);
            this.ButtonNouveauEnregistrement.Name = "ButtonNouveauEnregistrement";
            this.ButtonNouveauEnregistrement.Palette = this.kryptonPalette1;
            this.ButtonNouveauEnregistrement.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonNouveauEnregistrement.Size = new System.Drawing.Size(90, 25);
            this.ButtonNouveauEnregistrement.TabIndex = 13;
            this.ButtonNouveauEnregistrement.Values.Text = "Nouveau";
            // 
            // dateTimePickerEnregistrement
            // 
            this.dateTimePickerEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnregistrement.Location = new System.Drawing.Point(558, 15);
            this.dateTimePickerEnregistrement.Name = "dateTimePickerEnregistrement";
            this.dateTimePickerEnregistrement.Size = new System.Drawing.Size(113, 23);
            this.dateTimePickerEnregistrement.TabIndex = 4;
            // 
            // comboBoxDeviseEnregistrement
            // 
            this.comboBoxDeviseEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeviseEnregistrement.FormattingEnabled = true;
            this.comboBoxDeviseEnregistrement.Items.AddRange(new object[] {
            "Dollar US",
            "Ariary Malgache",
            "Euro",
            "Franc CFA"});
            this.comboBoxDeviseEnregistrement.Location = new System.Drawing.Point(458, 14);
            this.comboBoxDeviseEnregistrement.Name = "comboBoxDeviseEnregistrement";
            this.comboBoxDeviseEnregistrement.Size = new System.Drawing.Size(94, 24);
            this.comboBoxDeviseEnregistrement.TabIndex = 3;
            this.comboBoxDeviseEnregistrement.Text = "Euro";
            this.comboBoxDeviseEnregistrement.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviseEnregistrement_SelectedIndexChanged);
            // 
            // textBoxLibelleEnregistrement
            // 
            this.textBoxLibelleEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLibelleEnregistrement.Location = new System.Drawing.Point(300, 15);
            this.textBoxLibelleEnregistrement.Name = "textBoxLibelleEnregistrement";
            this.textBoxLibelleEnregistrement.Size = new System.Drawing.Size(152, 22);
            this.textBoxLibelleEnregistrement.TabIndex = 2;
            this.textBoxLibelleEnregistrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxEspeceEnregistrement
            // 
            this.comboBoxEspeceEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEspeceEnregistrement.FormattingEnabled = true;
            this.comboBoxEspeceEnregistrement.Items.AddRange(new object[] {
            "Espèce",
            "Virement",
            "Chèque"});
            this.comboBoxEspeceEnregistrement.Location = new System.Drawing.Point(6, 13);
            this.comboBoxEspeceEnregistrement.Name = "comboBoxEspeceEnregistrement";
            this.comboBoxEspeceEnregistrement.Size = new System.Drawing.Size(71, 24);
            this.comboBoxEspeceEnregistrement.TabIndex = 0;
            this.comboBoxEspeceEnregistrement.Text = "Espèce";
            // 
            // textBoxMontantEnregistrement
            // 
            this.textBoxMontantEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontantEnregistrement.Location = new System.Drawing.Point(82, 14);
            this.textBoxMontantEnregistrement.Name = "textBoxMontantEnregistrement";
            this.textBoxMontantEnregistrement.Size = new System.Drawing.Size(173, 23);
            this.textBoxMontantEnregistrement.TabIndex = 1;
            this.textBoxMontantEnregistrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMontantEnregistrement.TextChanged += new System.EventHandler(this.textBoxMontantEnregistrement_TextChanged);
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommand.Controls.Add(this.ButtonValider);
            this.groupBoxCommand.Controls.Add(this.ButtonCreerDoc);
            this.groupBoxCommand.Controls.Add(this.ButtonRappelTicket);
            this.groupBoxCommand.Controls.Add(this.ButtonEnAttente);
            this.groupBoxCommand.Controls.Add(this.ButtonRaccourci);
            this.groupBoxCommand.Controls.Add(this.ButtonTicket);
            this.groupBoxCommand.Controls.Add(this.ButtonFacture);
            this.groupBoxCommand.Controls.Add(this.ButtonAnnuler);
            this.groupBoxCommand.Controls.Add(this.ButtonFinDeSaisie);
            this.groupBoxCommand.Location = new System.Drawing.Point(714, 592);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Size = new System.Drawing.Size(393, 125);
            this.groupBoxCommand.TabIndex = 3;
            this.groupBoxCommand.TabStop = false;
            // 
            // ButtonValider
            // 
            this.ButtonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonValider.Enabled = false;
            this.ButtonValider.Location = new System.Drawing.Point(294, 92);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Palette = this.kryptonPalette1;
            this.ButtonValider.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonValider.Size = new System.Drawing.Size(90, 25);
            this.ButtonValider.TabIndex = 9;
            this.ButtonValider.Values.Text = "Valider";
            // 
            // ButtonCreerDoc
            // 
            this.ButtonCreerDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonCreerDoc.Location = new System.Drawing.Point(156, 92);
            this.ButtonCreerDoc.Name = "ButtonCreerDoc";
            this.ButtonCreerDoc.Palette = this.kryptonPalette1;
            this.ButtonCreerDoc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonCreerDoc.Size = new System.Drawing.Size(90, 25);
            this.ButtonCreerDoc.TabIndex = 8;
            this.ButtonCreerDoc.Values.Text = "Créer doc.";
            // 
            // ButtonRappelTicket
            // 
            this.ButtonRappelTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRappelTicket.Location = new System.Drawing.Point(12, 92);
            this.ButtonRappelTicket.Name = "ButtonRappelTicket";
            this.ButtonRappelTicket.Palette = this.kryptonPalette1;
            this.ButtonRappelTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonRappelTicket.Size = new System.Drawing.Size(90, 25);
            this.ButtonRappelTicket.TabIndex = 7;
            this.ButtonRappelTicket.Values.Text = "Rappel Ticket";
            // 
            // ButtonEnAttente
            // 
            this.ButtonEnAttente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonEnAttente.Enabled = false;
            this.ButtonEnAttente.Location = new System.Drawing.Point(293, 53);
            this.ButtonEnAttente.Name = "ButtonEnAttente";
            this.ButtonEnAttente.Palette = this.kryptonPalette1;
            this.ButtonEnAttente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonEnAttente.Size = new System.Drawing.Size(90, 25);
            this.ButtonEnAttente.TabIndex = 6;
            this.ButtonEnAttente.Values.Text = "En attente";
            // 
            // ButtonRaccourci
            // 
            this.ButtonRaccourci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonRaccourci.Location = new System.Drawing.Point(155, 53);
            this.ButtonRaccourci.Name = "ButtonRaccourci";
            this.ButtonRaccourci.Palette = this.kryptonPalette1;
            this.ButtonRaccourci.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonRaccourci.Size = new System.Drawing.Size(90, 25);
            this.ButtonRaccourci.TabIndex = 5;
            this.ButtonRaccourci.Values.Text = "Raccourcis";
            // 
            // ButtonTicket
            // 
            this.ButtonTicket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonTicket.Enabled = false;
            this.ButtonTicket.Location = new System.Drawing.Point(11, 53);
            this.ButtonTicket.Name = "ButtonTicket";
            this.ButtonTicket.Palette = this.kryptonPalette1;
            this.ButtonTicket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonTicket.Size = new System.Drawing.Size(90, 25);
            this.ButtonTicket.TabIndex = 4;
            this.ButtonTicket.Values.Text = "Ticket";
            // 
            // ButtonFacture
            // 
            this.ButtonFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFacture.Enabled = false;
            this.ButtonFacture.Location = new System.Drawing.Point(293, 11);
            this.ButtonFacture.Name = "ButtonFacture";
            this.ButtonFacture.Palette = this.kryptonPalette1;
            this.ButtonFacture.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonFacture.Size = new System.Drawing.Size(90, 25);
            this.ButtonFacture.TabIndex = 3;
            this.ButtonFacture.Values.Text = "Facture";
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAnnuler.Location = new System.Drawing.Point(155, 11);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.Palette = this.kryptonPalette1;
            this.ButtonAnnuler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonAnnuler.Size = new System.Drawing.Size(90, 25);
            this.ButtonAnnuler.TabIndex = 2;
            this.ButtonAnnuler.Values.Text = "Annuler";
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // ButtonFinDeSaisie
            // 
            this.ButtonFinDeSaisie.Enabled = false;
            this.ButtonFinDeSaisie.Location = new System.Drawing.Point(11, 11);
            this.ButtonFinDeSaisie.Name = "ButtonFinDeSaisie";
            this.ButtonFinDeSaisie.Palette = this.kryptonPalette1;
            this.ButtonFinDeSaisie.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonFinDeSaisie.Size = new System.Drawing.Size(90, 25);
            this.ButtonFinDeSaisie.TabIndex = 1;
            this.ButtonFinDeSaisie.Values.Text = "Fin de saisie";
            this.ButtonFinDeSaisie.Click += new System.EventHandler(this.ButtonFinDeSaisie_Click);
            // 
            // groupBoxReste
            // 
            this.groupBoxReste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReste.Controls.Add(this.labelPrixResteDu);
            this.groupBoxReste.Controls.Add(this.label11);
            this.groupBoxReste.Controls.Add(this.comboBoxResteDu);
            this.groupBoxReste.Controls.Add(this.labelResteDu);
            this.groupBoxReste.Controls.Add(this.labelResteDuDevise);
            this.groupBoxReste.Location = new System.Drawing.Point(714, 484);
            this.groupBoxReste.Name = "groupBoxReste";
            this.groupBoxReste.Size = new System.Drawing.Size(393, 102);
            this.groupBoxReste.TabIndex = 2;
            this.groupBoxReste.TabStop = false;
            // 
            // labelPrixResteDu
            // 
            this.labelPrixResteDu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrixResteDu.AutoSize = true;
            this.labelPrixResteDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixResteDu.Location = new System.Drawing.Point(195, 13);
            this.labelPrixResteDu.Name = "labelPrixResteDu";
            this.labelPrixResteDu.Size = new System.Drawing.Size(71, 31);
            this.labelPrixResteDu.TabIndex = 17;
            this.labelPrixResteDu.Text = "0,00";
            this.labelPrixResteDu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Devise";
            // 
            // comboBoxResteDu
            // 
            this.comboBoxResteDu.FormattingEnabled = true;
            this.comboBoxResteDu.Items.AddRange(new object[] {
            "Ariary Malgache",
            "Dollar US",
            "Euro",
            "Franc CFA"});
            this.comboBoxResteDu.Location = new System.Drawing.Point(138, 54);
            this.comboBoxResteDu.Name = "comboBoxResteDu";
            this.comboBoxResteDu.Size = new System.Drawing.Size(245, 21);
            this.comboBoxResteDu.TabIndex = 13;
            // 
            // labelResteDu
            // 
            this.labelResteDu.AutoSize = true;
            this.labelResteDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResteDu.Location = new System.Drawing.Point(6, 16);
            this.labelResteDu.Name = "labelResteDu";
            this.labelResteDu.Size = new System.Drawing.Size(117, 29);
            this.labelResteDu.TabIndex = 0;
            this.labelResteDu.Text = "Reste dû";
            this.labelResteDu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResteDuDevise
            // 
            this.labelResteDuDevise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResteDuDevise.AutoSize = true;
            this.labelResteDuDevise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResteDuDevise.Location = new System.Drawing.Point(195, 14);
            this.labelResteDuDevise.Name = "labelResteDuDevise";
            this.labelResteDuDevise.Size = new System.Drawing.Size(71, 31);
            this.labelResteDuDevise.TabIndex = 18;
            this.labelResteDuDevise.Text = "0,00";
            this.labelResteDuDevise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResteDuDevise.Visible = false;
            // 
            // groupBoxinfoCaissier
            // 
            this.groupBoxinfoCaissier.Controls.Add(this.labelNomCaissier);
            this.groupBoxinfoCaissier.Controls.Add(this.dateTimePicker1);
            this.groupBoxinfoCaissier.Controls.Add(this.labelTitleCaissier);
            this.groupBoxinfoCaissier.Controls.Add(this.label8);
            this.groupBoxinfoCaissier.Controls.Add(this.label9);
            this.groupBoxinfoCaissier.Controls.Add(this.labelCentrale);
            this.groupBoxinfoCaissier.Controls.Add(this.labelTarif);
            this.groupBoxinfoCaissier.Controls.Add(this.labelVendeur);
            this.groupBoxinfoCaissier.Controls.Add(this.labelDate);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxNumero);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxAffaire);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxDepot);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxType);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxCentrale);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxTarif);
            this.groupBoxinfoCaissier.Controls.Add(this.comboBoxVendeur);
            this.groupBoxinfoCaissier.Location = new System.Drawing.Point(19, 12);
            this.groupBoxinfoCaissier.Name = "groupBoxinfoCaissier";
            this.groupBoxinfoCaissier.Size = new System.Drawing.Size(549, 149);
            this.groupBoxinfoCaissier.TabIndex = 0;
            this.groupBoxinfoCaissier.TabStop = false;
            // 
            // labelNomCaissier
            // 
            this.labelNomCaissier.AutoSize = true;
            this.labelNomCaissier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomCaissier.Location = new System.Drawing.Point(292, 19);
            this.labelNomCaissier.Name = "labelNomCaissier";
            this.labelNomCaissier.Size = new System.Drawing.Size(127, 18);
            this.labelNomCaissier.TabIndex = 14;
            this.labelNomCaissier.Text = "NomCaissierN1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2024, 2, 21, 10, 37, 44, 0);
            // 
            // labelTitleCaissier
            // 
            this.labelTitleCaissier.AutoSize = true;
            this.labelTitleCaissier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCaissier.Location = new System.Drawing.Point(197, 19);
            this.labelTitleCaissier.Name = "labelTitleCaissier";
            this.labelTitleCaissier.Size = new System.Drawing.Size(65, 20);
            this.labelTitleCaissier.TabIndex = 6;
            this.labelTitleCaissier.Text = "Caissier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Affaire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dépôt";
            // 
            // labelCentrale
            // 
            this.labelCentrale.AutoSize = true;
            this.labelCentrale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCentrale.Location = new System.Drawing.Point(133, 106);
            this.labelCentrale.Name = "labelCentrale";
            this.labelCentrale.Size = new System.Drawing.Size(61, 17);
            this.labelCentrale.TabIndex = 10;
            this.labelCentrale.Text = "Centrale";
            // 
            // labelTarif
            // 
            this.labelTarif.AutoSize = true;
            this.labelTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarif.Location = new System.Drawing.Point(133, 79);
            this.labelTarif.Name = "labelTarif";
            this.labelTarif.Size = new System.Drawing.Size(37, 17);
            this.labelTarif.TabIndex = 9;
            this.labelTarif.Text = "Tarif";
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendeur.Location = new System.Drawing.Point(133, 52);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(62, 17);
            this.labelVendeur.TabIndex = 8;
            this.labelVendeur.Text = "Vendeur";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(133, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date";
            // 
            // comboBoxNumero
            // 
            this.comboBoxNumero.FormattingEnabled = true;
            this.comboBoxNumero.Location = new System.Drawing.Point(328, 46);
            this.comboBoxNumero.Name = "comboBoxNumero";
            this.comboBoxNumero.Size = new System.Drawing.Size(129, 21);
            this.comboBoxNumero.TabIndex = 7;
            this.comboBoxNumero.Text = "Numéro";
            // 
            // comboBoxAffaire
            // 
            this.comboBoxAffaire.FormattingEnabled = true;
            this.comboBoxAffaire.Location = new System.Drawing.Point(201, 100);
            this.comboBoxAffaire.Name = "comboBoxAffaire";
            this.comboBoxAffaire.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAffaire.TabIndex = 6;
            // 
            // comboBoxDepot
            // 
            this.comboBoxDepot.FormattingEnabled = true;
            this.comboBoxDepot.Location = new System.Drawing.Point(201, 73);
            this.comboBoxDepot.Name = "comboBoxDepot";
            this.comboBoxDepot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepot.TabIndex = 5;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(201, 46);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // comboBoxCentrale
            // 
            this.comboBoxCentrale.FormattingEnabled = true;
            this.comboBoxCentrale.Location = new System.Drawing.Point(6, 103);
            this.comboBoxCentrale.Name = "comboBoxCentrale";
            this.comboBoxCentrale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCentrale.TabIndex = 3;
            // 
            // comboBoxTarif
            // 
            this.comboBoxTarif.FormattingEnabled = true;
            this.comboBoxTarif.Location = new System.Drawing.Point(6, 76);
            this.comboBoxTarif.Name = "comboBoxTarif";
            this.comboBoxTarif.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarif.TabIndex = 2;
            // 
            // comboBoxVendeur
            // 
            this.comboBoxVendeur.FormattingEnabled = true;
            this.comboBoxVendeur.Location = new System.Drawing.Point(6, 49);
            this.comboBoxVendeur.Name = "comboBoxVendeur";
            this.comboBoxVendeur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVendeur.TabIndex = 1;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Location = new System.Drawing.Point(1000, 733);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Palette = this.kryptonPalette1;
            this.ButtonClose.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ButtonClose.Size = new System.Drawing.Size(90, 25);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Values.Text = "Fermer";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // VenteComptoirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 760);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.groupBoxGeneral);
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
            this.groupBoxGeneral.ResumeLayout(false);
            this.tableLayoutPanelDesignation.ResumeLayout(false);
            this.tableLayoutPanelDesignation.PerformLayout();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticle)).EndInit();
            this.groupBoxEnregistrement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnregistrement)).EndInit();
            this.groupBoxInvisibleEnregistrement.ResumeLayout(false);
            this.groupBoxInvisibleEnregistrement.PerformLayout();
            this.groupBoxCommand.ResumeLayout(false);
            this.groupBoxReste.ResumeLayout(false);
            this.groupBoxReste.PerformLayout();
            this.groupBoxinfoCaissier.ResumeLayout(false);
            this.groupBoxinfoCaissier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.GroupBox groupBoxinfoCaissier;
        private System.Windows.Forms.GroupBox groupBoxCommand;
        private System.Windows.Forms.GroupBox groupBoxReste;
        private System.Windows.Forms.GroupBox groupBoxEnregistrement;
        private KryptonButton ButtonClose;
        private System.Windows.Forms.DataGridView dataGridViewArticle;
        private KryptonButton ButtonValider;
        private KryptonButton ButtonCreerDoc;
        private KryptonButton ButtonRappelTicket;
        private KryptonButton ButtonEnAttente;
        private KryptonButton ButtonRaccourci;
        private KryptonButton ButtonTicket;
        private KryptonButton ButtonFacture;
        private KryptonButton ButtonAnnuler;
        private KryptonButton ButtonFinDeSaisie;
        private System.Windows.Forms.Label labelResteDu;
        private System.Windows.Forms.Label labelTotalTTC;
        private System.Windows.Forms.Label labelTotalHT;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.ComboBox comboBoxAffaire;
        private System.Windows.Forms.ComboBox comboBoxDepot;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxCentrale;
        private System.Windows.Forms.ComboBox comboBoxTarif;
        private System.Windows.Forms.ComboBox comboBoxVendeur;
        private System.Windows.Forms.ComboBox comboBoxResteDu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCentrale;
        private System.Windows.Forms.Label labelTarif;
        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxNumero;
        private System.Windows.Forms.Label labelTitleCaissier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDesignation;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxGamme1;
        private System.Windows.Forms.TextBox textBoxNumLot;
        private System.Windows.Forms.TextBox textBoxPUHT;
        private System.Windows.Forms.TextBox textBoxPUTTC;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private KryptonButton ButtonEnregistrerDesignation;
        private KryptonButton ButtonSupprimerDesignation;
        private KryptonButton ButtonNouveauDesignation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelNomCaissier;
        private System.Windows.Forms.Label labelPrixTotalTTC;
        private System.Windows.Forms.Label labelPrixTotalHT;
        private System.Windows.Forms.Label labelPrixResteDu;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.DataGridView dataGridViewEnregistrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeDeReception;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devise;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEcheance;
        private System.Windows.Forms.GroupBox groupBoxInvisibleEnregistrement;
        private KryptonButton ButtonEnregistrerEnregistrement;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnregistrement;
        private KryptonButton ButtonSupprimerEnregistrement;
        private KryptonButton ButtonNouveauEnregistrement;
        private System.Windows.Forms.ComboBox comboBoxDeviseEnregistrement;
        private System.Windows.Forms.TextBox textBoxLibelleEnregistrement;
        private System.Windows.Forms.TextBox textBoxMontantEnregistrement;
        private System.Windows.Forms.ComboBox comboBoxEspeceEnregistrement;
        private KryptonDataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeFamille;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteEnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteVendue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResteDuDevise;
    }
}