using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.ScdDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class GestionDesRoles : KryptonForm
    {
        private readonly DataTable _bindingSource;
        private readonly RoleRepository _roleRepository;
        private readonly UserRepository _userRepository;
        private readonly SCDContext _scdContext;
        private List<Role> listeRoles;



        // ================================================================================================================================
        // ================================================== DEBUT CONSTRUCTEUR ==========================================================
        public GestionDesRoles()
        {
            InitializeComponent();
            _scdContext = new SCDContext();
            _roleRepository = new RoleRepository(_scdContext);
            _userRepository = new UserRepository(_scdContext);

            _bindingSource = new DataTable();

            LoadData();

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Fichier");
            treeView1.Nodes[0].Nodes.Add("Paramètre de base");
            treeView1.Nodes[0].Nodes.Add("Paramètres de société");
            treeView1.Nodes[0].Nodes.Add("Autorisation d'accès");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Utilisateurs");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Gestion des rôles");
            treeView1.Nodes[0].Nodes.Add("Mise en page");

            treeView1.Nodes.Add("Structure");
            treeView1.Nodes[1].Nodes.Add("Article");
            treeView1.Nodes[1].Nodes.Add("Caisses");
            treeView1.Nodes[1].Nodes.Add("Clients");
            treeView1.Nodes[1].Nodes.Add("Collaborateurs");
            treeView1.Nodes[1].Nodes.Add("Famille");

            treeView1.Nodes.Add("Traitement");
            treeView1.Nodes[2].Nodes.Add("Ouverture de caisse");
            treeView1.Nodes[2].Nodes.Add("Ventes comptoir");
            treeView1.Nodes[2].Nodes.Add("Documents des ventes");
            treeView1.Nodes[2].Nodes.Add("Mouvements de caisse");
            treeView1.Nodes[2].Nodes.Add("Fermeture de caisse");
            treeView1.Nodes[2].Nodes.Add("Gestion des règlements");
            treeView1.Nodes[2].Nodes.Add("Gestion des comptes");
            treeView1.Nodes[2].Nodes.Add("Contrôle de caisse");
            treeView1.Nodes[2].Nodes.Add("Clôture de caisse");

            treeView1.Nodes.Add("Etat");
            treeView1.Nodes[3].Nodes.Add("Statistiques de caisses");
            treeView1.Nodes[3].Nodes.Add("Statistiques articles");
            treeView1.Nodes[3].Nodes.Add("Statistiques clients");
            treeView1.Nodes[3].Nodes.Add("Journaux de vente");
            treeView1.Nodes[3].Nodes.Add("Inventaire");
            treeView1.EndUpdate();

        }
        // ================================================== FIN CONSTRUCTEUR ==========================================================
        // ==============================================================================================================================





        // ==============================================================================================================================
        // ================================================== DEBUT FONCTIONS ===========================================================
        public void LoadData()
        {
            listeRoles = _roleRepository.GetAll();
            _bindingSource.Columns.Add(new DataColumn("Id"));
            _bindingSource.Columns.Add(new DataColumn("Intitule"));
            _bindingSource.Columns.Add(new DataColumn("Nombre d'utilisateurs"));
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

        }

        // ================================================== DEBUT EVENEMENTS ===========================================================
        // ==============================================================================================================================

    }
}
