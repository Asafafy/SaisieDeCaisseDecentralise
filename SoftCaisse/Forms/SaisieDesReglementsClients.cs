using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows;
using System.Windows.Forms;


namespace SoftCaisse.Forms
{
    public partial class SaisieDesReglementsClients : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;

        private readonly F_CREGLEMENTRepository f_CREGLEMENTRepository;

        private List<F_CAISSE> _f_CAISSEs;
        private List<F_COLLABORATEUR> _f_COLLABORATEURs;
        private List<P_REGLEMENT> _p_REGLEMENTs;
        private List<P_DEVISE> _p_DEVISEs;
        private List<F_REGLECH> f_REGLECHes;
        private DateTime _dateReference;

        List<F_COMPTET> _listeClients;


        // =============================== CONSTRUCTEUR ===============================
        public SaisieDesReglementsClients()
        {
            InitializeComponent();
            _context = new AppDbContext();

            f_CREGLEMENTRepository = new F_CREGLEMENTRepository(_context);

            InitDatatables();

            ApplyRoundedCorners(tableLayoutPanel1, 30);
            ApplyRoundedCorners(tableLayoutPanel12, 30);
            //ApplyRoundedCorners(panel2, 30);
            kptBtnSupprRegl.Enabled = false;
            kptBtnNouveau.Enabled = false;
            kptBtnUpdate.Enabled = false;

            List<string> listeOptionsRegl = new List<string> { "Tous", "Règlements non imputés", "Règlements soldés" };

            comboBox1.DataSource = listeOptionsRegl;

            _f_CAISSEs = _context.F_CAISSE.ToList();
            _f_COLLABORATEURs = _context.F_COLLABORATEUR.ToList();
            _p_REGLEMENTs = _context.P_REGLEMENT.ToList();
            _p_DEVISEs = _context.P_DEVISE.ToList();
            f_REGLECHes = _context.F_REGLECH.ToList();
            _listeClients = _context.F_COMPTET.OrderBy(c => c.CT_Num).ToList();
            _dateReference = new DateTime(1753, 1, 1, 0, 0, 0, 0);

            comboBox3.DataSource = _listeClients.Select(c => c.CT_Num + " - " + c.CT_Intitule).ToList();
            comboBox3.SelectedIndex = -1;
        }




        // ================================================ DEBUT FONCTIONS ================================================
        // =================================================================================================================
        private void InitDatatables()
        {
            _bindingSource = new DataTable();

            _bindingSource.Columns.Add(new DataColumn("Date"));
            _bindingSource.Columns.Add(new DataColumn("Caisse"));
            _bindingSource.Columns.Add(new DataColumn("Caissier"));
            _bindingSource.Columns.Add(new DataColumn("N° pièce"));
            _bindingSource.Columns.Add(new DataColumn("Type"));
            _bindingSource.Columns.Add(new DataColumn("Libellé"));
            _bindingSource.Columns.Add(new DataColumn("Référence"));
            _bindingSource.Columns.Add(new DataColumn("Mode règlement"));
            _bindingSource.Columns.Add(new DataColumn("N° tiers origine"));
            _bindingSource.Columns.Add(new DataColumn("Compte général"));
            _bindingSource.Columns.Add(new DataColumn("Montant"));
            _bindingSource.Columns.Add(new DataColumn("Devise"));
            _bindingSource.Columns.Add(new DataColumn("Cours"));
            _bindingSource.Columns.Add(new DataColumn("Montant devise"));
            _bindingSource.Columns.Add(new DataColumn("Code journal"));
            _bindingSource.Columns.Add(new DataColumn("Date impayé"));
            _bindingSource.Columns.Add(new DataColumn("Contrepartie"));
            _bindingSource.Columns.Add(new DataColumn("Solde"));
            _bindingSource.Columns.Add(new DataColumn("Clôturé"));
            _bindingSource.Columns.Add(new DataColumn("Echéance contrepartie"));
            _bindingSource.Columns.Add(new DataColumn("Validé"));
            _bindingSource.Columns.Add(new DataColumn("Imputé antérieur"));
            _bindingSource.Columns.Add(new DataColumn("Commission"));
            _bindingSource.Columns.Add(new DataColumn("Montant net"));
        }

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




        // =============================== EVENEMENTS ===============================
        private void btnNomenclature_Click(object sender, System.EventArgs e)
        {
            HistoriqueReglements historiqueReglements = new HistoriqueReglements();
            historiqueReglements.Show();
        }


        // Séléctionner (Liaison facture - règlement)
        private void button1_Click(object sender, System.EventArgs e)
        {
            F_COMPTET clientSelect = _context.F_COMPTET.Where(c => c.CT_Num + " - " + c.CT_Intitule == comboBox3.Text).FirstOrDefault();
            if (clientSelect == null)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Sélectionnez d'abord un client",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0) // Des lignes (règlements) sont sélectionnés
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    decimal? solde = Convert.ToDecimal(selectedRow.Cells["Solde"].Value.ToString());
                    decimal? montant = Convert.ToDecimal(selectedRow.Cells["Montant"].Value.ToString());
                    if (solde > 0 && solde <= montant)
                    {
                        string noPiece = selectedRow.Cells["N° pièce"].Value.ToString();
                        F_CREGLEMENT f_CREGLEMENT = _context.F_CREGLEMENT.Where(fcr => fcr.RG_Piece == noPiece).FirstOrDefault();
                        SelectionEcheancesARegler selectionEcheancesARegler = new SelectionEcheancesARegler(clientSelect.CT_Num, solde, (int)f_CREGLEMENT.RG_No);
                        selectionEcheancesARegler.Show();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Les règlements soldés ne sont plus utilisables",
                            "Attention",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                else // Aucune ligne (règlement) n'est sélectionnée
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Aucune ligne n'est sélectionnée",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            EcheancesRattacheesAuxReglements echeancesRattacheesAuxReglements = new EcheancesRattacheesAuxReglements();
            echeancesRattacheesAuxReglements.Show();
        }


        // Sélection des règlements à afficher
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                kptnBtnAfficher_Click(sender, e);
            }
        }


        private void kptnBtnAfficher_Click(object sender, System.EventArgs e)
        {
            string ctNumSelect = comboBox3.Text;
            F_COMPTET clientSelect = _listeClients.Where(ct => ct.CT_Num + " - " + ct.CT_Intitule == ctNumSelect).FirstOrDefault();

            if (clientSelect == null)
            {
                System.Windows.Forms.MessageBox.Show(
                        "Aucun client n'est trouvé, vérifiez votre sélection!",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
            else
            {
                List<F_CREGLEMENT> f_CREGLEMENTs = _context.F_CREGLEMENT.Where(fcr => fcr.CT_NumPayeur == clientSelect.CT_Num).ToList();
                if (comboBox1.SelectedIndex == 0) // Tous
                {
                    // Ne rien faire
                }
                else if (comboBox1.SelectedIndex == 1) // Règlements non imputés
                {
                    f_CREGLEMENTs = f_CREGLEMENTs.Where(fcr => fcr.RG_Impute == 0).ToList();
                }
                else // Règlements soldés
                {
                    f_CREGLEMENTs = f_CREGLEMENTs.Where(fcr => fcr.RG_Impute == 1).ToList();
                }


                InitDatatables();
                foreach (F_CREGLEMENT fcr in f_CREGLEMENTs)
                {
                    string nomCaisse = _f_CAISSEs.Where(c => c.CA_No == fcr.CA_No).Select(c => c.CA_Intitule).FirstOrDefault();
                    string nomCaissier = _f_COLLABORATEURs.Where(col => col.CO_No == fcr.CO_NoCaissier).Select(col => col.CO_Nom + col.CO_Prenom).FirstOrDefault();
                    string regType = "";
                    if (fcr.RG_Type == 0)
                        regType = "Client";
                    else if (fcr.RG_Type == 1)
                        regType = "Fournisseur";
                    else
                        regType = "Autres";
                    string nomReglement = _p_REGLEMENTs.Where(pr => pr.cbMarq == fcr.N_Reglement).Select(pr => pr.R_Intitule).FirstOrDefault();
                    string nomDevise = _p_DEVISEs.Where(d => d.cbMarq == fcr.N_Devise).Select(d => d.D_Intitule).FirstOrDefault();
                    string impaye = fcr.RG_Impaye != _dateReference ? fcr.RG_Impaye.ToString() : "";
                    List<F_REGLECH> listeReglech = f_REGLECHes.Where(r => r.RG_No == fcr.RG_No).ToList();
                    decimal? montantSolde = fcr.RG_Montant;
                    string dateEchContrepartie = fcr.RG_DateEchCont != _dateReference ? fcr.RG_DateEchCont.ToString() : "";
                    foreach (F_REGLECH reglech in listeReglech)
                    {
                        montantSolde = montantSolde - reglech.RC_Montant;
                    }
                    _bindingSource.Rows.Add(
                        fcr.RG_Date,
                        nomCaisse,
                        nomCaissier,
                        fcr.RG_Piece,
                        regType,
                        fcr.RG_Libelle,
                        fcr.RG_Reference,
                        nomReglement,
                        fcr.CT_NumPayeurOrig,
                        fcr.CG_Num,
                        fcr.RG_Montant,
                        nomDevise,
                        fcr.RG_Cours,
                        fcr.RG_MontantDev,
                        fcr.JO_Num,
                        impaye,
                        fcr.CG_NumCont,
                        fcr.RG_Impute == 1 ? 0 : montantSolde,
                        fcr.RG_Cloture == 1 ? "Cloturé" : "",
                        dateEchContrepartie,
                        fcr.RG_Valide == 0 ? "" : "Validé",
                        fcr.RG_Anterieur,
                        fcr.RG_MontantCommission,
                        fcr.RG_MontantNet
                    );
                }
                dataGridView1.DataSource = _bindingSource;
            }
        }



        // Suppression règlement (Delete F_CREGLEMENT)
        private void kptBtnSupprRegl_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string numPieceToDelete = selectedRow.Cells["N° pièce"].Value.ToString();
                F_CREGLEMENT cREGLEMENTToDelete = _context.F_CREGLEMENT.Where(fcr => fcr.RG_Piece == numPieceToDelete).FirstOrDefault();

                // On ne peut pas supprimer lorsque la facture est validée
                if (cREGLEMENTToDelete.RG_Valide == 1)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Vous ne pouvez pas supprimer les règlements déjà validées",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    f_CREGLEMENTRepository.Delete((int)cREGLEMENTToDelete.RG_No);
                    kptnBtnAfficher_Click(sender, e);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Veuillez sélectionner le règlement à supprimer",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // Nouveau règlement de compte
        private void kptBtnNouveau_Click(object sender, EventArgs e)
        {
            // Informations sur le client
            string ctNumSelect = comboBox3.Text;
            F_COMPTET clientSelect = _listeClients.Where(ct => ct.CT_Num + " - " + ct.CT_Intitule == ctNumSelect).FirstOrDefault();

            // Vérification rédondance Fenêtres
            var fenetreExistante = System.Windows.Forms.Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.Name == "NouveauReglement");
            if (fenetreExistante != null)
            {
                System.Windows.Forms.MessageBox.Show("Une création de règlement est encore en cours.", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
            }
            else
            {
                NouveauReglement nouveauReglement = new NouveauReglement(clientSelect.CT_Num);
                nouveauReglement.Show();
            }
        }

        // Activation ou non des deux boutons "Nouveau" et "Supprimer" selon la sélection dans DataGridView1
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Vérifier si au moins une ligne est sélectionnée.
            bool isRowSelected = dataGridView1.SelectedRows.Count > 0;

            kptBtnSupprRegl.Enabled = isRowSelected;
            kptBtnNouveau.Enabled = isRowSelected;
            kptBtnUpdate.Enabled = isRowSelected;
        }


        // Mise à jour règlement de compte (UPDATE F_CREGLEMENT)
        private void kptBtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string numPieceToDelete = selectedRow.Cells["N° pièce"].Value.ToString();
                F_CREGLEMENT cREGLEMENTToUpdate = _context.F_CREGLEMENT.Where(fcr => fcr.RG_Piece == numPieceToDelete).FirstOrDefault();
                // On ne peut pas supprimer lorsque la facture est validée
                if (cREGLEMENTToUpdate.RG_Valide == 1)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Vous ne pouvez pas modifier les règlements déjà validées",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    var fenetreExistante = System.Windows.Forms.Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.Name == "MiseAJourReglement");
                    if (fenetreExistante != null)
                    {
                        System.Windows.Forms.MessageBox.Show("Une modification de règlement est encore en cours.", "Attention", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                    }
                    else
                    {
                        MiseAJourReglement miseAJourReglement = new MiseAJourReglement(cREGLEMENTToUpdate);
                        miseAJourReglement.Show();
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                        "Sélectionnez d'abord le règlement à mettre à jour",
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                );
            }
        }


        // REGLER ET IMPUTER EN MEME TEMPS
        private void button3_Click(object sender, EventArgs e)
        {
            F_COMPTET clientSelect = _context.F_COMPTET.Where(c => c.CT_Num + " - " + c.CT_Intitule == comboBox3.Text).FirstOrDefault();
            if (clientSelect == null)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Sélectionnez d'abord un client",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                SelectionEcheancesARegler selectionEcheancesARegler = new SelectionEcheancesARegler(clientSelect.CT_Num, 0, 0);
                selectionEcheancesARegler.Show();
            }
        }
    }
}
