using System.Drawing;
using System.Windows.Forms;








namespace Soft_Caisse.Views.Operations.DocumentsDesVentesChildForm
{
    partial class CreateDocumentDeVente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDocumentDeVente));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonInformations = new Button();
            buttonValider = new Button();
            buttonImprimer = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            comboBoxRepresentant = new ComboBox();
            panel6 = new Panel();
            comboBoxExpedition = new ComboBox();
            panel7 = new Panel();
            comboBoxDepot = new ComboBox();
            labelExpedition = new Label();
            labelDepot = new Label();
            panel10 = new Panel();
            comboBoxAffaire = new ComboBox();
            labelRepresentant = new Label();
            labelAffaire = new Label();
            panelEnTete = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            textBoxDivers = new TextBox();
            panel4 = new Panel();
            textBoxReferenceDocEnTete = new TextBox();
            panel1 = new Panel();
            comboBoxClient = new ComboBox();
            panel5 = new Panel();
            textBoxCommentaires = new TextBox();
            labelCommentaires = new Label();
            labelClient = new Label();
            labelDivers = new Label();
            labelReference = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonNumeroDocument = new Button();
            panel12 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            dateTimePickerDateLivraisonRealisee = new DateTimePicker();
            textBoxDateLivraisonRealisee = new TextBox();
            panel13 = new Panel();
            dateTimePickerDateLivraisonPrevue = new DateTimePicker();
            textBoxDateLivraisonPrevue = new TextBox();
            labelDateLivraisonRealisee = new Label();
            panel11 = new Panel();
            dateTimePickerDate = new DateTimePicker();
            textBoxDate = new TextBox();
            label2 = new Label();
            labelDateLivraisonPrevue = new Label();
            buttonValiderLEnTete = new Button();
            panel14 = new Panel();
            panel15 = new Panel();
            buttonEnregistrer = new Button();
            buttonSupprimer = new Button();
            buttonNouveau = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel31 = new Panel();
            textBoxMontantTTC = new TextBox();
            panel30 = new Panel();
            textBoxMontantHT = new TextBox();
            panel27 = new Panel();
            textBoxPUNet = new TextBox();
            panel26 = new Panel();
            textBoxRemise = new TextBox();
            panel25 = new Panel();
            textBoxConditionnement = new TextBox();
            panel24 = new Panel();
            textBoxQuantite = new TextBox();
            panel23 = new Panel();
            textBoxPUTTC = new TextBox();
            panel22 = new Panel();
            textBoxPUHT = new TextBox();
            panel21 = new Panel();
            textBoxGamme2 = new TextBox();
            panel20 = new Panel();
            textBoxGamme1 = new TextBox();
            panel19 = new Panel();
            textBoxDesignation = new TextBox();
            panel18 = new Panel();
            textBoxReference = new TextBox();
            dataGridView1 = new DataGridView();
            Reference = new DataGridViewTextBoxColumn();
            Designation = new DataGridViewTextBoxColumn();
            Gamme1 = new DataGridViewTextBoxColumn();
            Gamme2 = new DataGridViewTextBoxColumn();
            PuHT = new DataGridViewTextBoxColumn();
            PuTTC = new DataGridViewTextBoxColumn();
            Quantite = new DataGridViewTextBoxColumn();
            Conditionnement = new DataGridViewTextBoxColumn();
            Remise = new DataGridViewTextBoxColumn();
            PuNet = new DataGridViewTextBoxColumn();
            MontantHT = new DataGridViewTextBoxColumn();
            MontantTTC = new DataGridViewTextBoxColumn();
            buttonFermer = new Button();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panelEnTete.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
            panel13.SuspendLayout();
            panel11.SuspendLayout();
            panel15.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel31.SuspendLayout();
            panel30.SuspendLayout();
            panel27.SuspendLayout();
            panel26.SuspendLayout();
            panel25.SuspendLayout();
            panel24.SuspendLayout();
            panel23.SuspendLayout();
            panel22.SuspendLayout();
            panel21.SuspendLayout();
            panel20.SuspendLayout();
            panel19.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(230, 29, 64, 102);
            flowLayoutPanel1.Controls.Add(buttonInformations);
            flowLayoutPanel1.Controls.Add(buttonValider);
            flowLayoutPanel1.Controls.Add(buttonImprimer);
            flowLayoutPanel1.Location = new Point(12, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 12, 0, 12);
            flowLayoutPanel1.Size = new Size(1203, 70);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // buttonInformations
            // 
            buttonInformations.BackColor = Color.AliceBlue;
            buttonInformations.Cursor = Cursors.Hand;
            buttonInformations.FlatAppearance.BorderSize = 0;
            buttonInformations.FlatStyle = FlatStyle.Flat;
            buttonInformations.Font = new Font("Segoe UI", 11F);
            buttonInformations.ForeColor = Color.FromArgb(29, 64, 102);
            buttonInformations.Image = (Image)resources.GetObject("buttonInformations.Image");
            buttonInformations.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInformations.Location = new Point(15, 12);
            buttonInformations.Margin = new Padding(15, 0, 5, 0);
            buttonInformations.Name = "buttonInformations";
            buttonInformations.Padding = new Padding(8, 0, 0, 0);
            buttonInformations.Size = new Size(190, 45);
            buttonInformations.TabIndex = 34;
            buttonInformations.Text = "Informations";
            buttonInformations.UseVisualStyleBackColor = false;
            // 
            // buttonValider
            // 
            buttonValider.BackColor = Color.AliceBlue;
            buttonValider.Cursor = Cursors.Hand;
            buttonValider.FlatAppearance.BorderSize = 0;
            buttonValider.FlatStyle = FlatStyle.Flat;
            buttonValider.Font = new Font("Segoe UI", 11F);
            buttonValider.ForeColor = Color.FromArgb(29, 64, 102);
            buttonValider.Image = (Image)resources.GetObject("buttonValider.Image");
            buttonValider.ImageAlign = ContentAlignment.MiddleLeft;
            buttonValider.Location = new Point(220, 12);
            buttonValider.Margin = new Padding(10, 0, 5, 0);
            buttonValider.Name = "buttonValider";
            buttonValider.Padding = new Padding(8, 0, 0, 0);
            buttonValider.Size = new Size(190, 45);
            buttonValider.TabIndex = 35;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = false;
            // 
            // buttonImprimer
            // 
            buttonImprimer.BackColor = Color.AliceBlue;
            buttonImprimer.Cursor = Cursors.Hand;
            buttonImprimer.FlatAppearance.BorderSize = 0;
            buttonImprimer.FlatStyle = FlatStyle.Flat;
            buttonImprimer.Font = new Font("Segoe UI", 11F);
            buttonImprimer.ForeColor = Color.FromArgb(29, 64, 102);
            buttonImprimer.Image = (Image)resources.GetObject("buttonImprimer.Image");
            buttonImprimer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonImprimer.Location = new Point(425, 12);
            buttonImprimer.Margin = new Padding(10, 0, 5, 0);
            buttonImprimer.Name = "buttonImprimer";
            buttonImprimer.Padding = new Padding(8, 0, 0, 0);
            buttonImprimer.Size = new Size(190, 45);
            buttonImprimer.TabIndex = 36;
            buttonImprimer.Text = "Imprimer";
            buttonImprimer.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panelEnTete, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 139);
            tableLayoutPanel1.Margin = new Padding(5, 5, 0, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1202, 195);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(230, 29, 64, 102);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(405, 5);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(12);
            panel3.Size = new Size(390, 185);
            panel3.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel3.Controls.Add(panel9, 1, 3);
            tableLayoutPanel3.Controls.Add(panel6, 1, 2);
            tableLayoutPanel3.Controls.Add(panel7, 1, 0);
            tableLayoutPanel3.Controls.Add(labelExpedition, 0, 2);
            tableLayoutPanel3.Controls.Add(labelDepot, 0, 0);
            tableLayoutPanel3.Controls.Add(panel10, 1, 1);
            tableLayoutPanel3.Controls.Add(labelRepresentant, 0, 3);
            tableLayoutPanel3.Controls.Add(labelAffaire, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(12, 12);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(366, 161);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(comboBoxRepresentant);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(127, 123);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 5, 4, 0);
            panel9.Size = new Size(236, 35);
            panel9.TabIndex = 47;
            // 
            // comboBoxRepresentant
            // 
            comboBoxRepresentant.Dock = DockStyle.Fill;
            comboBoxRepresentant.FlatStyle = FlatStyle.Flat;
            comboBoxRepresentant.FormattingEnabled = true;
            comboBoxRepresentant.Location = new Point(20, 5);
            comboBoxRepresentant.Name = "comboBoxRepresentant";
            comboBoxRepresentant.Size = new Size(210, 23);
            comboBoxRepresentant.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboBoxExpedition);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(127, 83);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 5, 4, 0);
            panel6.Size = new Size(236, 34);
            panel6.TabIndex = 46;
            // 
            // comboBoxExpedition
            // 
            comboBoxExpedition.Dock = DockStyle.Fill;
            comboBoxExpedition.FlatStyle = FlatStyle.Flat;
            comboBoxExpedition.FormattingEnabled = true;
            comboBoxExpedition.Location = new Point(20, 5);
            comboBoxExpedition.Name = "comboBoxExpedition";
            comboBoxExpedition.Size = new Size(210, 23);
            comboBoxExpedition.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(comboBoxDepot);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(127, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 5, 4, 0);
            panel7.Size = new Size(236, 34);
            panel7.TabIndex = 44;
            // 
            // comboBoxDepot
            // 
            comboBoxDepot.Dock = DockStyle.Fill;
            comboBoxDepot.FlatStyle = FlatStyle.Flat;
            comboBoxDepot.FormattingEnabled = true;
            comboBoxDepot.Location = new Point(20, 5);
            comboBoxDepot.Name = "comboBoxDepot";
            comboBoxDepot.Size = new Size(210, 23);
            comboBoxDepot.TabIndex = 0;
            // 
            // labelExpedition
            // 
            labelExpedition.AutoSize = true;
            labelExpedition.Dock = DockStyle.Right;
            labelExpedition.ForeColor = Color.White;
            labelExpedition.Location = new Point(59, 80);
            labelExpedition.Name = "labelExpedition";
            labelExpedition.Size = new Size(62, 40);
            labelExpedition.TabIndex = 38;
            labelExpedition.Text = "Expédition";
            labelExpedition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDepot
            // 
            labelDepot.AutoSize = true;
            labelDepot.Dock = DockStyle.Right;
            labelDepot.ForeColor = Color.White;
            labelDepot.Location = new Point(82, 0);
            labelDepot.Name = "labelDepot";
            labelDepot.Size = new Size(39, 40);
            labelDepot.TabIndex = 33;
            labelDepot.Text = "Dépôt";
            labelDepot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(comboBoxAffaire);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(127, 43);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 5, 4, 0);
            panel10.Size = new Size(236, 34);
            panel10.TabIndex = 27;
            // 
            // comboBoxAffaire
            // 
            comboBoxAffaire.Dock = DockStyle.Fill;
            comboBoxAffaire.FlatStyle = FlatStyle.Flat;
            comboBoxAffaire.FormattingEnabled = true;
            comboBoxAffaire.Location = new Point(20, 5);
            comboBoxAffaire.Name = "comboBoxAffaire";
            comboBoxAffaire.Size = new Size(210, 23);
            comboBoxAffaire.TabIndex = 0;
            // 
            // labelRepresentant
            // 
            labelRepresentant.AutoSize = true;
            labelRepresentant.Dock = DockStyle.Right;
            labelRepresentant.ForeColor = Color.White;
            labelRepresentant.Location = new Point(45, 120);
            labelRepresentant.Name = "labelRepresentant";
            labelRepresentant.Size = new Size(76, 41);
            labelRepresentant.TabIndex = 12;
            labelRepresentant.Text = "Représentant";
            labelRepresentant.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAffaire
            // 
            labelAffaire.AutoSize = true;
            labelAffaire.Dock = DockStyle.Right;
            labelAffaire.ForeColor = Color.White;
            labelAffaire.Location = new Point(79, 40);
            labelAffaire.Name = "labelAffaire";
            labelAffaire.Size = new Size(42, 40);
            labelAffaire.TabIndex = 8;
            labelAffaire.Text = "Affaire";
            labelAffaire.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelEnTete
            // 
            panelEnTete.BackColor = Color.FromArgb(230, 29, 64, 102);
            panelEnTete.Controls.Add(tableLayoutPanel2);
            panelEnTete.Dock = DockStyle.Fill;
            panelEnTete.Location = new Point(0, 5);
            panelEnTete.Margin = new Padding(0, 5, 5, 5);
            panelEnTete.Name = "panelEnTete";
            panelEnTete.Padding = new Padding(12);
            panelEnTete.Size = new Size(395, 185);
            panelEnTete.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.Controls.Add(panel8, 1, 3);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(panel5, 1, 2);
            tableLayoutPanel2.Controls.Add(labelCommentaires, 0, 2);
            tableLayoutPanel2.Controls.Add(labelClient, 0, 0);
            tableLayoutPanel2.Controls.Add(labelDivers, 0, 3);
            tableLayoutPanel2.Controls.Add(labelReference, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(371, 161);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(textBoxDivers);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(129, 123);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 9, 20, 10);
            panel8.Size = new Size(239, 35);
            panel8.TabIndex = 45;
            // 
            // textBoxDivers
            // 
            textBoxDivers.BorderStyle = BorderStyle.None;
            textBoxDivers.Dock = DockStyle.Fill;
            textBoxDivers.Location = new Point(20, 9);
            textBoxDivers.Name = "textBoxDivers";
            //textBoxDivers.PlaceholderText = "Divers";
            textBoxDivers.Size = new Size(197, 16);
            textBoxDivers.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBoxReferenceDocEnTete);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(129, 43);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(239, 34);
            panel4.TabIndex = 44;
            // 
            // textBoxReferenceDocEnTete
            // 
            textBoxReferenceDocEnTete.BorderStyle = BorderStyle.None;
            textBoxReferenceDocEnTete.Dock = DockStyle.Fill;
            textBoxReferenceDocEnTete.Location = new Point(20, 9);
            textBoxReferenceDocEnTete.Name = "textBoxReferenceDocEnTete";
            //textBoxReferenceDocEnTete.PlaceholderText = "Référence";
            textBoxReferenceDocEnTete.Size = new Size(197, 16);
            textBoxReferenceDocEnTete.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxClient);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(129, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 5, 4, 0);
            panel1.Size = new Size(239, 34);
            panel1.TabIndex = 43;
            // 
            // comboBoxClient
            // 
            comboBoxClient.Dock = DockStyle.Fill;
            comboBoxClient.FlatStyle = FlatStyle.Flat;
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(20, 5);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(213, 23);
            comboBoxClient.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBoxCommentaires);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(129, 83);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(239, 34);
            panel5.TabIndex = 39;
            // 
            // textBoxCommentaires
            // 
            textBoxCommentaires.BorderStyle = BorderStyle.None;
            textBoxCommentaires.Dock = DockStyle.Fill;
            textBoxCommentaires.Location = new Point(20, 9);
            textBoxCommentaires.Name = "textBoxCommentaires";
            //textBoxCommentaires.PlaceholderText = "Commentaires";
            textBoxCommentaires.Size = new Size(197, 16);
            textBoxCommentaires.TabIndex = 0;
            // 
            // labelCommentaires
            // 
            labelCommentaires.AutoSize = true;
            labelCommentaires.Dock = DockStyle.Right;
            labelCommentaires.ForeColor = Color.White;
            labelCommentaires.Location = new Point(38, 80);
            labelCommentaires.Name = "labelCommentaires";
            labelCommentaires.Size = new Size(85, 40);
            labelCommentaires.TabIndex = 38;
            labelCommentaires.Text = "Commentaires";
            labelCommentaires.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Dock = DockStyle.Right;
            labelClient.ForeColor = Color.White;
            labelClient.Location = new Point(85, 0);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(38, 40);
            labelClient.TabIndex = 33;
            labelClient.Text = "Client";
            labelClient.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDivers
            // 
            labelDivers.AutoSize = true;
            labelDivers.Dock = DockStyle.Right;
            labelDivers.ForeColor = Color.White;
            labelDivers.Location = new Point(84, 120);
            labelDivers.Name = "labelDivers";
            labelDivers.Size = new Size(39, 41);
            labelDivers.TabIndex = 12;
            labelDivers.Text = "Divers";
            labelDivers.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelReference
            // 
            labelReference.AutoSize = true;
            labelReference.Dock = DockStyle.Right;
            labelReference.ForeColor = Color.White;
            labelReference.Location = new Point(64, 40);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(59, 40);
            labelReference.TabIndex = 8;
            labelReference.Text = "Référence";
            labelReference.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(buttonNumeroDocument, 0, 0);
            tableLayoutPanel4.Controls.Add(panel12, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(805, 5);
            tableLayoutPanel4.Margin = new Padding(5, 5, 0, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25.9459457F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 74.0540543F));
            tableLayoutPanel4.Size = new Size(397, 185);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // buttonNumeroDocument
            // 
            buttonNumeroDocument.BackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroDocument.Dock = DockStyle.Top;
            buttonNumeroDocument.FlatAppearance.BorderSize = 0;
            buttonNumeroDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 138, 178);
            buttonNumeroDocument.FlatStyle = FlatStyle.Flat;
            buttonNumeroDocument.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNumeroDocument.ForeColor = Color.White;
            buttonNumeroDocument.Location = new Point(0, 0);
            buttonNumeroDocument.Margin = new Padding(0);
            buttonNumeroDocument.Name = "buttonNumeroDocument";
            buttonNumeroDocument.Size = new Size(397, 39);
            buttonNumeroDocument.TabIndex = 36;
            buttonNumeroDocument.Text = "FA00010";
            buttonNumeroDocument.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(230, 29, 64, 102);
            panel12.Controls.Add(tableLayoutPanel5);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 48);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(12, 8, 12, 12);
            panel12.Size = new Size(397, 137);
            panel12.TabIndex = 37;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel5.Controls.Add(panel2, 1, 2);
            tableLayoutPanel5.Controls.Add(panel13, 1, 1);
            tableLayoutPanel5.Controls.Add(labelDateLivraisonRealisee, 0, 2);
            tableLayoutPanel5.Controls.Add(panel11, 1, 0);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(labelDateLivraisonPrevue, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(12, 8);
            tableLayoutPanel5.Margin = new Padding(12);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.Size = new Size(373, 117);
            tableLayoutPanel5.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateTimePickerDateLivraisonRealisee);
            panel2.Controls.Add(textBoxDateLivraisonRealisee);
            panel2.Location = new Point(129, 83);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(241, 34);
            panel2.TabIndex = 43;
            // 
            // dateTimePickerDateLivraisonRealisee
            // 
            dateTimePickerDateLivraisonRealisee.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateLivraisonRealisee.Location = new Point(1, 34);
            dateTimePickerDateLivraisonRealisee.Name = "dateTimePickerDateLivraisonRealisee";
            dateTimePickerDateLivraisonRealisee.Size = new Size(158, 23);
            dateTimePickerDateLivraisonRealisee.TabIndex = 25;
            dateTimePickerDateLivraisonRealisee.ValueChanged += dateTimePickerDateLivraisonRealisee_ValueChanged;
            // 
            // textBoxDateLivraisonRealisee
            // 
            textBoxDateLivraisonRealisee.BorderStyle = BorderStyle.None;
            textBoxDateLivraisonRealisee.Dock = DockStyle.Fill;
            textBoxDateLivraisonRealisee.Location = new Point(20, 9);
            textBoxDateLivraisonRealisee.Name = "textBoxDateLivraisonRealisee";
            //textBoxDateLivraisonRealisee.PlaceholderText = "DD/MM/YYYY";
            textBoxDateLivraisonRealisee.Size = new Size(199, 16);
            textBoxDateLivraisonRealisee.TabIndex = 0;
            textBoxDateLivraisonRealisee.Click += textBoxDateLivraisonRealisee_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(dateTimePickerDateLivraisonPrevue);
            panel13.Controls.Add(textBoxDateLivraisonPrevue);
            panel13.Location = new Point(129, 43);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(20, 9, 20, 10);
            panel13.Size = new Size(241, 34);
            panel13.TabIndex = 44;
            // 
            // dateTimePickerDateLivraisonPrevue
            // 
            dateTimePickerDateLivraisonPrevue.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDateLivraisonPrevue.Location = new Point(1, 34);
            dateTimePickerDateLivraisonPrevue.Name = "dateTimePickerDateLivraisonPrevue";
            dateTimePickerDateLivraisonPrevue.Size = new Size(158, 23);
            dateTimePickerDateLivraisonPrevue.TabIndex = 25;
            dateTimePickerDateLivraisonPrevue.ValueChanged += dateTimePickerDateLivraisonPrevue_ValueChanged;
            // 
            // textBoxDateLivraisonPrevue
            // 
            textBoxDateLivraisonPrevue.BorderStyle = BorderStyle.None;
            textBoxDateLivraisonPrevue.Dock = DockStyle.Fill;
            textBoxDateLivraisonPrevue.Location = new Point(20, 9);
            textBoxDateLivraisonPrevue.Name = "textBoxDateLivraisonPrevue";
            //textBoxDateLivraisonPrevue.PlaceholderText = "DD/MM/YYYY";
            textBoxDateLivraisonPrevue.Size = new Size(199, 16);
            textBoxDateLivraisonPrevue.TabIndex = 0;
            textBoxDateLivraisonPrevue.Click += textBoxDateLivraisonPrevue_Click;
            // 
            // labelDateLivraisonRealisee
            // 
            labelDateLivraisonRealisee.AutoSize = true;
            labelDateLivraisonRealisee.Dock = DockStyle.Right;
            labelDateLivraisonRealisee.ForeColor = Color.White;
            labelDateLivraisonRealisee.Location = new Point(3, 80);
            labelDateLivraisonRealisee.Name = "labelDateLivraisonRealisee";
            labelDateLivraisonRealisee.Size = new Size(120, 40);
            labelDateLivraisonRealisee.TabIndex = 38;
            labelDateLivraisonRealisee.Text = "Date livraison réalisée";
            labelDateLivraisonRealisee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(dateTimePickerDate);
            panel11.Controls.Add(textBoxDate);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(129, 3);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 9, 20, 10);
            panel11.Size = new Size(241, 34);
            panel11.TabIndex = 34;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CalendarTrailingForeColor = Color.Transparent;
            dateTimePickerDate.Location = new Point(1, 34);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(158, 23);
            dateTimePickerDate.TabIndex = 25;
            dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Dock = DockStyle.Fill;
            textBoxDate.Location = new Point(20, 9);
            textBoxDate.Name = "textBoxDate";
            //textBoxDate.PlaceholderText = "DD/MM/YYYY";
            textBoxDate.Size = new Size(199, 16);
            textBoxDate.TabIndex = 0;
            textBoxDate.Click += textBoxDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 40);
            label2.TabIndex = 33;
            label2.Text = "Date";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDateLivraisonPrevue
            // 
            labelDateLivraisonPrevue.AutoSize = true;
            labelDateLivraisonPrevue.Dock = DockStyle.Right;
            labelDateLivraisonPrevue.ForeColor = Color.White;
            labelDateLivraisonPrevue.Location = new Point(6, 40);
            labelDateLivraisonPrevue.Name = "labelDateLivraisonPrevue";
            labelDateLivraisonPrevue.Size = new Size(117, 40);
            labelDateLivraisonPrevue.TabIndex = 8;
            labelDateLivraisonPrevue.Text = "Date livraison prévue";
            labelDateLivraisonPrevue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonValiderLEnTete
            // 
            buttonValiderLEnTete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonValiderLEnTete.BackColor = Color.FromArgb(129, 166, 181);
            buttonValiderLEnTete.Cursor = Cursors.Hand;
            buttonValiderLEnTete.FlatAppearance.BorderSize = 0;
            buttonValiderLEnTete.FlatStyle = FlatStyle.Flat;
            buttonValiderLEnTete.Font = new Font("Segoe UI", 11F);
            buttonValiderLEnTete.ForeColor = Color.White;
            buttonValiderLEnTete.Location = new Point(1030, 339);
            buttonValiderLEnTete.Margin = new Padding(144, 3, 144, 3);
            buttonValiderLEnTete.Name = "buttonValiderLEnTete";
            buttonValiderLEnTete.Padding = new Padding(8, 0, 0, 0);
            buttonValiderLEnTete.Size = new Size(185, 45);
            buttonValiderLEnTete.TabIndex = 38;
            buttonValiderLEnTete.Text = "Valider l'en-tête";
            buttonValiderLEnTete.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(29, 64, 102);
            panel14.Location = new Point(12, 399);
            panel14.Name = "panel14";
            panel14.Size = new Size(1202, 5);
            panel14.TabIndex = 39;
            // 
            // panel15
            // 
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(buttonEnregistrer);
            panel15.Controls.Add(buttonSupprimer);
            panel15.Controls.Add(buttonNouveau);
            panel15.Controls.Add(tableLayoutPanel6);
            panel15.Location = new Point(12, 419);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(12);
            panel15.Size = new Size(1202, 136);
            panel15.TabIndex = 40;
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.Anchor = AnchorStyles.Right;
            buttonEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            buttonEnregistrer.Cursor = Cursors.Hand;
            buttonEnregistrer.FlatAppearance.BorderSize = 0;
            buttonEnregistrer.FlatStyle = FlatStyle.Flat;
            buttonEnregistrer.Font = new Font("Segoe UI", 11F);
            buttonEnregistrer.ForeColor = Color.White;
            buttonEnregistrer.Location = new Point(1003, 75);
            buttonEnregistrer.Margin = new Padding(144, 3, 144, 3);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Padding = new Padding(8, 0, 0, 0);
            buttonEnregistrer.Size = new Size(185, 45);
            buttonEnregistrer.TabIndex = 34;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Anchor = AnchorStyles.Right;
            buttonSupprimer.BackColor = Color.FromArgb(129, 166, 181);
            buttonSupprimer.Cursor = Cursors.Hand;
            buttonSupprimer.FlatAppearance.BorderSize = 0;
            buttonSupprimer.FlatStyle = FlatStyle.Flat;
            buttonSupprimer.Font = new Font("Segoe UI", 11F);
            buttonSupprimer.ForeColor = Color.White;
            buttonSupprimer.Location = new Point(809, 75);
            buttonSupprimer.Margin = new Padding(144, 3, 144, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Padding = new Padding(8, 0, 0, 0);
            buttonSupprimer.Size = new Size(185, 45);
            buttonSupprimer.TabIndex = 33;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // buttonNouveau
            // 
            buttonNouveau.Anchor = AnchorStyles.Right;
            buttonNouveau.BackColor = Color.FromArgb(129, 166, 181);
            buttonNouveau.Cursor = Cursors.Hand;
            buttonNouveau.FlatAppearance.BorderSize = 0;
            buttonNouveau.FlatStyle = FlatStyle.Flat;
            buttonNouveau.Font = new Font("Segoe UI", 11F);
            buttonNouveau.ForeColor = Color.White;
            buttonNouveau.Location = new Point(615, 75);
            buttonNouveau.Margin = new Padding(144, 3, 144, 3);
            buttonNouveau.Name = "buttonNouveau";
            buttonNouveau.Padding = new Padding(8, 0, 0, 0);
            buttonNouveau.Size = new Size(185, 45);
            buttonNouveau.TabIndex = 32;
            buttonNouveau.Text = "Nouveau";
            buttonNouveau.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 12;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.332499F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.342502F));
            tableLayoutPanel6.Controls.Add(panel31, 11, 1);
            tableLayoutPanel6.Controls.Add(panel30, 10, 1);
            tableLayoutPanel6.Controls.Add(panel27, 9, 1);
            tableLayoutPanel6.Controls.Add(panel26, 8, 1);
            tableLayoutPanel6.Controls.Add(panel25, 7, 1);
            tableLayoutPanel6.Controls.Add(panel24, 6, 1);
            tableLayoutPanel6.Controls.Add(panel23, 5, 1);
            tableLayoutPanel6.Controls.Add(panel22, 4, 1);
            tableLayoutPanel6.Controls.Add(panel21, 3, 1);
            tableLayoutPanel6.Controls.Add(panel20, 2, 1);
            tableLayoutPanel6.Controls.Add(panel19, 1, 1);
            tableLayoutPanel6.Controls.Add(panel18, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(12, 12);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(1176, 60);
            tableLayoutPanel6.TabIndex = 27;
            // 
            // panel31
            // 
            panel31.BackColor = Color.White;
            panel31.BorderStyle = BorderStyle.FixedSingle;
            panel31.Controls.Add(textBoxMontantTTC);
            panel31.Dock = DockStyle.Fill;
            panel31.Location = new Point(1070, 13);
            panel31.Name = "panel31";
            panel31.Padding = new Padding(5, 8, 5, 10);
            panel31.Size = new Size(103, 34);
            panel31.TabIndex = 54;
            // 
            // textBoxMontantTTC
            // 
            textBoxMontantTTC.BorderStyle = BorderStyle.None;
            textBoxMontantTTC.Dock = DockStyle.Fill;
            textBoxMontantTTC.Location = new Point(5, 8);
            textBoxMontantTTC.Name = "textBoxMontantTTC";
            //textBoxMontantTTC.PlaceholderText = "Montant TTC";
            textBoxMontantTTC.Size = new Size(91, 16);
            textBoxMontantTTC.TabIndex = 0;
            // 
            // panel30
            // 
            panel30.BackColor = Color.White;
            panel30.BorderStyle = BorderStyle.FixedSingle;
            panel30.Controls.Add(textBoxMontantHT);
            panel30.Dock = DockStyle.Fill;
            panel30.Location = new Point(973, 13);
            panel30.Name = "panel30";
            panel30.Padding = new Padding(5, 8, 5, 10);
            panel30.Size = new Size(91, 34);
            panel30.TabIndex = 53;
            // 
            // textBoxMontantHT
            // 
            textBoxMontantHT.BorderStyle = BorderStyle.None;
            textBoxMontantHT.Dock = DockStyle.Fill;
            textBoxMontantHT.Location = new Point(5, 8);
            textBoxMontantHT.Name = "textBoxMontantHT";
            //textBoxMontantHT.PlaceholderText = "Montant HT";
            textBoxMontantHT.Size = new Size(79, 16);
            textBoxMontantHT.TabIndex = 0;
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(textBoxPUNet);
            panel27.Dock = DockStyle.Fill;
            panel27.Location = new Point(876, 13);
            panel27.Name = "panel27";
            panel27.Padding = new Padding(5, 8, 5, 10);
            panel27.Size = new Size(91, 34);
            panel27.TabIndex = 40;
            // 
            // textBoxPUNet
            // 
            textBoxPUNet.BorderStyle = BorderStyle.None;
            textBoxPUNet.Dock = DockStyle.Fill;
            textBoxPUNet.Location = new Point(5, 8);
            textBoxPUNet.Name = "textBoxPUNet";
            //textBoxPUNet.PlaceholderText = "Pu Net";
            textBoxPUNet.Size = new Size(79, 16);
            textBoxPUNet.TabIndex = 0;
            // 
            // panel26
            // 
            panel26.BackColor = Color.White;
            panel26.BorderStyle = BorderStyle.FixedSingle;
            panel26.Controls.Add(textBoxRemise);
            panel26.Dock = DockStyle.Fill;
            panel26.Location = new Point(779, 13);
            panel26.Name = "panel26";
            panel26.Padding = new Padding(5, 8, 5, 10);
            panel26.Size = new Size(91, 34);
            panel26.TabIndex = 39;
            // 
            // textBoxRemise
            // 
            textBoxRemise.BorderStyle = BorderStyle.None;
            textBoxRemise.Dock = DockStyle.Fill;
            textBoxRemise.Location = new Point(5, 8);
            textBoxRemise.Name = "textBoxRemise";
            //textBoxRemise.PlaceholderText = "Remise";
            textBoxRemise.Size = new Size(79, 16);
            textBoxRemise.TabIndex = 0;
            // 
            // panel25
            // 
            panel25.BackColor = Color.White;
            panel25.BorderStyle = BorderStyle.FixedSingle;
            panel25.Controls.Add(textBoxConditionnement);
            panel25.Dock = DockStyle.Fill;
            panel25.Location = new Point(682, 13);
            panel25.Name = "panel25";
            panel25.Padding = new Padding(5, 8, 5, 10);
            panel25.Size = new Size(91, 34);
            panel25.TabIndex = 38;
            // 
            // textBoxConditionnement
            // 
            textBoxConditionnement.BorderStyle = BorderStyle.None;
            textBoxConditionnement.Dock = DockStyle.Fill;
            textBoxConditionnement.Location = new Point(5, 8);
            textBoxConditionnement.Name = "textBoxConditionnement";
            //textBoxConditionnement.PlaceholderText = "Conditionnement";
            textBoxConditionnement.Size = new Size(79, 16);
            textBoxConditionnement.TabIndex = 0;
            // 
            // panel24
            // 
            panel24.BackColor = Color.White;
            panel24.BorderStyle = BorderStyle.FixedSingle;
            panel24.Controls.Add(textBoxQuantite);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(585, 13);
            panel24.Name = "panel24";
            panel24.Padding = new Padding(5, 8, 5, 10);
            panel24.Size = new Size(91, 34);
            panel24.TabIndex = 37;
            // 
            // textBoxQuantite
            // 
            textBoxQuantite.BorderStyle = BorderStyle.None;
            textBoxQuantite.Dock = DockStyle.Fill;
            textBoxQuantite.Location = new Point(5, 8);
            textBoxQuantite.Name = "textBoxQuantite";
            //textBoxQuantite.PlaceholderText = "Quantité";
            textBoxQuantite.Size = new Size(79, 16);
            textBoxQuantite.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.BackColor = Color.White;
            panel23.BorderStyle = BorderStyle.FixedSingle;
            panel23.Controls.Add(textBoxPUTTC);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(488, 13);
            panel23.Name = "panel23";
            panel23.Padding = new Padding(5, 8, 5, 10);
            panel23.Size = new Size(91, 34);
            panel23.TabIndex = 36;
            // 
            // textBoxPUTTC
            // 
            textBoxPUTTC.BorderStyle = BorderStyle.None;
            textBoxPUTTC.Dock = DockStyle.Fill;
            textBoxPUTTC.Location = new Point(5, 8);
            textBoxPUTTC.Name = "textBoxPUTTC";
            //textBoxPUTTC.PlaceholderText = "Pu TTC";
            textBoxPUTTC.Size = new Size(79, 16);
            textBoxPUTTC.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.BorderStyle = BorderStyle.FixedSingle;
            panel22.Controls.Add(textBoxPUHT);
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(391, 13);
            panel22.Name = "panel22";
            panel22.Padding = new Padding(5, 8, 5, 10);
            panel22.Size = new Size(91, 34);
            panel22.TabIndex = 35;
            // 
            // textBoxPUHT
            // 
            textBoxPUHT.BorderStyle = BorderStyle.None;
            textBoxPUHT.Dock = DockStyle.Fill;
            textBoxPUHT.Location = new Point(5, 8);
            textBoxPUHT.Name = "textBoxPUHT";
            //textBoxPUHT.PlaceholderText = "Pu HT";
            textBoxPUHT.Size = new Size(79, 16);
            textBoxPUHT.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.BackColor = Color.White;
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(textBoxGamme2);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(294, 13);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(5, 8, 5, 10);
            panel21.Size = new Size(91, 34);
            panel21.TabIndex = 34;
            // 
            // textBoxGamme2
            // 
            textBoxGamme2.BorderStyle = BorderStyle.None;
            textBoxGamme2.Dock = DockStyle.Fill;
            textBoxGamme2.Location = new Point(5, 8);
            textBoxGamme2.Name = "textBoxGamme2";
            //textBoxGamme2.PlaceholderText = "Gamme 2";
            textBoxGamme2.Size = new Size(79, 16);
            textBoxGamme2.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.BackColor = Color.White;
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(textBoxGamme1);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(197, 13);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(5, 8, 5, 10);
            panel20.Size = new Size(91, 34);
            panel20.TabIndex = 33;
            // 
            // textBoxGamme1
            // 
            textBoxGamme1.BorderStyle = BorderStyle.None;
            textBoxGamme1.Dock = DockStyle.Fill;
            textBoxGamme1.Location = new Point(5, 8);
            textBoxGamme1.Name = "textBoxGamme1";
            //textBoxGamme1.PlaceholderText = "Gamme 1";
            textBoxGamme1.Size = new Size(79, 16);
            textBoxGamme1.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.BorderStyle = BorderStyle.FixedSingle;
            panel19.Controls.Add(textBoxDesignation);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(100, 13);
            panel19.Name = "panel19";
            panel19.Padding = new Padding(5, 8, 5, 10);
            panel19.Size = new Size(91, 34);
            panel19.TabIndex = 32;
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.BorderStyle = BorderStyle.None;
            textBoxDesignation.Dock = DockStyle.Fill;
            textBoxDesignation.Location = new Point(5, 8);
            textBoxDesignation.Name = "textBoxDesignation";
            //textBoxDesignation.PlaceholderText = "Désignation";
            textBoxDesignation.Size = new Size(79, 16);
            textBoxDesignation.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(textBoxReference);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(3, 13);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(5, 8, 5, 10);
            panel18.Size = new Size(91, 34);
            panel18.TabIndex = 31;
            // 
            // textBoxReference
            // 
            textBoxReference.BorderStyle = BorderStyle.None;
            textBoxReference.Dock = DockStyle.Fill;
            textBoxReference.Location = new Point(5, 8);
            textBoxReference.Name = "textBoxReference";
            //textBoxReference.PlaceholderText = "Référence";
            textBoxReference.Size = new Size(79, 16);
            textBoxReference.TabIndex = 0;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Reference, Designation, Gamme1, Gamme2, PuHT, PuTTC, Quantite, Conditionnement, Remise, PuNet, MontantHT, MontantTTC });
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
            dataGridView1.Location = new Point(12, 561);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1203, 336);
            dataGridView1.TabIndex = 41;
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.Name = "Reference";
            // 
            // Designation
            // 
            Designation.HeaderText = "Désignation";
            Designation.Name = "Designation";
            // 
            // Gamme1
            // 
            Gamme1.HeaderText = "Gamme 1";
            Gamme1.Name = "Gamme1";
            // 
            // Gamme2
            // 
            Gamme2.HeaderText = "Gamme 2";
            Gamme2.Name = "Gamme2";
            // 
            // PuHT
            // 
            PuHT.HeaderText = "Pu HT";
            PuHT.Name = "PuHT";
            // 
            // PuTTC
            // 
            PuTTC.HeaderText = "Pu TTC";
            PuTTC.Name = "PuTTC";
            // 
            // Quantite
            // 
            Quantite.HeaderText = "Quantité";
            Quantite.Name = "Quantite";
            // 
            // Conditionnement
            // 
            Conditionnement.HeaderText = "Conditionnement";
            Conditionnement.Name = "Conditionnement";
            // 
            // Remise
            // 
            Remise.HeaderText = "Remise";
            Remise.Name = "Remise";
            // 
            // PuNet
            // 
            PuNet.HeaderText = "Pu Net";
            PuNet.Name = "PuNet";
            // 
            // MontantHT
            // 
            MontantHT.HeaderText = "Montant HT";
            MontantHT.Name = "MontantHT";
            // 
            // MontantTTC
            // 
            MontantTTC.HeaderText = "Montant TTC";
            MontantTTC.Name = "MontantTTC";
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
            buttonFermer.Location = new Point(1025, 915);
            buttonFermer.Margin = new Padding(144, 3, 144, 3);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Padding = new Padding(8, 0, 0, 0);
            buttonFermer.Size = new Size(190, 45);
            buttonFermer.TabIndex = 42;
            buttonFermer.Text = "Fermer";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
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
            iconButtonFermer.TabIndex = 57;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateDocumentDeVente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1262, 971);
            Controls.Add(iconButtonFermer);
            Controls.Add(buttonFermer);
            Controls.Add(dataGridView1);
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(buttonValiderLEnTete);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateDocumentDeVente";
            Text = "Création document de vente";
            Load += CreateDocumentDeVente_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panelEnTete.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel12.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel15.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonInformations;
        private Button buttonValider;
        private Button buttonImprimer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelEnTete;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private TextBox textBoxCommentaires;
        private Label labelCommentaires;
        private Label labelClient;
        private Label labelDivers;
        private Label labelReference;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonNumeroDocument;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelExpedition;
        private Label labelDepot;
        private Panel panel10;
        private ComboBox comboBoxAffaire;
        private Label labelRepresentant;
        private Label labelAffaire;
        private Panel panel11;
        private Label labelDateLivraisonRealisee;
        private DateTimePicker dateTimePickerDate;
        private TextBox textBoxDate;
        private Label label2;
        private Panel panel14;
        private Label labelDateLivraisonPrevue;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonValiderLEnTete;
        private Panel panel15;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel31;
        private TextBox textBoxMontantTTC;
        private Panel panel30;
        private TextBox textBoxMontantHT;
        private Panel panel27;
        private TextBox textBoxPUNet;
        private Panel panel26;
        private TextBox textBoxRemise;
        private Panel panel25;
        private TextBox textBoxConditionnement;
        private Panel panel24;
        private TextBox textBoxQuantite;
        private Panel panel23;
        private TextBox textBoxPUTTC;
        private Panel panel22;
        private TextBox textBoxPUHT;
        private Panel panel21;
        private TextBox textBoxGamme2;
        private Panel panel20;
        private TextBox textBoxGamme1;
        private Panel panel19;
        private TextBox textBoxDesignation;
        private Panel panel18;
        private TextBox textBoxReference;
        private Button buttonEnregistrer;
        private Button buttonSupprimer;
        private Button buttonNouveau;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn Gamme1;
        private DataGridViewTextBoxColumn Gamme2;
        private DataGridViewTextBoxColumn PuHT;
        private DataGridViewTextBoxColumn PuTTC;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn Conditionnement;
        private DataGridViewTextBoxColumn Remise;
        private DataGridViewTextBoxColumn PuNet;
        private DataGridViewTextBoxColumn MontantHT;
        private DataGridViewTextBoxColumn MontantTTC;
        private Button buttonFermer;
        private Panel panel2;
        private DateTimePicker dateTimePickerDateLivraisonRealisee;
        private TextBox textBoxDateLivraisonRealisee;
        private Panel panel13;
        private DateTimePicker dateTimePickerDateLivraisonPrevue;
        private TextBox textBoxDateLivraisonPrevue;
        private Panel panel1;
        private ComboBox comboBoxClient;
        private Panel panel7;
        private ComboBox comboBoxDepot;
        private Panel panel4;
        private TextBox textBoxReferenceDocEnTete;
        private Panel panel6;
        private ComboBox comboBoxExpedition;
        private Panel panel8;
        private TextBox textBoxDivers;
        private Panel panel9;
        private ComboBox comboBoxRepresentant;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}