using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils.Global;
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
        private List<dynamic> _users;
        private int UserId;
        private AppDbContext _context;
        private DataTable _bindingSource;
        private bool isExpanded = false;
        private bool isModification = false;
        private MainForm mainForm;
        private readonly bool estAdmin;



        public UserManagementForm(MainForm form)
        {
            _context = new AppDbContext();
            mainForm = form;

            InitializeComponent();
            _scdContext = new SCDContext();
            _userRepository = new UserRepository(_scdContext);
            _bindingSource = new DataTable();

            var data = _userRepository.GetAll();
            LoadData();
            var listRole = new List<Controle>();
            foreach (int item in Enum.GetValues(typeof(RoleUser)))
            {
                listRole.Add(new Controle()
                {
                    item = item + "",
                    valeur = Enum.GetName(typeof(RoleUser), item)
                });
            }
            RoleCmbx.Items.Clear();
            RoleCmbx.DataSource = (listRole);
            RoleCmbx.ValueMember = "item";
            RoleCmbx.DisplayMember = "valeur";
            HideGroupBox();

            var currentUser = data.Where(user => user.UserId == mainForm.UtilisateurConnecteId).FirstOrDefault();
            estAdmin = currentUser.RoleId == ((int)RoleUser.Admin);
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
        public void ShowGroupBox()
        {
            groupBoxInformations.Visible = true;
            Height += 170;
            isExpanded = true;
            groupBox1.Enabled = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.DataSource = null;
        }
        private void ClearFields()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            RoleCmbx.SelectedIndex = -1;
            checkBoxEstActif.Checked = false;
        }
        public void LoadData()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            var data = _userRepository.GetAll();
            _users = new List<dynamic>();

            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Id"));
            _bindingSource.Columns.Add(new DataColumn("Login"));
            _bindingSource.Columns.Add(new DataColumn("Rôle"));
            _bindingSource.Columns.Add(new DataColumn("Statut"));
            var listUser = data
              .Select(user => new { UserId = user.UserId, Login = user.Login, Password = user.UserPassword, Role = Enum.GetName(typeof(RoleUser), user.RoleId), EstActif = user.EstActif == 1 ? "Activé" : "Désactivé" })
              .ToList();
            foreach (var user in listUser)
            {
                _bindingSource.Rows.Add(user.UserId, user.Login, user.Role, user.EstActif);
            }
            dataGridView1.DataSource = _bindingSource;
            _users.AddRange(listUser);
        }
        // =================================================== FIN FONCTIONS ===================================================
        // =======================================================================================================================





        // ========================================================================================================================
        // =================================================== DÉBUT EVENEMENTS ===================================================
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearFields();
            HideGroupBox();
            LoadData();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            if (isExpanded == false)
            {
                ShowGroupBox();
                isModification = false;
            }
        }







        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    isModification = true;
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    dynamic userWithId = _users.FirstOrDefault(user => user.UserId == UserId);
                    txtLogin.Text = userWithId.Login;
                    txtUserPassword.Text = userWithId.Password;
                    RoleCmbx.Text = userWithId.Role;
                    checkBoxEstActif.Checked = userWithId.EstActif == "Désactivé" ? true : false;
                    if (isExpanded == false)
                    {
                        ShowGroupBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




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




        // =========================== Ajout ou modification (Bouton OK) ============================
        private void kryptonButton3_Click(object sender, EventArgs e)
        {

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
                        Models.Users user = new Models.Users
                        {
                            Login = txtLogin.Text,
                            UserPassword = txtUserPassword.Text,
                            RoleId = int.Parse(con.item),
                            EstActif = checkBoxEstActif.Checked == false ? 1 : 0,
                        };

                        _userRepository.Add(user);
                        LoadData();
                        MessageBox.Show("Utilisateur inséré avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        HideGroupBox();
                    }
                }
            }
            else
            {
                if (UserId == 0)
                {
                    MessageBox.Show("Veuillez séléctionner un utilisateur.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dynamic userWithId = _users.FirstOrDefault(user => user.UserId == UserId);
                    var userToUpdate = _scdContext.Users.Where(user => user.UserId == UserId).FirstOrDefault();
                    DialogResult result = MessageBox.Show("Confirmer vous la modification?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    Controle con = (Controle)RoleCmbx.SelectedItem;

                    // Check the result
                    if (result == DialogResult.Yes)
                    {
                        userToUpdate.Login = txtLogin.Text;
                        userToUpdate.UserPassword = txtUserPassword.Text;
                        userToUpdate.RoleId = int.Parse(con.item);
                        userToUpdate.EstActif = checkBoxEstActif.Checked == false ? 1 : 0; // (O : Désactivé (Checked), 1 : Activé (Unchecked))
                        _userRepository.Update(userToUpdate);
                        MessageBox.Show("Modification réussie");
                        ClearFields();
                        LoadData();
                        HideGroupBox();
                    }
                }
            }
        }

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

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (UserId == 0)
            {
                MessageBox.Show("Veuillez séléctionner un utilisateur.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dynamic userWithId = _users.FirstOrDefault(user => user.UserId == UserId);
                var userToUpdate = _scdContext.Users.Where(user => user.UserId == UserId).FirstOrDefault();
                if (mainForm.UtilisateurConnecteId == UserId)
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer votre propre compte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (userToUpdate.RoleId == ((int)RoleUser.Admin))
                {
                    MessageBox.Show("Ce compte est un administrateur vous ne pouvez pas le supprimer.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Confirmer vous la suppression", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        _scdContext.Users.Remove(userToUpdate);
                        _scdContext.SaveChanges();
                        ClearFields();
                        LoadData();
                        MessageBox.Show("Opération réussie");
                    }
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            }
        }
    }
}
