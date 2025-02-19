using ComponentFactory.Krypton.Toolkit;
using Objets100cLib;
using SoftCaisse.CustomModel;
using SoftCaisse.DTO;
using SoftCaisse.DTO.DetailsArticle;
using SoftCaisse.Forms.Article;
using SoftCaisse.Forms.FormCaisse;
using SoftCaisse.Models;
using SoftCaisse.Models.Json;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using SoftCaisse.Repositories.BIJOU.IRepository;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
using SoftCaisse.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace SoftCaisse.Forms
{
    public partial class NouveauEtMiseAJourDocumentDeVente : KryptonForm
    {
        // =============================================================================================================================================================================================
        // ============================================================================= DEBUT DECLARATION DES VARIABLES ===============================================================================
        // =============================================================================================================================================================================================
        MainForm mainForm;

        private readonly F_DOCREGLRepository _f_DOCREGLRepository;
        private readonly F_DOCLIGNERepository _f_DOCLIGNERepository;
        private readonly F_DOCENTETERepository _f_DOCENTETERepository;
        private readonly F_ARTFOURNISSRepository _f_ARTFOURNISSRepository;
        private readonly F_DOCCURRENTPIECERepository _f_DOCCURRENTPIECERepository;
        private readonly F_ARTSTOCKRepository _f_ARTSTOCKRepository;
        private readonly F_ARTSTOCKEMPLRepository _f_ARTSTOCKEMPLRepository;
        private readonly F_DOCLIGNEEMPLRepository _f_DOCLIGNEEMPLRepository;
        private readonly F_DEPOTRepository _f_DEPOTRepository;
        private readonly P_EXPEDITIONRepository _p_EXPEDITIONRepository;

        private readonly ListeEcheancesPourImpressionDocumentsDeVenteRepository _listeEcheancesPourImpressionDocumentsDeVenteRepository;

        private readonly F_DOCLIGNEService _f_DOCLIGNEService;
        private readonly F_ARTFOURNISSService _f_ARTFOURNISSService;
        private readonly F_DOCENTETEService _f_DOCENTETEService;
        private readonly F_DOCREGLService _f_DOCREGLService;
        private readonly F_ARTSTOCKService _f_ARTSTOCKService;
        private readonly F_ARTSTOCKEMPLService _f_ARTSTOCKEMPLService;

        private readonly AppDbContext _context;

        private readonly List<F_COMPTET> _listeClients;
        private readonly List<F_DOCENTETE> _listeDocuments;
        private readonly List<F_DOCREGL> _listeDocRegl;
        private readonly List<F_ARTICLE> _listeArticle;
        private readonly List<F_COLLABORATEUR> _listeCollaborateurs;
        private readonly List<F_DEPOT> _listeDepots;
        
        private readonly List<P_EXPEDITION> _listeExpedit;

        private readonly List<F_COLLABORATEUR> _listeCollab;
        private readonly List<F_COMPTEA> _listePlanAnalitique;


        private readonly string _typeDocument;
        private readonly string _currentDocPieceNo;

        private string initValuesDateLivrPrev;
        private string initValuesDateLivrReal;
        private string initValuesReference;
        private string initValuesAffaires;
        private string initValuesRepresentant;
        private string initValuesExpedition;
        private string initValuesEntete;
        private string initValuesCommentaires;
        private string initValuesDivers;
        private string initValuesDepot;

        private int nombreFermetureFenetre;
        private bool resultatDialogResultFermeture;
        private decimal pourcentageRemise;
        private int changedIndex = -1;
        private decimal _totalPrixHT;
        private decimal _totalPrixTTC;
        private F_DOCENTETE _fDocenteteToModif;
        // ===========================================================================================================================================================================================
        // ============================================================================= FIN DECLARATION DES VARIABLES ===============================================================================
        // ===========================================================================================================================================================================================





        // =========================================================================================================================================================================================
        // ================================================================================== DEBUT CONSTRUCTEUR ===================================================================================
        // =========================================================================================================================================================================================
        public NouveauEtMiseAJourDocumentDeVente(string typeDocument, MainForm form, F_DOCENTETE fDocenteteToModif)
        {
            InitializeComponent();

            FormClosing += NouveauEtMiseAJourDocumentDeVenteForm_FormClosing;

            _context = new AppDbContext();

            _f_DOCREGLRepository = new F_DOCREGLRepository(_context);
            _f_DOCENTETERepository = new F_DOCENTETERepository(_context);
            _f_DOCLIGNERepository = new F_DOCLIGNERepository(_context);
            _f_ARTFOURNISSRepository = new F_ARTFOURNISSRepository(_context);
            _f_DOCCURRENTPIECERepository = new F_DOCCURRENTPIECERepository(_context);
            _f_ARTSTOCKRepository = new F_ARTSTOCKRepository(_context);
            _f_ARTSTOCKEMPLRepository = new F_ARTSTOCKEMPLRepository(_context);
            _f_DOCLIGNEEMPLRepository = new F_DOCLIGNEEMPLRepository(_context);
            _f_DEPOTRepository = new F_DEPOTRepository(_context);
            _p_EXPEDITIONRepository = new P_EXPEDITIONRepository(_context);

            _listeEcheancesPourImpressionDocumentsDeVenteRepository = new ListeEcheancesPourImpressionDocumentsDeVenteRepository(_context);

            _f_DOCENTETEService = new F_DOCENTETEService(_f_DOCENTETERepository);
            _f_DOCLIGNEService = new F_DOCLIGNEService(_context, _f_DOCLIGNERepository);
            _f_ARTFOURNISSService = new F_ARTFOURNISSService(_f_ARTFOURNISSRepository);
            _f_DOCREGLService = new F_DOCREGLService(_f_DOCREGLRepository, _f_DOCENTETEService);
            _f_ARTSTOCKService = new F_ARTSTOCKService(_context, _f_ARTSTOCKRepository);
            _f_ARTSTOCKEMPLService = new F_ARTSTOCKEMPLService(_context, _f_ARTSTOCKEMPLRepository);

            _typeDocument = typeDocument;
            _fDocenteteToModif = fDocenteteToModif;
            mainForm = form;
            nombreFermetureFenetre = 0;


            _listeDocuments = _context.F_DOCENTETE.ToList();
            _listeClients = _context.F_COMPTET.Where(c => c.CT_Type == 0).ToList();
            _listeDocRegl = _context.F_DOCREGL.ToList();
            _listeArticle = _context.F_ARTICLE.ToList();
            _listeCollaborateurs = _context.F_COLLABORATEUR.ToList();
            _listeExpedit = _context.P_EXPEDITION.Where(expedit => expedit.E_Intitule != "").ToList();
            _listePlanAnalitique = _context.F_COMPTEA.ToList();
            _listeCollab = _context.F_COLLABORATEUR.ToList();
            _listeDepots = _context.F_DEPOT.OrderBy(d => d.DE_No).ToList();

            _currentDocPieceNo = _f_DOCENTETEService.GetCurrentDocNumber(typeDocument, _listeDocuments);

            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(tableLayoutPanel5, 30);

            comboBoxClient.DataSource = _listeClients.Select(c => c.CT_Num + " - " + c.CT_Intitule).ToList();
            comboBoxClient.SelectedIndex = -1;
            if (typeDocument != "Facture comptabilisée")
                comboBoxStatus.Text = "A comptabiliser";
            else
                comboBoxStatus.Text = "Comptabilisée";

            comboBoxAffaire.DataSource = _listePlanAnalitique.Where(p => p.N_Analytique == 3).Select(p => p.CA_Num + " - " + p.CA_Intitule).ToList();
            comboBoxAffaire.SelectedIndex = -1;
            comboBoxExpedit.DataSource = _listeExpedit.Select(ex => ex.E_Intitule).ToList();
            comboBoxExpedit.SelectedIndex = -1;
            comboBoxRepresentant.DataSource = _listeCollab.Where(c => c.CO_Vendeur == 1).Select(c => c.CO_Nom + " " + c.CO_Prenom).ToList();
            comboBoxRepresentant.SelectedIndex = -1;
            comboBoxDepot.DataSource = _listeDepots.Select(d => d.DE_Intitule).ToList();
            textBoxNDoc.Text = _currentDocPieceNo;


            // Activation ou non des propriétés du document de vente
            if (_fDocenteteToModif == null)
            {
                comboBoxClient.Enabled = true;
                dateTimePicker1.Enabled = true;
                textBoxNDoc.Enabled = false;
                comboBoxStatus.Enabled = false;
            } else
            {
                comboBoxClient.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBoxNDoc.Enabled = false;
                comboBoxStatus.Enabled = false;
            }

            // Désactiver les boutons (Valider, OK, Nouveau) et les champs de saisie des articles (F_DOCLIGNES)
            tableLayoutPanel2.Enabled = false;
            BouttonNouveauDesignation.Enabled = false;
            BouttonSupprimerDesignation.Enabled = false;
            BouttonEnregistrerDesignation.Enabled = false;
            kptnBtnValider.Enabled = false;            

            // Gestion des couleurs des textes dans le Table Layout Panel
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is TextBox)
                {
                    control.Enter += TextBox_Enter;
                    control.Leave += TextBox_Leave;
                    control.Tag = control.Text;
                }
            }


            if (_fDocenteteToModif != null)
            {
                // Affichage des informations concernant le F_DOCENTETE (Document de vente à mettre à jour) =========================
                F_COMPTET clientTiers = _listeClients.Where(cl => cl.CT_Num == _fDocenteteToModif.DO_Tiers).FirstOrDefault();
                F_COMPTEA planAnal = _listePlanAnalitique.Where(pa => pa.CA_Num == _fDocenteteToModif.CA_Num).FirstOrDefault();
                F_COLLABORATEUR collab = _listeCollab.Where(co => co.CO_No == _fDocenteteToModif.CO_No).FirstOrDefault();
                P_EXPEDITION expedit = _listeExpedit.Where(exp => exp.cbMarq == _fDocenteteToModif.DO_Expedit).FirstOrDefault();
                
                List<F_COMPTEA> listePAAffiches = _listePlanAnalitique.Where(p => p.N_Analytique == 3).ToList();
                List<F_COLLABORATEUR> listeCollaborateursCmbBx = _listeCollab.Where(c => c.CO_Vendeur == 1).ToList();
                List<F_DOCLIGNE> listeDoclignesDocToUpdate = _context.F_DOCLIGNE
                    .Where(dl => dl.DO_Piece == _fDocenteteToModif.DO_Piece)
                    .OrderBy(dl => dl.DL_Ligne)
                    .ToList();

                int indexPA = listePAAffiches.IndexOf(planAnal);
                int indexCollab = listeCollaborateursCmbBx.IndexOf(collab);
                int indexExpedit = _listeExpedit.IndexOf(expedit);
                
                comboBoxClient.SelectedIndex = _listeClients.IndexOf(clientTiers);
                dateTimePicker1.Value = (DateTime)_fDocenteteToModif.DO_Date;
                if (_fDocenteteToModif.DO_DateLivr != new DateTime(1753, 01, 01, 00, 00, 00))
                {
                    dateTimePicker2.Value = (DateTime)_fDocenteteToModif.DO_DateLivr;
                }
                if (_fDocenteteToModif.DO_DateLivrRealisee != new DateTime(1753, 01, 01, 00, 00, 00))
                {
                    dateTimePicker3.Value = (DateTime)_fDocenteteToModif.DO_DateLivrRealisee;
                }
                _currentDocPieceNo = _fDocenteteToModif.DO_Piece;
                textBoxNDoc.Text = _fDocenteteToModif.DO_Piece;
                txtBxRef.Text = _fDocenteteToModif.DO_Ref;
                textBoxEnTete.Text = _fDocenteteToModif.DO_Coord01;
                textBoxCommentaires.Text = _fDocenteteToModif.Commentaires;
                textBoxDivers.Text = _fDocenteteToModif.Divers;
                comboBoxAffaire.SelectedIndex = indexPA;
                comboBoxRepresentant.SelectedIndex = indexCollab;
                comboBoxExpedit.SelectedIndex = indexExpedit;
                comboBoxDepot.SelectedIndex = (int)_fDocenteteToModif.DE_No - 1;

                // Activation ou non du bouton Valider
                if (_fDocenteteToModif.DO_Type == 6)
                {
                    if (_fDocenteteToModif.DO_Valide == 1)
                        btnValider.Enabled = false;
                    else
                        btnValider.Enabled = true;
                }
                else
                    btnValider.Enabled = false;

                // ========================= Affichage des F_DOCLIGNES =========================
                foreach (F_DOCLIGNE fDocligne in listeDoclignesDocToUpdate)
                {
                    decimal? quantite = fDocligne.DL_Qte;
                    F_ARTICLE article = _context.F_ARTICLE.Where(art => art.AR_Ref == fDocligne.AR_Ref).FirstOrDefault();
                    string conditionnementLigne = article.AR_Condition == 0 ? "Pièce" : "Unité";
                    DataGridViewArticle.Rows.Add(fDocligne.DL_Ligne, fDocligne.AR_Ref, fDocligne.DL_Design, fDocligne.DL_PrixUnitaire, fDocligne.DL_PUTTC, quantite, conditionnementLigne, fDocligne.DL_Remise01REM_Valeur, fDocligne.DL_PrixUnitaire, fDocligne.DL_MontantHT, fDocligne.DL_MontantTTC);
                }

                if(DataGridViewArticle.Rows.Count < 1)
                {
                    tableLayoutPanel2.Enabled = true;
                    BouttonNouveauDesignation.Enabled = true;
                    BouttonEnregistrerDesignation.Enabled = true;
                    comboBoxDepot.Enabled = false;
                }


                // Désactivation de certains éléments lorsque le document est déjà validé
                if (_fDocenteteToModif.DO_Valide == 1)
                {
                    TextBoxReference.Enabled = false;
                    comboBoxRepresentant.Enabled = false;
                    comboBoxExpedit.Enabled = false;

                    BouttonEnregistrerDesignation.Enabled = false;
                    BouttonSupprimerDesignation.Enabled = false;
                    BouttonNouveauDesignation.Enabled = false;
                }


                // Initialisation des valeurs à vérifier lors de la fermeture de la fenêtre
                initValuesDateLivrPrev = dateTimePicker2.Value.ToString();
                initValuesDateLivrReal = dateTimePicker3.Value.ToString();
                initValuesReference = txtBxRef.Text;
                initValuesAffaires = comboBoxAffaire.Text;
                initValuesRepresentant = comboBoxRepresentant.Text;
                initValuesExpedition = comboBoxExpedit.Text;
                initValuesEntete = textBoxEnTete.Text;
                initValuesCommentaires = textBoxCommentaires.Text;
                initValuesDivers = textBoxDivers.Text;
                initValuesDepot = comboBoxDepot.Text;
            }
            else
            {
                initValuesDateLivrPrev = DateTime.Now.ToString();
                initValuesDateLivrReal = DateTime.Now.ToString();
                initValuesReference = "";
                initValuesAffaires = "";
                initValuesRepresentant = "";
                initValuesExpedition = "";
                initValuesEntete = "";
                initValuesCommentaires = "";
                initValuesDivers = "";
                initValuesDepot = "";
            }
        }
        // =======================================================================================================================================================================================
        // ================================================================================== FIN CONSTRUCTEUR ===================================================================================
        // =======================================================================================================================================================================================









        // =======================================================================================================================================================================================
        // ================================================================================== DEBUT FONCTIONS ====================================================================================
        // =======================================================================================================================================================================================

        // =======================================================================================================================================================================================
        // =============================================================================== DEBUT FONCTIONS DESIGN ================================================================================
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
        // ================================================================================ FIN FONCTIONS DESIGN =================================================================================
        // =======================================================================================================================================================================================





        // =======================================================================================================================================================================================
        // ===================================================================== DEBUT FONCTIONS MISE A JOUR DES AFFICHAGES ======================================================================

        // ======================================================================== AJOUT PRIX LORS DU CHOIX DES ARTICLES ========================================================================
        public void AjouterPrix(string arRef, string arDesign, decimal puHT, decimal puTTC, string UniteVente)
        {
            TextBoxReference.Text = arRef;
            TextBoxDesignation.Text = arDesign;
            TextBoxPUHT.Text = puHT.ToString("N2");
            TextBoxPUTTC.Text = puTTC.ToString("N2");
            TextBoxPUNet.Text = puHT.ToString("N2");
            TextBoxConditionnement.Text = UniteVente;
            TextBoxMontantHT.Text = puHT.ToString("N2");
            TextBoxMontantTTC.Text = puTTC.ToString("N2");
            txtBxQuantite.Text = "1";
        }




        // ============================================================ MISE A JOUR DES MONTANTS LORS DE LA MISE A JOUR DE LA QUANTITE ===========================================================
        public void MettreAJourMontants()
        {
            if (txtBxQuantite.Text != "")
            {
                int quantiteArt = Convert.ToInt32(txtBxQuantite.Text);
                decimal? puHT = Convert.ToDecimal(TextBoxPUHT.Text);
                decimal? puTTC = Convert.ToDecimal(TextBoxPUTTC.Text);
                decimal? remise = txtBxRemise.Text == "" ? 0 : Convert.ToDecimal(txtBxRemise.Text);
                                       
                decimal? montantHTSansRemise = quantiteArt * puHT;
                decimal? valeurRemiseHT = (remise * montantHTSansRemise) / 100;
                decimal? montantHTAvecRemise = montantHTSansRemise - valeurRemiseHT;
                TextBoxMontantHT.Text = montantHTAvecRemise.ToString();
                
                decimal? montantTTCSansRemise = quantiteArt * puTTC;
                decimal? valeurRemiseTTC = (remise * montantTTCSansRemise) / 100;
                decimal? montantTTCAvecRemise = montantTTCSansRemise - valeurRemiseTTC;
                TextBoxMontantTTC.Text = montantTTCAvecRemise.ToString();
            }
        }




        // ======================================================================= MISE A JOUR DU POIDS TOTAL (BRUT ET NET) ======================================================================
        public void MettreAJourPoids()
        {
            List<string> listeDesChaines = new List<string>();
            decimal? poidsNetTot = 0;
            decimal? poidsBrutTot = 0;

            // Parcourir chaque ligne du DataGridView
            foreach (DataGridViewRow row in DataGridViewArticle.Rows)
            {
                string arRef = row.Cells[1].Value.ToString();
                F_ARTICLE article = _context.F_ARTICLE.Where(art => art.AR_Ref == arRef).FirstOrDefault();
                poidsNetTot = poidsNetTot + article.AR_PoidsNet;
                poidsBrutTot = poidsBrutTot + article.AR_PoidsBrut;
            }

            valPdsNet.Text = poidsNetTot.ToString();
            valPdsBrut.Text = poidsBrutTot.ToString();
        }
        // ====================================================================== FIN FONCTIONS MISE A JOUR DES AFFICHAGES =======================================================================
        // =======================================================================================================================================================================================




        private void ControlTableLayoutPanel()
        {
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Tag?.ToString();
                }
            }
        }
        // =======================================================================================================================================================================================
        // =================================================================================== FIN FONCTIONS =====================================================================================
        // =======================================================================================================================================================================================









        // =======================================================================================================================================================================================
        // ================================================================================== DEBUT EVENEMENTS ===================================================================================
        // =======================================================================================================================================================================================

        // ================================================================================ FIN FONCTIONS DESIGN =================================================================================
        // =======================================================================================================================================================================================


        // =============================================================================== ANNULATION / FERMETURE ================================================================================

        private void NouveauEtMiseAJourDocumentDeVenteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nombreFermetureFenetre < 1)
            {
                kptAnnuler_Click(sender, e);
                if (resultatDialogResultFermeture == false)
                    e.Cancel = true;
            }
            // else (ne rien faire) - Laisser la fenêtre fermer
        }

        private void kptAnnuler_Click(object sender, System.EventArgs e)
        {
            bool nEstPasModifie =   initValuesDateLivrPrev == dateTimePicker2.Value.ToString()
                                    && initValuesDateLivrReal == dateTimePicker3.Value.ToString()
                                    && initValuesReference == txtBxRef.Text
                                    && initValuesAffaires == comboBoxAffaire.Text
                                    && initValuesRepresentant == comboBoxRepresentant.Text
                                    && initValuesExpedition == comboBoxExpedit.Text
                                    && initValuesEntete == textBoxEnTete.Text
                                    && initValuesCommentaires == textBoxCommentaires.Text
                                    && initValuesDivers == textBoxDivers.Text
                                    && initValuesDepot == comboBoxDepot.Text;

            // Fermer si aucune modification n'est effectuée
            if (nEstPasModifie == true)
            {
                nombreFermetureFenetre += 1;
                Close();
            }
            // Message de confirmation suite aux modifications avant fermeture
            else
            {
                DialogResult resultat = MessageBox.Show("Les modifications non enregistrés seront perdues, vouluez vous confirmer la fermeture ?","Confirmationfermeture",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    nombreFermetureFenetre += 1;
                    Close();
                } else
                {
                    resultatDialogResultFermeture = false;
                }
            }
        }




        // =======================================================================================================================================================================================
        // ================================================================================== SELECTION CLIENT ===================================================================================
        private void comboBoxClient_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxClient.SelectedIndex == -1)
            {
                kptnBtnValider.Enabled = false;
            }
            else
            {
                F_COMPTET client = _listeClients.Where(c => c.CT_Num + " - " + c.CT_Intitule == comboBoxClient.Text).FirstOrDefault();

                // Sélectionner le compte analytique correspondant au client s'il existe
                F_COMPTEA compteAnal = _listePlanAnalitique.Where(ca => ca.CA_Num == client.CA_Num).FirstOrDefault();
                if (compteAnal == null)
                {
                    comboBoxAffaire.SelectedIndex = -1;
                }
                else
                {
                    int indexCmbBxAffaire = comboBoxAffaire.FindStringExact(compteAnal.CA_Num + " - " + compteAnal.CA_Intitule);
                    comboBoxAffaire.SelectedIndex = indexCmbBxAffaire;
                }

                // Sélectionner le collaborateur correspondant au client s'il existe
                F_COLLABORATEUR collaborateur = _listeCollab.Where(collab => collab.CO_No == client.CO_No).FirstOrDefault();
                if (collaborateur == null)
                {
                    comboBoxRepresentant.SelectedIndex = -1;
                }
                else
                {
                    int indexCmbBxRepresentant = comboBoxRepresentant.FindStringExact(collaborateur.CO_Nom + " " + collaborateur.CO_Prenom);
                    comboBoxRepresentant.SelectedIndex = indexCmbBxRepresentant;
                }

                // Sélectionner le lieu d'expédition correspondant au client
                P_EXPEDITION p_EXPEDITION = _p_EXPEDITIONRepository.Get_P_EXPEDITION_By_cbMarq((int)client.N_Expedition);
                if (p_EXPEDITION == null)
                {
                    comboBoxExpedit.SelectedIndex = -1;
                } else
                {
                    int indexCmbBxExpedition = comboBoxExpedit.FindStringExact(p_EXPEDITION.E_Intitule);
                    comboBoxExpedit.SelectedIndex = indexCmbBxExpedition;
                }

                kptnBtnValider.Enabled = true;
            }
        }




        // ================================================================== VALIDATION DE LA CREATION D'UN DOCUMENT DE VENTE ===================================================================
        private void kptnBtnValider_Click(object sender, System.EventArgs e)
        {
            short? estBloque = _listeClients.Where(c => c.CT_Num + " - " + c.CT_Intitule == comboBoxClient.Text).Select(c => c.CT_ControlEnc).FirstOrDefault();
            if (estBloque == 2)
            {
                MessageBox.Show("Aucun document ne peut être émis depuis ce client car il est bloqué", "Client bloqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Récupération des informations du document de vente
                string CT_NumActu = _listeClients[comboBoxClient.SelectedIndex].CT_Num;
                DateTime dateLivrPrevu;
                if (dateTimePicker2.Value == null)
                    dateLivrPrevu = new DateTime(1753, 01, 01);
                else
                    dateLivrPrevu = dateTimePicker3.Value;
                DateTime dateLivrReal;
                if (dateTimePicker3.Value == null)
                    dateLivrReal = new DateTime(1753, 01, 01);
                else
                    dateLivrReal = dateTimePicker3.Value;
                string reference = txtBxRef.Text;
                string caNum = comboBoxAffaire.Text;
                int indexEspace = caNum.IndexOf(' ');
                if (caNum != "")
                    caNum = caNum.Substring(0, indexEspace);
                
                int numExpedition = comboBoxExpedit.SelectedIndex + 1;
                string expeditIntitule = comboBoxExpedit.Text == "" ? _listeExpedit[0].E_Intitule : comboBoxExpedit.Text;
                string dO_Coord01 = textBoxEnTete.Text;
                string commentaires = textBoxCommentaires.Text;
                string divers = textBoxDivers.Text;
                string representant = comboBoxRepresentant.Text;
                int numeroDepot = comboBoxDepot.SelectedIndex + 1;

                // CREATION D'UN NOUVEAU DOCUMENT DE VENTE ===================================================================
                if (_fDocenteteToModif == null)
                {
                    // Mise à jour du Doc current pièce (Numéro de pièce actuel)
                    _f_DOCCURRENTPIECERepository.Update(_typeDocument, _currentDocPieceNo);

                    List<F_REGLEMENTT> listeReglT = _context.F_REGLEMENTT.Where(r => r.CT_Num == CT_NumActu).ToList();

                    // Insertion dans F_DOCREGL (Règlement)
                    _f_DOCREGLService.InsertNewF_DOCREGL(_listeDocRegl, listeReglT, _currentDocPieceNo, _listeClients, _typeDocument);

                    // Get des propriétés à inserer dans le nouveau DOCENTETE
                    int caisseNumber = mainForm.CaisseNo;
                    int caissierNumber = mainForm.CaissierCollabNo;

                    // Insertion d'un nouvel objet dans F_DOCENTETE
                    F_COMPTET client = _listeClients[comboBoxClient.SelectedIndex];
                    _f_DOCENTETEService.InsertNewF_DOCENTETE(_typeDocument, _currentDocPieceNo, client, (short?)numExpedition, caNum, caisseNumber, caissierNumber, expeditIntitule, dateLivrPrevu, dateLivrReal, reference, dO_Coord01, divers, commentaires, representant, numeroDepot);

                    // MISE A JOUR DES AFFICHAGES =================================
                    // Activer Table Layout Panel (Champ de saisie des articles)
                    tableLayoutPanel2.Enabled = true;

                    // Activation des boutons Nouveau, Supprimer et Enregistrer
                    BouttonNouveauDesignation.Enabled = true;
                    BouttonSupprimerDesignation.Enabled = true;
                    BouttonEnregistrerDesignation.Enabled = true;

                    // Disable Valider (Validation Docentete & Client)
                    labelClient.Enabled = false;
                    comboBoxClient.Enabled = false;
                    labelDate.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    labelNDocu.Enabled = false;
                    textBoxNDoc.Enabled = false;
                    labelStatut.Enabled = false;
                    comboBoxStatus.Enabled = false;

                    _fDocenteteToModif = _context.F_DOCENTETE.Where(d => d.DO_Piece == _currentDocPieceNo).FirstOrDefault();

                    MessageBox.Show("La création du document de vente est effectuée avec succès", "Création effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mise à jour des valeurs initiaux
                    initValuesDateLivrPrev = dateTimePicker2.Value.ToString();
                    initValuesDateLivrReal = dateTimePicker3.Value.ToString();
                    initValuesReference = txtBxRef.Text;
                    initValuesAffaires = comboBoxAffaire.Text;
                    initValuesRepresentant = comboBoxRepresentant.Text;
                    initValuesExpedition = comboBoxExpedit.Text;
                    initValuesEntete = textBoxEnTete.Text;
                    initValuesCommentaires = textBoxCommentaires.Text;
                    initValuesDivers = textBoxDivers.Text;
                    initValuesDepot = comboBoxDepot.Text;
                }
                // MISE A JOUR D'UN DOCUMENT DE VENTE EXISTANT ===================================================================
                else
                {
                    _f_DOCENTETEService.UpdateProprietesF_DOCENTETE(_currentDocPieceNo, dateLivrPrevu, dateLivrReal, reference, caNum, representant, (short?)numExpedition, expeditIntitule, dO_Coord01, commentaires, divers, numeroDepot);
                    MessageBox.Show("Mise à jour effectué avec succès", "Mise à jour effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mise à jour des valeurs initiaux
                    initValuesDateLivrPrev = dateTimePicker2.Value.ToString();
                    initValuesDateLivrReal = dateTimePicker3.Value.ToString();
                    initValuesReference = txtBxRef.Text;
                    initValuesAffaires = comboBoxAffaire.Text;
                    initValuesRepresentant = comboBoxRepresentant.Text;
                    initValuesExpedition = comboBoxExpedit.Text;
                    initValuesEntete = textBoxEnTete.Text;
                    initValuesCommentaires = textBoxCommentaires.Text;
                    initValuesDivers = textBoxDivers.Text;
                    initValuesDepot = comboBoxDepot.Text;
                }
            }
        }




        // ================================================================= DEFINITION DES COMPORTEMENTS DES DATETIME PICKER ===================================================================
        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Long;
        }
        private void dateTimePicker3_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Long;
        }
        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }
        private void kryptonButton4_Click(object sender, System.EventArgs e)
        {
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
        }




        // =========================================================================== OUVERTURE FENETRE NOMENCLATURE ============================================================================
        private void btnNomenclature_Click(object sender, EventArgs e)
        {
            InformationsDocumentsDesVentes informationsDocumentsDesVentes = new InformationsDocumentsDesVentes();
            informationsDocumentsDesVentes.ShowDialog();
        }




        // ======================================================================== SELECTION ARTICLE AVEC SA REFERENCE ==========================================================================
        private void TextBoxReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }




        // ======================================================================== SELECTION ARTICLE AVEC SA REFERENCE ==========================================================================
        private void TextBoxReference_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                decimal puHT;
                decimal puTTC;

                e.IsInputKey = true;

                string codeFamilleOuDesignation = TextBoxReference.Text.ToLower();

                var articleSaisie = _context.F_ARTICLE.Where(a => a.AR_Ref.ToLower() == codeFamilleOuDesignation || a.FA_CodeFamille.ToLower() == codeFamilleOuDesignation).FirstOrDefault();
                if (articleSaisie != null)
                {
                    F_COMPTET clientSelectionne = _listeClients.Where(cli => cli.CT_Num + " - " + cli.CT_Intitule == comboBoxClient.Text).FirstOrDefault();
                    var artClient = _context.F_ARTCLIENT.Where(artCli => artCli.CT_Num == clientSelectionne.CT_Num && artCli.AR_Ref == articleSaisie.AR_Ref).FirstOrDefault();
                    var artCompta = _context.F_ARTCOMPTA.Where(artCmpt => artCmpt.AR_Ref == articleSaisie.AR_Ref && artCmpt.ACP_TypeFacture == 0 && artCmpt.ACP_Type == 0 && artCmpt.ACP_Champ == 1).FirstOrDefault();
                    var taxe1 = _context.F_TAXE.Where(taxe => taxe.TA_Code == artCompta.ACP_ComptaCPT_Taxe1).FirstOrDefault();
                    var taxe2 = _context.F_TAXE.Where(taxe => taxe.TA_Code == artCompta.ACP_ComptaCPT_Taxe2).FirstOrDefault();
                    var taxe3 = _context.F_TAXE.Where(taxe => taxe.TA_Code == artCompta.ACP_ComptaCPT_Taxe3).FirstOrDefault();
                    decimal taux1 = taxe1?.TA_Taux ?? 0;
                    decimal taux2 = taxe2?.TA_Taux ?? 0;
                    decimal taux3 = taxe3?.TA_Taux ?? 0;
                    bool estHorsTaxe;

                    if (artClient != null) // Prix de l'article spécifique à un client existe
                    {
                        estHorsTaxe = artClient.AC_PrixTTC == 0 ? true : false;
                        bool prixVenteEstZero = artClient.AC_PrixVen == 0 ? true : false;
                        if (!prixVenteEstZero)
                        {
                            if (estHorsTaxe)
                            {
                                puHT = (decimal)artClient.AC_PrixVen;
                                puTTC = puHT * (taux1 + taux2 + taux3 + 100) / 100;
                            }
                            else
                            {
                                puTTC = (decimal)artClient.AC_PrixVen;
                                puHT = 100 * puTTC / (100 + taux1 + taux2 + taux3);
                            }
                        }
                        else
                        {
                            bool prixVenteArtEstHorsTaxe = articleSaisie.AR_PrixTTC == 0 ? true : false;
                            if (prixVenteArtEstHorsTaxe)
                            {
                                puHT = (decimal)articleSaisie.AR_PrixVen;
                                puTTC = puHT * (taux1 + taux2 + taux3 + 100) / 100;
                            }
                            else
                            {
                                puTTC = (decimal)articleSaisie.AR_PrixVen;
                                puHT = 100 * puTTC / (100 + taux1 + taux2 + taux3);
                            }
                        }
                    }
                    else // Prix de l'article spécifique à un client n'existe pas
                    {
                        estHorsTaxe = articleSaisie.AR_PrixTTC == 0 ? true : false;
                        if (estHorsTaxe)
                        {
                            puHT = (decimal)articleSaisie.AR_PrixVen;
                            puTTC = puHT * (taux1 + taux2 + taux3 + 100) / 100;
                        }
                        else
                        {
                            puTTC = (decimal)articleSaisie.AR_PrixVen;
                            puHT = 100 * puTTC / (100 + taux1 + taux2 + taux3);
                        }
                    }
                    AjouterPrix(articleSaisie.AR_Ref, articleSaisie.AR_Design, puHT, puTTC, articleSaisie.AR_Condition == 0 ? "Pièce" : "Unité");
                    MettreAJourMontants();
                }
                else
                {
                    ListeArticles articleARechercher = new ListeArticles(codeFamilleOuDesignation, false, true, null, pourcentageRemise);
                    articleARechercher.ShowDialog(this);
                }
            }
        }




        // ============================================================================= COMPORTEMENTS DE TEXTBOX ================================================================================
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }




        // =============================================================================== SUPPRESSION DOCLIGNE ==================================================================================
        private void BouttonSupprimerDesignation_Click(object sender, EventArgs e)
        {
            int? DL_Ligne = Convert.ToInt32(DataGridViewArticle.Rows[changedIndex].Cells[0].Value);
            string arRef = TextBoxReference.Text;
            int? dl_Ligne = Convert.ToInt32(DataGridViewArticle.Rows[changedIndex].Cells[0].Value);
            int? DE_No = _context.F_DOCLIGNE.Where(dl => dl.DO_Piece == _currentDocPieceNo && dl.AR_Ref == arRef && dl.DL_Ligne == dl_Ligne).Select(dl => dl.DE_No).FirstOrDefault();
            int? DP_No = _f_DEPOTRepository.GetDP_NoPrincipal(arRef, DE_No);
            decimal? DL_MontantHT = Convert.ToDecimal(DataGridViewArticle.Rows[changedIndex].Cells[9].Value);
            int qteArt = Convert.ToInt32(DataGridViewArticle.Rows[changedIndex].Cells[5].Value);

            DialogResult result = MessageBox.Show("Confirmez-vous la suppression de cette ligne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // MISE A JOUR DES AFFICHAGES
                if (DataGridViewArticle.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridViewArticle.SelectedRows[0];
                    decimal? prixTotalHT = lblPrixTotHT.Text == " - " ? 0 : Convert.ToDecimal(lblPrixTotHT.Text);

                    lblPrixTotHT.Text = (prixTotalHT - DL_MontantHT ?? 0).ToString();
                    DataGridViewArticle.Rows.Remove(selectedRow);
                    MettreAJourPoids();
                }
                TextBoxReference.Focus();


                // TODO: SUPPRESSION DOCLIGNE DANS LA BASE
                _f_DOCLIGNEEMPLRepository.DeleteF_DOCLIGNEEMPL(_currentDocPieceNo, dl_Ligne);

                _f_ARTSTOCKEMPLService.UpdateArtstockEmpl(_typeDocument , _currentDocPieceNo, dl_Ligne, arRef, qteArt, 0, DE_No);

                _f_DOCLIGNEService.DeleteF_DOCLIGNE(_currentDocPieceNo, DL_Ligne);

                _f_DOCENTETEService.UpdateDO_TotalHTAfterDelete(_currentDocPieceNo, DL_MontantHT);

                _f_ARTSTOCKService.UpdateMontantEtQuantiteStock(_typeDocument, arRef, 0, qteArt, DE_No);

                // Réinitialisation des champs de saisie (TextBox choix et paramétrage des articles)
                foreach (Control control in tableLayoutPanel2.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Text = textBox.Tag.ToString();
                    }
                }

                if (DataGridViewArticle.Rows.Count < 1)
                    comboBoxDepot.Enabled = true;
                else
                    comboBoxDepot.Enabled = false;
            }
        }




        // =========================================================================== AJOUT D'UNE LIGNE DE DOCUMENT =============================================================================
        private void BouttonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            string arRef = TextBoxReference.Text;
            string CT_NumClient = _listeClients[comboBoxClient.SelectedIndex].CT_Num;
            F_ARTSTOCK articleBaseDeDonnees = null;
            int? DE_No = 1;
            int? dl_Ligne = 0;
            int previousQuantite = 0;
            int? DP_NoSelectedRowDOCLIGNEPrincipal;
            if (changedIndex >= 0)
            {
                previousQuantite = Convert.ToInt32(DataGridViewArticle.Rows[changedIndex].Cells[5].Value);
                dl_Ligne = Convert.ToInt32(DataGridViewArticle.Rows[changedIndex].Cells[0].Value);
                DE_No = _context.F_DOCLIGNE.Where(dl => dl.CT_Num == CT_NumClient && dl.AR_Ref == arRef && dl.DL_Ligne == dl_Ligne).Select(dl => dl.DE_No).FirstOrDefault();
                DP_NoSelectedRowDOCLIGNEPrincipal = _f_DEPOTRepository.GetDP_NoPrincipal(arRef, DE_No);
                articleBaseDeDonnees = _context.F_ARTSTOCK.FirstOrDefault(a => a.AR_Ref == TextBoxReference.Text && a.DP_NoPrincipal == DP_NoSelectedRowDOCLIGNEPrincipal);
            } else
            {
                DE_No = comboBoxDepot.SelectedIndex + 1;
                DP_NoSelectedRowDOCLIGNEPrincipal = _f_DEPOTRepository.GetDP_NoPrincipal(arRef, DE_No);
                articleBaseDeDonnees = _context.F_ARTSTOCK.Where(a => a.AR_Ref == TextBoxReference.Text && a.DP_NoPrincipal == DP_NoSelectedRowDOCLIGNEPrincipal).FirstOrDefault();
            }

            if (articleBaseDeDonnees != null)
            {
                decimal quantiteEnStock = (decimal)articleBaseDeDonnees.AS_QteSto + previousQuantite - (decimal)articleBaseDeDonnees.AS_QteRes;

                if (Convert.ToInt32(txtBxQuantite.Text) <= quantiteEnStock)
                {
                    if (string.IsNullOrWhiteSpace(TextBoxReference.Text) || string.IsNullOrWhiteSpace(TextBoxDesignation.Text) || string.IsNullOrWhiteSpace(TextBoxPUHT.Text) || string.IsNullOrWhiteSpace(TextBoxPUTTC.Text) || string.IsNullOrWhiteSpace(txtBxQuantite.Text) || string.IsNullOrWhiteSpace(TextBoxConditionnement.Text) || string.IsNullOrWhiteSpace(TextBoxMontantHT.Text) || string.IsNullOrWhiteSpace(TextBoxMontantTTC.Text))
                    {
                        MessageBox.Show("Veuillez remplir tous les champs.");
                        return;
                    }
                    else if (Convert.ToDecimal(txtBxQuantite.Text) <= 0)
                    {
                        MessageBox.Show("La quantité ne doit pas être nulle ou négatif, rectifiez!");
                        return;
                    }

                    string arDesign = TextBoxDesignation.Text;
                    string conditionnement = TextBoxConditionnement.Text;
                    int quantiteEcriteStock = int.Parse(txtBxQuantite.Text);
                    decimal puHT = Convert.ToDecimal(TextBoxPUNet?.Text ?? "0");
                    decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text ?? "0");
                    decimal puNet = Convert.ToDecimal(TextBoxPUHT.Text ?? "0");
                    decimal montantHT = Convert.ToDecimal(TextBoxMontantHT.Text ?? "0");
                    decimal montantTTC = Convert.ToDecimal(TextBoxMontantTTC.Text ?? "0");

                    // Get all properties du docligne
                    F_DOCENTETE docEnCours = _f_DOCENTETERepository.GetBy_DO_Piece(_currentDocPieceNo);
                    F_ARTICLE articleChoisi = _listeArticle.Where(a => a.AR_Ref == TextBoxReference.Text).FirstOrDefault();
                    F_COLLABORATEUR collab = _listeCollaborateurs.Where(c => c.CO_Nom + " " + c.CO_Prenom == comboBoxRepresentant.Text).FirstOrDefault();
                    F_ARTFOURNISS fournisseur = _f_ARTFOURNISSService.GetByARRefAndPrincipal(articleChoisi.AR_Ref);

                    DateTime DO_Date = dateTimePicker1.Value;
                    DateTime DO_DateLivr = dateTimePicker2.Value;
                    DateTime dateTimePicker3Value = dateTimePicker3.Value;

                    // CAS : CREATION D'UN NOUVEAU DOCLIGNE (AJOUT) =======================================================================================================
                    if (changedIndex == -1)
                    {
                        // Mise à jour affichage
                        int? maxValueDL_Ligne = 0;
                        foreach (DataGridViewRow row in DataGridViewArticle.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) > maxValueDL_Ligne)
                                maxValueDL_Ligne = Convert.ToInt32(row.Cells[0].Value);
                        }
                        int? numeroLigneDL_Ligne = maxValueDL_Ligne + 1000;

                        DataGridViewArticle.Rows.Add(numeroLigneDL_Ligne, arRef, arDesign, puHT, puTTC, quantiteEcriteStock, conditionnement, txtBxRemise.Text, puNet, montantHT, montantTTC);

                        short typeDoc = (short)_f_DOCENTETEService.GetDocTypeNo(_typeDocument);
                        short DL_NoRef = (short)(DataGridViewArticle.Rows.Count + 1);
                        decimal DL_PUTTC = Convert.ToDecimal(TextBoxPUTTC.Text ?? "0");
                        string AR_RefF_DOCLIGNE = TextBoxReference.Text;
                        string DL_DesignF_DOCLIGNE = TextBoxDesignation.Text;
                        string txtBxQuantiteText = txtBxQuantite.Text;
                        string txtBxRemiseText = txtBxRemise.Text;
                        string TextBoxPUNetText = TextBoxPUNet.Text;
                        string CA_NumText = comboBoxAffaire.Text;
                        string TextBoxMontantTTCText = TextBoxMontantTTC.Text;
                        string TextBoxMontantHTText = TextBoxMontantHT.Text;

                        _f_DOCLIGNEService.AjouterF_DOCLIGNE(mainForm, typeDoc, CT_NumClient, _currentDocPieceNo, DO_Date, numeroLigneDL_Ligne, docEnCours, arRef, DL_DesignF_DOCLIGNE, Convert.ToInt32(txtBxQuantiteText), _typeDocument, articleChoisi, txtBxQuantiteText, txtBxRemiseText, TextBoxPUNetText, collab, DL_NoRef, DL_PUTTC, DO_DateLivr, CA_NumText, TextBoxMontantTTCText, TextBoxMontantHTText, dateTimePicker3Value, DE_No);


                        // Update DO_TotalHT dans F_DOCENTETE (Document en cours)
                        decimal montantTotalHT = 0;
                        foreach (DataGridViewRow row in DataGridViewArticle.Rows)
                        {
                            if (row.Cells[8].Value != null)
                            {
                                montantTotalHT += Convert.ToDecimal(row.Cells[8].Value);
                            }
                        }
                        _f_DOCENTETEService.UpdateDO_Totaux_HT_Net_TTC(_currentDocPieceNo, puNet, quantiteEcriteStock, 0);


                        // Mise à jour F_ARTSTOCK
                        _f_ARTSTOCKService.UpdateMontantEtQuantiteStock(_typeDocument, arRef, quantiteEcriteStock, previousQuantite, DE_No);

                        // Mise à jour F_ARTSTOCKEMPL
                        _f_ARTSTOCKEMPLService.UpdateArtstockEmpl(_typeDocument, CT_NumClient, numeroLigneDL_Ligne, arRef, previousQuantite, quantiteEcriteStock, DE_No);

                        // Insertion F_DOCLIGNEEMPL
                        _f_DOCLIGNEEMPLRepository.InsertDOCLIGNEEMPL((int)DP_NoSelectedRowDOCLIGNEPrincipal, Convert.ToInt32(txtBxQuantiteText), arRef);
                    }


                    // CAS : MISE A JOUR D'UN DOCLIGNE EXISTANT ===========================================================================================================
                    else
                    {
                        if (Convert.ToInt32( DataGridViewArticle.Rows[changedIndex].Cells[5].Value) != Convert.ToInt32(txtBxQuantite.Text) || Convert.ToDecimal(DataGridViewArticle.Rows[changedIndex].Cells[7].Value) != Convert.ToDecimal(txtBxRemise.Text))
                        {
                            // Récupération des valeurs avant modifications
                            int previousQuantiteEcriteStock = Convert.ToInt32(DataGridViewArticle.Rows[changedIndex].Cells[5].Value);
                            decimal previousMontantHT = Convert.ToDecimal(DataGridViewArticle.Rows[changedIndex].Cells[9].Value);

                            // Mise à jour affichage
                            DataGridViewArticle.Rows[changedIndex].Cells[1].Value = arRef;
                            DataGridViewArticle.Rows[changedIndex].Cells[2].Value = arDesign;
                            DataGridViewArticle.Rows[changedIndex].Cells[3].Value = puHT;
                            DataGridViewArticle.Rows[changedIndex].Cells[4].Value = puTTC;
                            DataGridViewArticle.Rows[changedIndex].Cells[5].Value = quantiteEcriteStock;
                            DataGridViewArticle.Rows[changedIndex].Cells[6].Value = conditionnement;
                            DataGridViewArticle.Rows[changedIndex].Cells[7].Value = txtBxRemise.Text;
                            DataGridViewArticle.Rows[changedIndex].Cells[8].Value = puNet;
                            DataGridViewArticle.Rows[changedIndex].Cells[9].Value = montantHT;
                            DataGridViewArticle.Rows[changedIndex].Cells[10].Value = montantTTC;

                            string ct_Num = comboBoxClient.Text.Split('-')[0].Trim();

                            // MISE A JOUR DES DONNEES DANS LA BASE

                            // Mise à jour de l'en-tête du document F_DOCENTETE
                            _f_DOCENTETEService.UpdateDO_Totaux_HT_Net_TTC(_currentDocPieceNo, puNet, quantiteEcriteStock, previousMontantHT);

                            // Mise à jour du stock des articles (F_ARTSTOCK) (Montant du stock et quantité en stock)
                            _f_ARTSTOCKService.UpdateMontantEtQuantiteStock(_typeDocument, arRef, quantiteEcriteStock, previousQuantiteEcriteStock, DE_No);

                            // Mise à jour du ligne de document (F_DOCLIGNE) (Mise à jour des quantités, des poids et des prix (PrixRU et CMUP))
                            _f_DOCLIGNEService.UpdateF_DOCLIGNE(_currentDocPieceNo, arRef, dl_Ligne, quantiteEcriteStock, _typeDocument);

                            // Mise à jour du stock de l'article dans un emplacement concerné
                            _f_ARTSTOCKEMPLService.UpdateArtstockEmpl(_typeDocument, ct_Num, dl_Ligne, arRef, previousQuantiteEcriteStock, quantiteEcriteStock, DE_No);

                            // Mise à jour de la quantité prise dans l'emplacement concerné (DL_Qte)
                            _f_DOCLIGNEEMPLRepository.UpdateDL_Qte(_typeDocument, _currentDocPieceNo, dl_Ligne, quantiteEcriteStock);
                        }
                    }

                    // Mise à jour des poids totaux (poids brut et net totaux)
                    MettreAJourPoids();

                    // Mise à jour des montants totaux (montant HT et TTC totaux)
                    _totalPrixHT += montantHT;
                    _totalPrixTTC += montantTTC;
                    lblPrixTotHT.Text = _totalPrixHT.ToString("N2");

                    foreach (Control control in tableLayoutPanel2.Controls)
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.Text = textBox.Tag.ToString();
                        }
                    }
                    
                    // Gestion du comportement du combobox Dépôt
                    if (DataGridViewArticle.Rows.Count < 1)
                        comboBoxDepot.Enabled = true;
                    else
                        comboBoxDepot.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Stock insuffisant!");
                    ControlTableLayoutPanel();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs prérequis");
                ControlTableLayoutPanel();
                TextBoxReference.Focus();
            }

            TextBoxReference.Focus();
        }




        // =========================================================================== CHANGEMENT QUANTITE ARTICLE ===============================================================================
        private void txtBxQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permet seulement les chiffres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Empêche l'entrée du "0" comme premier caractère
            if (txtBxQuantite.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }




        // =========================================================================== CHANGEMENT QUANTITE ARTICLE ===============================================================================
        private void txtBxQuantite_TextChanged(object sender, EventArgs e)
        {
            // Vérifie que la valeur est non nulle
            if (int.TryParse(txtBxQuantite.Text, out int value))
            {
                if (value <= 0)
                {
                    MessageBox.Show("Veuillez entrer une valeur numérique non nulle.");
                    textBoxNDoc.Clear();
                }
                else
                {
                    MettreAJourMontants();
                }
            }
        }




        // ============================================================================= CHANGEMENT VALEUR REMISE ================================================================================
        private void txtBxRemise_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permet seulement les chiffres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Empêche l'entrée du "0" comme premier caractère
            if (txtBxRemise.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }




        // ============================================================================= CHANGEMENT VALEUR REMISE ================================================================================
        private void txtBxRemise_TextChanged(object sender, EventArgs e)
        {
            string cultureName = "en-EN"; // Exemple pour la culture française
            CultureInfo culture = new CultureInfo(cultureName);
            if (decimal.TryParse(txtBxRemise.Text, NumberStyles.Number, culture, out pourcentageRemise))
            {
                if (pourcentageRemise < 0)
                {
                    MessageBox.Show("Les valeurs négatives ne sont pas valides.");
                    textBoxNDoc.Clear();
                }
                else
                {
                    MettreAJourMontants();
                }
            }
        }




        // =========================================================== Modification de l'élément (ligne) sélectionné dans le DataGridView =========================================================
        private void BouttonNouveauDesignation_Click(object sender, EventArgs e)
        {
            changedIndex = -1;

            // Réinitialisation des champs de texte
            TextBoxReference.Text = "";
            TextBoxDesignation.Text = "";
            TextBoxPUHT.Text = "";
            TextBoxPUTTC.Text = "";
            txtBxQuantite.Text = "";
            TextBoxConditionnement.Text = "";
            txtBxRemise.Text = "";
            TextBoxPUNet.Text = "";
            TextBoxMontantHT.Text = "";
            TextBoxMontantTTC.Text = "";

            TextBoxReference.Enabled = true;
            txtBxQuantite.Enabled = true;
            txtBxRemise.Enabled = true;

            BouttonSupprimerDesignation.Enabled = false;
        }




        // ===================================================================== Changement de la ligne de document sélectionné =====================================================================
        private void DataGridViewArticle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewArticle.Rows.Count < 1)
            {
                changedIndex = -1;

                // Réinitialisation des champs de texte
                TextBoxReference.Text = "";
                TextBoxDesignation.Text = "";
                TextBoxPUHT.Text = "";
                TextBoxPUTTC.Text = "";
                txtBxQuantite.Text = "";
                TextBoxConditionnement.Text = "";
                txtBxRemise.Text = "";
                TextBoxPUNet.Text = "";
                TextBoxMontantHT.Text = "";
                TextBoxMontantTTC.Text = "";

                TextBoxReference.Enabled = true;

                BouttonSupprimerDesignation.Enabled = false;
            }
            else
            {
                int selectedRowIndex = DataGridViewArticle.SelectedRows[0].Index;
                changedIndex = selectedRowIndex;
                int? DL_Ligne = Convert.ToInt32(DataGridViewArticle.Rows[selectedRowIndex].Cells[0].Value);

                // Récupération et affichage des données
                TextBoxReference.Text = DataGridViewArticle.Rows[selectedRowIndex].Cells[1].Value.ToString();
                TextBoxDesignation.Text = DataGridViewArticle.Rows[selectedRowIndex].Cells[2].Value.ToString();
                TextBoxPUTTC.Text = Convert.ToDecimal(DataGridViewArticle.Rows[selectedRowIndex].Cells[4].Value).ToString();
                TextBoxConditionnement.Text = DataGridViewArticle.Rows[selectedRowIndex].Cells[6].Value.ToString();
                TextBoxPUNet.Text = Convert.ToDecimal(DataGridViewArticle.Rows[selectedRowIndex].Cells[8].Value).ToString();
                TextBoxPUHT.Text = Convert.ToDecimal(DataGridViewArticle.Rows[selectedRowIndex].Cells[3].Value).ToString();
                TextBoxMontantTTC.Text = Convert.ToDecimal(DataGridViewArticle.Rows[selectedRowIndex].Cells[10].Value).ToString();
                TextBoxMontantHT.Text = Convert.ToDecimal(DataGridViewArticle.Rows[selectedRowIndex].Cells[9].Value).ToString();
                txtBxQuantite.Text = Convert.ToInt32(DataGridViewArticle.Rows[selectedRowIndex].Cells[5].Value).ToString();
                txtBxRemise.Text = DataGridViewArticle.Rows[selectedRowIndex].Cells[7].Value.ToString() == "" ? "0" : Convert.ToDecimal(DataGridViewArticle.Rows[selectedRowIndex].Cells[7].Value).ToString();

                // Activation et desactivation des champs (Enable/Disable)
                tableLayoutPanel2.Enabled = true;
                TextBoxReference.Enabled = false;
                TextBoxDesignation.Enabled = false;
                TextBoxPUHT.Enabled = false;
                TextBoxPUTTC.Enabled = false;
                TextBoxConditionnement.Enabled = false;
                TextBoxPUNet.Enabled = false;
                TextBoxMontantHT.Enabled = false;
                TextBoxMontantTTC.Enabled = false;

                BouttonNouveauDesignation.Enabled = true;
                BouttonSupprimerDesignation.Enabled = true;
                BouttonEnregistrerDesignation.Enabled = true;
            }
        }




        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Confirmez-vous la validation de document ? Les documents validés ne seront plus modifiables!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                _f_DOCENTETERepository.ValiderDocument(_fDocenteteToModif.DO_Piece, 1);
                MessageBox.Show("Validation du document effectuée!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Désactivation de certains éléments lorsque le document est déjà validé
                btnValider.Enabled = false;
                TextBoxReference.Enabled = false;
                comboBoxRepresentant.Enabled = false;
                comboBoxExpedit.Enabled = false;
                
                BouttonEnregistrerDesignation.Enabled = false;
                BouttonSupprimerDesignation.Enabled = false;
                BouttonNouveauDesignation.Enabled = false;
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            string f_CAISSEIntitule = _context.F_CAISSE.Where(c => c.CA_No == mainForm.CaisseNo).Select(c => c.CA_Intitule).FirstOrDefault();
            string p_DEVISEIntitule = _context.P_DEVISE.Where(d => d.cbMarq == _fDocenteteToModif.DO_Devise).Select(d => d.D_Intitule).FirstOrDefault();

            List<Fligne> fligne = new List<Fligne>();

            foreach (DataGridViewRow ligne in DataGridViewArticle.Rows)
            {
                fligne.Add(new Fligne()
                {
                    reference = ligne.Cells[1].FormattedValue.ToString(),
                    designation = ligne.Cells[2].FormattedValue.ToString(),
                    montant_ht = double.Parse(ligne.Cells[9].FormattedValue.ToString()),
                    prix_unitaire = double.Parse(ligne.Cells[8].FormattedValue.ToString()),
                    quantite = double.Parse(ligne.Cells[5].FormattedValue.ToString()),
                    remise = string.IsNullOrEmpty(ligne.Cells[7].Value.ToString()) ? "0%" : ligne.Cells[6].Value.ToString() + "%"
                });
            }

            List<ListeEcheancesPourImpressionDocumentsDeVente> listeEcheancesPourImpressionDocumentsDeVentes = _listeEcheancesPourImpressionDocumentsDeVenteRepository.ListerEcheancesImpressionDocVente(_fDocenteteToModif.CT_NumPayeur, _fDocenteteToModif.DO_Piece);

            Reporting report = new Reporting(_typeDocument, f_CAISSEIntitule, (DateTime)_fDocenteteToModif.DO_Date, _fDocenteteToModif.DO_Piece, _fDocenteteToModif.DO_Devise == 0 ? " - " : p_DEVISEIntitule, (decimal)_fDocenteteToModif.DO_TotalHT, (decimal)_fDocenteteToModif.DO_TotalTTC, fligne, listeEcheancesPourImpressionDocumentsDeVentes);
            report.BringToFront();
            report.Show();
            report.Focus();

        }

        // =======================================================================================================================================================================================
        // =================================================================================== FIN EVENEMENTS ====================================================================================
        // =======================================================================================================================================================================================
    }
}
