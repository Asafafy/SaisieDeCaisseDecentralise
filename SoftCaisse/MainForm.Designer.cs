namespace SoftCaisse
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnecterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OuvrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamSoc = new System.Windows.Forms.ToolStripMenuItem();
            this.autorisationAccèsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseEnPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.structureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caissesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvertureDeCaisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventesComptoirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermetureDeCaisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesRèglementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieDesRèglementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remiseEnBanqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCaissesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôleDeCaisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clôtureDeCausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesDesCaissesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFamillesDarticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parModeDeRèglementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesDarticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parArticlesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parFamilleDarticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palmarèsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFamillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFamillesDarticlesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.palmarèsDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journauxDeVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.structureToolStripMenuItem,
            this.traitementToolStripMenuItem,
            this.etatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnecterMenu,
            this.OuvrirMenu,
            this.fermerToolStripMenuItem,
            this.ParamSoc,
            this.autorisationAccèsToolStripMenuItem,
            this.miseEnPageToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.fichierToolStripMenuItem.Text = "Fichier ";
            // 
            // ConnecterMenu
            // 
            this.ConnecterMenu.Name = "ConnecterMenu";
            this.ConnecterMenu.Size = new System.Drawing.Size(237, 26);
            this.ConnecterMenu.Text = "Se connecter";
            this.ConnecterMenu.Click += new System.EventHandler(this.ConnecterMenu_Click);
            // 
            // OuvrirMenu
            // 
            this.OuvrirMenu.Name = "OuvrirMenu";
            this.OuvrirMenu.Size = new System.Drawing.Size(237, 26);
            this.OuvrirMenu.Text = "Paramètre de base";
            this.OuvrirMenu.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // ParamSoc
            // 
            this.ParamSoc.Name = "ParamSoc";
            this.ParamSoc.Size = new System.Drawing.Size(237, 26);
            this.ParamSoc.Text = "Paramètres de société";
            this.ParamSoc.Click += new System.EventHandler(this.ParamSoc_Click);
            // 
            // autorisationAccèsToolStripMenuItem
            // 
            this.autorisationAccèsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsateurToolStripMenuItem});
            this.autorisationAccèsToolStripMenuItem.Name = "autorisationAccèsToolStripMenuItem";
            this.autorisationAccèsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.autorisationAccèsToolStripMenuItem.Text = "Autorisation accès";
            // 
            // utilsateurToolStripMenuItem
            // 
            this.utilsateurToolStripMenuItem.Name = "utilsateurToolStripMenuItem";
            this.utilsateurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.utilsateurToolStripMenuItem.Text = "Utilisateurs";
            this.utilsateurToolStripMenuItem.Click += new System.EventHandler(this.utilsateurToolStripMenuItem_Click);
            // 
            // miseEnPageToolStripMenuItem
            // 
            this.miseEnPageToolStripMenuItem.Name = "miseEnPageToolStripMenuItem";
            this.miseEnPageToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.miseEnPageToolStripMenuItem.Text = "Mise en page";
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.quiterToolStripMenuItem.Text = "Quiter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // structureToolStripMenuItem
            // 
            this.structureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collaborateursToolStripMenuItem,
            this.caissesToolStripMenuItem});
            this.structureToolStripMenuItem.Name = "structureToolStripMenuItem";
            this.structureToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.structureToolStripMenuItem.Text = "Structure ";
            // 
            // collaborateursToolStripMenuItem
            // 
            this.collaborateursToolStripMenuItem.Name = "collaborateursToolStripMenuItem";
            this.collaborateursToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.collaborateursToolStripMenuItem.Text = "Collaborateurs";
            this.collaborateursToolStripMenuItem.Click += new System.EventHandler(this.collaborateursToolStripMenuItem_Click);
            // 
            // caissesToolStripMenuItem
            // 
            this.caissesToolStripMenuItem.Name = "caissesToolStripMenuItem";
            this.caissesToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.caissesToolStripMenuItem.Text = "Caisses";
            this.caissesToolStripMenuItem.Click += new System.EventHandler(this.caissesToolStripMenuItem_Click);
            // 
            // traitementToolStripMenuItem
            // 
            this.traitementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvertureDeCaisseToolStripMenuItem,
            this.ventesComptoirToolStripMenuItem,
            this.dOToolStripMenuItem,
            this.mouvementsToolStripMenuItem,
            this.fermetureDeCaisseToolStripMenuItem,
            this.gestionDesRèglementsToolStripMenuItem,
            this.gestionDesComptesToolStripMenuItem,
            this.contrôleDeCaisseToolStripMenuItem,
            this.clôtureDeCausToolStripMenuItem});
            this.traitementToolStripMenuItem.Name = "traitementToolStripMenuItem";
            this.traitementToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.traitementToolStripMenuItem.Text = "Traitement ";
            // 
            // ouvertureDeCaisseToolStripMenuItem
            // 
            this.ouvertureDeCaisseToolStripMenuItem.Name = "ouvertureDeCaisseToolStripMenuItem";
            this.ouvertureDeCaisseToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.ouvertureDeCaisseToolStripMenuItem.Text = "Ouverture de caisse...";
            this.ouvertureDeCaisseToolStripMenuItem.Click += new System.EventHandler(this.ouvertureDeCaisseToolStripMenuItem_Click);
            // 
            // ventesComptoirToolStripMenuItem
            // 
            this.ventesComptoirToolStripMenuItem.Name = "ventesComptoirToolStripMenuItem";
            this.ventesComptoirToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.ventesComptoirToolStripMenuItem.Text = "Ventes comptoir";
            this.ventesComptoirToolStripMenuItem.Click += new System.EventHandler(this.ventesComptoirToolStripMenuItem_Click);
            // 
            // dOToolStripMenuItem
            // 
            this.dOToolStripMenuItem.Name = "dOToolStripMenuItem";
            this.dOToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.dOToolStripMenuItem.Text = "Documents des ventes";
            this.dOToolStripMenuItem.Click += new System.EventHandler(this.dOToolStripMenuItem_Click);
            // 
            // mouvementsToolStripMenuItem
            // 
            this.mouvementsToolStripMenuItem.Name = "mouvementsToolStripMenuItem";
            this.mouvementsToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.mouvementsToolStripMenuItem.Text = "Mouvements de caisse...";
            // 
            // fermetureDeCaisseToolStripMenuItem
            // 
            this.fermetureDeCaisseToolStripMenuItem.Name = "fermetureDeCaisseToolStripMenuItem";
            this.fermetureDeCaisseToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.fermetureDeCaisseToolStripMenuItem.Text = "Fermeture de caisse";
            // 
            // gestionDesRèglementsToolStripMenuItem
            // 
            this.gestionDesRèglementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieDesRèglementsToolStripMenuItem,
            this.remiseEnBanqueToolStripMenuItem});
            this.gestionDesRèglementsToolStripMenuItem.Name = "gestionDesRèglementsToolStripMenuItem";
            this.gestionDesRèglementsToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.gestionDesRèglementsToolStripMenuItem.Text = "Gestion des règlements";
            // 
            // saisieDesRèglementsToolStripMenuItem
            // 
            this.saisieDesRèglementsToolStripMenuItem.Name = "saisieDesRèglementsToolStripMenuItem";
            this.saisieDesRèglementsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.saisieDesRèglementsToolStripMenuItem.Text = "Saisie des règlements";
            // 
            // remiseEnBanqueToolStripMenuItem
            // 
            this.remiseEnBanqueToolStripMenuItem.Name = "remiseEnBanqueToolStripMenuItem";
            this.remiseEnBanqueToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.remiseEnBanqueToolStripMenuItem.Text = "Remise en banque...";
            // 
            // gestionDesComptesToolStripMenuItem
            // 
            this.gestionDesComptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesCaissesToolStripMenuItem,
            this.gestionDesArticlesToolStripMenuItem});
            this.gestionDesComptesToolStripMenuItem.Name = "gestionDesComptesToolStripMenuItem";
            this.gestionDesComptesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.gestionDesComptesToolStripMenuItem.Text = "Gestion des comptes";
            // 
            // gestionDesCaissesToolStripMenuItem
            // 
            this.gestionDesCaissesToolStripMenuItem.Name = "gestionDesCaissesToolStripMenuItem";
            this.gestionDesCaissesToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.gestionDesCaissesToolStripMenuItem.Text = "Gestion des caisses";
            this.gestionDesCaissesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesCaissesToolStripMenuItem_Click);
            // 
            // gestionDesArticlesToolStripMenuItem
            // 
            this.gestionDesArticlesToolStripMenuItem.Name = "gestionDesArticlesToolStripMenuItem";
            this.gestionDesArticlesToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.gestionDesArticlesToolStripMenuItem.Text = "Gestion des articles";
            // 
            // contrôleDeCaisseToolStripMenuItem
            // 
            this.contrôleDeCaisseToolStripMenuItem.Name = "contrôleDeCaisseToolStripMenuItem";
            this.contrôleDeCaisseToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.contrôleDeCaisseToolStripMenuItem.Text = "Contrôle de caisse";
            this.contrôleDeCaisseToolStripMenuItem.Click += new System.EventHandler(this.contrôleDeCaisseToolStripMenuItem_Click);
            // 
            // clôtureDeCausToolStripMenuItem
            // 
            this.clôtureDeCausToolStripMenuItem.Name = "clôtureDeCausToolStripMenuItem";
            this.clôtureDeCausToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.clôtureDeCausToolStripMenuItem.Text = "Clôture de caisse...";
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistiquesDesCaissesToolStripMenuItem,
            this.statistiquesDarticlesToolStripMenuItem,
            this.statistiquesClientsToolStripMenuItem,
            this.journauxDeVenteToolStripMenuItem,
            this.inventaireToolStripMenuItem});
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.etatToolStripMenuItem.Text = "Etat";
            // 
            // statistiquesDesCaissesToolStripMenuItem
            // 
            this.statistiquesDesCaissesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parArticlesToolStripMenuItem,
            this.parFamillesDarticlesToolStripMenuItem,
            this.parModeDeRèglementToolStripMenuItem});
            this.statistiquesDesCaissesToolStripMenuItem.Name = "statistiquesDesCaissesToolStripMenuItem";
            this.statistiquesDesCaissesToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.statistiquesDesCaissesToolStripMenuItem.Text = "Statistiques de caisses";
            // 
            // parArticlesToolStripMenuItem
            // 
            this.parArticlesToolStripMenuItem.Name = "parArticlesToolStripMenuItem";
            this.parArticlesToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.parArticlesToolStripMenuItem.Text = "Par articles";
            this.parArticlesToolStripMenuItem.Click += new System.EventHandler(this.parArticlesToolStripMenuItem_Click);
            // 
            // parFamillesDarticlesToolStripMenuItem
            // 
            this.parFamillesDarticlesToolStripMenuItem.Name = "parFamillesDarticlesToolStripMenuItem";
            this.parFamillesDarticlesToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.parFamillesDarticlesToolStripMenuItem.Text = "Par familles d\'articles";
            // 
            // parModeDeRèglementToolStripMenuItem
            // 
            this.parModeDeRèglementToolStripMenuItem.Name = "parModeDeRèglementToolStripMenuItem";
            this.parModeDeRèglementToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.parModeDeRèglementToolStripMenuItem.Text = "Par mode de règlements";
            // 
            // statistiquesDarticlesToolStripMenuItem
            // 
            this.statistiquesDarticlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parArticlesToolStripMenuItem1,
            this.parFamilleDarticlesToolStripMenuItem,
            this.palmarèsToolStripMenuItem});
            this.statistiquesDarticlesToolStripMenuItem.Name = "statistiquesDarticlesToolStripMenuItem";
            this.statistiquesDarticlesToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.statistiquesDarticlesToolStripMenuItem.Text = "Statistiques articles";
            // 
            // parArticlesToolStripMenuItem1
            // 
            this.parArticlesToolStripMenuItem1.Name = "parArticlesToolStripMenuItem1";
            this.parArticlesToolStripMenuItem1.Size = new System.Drawing.Size(287, 26);
            this.parArticlesToolStripMenuItem1.Text = "Par articles";
            this.parArticlesToolStripMenuItem1.Click += new System.EventHandler(this.parArticlesToolStripMenuItem1_Click);
            // 
            // parFamilleDarticlesToolStripMenuItem
            // 
            this.parFamilleDarticlesToolStripMenuItem.Name = "parFamilleDarticlesToolStripMenuItem";
            this.parFamilleDarticlesToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.parFamilleDarticlesToolStripMenuItem.Text = "Par familles d\'articles";
            // 
            // palmarèsToolStripMenuItem
            // 
            this.palmarèsToolStripMenuItem.Name = "palmarèsToolStripMenuItem";
            this.palmarèsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.palmarèsToolStripMenuItem.Text = "Palmarès des ventes d\'articles";
            // 
            // statistiquesClientsToolStripMenuItem
            // 
            this.statistiquesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parFamillToolStripMenuItem,
            this.parFamillesDarticlesToolStripMenuItem1,
            this.palmarèsDesClientsToolStripMenuItem});
            this.statistiquesClientsToolStripMenuItem.Name = "statistiquesClientsToolStripMenuItem";
            this.statistiquesClientsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.statistiquesClientsToolStripMenuItem.Text = "Statistiques clients";
            // 
            // parFamillToolStripMenuItem
            // 
            this.parFamillToolStripMenuItem.Name = "parFamillToolStripMenuItem";
            this.parFamillToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.parFamillToolStripMenuItem.Text = "Par articles";
            // 
            // parFamillesDarticlesToolStripMenuItem1
            // 
            this.parFamillesDarticlesToolStripMenuItem1.Name = "parFamillesDarticlesToolStripMenuItem1";
            this.parFamillesDarticlesToolStripMenuItem1.Size = new System.Drawing.Size(231, 26);
            this.parFamillesDarticlesToolStripMenuItem1.Text = "Par familles d\'articles";
            // 
            // palmarèsDesClientsToolStripMenuItem
            // 
            this.palmarèsDesClientsToolStripMenuItem.Name = "palmarèsDesClientsToolStripMenuItem";
            this.palmarèsDesClientsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.palmarèsDesClientsToolStripMenuItem.Text = "Palmarès des clients";
            // 
            // journauxDeVenteToolStripMenuItem
            // 
            this.journauxDeVenteToolStripMenuItem.Name = "journauxDeVenteToolStripMenuItem";
            this.journauxDeVenteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.journauxDeVenteToolStripMenuItem.Text = "Journaux de vente";
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            // 
            // databaseOpenFile
            // 
            this.databaseOpenFile.FileName = "databaseOpenFile";
            this.databaseOpenFile.Title = "Ouvrir le fichier commercial";
            // 
            // kryptonPalette1
            // 
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
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftCaisse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OuvrirMenu;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamSoc;
        private System.Windows.Forms.ToolStripMenuItem autorisationAccèsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseEnPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem structureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caissesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvertureDeCaisseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventesComptoirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermetureDeCaisseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesRèglementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieDesRèglementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remiseEnBanqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCaissesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrôleDeCaisseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clôtureDeCausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesDesCaissesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFamillesDarticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parModeDeRèglementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesDarticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parArticlesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parFamilleDarticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palmarèsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFamillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFamillesDarticlesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem palmarèsDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journauxDeVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog databaseOpenFile;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ToolStripMenuItem ConnecterMenu;
    }
}

