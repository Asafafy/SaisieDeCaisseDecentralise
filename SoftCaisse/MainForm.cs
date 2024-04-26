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
using SoftCaisse.Models;
using SoftCaisse.Forms.MouvementCaisse;
using static System.Collections.Specialized.BitVector32;
using SoftCaisse.Forms.ClotureCaisse;

namespace SoftCaisse
{
    public partial class MainForm : KryptonForm
    {
        Controls.DeviseControl deviseControl = new Controls.DeviseControl();
        Controls.CollaborateurControl collaborateurControl = new CollaborateurControl();
        Controls.CaissierControl caissierControl = new CaissierControl();
        Controls.CaissieGestion caisseGestion = new CaissieGestion();
        private string dataSource = null;
        private string initialCatalog = null;
        private string initialCatalogSage = null;
        private string userId = null;
        private string password = null;
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
            if (File.Exists(filePath) && File.Exists(filePathSage))
            {
                DialogResult result = MessageBox.Show("Votre base est déja configurée, souhaitez vous re-entrer les paramètres?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    ConnectDbForm connectDbForm = new ConnectDbForm();
                    connectDbForm.Show();
                }
            } 
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

        private void mouvementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouvementCaisseForm mouvementCaisseForm = new MouvementCaisseForm();
            mouvementCaisseForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void clôtureDeCausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClotureCaisse cl=new ClotureCaisse();
            cl.Show();
        }
    }
}
