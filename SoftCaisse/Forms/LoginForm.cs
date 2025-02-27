using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories.ScdDb;
using SoftCaisse.Utils;
using SoftCaisse.Utils.Global;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace SoftCaisse.Forms.Login
{
    public partial class LoginForm : KryptonForm
    {
        private readonly SCDContext _sCDContext;
        private ToolStripMenuItem _menuTraitement;
        private ToolStripMenuItem _menuFichier;
        private ToolStripMenuItem _menuStructure;
        private ToolStripMenuItem _menuEtat;
        private ToolStripMenuItem _menuAuthAcces;

        private readonly RoleAutorisationRepository _autorisationRepository;
        private readonly RoleRepository _roleRepository;

        private MainForm mainForm;




        // ==============================================================================================
        // ======================================== CONSTRUCTEUR ========================================
        public LoginForm(ToolStripMenuItem menuFichier, ToolStripMenuItem menuTraitement, ToolStripMenuItem menuStructure, ToolStripMenuItem menuEtat, ToolStripMenuItem autorisationAccèsToolStripMenuItem, MainForm form)
        {
            InitializeComponent();

            _sCDContext = new SCDContext();
            _autorisationRepository = new RoleAutorisationRepository();
            _roleRepository = new RoleRepository(_sCDContext);

            ChampUser.KeyDown += (sender, e) => EventHandlers.KeyDownEnterHandler(sender, e, kryptonButton1_Click);
            Champpwd.KeyDown += (sender, e) => EventHandlers.KeyDownEnterHandler(sender, e, kryptonButton1_Click);

            _menuTraitement = menuTraitement;
            _menuFichier = menuFichier;
            _menuStructure = menuStructure;
            _menuEtat = menuEtat;
            _menuAuthAcces = autorisationAccèsToolStripMenuItem;
            mainForm = form;
        }
        // ======================================== CONSTRUCTEUR ========================================
        // ==============================================================================================





        // ===========================================================================================
        // ======================================== FONCTIONS ========================================
        private void gererLesActivationsRubriques(List<int> autorisationsRubriques)
        {
            int i = 0;
            foreach (int auth in autorisationsRubriques)
            {
                bool estActif = auth == 1 ? true : false;
                switch (i)
                {
                    case 0:
                        _menuFichier.Enabled = estActif;
                        break;
                    case 1:
                        _menuFichier.DropDownItems["OuvrirMenu"].Enabled = estActif;
                        break;
                    case 2:
                        _menuFichier.DropDownItems["ParamSoc"].Enabled = estActif;
                        break;
                    case 3:
                        _menuFichier.DropDownItems["autAccesMenuItem"].Enabled = estActif;
                        break;
                    case 4:
                        _menuAuthAcces.DropDownItems[0].Enabled = estActif;
                        break;
                    case 5:
                        _menuAuthAcces.DropDownItems[1].Enabled = estActif;
                        break;
                    case 6:
                        _menuFichier.DropDownItems["miseEnPageToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 7:
                        _menuStructure.Enabled = estActif;
                        break;
                    case 8:
                        _menuStructure.DropDownItems["artilceToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 9:
                        _menuStructure.DropDownItems["caissesToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 10:
                        _menuStructure.DropDownItems["clientsToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 11:
                        _menuStructure.DropDownItems["collaborateursToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 12:
                        _menuStructure.DropDownItems["familleToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 13:
                        _menuTraitement.Enabled = estActif;
                        break;
                    case 14:
                        _menuTraitement.DropDownItems["ouvertureDeCaisseToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 15:
                        _menuTraitement.DropDownItems["ventesComptoirToolStripMenuItem"].Enabled = false;
                        break;
                    case 16:
                        _menuTraitement.DropDownItems["dOToolStripMenuItem"].Enabled = false;
                        break;
                    case 17:
                        _menuTraitement.DropDownItems["mouvementsToolStripMenuItem"].Enabled = false;
                        break;
                    case 18:
                        _menuTraitement.DropDownItems["fermetureDeCaisseToolStripMenuItem"].Enabled = false;
                        break;
                    case 19:
                        _menuTraitement.DropDownItems["gestionDesRèglementsToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 20:
                        _menuTraitement.DropDownItems["gestionDesComptesToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 21:
                        _menuTraitement.DropDownItems["contrôleDeCaisseToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 22:
                        _menuTraitement.DropDownItems["clôtureDeCausToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 23:
                        _menuEtat.Enabled = estActif;
                        break;
                    case 24:
                        _menuEtat.DropDownItems["statistiquesDesCaissesToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 25:
                        _menuEtat.DropDownItems["statistiquesDarticlesToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 26:
                        _menuEtat.DropDownItems["statistiquesClientsToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 27:
                        _menuEtat.DropDownItems["journauxDeVenteToolStripMenuItem"].Enabled = estActif;
                        break;
                    case 28:
                        _menuEtat.DropDownItems["inventaireToolStripMenuItem"].Enabled = estActif;
                        break;
                    default:
                        MessageBox.Show("Une erreur s'est produite!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                i++;
            }
        }
        // ======================================== FONCTIONS ========================================
        // ===========================================================================================





        // ============================================================================================
        // ======================================== EVENEMENTS ========================================
        private async void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            var user = _sCDContext.Users.FirstOrDefault(u => u.Login == ChampUser.Text && u.UserPassword == Champpwd.Text);
            if (user != null)
            {
                ConnectedUser.UserName = user.Login;
                ConnectedUser.UserId = user.UserId;
                ConnectedUser.roles = (RoleUser)user.RoleId;

                Role role = await _roleRepository.GetById(user.RoleId);
                List<int> autorisationsDesRubriques = _sCDContext.RoleAutorisation.Where(ra => ra.IdRole == role.IdRole).Select(ra => ra.EstAutorise).ToList();
                gererLesActivationsRubriques(autorisationsDesRubriques);

                mainForm.DisableLoginButton();
                mainForm.UtilisateurConnecteId = user.UserId;

                Close();
                MessageBox.Show("Connection avec succès !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur Pseudo/Mot de passe !", "Erreur Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ======================================== EVENEMENTS ========================================
        // ============================================================================================
    }
}
