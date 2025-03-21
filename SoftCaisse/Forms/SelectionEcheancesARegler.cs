﻿using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using SoftCaisse.DTO;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SoftCaisse.Forms
{
    public partial class SelectionEcheancesARegler : KryptonForm
    {
        // =============================================================================================================================================
        // ========================================================= DECLARATION DES VARIABLES =========================================================
        // =============================================================================================================================================
        private readonly AppDbContext _context;
        private DataTable _bindingSource;
        private readonly F_COMPTET _clientSelect;
        private readonly decimal? _initSolde;

        private readonly F_CREGLEMENTRepository _f_CREGLEMENTRepository;
        private readonly F_REGLECHRepository _f_REGLECHRepository;
        private readonly F_DOCENTETERepository _f_DOCENTETERepository;
        private readonly F_DOCREGLRepository _f_DOCREGLRepository;

        private ListeSelectionEcheancesRepository listeSelectionEcheancesRepository;

        private readonly List<F_COMPTEG> _listeCompteGeneral;
        private List<ListeSelectionEcheances> listeEcheances;

        private int rgNoFCRegl;
        // =============================================================================================================================================
        // ========================================================= DECLARATION DES VARIABLES =========================================================
        // =============================================================================================================================================









        // ======================================================================================================================================
        // ========================================================= DEBUT CONSTRUCTEUR =========================================================
        // ======================================================================================================================================
        public SelectionEcheancesARegler(string ct_Num, decimal? solde, int rgNo)
        {
            InitializeComponent();

            _context = new AppDbContext();
            _initSolde = solde;

            rgNoFCRegl = rgNo;

            listeSelectionEcheancesRepository = new ListeSelectionEcheancesRepository(_context);
            _f_CREGLEMENTRepository = new F_CREGLEMENTRepository(_context);
            _f_REGLECHRepository = new F_REGLECHRepository(_context);
            _f_DOCENTETERepository = new F_DOCENTETERepository(_context);
            _f_DOCREGLRepository = new F_DOCREGLRepository(_context);

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(panel2, 30);
            ApplyRoundedCorners(panel1, 30);

            _clientSelect = _context.F_COMPTET.Where(c => c.CT_Num == ct_Num).FirstOrDefault();
            _listeCompteGeneral = _context.F_COMPTEG.OrderBy(cmptG => cmptG.CG_Num).ToList();
            listeEcheances = listeSelectionEcheancesRepository.ListerEcheances(_clientSelect.CT_Num, rgNoFCRegl);

            afficherListeEcheances(listeEcheances);

            List<string> listeOptionsEcheances = new List<string> { "Tous", "Echéances non réglées", "Echéances réglées" };
            List<string> f_JOURNAUXes = _context.F_JOURNAUX.Where(j => j.JO_Type == 3).Select(j => j.JO_Num + " - " + j.JO_Intitule).ToList();

            cmbBxCompteEcart.DataSource = _listeCompteGeneral.Select(cmptG => cmptG.CG_Num + " - " + cmptG.CG_Intitule).ToList();
            cmbBxCompteEcart.SelectedIndex = -1;
            cmbBxOptEcheaches.DataSource = listeOptionsEcheances;
            cmbBxCodeJournal.DataSource = f_JOURNAUXes;
            cmbBxCodeJournal.SelectedIndex = -1;

            txtBxMontRegl.Enabled = false;
            txtBxMontEcart.Enabled = false;
            cmbBxCompteEcart.Enabled = false;
            cmbBxCodeJournal.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            if(_initSolde != 0)
            {
                decimal? montReglement = _initSolde;
                decimal? totImpute = 0;
                
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Règlement"].Value != null && decimal.TryParse(row.Cells["Règlement"].Value.ToString(), out decimal valeur))
                    {
                        montReglement += valeur;
                        totImpute += valeur;
                    }
                }
                decimal? resteAImputer = montReglement - totImpute;

                txtBxMontRegl.Text = montReglement.ToString();
                valMontRegle.Text = montReglement.ToString();
                valTotImpute.Text = totImpute.ToString();
                valResteAImputer.Text = resteAImputer.ToString();
            }
        }
        // ====================================================================================================================================
        // ========================================================= FIN CONSTRUCTEUR =========================================================
        // ====================================================================================================================================









        // ===================================================================================================================================================
        // ====================================================================== DEBUT FONCTIONS ============================================================
        // ===================================================================================================================================================

        // =================================================== DEBUT FONCTIONS POUR LE DESIGN ===================================================
        private void ApplyRoundedCorners(Control control, int borderRadius)
        {
            control.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                    path.AddArc(new Rectangle(0, control.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                    path.CloseAllFigures();

                    control.Region = new Region(path);
                }
            };

            control.Invalidate();
        }
        // =================================================== FIN FONCTIONS POUR LE DESIGN ===================================================



        // =========================================== DEBUT AUTRES FONCTIONS (ACTIONS) ===========================================
        private void afficherListeEcheances(List<ListeSelectionEcheances> listeEch)
        {
            if (cmbBxOptEcheaches.SelectedIndex == 0) // Option "Tous"
            {
                // Ne rien faire
            }
            else if (cmbBxOptEcheaches.SelectedIndex == 1) // Option "Echéances non réglées"
            {
                listeEch = listeEch.Where(ech => ech.DR_Regle == 0).ToList();
            }
            else // Option "Echéances réglées"
            {
                listeEch = listeEch.Where(ech => ech.DR_Regle == 1).ToList();
            }

            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Echéance"));
            _bindingSource.Columns.Add(new DataColumn("N° pièce"));
            _bindingSource.Columns.Add(new DataColumn("N° client"));
            _bindingSource.Columns.Add(new DataColumn("Mode règlement"));
            _bindingSource.Columns.Add(new DataColumn("Pourcentage"));
            _bindingSource.Columns.Add(new DataColumn("A payer"));
            _bindingSource.Columns.Add(new DataColumn("Est payé"));
            _bindingSource.Columns.Add(new DataColumn("Solde"));
            _bindingSource.Columns.Add(new DataColumn("Règlement"));

            foreach (ListeSelectionEcheances echeance in listeEch)
            {
                _bindingSource.Rows.Add(
                    echeance.DR_Date.ToString(),
                    echeance.DO_Piece,
                    echeance.CT_NumPayeur,
                    echeance.R_Intitule,
                    echeance.DR_Pourcent,
                    echeance.A_Payer,
                    echeance.DR_Regle == 0 ? "Non" : "Oui",
                    echeance.DR_Regle == 0 ? echeance.Solde : 0,
                    echeance.RC_Montant
                );
            }
            dataGridView1.DataSource = _bindingSource;
        }



        private decimal calculerTotalImpute()
        {
            decimal sommeImputation = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Règlement"].Value != null &&
                    decimal.TryParse(row.Cells["Règlement"].Value.ToString(), out decimal valeur))
                {
                    sommeImputation += valeur;
                }
            }
            return sommeImputation;
        }
        // =========================================== FIN AUTRES FONCTIONS (ACTIONS) ===========================================

        // ===================================================================================================================================================
        // ====================================================================== DEBUT FONCTIONS ============================================================
        // ===================================================================================================================================================









        // ====================================================================================================================================================
        // ====================================================================== DEBUT EVENEMENTS ============================================================
        // ====================================================================================================================================================

        // ======================================= CHANGEMENT DES ECHEANCES A AFFICHER ("TOUS", "NON REGLES", "REGLES") =======================================
        private void cmbBxOptEcheaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficherListeEcheances(listeEcheances);
        }





        // ==================================================== ACTIVATION OU DESACTIVATION ECART DE REGLEMENT ================================================
        private void checkBoxEnregistrerEcart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnregistrerEcart.Checked == false)
            {
                txtBxMontRegl.Enabled = false;
                cmbBxCompteEcart.Enabled = false;
                cmbBxCodeJournal.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                if (_initSolde != 0)
                {
                    txtBxMontRegl.Text = _initSolde.ToString();
                    valMontRegle.Text = _initSolde.ToString();
                }
                txtBxMontEcart.Text = "";

                decimal montRegle = valMontRegle.Text == "" ? 0 : Convert.ToDecimal(valMontRegle.Text);
                decimal totImpute = valTotImpute.Text == "" ? 0 : Convert.ToDecimal(valTotImpute.Text);
                if (montRegle != 0)
                {
                    valResteAImputer.Text = (montRegle - totImpute).ToString();
                }
            }
            else
            {
                if (_initSolde == 0)
                {
                    txtBxMontRegl.Enabled = true;
                    label1.Enabled = true;
                }
                else
                {
                    txtBxMontRegl.Enabled = false;
                    label1.Enabled = false;
                }
                cmbBxCompteEcart.Enabled = true;
                cmbBxCodeJournal.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                valResteAImputer.Text = "";

                decimal montRegle = valMontRegle.Text == "" ? 0 : Convert.ToDecimal(valMontRegle.Text);
                decimal totImpute = valTotImpute.Text == "" ? 0 : Convert.ToDecimal(valTotImpute.Text);
                if (montRegle != 0)
                {
                    txtBxMontEcart.Text = (montRegle - totImpute).ToString();
                }
            }
        }





        // =============================================== RESTRICTION LORS DE LA SAISIE DANS LES TEXTBOX NUMERIQUES ===============================================
        private void txtBxMontRegle_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (e.KeyChar == ',' && textBox.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',' || textBox.Text.Contains(",")) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }
        private void txtBxMontRegl_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (e.KeyChar == ',' && textBox.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',' || textBox.Text.Contains(",")) && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }
        // =============================================== RESTRICTION LORS DE LA SAISIE DANS LES TEXTBOX NUMERIQUES ================================================





        // ========================================================= MISE A JOUR DU CHAMP MONTANT A IMPUTER =========================================================
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Des lignes (règlements) sont sélectionnés
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                decimal? soldeEcheanceSelect = Convert.ToDecimal(selectedRow.Cells["Solde"].Value.ToString());
                decimal? montantReglement = Convert.ToDecimal(selectedRow.Cells["Règlement"].Value.ToString());
                txtBxMontRegle.Text = (soldeEcheanceSelect + montantReglement).ToString();
            }
        }





        // ============================================================= CLIQUER SUR LE BOUTON IMPUTER =============================================================
        private void kptnBtnImputer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Des lignes (règlements) sont sélectionnés
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                ListeSelectionEcheances ech = listeEcheances.Where(echeance => echeance.DO_Piece == selectedRow.Cells["N° pièce"].Value.ToString()).FirstOrDefault();
                decimal? soldeEcheanceSelect = Convert.ToDecimal(selectedRow.Cells["Solde"].Value.ToString());
                decimal? imputationAnterieur = selectedRow.Cells["Règlement"].Value.ToString() == "" ? 0 : Convert.ToDecimal(selectedRow.Cells["Règlement"].Value.ToString());
                decimal? resteAPayer = soldeEcheanceSelect + imputationAnterieur;
                decimal? montantAImputer = Convert.ToDecimal(txtBxMontRegle.Text);
                decimal montantRegl = valMontRegle.Text == "" ? 0 : Convert.ToDecimal(valMontRegle.Text);

                if (_initSolde == 0)
                {
                    if (montantAImputer > resteAPayer)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Le montant à imputer est supérieur au solde de l'échéance!",
                            "Attention",
                            (MessageBoxButtons)MessageBoxButton.OK,
                            (MessageBoxIcon)MessageBoxImage.Warning
                        );
                    }
                    else if (montantAImputer < 0)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Le montant à imputer est négatif!",
                            "Attention",
                            (MessageBoxButtons)MessageBoxButton.OK,
                            (MessageBoxIcon)MessageBoxImage.Warning
                        );
                    } else
                    {
                        selectedRow.Cells["Solde"].Value = resteAPayer - montantAImputer;
                        ech.Solde = resteAPayer - montantAImputer;
                        selectedRow.Cells["Règlement"].Value = montantAImputer;
                        ech.RC_Montant = montantAImputer;
                        if (Convert.ToDecimal(selectedRow.Cells["Solde"].Value) == 0)
                        {
                            selectedRow.Cells["Est payé"].Value = "Oui";
                            ech.DR_Regle = 1;
                        }
                        else
                        {
                            selectedRow.Cells["Est payé"].Value = "Non";
                            ech.DR_Regle = 0;
                        }
                        decimal totalImpute = calculerTotalImpute();
                        valTotImpute.Text = totalImpute.ToString();
                        decimal resteAImputer = montantRegl - totalImpute;
                        if (checkBoxEnregistrerEcart.Checked == true)
                        {
                            txtBxMontEcart.Text = resteAImputer.ToString();
                            valResteAImputer.Text = "";
                        }
                        else
                        {
                            valResteAImputer.Text = "";
                            valMontRegle.Text = totalImpute.ToString();
                            txtBxMontRegl.Text = totalImpute.ToString();
                            txtBxMontEcart.Text = "";
                        }
                    }
                }
                else
                {
                    if (montantAImputer < 0)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Le montant à imputer est négatif",
                            "Attention",
                            (MessageBoxButtons)MessageBoxButton.OK,
                            (MessageBoxIcon)MessageBoxImage.Warning
                        );
                    }
                    else if (montantAImputer > resteAPayer)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Le montant à imputer est supérieur au solde de l'échéance!",
                            "Attention",
                            (MessageBoxButtons)MessageBoxButton.OK,
                            (MessageBoxIcon)MessageBoxImage.Warning
                        );
                    }
                    else if (montantAImputer > montantRegl)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Le montant du règlement est insuffisant!",
                            "Attention",
                            (MessageBoxButtons)MessageBoxButton.OK,
                            (MessageBoxIcon)MessageBoxImage.Warning
                        );
                    }
                    else
                    {
                        selectedRow.Cells["Solde"].Value = resteAPayer - montantAImputer;
                        ech.Solde = resteAPayer - montantAImputer;
                        selectedRow.Cells["Règlement"].Value = montantAImputer;
                        ech.RC_Montant = montantAImputer;
                        if (Convert.ToDecimal(selectedRow.Cells["Solde"].Value) == 0)
                        {
                            selectedRow.Cells["Est payé"].Value = "Oui";
                            ech.DR_Regle = 1;
                        }
                        else
                        {
                            selectedRow.Cells["Est payé"].Value = "Non";
                            ech.DR_Regle = 0;
                        }
                        decimal totalImpute = calculerTotalImpute();
                        valTotImpute.Text = totalImpute.ToString();
                        decimal resteAImputer = montantRegl - totalImpute;
                        if (checkBoxEnregistrerEcart.Checked == true)
                        {
                            txtBxMontEcart.Text = resteAImputer.ToString();
                            valResteAImputer.Text = "";
                        }
                        else
                        {
                            valResteAImputer.Text = resteAImputer.ToString();
                            txtBxMontEcart.Text = "";
                        }
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Aucune échéance n'est sélectionée",
                    "Attention",
                    (MessageBoxButtons)MessageBoxButton.OK,
                    (MessageBoxIcon)MessageBoxImage.Warning
                );
            }
        }





        // ===================================================== MONTANT DU REGLEMENT (CAS AUCUN IMPUTATION ET REGLEMENT EN MEME TEMPS) =====================================================
        private void txtBxMontRegl_TextChanged(object sender, EventArgs e)
        {
            valMontRegle.Text = txtBxMontRegl.Text;
            decimal totalImpute = calculerTotalImpute();
            decimal montantRegl = valMontRegle.Text == "" ? 0 : Convert.ToDecimal(valMontRegle.Text);
            decimal resteAImputer = montantRegl - totalImpute;
            if (checkBoxEnregistrerEcart.Checked == true)
            {
                txtBxMontEcart.Text = resteAImputer.ToString();
                valResteAImputer.Text = "";
            }
            else
            {
                valResteAImputer.Text = resteAImputer.ToString();
                txtBxMontEcart.Text = "";
            }
        }





        // ===================================================== MONTANT DU REGLEMENT (CAS AUCUN IMPUTATION ET REGLEMENT EN MEME TEMPS) =====================================================
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkBoxEnregistrerEcart.Checked == true)
            {
                if (cmbBxCompteEcart.Text == "" || cmbBxCompteEcart.SelectedIndex == -1)
                {
                    System.Windows.Forms.MessageBox.Show("Aucun compte d'écart n'est spécifié", "erreur", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                    return;
                }
                else if (cmbBxCodeJournal.Text == "" || cmbBxCodeJournal.SelectedIndex == -1)
                {
                    System.Windows.Forms.MessageBox.Show("Aucun code journal n'est sélectionné", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
                    return;
                }
            }

            if (_initSolde == 0)
            {
                // ==================================== CREATION & ENREGISTREMENT REGLEMENT ====================================
                // Montant pas encore spécifié
                if (Convert.ToDecimal(txtBxMontRegl.Text) <= 0)
                {
                    System.Windows.Forms.MessageBox.Show("Le montant du règlement n'est pas encore valide", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                    return;
                }

                // Création objet à enregistrer dans la base
                F_CREGLEMENT newF_CREGLEMENT = new F_CREGLEMENT();
                P_COLREGLEMENT p_COLREGLEMENT = _context.P_COLREGLEMENT.FirstOrDefault();
                rgNoFCRegl = p_COLREGLEMENT.CR_Numero01 == "" ? 1 : Convert.ToInt32(p_COLREGLEMENT.CR_Numero01) + 1; // Numéro RG_Piece (Première colonne)
                newF_CREGLEMENT.RG_No = rgNoFCRegl;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string clientCTNum = selectedRow.Cells["N° client"].Value.ToString();
                string clientIntitule = _context.F_COMPTET.Where(c => c.CT_Num == clientCTNum).Select(c => c.CT_Intitule).FirstOrDefault();
                newF_CREGLEMENT.CT_NumPayeur = clientCTNum; // Client payeur
                newF_CREGLEMENT.RG_Date = DateTime.Now; // Date de la création
                newF_CREGLEMENT.RG_Reference = ""; // Référence
                newF_CREGLEMENT.RG_Libelle = "Règlement " + clientIntitule; // Libellé
                newF_CREGLEMENT.RG_Montant = txtBxMontRegl.Text == "" ? 0 : Convert.ToDecimal(txtBxMontRegl.Text); // Montant du règlement
                newF_CREGLEMENT.RG_MontantDev = 0; // Montant du règlement avec devise
                newF_CREGLEMENT.N_Reglement = 1; // Mode de règlement
                if (valResteAImputer.Text == "" || Convert.ToDecimal(valResteAImputer.Text) == 0)
                {
                    newF_CREGLEMENT.RG_Impute = 1; // 1 si imputé sinon 0
                    newF_CREGLEMENT.RG_Valide = 1; // Règlement validé ou non
                }
                else
                {
                    newF_CREGLEMENT.RG_Impute = 0; // 1 si imputé sinon 0
                    newF_CREGLEMENT.RG_Valide = 0; // Règlement validé ou non
                }
                newF_CREGLEMENT.RG_Compta = 0; // Non comptabilisé
                newF_CREGLEMENT.EC_No = 0;
                newF_CREGLEMENT.RG_Type = 0; // Type du client (0: client, 1: fournisseur, etc.)
                newF_CREGLEMENT.RG_Cours = 0; // Cours d'échange selon devise
                newF_CREGLEMENT.N_Devise = 0; // Devise
                newF_CREGLEMENT.JO_Num = "CAIS";
                if (checkBoxEnregistrerEcart.Checked == true)
                {
                    string CG_NumEcart = cmbBxCompteEcart.Text.Substring(0, cmbBxCompteEcart.Text.IndexOf(" - "));
                    string JO_NumEcart = cmbBxCodeJournal.Text.Substring(0, cmbBxCodeJournal.Text.IndexOf(" - "));
                    newF_CREGLEMENT.CG_NumEcart = CG_NumEcart; // Numéro de compte général d'écart
                    newF_CREGLEMENT.JO_NumEcart = JO_NumEcart; // Code journal d'écart
                    newF_CREGLEMENT.RG_MontantEcart = txtBxMontEcart.Text == "" ? 0 : Convert.ToDecimal(txtBxMontEcart.Text); // Montant d'écart
                } else
                {
                    newF_CREGLEMENT.CG_NumEcart = null; // Numéro de compte général d'écart
                    newF_CREGLEMENT.JO_NumEcart = null; // Code journal d'écart
                    newF_CREGLEMENT.RG_MontantEcart = 0; // Montant d'écart
                }
                newF_CREGLEMENT.CG_NumCont = null; // CompteGénéral contrepatie
                newF_CREGLEMENT.RG_Impaye = new DateTime(1753, 1, 1, 0, 0, 0, 0); // Date impayé
                newF_CREGLEMENT.CG_Num = "4110000";
                newF_CREGLEMENT.RG_TypeReg = 0; // (Type du règlement (0 = règlement))
                newF_CREGLEMENT.RG_Heure = "000" + DateTime.Now.ToString("HHmmss"); // Heure de la création du nouveau règlement
                newF_CREGLEMENT.RG_Piece = _context.P_COLREGLEMENT.Select(pc => pc.CR_Numero01).FirstOrDefault(); // Numéro du pièce (Règlement de compte)
                newF_CREGLEMENT.CA_No = 0; // Numéro de la caisse sélectionnée
                newF_CREGLEMENT.cbCA_No = null; // Numéro de la caisse sélectionnée
                newF_CREGLEMENT.CO_NoCaissier = 0; // Numéro du caissier sélectionné
                newF_CREGLEMENT.cbCO_NoCaissier = null; // Numéro du caissier sélectionné
                newF_CREGLEMENT.RG_Banque = 0; // Valeurs par défaut
                newF_CREGLEMENT.RG_Transfere = 0;  // Valeurs par défaut
                newF_CREGLEMENT.RG_Cloture = 0;  // Valeurs par défaut
                newF_CREGLEMENT.RG_Ticket = 0;  // Valeurs par défaut
                newF_CREGLEMENT.RG_Souche = 0;  // Valeurs par défaut
                newF_CREGLEMENT.CT_NumPayeurOrig = clientCTNum; // Client payeur origine
                newF_CREGLEMENT.RG_DateEchCont = new DateTime(1753, 1, 1, 0, 0, 0, 0); // Date de l'échéance contrepartie
                newF_CREGLEMENT.RG_NoBonAchat = 0; // Numéro interne du règlement
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
            }

            foreach (ListeSelectionEcheances ech in listeEcheances)
            {
                if (ech.RC_Montant > 0)
                {
                    _f_DOCENTETERepository.UpdateDO_MontantRegle((decimal)ech.RC_Montant, ech.DO_Piece);

                    F_CREGLEMENT f_CREGLEMENT = _context.F_CREGLEMENT.Where(fcr => fcr.RG_No == rgNoFCRegl).FirstOrDefault();
                    if (checkBoxEnregistrerEcart.Checked == true)
                    {
                        string cgNum = cmbBxCompteEcart.Text.Substring(0, cmbBxCompteEcart.Text.IndexOf(" - "));
                        string joNum = cmbBxCodeJournal.Text.Substring(0, cmbBxCodeJournal.Text.IndexOf(" - "));
                        decimal montEcart = txtBxMontEcart.Text == "" ? 0 : Convert.ToDecimal(txtBxMontEcart.Text);
                        f_CREGLEMENT.CG_NumEcart = cgNum;
                        f_CREGLEMENT.JO_NumEcart = joNum;
                        f_CREGLEMENT.RG_MontantEcart = montEcart;
                        _context.SaveChanges();
                    }
                    if (valResteAImputer.Text == "" || Convert.ToDecimal(valResteAImputer.Text) == 0)
                    {
                        f_CREGLEMENT.RG_Impute = 1; // 1 si imputé sinon 0
                        f_CREGLEMENT.RG_Valide = 1; // Règlement validé ou non
                        _context.SaveChanges();
                    }
                    else
                    {
                        f_CREGLEMENT.RG_Impute = 0; // 1 si imputé sinon 0
                        f_CREGLEMENT.RG_Valide = 0; // Règlement validé ou non
                        _context.SaveChanges();
                    }
                }
            }

            foreach (ListeSelectionEcheances ech in listeEcheances)
            {
                int indexOfEch = listeEcheances.IndexOf(ech);
                decimal? reglement = ech.RC_Montant;
                decimal? soldeEcheanceSelect = ech.Solde;
                if (reglement > 0)
                {
                    F_REGLECH reglech = _context.F_REGLECH.Where(rg => rg.RG_No == ech.RG_No && rg.DR_No == ech.DR_No).FirstOrDefault();
                    if (reglech != null && ech.RG_No == rgNoFCRegl)
                    {
                        _f_REGLECHRepository.UpdateRC_Montant((decimal)reglement, (int)ech.RG_No, ech.DR_No);
                        if (soldeEcheanceSelect == 0)
                        {
                            _f_DOCREGLRepository.UpdateEtatReglement((decimal)soldeEcheanceSelect, ech.DR_No);
                        }
                    }
                    else
                    {
                        _f_REGLECHRepository.AddReglech(rgNoFCRegl, ech.DR_No, ech.DO_Piece, (decimal)reglement, soldeEcheanceSelect == 0 ? 1 : 0);
                    }
                }
            }
            Close();
        }





        // ===================================================== ANNULATION DES OPERATIONS (FERMETURE DE LA FENETRE) =====================================================
        private void kptBtnAnnuler_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(valTotImpute.Text) != 0)
            {
                DialogResult result = System.Windows.Forms.MessageBox.Show(
                    "Voulez vous annuler les modifications ?",
                    "Attention",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                );
                if (result == DialogResult.OK)
                {
                    Close();
                }
                else
                {
                    // Ne rien faire
                }
            }
            else
            {
                Close();
            }
        }
        // ====================================================================================================================================================
        // ====================================================================== FIN EVENEMENTS ============================================================
        // ====================================================================================================================================================
    }
}
