using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;


namespace SoftCaisse.Forms.User
{
    public partial class UserManagementForm : KryptonForm
    {
        private readonly SCDContext _scdContext;
        private readonly UserRepository _userRepository;
        private List<Users> users;
        private int UserId;
        private AppDbContext _context;
        private DataTable _bindingSource;
        private bool isExpanded = false;
        private bool isModification = false;
        private MainForm mainForm;
        private readonly bool estAdmin;
        List<Role> roles;



        public UserManagementForm(MainForm form)
        {
            _context = new AppDbContext();
            mainForm = form;

            InitializeComponent();
            _scdContext = new SCDContext();
            _userRepository = new UserRepository(_scdContext);
            _bindingSource = new DataTable();

            var data = _userRepository.GetAll();
            roles = _scdContext.Role.ToList();
            LoadData();
            List<Controle> rolesCmbBx = roles.Select(r => new Controle { item = r.RoleIntitule, valeur = r.IdRole.ToString() }).ToList();
            RoleCmbx.Items.Clear();
            RoleCmbx.DataSource = rolesCmbBx;
            RoleCmbx.ValueMember = "valeur";
            RoleCmbx.DisplayMember = "item";
            HideGroupBox();

            Users currentUser = data.Where(user => user.UserId == mainForm.UtilisateurConnecteId).FirstOrDefault();
            estAdmin = currentUser.RoleId == 1;

            if (estAdmin == false)
            {
                btnAddUser.Enabled = false;
                btnSuppr.Enabled = false;
                btnModifUser.Enabled = false;
                RoleCmbx.Enabled = false;
                label2.Enabled = false;
                checkBoxEstActif.Visible = false;
                //btnReinitialiserMdp.Enabled = false;
            }
        }




        // =======================================================================================================================
        // =================================================== DÉBUT FONCTIONS ===================================================
        public void HideGroupBox()
        {
            groupBoxInformations.Visible = false;
            Height -= 170;
            isExpanded = false;
            groupBox1.Enabled = true;
            dataGridView1.BackgroundColor = Color.White;
        }
        public void ShowGroupBox(int selectedUserId, bool estNouveau)
        {
            groupBoxInformations.Visible = true;
            Height += 170;
            isExpanded = true;
            groupBox1.Enabled = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.DataSource = null;
            if (selectedUserId != mainForm.UtilisateurConnecteId)
            {
                txtUserPassword.Enabled = false;
                txtUserPassword.Text = "* * * * * * * *";
            }
            else
            {
                txtUserPassword.Enabled = false;
            }
            if (estNouveau == true)
            {
                txtUserPassword.Enabled = true;
                txtUserPassword.Text = "";
                btnReinitialiserMdp.Visible = false;
            }
            else
            {
                btnReinitialiserMdp.Visible = true;
            }
        }
        private void ResetAllFields()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            RoleCmbx.SelectedIndex = -1;
            checkBoxEstActif.Checked = false;
            txtUserPassword.Enabled = true;
        }
        public void LoadData()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            var data = _userRepository.GetAll();

            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Id"));
            _bindingSource.Columns.Add(new DataColumn("Login"));
            _bindingSource.Columns.Add(new DataColumn("Rôle"));
            _bindingSource.Columns.Add(new DataColumn("Statut"));
            users = _userRepository.GetAll();
            foreach (var user in users)
            {
                Role role = roles.Where(r => r.IdRole == user.RoleId).FirstOrDefault();
                string estActif = user.EstActif == 1 ? "Actif" : "Désactivé";
                _bindingSource.Rows.Add(user.UserId, user.Login, role.RoleIntitule, estActif);
            }
            dataGridView1.DataSource = _bindingSource;
        }
        // =================================================== FIN FONCTIONS ===================================================
        // =======================================================================================================================





        // =========================================================================================================================================
        // ============================================================= DÉBUT EVENEMENTS ==========================================================

        // ===================================== Double clique sur une cellulle du DatagridView =====================================
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow dfedRow = dataGridView1.Rows[e.RowIndex];
                    btnModifier_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===================================== Fin Double clique sur une cellulle du DatagridView =====================================



        // ===================================== Clique sur une cellulle du DatagridView =====================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                Users connectedUser = users.FirstOrDefault(u => u.UserId == mainForm.UtilisateurConnecteId);
                if (connectedUser.RoleId != 1)
                {
                    if (UserId.ToString() == mainForm.UtilisateurConnecteId.ToString())
                    {
                        btnModifUser.Enabled = true;
                    }
                    else
                    {
                        btnModifUser.Enabled = false;
                    }
                }
                else
                {
                    btnModifUser.Enabled = true;
                }
            }
        }
        // ===================================== FinClique sur une cellulle du DatagridView =====================================



        // ===================================== Début clique sur le bouton "Réinitialiser Mot de passe" =====================================
        private void btnReinitialiserMdp_Click(object sender, EventArgs e)
        {
            txtUserPassword.Enabled = true;
            txtUserPassword.Clear();
            txtUserPassword.Focus();
        }
        // ===================================== Début clique sur le bouton "Réinitialiser Mot de passe" =====================================



        // =========================== Ajout ou modification (Bouton OK) ============================
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            // Cas Ajout d'un nouveau utilisateur
            if (isModification == false)
            {
                if (txtLogin.Text == "" || txtUserPassword.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var userToSearch = _scdContext.Users.Where(user => user.Login == txtLogin.Text).FirstOrDefault();
                    if (userToSearch != null)
                    {
                        MessageBox.Show("Le login est déja pris.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Controle con = (Controle)RoleCmbx.SelectedItem;
                        Users user = new Users
                        {
                            Login = txtLogin.Text,
                            UserPassword = txtUserPassword.Text,
                            RoleId = int.Parse(con.valeur),
                            EstActif = checkBoxEstActif.Checked == false ? 1 : 0,
                        };

                        _userRepository.Add(user);
                        LoadData();
                        MessageBox.Show("Utilisateur inséré avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetAllFields();
                        HideGroupBox();
                    }
                }
            }
            // Cas Modification d'un utilisateur existant
            else
            {
                if (UserId == 0)
                {
                    MessageBox.Show("Veuillez séléctionner un utilisateur.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Users userWithId = users.FirstOrDefault(user => user.UserId == UserId);
                    var userToUpdate = _scdContext.Users.Where(user => user.UserId == UserId).FirstOrDefault();
                    DialogResult result = MessageBox.Show("Confirmer vous la modification?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    Controle con = (Controle)RoleCmbx.SelectedItem;

                    if (result == DialogResult.Yes)
                    {
                        userToUpdate.Login = txtLogin.Text;
                        if (txtUserPassword.Enabled == true)
                        {
                            userToUpdate.UserPassword = txtUserPassword.Text;
                        }
                        userToUpdate.RoleId = int.Parse(con.valeur);
                        userToUpdate.EstActif = checkBoxEstActif.Checked == false ? 1 : 0; // (O : Désactivé (Checked), 1 : Activé (Unchecked))
                        _userRepository.Update(userToUpdate);
                        MessageBox.Show("Modification réussie");
                        ResetAllFields();
                        LoadData();
                        HideGroupBox();
                    }
                }
            }
        }
        // =========================== Fin Ajout ou modification (Bouton OK) ============================



        // ===================================== Bouton "Annuler" (Annuler) une Modification ou un Ajout =====================================
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ResetAllFields();
            HideGroupBox();
            LoadData();
        }
        // ===================================== Fin Bouton "Annuler" (Annuler) une Modification ou un Ajout =====================================



        // ===================================== Début Bouton "Nouveau" (Nouvel utilisateur) =====================================
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (isExpanded == false)
            {
                ShowGroupBox(0, true);
                isModification = false;
            }
        }
        // ===================================== Fin Bouton "Nouveau" (Nouvel utilisateur) =====================================



        // ===================================== Bouton "Modifier" =====================================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    isModification = true;
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    Users userWithId = users.FirstOrDefault(user => user.UserId == UserId);
                    Role roleSelectionne = roles.FirstOrDefault(r => r.IdRole == userWithId.RoleId);
                    RoleCmbx.SelectedIndex = RoleCmbx.FindStringExact(roleSelectionne.RoleIntitule);
                    txtLogin.Text = userWithId.Login;
                    txtUserPassword.Text = userWithId.UserPassword;
                    checkBoxEstActif.Checked = userWithId.EstActif == 1 ? false : true;

                    if (isExpanded == false)
                    {
                        ShowGroupBox(UserId, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===================================== Fin Bouton "Modifier" =====================================



        // ===================================== Début Bouton "Supprimer" =====================================
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserId == 0)
                {
                    MessageBox.Show("Veuillez séléctionner un utilisateur.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Users userToDelete = _scdContext.Users.Where(user => user.UserId == UserId).FirstOrDefault();
                    if (userToDelete.RoleId == 1)
                    {
                        MessageBox.Show("Ce compte est un un compte administrateur, vous ne pouvez pas le supprimer.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Confirmer vous la suppression", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            _scdContext.Users.Remove(userToDelete);
                            _scdContext.SaveChanges();
                            ResetAllFields();
                            LoadData();
                            MessageBox.Show("Opération réussie");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===================================== Fin Bouton "Supprimer" =====================================



        // =========================== Fermeture de la fenêtre (Bouton Fermer) ============================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            if (isExpanded == true)
            {
                DialogResult resultat = MessageBox.Show("Voulez-vous abandonner les modifications ?", "Confirmation de fermeture", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultat == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        // =========================== Fin Fermeture de la fenêtre (Bouton Fermer) ============================
    }
}
