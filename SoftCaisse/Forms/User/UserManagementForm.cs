using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Migrations;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftCaisse.Forms.User
{
    public partial class UserManagementForm : KryptonForm
    {
        private readonly SCDContext _scdContext;
        private readonly UserRepository _userRepository;
        private readonly RoleRepository _roleRepository;
        private List<dynamic> _users;
        private int IdRole;
        private int UserId;
        public UserManagementForm()
        {
            InitializeComponent();
            _scdContext = new SCDContext();
            _userRepository = new UserRepository(_scdContext);
            _roleRepository = new RoleRepository(_scdContext);
            RoleCmbx.DisplayMember = "RoleName";
            RoleCmbx.ValueMember = "RoleId";

            var data1 = _roleRepository.GetAll();
            var data = _userRepository.GetAll();
            LoadData();
            var listRole = data1.Select(role => new { RoleId = role.RoleId, RoleName = role.RoleName }).ToArray();
            //var listUser = data
            //    .Select(user => new { Login = user.Login, Password = user.UserPassword, Role = user.Role.RoleName}).ToList();
            //userDatagridView.DataSource = listUser;
            RoleCmbx.Items.Clear();
            RoleCmbx.Items.AddRange(listRole);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Models.User user = new Models.User
            {
                Login = txtLogin.Text,
                UserPassword = txtUserPassword.Text,
                RoleId = IdRole
            };
            
            _userRepository.Add(user);
            LoadData();
            MessageBox.Show("Utilisateur inséré avec succès.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        public void LoadData()
        {
            txtLogin.Text = "";
            txtUserPassword.Text = "";
            var data = _userRepository.GetAll();
            _users = new List<dynamic>();
            var listUser = data
              .Select(user => new { UserId = user.UserId, Login = user.Login, Password = user.UserPassword, Role = user.Role.RoleName }).ToList();
            userDatagridView.DataSource = listUser;
            _users.AddRange(listUser);
        }
        private void RoleCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleCmbx.SelectedItem != null)
            {
                string selectedValue = RoleCmbx.SelectedItem.ToString();
                // Split the selected text to extract RoleId
                int startIndex = selectedValue.IndexOf("RoleId = ") + "RoleId = ".Length;
                int endIndex = selectedValue.IndexOf(", RoleName");
                string roleIdString = selectedValue.Substring(startIndex, endIndex - startIndex).Trim();
                int.TryParse(roleIdString, out IdRole);
            }
        }

        private void userDatagridView_Click(object sender, EventArgs e)
        {
            if (userDatagridView.CurrentRow.Index != -1)
            {
                UserId = Convert.ToInt32(userDatagridView.CurrentRow.Cells["Column1"].Value);
              
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
                txtLogin.Text = userWithId.Login;
                txtUserPassword.Text = userWithId.Password;
                RoleCmbx.Text = userWithId.Role;
            }
            
        }
    }
}
