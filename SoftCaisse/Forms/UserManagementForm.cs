using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace SoftCaisse.Forms.User
{
    public partial class UserManagementForm : KryptonForm
    {
        private readonly SCDContext _scdContext;
        private readonly UserRepository _userRepository;
        private List<dynamic> _users;
        private int UserId;
        public UserManagementForm()
        {
            InitializeComponent();
            _scdContext = new SCDContext();
            _userRepository = new UserRepository(_scdContext);

            var data = _userRepository.GetAll();
            LoadData();
            var listRole = new List<Controle>();
            foreach (int item in Enum.GetValues(typeof(RoleUser)))
            {
                listRole.Add(new Controle()
                {
                    item =item+"",
                    valeur = Enum.GetName(typeof(RoleUser),item)
                });
            }
            RoleCmbx.Items.Clear();
            RoleCmbx.DataSource=(listRole);
            RoleCmbx.ValueMember="item";
            RoleCmbx.DisplayMember="valeur";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtUserPassword.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else{
                var userToSearch = _scdContext.Users.Where(user => user.Login == txtLogin.Text).FirstOrDefault();
                if (userToSearch!= null)
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
                        RoleId = (RoleUser)int.Parse(con.item)
                    };

                    _userRepository.Add(user);
                    LoadData();
                    MessageBox.Show("Utilisateur inséré avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
          
            
        }
        public void LoadData()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            var data = _userRepository.GetAll();
            _users = new List<dynamic>();
            var listUser = data
              .Select(user => new { UserId = user.UserId, Login = user.Login, Password = user.UserPassword, Role = Enum.GetName(typeof(RoleUser),user.RoleId)}).ToList();
            userDatagridView.DataSource = listUser;
            _users.AddRange(listUser);
        }
        private void RoleCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleCmbx.SelectedItem != null)
            {
                //string selectedValue = RoleCmbx.SelectedItem.ToString();
                //int startIndex = selectedValue.IndexOf("RoleId = ") + "RoleId = ".Length;
                //int endIndex = selectedValue.IndexOf(", RoleName");
                //string roleIdString = selectedValue.Substring(startIndex, endIndex - startIndex).Trim();
                //int.TryParse(roleIdString, out IdRole);
            }
        }

        private void userDatagridView_Click(object sender, EventArgs e)
        {
            if (userDatagridView.CurrentRow.Index != -1)
            {
                UserId = Convert.ToInt32(userDatagridView.CurrentRow.Cells["Column1"].Value);
                dynamic userWithId = _users.FirstOrDefault(user => user.UserId == UserId);
                txtLogin.Text = userWithId.Login;
                txtUserPassword.Text = userWithId.Password;
                RoleCmbx.Text = userWithId.Role;

            }  
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (UserId == 0)
            {
                MessageBox.Show("Veuillez séléctionner un utilisateur.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dynamic userWithId = _users.FirstOrDefault(user => user.UserId == UserId);
                var userToUpdate = _scdContext.Users.Where(user=>user.UserId == UserId).FirstOrDefault();
                DialogResult result = MessageBox.Show("Confirmer vous la modification?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Controle con = (Controle)RoleCmbx.SelectedItem;

                // Check the result
                if (result == DialogResult.Yes)
                {
                    userToUpdate.Login = txtLogin.Text;
                    userToUpdate.UserPassword = txtUserPassword.Text;
                    userToUpdate.RoleId = (RoleUser)int.Parse(con.item);
                    _userRepository.Update(userToUpdate);
                    //Eto ndray petahana
                    MessageBox.Show("Modification réussie");
                    Clear();
                    LoadData();
                }
            }
        }
        private void Clear()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            RoleCmbx.Text = "";
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (UserId == 0)
            {
                MessageBox.Show("Veuillez séléctionner un utilisateur.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dynamic userWithId = _users.FirstOrDefault(user => user.UserId == UserId);
                var userToUpdate = _scdContext.Users.Where(user => user.UserId == UserId).FirstOrDefault();
                DialogResult result = MessageBox.Show("Confirmer vous la suppression", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Check the result
                if (result == DialogResult.Yes)
                {
                    if (userToUpdate.RoleId == ((int)RoleUser.Admin))
                    {
                        MessageBox.Show("Ce compte est un administrateur vous ne pouvez pas le supprimer.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        _scdContext.Users.Remove(userToUpdate);
                        _scdContext.SaveChanges();
                        MessageBox.Show("Opération réussie");
                    }
                    Clear();
                    LoadData();
                }
            }
        }
    }
}
