using System.Drawing;
using System.Windows.Forms;
namespace Soft_Caisse.Views.Parametres
{
    partial class ParametresDeLaBase
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            txtBxMotDePasse = new TextBox();
            panel4 = new Panel();
            txtBxUtilisateur = new TextBox();
            panel2 = new Panel();
            txtBxNomDuServeur = new TextBox();
            lblMotDePasse = new Label();
            lblUtilisateur = new Label();
            lblNomDuServeur = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            txtBxBaseDeDonneesSoftCaisse = new TextBox();
            panel6 = new Panel();
            txtBxBaseDeDonnesSage = new TextBox();
            lblBaseDeDonneesSoftCaisse = new Label();
            lblBaseDeDonnesSage = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel12 = new Panel();
            txtBxMotDePasseFichierSage = new TextBox();
            panel11 = new Panel();
            txtBxUtilisateurFichiersSage = new TextBox();
            lblMotDePasseDonneesSage = new Label();
            lblUtilisateurDonneesSage = new Label();
            panel1 = new Panel();
            txtBxFichierCompta = new TextBox();
            panel3 = new Panel();
            txtBxFichiersGesCom = new TextBox();
            lblSage100Comptablite = new Label();
            lblSage100Commerciale = new Label();
            btnConnecter = new Button();
            btnValider = new Button();
            btnUtiliser = new Button();
            panel8 = new Panel();
            iconButtonFermer = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(16, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(60, 3, 60, 3);
            groupBox1.Size = new Size(554, 155);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Authentification au SGBD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel5, 1, 3);
            tableLayoutPanel1.Controls.Add(panel4, 1, 2);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblMotDePasse, 0, 3);
            tableLayoutPanel1.Controls.Add(lblUtilisateur, 0, 2);
            tableLayoutPanel1.Controls.Add(lblNomDuServeur, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(60, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(434, 133);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtBxMotDePasse);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(154, 93);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 9, 20, 10);
            panel5.Size = new Size(277, 34);
            panel5.TabIndex = 21;
            // 
            // txtBxMotDePasse
            // 
            txtBxMotDePasse.BorderStyle = BorderStyle.None;
            txtBxMotDePasse.Dock = DockStyle.Fill;
            txtBxMotDePasse.Location = new Point(20, 9);
            txtBxMotDePasse.Name = "txtBxMotDePasse";
            //txtBxMotDePasse.PlaceholderText = "Mot de passe";
            txtBxMotDePasse.Size = new Size(235, 16);
            txtBxMotDePasse.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtBxUtilisateur);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(154, 53);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 9, 20, 10);
            panel4.Size = new Size(277, 34);
            panel4.TabIndex = 20;
            // 
            // txtBxUtilisateur
            // 
            txtBxUtilisateur.BorderStyle = BorderStyle.None;
            txtBxUtilisateur.Dock = DockStyle.Fill;
            txtBxUtilisateur.Location = new Point(20, 9);
            txtBxUtilisateur.Name = "txtBxUtilisateur";
            //txtBxUtilisateur.PlaceholderText = "Utilisateur";
            txtBxUtilisateur.Size = new Size(235, 16);
            txtBxUtilisateur.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBxNomDuServeur);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(154, 13);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 9, 20, 10);
            panel2.Size = new Size(277, 34);
            panel2.TabIndex = 19;
            // 
            // txtBxNomDuServeur
            // 
            txtBxNomDuServeur.BorderStyle = BorderStyle.None;
            txtBxNomDuServeur.Dock = DockStyle.Fill;
            txtBxNomDuServeur.Location = new Point(20, 9);
            txtBxNomDuServeur.Name = "txtBxNomDuServeur";
            //txtBxNomDuServeur.PlaceholderText = "Nom du serveur";
            txtBxNomDuServeur.Size = new Size(235, 16);
            txtBxNomDuServeur.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Dock = DockStyle.Right;
            lblMotDePasse.Location = new Point(71, 90);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(77, 40);
            lblMotDePasse.TabIndex = 6;
            lblMotDePasse.Text = "Mot de passe";
            lblMotDePasse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Dock = DockStyle.Right;
            lblUtilisateur.Location = new Point(88, 50);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(60, 40);
            lblUtilisateur.TabIndex = 4;
            lblUtilisateur.Text = "Utilisateur";
            lblUtilisateur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNomDuServeur
            // 
            lblNomDuServeur.AutoSize = true;
            lblNomDuServeur.Dock = DockStyle.Right;
            lblNomDuServeur.Location = new Point(56, 10);
            lblNomDuServeur.Name = "lblNomDuServeur";
            lblNomDuServeur.Size = new Size(92, 40);
            lblNomDuServeur.TabIndex = 0;
            lblNomDuServeur.Text = "Nom du serveur";
            lblNomDuServeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(16, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(40, 3, 60, 3);
            groupBox2.Size = new Size(554, 155);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sélection des bases de données";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(panel7, 1, 2);
            tableLayoutPanel2.Controls.Add(panel6, 1, 1);
            tableLayoutPanel2.Controls.Add(lblBaseDeDonneesSoftCaisse, 0, 2);
            tableLayoutPanel2.Controls.Add(lblBaseDeDonnesSage, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(40, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(454, 133);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtBxBaseDeDonneesSoftCaisse);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(161, 68);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(20, 9, 20, 10);
            panel7.Size = new Size(290, 34);
            panel7.TabIndex = 23;
            // 
            // txtBxBaseDeDonneesSoftCaisse
            // 
            txtBxBaseDeDonneesSoftCaisse.BorderStyle = BorderStyle.None;
            txtBxBaseDeDonneesSoftCaisse.Dock = DockStyle.Fill;
            txtBxBaseDeDonneesSoftCaisse.Location = new Point(20, 9);
            txtBxBaseDeDonneesSoftCaisse.Name = "txtBxBaseDeDonneesSoftCaisse";
            //txtBxBaseDeDonneesSoftCaisse.PlaceholderText = "BaseSoftCaisse.bak";
            txtBxBaseDeDonneesSoftCaisse.Size = new Size(248, 16);
            txtBxBaseDeDonneesSoftCaisse.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtBxBaseDeDonnesSage);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(161, 28);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20, 9, 20, 10);
            panel6.Size = new Size(290, 34);
            panel6.TabIndex = 22;
            // 
            // txtBxBaseDeDonnesSage
            // 
            txtBxBaseDeDonnesSage.BorderStyle = BorderStyle.None;
            txtBxBaseDeDonnesSage.Dock = DockStyle.Fill;
            txtBxBaseDeDonnesSage.Location = new Point(20, 9);
            txtBxBaseDeDonnesSage.Name = "txtBxBaseDeDonnesSage";
            //txtBxBaseDeDonnesSage.PlaceholderText = "BaseSage.bak";
            txtBxBaseDeDonnesSage.Size = new Size(248, 16);
            txtBxBaseDeDonnesSage.TabIndex = 0;
            // 
            // lblBaseDeDonneesSoftCaisse
            // 
            lblBaseDeDonneesSoftCaisse.AutoSize = true;
            lblBaseDeDonneesSoftCaisse.Dock = DockStyle.Right;
            lblBaseDeDonneesSoftCaisse.Location = new Point(3, 65);
            lblBaseDeDonneesSoftCaisse.Name = "lblBaseDeDonneesSoftCaisse";
            lblBaseDeDonneesSoftCaisse.Size = new Size(152, 40);
            lblBaseDeDonneesSoftCaisse.TabIndex = 4;
            lblBaseDeDonneesSoftCaisse.Text = "Base de données SoftCaisse";
            lblBaseDeDonneesSoftCaisse.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBaseDeDonnesSage
            // 
            lblBaseDeDonnesSage.AutoSize = true;
            lblBaseDeDonnesSage.Dock = DockStyle.Right;
            lblBaseDeDonnesSage.Location = new Point(32, 25);
            lblBaseDeDonnesSage.Name = "lblBaseDeDonnesSage";
            lblBaseDeDonnesSage.Size = new Size(123, 40);
            lblBaseDeDonnesSage.TabIndex = 0;
            lblBaseDeDonnesSage.Text = "Base de données Sage";
            lblBaseDeDonnesSage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Location = new Point(16, 521);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(60, 3, 60, 3);
            groupBox3.Size = new Size(554, 196);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sélection des fichiers des données Sage";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Controls.Add(panel12, 1, 4);
            tableLayoutPanel3.Controls.Add(panel11, 1, 3);
            tableLayoutPanel3.Controls.Add(lblMotDePasseDonneesSage, 0, 4);
            tableLayoutPanel3.Controls.Add(lblUtilisateurDonneesSage, 0, 3);
            tableLayoutPanel3.Controls.Add(panel1, 1, 2);
            tableLayoutPanel3.Controls.Add(panel3, 1, 1);
            tableLayoutPanel3.Controls.Add(lblSage100Comptablite, 0, 2);
            tableLayoutPanel3.Controls.Add(lblSage100Commerciale, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(60, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Size = new Size(434, 174);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(txtBxMotDePasseFichierSage);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(154, 133);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(20, 9, 20, 10);
            panel12.Size = new Size(277, 34);
            panel12.TabIndex = 32;
            // 
            // txtBxMotDePasseFichierSage
            // 
            txtBxMotDePasseFichierSage.BorderStyle = BorderStyle.None;
            txtBxMotDePasseFichierSage.Dock = DockStyle.Fill;
            txtBxMotDePasseFichierSage.Location = new Point(20, 9);
            txtBxMotDePasseFichierSage.Name = "txtBxMotDePasseFichierSage";
            //txtBxMotDePasseFichierSage.PlaceholderText = "Mot de passe";
            txtBxMotDePasseFichierSage.Size = new Size(235, 16);
            txtBxMotDePasseFichierSage.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(txtBxUtilisateurFichiersSage);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(154, 93);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(20, 9, 20, 10);
            panel11.Size = new Size(277, 34);
            panel11.TabIndex = 31;
            // 
            // txtBxUtilisateurFichiersSage
            // 
            txtBxUtilisateurFichiersSage.BorderStyle = BorderStyle.None;
            txtBxUtilisateurFichiersSage.Dock = DockStyle.Fill;
            txtBxUtilisateurFichiersSage.Location = new Point(20, 9);
            txtBxUtilisateurFichiersSage.Name = "txtBxUtilisateurFichiersSage";
            //txtBxUtilisateurFichiersSage.PlaceholderText = "Utilisateur";
            txtBxUtilisateurFichiersSage.Size = new Size(235, 16);
            txtBxUtilisateurFichiersSage.TabIndex = 0;
            // 
            // lblMotDePasseDonneesSage
            // 
            lblMotDePasseDonneesSage.AutoSize = true;
            lblMotDePasseDonneesSage.Dock = DockStyle.Right;
            lblMotDePasseDonneesSage.Location = new Point(71, 130);
            lblMotDePasseDonneesSage.Name = "lblMotDePasseDonneesSage";
            lblMotDePasseDonneesSage.Size = new Size(77, 40);
            lblMotDePasseDonneesSage.TabIndex = 28;
            lblMotDePasseDonneesSage.Text = "Mot de passe";
            lblMotDePasseDonneesSage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUtilisateurDonneesSage
            // 
            lblUtilisateurDonneesSage.AutoSize = true;
            lblUtilisateurDonneesSage.Dock = DockStyle.Right;
            lblUtilisateurDonneesSage.Location = new Point(88, 90);
            lblUtilisateurDonneesSage.Name = "lblUtilisateurDonneesSage";
            lblUtilisateurDonneesSage.Size = new Size(60, 40);
            lblUtilisateurDonneesSage.TabIndex = 26;
            lblUtilisateurDonneesSage.Text = "Utilisateur";
            lblUtilisateurDonneesSage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtBxFichierCompta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(154, 53);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 9, 20, 10);
            panel1.Size = new Size(277, 34);
            panel1.TabIndex = 23;
            // 
            // txtBxFichierCompta
            // 
            txtBxFichierCompta.BorderStyle = BorderStyle.None;
            txtBxFichierCompta.Dock = DockStyle.Fill;
            txtBxFichierCompta.Location = new Point(20, 9);
            txtBxFichierCompta.Name = "txtBxFichierCompta";
            //txtBxFichierCompta.PlaceholderText = "FichierCompta.mae";
            txtBxFichierCompta.Size = new Size(235, 16);
            txtBxFichierCompta.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtBxFichiersGesCom);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(154, 13);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 9, 20, 10);
            panel3.Size = new Size(277, 34);
            panel3.TabIndex = 22;
            // 
            // txtBxFichiersGesCom
            // 
            txtBxFichiersGesCom.BorderStyle = BorderStyle.None;
            txtBxFichiersGesCom.Dock = DockStyle.Fill;
            txtBxFichiersGesCom.Location = new Point(20, 9);
            txtBxFichiersGesCom.Name = "txtBxFichiersGesCom";
            //txtBxFichiersGesCom.PlaceholderText = "FichierGesCom.gcm";
            txtBxFichiersGesCom.Size = new Size(235, 16);
            txtBxFichiersGesCom.TabIndex = 0;
            // 
            // lblSage100Comptablite
            // 
            lblSage100Comptablite.AutoSize = true;
            lblSage100Comptablite.Dock = DockStyle.Right;
            lblSage100Comptablite.Location = new Point(23, 50);
            lblSage100Comptablite.Name = "lblSage100Comptablite";
            lblSage100Comptablite.Size = new Size(125, 40);
            lblSage100Comptablite.TabIndex = 4;
            lblSage100Comptablite.Text = "Sage 100 Comptabilité";
            lblSage100Comptablite.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSage100Commerciale
            // 
            lblSage100Commerciale.AutoSize = true;
            lblSage100Commerciale.Dock = DockStyle.Right;
            lblSage100Commerciale.Location = new Point(21, 10);
            lblSage100Commerciale.Name = "lblSage100Commerciale";
            lblSage100Commerciale.Size = new Size(127, 40);
            lblSage100Commerciale.TabIndex = 0;
            lblSage100Commerciale.Text = "Sage 100 Commerciale";
            lblSage100Commerciale.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConnecter
            // 
            btnConnecter.BackColor = Color.FromArgb(129, 166, 181);
            btnConnecter.Cursor = Cursors.Hand;
            btnConnecter.FlatAppearance.BorderSize = 0;
            btnConnecter.FlatStyle = FlatStyle.Flat;
            btnConnecter.Font = new Font("Segoe UI", 11F);
            btnConnecter.ForeColor = Color.White;
            btnConnecter.Location = new Point(380, 201);
            btnConnecter.Margin = new Padding(144, 3, 144, 3);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Padding = new Padding(8, 0, 0, 0);
            btnConnecter.Size = new Size(190, 45);
            btnConnecter.TabIndex = 13;
            btnConnecter.Text = "Connecter";
            btnConnecter.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.FromArgb(129, 166, 181);
            btnValider.Cursor = Cursors.Hand;
            btnValider.FlatAppearance.BorderSize = 0;
            btnValider.FlatStyle = FlatStyle.Flat;
            btnValider.Font = new Font("Segoe UI", 11F);
            btnValider.ForeColor = Color.White;
            btnValider.Location = new Point(380, 441);
            btnValider.Margin = new Padding(144, 3, 144, 3);
            btnValider.Name = "btnValider";
            btnValider.Padding = new Padding(8, 0, 0, 0);
            btnValider.Size = new Size(190, 45);
            btnValider.TabIndex = 14;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = false;
            // 
            // btnUtiliser
            // 
            btnUtiliser.BackColor = Color.FromArgb(129, 166, 181);
            btnUtiliser.Cursor = Cursors.Hand;
            btnUtiliser.FlatAppearance.BorderSize = 0;
            btnUtiliser.FlatStyle = FlatStyle.Flat;
            btnUtiliser.Font = new Font("Segoe UI", 11F);
            btnUtiliser.ForeColor = Color.White;
            btnUtiliser.Location = new Point(380, 723);
            btnUtiliser.Margin = new Padding(144, 3, 144, 3);
            btnUtiliser.Name = "btnUtiliser";
            btnUtiliser.Padding = new Padding(8, 0, 0, 0);
            btnUtiliser.Size = new Size(190, 45);
            btnUtiliser.TabIndex = 15;
            btnUtiliser.Text = "Utiliser";
            btnUtiliser.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(iconButtonFermer);
            panel8.Controls.Add(groupBox1);
            panel8.Controls.Add(btnUtiliser);
            panel8.Controls.Add(groupBox2);
            panel8.Controls.Add(btnValider);
            panel8.Controls.Add(groupBox3);
            panel8.Controls.Add(btnConnecter);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(619, 794);
            panel8.TabIndex = 16;
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
            iconButtonFermer.Location = new Point(571, 5);
            iconButtonFermer.Name = "iconButtonFermer";
            iconButtonFermer.Padding = new Padding(0, 5, 0, 0);
            iconButtonFermer.Size = new Size(40, 40);
            iconButtonFermer.TabIndex = 46;
            iconButtonFermer.UseVisualStyleBackColor = false;
            iconButtonFermer.Click += btnFermerActiveForm_Click;
            // 
            // ParametresDeLaBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(619, 794);
            Controls.Add(panel8);
            Name = "ParametresDeLaBase";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSeConnecter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMotDePasse;
        private Label lblUtilisateur;
        private Label lblNomDuServeur;
        private TextBox txtBxNomDuServeur;
        private TextBox txtBxMotDePasse;
        private TextBox txtBxUtilisateur;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Button btnConnecter;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSage100Comptablite;
        private Label lblSage100Commerciale;
        private Label label3;
        private Label lblBaseDeDonnesSage;
        private Label lblBaseDeDonneesSoftCaisse;
        private Button btnUtiliser;
        private Panel panel7;
        private TextBox txtBxBaseDeDonneesSoftCaisse;
        private Panel panel6;
        private TextBox txtBxBaseDeDonnesSage;
        private Button btnValider;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private TextBox txtBxFichierCompta;
        private Panel panel3;
        private TextBox txtBxFichiersGesCom;
        private Panel panel8;
        private Panel panel12;
        private TextBox txtBxMotDePasseFichierSage;
        private Panel panel11;
        private TextBox txtBxUtilisateurFichiersSage;
        private Label lblMotDePasseDonneesSage;
        private Label lblUtilisateurDonneesSage;
        private FontAwesome.Sharp.IconButton iconButtonFermer;
    }
}