using System.Drawing;
using System.Windows.Forms;

namespace Soft_Caisse
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnParametresDeLaBase = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnParametresSociete = new System.Windows.Forms.Button();
            this.btnGestionDesUtilisateurs = new System.Windows.Forms.Button();
            this.btnGestionDesRoles = new System.Windows.Forms.Button();
            this.btnDonnees = new System.Windows.Forms.Button();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnCaisses = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnCollaborateurs = new System.Windows.Forms.Button();
            this.btnFamilles = new System.Windows.Forms.Button();
            this.btnOperations = new System.Windows.Forms.Button();
            this.btnOuvertureDeCaisse = new System.Windows.Forms.Button();
            this.btnVenteComptoir = new System.Windows.Forms.Button();
            this.btnMouvementsDeCaisse = new System.Windows.Forms.Button();
            this.btnFermetureDeCaisse = new System.Windows.Forms.Button();
            this.btnDocumentsDesStocks = new System.Windows.Forms.Button();
            this.btnDocumentsDesVentes = new System.Windows.Forms.Button();
            this.btnSaisieDesReglements = new System.Windows.Forms.Button();
            this.btnClotureDesCaisses = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnControleDesCaisses = new System.Windows.Forms.Button();
            this.btnStatistiquesDesCaisses = new System.Windows.Forms.Button();
            this.btnSeDeconnecter = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParametresDeLaBase
            // 
            this.btnParametresDeLaBase.BackColor = System.Drawing.Color.Transparent;
            this.btnParametresDeLaBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametresDeLaBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametresDeLaBase.FlatAppearance.BorderSize = 0;
            this.btnParametresDeLaBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametresDeLaBase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParametresDeLaBase.Location = new System.Drawing.Point(33, 207);
            this.btnParametresDeLaBase.Margin = new System.Windows.Forms.Padding(30, 8, 30, 4);
            this.btnParametresDeLaBase.Name = "btnParametresDeLaBase";
            this.btnParametresDeLaBase.Size = new System.Drawing.Size(250, 35);
            this.btnParametresDeLaBase.TabIndex = 3;
            this.btnParametresDeLaBase.Text = "Paramètres de la base";
            this.btnParametresDeLaBase.UseVisualStyleBackColor = false;
            this.btnParametresDeLaBase.Click += new System.EventHandler(this.btnParametresDeLaBase_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.btnParametres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametres.FlatAppearance.BorderSize = 0;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametres.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnParametres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnParametres.Image = ((System.Drawing.Image)(resources.GetObject("btnParametres.Image")));
            this.btnParametres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametres.Location = new System.Drawing.Point(13, 143);
            this.btnParametres.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnParametres.Size = new System.Drawing.Size(290, 56);
            this.btnParametres.TabIndex = 2;
            this.btnParametres.Text = "          Paramètres";
            this.btnParametres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametres.UseVisualStyleBackColor = false;
            this.btnParametres.Click += new System.EventHandler(this.btnParametres_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnParametres);
            this.flowLayoutPanel1.Controls.Add(this.btnParametresDeLaBase);
            this.flowLayoutPanel1.Controls.Add(this.btnParametresSociete);
            this.flowLayoutPanel1.Controls.Add(this.btnGestionDesUtilisateurs);
            this.flowLayoutPanel1.Controls.Add(this.btnGestionDesRoles);
            this.flowLayoutPanel1.Controls.Add(this.btnDonnees);
            this.flowLayoutPanel1.Controls.Add(this.btnArticles);
            this.flowLayoutPanel1.Controls.Add(this.btnCaisses);
            this.flowLayoutPanel1.Controls.Add(this.btnClients);
            this.flowLayoutPanel1.Controls.Add(this.btnCollaborateurs);
            this.flowLayoutPanel1.Controls.Add(this.btnFamilles);
            this.flowLayoutPanel1.Controls.Add(this.btnOperations);
            this.flowLayoutPanel1.Controls.Add(this.btnOuvertureDeCaisse);
            this.flowLayoutPanel1.Controls.Add(this.btnVenteComptoir);
            this.flowLayoutPanel1.Controls.Add(this.btnMouvementsDeCaisse);
            this.flowLayoutPanel1.Controls.Add(this.btnFermetureDeCaisse);
            this.flowLayoutPanel1.Controls.Add(this.btnDocumentsDesStocks);
            this.flowLayoutPanel1.Controls.Add(this.btnDocumentsDesVentes);
            this.flowLayoutPanel1.Controls.Add(this.btnSaisieDesReglements);
            this.flowLayoutPanel1.Controls.Add(this.btnClotureDesCaisses);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistiques);
            this.flowLayoutPanel1.Controls.Add(this.btnControleDesCaisses);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistiquesDesCaisses);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 941);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 30, 0, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 73);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnParametresSociete
            // 
            this.btnParametresSociete.BackColor = System.Drawing.Color.Transparent;
            this.btnParametresSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametresSociete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametresSociete.FlatAppearance.BorderSize = 0;
            this.btnParametresSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametresSociete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnParametresSociete.Location = new System.Drawing.Point(33, 250);
            this.btnParametresSociete.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnParametresSociete.Name = "btnParametresSociete";
            this.btnParametresSociete.Size = new System.Drawing.Size(250, 35);
            this.btnParametresSociete.TabIndex = 9;
            this.btnParametresSociete.Text = "Paramètres société";
            this.btnParametresSociete.UseVisualStyleBackColor = false;
            this.btnParametresSociete.Click += new System.EventHandler(this.btnParametresSociete_Click);
            // 
            // btnGestionDesUtilisateurs
            // 
            this.btnGestionDesUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionDesUtilisateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionDesUtilisateurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionDesUtilisateurs.FlatAppearance.BorderSize = 0;
            this.btnGestionDesUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionDesUtilisateurs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionDesUtilisateurs.Location = new System.Drawing.Point(33, 293);
            this.btnGestionDesUtilisateurs.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnGestionDesUtilisateurs.Name = "btnGestionDesUtilisateurs";
            this.btnGestionDesUtilisateurs.Size = new System.Drawing.Size(250, 35);
            this.btnGestionDesUtilisateurs.TabIndex = 10;
            this.btnGestionDesUtilisateurs.Text = "Gestion des utilisateurs";
            this.btnGestionDesUtilisateurs.UseVisualStyleBackColor = false;
            this.btnGestionDesUtilisateurs.Click += new System.EventHandler(this.btnGestionDesUtilisateurs_Click);
            // 
            // btnGestionDesRoles
            // 
            this.btnGestionDesRoles.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionDesRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionDesRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionDesRoles.FlatAppearance.BorderSize = 0;
            this.btnGestionDesRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionDesRoles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestionDesRoles.Location = new System.Drawing.Point(33, 340);
            this.btnGestionDesRoles.Margin = new System.Windows.Forms.Padding(30, 8, 30, 4);
            this.btnGestionDesRoles.Name = "btnGestionDesRoles";
            this.btnGestionDesRoles.Size = new System.Drawing.Size(250, 35);
            this.btnGestionDesRoles.TabIndex = 45;
            this.btnGestionDesRoles.Text = "Gestion des rôles";
            this.btnGestionDesRoles.UseVisualStyleBackColor = false;
            this.btnGestionDesRoles.Click += new System.EventHandler(this.btnGestionDesRoles_Click);
            // 
            // btnDonnees
            // 
            this.btnDonnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.btnDonnees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonnees.FlatAppearance.BorderSize = 0;
            this.btnDonnees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonnees.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDonnees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnDonnees.Image = ((System.Drawing.Image)(resources.GetObject("btnDonnees.Image")));
            this.btnDonnees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonnees.Location = new System.Drawing.Point(13, 399);
            this.btnDonnees.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.btnDonnees.Name = "btnDonnees";
            this.btnDonnees.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDonnees.Size = new System.Drawing.Size(290, 56);
            this.btnDonnees.TabIndex = 56;
            this.btnDonnees.Text = "          Données";
            this.btnDonnees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonnees.UseVisualStyleBackColor = false;
            this.btnDonnees.Click += new System.EventHandler(this.btnDonnees_Click);
            // 
            // btnArticles
            // 
            this.btnArticles.BackColor = System.Drawing.Color.Transparent;
            this.btnArticles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArticles.FlatAppearance.BorderSize = 0;
            this.btnArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArticles.Location = new System.Drawing.Point(33, 464);
            this.btnArticles.Margin = new System.Windows.Forms.Padding(30, 9, 30, 4);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Size = new System.Drawing.Size(250, 35);
            this.btnArticles.TabIndex = 61;
            this.btnArticles.Text = "Articles";
            this.btnArticles.UseVisualStyleBackColor = false;
            this.btnArticles.Click += new System.EventHandler(this.btnArticles_Click);
            // 
            // btnCaisses
            // 
            this.btnCaisses.BackColor = System.Drawing.Color.Transparent;
            this.btnCaisses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaisses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaisses.FlatAppearance.BorderSize = 0;
            this.btnCaisses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaisses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaisses.Location = new System.Drawing.Point(33, 507);
            this.btnCaisses.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnCaisses.Name = "btnCaisses";
            this.btnCaisses.Size = new System.Drawing.Size(250, 35);
            this.btnCaisses.TabIndex = 57;
            this.btnCaisses.Text = "Caisses";
            this.btnCaisses.UseVisualStyleBackColor = false;
            this.btnCaisses.Click += new System.EventHandler(this.btnCaisses_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClients.Location = new System.Drawing.Point(33, 550);
            this.btnClients.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(250, 35);
            this.btnClients.TabIndex = 58;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnCollaborateurs
            // 
            this.btnCollaborateurs.BackColor = System.Drawing.Color.Transparent;
            this.btnCollaborateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollaborateurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollaborateurs.FlatAppearance.BorderSize = 0;
            this.btnCollaborateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollaborateurs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCollaborateurs.Location = new System.Drawing.Point(33, 593);
            this.btnCollaborateurs.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnCollaborateurs.Name = "btnCollaborateurs";
            this.btnCollaborateurs.Size = new System.Drawing.Size(250, 35);
            this.btnCollaborateurs.TabIndex = 59;
            this.btnCollaborateurs.Text = "Collaborateurs";
            this.btnCollaborateurs.UseVisualStyleBackColor = false;
            this.btnCollaborateurs.Click += new System.EventHandler(this.btnCollaborateurs_Click);
            // 
            // btnFamilles
            // 
            this.btnFamilles.BackColor = System.Drawing.Color.Transparent;
            this.btnFamilles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamilles.FlatAppearance.BorderSize = 0;
            this.btnFamilles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFamilles.Location = new System.Drawing.Point(33, 636);
            this.btnFamilles.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnFamilles.Name = "btnFamilles";
            this.btnFamilles.Size = new System.Drawing.Size(250, 35);
            this.btnFamilles.TabIndex = 60;
            this.btnFamilles.Text = "Familles";
            this.btnFamilles.UseVisualStyleBackColor = false;
            this.btnFamilles.Click += new System.EventHandler(this.btnFamilles_Click);
            // 
            // btnOperations
            // 
            this.btnOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.btnOperations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperations.FlatAppearance.BorderSize = 0;
            this.btnOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperations.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnOperations.Image")));
            this.btnOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperations.Location = new System.Drawing.Point(13, 695);
            this.btnOperations.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOperations.Size = new System.Drawing.Size(290, 56);
            this.btnOperations.TabIndex = 62;
            this.btnOperations.Text = "          Opérations";
            this.btnOperations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperations.UseVisualStyleBackColor = false;
            this.btnOperations.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnOuvertureDeCaisse
            // 
            this.btnOuvertureDeCaisse.BackColor = System.Drawing.Color.Transparent;
            this.btnOuvertureDeCaisse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuvertureDeCaisse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOuvertureDeCaisse.FlatAppearance.BorderSize = 0;
            this.btnOuvertureDeCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvertureDeCaisse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOuvertureDeCaisse.Location = new System.Drawing.Point(33, 759);
            this.btnOuvertureDeCaisse.Margin = new System.Windows.Forms.Padding(30, 8, 30, 4);
            this.btnOuvertureDeCaisse.Name = "btnOuvertureDeCaisse";
            this.btnOuvertureDeCaisse.Size = new System.Drawing.Size(250, 35);
            this.btnOuvertureDeCaisse.TabIndex = 63;
            this.btnOuvertureDeCaisse.Text = "Ouverture de caisse";
            this.btnOuvertureDeCaisse.UseVisualStyleBackColor = false;
            this.btnOuvertureDeCaisse.Click += new System.EventHandler(this.btnOuvertureDeCaisse_Click);
            // 
            // btnVenteComptoir
            // 
            this.btnVenteComptoir.BackColor = System.Drawing.Color.Transparent;
            this.btnVenteComptoir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenteComptoir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenteComptoir.FlatAppearance.BorderSize = 0;
            this.btnVenteComptoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenteComptoir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVenteComptoir.Location = new System.Drawing.Point(33, 802);
            this.btnVenteComptoir.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnVenteComptoir.Name = "btnVenteComptoir";
            this.btnVenteComptoir.Size = new System.Drawing.Size(250, 35);
            this.btnVenteComptoir.TabIndex = 64;
            this.btnVenteComptoir.Text = "Vente comptoir";
            this.btnVenteComptoir.UseVisualStyleBackColor = false;
            this.btnVenteComptoir.Click += new System.EventHandler(this.btnVenteComptoir_Click);
            // 
            // btnMouvementsDeCaisse
            // 
            this.btnMouvementsDeCaisse.BackColor = System.Drawing.Color.Transparent;
            this.btnMouvementsDeCaisse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMouvementsDeCaisse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMouvementsDeCaisse.FlatAppearance.BorderSize = 0;
            this.btnMouvementsDeCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouvementsDeCaisse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMouvementsDeCaisse.Location = new System.Drawing.Point(33, 845);
            this.btnMouvementsDeCaisse.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnMouvementsDeCaisse.Name = "btnMouvementsDeCaisse";
            this.btnMouvementsDeCaisse.Size = new System.Drawing.Size(250, 35);
            this.btnMouvementsDeCaisse.TabIndex = 66;
            this.btnMouvementsDeCaisse.Text = "Mouvements de caisse";
            this.btnMouvementsDeCaisse.UseVisualStyleBackColor = false;
            this.btnMouvementsDeCaisse.Click += new System.EventHandler(this.btnMouvementsDeCaisse_Click);
            // 
            // btnFermetureDeCaisse
            // 
            this.btnFermetureDeCaisse.BackColor = System.Drawing.Color.Transparent;
            this.btnFermetureDeCaisse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermetureDeCaisse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFermetureDeCaisse.FlatAppearance.BorderSize = 0;
            this.btnFermetureDeCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermetureDeCaisse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFermetureDeCaisse.Location = new System.Drawing.Point(33, 888);
            this.btnFermetureDeCaisse.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnFermetureDeCaisse.Name = "btnFermetureDeCaisse";
            this.btnFermetureDeCaisse.Size = new System.Drawing.Size(250, 35);
            this.btnFermetureDeCaisse.TabIndex = 67;
            this.btnFermetureDeCaisse.Text = "Fermeture de caisse";
            this.btnFermetureDeCaisse.UseVisualStyleBackColor = false;
            this.btnFermetureDeCaisse.Click += new System.EventHandler(this.btnFermetureDeCaisse_Click);
            // 
            // btnDocumentsDesStocks
            // 
            this.btnDocumentsDesStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnDocumentsDesStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentsDesStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentsDesStocks.FlatAppearance.BorderSize = 0;
            this.btnDocumentsDesStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentsDesStocks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDocumentsDesStocks.Location = new System.Drawing.Point(33, 931);
            this.btnDocumentsDesStocks.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnDocumentsDesStocks.Name = "btnDocumentsDesStocks";
            this.btnDocumentsDesStocks.Size = new System.Drawing.Size(250, 35);
            this.btnDocumentsDesStocks.TabIndex = 71;
            this.btnDocumentsDesStocks.Text = "Documents des stocks";
            this.btnDocumentsDesStocks.UseVisualStyleBackColor = false;
            this.btnDocumentsDesStocks.Click += new System.EventHandler(this.btnDocumentsDesStocks_Click);
            // 
            // btnDocumentsDesVentes
            // 
            this.btnDocumentsDesVentes.BackColor = System.Drawing.Color.Transparent;
            this.btnDocumentsDesVentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentsDesVentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentsDesVentes.FlatAppearance.BorderSize = 0;
            this.btnDocumentsDesVentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentsDesVentes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDocumentsDesVentes.Location = new System.Drawing.Point(33, 974);
            this.btnDocumentsDesVentes.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnDocumentsDesVentes.Name = "btnDocumentsDesVentes";
            this.btnDocumentsDesVentes.Size = new System.Drawing.Size(250, 35);
            this.btnDocumentsDesVentes.TabIndex = 65;
            this.btnDocumentsDesVentes.Text = "Documents des ventes";
            this.btnDocumentsDesVentes.UseVisualStyleBackColor = false;
            this.btnDocumentsDesVentes.Click += new System.EventHandler(this.btnDocumentsDesVentes_Click);
            // 
            // btnSaisieDesReglements
            // 
            this.btnSaisieDesReglements.BackColor = System.Drawing.Color.Transparent;
            this.btnSaisieDesReglements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaisieDesReglements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaisieDesReglements.FlatAppearance.BorderSize = 0;
            this.btnSaisieDesReglements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaisieDesReglements.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaisieDesReglements.Location = new System.Drawing.Point(33, 1017);
            this.btnSaisieDesReglements.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnSaisieDesReglements.Name = "btnSaisieDesReglements";
            this.btnSaisieDesReglements.Size = new System.Drawing.Size(250, 35);
            this.btnSaisieDesReglements.TabIndex = 69;
            this.btnSaisieDesReglements.Text = "Saisie des règlements";
            this.btnSaisieDesReglements.UseVisualStyleBackColor = false;
            this.btnSaisieDesReglements.Click += new System.EventHandler(this.btnSaisieDesReglements_Click);
            // 
            // btnClotureDesCaisses
            // 
            this.btnClotureDesCaisses.BackColor = System.Drawing.Color.Transparent;
            this.btnClotureDesCaisses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClotureDesCaisses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClotureDesCaisses.FlatAppearance.BorderSize = 0;
            this.btnClotureDesCaisses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClotureDesCaisses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClotureDesCaisses.Location = new System.Drawing.Point(33, 1060);
            this.btnClotureDesCaisses.Margin = new System.Windows.Forms.Padding(30, 4, 30, 4);
            this.btnClotureDesCaisses.Name = "btnClotureDesCaisses";
            this.btnClotureDesCaisses.Size = new System.Drawing.Size(250, 35);
            this.btnClotureDesCaisses.TabIndex = 70;
            this.btnClotureDesCaisses.Text = "Clôture des caisses";
            this.btnClotureDesCaisses.UseVisualStyleBackColor = false;
            this.btnClotureDesCaisses.Click += new System.EventHandler(this.btnClotureDesCaisses_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.FlatAppearance.BorderSize = 0;
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiques.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnStatistiques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnStatistiques.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistiques.Image")));
            this.btnStatistiques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiques.Location = new System.Drawing.Point(13, 1119);
            this.btnStatistiques.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStatistiques.Size = new System.Drawing.Size(290, 56);
            this.btnStatistiques.TabIndex = 72;
            this.btnStatistiques.Text = "          Statistiques";
            this.btnStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnControleDesCaisses
            // 
            this.btnControleDesCaisses.BackColor = System.Drawing.Color.Transparent;
            this.btnControleDesCaisses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControleDesCaisses.FlatAppearance.BorderSize = 0;
            this.btnControleDesCaisses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleDesCaisses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnControleDesCaisses.Location = new System.Drawing.Point(33, 1183);
            this.btnControleDesCaisses.Margin = new System.Windows.Forms.Padding(30, 8, 30, 4);
            this.btnControleDesCaisses.Name = "btnControleDesCaisses";
            this.btnControleDesCaisses.Size = new System.Drawing.Size(250, 35);
            this.btnControleDesCaisses.TabIndex = 68;
            this.btnControleDesCaisses.Text = "Contrôle des caisses";
            this.btnControleDesCaisses.UseVisualStyleBackColor = false;
            this.btnControleDesCaisses.Click += new System.EventHandler(this.btnControleDesCaisses_Click);
            // 
            // btnStatistiquesDesCaisses
            // 
            this.btnStatistiquesDesCaisses.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistiquesDesCaisses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiquesDesCaisses.FlatAppearance.BorderSize = 0;
            this.btnStatistiquesDesCaisses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiquesDesCaisses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStatistiquesDesCaisses.Location = new System.Drawing.Point(33, 1226);
            this.btnStatistiquesDesCaisses.Margin = new System.Windows.Forms.Padding(30, 4, 30, 50);
            this.btnStatistiquesDesCaisses.Name = "btnStatistiquesDesCaisses";
            this.btnStatistiquesDesCaisses.Size = new System.Drawing.Size(250, 35);
            this.btnStatistiquesDesCaisses.TabIndex = 73;
            this.btnStatistiquesDesCaisses.Text = "Statistiques des caisses";
            this.btnStatistiquesDesCaisses.UseVisualStyleBackColor = false;
            this.btnStatistiquesDesCaisses.Click += new System.EventHandler(this.btnStatistiquesDesCaisses_Click);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeDeconnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnSeDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSeDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnSeDeconnecter.Image")));
            this.btnSeDeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeDeconnecter.Location = new System.Drawing.Point(36, 855);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSeDeconnecter.Size = new System.Drawing.Size(238, 56);
            this.btnSeDeconnecter.TabIndex = 7;
            this.btnSeDeconnecter.Text = "           Se déconnecter";
            this.btnSeDeconnecter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeDeconnecter.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBoxBackground);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(320, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(864, 941);
            this.panelContainer.TabIndex = 8;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.ErrorImage = null;
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.ImageLocation = "";
            this.pictureBoxBackground.InitialImage = null;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(864, 941);
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            this.pictureBoxBackground.Resize += new System.EventHandler(this.panelContainer_Resize);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1184, 941);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnSeDeconnecter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnParametres;
        private Button btnParametresDeLaBase;
        private Button button38;
        private Button button37;
        private Button button36;
        private Button button35;
        private Button button34;
        private Button button33;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSeDeconnecter;
        private Button btnParametresSociete;
        private Button btnGestionDesUtilisateurs;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panelContainer;
        private PictureBox pictureBoxBackground;
        private Button btnGestionDesRoles;
        private Button btnDonnees;
        private Button btnArticles;
        private Button btnCaisses;
        private Button btnClients;
        private Button btnCollaborateurs;
        private Button btnFamilles;
        private Button btnOperations;
        private Button btnOuvertureDeCaisse;
        private Button btnVenteComptoir;
        private Button btnMouvementsDeCaisse;
        private Button btnFermetureDeCaisse;
        private Button btnDocumentsDesStocks;
        private Button btnDocumentsDesVentes;
        private Button btnSaisieDesReglements;
        private Button btnClotureDesCaisses;
        private Button btnStatistiques;
        private Button btnControleDesCaisses;
        private Button btnStatistiquesDesCaisses;
    }
}
