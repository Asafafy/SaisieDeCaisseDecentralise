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
        private readonly RoleAutorisationRepository _roleAutorisationRepository;

        private readonly SCDContext _scdContext;

        private List<Role> listeRoles;
        private int selectedRoleId;
        private bool groupBox1EstOuvert;
        private RoleAutorisation newAutorisation;
        private bool estNouveau;

        private Role currentRole;





        // ================================================================================================================================
        // ================================================== DEBUT CONSTRUCTEUR ==========================================================
        public GestionDesRoles()
        {
            InitializeComponent();

            _scdContext = new SCDContext();
            _roleRepository = new RoleRepository(_scdContext);
            _userRepository = new UserRepository(_scdContext);
            _roleAutorisationRepository = new RoleAutorisationRepository(_scdContext);

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
                btnFermer.Location = new System.Drawing.Point(Width - 100, btnFermer.Location.Y);
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
                btnFermer.Location = new System.Drawing.Point(Width - 100, btnFermer.Location.Y);
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

        public void SetAuthAndAllOthersAuth(RoleAutorisation autorisation, int roleId)
        {
            Rubrique rubrique = _scdContext.Rubrique.Where(rub => rub.Id == autorisation.IdRubrique).FirstOrDefault();
            List<int> listRubrAModif = new List<int>();
            listRubrAModif.Add(rubrique.Id);
            List<int> idRubriquesFils = _scdContext.Rubrique.Where(rub => rub.IdParent == rubrique.Id).Select(rub => rub.Id).ToList();
            listRubrAModif.AddRange(idRubriquesFils);
            foreach (int rubId in idRubriquesFils)
            {
                List<int> rubriqueFils2 = _scdContext.Rubrique.Where(rubFils2 => rubFils2.IdParent == rubId).Select(rub => rub.Id).ToList();
                if (rubriqueFils2.Count > 0)
                {
                    idRubriquesFils.AddRange(rubriqueFils2);
                }
            }
            int valToSet = autorisation.EstAutorise == 1 ? 0 : 1;
            // Mise à jour des données dans la base
            if (estNouveau == true)
            {
                foreach (int rubId in listRubrAModif)
                {
                    RoleAutorisation roleToUpdate = _scdContext.RoleAutorisation
                        .Where(roleAuth => roleAuth.IdRole == null && roleAuth.IdRubrique == rubId)
                        .FirstOrDefault();
                    roleToUpdate.EstAutorise = valToSet;
                }
            }
            else
            {
                foreach (int rubId in listRubrAModif)
                {
                    RoleAutorisation roleToUpdate = _scdContext.RoleAutorisation
                        .Where(roleAuth => roleAuth.IdRole == roleId && roleAuth.IdRubrique == rubId)
                        .FirstOrDefault();
                    roleToUpdate.EstAutorise = valToSet;
                }
            }
            _scdContext.SaveChanges();
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
                            LoadData();
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

            // Création des nouvelles autorisations
            int i = 1;
            int rubriqueLastID = _scdContext.Rubrique.Count();
            while (i <= rubriqueLastID)
            {
                newAutorisation = new RoleAutorisation();
                newAutorisation.EstAutorise = 1;
                newAutorisation.IdRubrique = i;
                _roleAutorisationRepository.Add(newAutorisation);
                i++;
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Veuillez sélectionner l'utilisateur à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dataGridView1.CurrentRow.Index != -1)
            {
                string selectedRole = dataGridView1.CurrentRow.Cells["Intitule"].Value.ToString();
                if (selectedRole == "Admin" || selectedRole == "Caissier")
                {
                    MessageBox.Show("Les rôles Administrateur et Caissier sont protégés et ne peuvent être modifiés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    selectedRoleId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                    ShowGroupBox();
                    groupBox2.Enabled = false;
                    txBxIntRole.Text = dataGridView1.CurrentRow.Cells["Intitule"].Value.ToString();
                    dataGridView1.BackgroundColor = Color.WhiteSmoke;
                    dataGridView1.DataSource = null;
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Text == "Fichier") // Rubrique "Fichier" toujours actif
                chckBxAuth.Enabled = false;
            else
                chckBxAuth.Enabled = true;
            int rubriqueNo = _scdContext.Rubrique.Where(rub => rub.Nom == selectedNode.Text).Select(rub => rub.Id).FirstOrDefault();
            RoleAutorisation rubriqueAuth;
            if (estNouveau == true)
            {
                rubriqueAuth = _scdContext.RoleAutorisation.Where(rlAuth => rlAuth.IdRubrique == rubriqueNo && rlAuth.IdRole == null).FirstOrDefault();
            }
            else
            {
                rubriqueAuth = _scdContext.RoleAutorisation.Where(rlAuth => rlAuth.IdRubrique == rubriqueNo && rlAuth.IdRole == selectedRoleId).FirstOrDefault();
            }
            chckBxAuth.Checked = rubriqueAuth.EstAutorise == 1 ? true : false;
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
                int rubriqueNo = _scdContext.Rubrique.Where(rub => rub.Nom == selectedNode.Text).Select(rub => rub.Id).FirstOrDefault();
                RoleAutorisation rubriqueAuth;
                if (estNouveau == true)
                {
                    rubriqueAuth = _scdContext.RoleAutorisation.Where(rlAuth => rlAuth.IdRubrique == rubriqueNo && rlAuth.IdRole == null).FirstOrDefault();
                }
                else
                {
                    rubriqueAuth = _scdContext.RoleAutorisation.Where(rlAuth => rlAuth.IdRubrique == rubriqueNo && rlAuth.IdRole == selectedRoleId).FirstOrDefault();
                }
                SetAuthAndAllOthersAuth(rubriqueAuth, selectedRoleId);
                _roleAutorisationRepository.Update(rubriqueAuth);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txBxIntRole.Text != "")
            {
                if (estNouveau == true)
                {
                    // Création nouveau rôle
                    Role nouveauRole = new Role
                    {
                        RoleIntitule = txBxIntRole.Text
                    };
                    _roleRepository.Add(nouveauRole);

                    // Mise à jour de toutes les autorisations liées au nouveau rôle
                    List<RoleAutorisation> listeAutToUpdate = _scdContext.RoleAutorisation.Where(roleAuth => roleAuth.IdRole == null).ToList();
                    Role roleActu = _scdContext.Role.Where(r => r.RoleIntitule == txBxIntRole.Text).FirstOrDefault();
                    foreach (RoleAutorisation roleAuth in listeAutToUpdate)
                    {
                        roleAuth.IdRole = roleActu.IdRole;
                    }
                    HideGroupBox();
                    LoadData();
                }
                else
                {
                    // Mise à jour Intitule Rôle
                    Role roleToUpdate = _roleRepository.GetById(selectedRoleId);

                    roleToUpdate.RoleIntitule = txBxIntRole.Text;
                    _roleRepository.Update(roleToUpdate);
                    HideGroupBox();
                    LoadData();
                }
            }
            else
                MessageBox.Show("Complétez d'abord l'intitule du rôle", "Incomplet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (estNouveau)
            {
                _roleRepository.Delete(selectedRoleId);
                List<RoleAutorisation> listeAutToDelete = _scdContext.RoleAutorisation.Where(roleAuth => roleAuth.IdRole == null).ToList();
                foreach (RoleAutorisation autorisation in listeAutToDelete)
                {
                    _roleAutorisationRepository.Delete(autorisation.Id);
                }
            }
            HideGroupBox();
            LoadData();
        }

        // ================================================== DEBUT EVENEMENTS ===========================================================
        // ==============================================================================================================================
    }
}
