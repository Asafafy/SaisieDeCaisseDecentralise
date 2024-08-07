using System.Windows.Forms;

namespace SoftCaisse.Forms.Article
{
    partial class DetailsArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsArticle));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNomenclature = new System.Windows.Forms.Button();
            this.btnInterroger = new System.Windows.Forms.Button();
            this.btnTracabilite = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IdentificationPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpBxIdentification = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.labelConditionnement = new System.Windows.Forms.Label();
            this.labelSuiviDeStock = new System.Windows.Forms.Label();
            this.labelNomenclature = new System.Windows.Forms.Label();
            this.labelFamille = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpBxTarif = new System.Windows.Forms.GroupBox();
            this.DescriptifPage = new System.Windows.Forms.TabPage();
            this.ChampLibresPage = new System.Windows.Forms.TabPage();
            this.ParametresPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.IdentificationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpBxIdentification.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNomenclature);
            this.flowLayoutPanel1.Controls.Add(this.btnInterroger);
            this.flowLayoutPanel1.Controls.Add(this.btnTracabilite);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1026, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnNomenclature
            // 
            this.btnNomenclature.BackColor = System.Drawing.Color.Transparent;
            this.btnNomenclature.FlatAppearance.BorderSize = 0;
            this.btnNomenclature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomenclature.Location = new System.Drawing.Point(1, 5);
            this.btnNomenclature.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btnNomenclature.Name = "btnNomenclature";
            this.btnNomenclature.Size = new System.Drawing.Size(134, 27);
            this.btnNomenclature.TabIndex = 1;
            this.btnNomenclature.Text = "Nomenclature";
            this.btnNomenclature.UseVisualStyleBackColor = false;
            this.btnNomenclature.MouseHover += new System.EventHandler(this.btnNomenclature_MouseHover);
            // 
            // btnInterroger
            // 
            this.btnInterroger.BackColor = System.Drawing.Color.Transparent;
            this.btnInterroger.FlatAppearance.BorderSize = 0;
            this.btnInterroger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterroger.Location = new System.Drawing.Point(137, 5);
            this.btnInterroger.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btnInterroger.Name = "btnInterroger";
            this.btnInterroger.Size = new System.Drawing.Size(100, 27);
            this.btnInterroger.TabIndex = 2;
            this.btnInterroger.Text = "Interroger";
            this.btnInterroger.UseVisualStyleBackColor = false;
            this.btnInterroger.MouseHover += new System.EventHandler(this.btnInterroger_MouseHover);
            // 
            // btnTracabilite
            // 
            this.btnTracabilite.BackColor = System.Drawing.Color.Transparent;
            this.btnTracabilite.FlatAppearance.BorderSize = 0;
            this.btnTracabilite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracabilite.Location = new System.Drawing.Point(239, 5);
            this.btnTracabilite.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btnTracabilite.Name = "btnTracabilite";
            this.btnTracabilite.Size = new System.Drawing.Size(101, 27);
            this.btnTracabilite.TabIndex = 3;
            this.btnTracabilite.Text = "Traçabilité";
            this.btnTracabilite.UseVisualStyleBackColor = false;
            this.btnTracabilite.MouseHover += new System.EventHandler(this.btnTracabilite_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IdentificationPage);
            this.tabControl1.Controls.Add(this.DescriptifPage);
            this.tabControl1.Controls.Add(this.ChampLibresPage);
            this.tabControl1.Controls.Add(this.ParametresPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 656);
            this.tabControl1.TabIndex = 3;
            // 
            // IdentificationPage
            // 
            this.IdentificationPage.Controls.Add(this.splitContainer2);
            this.IdentificationPage.Location = new System.Drawing.Point(4, 25);
            this.IdentificationPage.Name = "IdentificationPage";
            this.IdentificationPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentificationPage.Size = new System.Drawing.Size(1018, 627);
            this.IdentificationPage.TabIndex = 0;
            this.IdentificationPage.Text = "Identification";
            this.IdentificationPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpBxIdentification);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpBxTarif);
            this.splitContainer2.Size = new System.Drawing.Size(1012, 621);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 0;
            // 
            // grpBxIdentification
            // 
            this.grpBxIdentification.Controls.Add(this.tableLayoutPanel2);
            this.grpBxIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxIdentification.Location = new System.Drawing.Point(0, 0);
            this.grpBxIdentification.Name = "grpBxIdentification";
            this.grpBxIdentification.Size = new System.Drawing.Size(1012, 192);
            this.grpBxIdentification.TabIndex = 1;
            this.grpBxIdentification.TabStop = false;
            this.grpBxIdentification.Text = "Identification";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelConditionnement, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelSuiviDeStock, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelNomenclature, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelFamille, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelDesignation, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBox3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1006, 165);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(661, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox7
            // 
            this.comboBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(706, 3);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(297, 30);
            this.comboBox7.TabIndex = 26;
            // 
            // labelConditionnement
            // 
            this.labelConditionnement.AutoSize = true;
            this.labelConditionnement.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelConditionnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelConditionnement.Location = new System.Drawing.Point(593, 123);
            this.labelConditionnement.Name = "labelConditionnement";
            this.labelConditionnement.Size = new System.Drawing.Size(107, 42);
            this.labelConditionnement.TabIndex = 17;
            this.labelConditionnement.Text = "Conditionnement";
            this.labelConditionnement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSuiviDeStock
            // 
            this.labelSuiviDeStock.AutoSize = true;
            this.labelSuiviDeStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSuiviDeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelSuiviDeStock.Location = new System.Drawing.Point(108, 123);
            this.labelSuiviDeStock.Name = "labelSuiviDeStock";
            this.labelSuiviDeStock.Size = new System.Drawing.Size(90, 42);
            this.labelSuiviDeStock.TabIndex = 15;
            this.labelSuiviDeStock.Text = "Suivi de stock";
            this.labelSuiviDeStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNomenclature
            // 
            this.labelNomenclature.AutoSize = true;
            this.labelNomenclature.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNomenclature.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelNomenclature.Location = new System.Drawing.Point(609, 82);
            this.labelNomenclature.Name = "labelNomenclature";
            this.labelNomenclature.Size = new System.Drawing.Size(91, 41);
            this.labelNomenclature.TabIndex = 13;
            this.labelNomenclature.Text = "Nomenclature";
            this.labelNomenclature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFamille
            // 
            this.labelFamille.AutoSize = true;
            this.labelFamille.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelFamille.Location = new System.Drawing.Point(147, 82);
            this.labelFamille.Name = "labelFamille";
            this.labelFamille.Size = new System.Drawing.Size(51, 41);
            this.labelFamille.TabIndex = 11;
            this.labelFamille.Text = "Famille";
            this.labelFamille.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelDesignation.Location = new System.Drawing.Point(119, 41);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(79, 41);
            this.labelDesignation.TabIndex = 4;
            this.labelDesignation.Text = "Désignation";
            this.labelDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(128, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 30);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(706, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(297, 30);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(204, 85);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(295, 30);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(706, 85);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(297, 30);
            this.comboBox4.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(204, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 28);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox2, 3);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(204, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(799, 28);
            this.textBox2.TabIndex = 24;
            // 
            // grpBxTarif
            // 
            this.grpBxTarif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxTarif.Location = new System.Drawing.Point(0, 0);
            this.grpBxTarif.Name = "grpBxTarif";
            this.grpBxTarif.Size = new System.Drawing.Size(1012, 425);
            this.grpBxTarif.TabIndex = 1;
            this.grpBxTarif.TabStop = false;
            this.grpBxTarif.Text = "Tarif";
            // 
            // DescriptifPage
            // 
            this.DescriptifPage.Location = new System.Drawing.Point(4, 25);
            this.DescriptifPage.Name = "DescriptifPage";
            this.DescriptifPage.Padding = new System.Windows.Forms.Padding(3);
            this.DescriptifPage.Size = new System.Drawing.Size(1018, 627);
            this.DescriptifPage.TabIndex = 1;
            this.DescriptifPage.Text = "Descriptif";
            this.DescriptifPage.UseVisualStyleBackColor = true;
            // 
            // ChampLibresPage
            // 
            this.ChampLibresPage.Location = new System.Drawing.Point(4, 25);
            this.ChampLibresPage.Name = "ChampLibresPage";
            this.ChampLibresPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChampLibresPage.Size = new System.Drawing.Size(1018, 627);
            this.ChampLibresPage.TabIndex = 2;
            this.ChampLibresPage.Text = "Champs libres";
            this.ChampLibresPage.UseVisualStyleBackColor = true;
            // 
            // ParametresPage
            // 
            this.ParametresPage.Location = new System.Drawing.Point(4, 25);
            this.ParametresPage.Name = "ParametresPage";
            this.ParametresPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParametresPage.Size = new System.Drawing.Size(1018, 627);
            this.ParametresPage.TabIndex = 3;
            this.ParametresPage.Text = "Paramètres";
            this.ParametresPage.UseVisualStyleBackColor = true;
            // 
            // DetailsArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailsArticle";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Article: ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.IdentificationPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpBxIdentification.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNomenclature;
        private System.Windows.Forms.Button btnInterroger;
        private System.Windows.Forms.Button btnTracabilite;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage IdentificationPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpBxIdentification;
        private System.Windows.Forms.GroupBox grpBxTarif;
        private System.Windows.Forms.TabPage DescriptifPage;
        private System.Windows.Forms.TabPage ChampLibresPage;
        private System.Windows.Forms.TabPage ParametresPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConditionnement;
        private System.Windows.Forms.Label labelSuiviDeStock;
        private System.Windows.Forms.Label labelNomenclature;
        private System.Windows.Forms.Label labelFamille;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}