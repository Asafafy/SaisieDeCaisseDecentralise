using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms.CollaboDetail
{
    public partial class CollaboDetailForm : KryptonForm
    {
        // ====================================================================================================
        // DEBUT DECLARATION DES VARIABLES ====================================================================
        // ====================================================================================================
        private readonly AppDbContext _context;
        private readonly SCDContext _sCDContext;

        private readonly F_COLLABORATEURRepository _f_COLLABORATEURRepository;

        private bool isUpdate = false;
        private int idCollabo;
        private Users user;
        // ====================================================================================================
        // FIN DECLARATION DES VARIABLES ======================================================================
        // ====================================================================================================










        // ====================================================================================================
        // DEBUT CONSTRUCTEUR =================================================================================
        // ====================================================================================================
        public CollaboDetailForm(int collaboId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _sCDContext = new SCDContext();

            _f_COLLABORATEURRepository = new F_COLLABORATEURRepository(_context);

            user = new Users();
            if (collaboId != 0)
            {
                F_COLLABORATEUR collabo = _f_COLLABORATEURRepository.GetBy_CO_No(collaboId);

                txtCollaboNom.Text = collabo.CO_Nom;
                txtCollaboPrenom.Text = collabo.CO_Prenom;
                txtAdresse.Text = collabo.CO_Adresse;
                txtPostal.Text = collabo.CO_CodePostal;
                txtVille.Text = collabo.CO_Ville;
                txtTelephone.Text = collabo.CO_Telephone;
                txtTelecopie.Text = collabo.CO_Telecopie;
                txtFonction.Text = collabo.CO_Fonction;
                txtSkype.Text = collabo.CO_Skype;
                txtComplement.Text = collabo.CO_Complement;
                txtPays.Text = collabo.CO_Pays;
                txtMatricule.Text = collabo.CO_Matricule;
                txtPortable.Text = collabo.CO_Matricule;
                txtService.Text = collabo.CO_Service;
                isUpdate = true;
                idCollabo = collaboId;
            }
        }
        // ====================================================================================================
        // FIN CONSTRUCTEUR ===================================================================================
        // ====================================================================================================










        // ====================================================================================================
        // DEBUT EVENEMENTS ===================================================================================
        // ====================================================================================================
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            F_COLLABORATEUR cOLLABORATEUR = null;
            if (!isUpdate)
            {
                cOLLABORATEUR = new F_COLLABORATEUR()
                {
                    CO_Nom = txtCollaboNom.Text,
                    CO_Prenom = txtCollaboPrenom.Text,
                    CO_Adresse = txtAdresse.Text,
                    CO_CodePostal = txtPostal.Text,
                    CO_Ville = txtVille.Text,
                    CO_Telephone = txtTelephone.Text,
                    CO_EMail = txtTelecopie.Text,
                    CO_Fonction = txtFonction.Text,
                    CO_Skype = txtSkype.Text,
                    CO_Complement = txtComplement.Text,
                    CO_Pays = txtPays.Text,
                    CO_Matricule = txtMatricule.Text,
                    CO_TelPortable = txtPortable.Text,
                    CO_Service = txtService.Text
                };
                _context.F_COLLABORATEUR.Add(cOLLABORATEUR);
            }
            else
            {
                cOLLABORATEUR = _context.F_COLLABORATEUR.FirstOrDefault(u => u.CO_No == idCollabo);
                cOLLABORATEUR.CO_Nom = txtCollaboNom.Text;
                cOLLABORATEUR.CO_Prenom = txtCollaboPrenom.Text;
                cOLLABORATEUR.CO_Adresse = txtAdresse.Text;
                cOLLABORATEUR.CO_CodePostal = txtPostal.Text;
                cOLLABORATEUR.CO_Ville = txtVille.Text;
                cOLLABORATEUR.CO_Telephone = txtTelephone.Text;
                cOLLABORATEUR.CO_EMail = txtTelecopie.Text;
                cOLLABORATEUR.CO_Fonction = txtFonction.Text;
                cOLLABORATEUR.CO_Skype = txtSkype.Text;
                cOLLABORATEUR.CO_Complement = txtComplement.Text;
                cOLLABORATEUR.CO_Pays = txtPays.Text;
                cOLLABORATEUR.CO_Matricule = txtMatricule.Text;
                cOLLABORATEUR.CO_TelPortable = txtPortable.Text;
                cOLLABORATEUR.CO_Service = txtService.Text;
            }
            _context.SaveChanges();
            Collaborateur existCollab = (from c in _sCDContext.Collaborateur
                                         where c.Nom_Collab == txtCollaboNom.Text && c.Prenoms_Collab == txtCollaboPrenom.Text
                                         select c).FirstOrDefault();
            if (existCollab != null)
            {
                existCollab.UserId = user.UserId;
            }
            else
            {
                _sCDContext.Collaborateur.Add(new Collaborateur()
                {
                    Nom_Collab = txtCollaboNom.Text,
                    Prenoms_Collab = txtCollaboPrenom.Text,
                    UserId = user.UserId
                });

            }
            _sCDContext.SaveChanges();
            MessageBox.Show("Mis à jour avec succes", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void tabPage2_Click(object sender, EventArgs e)
        {

        }





        private void CollaboDetailForm_Load(object sender, EventArgs e)
        {
            List<string> lUser = new List<string>();
            lUser = (from u in _sCDContext.Users
                     select u.Login).ToList();
            try
            {
                cUser.DataSource = lUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Ërreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






        private void cUser_SelectedValueChanged(object sender, EventArgs e)
        {
            user = getUser();
        }
        private Users getUser()
        {
            return (from u in _sCDContext.Users where u.Login == cUser.Text select u).FirstOrDefault();
        }
        // ====================================================================================================
        // DEBUT EVENEMENTS ===================================================================================
        // ====================================================================================================

    }
}
