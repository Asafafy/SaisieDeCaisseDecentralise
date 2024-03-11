using SoftCaisse.Controls;
using SoftCaisse.Forms.ConnexBase;
using SoftCaisse.Forms.GestionCaisse;
using SoftCaisse.Forms.OuvertureCaisse;
using SoftCaisse.Forms.ParamSociete;
using SoftCaisse.Forms.StructureCaisse;
using SoftCaisse.Utils.Controls;
using System;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Forms.DocumentVente;
using SoftCaisse.Forms.Login;
using SoftCaisse.Forms.StatCaisse;
using SoftCaisse.Forms.Statistiques;
using SoftCaisse.Forms.ControlCaisse;
using SoftCaisse.Forms.User;

namespace SoftCaisse
{
    public partial class MainForm : KryptonForm
    {
        Controls.DeviseControl deviseControl = new Controls.DeviseControl();
        Controls.CollaborateurControl collaborateurControl = new CollaborateurControl();
        Controls.CaissierControl caissierControl = new CaissierControl();
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
            //OpenFileDialog databaseOpenFile = new OpenFileDialog();
            //databaseOpenFile.ShowDialog();
            //databaseOpenFile.InitialDirectory = @"C:\";
            //databaseOpenFile.RestoreDirectory = true;
            //databaseOpenFile.DefaultExt = "gcm";
            //databaseOpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ConnectDbForm connectDbForm = new ConnectDbForm();
            connectDbForm.Show();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void collaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StructureCaisseForm structureCaisseForm = new StructureCaisseForm();
            AddControl.ToForm(structureCaisseForm, collaborateurControl);
        }

        private void ouvertureDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvertureCaisseForm ouvertureCaisse = new OuvertureCaisseForm();
            ouvertureCaisse.Show();
        }

        private void caissesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StructureCaisseForm structureCaisseForm = new StructureCaisseForm();
            AddControl.ToForm(structureCaisseForm, caissierControl);
        }

        private void gestionDesCaissesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCaisse gestion = new GestionCaisse();
            gestion.Show();
        }

        private void ventesComptoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VenteComptoirForm venteComptoirForm = new VenteComptoirForm();
            venteComptoirForm.Show();
        }

        private void dOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentVenteForm documentVenteForm = new DocumentVenteForm();
            documentVenteForm.Show();
        }

        private void ConnecterMenu_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void parArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatCaisseForm statCaisseForm = new StatCaisseForm();
            statCaisseForm.Show();
        }

        private void parArticlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StatArticleForm statArticleForm = new StatArticleForm();
            statArticleForm.Show();
        }

        private void contrôleDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCaisseForm controlCaisseForm = new ControlCaisseForm();
            controlCaisseForm.Show();   
        }

        private void utilsateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
        }
    }
}
