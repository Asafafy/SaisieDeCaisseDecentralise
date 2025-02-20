﻿using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Controls;
using SoftCaisse.Forms;
using SoftCaisse.Forms.Article;
using SoftCaisse.Forms.Clients;
using SoftCaisse.Forms.ClotureCaisse;
using SoftCaisse.Forms.ConnexBase;
using SoftCaisse.Forms.ControlCaisse;
using SoftCaisse.Forms.DocumentVente;
using SoftCaisse.Forms.Famille;
using SoftCaisse.Forms.FermetureCaisse;
using SoftCaisse.Forms.GestionCaisse;
using SoftCaisse.Forms.Login;
using SoftCaisse.Forms.MouvementCaisse;
using SoftCaisse.Forms.OuvertureCaisse;
using SoftCaisse.Forms.ParamSociete;
using SoftCaisse.Forms.StatCaisse;
using SoftCaisse.Forms.StructureCaisse;
using SoftCaisse.Forms.User;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Utils.Controls;
using SoftCaisse.Utils.Global;
using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace SoftCaisse
{
    public partial class MainForm : KryptonForm
    {
        private int _caisseNo = 0;
        private int _caissierCollabNo = 0;
        private int _connectedUserId = 0;

        public int CaisseNo
        {
            get { return _caisseNo; }
            set { _caisseNo = value; }
        }

        public int CaissierCollabNo
        {
            get { return _caissierCollabNo; }
            set { _caissierCollabNo = value; }
        }

        public int UtilisateurConnecteId
        {
            get { return _connectedUserId; }
            set { _connectedUserId = value; }
        }

        Controls.DeviseControl deviseControl = new Controls.DeviseControl();
        Controls.CollaborateurControl collaborateurControl = new CollaborateurControl();
        Controls.CaissierControl caissierControl = new CaissierControl();
        Controls.CaissieGestion caisseGestion = new CaissieGestion();
        private string dataSource = null;
        private string initialCatalog = null;
        private string initialCatalogSage = null;
        private string userId = null;
        private string password = null;
        private bool _estConnecte = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ParamSoc_Click(object sender, EventArgs e)
        {
            ParamSocForm paramsoc = new ParamSocForm();
            paramsoc.Show();
        }
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "ServeurCfg.txt");
            string filePathSage = Path.Combine(baseDirectory, "ServeurSage.txt");
            string filePathObj = Path.Combine(baseDirectory, "ObjSage.txt");
            int mid = 0;
            if (File.Exists(filePath) && File.Exists(filePathSage) && File.Exists(filePathObj))
            {
                DialogResult result = MessageBox.Show("Votre base est déjà configurée, souhaitez vous re-entrer les paramètres?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    mid = 1;
                }
            }
            else
            {
                mid = 1;
            }
            if (mid == 1)
            {
                ConnectDbForm connectDbForm = new ConnectDbForm();
                connectDbForm.Show();
            }
        }
        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fichierToolStripMenuItem.DropDownItems["ParamSoc"].Enabled = false;
            fichierToolStripMenuItem.DropDownItems["autAccesMenuItem"].Enabled = false;
            fichierToolStripMenuItem.DropDownItems["miseEnPageToolStripMenuItem"].Enabled = false;
            traitementToolStripMenuItem.Enabled = false;
            structureToolStripMenuItem.Enabled = false;
            etatToolStripMenuItem.Enabled = false;
            _estConnecte = false;
            ConnecterMenu.Enabled = true;
        }

        private void collaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StructureCaisseForm structureCaisseForm = new StructureCaisseForm();
            AddControl.ToForm(structureCaisseForm, collaborateurControl);
        }

        private void ouvertureDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvertureCaisseForm ouvertureCaisse = new OuvertureCaisseForm(traitementToolStripMenuItem, this);
            ouvertureCaisse.Show();

        }

        private void caissesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StructureCaisseForm structureCaisseForm = new StructureCaisseForm();
            AddControl.ToForm(structureCaisseForm, caissierControl);
            structureCaisseForm.Focus();
        }

        private void gestionDesCaissesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCaisse gestion = new GestionCaisse();
            AddControl.ToForm(gestion, caisseGestion);
            gestion.Focus();
        }

        private void ventesComptoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VenteComptoirForm venteComptoirForm = new VenteComptoirForm(int.Parse(CaisseOuvert.CaisseID), int.Parse(CaisseOuvert.CaissierID), null, null);
            venteComptoirForm.Show();
        }

        private void dOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDocumentVenteForm documentVenteForm = new ListeDocumentVenteForm(this);
            documentVenteForm.Show();
        }

        private void ConnecterMenu_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(
                fichierToolStripMenuItem,
                traitementToolStripMenuItem,
                structureToolStripMenuItem,
                etatToolStripMenuItem,
                autAccesMenuItem,
                this
            );
            login.Show();
        }
        public void DisableLoginButton()
        {
            ConnecterMenu.Enabled = false;
            _estConnecte = true;
        }

        private void parArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatCaisseForm statCaisseForm = new StatCaisseForm();
            statCaisseForm.Show();
        }



        private void contrôleDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCaisseForm controlCaisseForm = new ControlCaisseForm();
            controlCaisseForm.Show();
        }

        private void utilsateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(this);
            userManagementForm.Show();
        }

        private void mouvementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouvementCaisseForm mouvementCaisseForm = new MouvementCaisseForm(this);
            mouvementCaisseForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void clôtureDeCausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClotureCaisse cl = new ClotureCaisse();
            cl.Show();
        }

        private void fermetureDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermetureCaisse fe = new FermetureCaisse(traitementToolStripMenuItem);
            fe.Show();
        }

        private void statistiquesDesCaissesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatCaisseForm stat = new StatCaisseForm();
            stat.Show();
        }


        private void artilceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListeArticles("", false, false, null, 0).Show();
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeFamillesDArticles listeFamillesDArticles = new ListeFamillesDArticles();
            listeFamillesDArticles.Show();
        }

        private void saisieDesRèglementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieDesReglementsClients saisieDesReglementsClients = new SaisieDesReglementsClients();
            saisieDesReglementsClients.Show();
        }

        private void gestionDesRôlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDesRoles gestionDesRoles = new GestionDesRoles();
            gestionDesRoles.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClients listeClients = new ListeClients();
            listeClients.Show();
        }
    }
}
