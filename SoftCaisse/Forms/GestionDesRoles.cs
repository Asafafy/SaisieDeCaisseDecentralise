using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.ScdDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class GestionDesRoles : KryptonForm
    {
        private readonly DataTable _bindingSource;

        private readonly RoleRepository _roleRepository;
        private readonly UserRepository _userRepository;
        private readonly AutorisationRepository _autorisationRepository;

        private readonly SCDContext _scdContext;

        private List<Role> listeRoles;
        private int selectedRoleId;
        private bool groupBox1EstOuvert;
        private Autorisation newAutorisation;
        private bool estNouveau;

        private Autorisation currentAutorisation;





        // ================================================================================================================================
        // ================================================== DEBUT CONSTRUCTEUR ==========================================================
        public GestionDesRoles()
        {
            InitializeComponent();

            _scdContext = new SCDContext();
            _roleRepository = new RoleRepository(_scdContext);
            _userRepository = new UserRepository(_scdContext);
            _autorisationRepository = new AutorisationRepository(_scdContext);

            _bindingSource = new DataTable();

            treeView1.Nodes.OfType<TreeNode>().ToList().ForEach(node => node.Expand());

            groupBox1EstOuvert = true;
            HideGroupBox();

            LoadData();
        }
        // ================================================== FIN CONSTRUCTEUR ==========================================================
        // ==============================================================================================================================





        // ==============================================================================================================================
        // ================================================== DEBUT FONCTIONS ===========================================================
        public void ShowGroupBox()
        {
            if (groupBox1EstOuvert == false)
            {
                int width = Width;
                Width = width + groupBox1.Width + 10;
                btnFermer.Location = new Point(Width - 100, btnFermer.Location.Y);
                groupBox1.Visible = true;
                groupBox1EstOuvert = true;
            }
        }

        public void HideGroupBox()
        {
            if (groupBox1EstOuvert == true)
            {
                int width = Width;
                Width = width - groupBox1.Width - 10;
                btnFermer.Location = new Point(Width - 100, btnFermer.Location.Y);
                groupBox1.Visible = false;
                groupBox1EstOuvert = false;
                groupBox2.Enabled = true;
            }
        }

        public void LoadData()
        {
            _bindingSource.Clear();
            listeRoles = _roleRepository.GetAll();
            if (_bindingSource.Columns.Count < 1)
            {
                _bindingSource.Columns.Add(new DataColumn("Id"));
                _bindingSource.Columns.Add(new DataColumn("Intitule"));
                _bindingSource.Columns.Add(new DataColumn("Nombre d'utilisateurs"));
            }
            List<int> nbUserParRole = _roleRepository.GetUsersNumber();
            int i = 0;
            foreach (var role in listeRoles)
            {
                _bindingSource.Rows.Add(role.IdRole, role.RoleIntitule, nbUserParRole[i]);
                i++;
            }
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nombre d'utilisateurs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        // ================================================== DEBUT FONCTIONS ===========================================================
        // ==============================================================================================================================





        // ===============================================================================================================================
        // ================================================== DEBUT EVENEMENTS ===========================================================
        private void btnFermer_Click(object sender, System.EventArgs e)
        {
            Close();
        }



        private void btnSupp_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Veuillez sélectionner l'utilisateur à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    string selectedRole = dataGridView1.CurrentRow.Cells["Intitule"].Value.ToString();
                    if (selectedRole == "Admin" || selectedRole == "Caissier")
                    {
                        MessageBox.Show("Les rôles Administrateur et Caissier sont protégés et ne peuvent être supprimés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int currentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                        int nbUserDuRole = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Nombre d'utilisateurs"].Value);
                        if (nbUserDuRole > 0)
                        {
                            DialogResult resultSupprUsersToo = MessageBox.Show("Supprimer ce rôle entraînera la suppression de tous les utilisateurs qui lui sont associés.", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (resultSupprUsersToo == DialogResult.Yes)
                            {
                                List<Users> usersDeCeRole = _userRepository.GetAll().Where(u => u.RoleId == currentId).ToList();
                                foreach (Users user in usersDeCeRole)
                                {
                                    _userRepository.Delete(user.UserId);
                                }
                                _roleRepository.Delete(currentId);
                                MessageBox.Show("Opération réussie");
                            }
                            else
                            {
                                return;
                            }
                        }
                        DialogResult result = MessageBox.Show("Confirmer vous la suppression", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            _roleRepository.Delete(currentId);
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

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            ShowGroupBox();
            groupBox2.Enabled = false;

            estNouveau = true;

            newAutorisation = new Autorisation();
            int maxId = _autorisationRepository.GetMaxId();
            newAutorisation.Id = maxId + 1;
            newAutorisation.Autorisations = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            _autorisationRepository.Add(newAutorisation);
            currentAutorisation = newAutorisation;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            selectedRoleId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            currentAutorisation = _autorisationRepository.GetById(selectedRoleId);

            ShowGroupBox();
            groupBox2.Enabled = false;
            txBxIntRole.Text = dataGridView1.CurrentRow.Cells["Intitule"].Value.ToString();
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.DataSource = null;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            int rubriqueAuth = _autorisationRepository.GetRubriqueAuth(currentAutorisation, selectedNode.Name);
            chckBxAuth.Checked = rubriqueAuth == 1 ? true : false;
        }

        private void chckBxAuth_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Veuillez sélectionner d'abord une rubrique.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int indexVal = Convert.ToInt32(selectedNode.Name);
                currentAutorisation.Autorisations[indexVal] = currentAutorisation.Autorisations[indexVal] == 1 ? 0 : 1;
                _autorisationRepository.Update(currentAutorisation);
                currentAutorisation = _autorisationRepository.GetById(selectedRoleId);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Mise à jour Intitule Rôle
            Role roleToUpdate = _roleRepository.GetById(selectedRoleId);
            roleToUpdate.RoleIntitule = txBxIntRole.Text;
            _roleRepository.Update(roleToUpdate);

            HideGroupBox();
            LoadData();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (estNouveau)
            {

            }
            HideGroupBox();
            LoadData();
        }

        // ================================================== DEBUT EVENEMENTS ===========================================================
        // ==============================================================================================================================
    }
}
