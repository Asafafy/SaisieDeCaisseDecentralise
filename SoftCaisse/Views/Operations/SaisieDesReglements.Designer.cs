using System.Drawing;
using System.Windows.Forms;





namespace Soft_Caisse.Views.Operations
{
    partial class SaisieDesReglements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaisieDesReglements));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            buttonSelectionner = new Button();
            buttonReglerEtImputer = new Button();
            buttonVisualiser = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Caisse = new DataGridViewTextBoxColumn();
            Caissier = new DataGridViewTextBoxColumn();
            NPiece = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Libelle = new DataGridViewTextBoxColumn();
            CompteGeneral = new DataGridViewTextBoxColumn();
            Montant = new DataGridViewTextBoxColumn();
            CodeJournal = new DataGridViewTextBoxColumn();
            Etat = new DataGridViewTextBoxColumn();
            Solde = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            comboBoxTypeDocumentDeStock = new ComboBox();
            labelTypeDocumentStock = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            txtBxBarreDeRecherche = new TextBox();
            button3 = new Button();
            buttonOuvrir = new Button();
            buttonNouveau = new Button();
            buttonSupprimer = new Button();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label8 = new Label();
            labelSolde = new Label();
            label6 = new Label();
            labelTotalImpute = new Label();
            label4 = new Label();
            labelTotalReglement = new Label();
            buttonFermer = new Button();
            panel14 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSelectionner
            // 
            buttonSelectionner.BackColor = Color.AliceBlue;
            buttonSelectionner.Cursor = Cursors.Hand;
            buttonSelectionner.FlatAppearance.BorderSize = 0;
            buttonSelectionner.FlatStyle = FlatStyle.Flat;
            buttonSelectionner.Font = new Font("Segoe UI", 11F);
            buttonSelectionner.ForeColor = Color.FromArgb(29, 64, 102);
            buttonSelectionner.Image = (Image)resources.GetObject("buttonSelectionner.Image");
            buttonSelectionner.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectionner.Location = new Point(15, 12);
            buttonSelectionner.Margin = new Padding(15, 0, 5, 0);
            buttonSelectionner.Name = "buttonSelectionner";
            buttonSelectionner.Padding = new Padding(8, 0, 0, 0);
            buttonSelectionner.Size = new Size(190, 45);
            buttonSelectionner.TabIndex = 34;
            buttonSelectionner.Text = "Sélectionner";
            buttonSelectionner.UseVisualStyleBackColor = false;
            buttonSelectionner.Click += buttonSelectionner_Click;
            // 
            // buttonReglerEtImputer
            // 
            buttonReglerEtImputer.BackColor = Color.AliceBlue;
            buttonReglerEtImputer.Cursor = Cursors.Hand;
            buttonReglerEtImputer.FlatAppearance.BorderSize = 0;
            buttonReglerEtImputer.FlatStyle = FlatStyle.Flat;
            buttonReglerEtImputer.Font = new Font("Segoe UI", 11F);
            buttonReglerEtImputer.ForeColor = Color.FromArgb(29, 64, 102);
            buttonReglerEtImputer.Image = (Image)resources.GetObject("buttonReglerEtImputer.Image");
            buttonReglerEtImputer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReglerEtImputer.Location = new Point(220, 12);
            buttonReglerEtImputer.Margin = new Padding(10, 0, 5, 0);
            buttonReglerEtImputer.Name = "buttonReglerEtImputer";
            buttonReglerEtImputer.Padding = new Padding(8, 0, 0, 0);
            buttonReglerEtImputer.Size = new Size(190, 45);
            buttonReglerEtImputer.TabIndex = 35;
            buttonReglerEtImputer.Text = "     Règler et imputer";
            buttonReglerEtImputer.UseVisualStyleBackColor = false;
            buttonReglerEtImputer.Click += buttonReglerEtImputer_Click;
            // 
            // buttonVisualiser
            // 
            buttonVisualiser.BackColor = Color.AliceBlue;
            buttonVisualiser.Cursor = Cursors.Hand;
            buttonVisualiser.FlatAppearance.BorderSize = 0;
            buttonVisualiser.FlatStyle = FlatStyle.Flat;
            buttonVisualiser.Font = new Font("Segoe UI", 11F);
            buttonVisualiser.ForeColor = Color.FromArgb(29, 64, 102);
            buttonVisualiser.Image = (Image)resources.GetObject("buttonVisualiser.Image");
            buttonVisualiser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVisualiser.Location = new Point(425, 12);
            buttonVisualiser.Margin = new Padding(10, 0, 5, 0);
            buttonVisualiser.Name = "buttonVisualiser";
            buttonVisualiser.Padding = new Padding(8, 0, 0, 0);
            buttonVisualiser.Size = new Size(190, 45);
            buttonVisualiser.TabIndex = 36;
            buttonVisualiser.Text = "Visualiser";
            buttonVisualiser.UseVisualStyleBackColor = false;
            buttonVisualiser.Click += buttonVisualiser_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(230, 29, 64, 102);
            flowLayoutPanel1.Controls.Add(buttonSelectionner);
            flowLayoutPanel1.Controls.Add(buttonReglerEtImputer);
            flowLayoutPanel1.Controls.Add(buttonVisualiser);
            flowLayoutPanel1.Location = new Point(11, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 12, 0, 12);
            flowLayoutPanel1.Size = new Size(1203, 70);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(29, 64, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Caisse, Caissier, NPiece, Type, Libelle, CompteGeneral, Montant, CodeJournal, Etat, Solde });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(30, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(129, 166, 181);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(11, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1203, 336);
            dataGridView1.TabIndex = 42;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Caisse
            // 
            Caisse.HeaderText = "Caisse";
            Caisse.Name = "Caisse";
            // 
            // Caissier
            // 
            Caissier.HeaderText = "Caissier";
            Caissier.Name = "Caissier";
            // 
            // NPiece
            // 
            NPiece.HeaderText = "N° Piece";
            NPiece.Name = "NPiece";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Libelle
            // 
            Libelle.HeaderText = "Libellé";
            Libelle.Name = "Libelle";
            // 
            // CompteGeneral
            // 
            CompteGeneral.HeaderText = "Compte général";
            CompteGeneral.Name = "CompteGeneral";
            // 
            // Montant
            // 
            Montant.HeaderText = "Montant";
            Montant.Name = "Montant";
            // 
            // CodeJournal
            // 
            CodeJournal.HeaderText = "Code journal";
            CodeJournal.Name = "CodeJournal";
            // 
            // Etat
            // 
            Etat.HeaderText = "Etat";
            Etat.Name = "Etat";
            // 
            // Solde
            // 
            Solde.HeaderText = "Solde";
            Solde.Name = "Solde";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Controls.Add(labelTypeDocumentStock, 0, 0);
            tableLayoutPanel1.Location = new Point(11, 124);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(263, 87);
            tableLayoutPanel1.TabIndex = 43;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxTypeDocumentDeStock);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 43);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(257, 34);
            panel6.TabIndex = 34;
            // 
            // comboBoxTypeDocumentDeStock
            // 
            comboBoxTypeDocumentDeStock.Dock = DockStyle.Fill;
            comboBoxTypeDocumentDeStock.FlatStyle = FlatStyle.Flat;
            comboBoxTypeDocumentDeStock.FormattingEnabled = true;
            comboBoxTypeDocumentDeStock.Location = new Point(20, 5);
            comboBoxTypeDocumentDeStock.Name = "comboBoxTypeDocumentDeStock";
            comboBoxTypeDocumentDeStock.Size = new Size(231, 23);
            comboBoxTypeDocumentDeStock.TabIndex = 0;
            // 
            // labelTypeDocumentStock
            // 
            labelTypeDocumentStock.AutoSize = true;
            labelTypeDocumentStock.Dock = DockStyle.Left;
            labelTypeDocumentStock.Location = new Point(3, 0);
            labelTypeDocumentStock.Name = "labelTypeDocumentStock";
            labelTypeDocumentStock.Size = new Size(154, 40);
            labelTypeDocumentStock.TabIndex = 35;
            labelTypeDocumentStock.Text = "Type du document de stock";
            labelTypeDocumentStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(button3, 1, 1);
            tableLayoutPanel2.Location = new Point(742, 154);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(472, 57);
            tableLayoutPanel2.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxBarreDeRecherche);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 10);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 11, 20, 10);
            panel2.Size = new Size(427, 40);
            panel2.TabIndex = 26;
            // 
            // txtBxBarreDeRecherche
            // 
            txtBxBarreDeRecherche.BorderStyle = BorderStyle.None;
            txtBxBarreDeRecherche.Dock = DockStyle.Fill;
            txtBxBarreDeRecherche.Location = new Point(20, 11);
            txtBxBarreDeRecherche.Name = "txtBxBarreDeRecherche";
            //txtBxBarreDeRecherche.PlaceholderText = "Mots à rechercher";
            txtBxBarreDeRecherche.Size = new Size(385, 16);
            txtBxBarreDeRecherche.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(29, 64, 102);
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = Color.AliceBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(427, 10);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(45, 40);
            button3.TabIndex = 25;
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonOuvrir
            // 
            buttonOuvrir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOuvrir.BackColor = Color.FromArgb(129, 166, 181);
            buttonOuvrir.Cursor = Cursors.Hand;
            buttonOuvrir.FlatAppearance.BorderSize = 0;
            buttonOuvrir.FlatStyle = FlatStyle.Flat;
            buttonOuvrir.Font = new Font("Segoe UI", 11F);
            buttonOuvrir.ForeColor = Color.White;
            buttonOuvrir.Location = new Point(628, 578);
            buttonOuvrir.Margin = new Padding(144, 3, 144, 3);
            buttonOuvrir.Name = "buttonOuvrir";
            buttonOuvrir.Padding = new Padding(8, 0, 0, 0);
            buttonOuvrir.Size = new Size(190, 45);
            buttonOuvrir.TabIndex = 47;
            buttonOuvrir.Text = "Ouvrir";
            buttonOuvrir.UseVisualStyleBackColor = false;
            buttonOuvrir.Click += buttonOuvrir_Click;
            // 
            // buttonNouveau
            // 
            buttonNouveau.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNouveau.BackColor = Color.FromArgb(129, 166, 181);
            buttonNouveau.Cursor = Cursors.Hand;
            buttonNouveau.FlatAppearance.BorderSize = 0;
            buttonNouveau.FlatStyle = FlatStyle.Flat;
            buttonNouveau.Font = new Font("Segoe UI", 11F);
            buttonNouveau.ForeColor = Color.White;
            buttonNouveau.Location = new Point(826, 578);
            buttonNouveau.Margin = new Padding(144, 3, 144, 3);
            buttonNouveau.Name = "buttonNouveau";
            buttonNouveau.Padding = new Padding(8, 0, 0, 0);
            buttonNouveau.Size = new Size(190, 45);
            buttonNouveau.TabIndex = 46;
            buttonNouveau.Text = "Nouveau";
            buttonNouveau.UseVisualStyleBackColor = false;
            buttonNouveau.Click += buttonNouveau_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.FlatAppearance.BorderSize = 0;
            buttonSupprimer.FlatStyle = FlatStyle.Flat;
            buttonSupprimer.Font = new Font("Segoe UI", 11F);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(1024, 578);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(190, 45);
            buttonSupprimer.TabIndex = 45;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(84, 138, 178);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Location = new Point(11, 664);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(505, 167);
            panel1.TabIndex = 48;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Controls.Add(label8, 1, 3);
            tableLayoutPanel3.Controls.Add(labelSolde, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 1, 2);
            tableLayoutPanel3.Controls.Add(labelTotalImpute, 0, 2);
            tableLayoutPanel3.Controls.Add(label4, 1, 1);
            tableLayoutPanel3.Controls.Add(labelTotalReglement, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(12, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Size = new Size(481, 143);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(198, 90);
            label8.Margin = new Padding(30, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 40);
            label8.TabIndex = 7;
            label8.Text = "5 000Ar";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSolde
            // 
            labelSolde.AutoSize = true;
            labelSolde.Dock = DockStyle.Right;
            labelSolde.Font = new Font("Segoe UI", 10F);
            labelSolde.ForeColor = Color.White;
            labelSolde.Location = new Point(116, 90);
            labelSolde.Name = "labelSolde";
            labelSolde.Size = new Size(49, 40);
            labelSolde.TabIndex = 6;
            labelSolde.Text = "Solde :";
            labelSolde.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(198, 50);
            label6.Margin = new Padding(30, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 40);
            label6.TabIndex = 5;
            label6.Text = "2 000Ar";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotalImpute
            // 
            labelTotalImpute.AutoSize = true;
            labelTotalImpute.Dock = DockStyle.Right;
            labelTotalImpute.Font = new Font("Segoe UI", 10F);
            labelTotalImpute.ForeColor = Color.White;
            labelTotalImpute.Location = new Point(73, 50);
            labelTotalImpute.Name = "labelTotalImpute";
            labelTotalImpute.Size = new Size(92, 40);
            labelTotalImpute.TabIndex = 4;
            labelTotalImpute.Text = "Total imputé :";
            labelTotalImpute.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(198, 10);
            label4.Margin = new Padding(30, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 40);
            label4.TabIndex = 3;
            label4.Text = "10 000Ar";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotalReglement
            // 
            labelTotalReglement.AutoSize = true;
            labelTotalReglement.Dock = DockStyle.Right;
            labelTotalReglement.Font = new Font("Segoe UI", 10F);
            labelTotalReglement.ForeColor = Color.White;
            labelTotalReglement.Location = new Point(48, 10);
            labelTotalReglement.Name = "labelTotalReglement";
            labelTotalReglement.Size = new Size(117, 40);
            labelTotalReglement.TabIndex = 0;
            labelTotalReglement.Text = "Total règlements :";
            labelTotalReglement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonFermer
            // 
            buttonFermer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFermer.BackColor = Color.FromArgb(84, 138, 178);
            buttonFermer.Cursor = Cursors.Hand;
            buttonFermer.FlatAppearance.BorderSize = 0;
            buttonFermer.FlatStyle = FlatStyle.Flat;
            buttonFermer.Font = new Font("Segoe UI", 11F);
            buttonFermer.ForeColor = Color.White;
            buttonFermer.Location = new Point(1024, 786);
            buttonFermer.Margin = new Padding(144, 3, 144, 3);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Padding = new Padding(8, 0, 0, 0);
            buttonFermer.Size = new Size(190, 45);
            buttonFermer.TabIndex = 49;
            buttonFermer.Text = "Fermer";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(29, 64, 102);
            panel14.Location = new Point(11, 635);
            panel14.Name = "panel14";
            panel14.Size = new Size(1202, 5);
            panel14.TabIndex = 50;
            // 
            // iconButtonFermer
            // 
            iconButtonFermer.BackColor = Color.FromArgb(84, 138, 178);
            iconButtonFermer.Cursor = Cursors.Hand;
            iconButtonFermer.FlatAppearance.BorderColor = Color.FromArgb(29, 64, 102);
            iconButtonFermer.FlatAppearance.BorderSize = 0;
            iconButtonFermer.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButtonFermer.IconColor = Color.White;
            iconButtonFermer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonFermer.IconSize = 33;
            iconButtonFermer.Location = new Point(1215, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 72;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // SaisieDesReglements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1262, 845);
            Controls.Add(iconButtonFermer);
            Controls.Add(panel14);
            Controls.Add(buttonFermer);
            Controls.Add(panel1);
            Controls.Add(buttonOuvrir);
            Controls.Add(buttonNouveau);
            Controls.Add(buttonSupprimer);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Name = "SaisieDesReglements";
            Text = "Saisie des règlements";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonSelectionner;
        private Button buttonReglerEtImputer;
        private Button buttonVisualiser;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private ComboBox comboBoxTypeDocumentDeStock;
        private Label labelTypeDocumentStock;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private TextBox txtBxBarreDeRecherche;
        private Button button3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Caisse;
        private DataGridViewTextBoxColumn Caissier;
        private DataGridViewTextBoxColumn NPiece;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn CompteGeneral;
        private DataGridViewTextBoxColumn Montant;
        private DataGridViewTextBoxColumn CodeJournal;
        private DataGridViewTextBoxColumn Etat;
        private DataGridViewTextBoxColumn Solde;
        private Button buttonOuvrir;
        private Button buttonNouveau;
        private Button buttonSupprimer;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelTotalReglement;
        private Label label8;
        private Label labelSolde;
        private Label label6;
        private Label labelTotalImpute;
        private Label label4;
        private Button buttonFermer;
        private Panel panel14;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}