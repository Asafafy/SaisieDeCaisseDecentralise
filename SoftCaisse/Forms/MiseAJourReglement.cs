using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class MiseAJourReglement : KryptonForm
    {
        private readonly AppDbContext _context;
        private readonly SCDContext _sCDContext;

        private readonly F_CREGLEMENTRepository _f_CREGLEMENTRepository;
        private readonly IRepository<F_COLLABORATEURRepository> _f_COLLABORATEURRepository;

        List<F_CAISSE> _listeCaisses;
        List<F_COLLABORATEUR> _listeCaissier;
        List<P_REGLEMENT> _listeModeReglement;
        List<F_COMPTEG> _listeCompteGeneral;
        List<P_DEVISE> _listeDevises;
        List<F_JOURNAUX> _listeCodeJournal;

        List<string> _listeCompteGeneralContrepartieToDisplay;

        private readonly string _placeholderLibelle = "Description du règlement";
        private readonly string _placeholderReference = "Référence";
        private readonly string _placeholerMontant = "Montant";
        private readonly string _placeholderCours = "Cours";
        private readonly string _placeholerMontantDevise = "Montant devise";

        private F_CREGLEMENT _f_CREGLEMENTToUpdateGlobal;

        private DateTime _dateReference;



        // ============================================================================================================================
        // ======================================================= CONSTRUCTEUR =======================================================
        public MiseAJourReglement(F_CREGLEMENT f_CREGLEMENTToUpdate)
        {
            InitializeComponent();

            _f_CREGLEMENTToUpdateGlobal = f_CREGLEMENTToUpdate;

            _context = new AppDbContext();
            _sCDContext = new SCDContext();

            _f_CREGLEMENTRepository = new F_CREGLEMENTRepository(_context);

            _dateReference = new DateTime(1753, 1, 1, 0, 0, 0, 0);

            _listeCaisses = _context.F_CAISSE.OrderBy(c => c.CA_No).ToList();
            _listeCaissier = _context.F_COLLABORATEUR.Where(c => c.CO_Caissier == 1).ToList();
            _listeModeReglement = _context.P_REGLEMENT.ToList();
            _listeCompteGeneral = _context.F_COMPTEG.OrderBy(cmptG => cmptG.CG_Num).ToList();
            _listeDevises = _context.P_DEVISE.ToList();
            _listeCodeJournal = _context.F_JOURNAUX.ToList();


            cmbBxCaisse.DataSource = _listeCaisses.Select(c => c.CA_Intitule).ToList();
            cmbBxCaissier.DataSource = _listeCaissier.Select(c => c.CO_Nom).ToList();
            cmbBxModeRegl.DataSource = _listeModeReglement.Select(rgl => rgl.R_Intitule).ToList();
            cmbBxCompteGeneral.DataSource = _listeCompteGeneral.Select(cmptG => cmptG.CG_Num + " - " + cmptG.CG_Intitule).ToList();
            List<string> listeDevisesToDisplay = _listeDevises.Select(d => d.D_Intitule).ToList();
            listeDevisesToDisplay.Insert(0, "Aucune");
            cmbBxDevise.DataSource = listeDevisesToDisplay;
            cmbBxCodeJournal.DataSource = _listeCodeJournal.Select(cj => cj.JO_Num).ToList();
            _listeCompteGeneralContrepartieToDisplay = _listeCompteGeneral.Select(cgContr => cgContr.CG_Num).ToList();
            _listeCompteGeneralContrepartieToDisplay.Insert(0, "Aucun");
            cmbBxContrepartie.DataSource = _listeCompteGeneral.Select(cmptG => cmptG.CG_Num + " - " + cmptG.CG_Intitule).ToList(); // Contrepartie (CompteGeneral en contrepartie)


            // Assigner les mêmes événements aux différents TextBox (Effet placeholder)
            txtBxNPiece.Enter += textBox_Enter;
            txtBxNPiece.Leave += textBox_Leave;
            txtBxLibelle.Enter += textBox_Enter;
            txtBxLibelle.Leave += textBox_Leave;
            txtBxRefer.Enter += textBox_Enter;
            txtBxRefer.Leave += textBox_Leave;
            txtBxMontant.Enter += textBox_Enter;
            txtBxMontant.Leave += textBox_Leave;
            txtBxCours.Enter += textBox_Enter;
            txtBxCours.Leave += textBox_Leave;
            txtBxMontantDevise.Enter += textBox_Enter;
            txtBxMontantDevise.Leave += textBox_Leave;


            // Config dateTimePicker
            dtTmPckrDateImpaye.Format = DateTimePickerFormat.Custom;
            dtTmPckrDateImpaye.CustomFormat = " ";
            dtTmPckrEcheanceContrepartie.Format = DateTimePickerFormat.Custom;
            dtTmPckrEcheanceContrepartie.CustomFormat = " ";


            // Mise en place des valeurs par défauts
            txtBxNPiece.Text = _f_CREGLEMENTToUpdateGlobal.RG_Piece;
            cmbBxCaisse.SelectedIndex = (int)(_f_CREGLEMENTToUpdateGlobal.CA_No - 1);
            F_COLLABORATEUR reglCollab = _context.F_COLLABORATEUR.FirstOrDefault(u => u.CO_No == _f_CREGLEMENTToUpdateGlobal.CO_NoCaissier);
            cmbBxCaissier.SelectedIndex = _listeCaissier.IndexOf(reglCollab);
            dtTmPickerDate.Value = (DateTime)_f_CREGLEMENTToUpdateGlobal.RG_Date;
            txtBxLibelle.Text = _f_CREGLEMENTToUpdateGlobal.RG_Libelle;
            txtBxRefer.Text = _f_CREGLEMENTToUpdateGlobal.RG_Reference;
            cmbBxModeRegl.SelectedIndex = (int)_f_CREGLEMENTToUpdateGlobal.RG_TypeReg;
            F_COMPTEG compteGToSearh = _context.F_COMPTEG.Where(cg => cg.CG_Num == _f_CREGLEMENTToUpdateGlobal.CG_Num).FirstOrDefault();
            cmbBxCompteGeneral.SelectedIndex = _listeCompteGeneral.IndexOf(compteGToSearh);
            txtBxMontant.Text = _f_CREGLEMENTToUpdateGlobal.RG_Montant.ToString();
            cmbBxDevise.SelectedIndex = (int)_f_CREGLEMENTToUpdateGlobal.N_Devise;
            txtBxCours.Text = _f_CREGLEMENTToUpdateGlobal.RG_Cours.ToString();
            txtBxMontantDevise.Text = _f_CREGLEMENTToUpdateGlobal.RG_MontantDev.ToString();
            cmbBxCodeJournal.SelectedItem = _f_CREGLEMENTToUpdateGlobal.JO_Num;
            if (_f_CREGLEMENTToUpdateGlobal.RG_Impaye != _dateReference)
            {
                dtTmPckrDateImpaye.CustomFormat = "dd-MM-yyyy";
                dtTmPckrDateImpaye.Value = (DateTime)_f_CREGLEMENTToUpdateGlobal.RG_Impaye;
            }
            int indexCompteGContre = _listeCompteGeneralContrepartieToDisplay.IndexOf(_f_CREGLEMENTToUpdateGlobal.CG_NumCont);
            if (indexCompteGContre == -1)
            {
                cmbBxContrepartie.SelectedIndex = -1;
            } else
            {
                cmbBxContrepartie.SelectedIndex = indexCompteGContre - 1;
            }
            if (_f_CREGLEMENTToUpdateGlobal.RG_DateEchCont != _dateReference)
            {
                dtTmPckrEcheanceContrepartie.CustomFormat = "dd-MM-yyyy";
                dtTmPckrEcheanceContrepartie.Value = (DateTime)_f_CREGLEMENTToUpdateGlobal.RG_DateEchCont;
            }



            // Initialisation du placeholder pour chaque TextBox
            if (txtBxLibelle.Text == "")
            {
                txtBxLibelle.Text = txtBxLibelle.Text;
                txtBxLibelle.ForeColor = Color.Gray;
            }
            if (txtBxRefer.Text == "")
            {
                txtBxRefer.Text = txtBxRefer.Text;
                txtBxRefer.ForeColor = Color.Gray;
            }
            if (txtBxMontant.Text == "")
            {
                txtBxMontant.Text = txtBxMontant.Text == "" ? _placeholerMontant : txtBxMontant.Text;
                txtBxMontant.ForeColor = Color.Gray;
            }
            if (_f_CREGLEMENTToUpdateGlobal.N_Devise == 0)
            {
                txtBxCours.Enabled = false;
                txtBxCours.Text = _placeholderCours;
                txtBxMontantDevise.Enabled = false;
                txtBxMontantDevise.Text = _placeholerMontantDevise;
            }
            else
            {
                txtBxCours.Enabled = true;
                txtBxMontantDevise.Enabled = true;
            }


            // Disable TextBox Numéro pièce
            txtBxNPiece.Enabled = false;
        }
        // ======================================================= CONSTRUCTEUR =======================================================
        // ============================================================================================================================





        // =============================================================================================================================
        // ========================================================= FONCTIONS =========================================================

        // ========================= fonctions réliées aux placeholder des textBox
        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.Text == GetPlaceholderText(textBox))
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = GetPlaceholderText(textBox);
                textBox.ForeColor = Color.Gray;
            }
        }

        private string GetPlaceholderText(TextBox textBox)
        {
            if (textBox == txtBxLibelle)
                return _placeholderLibelle;
            else if (textBox == txtBxRefer)
                return _placeholderReference;
            else if (textBox == txtBxMontant)
                return _placeholerMontant;
            else if (textBox == txtBxCours)
                return _placeholderCours;
            else if (textBox == txtBxMontantDevise)
                return _placeholerMontantDevise;
            return "";
        }
        // ========================================================= FONCTIONS =========================================================
        // =============================================================================================================================






        // ==============================================================================================================================
        // ========================================================= EVENEMENTS =========================================================
        private void kptnBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show("Voulez vous abandonner les modifications ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                // Ne rien faire
            }
        }



        // ====================================== GESTION DES COMPORTEMENTS DES DEUX DATETIMEPICKERS ====================================== 
        private void dtTmPckrDateImpaye_MouseDown(object sender, MouseEventArgs e)
        {
            dtTmPckrDateImpaye.CustomFormat = "dd-MM-yyyy";
        }

        private void dtTmPckrEcheanceContrepartie_MouseDown(object sender, MouseEventArgs e)
        {
            dtTmPckrEcheanceContrepartie.CustomFormat = "dd-MM-yyyy";
        }
        // ====================================== GESTION DES COMPORTEMENTS DES DEUX DATETIMEPICKERS ======================================





        // ======================================== RESTRICTION SAISIE SUR LES TEXTBOX NUMÉRIQUES =========================================
        private void txtBxMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox.Text.Contains(".")) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void txtBxCours_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox.Text.Contains(".")) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void txtBxMontantDevise_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox.Text.Contains(".")) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }
        // ======================================== RESTRICTION SAISIE SUR LES TEXTBOX NUMÉRIQUES =========================================





        // =============================================== CALCULS DES MONTANTS SELON DEVISE ================================================
        private void cmbBxDevise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxDevise.Text == "Aucune")
            {
                txtBxCours.Enabled = false;
                txtBxMontantDevise.Enabled = false;
            }
            else
            {
                txtBxCours.Enabled = true;
                txtBxMontantDevise.Enabled = true;
            }
            txtBxCours.Text = GetPlaceholderText(txtBxCours);
            txtBxMontantDevise.Text = GetPlaceholderText(txtBxMontantDevise);
        }

        private void txtBxMontant_TextChanged(object sender, EventArgs e)
        {
            if (cmbBxDevise.Text != "Aucune" && txtBxCours.Text != "Cours" && txtBxCours.Text != "" && txtBxMontant.Text != "" && txtBxMontant.Text != "Montant")
            {
                decimal cours = Convert.ToDecimal(txtBxCours.Text);
                decimal montant = Convert.ToDecimal(txtBxMontant.Text);
                txtBxMontantDevise.Text = (montant * cours).ToString();
            }
        }

        private void txtBxCours_TextChanged(object sender, EventArgs e)
        {
            if (cmbBxDevise.Text != "Aucune" && txtBxMontant.Text != "" && txtBxMontant.Text != "Montant" && txtBxCours.Text != "Cours" && txtBxCours.Text != "")
            {
                decimal montant = Convert.ToDecimal(txtBxMontant.Text);
                decimal cours = Convert.ToDecimal(txtBxCours.Text);
                txtBxMontantDevise.Text = (montant * cours).ToString();
            }
            else if (cmbBxDevise.Text != "Aucune" && txtBxMontantDevise.Text != "" && txtBxMontantDevise.Text != "Montant devise" && txtBxCours.Text != "Cours" && txtBxCours.Text != "")
            {
                decimal cours = Convert.ToDecimal(txtBxCours.Text);
                decimal montantDevise = Convert.ToDecimal(txtBxMontantDevise.Text);
                txtBxMontant.Text = (montantDevise / cours).ToString();
            }
            else
            {
                // Ne rien faire
            }
        }

        private void txtBxMontantDevise_TextChanged(object sender, EventArgs e)
        {
            if (cmbBxDevise.Text != "Aucune" && txtBxCours.Text != "Cours" && txtBxCours.Text != "" && txtBxMontantDevise.Text != "" && txtBxMontantDevise.Text != "Montant devise")
            {
                decimal cours = Convert.ToDecimal(txtBxCours.Text);
                decimal montantDevise = Convert.ToDecimal(txtBxMontantDevise.Text);
                txtBxMontant.Text = (montantDevise / cours).ToString();
            }
        }
        // =============================================== CALCULS DES MONTANTS SELON DEVISE ================================================






        // Enregistrement des modifications (Mise à jour)
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Date pas encore spécifié
            if (dtTmPickerDate.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir la date du règlement avant d'enregistrer", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // Montant pas encore spécifié
            if (txtBxMontant.Text == "" || txtBxMontant.Text == "Montant")
            {
                System.Windows.Forms.MessageBox.Show("Le montant du règlement n'est pas encore spécifié", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // Caisse pas encore spécifiée
            if (cmbBxCaisse.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Aucune caisse n'est sélectionnée", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }


            // Caissier pas encore spécifié
            if (cmbBxCaissier.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Aucun caissier n'est sélectionné", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            // Libellé vide
            if (txtBxLibelle.Text == "" || txtBxLibelle.Text == "Description du règlement")
            {
                System.Windows.Forms.MessageBox.Show("Veuillez remplir le libellé", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            F_CREGLEMENT reglToUpdate = _context.F_CREGLEMENT.Where(regl => regl.RG_No == _f_CREGLEMENTToUpdateGlobal.RG_No).FirstOrDefault();
            // Changement des anciens valeurs par les nouveaux valeurs entrées par l'utilisateur
            reglToUpdate.CA_No = cmbBxCaisse.SelectedIndex + 1; // Numéro de la caisse sélectionnée
            reglToUpdate.cbCA_No = cmbBxCaisse.SelectedIndex + 1; // Numéro de la caisse sélectionnée
            F_COLLABORATEUR caissierSelect = _listeCaissier[cmbBxCaissier.SelectedIndex];
            reglToUpdate.CO_NoCaissier = caissierSelect.CO_No; // Numéro du caissier sélectionné
            reglToUpdate.cbCO_NoCaissier = cmbBxCaissier.SelectedIndex + 1; // Numéro du caissier sélectionné
            reglToUpdate.RG_Libelle = txtBxLibelle.Text; // Libellé
            reglToUpdate.RG_Reference = txtBxRefer.Text == "Référence" ? "" : txtBxRefer.Text; // Référence
            reglToUpdate.RG_TypeReg = 0; // (Type du règlement (0 = règlement))
            F_COMPTEG cg = _listeCompteGeneral[cmbBxCompteGeneral.SelectedIndex];
            reglToUpdate.CG_Num = cg.CG_Num; // Compte général
            reglToUpdate.RG_Montant = Convert.ToDecimal(txtBxMontant.Text); // Montant du règlement
            //txtBxCours
            reglToUpdate.RG_Cours = txtBxCours.Text == "Cours" ? 0 : Convert.ToDecimal(txtBxCours.Text); // Cours d'échange selon devise
            reglToUpdate.N_Devise = (short)cmbBxDevise.SelectedIndex; // Devise
            reglToUpdate.RG_MontantDev = txtBxMontantDevise.Text == "Montant devise" ? 0 : Convert.ToDecimal(txtBxMontantDevise.Text); // Montant du règlement avec devise
            reglToUpdate.JO_Num = cmbBxCodeJournal.Text; // Code journal (CAIS, etc.)
            reglToUpdate.RG_Impaye = dtTmPckrDateImpaye.Text == "" ? new DateTime(1753, 1, 1, 0, 0, 0, 0) : dtTmPckrDateImpaye.Value; // Date impayé
            string cg_NumCont = cmbBxContrepartie.SelectedIndex == -1 ? null : _listeCompteGeneralContrepartieToDisplay[cmbBxContrepartie.SelectedIndex + 1];
            reglToUpdate.CG_NumCont = cg_NumCont == "Aucun" ? null : cg_NumCont; // CompteGénéral contrepatie
            reglToUpdate.RG_DateEchCont = dtTmPckrEcheanceContrepartie.Text == "" ? new DateTime(1753, 1, 1, 0, 0, 0, 0) : dtTmPckrEcheanceContrepartie.Value; // Date de l'échéance contrepartie

            _context.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Mise à jour effectuée avec succès!", "Opération réussie", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);

            Close();
        }



    }
}
