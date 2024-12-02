using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class NouveauReglement : KryptonForm
    {
        private readonly AppDbContext _context;
        private readonly SCDContext _sCDContext;

        private readonly IRepository<F_CREGLEMENT> _f_CREGLEMENTRepository;

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

        private readonly string _cT_NumPayeur;





        // ======================================================================================================================================
        // ========================================================= DEBUT CONSTRUCTEUR =========================================================
        public NouveauReglement(string cT_NumPayeur)
        {
            InitializeComponent();

            _context = new AppDbContext();
            _sCDContext = new SCDContext();

            _f_CREGLEMENTRepository = new F_CREGLEMENTRepository(_context);

            _cT_NumPayeur = cT_NumPayeur;

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

            // Initialisation du placeholder pour chaque TextBox
            txtBxLibelle.Text = _placeholderLibelle;
            txtBxRefer.Text = _placeholderReference;
            txtBxMontant.Text = _placeholerMontant;
            txtBxCours.Text = _placeholderCours;
            txtBxMontantDevise.Text = _placeholerMontantDevise;
            txtBxNPiece.ForeColor = Color.Gray;
            txtBxLibelle.ForeColor = Color.Gray;
            txtBxRefer.ForeColor = Color.Gray;
            txtBxMontant.ForeColor = Color.Gray;
            txtBxCours.ForeColor = Color.Gray;
            txtBxMontantDevise.ForeColor = Color.Gray;

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
            P_COLREGLEMENT p_COLREGLEMENT = _context.P_COLREGLEMENT.FirstOrDefault();
            txtBxNPiece.Text = p_COLREGLEMENT.CR_Numero01;
            dtTmPckrEcheanceContrepartie.Text = "";
            dtTmPckrDateImpaye.Text = "";
            cmbBxCaisse.SelectedIndex = 0;
            cmbBxCaissier.SelectedIndex = 0;
            cmbBxModeRegl.SelectedIndex = 0; // Mode de règlement
            cmbBxCompteGeneral.SelectedIndex = 65; // Collectif client (4110000)
            cmbBxDevise.SelectedIndex = 0;
            cmbBxCodeJournal.SelectedIndex = 0;
            cmbBxContrepartie.SelectedIndex = -1;

            // Disable TextBox
            txtBxNPiece.Enabled = false;
            txtBxCours.Enabled = false;
            txtBxMontantDevise.Enabled = false;
        }
        // ========================================================= FIN CONSTRUCTEUR =========================================================
        // ====================================================================================================================================




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
        private void kptnBtn_Click(object sender, System.EventArgs e)
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


        // Réinitialisation de tous les champs
        private void kryptonButton2_Click(object sender, System.EventArgs e)
        {
            cmbBxCaisse.SelectedIndex = 0; // Caisses
            cmbBxCaissier.SelectedIndex = 0; // Caissiers
            cmbBxModeRegl.SelectedIndex = 0; // Mode de règlement
            cmbBxCompteGeneral.SelectedIndex = 65; // Collectif client (4110000)
            cmbBxDevise.SelectedIndex = 0; // Devise
            cmbBxCodeJournal.SelectedIndex = 0; // Code journal
            cmbBxContrepartie.SelectedIndex = -1; // Contrepartie (CompteGeneral en contrepartie)
            txtBxLibelle.Text = "";
            txtBxRefer.Text = "";
            txtBxMontant.Text = "";
            txtBxCours.Text = "";
            txtBxMontantDevise.Text = "";
            dtTmPckrDateImpaye.Text = "";
        }


        // Enregistrement du règlement saisi par l'utilisateur
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

            // Création objet à enregistrer dans la base
            F_CREGLEMENT newF_CREGLEMENT = new F_CREGLEMENT();
            newF_CREGLEMENT.RG_No = _context.F_CREGLEMENT.Max(rg => rg.RG_No) + 1; // Numéro RG_Piece (Première colonne)
            newF_CREGLEMENT.CT_NumPayeur = _cT_NumPayeur; // Client payeur
            newF_CREGLEMENT.RG_Date = dtTmPickerDate.Value; // Date de la création
            newF_CREGLEMENT.RG_Reference = txtBxRefer.Text == "Référence" ? "" : txtBxRefer.Text; // Référence
            newF_CREGLEMENT.RG_Libelle = txtBxLibelle.Text; // Libellé
            newF_CREGLEMENT.RG_Montant = Convert.ToDecimal(txtBxMontant.Text); // Montant du règlement
            newF_CREGLEMENT.RG_MontantDev = txtBxMontantDevise.Text == "Montant devise" ? 0 : Convert.ToDecimal(txtBxMontantDevise.Text); // Montant du règlement avec devise
            newF_CREGLEMENT.N_Reglement = (short)(cmbBxModeRegl.SelectedIndex + 1); // Mode de règlement
            newF_CREGLEMENT.RG_Impute = 0; // 1 si imputé sinon 0
            newF_CREGLEMENT.RG_Compta = 0; // Non comptabilisé
            newF_CREGLEMENT.EC_No = 0;
            newF_CREGLEMENT.RG_Type = 0; // Type du client (0: client, 1: fournisseur, etc.)
            newF_CREGLEMENT.RG_Cours = txtBxCours.Text == "Cours" ? 0 : Convert.ToDecimal(txtBxCours.Text); // Cours d'échange selon devise
            newF_CREGLEMENT.N_Devise = (short)cmbBxDevise.SelectedIndex; // Devise
            newF_CREGLEMENT.JO_Num = cmbBxCodeJournal.Text; // Code journal (CAIS, etc.)
            string cg_NumCont = cmbBxContrepartie.SelectedIndex == -1 ? null : _listeCompteGeneralContrepartieToDisplay[cmbBxContrepartie.SelectedIndex];
            newF_CREGLEMENT.CG_NumCont = cg_NumCont == "Aucun" ? null : cg_NumCont; // CompteGénéral contrepatie
            newF_CREGLEMENT.RG_Impaye = dtTmPckrDateImpaye.Text == "" ? new DateTime(1753, 1, 1, 0, 0, 0, 0) : dtTmPckrDateImpaye.Value; // Date impayé
            F_COMPTEG cg = _listeCompteGeneral[cmbBxCompteGeneral.SelectedIndex];
            newF_CREGLEMENT.CG_Num = cg.CG_Num; // Compte général
            newF_CREGLEMENT.RG_TypeReg = 0; // (Type du règlement (0 = règlement))
            newF_CREGLEMENT.RG_Heure = "000" + DateTime.Now.ToString("HHmmss"); // Heure de la création du nouveau règlement
            newF_CREGLEMENT.RG_Piece = txtBxNPiece.Text; // Numéro du pièce (Règlement de compte)
            newF_CREGLEMENT.CA_No = cmbBxCaisse.SelectedIndex + 1; // Numéro de la caisse sélectionnée
            newF_CREGLEMENT.cbCA_No = cmbBxCaisse.SelectedIndex + 1; // Numéro de la caisse sélectionnée
            F_COLLABORATEUR caissierSelect = _listeCaissier[cmbBxCaissier.SelectedIndex];
            newF_CREGLEMENT.CO_NoCaissier = caissierSelect.CO_No; // Numéro du caissier sélectionné
            newF_CREGLEMENT.cbCO_NoCaissier = cmbBxCaissier.SelectedIndex + 1; // Numéro du caissier sélectionné
            newF_CREGLEMENT.RG_Banque = 0; // Valeurs par défaut
            newF_CREGLEMENT.RG_Transfere = 0;  // Valeurs par défaut
            newF_CREGLEMENT.RG_Cloture = 0;  // Valeurs par défaut
            newF_CREGLEMENT.RG_Ticket = 0;  // Valeurs par défaut
            newF_CREGLEMENT.RG_Souche = 0;  // Valeurs par défaut
            newF_CREGLEMENT.CT_NumPayeurOrig = _cT_NumPayeur; // Client payeur origine
            newF_CREGLEMENT.RG_DateEchCont = dtTmPckrEcheanceContrepartie.Text == "" ? new DateTime(1753, 1, 1, 0, 0, 0, 0) : dtTmPckrEcheanceContrepartie.Value; // Date de l'échéance contrepartie
            newF_CREGLEMENT.CG_NumEcart = null; // Numéro de compte général d'écart
            newF_CREGLEMENT.JO_NumEcart = null; // Code journal d'écart
            newF_CREGLEMENT.RG_MontantEcart = 0; // Montant d'écart
            newF_CREGLEMENT.RG_NoBonAchat = 0; // Numéro interne du règlement
            newF_CREGLEMENT.RG_Valide = 0; // Règlement validé ou non
            newF_CREGLEMENT.RG_Anterieur = 0; // Règlement antérieur
            newF_CREGLEMENT.RG_MontantCommission = 0; // Montant du commission
            newF_CREGLEMENT.RG_MontantNet = 0; // Montant net (valeur net)
            newF_CREGLEMENT.cbCreateur = "COLS"; // Créateur de l'application
            newF_CREGLEMENT.cbModification = DateTime.Now; // Date de la modification
            newF_CREGLEMENT.cbReplication = 0;
            newF_CREGLEMENT.cbFlag = 0;
            newF_CREGLEMENT.cbCreation = DateTime.Now;
            newF_CREGLEMENT.cbHashVersion = 1;
            newF_CREGLEMENT.cbHash = null;
            newF_CREGLEMENT.cbHashDate = null;
            newF_CREGLEMENT.cbHashOrder = null;
            newF_CREGLEMENT.cbProt = 0;



            // Enregistrement du règlement dans la base
            _f_CREGLEMENTRepository.Add(newF_CREGLEMENT);

            // Mise à jour du numéro de pièce pour la prochaine création
            P_COLREGLEMENT p_COLREGLEMENT = _context.P_COLREGLEMENT.FirstOrDefault();
            int nextNPiece = Convert.ToInt32(txtBxNPiece.Text) + 1;
            p_COLREGLEMENT.CR_Numero01 = nextNPiece.ToString();
            _context.SaveChanges();

            System.Windows.Forms.MessageBox.Show("Insertion effectuée avec succès!", "Opération réussie", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);

            Close();
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
        private void txtBxCours_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' || textBox.Text.Contains(".")) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }
        private void txtBxMontant_KeyPress(object sender, KeyPressEventArgs e)
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



        // =================================================== CALCULS MONTANTS DEVISES ===================================================
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

        private void txtBxMontant_TextChanged(object sender, EventArgs e)
        {
            if (cmbBxDevise.Text != "Aucune" && txtBxCours.Text != "Cours" && txtBxCours.Text != "" && txtBxMontant.Text != "" && txtBxMontant.Text != "Montant")
            {
                decimal cours = Convert.ToDecimal(txtBxCours.Text);
                decimal montant = Convert.ToDecimal(txtBxMontant.Text);
                txtBxMontantDevise.Text = (montant * cours).ToString();
            }
        }


        // =================================================== CALCULS MONTANTS DEVISES ===================================================
    }
}
