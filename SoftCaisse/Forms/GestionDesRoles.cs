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
        // ====================================================================================
        // DEBUT DECLARATION DES VARIABLES ====================================================
        // ====================================================================================
        private readonly DataTable _bindingSource;

        private readonly RoleRepository _roleRepository;
        private readonly UserRepository _userRepository;
        private readonly RoleAutorisationRepository _roleAutorisationRepository;
        private readonly RubriqueRepository _rubriqueRepository;

        private readonly SCDContext _scdContext;

        List<int> valeursEstAutoriseInit = new List<int>();

        private List<Role> listeRoles;
        private int selectedRoleId;
        private bool groupBox1EstOuvert;
        private bool estNouveau;
        private RoleAutorisation newAutorisation;
        // ====================================================================================
        // FIN DECLARATION DES VARIABLES ======================================================
        // ====================================================================================










        // ====================================================================================
        // DEBUT CONSTRUCTEUR =================================================================
        // ====================================================================================
        public GestionDesRoles()
        {
            InitializeComponent();

            _scdContext = new SCDContext();

            _roleRepository = new RoleRepository(_scdContext);
            _userRepository = new UserRepository(_scdContext);
            _roleAutorisationRepository = new RoleAutorisationRepository();
            _rubriqueRepository = new RubriqueRepository();

            _bindingSource = new DataTable();

            treeView1.Nodes.OfType<TreeNode>().ToList().ForEach(node => node.Expand());

            groupBox1EstOuvert = true;
            HideGroupBox();

            LoadData();
        }
        // ====================================================================================
        // FIN CONSTRUCTEUR ===================================================================
        // ====================================================================================










        // ====================================================================================
        // DEBUT FONCTIONS ====================================================================
        // ====================================================================================
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



        public async void LoadData()
        {
            _bindingSource.Clear()
                ;
            listeRoles = await _roleRepository.GetAll();

            if (_bindingSource.Columns.Count < 1)
            {
                _bindingSource.Columns.Add(new DataColumn("Id"));
                _bindingSource.Columns.Add(new DataColumn("Intitule"));
                _bindingSource.Columns.Add(new DataColumn("Nombre d'utilisateurs"));
            }

            List<int> nbUserParRole = await _roleRepository.GetUsersNumber();

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



        public async void SetAuthAndAllOthersAuth(RoleAutorisation autorisation, int roleId)
        {
            Rubrique rubrique = await _rubriqueRepository.GetRubrique_by_IdRubrique(autorisation.IdRubrique);
            List<int> listRubrAModif = new List<int> ();
            listRubrAModif.Add(rubrique.Id);
            List<Rubrique> rubriquesFils = await _rubriqueRepository.GetRubriqueFils_by_IdParent(rubrique.Id);
            List<int> idRubriquesFils = rubriquesFils.Select(rub => rub.Id).ToList();
            foreach (int rubId in idRubriquesFils)
                listRubrAModif.Add(rubId);
            foreach (int rubId in idRubriquesFils)
            {
                List<Rubrique> rubriquesFils2 = await _rubriqueRepository.GetRubriqueFils_by_IdParent(rubId);
                List<int> rubriqueFils2 = rubriquesFils2.Select(rub => rub.Id).ToList();
                if (rubriqueFils2.Count > 0)
                {
                    foreach (int rubId2 in rubriqueFils2)
                        listRubrAModif.Add(rubId2);
                }
            }
            int valToSet = autorisation.EstAutorise == 1 ? 0 : 1;

            // Mise à jour des données dans la base
            if (estNouveau == true)
            {
                foreach (int rubId in listRubrAModif)
                {
                    RoleAutorisation roleToUpdate = await _roleAutorisationRepository.Get_RoleAutorisation_By_IdRubrique_And_IdRole(rubId, null);
                    roleToUpdate.EstAutorise = valToSet;
                    _roleAutorisationRepository.Update(roleToUpdate);
                }
            }
            else
            {
                foreach (int rubId in listRubrAModif)
                {
                    RoleAutorisation roleToUpdate = await _roleAutorisationRepository.Get_RoleAutorisation_By_IdRubrique_And_IdRole(rubId, roleId);
                    roleToUpdate.EstAutorise = valToSet;
                    _roleAutorisationRepository.Update(roleToUpdate);
                }
            }
        }
        // ====================================================================================
        // FIN FONCTIONS ======================================================================
        // ====================================================================================










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





        private async void btnNouveau_Click(object sender, EventArgs e)
        {
            ShowGroupBox();

            groupBox2.Enabled = false;
            txBxIntRole.Text = "";

            estNouveau = true;

            // Création des nouvelles autorisations
            int i = 1;
            int nombreRubrique = await _rubriqueRepository.CountRubriques();
            while (i <= nombreRubrique)
            {
                newAutorisation = new RoleAutorisation();
                newAutorisation.EstAutorise = 1;
                newAutorisation.IdRubrique = i;
                _roleAutorisationRepository.Add(newAutorisation);
                i++;
            }
        }





        private async void btnModif_Click(object sender, EventArgs e)
        {
            estNouveau = false;
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
            List<RoleAutorisation> listeRolesAutorisation = await _roleAutorisationRepository.Get_List_RoleAutorisation_By_IdRole(selectedRoleId);
            valeursEstAutoriseInit = listeRolesAutorisation.Select(ra => ra.EstAutorise).ToList();
        }





        private async void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Text == "Fichier") // Rubrique "Fichier" toujours actif
                chckBxAuth.Enabled = false;
            else
                chckBxAuth.Enabled = true;

            Rubrique rubriqueSelected = await _rubriqueRepository.GetRubrique_by_Nom(selectedNode.Text);
            int rubriqueNo = rubriqueSelected.Id;
            RoleAutorisation rubriqueAuth;
            if (estNouveau == true)
            {
                rubriqueAuth = await _roleAutorisationRepository.Get_RoleAutorisation_By_IdRubrique_And_IdRole(rubriqueNo, null);
            }
            else
            {
                rubriqueAuth = await _roleAutorisationRepository.Get_RoleAutorisation_By_IdRubrique_And_IdRole(rubriqueNo, selectedRoleId);
            }
            chckBxAuth.Checked = rubriqueAuth.EstAutorise == 1 ? true : false;
        }





        private async void chckBxAuth_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Veuillez sélectionner d'abord une rubrique.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Rubrique rubriqueSelected = await _rubriqueRepository.GetRubrique_by_Nom(selectedNode.Text);
                int rubriqueNo = rubriqueSelected.Id;
                RoleAutorisation rubriqueAuth;
                if (estNouveau == true)
                {
                    rubriqueAuth = await _roleAutorisationRepository.Get_RoleAutorisation_By_IdRubrique_And_IdRole(rubriqueNo, null);
                }
                else
                {
                    rubriqueAuth = await _roleAutorisationRepository.Get_RoleAutorisation_By_IdRubrique_And_IdRole(rubriqueNo, selectedRoleId);
                }
                SetAuthAndAllOthersAuth(rubriqueAuth, selectedRoleId);
            }
        }





        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (txBxIntRole.Text != "")
            {
                if (estNouveau == true)
                {
                    string nomRole = txBxIntRole.Text;
                    _roleRepository.Add(nomRole);
                    Role roleConcerne = await _roleRepository.GetRoleBy_RoleIntitule(nomRole);

                    // Mise à jour des autorisations liés au rôle
                    List<RoleAutorisation> listeAutToUpdate = await _roleAutorisationRepository.Get_List_RoleAutorisation_By_IdRole(null);
                    foreach (RoleAutorisation roleAuth in listeAutToUpdate)
                    {
                        roleAuth.IdRole = roleConcerne.IdRole;
                        _roleAutorisationRepository.Update(roleAuth);
                    }
                }
                else
                {
                    // Mise à jour Intitule Rôle
                    Role roleToUpdate = await _roleRepository.GetById(selectedRoleId);

                    roleToUpdate.RoleIntitule = txBxIntRole.Text;
                    _roleRepository.Update(roleToUpdate);
                }
                valeursEstAutoriseInit.Clear();
                HideGroupBox();
                LoadData();
            }
            else
                MessageBox.Show("Complétez d'abord l'intitule du rôle", "Incomplet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }





        private async void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (estNouveau)
            {
                _roleRepository.Delete(selectedRoleId);
                List<RoleAutorisation> listeAutToDelete = await _roleAutorisationRepository.Get_List_RoleAutorisation_By_IdRole(null);
                foreach (RoleAutorisation autorisation in listeAutToDelete)
                {
                    _roleAutorisationRepository.Delete(autorisation.Id);
                }
            }
            else
            {
                List<RoleAutorisation> listeRoleAuthToReset = await _roleAutorisationRepository.Get_List_RoleAutorisation_By_IdRole(selectedRoleId);
                int nombreRoleAuth = listeRoleAuthToReset.Count();
                int i = 0;
                while (i < nombreRoleAuth)
                {
                    listeRoleAuthToReset[i].EstAutorise = valeursEstAutoriseInit[i];
                    _roleAutorisationRepository.Update(listeRoleAuthToReset[i]);
                    i++;
                }
            }
            valeursEstAutoriseInit.Clear();
            HideGroupBox();
            LoadData();
        }

        // ================================================== DEBUT EVENEMENTS ===========================================================
        // ==============================================================================================================================
    }
}
