using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse.Views.Donnees.CollaborateursChildForm
{
    partial class CreateUpdateCollaborateurs
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
            btnEnregistrer = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            txtBxFonction = new TextBox();
            lblFonction = new Label();
            panel1 = new Panel();
            txtBxMatricule = new TextBox();
            lblMatricule = new Label();
            panel5 = new Panel();
            txtBxService = new TextBox();
            panel4 = new Panel();
            txtBxPrenoms = new TextBox();
            panel2 = new Panel();
            txtBxNom = new TextBox();
            lblService = new Label();
            lblPrenom = new Label();
            lblNom = new Label();
            groupBoxCoordonneesPhysiques = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel18 = new Panel();
            comboBoxPays = new ComboBox();
            lblPays = new Label();
            panel6 = new Panel();
            txtBxVille = new TextBox();
            lblVille = new Label();
            panel7 = new Panel();
            txtBxRegion = new TextBox();
            lblRegion = new Label();
            panel8 = new Panel();
            txtBxCodePostal = new TextBox();
            panel9 = new Panel();
            txtBxComplement = new TextBox();
            panel10 = new Panel();
            txtBxAdresse = new TextBox();
            lblCodePostal = new Label();
            lblComplement = new Label();
            lblAdresse = new Label();
            groupBoxProfilsNumeriques = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel13 = new Panel();
            txtBxAdresseElectronique = new TextBox();
            panel14 = new Panel();
            txtBxTelecopie = new TextBox();
            panel15 = new Panel();
            txtBxTelephone = new TextBox();
            lblEmail = new Label();
            lblTelecopie = new Label();
            lblTelephone = new Label();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxCoordonneesPhysiques.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel18.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            groupBoxProfilsNumeriques.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.FromArgb(129, 166, 181);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI", 11F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(388, 784);
            btnEnregistrer.Margin = new Padding(144, 3, 144, 3);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Padding = new Padding(8, 0, 0, 0);
            btnEnregistrer.Size = new Size(190, 45);
            btnEnregistrer.TabIndex = 29;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(24, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 3, 60, 3);
            groupBox1.Size = new Size(554, 242);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profil du collaborateur";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(lblFonction, 0, 5);
            tableLayoutPanel1.Controls.Add(panel1, 1, 4);
            tableLayoutPanel1.Controls.Add(lblMatricule, 0, 4);
            tableLayoutPanel1.Controls.Add(panel5, 1, 3);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblService, 0, 3);
            tableLayoutPanel1.Controls.Add(lblPrenom, 0, 2);
            tableLayoutPanel1.Controls.Add(lblNom, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(434, 220);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtBxFonction);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(154, 173);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(277, 34);
            panel3.TabIndex = 29;
            // 
            // txtBxFonction
            // 
            txtBxFonction.BorderStyle = BorderStyle.None;
            txtBxFonction.Dock = DockStyle.Fill;
            txtBxFonction.Location = new Point(20, 9);
            txtBxFonction.Name = "txtBxFonction";
            //txtBxFonction.PlaceholderText = "Fonction";
            txtBxFonction.Size = new Size(235, 16);
            txtBxFonction.TabIndex = 0;
            // 
            // lblFonction
            // 
            lblFonction.AutoSize = true;
            lblFonction.Dock = DockStyle.Right;
            lblFonction.Location = new Point(94, 170);
            lblFonction.Name = "lblFonction";
            lblFonction.Size = new Size(54, 40);
            lblFonction.TabIndex = 28;
            lblFonction.Text = "Fonction";
            lblFonction.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBxMatricule);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(154, 133);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(277, 34);
            panel1.TabIndex = 25;
            // 
            // txtBxMatricule
            // 
            txtBxMatricule.BorderStyle = BorderStyle.None;
            txtBxMatricule.Dock = DockStyle.Fill;
            txtBxMatricule.Location = new Point(20, 9);
            txtBxMatricule.Name = "txtBxMatricule";
            //txtBxMatricule.PlaceholderText = "Matricule";
            txtBxMatricule.Size = new Size(235, 16);
            txtBxMatricule.TabIndex = 0;
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Dock = DockStyle.Right;
            lblMatricule.Location = new Point(91, 130);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(57, 40);
            lblMatricule.TabIndex = 24;
            lblMatricule.Text = "Matricule";
            lblMatricule.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxService);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(154, 93);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(277, 34);
            panel5.TabIndex = 21;
            // 
            // txtBxService
            // 
            txtBxService.BorderStyle = BorderStyle.None;
            txtBxService.Dock = DockStyle.Fill;
            txtBxService.Location = new Point(20, 9);
            txtBxService.Name = "txtBxService";
            //txtBxService.PlaceholderText = "Service";
            txtBxService.Size = new Size(235, 16);
            txtBxService.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBxPrenoms);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(154, 53);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(277, 34);
            panel4.TabIndex = 20;
            // 
            // txtBxPrenoms
            // 
            txtBxPrenoms.BorderStyle = BorderStyle.None;
            txtBxPrenoms.Dock = DockStyle.Fill;
            txtBxPrenoms.Location = new Point(20, 9);
            txtBxPrenoms.Name = "txtBxPrenoms";
            //txtBxPrenoms.PlaceholderText = "Prénom(s)";
            txtBxPrenoms.Size = new Size(235, 16);
            txtBxPrenoms.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxNom);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(154, 13);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(277, 34);
            panel2.TabIndex = 19;
            // 
            // txtBxNom
            // 
            txtBxNom.BorderStyle = BorderStyle.None;
            txtBxNom.Dock = DockStyle.Fill;
            txtBxNom.Location = new Point(20, 9);
            txtBxNom.Name = "txtBxNom";
            //txtBxNom.PlaceholderText = "Nom";
            txtBxNom.Size = new Size(235, 16);
            txtBxNom.TabIndex = 0;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Dock = DockStyle.Right;
            lblService.Location = new Point(104, 90);
            lblService.Name = "lblService";
            lblService.Size = new Size(44, 40);
            lblService.TabIndex = 6;
            lblService.Text = "Service";
            lblService.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Dock = DockStyle.Right;
            lblPrenom.Location = new Point(86, 50);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(62, 40);
            lblPrenom.TabIndex = 4;
            lblPrenom.Text = "Prénom(s)";
            lblPrenom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Dock = DockStyle.Right;
            lblNom.Location = new Point(114, 10);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 40);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            lblNom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxCoordonneesPhysiques
            // 
            groupBoxCoordonneesPhysiques.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCoordonneesPhysiques.Controls.Add(tableLayoutPanel2);
            groupBoxCoordonneesPhysiques.Location = new Point(24, 303);
            groupBoxCoordonneesPhysiques.Name = "groupBoxCoordonneesPhysiques";
            groupBoxCoordonneesPhysiques.Padding = new Padding(60, 3, 60, 3);
            groupBoxCoordonneesPhysiques.Size = new Size(554, 280);
            groupBoxCoordonneesPhysiques.TabIndex = 31;
            groupBoxCoordonneesPhysiques.TabStop = false;
            groupBoxCoordonneesPhysiques.Text = "Coordonnées physiques";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(panel18, 1, 6);
            tableLayoutPanel2.Controls.Add(lblPays, 0, 6);
            tableLayoutPanel2.Controls.Add(panel6, 1, 5);
            tableLayoutPanel2.Controls.Add(lblVille, 0, 5);
            tableLayoutPanel2.Controls.Add(panel7, 1, 4);
            tableLayoutPanel2.Controls.Add(lblRegion, 0, 4);
            tableLayoutPanel2.Controls.Add(panel8, 1, 3);
            tableLayoutPanel2.Controls.Add(panel9, 1, 2);
            tableLayoutPanel2.Controls.Add(panel10, 1, 1);
            tableLayoutPanel2.Controls.Add(lblCodePostal, 0, 3);
            tableLayoutPanel2.Controls.Add(lblComplement, 0, 2);
            tableLayoutPanel2.Controls.Add(lblAdresse, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(434, 258);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(comboBoxPays);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(154, 213);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(20, 5, 4, 0);
            panel18.Size = new Size(277, 34);
            panel18.TabIndex = 35;
            // 
            // comboBoxPays
            // 
            comboBoxPays.Dock = DockStyle.Fill;
            comboBoxPays.FlatStyle = FlatStyle.Flat;
            comboBoxPays.FormattingEnabled = true;
            comboBoxPays.Location = new Point(20, 5);
            comboBoxPays.Name = "comboBoxPays";
            comboBoxPays.Size = new Size(251, 23);
            comboBoxPays.TabIndex = 0;
            // 
            // lblPays
            // 
            lblPays.AutoSize = true;
            lblPays.Dock = DockStyle.Right;
            lblPays.Location = new Point(117, 210);
            lblPays.Name = "lblPays";
            lblPays.Size = new Size(31, 40);
            lblPays.TabIndex = 32;
            lblPays.Text = "Pays";
            lblPays.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtBxVille);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(154, 173);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 9, 20, 10);
            panel6.Size = new Size(277, 34);
            panel6.TabIndex = 29;
            // 
            // txtBxVille
            // 
            txtBxVille.BorderStyle = BorderStyle.None;
            txtBxVille.Dock = DockStyle.Fill;
            txtBxVille.Location = new Point(20, 9);
            txtBxVille.Name = "txtBxVille";
            //txtBxVille.PlaceholderText = "Ville";
            txtBxVille.Size = new Size(235, 16);
            txtBxVille.TabIndex = 0;
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Dock = DockStyle.Right;
            lblVille.Location = new Point(119, 170);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(29, 40);
            lblVille.TabIndex = 28;
            lblVille.Text = "Ville";
            lblVille.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtBxRegion);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(154, 133);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(277, 34);
            panel7.TabIndex = 25;
            // 
            // txtBxRegion
            // 
            txtBxRegion.BorderStyle = BorderStyle.None;
            txtBxRegion.Dock = DockStyle.Fill;
            txtBxRegion.Location = new Point(20, 9);
            txtBxRegion.Name = "txtBxRegion";
            //txtBxRegion.PlaceholderText = "Région";
            txtBxRegion.Size = new Size(235, 16);
            txtBxRegion.TabIndex = 0;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Dock = DockStyle.Right;
            lblRegion.Location = new Point(104, 130);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(44, 40);
            lblRegion.TabIndex = 24;
            lblRegion.Text = "Région";
            lblRegion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(txtBxCodePostal);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(154, 93);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 9, 20, 10);
            panel8.Size = new Size(277, 34);
            panel8.TabIndex = 21;
            // 
            // txtBxCodePostal
            // 
            txtBxCodePostal.BorderStyle = BorderStyle.None;
            txtBxCodePostal.Dock = DockStyle.Fill;
            txtBxCodePostal.Location = new Point(20, 9);
            txtBxCodePostal.Name = "txtBxCodePostal";
            //txtBxCodePostal.PlaceholderText = "Code postal";
            txtBxCodePostal.Size = new Size(235, 16);
            txtBxCodePostal.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(txtBxComplement);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(154, 53);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(20, 9, 20, 10);
            panel9.Size = new Size(277, 34);
            panel9.TabIndex = 20;
            // 
            // txtBxComplement
            // 
            txtBxComplement.BorderStyle = BorderStyle.None;
            txtBxComplement.Dock = DockStyle.Fill;
            txtBxComplement.Location = new Point(20, 9);
            txtBxComplement.Name = "txtBxComplement";
            //txtBxComplement.PlaceholderText = "Complément";
            txtBxComplement.Size = new Size(235, 16);
            txtBxComplement.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(txtBxAdresse);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(154, 13);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(20, 9, 20, 10);
            panel10.Size = new Size(277, 34);
            panel10.TabIndex = 19;
            // 
            // txtBxAdresse
            // 
            txtBxAdresse.BorderStyle = BorderStyle.None;
            txtBxAdresse.Dock = DockStyle.Fill;
            txtBxAdresse.Location = new Point(20, 9);
            txtBxAdresse.Name = "txtBxAdresse";
            //txtBxAdresse.PlaceholderText = "Adresse";
            txtBxAdresse.Size = new Size(235, 16);
            txtBxAdresse.TabIndex = 0;
            // 
            // lblCodePostal
            // 
            lblCodePostal.AutoSize = true;
            lblCodePostal.Dock = DockStyle.Right;
            lblCodePostal.Location = new Point(78, 90);
            lblCodePostal.Name = "lblCodePostal";
            lblCodePostal.Size = new Size(70, 40);
            lblCodePostal.TabIndex = 6;
            lblCodePostal.Text = "Code postal";
            lblCodePostal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblComplement
            // 
            lblComplement.AutoSize = true;
            lblComplement.Dock = DockStyle.Right;
            lblComplement.Location = new Point(71, 50);
            lblComplement.Name = "lblComplement";
            lblComplement.Size = new Size(77, 40);
            lblComplement.TabIndex = 4;
            lblComplement.Text = "Complément";
            lblComplement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Dock = DockStyle.Right;
            lblAdresse.Location = new Point(100, 10);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(48, 40);
            lblAdresse.TabIndex = 0;
            lblAdresse.Text = "Adresse";
            lblAdresse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxProfilsNumeriques
            // 
            groupBoxProfilsNumeriques.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProfilsNumeriques.Controls.Add(tableLayoutPanel3);
            groupBoxProfilsNumeriques.Location = new Point(24, 612);
            groupBoxProfilsNumeriques.Name = "groupBoxProfilsNumeriques";
            groupBoxProfilsNumeriques.Padding = new Padding(60, 3, 60, 3);
            groupBoxProfilsNumeriques.Size = new Size(554, 160);
            groupBoxProfilsNumeriques.TabIndex = 32;
            groupBoxProfilsNumeriques.TabStop = false;
            groupBoxProfilsNumeriques.Text = "Profils numériques";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Controls.Add(panel13, 1, 3);
            tableLayoutPanel3.Controls.Add(panel14, 1, 2);
            tableLayoutPanel3.Controls.Add(panel15, 1, 1);
            tableLayoutPanel3.Controls.Add(lblEmail, 0, 3);
            tableLayoutPanel3.Controls.Add(lblTelecopie, 0, 2);
            tableLayoutPanel3.Controls.Add(lblTelephone, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(60, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(434, 138);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(txtBxAdresseElectronique);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(154, 93);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(20, 9, 20, 10);
            panel13.Size = new Size(277, 34);
            panel13.TabIndex = 21;
            // 
            // txtBxAdresseElectronique
            // 
            txtBxAdresseElectronique.BorderStyle = BorderStyle.None;
            txtBxAdresseElectronique.Dock = DockStyle.Fill;
            txtBxAdresseElectronique.Location = new Point(20, 9);
            txtBxAdresseElectronique.Name = "txtBxAdresseElectronique";
            //txtBxAdresseElectronique.PlaceholderText = "Adresse éléctronique";
            txtBxAdresseElectronique.Size = new Size(235, 16);
            txtBxAdresseElectronique.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.BackColor = Color.White;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(txtBxTelecopie);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(154, 53);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(20, 9, 20, 10);
            panel14.Size = new Size(277, 34);
            panel14.TabIndex = 20;
            // 
            // txtBxTelecopie
            // 
            txtBxTelecopie.BorderStyle = BorderStyle.None;
            txtBxTelecopie.Dock = DockStyle.Fill;
            txtBxTelecopie.Location = new Point(20, 9);
            txtBxTelecopie.Name = "txtBxTelecopie";
            //txtBxTelecopie.PlaceholderText = "Télécopie";
            txtBxTelecopie.Size = new Size(235, 16);
            txtBxTelecopie.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(txtBxTelephone);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(154, 13);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(20, 9, 20, 10);
            panel15.Size = new Size(277, 34);
            panel15.TabIndex = 19;
            // 
            // txtBxTelephone
            // 
            txtBxTelephone.BorderStyle = BorderStyle.None;
            txtBxTelephone.Dock = DockStyle.Fill;
            txtBxTelephone.Location = new Point(20, 9);
            txtBxTelephone.Name = "txtBxTelephone";
            //txtBxTelephone.PlaceholderText = "Téléphone";
            txtBxTelephone.Size = new Size(235, 16);
            txtBxTelephone.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Right;
            lblEmail.Location = new Point(112, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 40);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTelecopie
            // 
            lblTelecopie.AutoSize = true;
            lblTelecopie.Dock = DockStyle.Right;
            lblTelecopie.Location = new Point(91, 50);
            lblTelecopie.Name = "lblTelecopie";
            lblTelecopie.Size = new Size(57, 40);
            lblTelecopie.TabIndex = 4;
            lblTelecopie.Text = "Télécopie";
            lblTelecopie.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Dock = DockStyle.Right;
            lblTelephone.Location = new Point(86, 10);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(62, 40);
            lblTelephone.TabIndex = 0;
            lblTelephone.Text = "Téléphone";
            lblTelephone.TextAlign = ContentAlignment.MiddleRight;
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
            iconButtonFermer.Location = new Point(582, 2);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 47;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // CreateUpdateCollaborateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(628, 841);
            Controls.Add(iconButtonFermer);
            Controls.Add(groupBoxProfilsNumeriques);
            Controls.Add(groupBoxCoordonneesPhysiques);
            Controls.Add(groupBox1);
            Controls.Add(btnEnregistrer);
            Name = "CreateUpdateCollaborateurs";
            ShowIcon = false;
            ShowInTaskbar = false;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxCoordonneesPhysiques.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel18.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            groupBoxProfilsNumeriques.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEnregistrer;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TextBox txtBxService;
        private Panel panel4;
        private TextBox txtBxPrenoms;
        private Panel panel2;
        private TextBox txtBxNom;
        private Label lblService;
        private Label lblPrenom;
        private Label lblNom;
        private Panel panel1;
        private TextBox txtBxMatricule;
        private Label lblMatricule;
        private Panel panel3;
        private TextBox txtBxFonction;
        private Label lblFonction;
        private GroupBox groupBoxCoordonneesPhysiques;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private TextBox txtBxVille;
        private Label lblVille;
        private Panel panel7;
        private TextBox txtBxRegion;
        private Label lblRegion;
        private Panel panel8;
        private TextBox txtBxCodePostal;
        private Panel panel9;
        private TextBox txtBxComplement;
        private Panel panel10;
        private TextBox txtBxAdresse;
        private Label lblCodePostal;
        private Label lblComplement;
        private Label lblAdresse;
        private GroupBox groupBoxProfilsNumeriques;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel13;
        private TextBox txtBxAdresseElectronique;
        private Panel panel14;
        private TextBox txtBxTelecopie;
        private Panel panel15;
        private TextBox txtBxTelephone;
        private Label lblEmail;
        private Label lblTelecopie;
        private Label lblTelephone;
        private Label lblPays;
        private Panel panel18;
        private ComboBox comboBoxPays;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}