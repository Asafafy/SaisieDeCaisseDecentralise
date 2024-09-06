using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Utils.Global;
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
        private MainForm _mainForm;
        public LoginForm(ToolStripMenuItem menuFichier, ToolStripMenuItem menuTraitement, ToolStripMenuItem menuStructure, ToolStripMenuItem menuEtat, MainForm mainForm)
        {
            InitializeComponent();
            _sCDContext = new SCDContext();
            _menuTraitement = menuTraitement;
            _menuFichier = menuFichier;
            _menuStructure = menuStructure;
            _menuEtat = menuEtat;
            _mainForm = mainForm;
        }

        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            var user = _sCDContext.Users.FirstOrDefault(u => u.Login == ChampUser.Text && u.UserPassword == Champpwd.Text);
            if (user != null)
            {
                ConnectedUser.UserName = user.Login;
                ConnectedUser.UserId = user.UserId;
                ConnectedUser.roles = user.RoleId;
                _menuTraitement.Enabled = true;
                _menuStructure.Enabled = true;
                _menuEtat.Enabled = true;
                _menuFichier.DropDownItems["ParamSoc"].Enabled = true;
                _menuFichier.DropDownItems["autorisationAccèsToolStripMenuItem"].Enabled = true;
                _menuFichier.DropDownItems["miseEnPageToolStripMenuItem"].Enabled = true;
                _mainForm.DisableLoginButton();
                this.Close();
                MessageBox.Show("Connection avec succès !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur Pseudo/Mot de passe !", "Erreur Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ChampUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton1_Click(sender, e);
            }
        }

        private void Champpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kryptonButton1_Click(sender, e);
            }
        }
    }
}
