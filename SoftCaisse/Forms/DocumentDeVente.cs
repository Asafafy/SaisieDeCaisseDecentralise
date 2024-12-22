using ComponentFactory.Krypton.Toolkit;
using Objets100cLib;
using SoftCaisse.Forms.Article;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using SoftCaisse.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class DocumentDeVente : KryptonForm
    {
        MainForm mainForm;

        private readonly F_DOCLIGNEService f_DOCLIGNEService;
        private readonly F_ARTFOURNISSService f_ARTFOURNISSService;

        private readonly F_DOCREGLRepository _f_DOCREGLRepository;
        private readonly F_DOCLIGNERepository _f_DOCLIGNERepository;
        private readonly F_DOCENTETERepository _f_DOCENTETERepository;

        private readonly AppDbContext _context;
        private readonly SageContexte _sageContextObjMetier;

        private readonly List<F_COMPTET> _listeClients;
        private readonly List<F_DOCENTETE> _listeDocuments;
        private readonly List<F_DOCREGL> _listeDocRegl;
        private readonly List<F_LIVRAISON> _listeLivraisons;
        private readonly List<F_ARTICLE> _listeArticle;
        private readonly List<F_COLLABORATEUR> _listeCollaborateurs;

        List<F_COLLABORATEUR> listeCollab;
        List<F_COMPTEA> listePlanAnalitique;
        List<Fligne> fligne;

        private readonly string _typeDocument;
        private readonly string _currentDocPieceNo;
        private decimal pourcentageRemise;
        private int changedIndex = -1;
        private decimal _totalPrixHT;
        private decimal _totalPrixTTC;





        // ================================================ DEBUT CONSTRUCTEUR ================================================
        // ====================================================================================================================
        public DocumentDeVente(string typeDocument, MainForm form, F_DOCENTETE fDocenteteToModif)
        {
            InitializeComponent();

            _context = new AppDbContext();
            _sageContextObjMetier = new SageContexte();

            _f_DOCREGLRepository = new F_DOCREGLRepository(_context);
            _f_DOCENTETERepository = new F_DOCENTETERepository(_context);
            _f_DOCLIGNERepository = new F_DOCLIGNERepository(_context);
            f_DOCLIGNEService = new F_DOCLIGNEService(_f_DOCLIGNERepository);
            F_ARTFOURNISSRepository f_ARTFOURNISSRepository = new F_ARTFOURNISSRepository(_context);
            f_ARTFOURNISSService = new F_ARTFOURNISSService(f_ARTFOURNISSRepository);

            _typeDocument = typeDocument;
            mainForm = form;

            _listeDocuments = _context.F_DOCENTETE.ToList();
            _listeClients = _context.F_COMPTET.Where(c => c.CT_Type == 0).ToList();
            _listeDocRegl = _context.F_DOCREGL.ToList();
            _listeLivraisons = _context.F_LIVRAISON.ToList();
            _listeArticle = _context.F_ARTICLE.ToList();
            _listeCollaborateurs = _context.F_COLLABORATEUR.ToList();

            _currentDocPieceNo = GetCurrentDocNumber(typeDocument, _listeDocuments);

            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(tableLayoutPanel5, 30);

            listePlanAnalitique = _context.F_COMPTEA.ToList();
            List<P_EXPEDITION> listeExpedit = _context.P_EXPEDITION.ToList();
            listeCollab = _context.F_COLLABORATEUR.ToList();

            textBoxNDoc.Text = _currentDocPieceNo;
            textBoxNDoc.Enabled = false;

            comboBoxClient.DataSource = _listeClients.Select(c => c.CT_Num + " - " + c.CT_Intitule).ToList();
            comboBoxClient.SelectedIndex = -1;
            if (typeDocument != "Facture comptabilisée")
            {
                comboBoxStatus.Text = "A comptabiliser";
            }
            else
            {
                comboBoxStatus.Text = "Comptabilisée";
            }
            comboBoxAffaire.DataSource = listePlanAnalitique.Where(p => p.N_Analytique == 3).Select(p => p.CA_Num + " - " + p.CA_Intitule).ToList();
            comboBoxAffaire.SelectedIndex = -1;
            comboBoxExpedit.DataSource = listeExpedit.Select(ex => ex.E_Intitule).ToList();
            comboBoxRepresentant.DataSource = listeCollab.Where(c => c.CO_Vendeur == 1).Select(c => c.CO_Nom + " - " + c.CO_Prenom).ToList();
            comboBoxRepresentant.SelectedIndex = -1;

            // Désactiver les boutons (Valider, OK, Nouveau) et les champs de saisie des articles (F_DOCLIGNES)
            tableLayoutPanel2.Enabled = false;
            BouttonNouveauDesignation.Enabled = false;
            BouttonSupprimerDesignation.Enabled = false;
            BouttonEnregistrerDesignation.Enabled = false;

            kptnBtnValider.Enabled = false;

            btnOk.Enabled = false;

            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is TextBox)
                {
                    control.Enter += TextBox_Enter;
                    control.Leave += TextBox_Leave;
                    control.Tag = control.Text;
                }
            }

            if (fDocenteteToModif != null)
            {
                // ========================= Affichage des informations concernant le F_DOCENTETE (Document de vente à mettre à jour) =========================
                F_COMPTET clientTiers = _listeClients.Where(cl => cl.CT_Num == fDocenteteToModif.DO_Tiers).FirstOrDefault();
                comboBoxClient.SelectedIndex = _listeClients.IndexOf(clientTiers);
                dateTimePicker1.Value = (DateTime)fDocenteteToModif.DO_Date;
                if (fDocenteteToModif.DO_DateLivr != new DateTime(1753, 01, 01, 00, 00, 00))
                {
                    dateTimePicker2.Value = (DateTime)fDocenteteToModif.DO_DateLivr;
                }
                if (fDocenteteToModif.DO_DateLivrRealisee != new DateTime(1753, 01, 01, 00, 00, 00))
                {
                    dateTimePicker3.Value = (DateTime)fDocenteteToModif.DO_DateLivrRealisee;
                }
                textBoxNDoc.Text = fDocenteteToModif.DO_Piece;
                txtBxRef.Text = fDocenteteToModif.DO_Ref;
                F_COMPTEA planAnal = listePlanAnalitique.Where(pa => pa.CA_Num == fDocenteteToModif.CA_Num).FirstOrDefault();
                List<F_COMPTEA> listePAAffiches = listePlanAnalitique.Where(p => p.N_Analytique == 3).ToList();
                int indexPA = listePAAffiches.IndexOf(planAnal);
                comboBoxAffaire.SelectedIndex = indexPA;
                F_COLLABORATEUR collab = listeCollab.Where(co => co.CO_No == fDocenteteToModif.CO_No).FirstOrDefault();
                List<F_COLLABORATEUR> listeCollaborateursCmbBx = listeCollab.Where(c => c.CO_Vendeur == 1).ToList();
                int indexCollab = listeCollaborateursCmbBx.IndexOf(collab);
                comboBoxRepresentant.SelectedIndex = indexCollab;
                P_EXPEDITION expedit = listeExpedit.Where(exp => exp.cbMarq == fDocenteteToModif.DO_Expedit).FirstOrDefault();
                int indexExpedit = listeExpedit.IndexOf(expedit);
                comboBoxExpedit.SelectedIndex = indexExpedit;
                textBoxEnTete.Text = fDocenteteToModif.DO_Coord01;
                textBoxCommentaires.Text = fDocenteteToModif.Commentaires;
                textBoxDivers.Text = fDocenteteToModif.Divers;

                // ========================= Affichage des F_DOCLIGNES =========================
                List<F_DOCLIGNE> listeDoclignesDocToUpdate = _context.F_DOCLIGNE
                    .Where(dl => dl.DO_Piece == fDocenteteToModif.DO_Piece)
                    .OrderBy(dl => dl.DL_Ligne)
                    .ToList();
                foreach (F_DOCLIGNE fDocligne in listeDoclignesDocToUpdate)
                {
                    decimal? quantite = 0;
                    if (fDocenteteToModif.DO_Type == 0) // Devis
                    {
                        quantite = fDocligne.DL_QteDE;
                    }
                    else if (fDocenteteToModif.DO_Type == 1) // Bon de commande
                    {
                        quantite = fDocligne.DL_QteBC;
                    }
                    else if (fDocenteteToModif.DO_Type == 2) // Préparation de livraison
                    {
                        quantite = fDocligne.DL_QtePL;
                    }
                    else if (fDocenteteToModif.DO_Type == 3) // Bon de livraison
                    {
                        quantite = fDocligne.DL_QteBL;
                    }
                    else
                    {
                        quantite = fDocligne.DL_Qte;
                    }
                    F_ARTICLE article = _context.F_ARTICLE.Where(art => art.AR_Ref == fDocligne.AR_Ref).FirstOrDefault();
                    string conditionnementLigne = article.AR_Condition == 0 ? "Pièce" : "Unité";
                    DataGridViewArticle.Rows.Add(fDocligne.AR_Ref, fDocligne.DL_Design, fDocligne.DL_PrixUnitaire, fDocligne.DL_PUTTC, quantite, conditionnementLigne, fDocligne.DL_Remise01REM_Valeur, fDocligne.DL_PrixUnitaire, fDocligne.DL_MontantHT, fDocligne.DL_MontantTTC);
                }

            }
        }
        // ================================================ FIN CONSTRUCTEUR ================================================
        // ==================================================================================================================





        // ================================================ DEBUT FONCTIONS ================================================
        // =================================================================================================================
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

        private short? GetDocLigneDomaine(short docType)
        {
            List<int> typeZero = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            if (typeZero.Contains(docType))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private string FormatPieceNo(int maxNo, string prefixe)
        {
            string doPieceActu;
            if (maxNo <= 9)
            {
                doPieceActu = prefixe + "0000" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 99 && maxNo > 9)
            {
                doPieceActu = prefixe + "000" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 999 && maxNo > 99)
            {
                doPieceActu = prefixe + "00" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 9999 && maxNo > 999)
            {
                doPieceActu = prefixe + "0" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 99999 && maxNo > 9999)
            {
                doPieceActu = prefixe + maxNo.ToString();
                return doPieceActu;
            }
            else
            {
                return null;
            }
        }

        private DocumentType GetDocumentType(string docType)
        {
            if (docType == "Devis")
            {
                return DocumentType.DocumentTypeVenteDevis;
            }
            else if (docType == "Bon de commande")
            {
                return DocumentType.DocumentTypeVenteCommande;
            }
            else if (docType == "Préparation de livraison")
            {
                return DocumentType.DocumentTypeVentePrepaLivraison;
            }
            else if (docType == "Bon de livraison")
            {
                return DocumentType.DocumentTypeVenteLivraison;
            }
            else if (docType == "Bon de retour")
            {
                return DocumentType.DocumentTypeVenteReprise;
            }
            else if (docType == "Bon d'avoir finanicier")
            {
                return DocumentType.DocumentTypeVenteAvoir;
            }
            else if (docType == "Facture")
            {
                return DocumentType.DocumentTypeAchatFacture;
            }
            else if (docType == "Facture de retour")
            {
                return DocumentType.DocumentTypeAchatFacture;
            }
            else if (docType == "Facture d'avoir")
            {
                return DocumentType.DocumentTypeAchatAvoir;
            }
            else
            {
                return DocumentType.DocumentTypeAchatFacture;
            }
        }

        private int? GetDocTypeNo(string docType)
        {
            if (docType == "Devis")
            {
                return 0;
            }
            else if (docType == "Bon de commande")
            {
                return 1;
            }
            else if (docType == "Préparation de livraison")
            {
                return 2;
            }
            else if (docType == "Bon de livraison")
            {
                return 3;
            }
            else if (docType == "Bon de retour")
            {
                return 4;
            }
            else if (docType == "Bon d'avoir finanicier")
            {
                return 5;
            }
            else if (docType == "Facture")
            {
                return 6;
            }
            else if (docType == "Facture comptabilisée")
            {
                return 7;
            }
            else if (docType == "Facture de retour")
            {
                return 16;
            }
            else if (docType == "Facture d'avoir")
            {
                return 19;
            }
            else
            {
                return null;
            }
        }
        private string GetCurrentDocNumber(string docType, List<F_DOCENTETE> listeDocs)
        {
            int maxNumber;
            if (docType == "Devis")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("DE")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "DE");
            }
            else if (docType == "Bon de commande")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BC")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BC");
            }
            else if (docType == "Préparation de livraison")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("PL")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "PL");
            }
            else if (docType == "Bon de livraison")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BL")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BL");
            }
            else if (docType == "Bon de retour")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BR")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BR");
            }
            else if (docType == "Bon d'avoir finanicier")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BA")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BA");
            }
            else if (docType == "Facture")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("FA")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "FA");
            }
            else if (docType == "Facture de retour")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("FR")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "FR");
            }
            else if (docType == "Facture d'avoir")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("FV")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "FV");
            }
            else
            {
                return null;
            }
        }


        private (int transaction, int regime) GetTransacEtRegime(string typeDoc)
        {
            if (typeDoc == "Devis" || typeDoc == "Bon de commande" || typeDoc == "Préparation de livraison" || typeDoc == "Bon de livraison" || typeDoc == "Facture")
            {
                return (11, 21);
            }
            else if (typeDoc == "Bon de retour" || typeDoc == "Bon d'avoir finanicier" || typeDoc == "Facture de retour" || typeDoc == "Facture d'avoir")
            {
                return (21, 25);
            }
            else
            {
                return (0, 0);
            }
        }

        private void MettreAJourF_DOCCURRENTPIECE(string typeDoc, string currentPieceNo)
        {
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBUPD_F_DOCCURRENTPIECE] ON [dbo].[F_DOCCURRENTPIECE]");

            if (typeDoc == "Devis")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 1).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Bon de commande")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 2).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Préparation de livraison")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 3).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Bon de livraison")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 4).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Bon de retour")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 5).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Bon d'avoir finanicier")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 6).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Facture")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 74).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Facture de retour")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 75).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            else if (typeDoc == "Facture d'avoir")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 76).FirstOrDefault();
                if (fDocCurrent.DC_Piece != currentPieceNo)
                {
                    fDocCurrent.DC_Piece = currentPieceNo;
                    fDocCurrent.cbModification = DateTime.Now;
                    _context.SaveChanges();
                }
            }

            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBUPD_F_DOCCURRENTPIECE] ON [dbo].[F_DOCCURRENTPIECE]");
        }

        private void InsertNewF_DOCREGL(List<F_DOCREGL> listeDocRegl, string numPieceActu, List<F_COMPTET> listeClients, string typeDocu)
        {
            int? newDrNo = listeDocRegl.Max(element => element.DR_No);
            string CT_NumActu = listeClients[comboBoxClient.SelectedIndex].CT_Num;
            List<F_REGLEMENTT> listeReglT = _context.F_REGLEMENTT.Where(r => r.CT_Num == CT_NumActu).ToList();
            foreach (var reglT in listeReglT)
            {
                DateTime date = DateTime.Now.AddDays((double)reglT.RT_NbJour);
                if (reglT.RT_Condition == 0)
                {
                    List<short?> joursTb = new List<short?>
                    {
                        reglT.RT_JourTb01,
                        reglT.RT_JourTb02,
                        reglT.RT_JourTb03,
                        reglT.RT_JourTb04,
                        reglT.RT_JourTb05,
                        reglT.RT_JourTb06
                    };
                    joursTb.RemoveAll(x => x == 0);
                    if (joursTb.Count > 0)
                    {
                        int? nextDay = joursTb.Where(d => d >= date.Day).OrderBy(d => d).FirstOrDefault();
                        if (!nextDay.HasValue)
                            nextDay = joursTb.FirstOrDefault();
                        date = new DateTime(date.Year, date.Month, (int)nextDay);
                    }
                }
                else if (reglT.RT_Condition == 1)
                {
                    date = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                    // Si le dernier jour du mois est un samedi, revenir au vendredi
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        date.AddDays(-1);
                    }
                    // Si le dernier jour du mois est un dimanche, revenir au vendredi
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        date.AddDays(-2);
                    }
                }
                else
                {
                    date = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                }
                newDrNo++;
                F_DOCREGL newDocRegl = new F_DOCREGL
                {
                    DR_No = newDrNo,
                    DO_Domaine = 0,
                    DO_Type = 6,
                    DO_Piece = numPieceActu,
                    DR_TypeRegl = 2,
                    DR_Date = date,
                    DR_Libelle = "",
                    DR_Pourcent = reglT.RT_VRepart,
                    DR_Montant = 0,
                    DR_MontantDev = 0,
                    DR_Equil = 1,
                    EC_No = 0,
                    cbEC_No = 0,
                    DR_Regle = 0,
                    N_Reglement = 1,
                    CA_No = 3,
                    DO_DocType = (short?)GetDocTypeNo(typeDocu),
                    cbCreateur = "COLS",
                    DR_RefPaiement = null,
                    DR_AdressePaiement = "",
                };
                _f_DOCREGLRepository.Add(newDocRegl);
            }
        }

        private void InsertNewF_DOCENTETE(string typeDoc, string noPiece, List<F_COMPTET> listeClients, List<F_LIVRAISON> listeLivr, short? numExpedit, string caNum, int numCaisse, int numCaissier, string expeditInt, DateTime dateLivrRealise, string refer)
        {
            // Get properties (Recherche des propriétés manquantes)
            DateTime dateLivrPrev = dateTimePicker2.Value;
            DateTime dateLivrReal = dateTimePicker3.Value;
            DocumentType typeDocument = GetDocumentType(typeDoc);
            F_COMPTET client = listeClients[comboBoxClient.SelectedIndex];
            F_LIVRAISON lieuLivrPrinc = listeLivr.Where(l => l.CT_Num == client.CT_Num && l.LI_Principal == 1).FirstOrDefault();
            F_COLLABORATEUR collab = listeCollab.Where(coll => coll.CO_No == mainForm.CaissierCollabNo).FirstOrDefault();
            string referenceDoc = txtBxRef.Text;
            P_EXPEDITION expedit = _context.P_EXPEDITION.Where(exp => exp.E_Intitule == expeditInt).FirstOrDefault();
            (int, int) tupleTransactionRegime = GetTransacEtRegime(typeDoc);
            int? typeNo = GetDocTypeNo(typeDoc);
            DateTime now = DateTime.Now;
            string heureNow = "000" + now.Hour + now.Minute + now.Second;

            // OPTION NOUVEAU DOCUMENT DE VENTE AVEC SQL QUERY
            F_DOCENTETE newDocEnTete = new F_DOCENTETE
            {
                DO_Domaine = 0,
                DO_Type = (short)typeNo,
                DO_Piece = noPiece,
                DO_Date = DateTime.Now,
                DO_Ref = refer,
                DO_Tiers = client.CT_Num,
                CO_No = client.CO_No,
                cbCO_No = client.CO_No,
                DO_Period = 1,
                DO_Devise = 0,
                DO_Cours = 0,
                DE_No = 1,
                cbDE_No = 1,
                LI_No = lieuLivrPrinc == null ? 0 : lieuLivrPrinc.LI_No,
                cbLI_No = lieuLivrPrinc == null ? 0 : lieuLivrPrinc.LI_No,
                CT_NumPayeur = client.CT_NumPayeur,
                DO_Expedit = numExpedit,
                DO_NbFacture = 1,
                DO_BLFact = 0,
                DO_TxEscompte = client.CT_Taux02,
                DO_Reliquat = 0,
                DO_Imprim = 0,
                CA_Num = caNum,
                DO_Coord01 = textBoxEnTete.Text,
                DO_Coord02 = "",
                DO_Coord03 = "",
                DO_Coord04 = "",
                DO_Souche = 0,
                DO_DateLivr = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_Condition = 1,
                DO_Tarif = 1,
                DO_Colisage = 1,
                DO_TypeColis = 1,
                DO_Transaction = (short?)tupleTransactionRegime.Item1,
                DO_Langue = 0,
                DO_Ecart = 0,
                DO_Regime = (short?)tupleTransactionRegime.Item2,
                N_CatCompta = 1,
                DO_Ventile = 0,
                AB_No = 0,
                DO_DebutAbo = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_FinAbo = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_DebutPeriod = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_FinPeriod = new DateTime(1753, 01, 01, 00, 00, 00),
                CG_Num = "4110000",
                DO_Statut = 2,
                DO_Heure = heureNow,
                CA_No = numCaisse,
                cbCA_No = numCaisse,
                CO_NoCaissier = numCaissier,
                cbCO_NoCaissier = numCaissier,
                DO_Transfere = 0,
                DO_Cloture = 0,
                DO_NoWeb = "",
                DO_Attente = 0,
                DO_Provenance = 0,
                MR_No = 0,
                CA_NumIFRS = "",
                DO_TypeFrais = 0,
                DO_ValFrais = expedit.E_ValFrais,
                DO_TypeLigneFrais = 0,
                DO_TypeFranco = 0,
                DO_ValFranco = expedit.E_ValFranco,
                DO_TypeLigneFranco = 0,
                DO_Taxe1 = 20,
                DO_TypeTaux1 = 0,
                DO_TypeTaxe1 = 0,
                DO_Taxe2 = 0,
                DO_TypeTaux2 = 0,
                DO_TypeTaxe2 = 0,
                DO_Taxe3 = 0,
                DO_TypeTaux3 = 0,
                DO_TypeTaxe3 = 0,
                DO_MajCpta = 0,
                DO_Motif = "",
                CT_NumCentrale = null,
                DO_Contact = "",
                DO_FactureElec = 0,
                DO_TypeTransac = 0,
                DO_DateLivrRealisee = dateLivrRealise,
                DO_DateExpedition = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_FactureFrs = "",
                DO_PieceOrig = "",
                DO_GUID = null,
                DO_EStatut = 0,
                DO_DemandeRegul = 0,
                ET_No = 0,
                cbET_No = null,
                DO_Valide = 0,
                DO_Coffre = 0,
                DO_CodeTaxe1 = "C20",
                DO_CodeTaxe2 = null,
                DO_CodeTaxe3 = null,
                DO_TotalHT = 0,
                DO_StatutBAP = 0,
                DO_Escompte = 1,
                DO_DocType = 6,
                DO_TypeCalcul = 0,
                DO_FactureFile = null,
                DO_TotalHTNet = 0,
                DO_TotalTTC = 0,
                DO_NetAPayer = 0,
                DO_MontantRegle = 0,
                DO_RefPaiement = null,
                DO_AdressePaiement = "",
                DO_PaiementLigne = 0,
                DO_MotifDevis = 0,
                DO_Conversion = 0,
                cbCreateur = "COLS"
            };

            // Ajout objet dans F_DOCENTETE
            _f_DOCENTETERepository.Add(newDocEnTete);
        }

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

        public void MettreAJourMontants()
        {
            if (txtBxQuantite.Text != "")
            {
                int quantiteArt = Convert.ToInt32(txtBxQuantite.Text);
                decimal? puHT = Convert.ToDecimal(TextBoxPUHT.Text);
                decimal? puTTC = Convert.ToDecimal(TextBoxPUTTC.Text);
                if (TextBoxMontantHT.Text != "")
                {
                    if (!string.IsNullOrEmpty(TextBoxPUHT.Text))
                    {
                        if (!string.IsNullOrEmpty(txtBxRemise.Text))
                        {
                            decimal? remise = Convert.ToDecimal(txtBxRemise.Text);
                            decimal? montantHTSansRemise = quantiteArt * puHT;
                            decimal? valeurRemise = (remise * montantHTSansRemise) / 100;
                            decimal? montantHTAvecRemise = montantHTSansRemise - valeurRemise;
                            TextBoxMontantHT.Text = montantHTAvecRemise.ToString();
                        }
                    }
                }
                if (TextBoxMontantTTC.Text != "")
                {
                    if (!string.IsNullOrEmpty(TextBoxPUTTC.Text))
                    {
                        if (!string.IsNullOrEmpty(txtBxRemise.Text))
                        {
                            decimal? remise = Convert.ToDecimal(txtBxRemise.Text);
                            decimal? montantTTCSansRemise = quantiteArt * puTTC;
                            decimal? valeurRemise = (remise * montantTTCSansRemise) / 100;
                            decimal? montantTTCAvecRemise = montantTTCSansRemise - valeurRemise;
                            TextBoxMontantTTC.Text = montantTTCAvecRemise.ToString();
                        }
                    }
                }
            }
        }

        public void MettreAJourPoids()
        {
            List<string> listeDesChaines = new List<string>();
            decimal? poidsNetTot = 0;
            decimal? poidsBrutTot = 0;

            // Parcourir chaque ligne du DataGridView
            foreach (DataGridViewRow row in DataGridViewArticle.Rows)
            {
                string arRef = row.Cells[0].Value.ToString();
                F_ARTICLE article = _context.F_ARTICLE.Where(art => art.AR_Ref == arRef).FirstOrDefault();
                poidsNetTot = poidsNetTot + article.AR_PoidsNet;
                poidsBrutTot = poidsBrutTot + article.AR_PoidsBrut;
            }

            valPdsNet.Text = poidsNetTot.ToString();
            valPdsBrut.Text = poidsBrutTot.ToString();


        }

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
        // ================================================ FIN FONCTIONS ================================================
        // =================================================================================================================





        // ================================================ DEBUT EVENEMENTS =================================================
        // ===================================================================================================================
        private void kptAnnuler_Click(object sender, System.EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Confirmez vous l'annulation de ce document ?", "Confirmation d'annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultat == DialogResult.Yes)
            {
                Close();
            }
        }

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
                F_COMPTEA compteAnal = listePlanAnalitique.Where(ca => ca.CA_Num == client.CA_Num).FirstOrDefault();
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
                F_COLLABORATEUR collaborateur = listeCollab.Where(collab => collab.CO_No == client.CO_No).FirstOrDefault();
                if (collaborateur == null)
                {
                    comboBoxAffaire.SelectedIndex = -1;
                }
                else
                {
                    int indexCmbBxRepresentant = comboBoxRepresentant.FindStringExact(collaborateur.CO_Nom + " - " + collaborateur.CO_Prenom);
                    comboBoxRepresentant.SelectedIndex = indexCmbBxRepresentant;
                }

                kptnBtnValider.Enabled = true;
            }
        }

        private void kptnBtnValider_Click(object sender, System.EventArgs e)
        {
            short? estBloque = _listeClients.Where(c => c.CT_Num + " - " + c.CT_Intitule == comboBoxClient.Text).Select(c => c.CT_ControlEnc).FirstOrDefault();
            if (estBloque == 2)
            {
                MessageBox.Show("Aucun document ne peut être émis depuis ce client car il est bloqué", "Client bloqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Mise à jour du Doc current pièce (Numéro de pièce actuel)
                MettreAJourF_DOCCURRENTPIECE(_typeDocument, _currentDocPieceNo);

                // Insertion dans F_DOCREGL (Règlement)
                InsertNewF_DOCREGL(_listeDocRegl, _currentDocPieceNo, _listeClients, _typeDocument);

                // Get des propriétés à inserer dans le nouveau DOCENTETE
                int numExpedition = comboBoxExpedit.SelectedIndex + 1;
                string caNum = comboBoxAffaire.Text;
                int indexEspace = caNum.IndexOf(' ');
                if (caNum != "")
                {
                    caNum = caNum.Substring(0, indexEspace);
                }
                int caisseNumber = mainForm.CaisseNo;
                int caissierNumber = mainForm.CaissierCollabNo;
                string reference = txtBxRef.Text;
                string expeditIntitule = comboBoxExpedit.Text;
                DateTime dateLivrReal;
                if (dateTimePicker3.Value == null)
                    dateLivrReal = new DateTime(1753, 01, 01);
                else
                    dateLivrReal = dateTimePicker3.Value;

                // Insertion d'un nouvel objet dans F_DOCENTETE
                InsertNewF_DOCENTETE(_typeDocument, _currentDocPieceNo, _listeClients, _listeLivraisons, (short?)numExpedition, caNum, caisseNumber, caissierNumber, expeditIntitule, dateLivrReal, reference);

                // Activer Table Layout Panel (Champ de saisie des articles)
                tableLayoutPanel2.Enabled = true;

                // Activation des boutons Nouveau, Supprimer et Enregistrer
                BouttonNouveauDesignation.Enabled = true;
                BouttonSupprimerDesignation.Enabled = true;
                BouttonEnregistrerDesignation.Enabled = true;

                // Coloration des TextBox (Remise des couleurs)
                TextBoxReference.BackColor = Color.White;
                TextBoxDesignation.BackColor = Color.White;
                txtBxQuantite.BackColor = Color.White;
                txtBxRemise.BackColor = Color.White;

                // Disable Valider (Validation Docentete & Client)
                kptnBtnValider.Enabled = false;

                //btnNouveauDocEnTete.Enabled = false;
                //btnOk.Enabled = false;
            }
        }

        // ================= DEBUT RESET DATETIME PICKER (DATE PRÉVU ET RÉALISÉE) =================
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

        private void btnNomenclature_Click(object sender, EventArgs e)
        {
            InformationsDocumentsDesVentes informationsDocumentsDesVentes = new InformationsDocumentsDesVentes();
            informationsDocumentsDesVentes.ShowDialog();
        }

        private void TextBoxReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void TextBoxReference_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                decimal puHT;
                decimal puTTC;
                //try
                //{
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

                    // Prix de l'article spécifique à un client existe
                    if (artClient != null)
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
                    // Prix de l'article spécifique à un client n'existe pas
                    else
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
                    AjouterPrix(articleSaisie.AR_Ref, articleSaisie.AR_Design, puHT, puTTC, estHorsTaxe ? "HT" : "TTC");
                    MettreAJourMontants();
                }
                else
                {
                    ListeArticles articleARechercher = new ListeArticles(codeFamilleOuDesignation, false, true, null, pourcentageRemise);
                    articleARechercher.ShowDialog(this);
                }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

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

        private void BouttonSupprimerDesignation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmez-vous la suppression de cette ligne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (DataGridViewArticle.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridViewArticle.SelectedRows[0];
                    lblPrixTotHT.Text = (Convert.ToDecimal(lblPrixTotHT.Text) - Convert.ToDecimal(selectedRow.Cells[8].Value)).ToString("N2");
                    DataGridViewArticle.Rows.Remove(selectedRow);
                    MettreAJourPoids();
                }
                TextBoxReference.Focus();
            }
        }

        private void BouttonEnregistrerDesignation_Click(object sender, EventArgs e)
        {
            BouttonSupprimerDesignation.Enabled = true;

            var articleBaseDeDonnees = _context.F_ARTSTOCK.FirstOrDefault(a => a.AR_Ref == TextBoxReference.Text);
            if (articleBaseDeDonnees != null)
            {
                decimal quantiteEnStock = (decimal)articleBaseDeDonnees.AS_QteSto - (decimal)articleBaseDeDonnees.AS_QteRes;

                if (Convert.ToInt16(txtBxQuantite.Text) <= quantiteEnStock)
                {
                    if (string.IsNullOrWhiteSpace(TextBoxReference.Text) || string.IsNullOrWhiteSpace(TextBoxDesignation.Text) || string.IsNullOrWhiteSpace(TextBoxPUHT.Text) || string.IsNullOrWhiteSpace(TextBoxPUTTC.Text) || string.IsNullOrWhiteSpace(txtBxQuantite.Text) || string.IsNullOrWhiteSpace(TextBoxConditionnement.Text) || string.IsNullOrWhiteSpace(TextBoxMontantHT.Text) || string.IsNullOrWhiteSpace(TextBoxMontantTTC.Text))
                    {
                        MessageBox.Show("Veuillez remplir tous les champs.");
                        return;
                    }

                    string arRef = TextBoxReference.Text;
                    string arDesign = TextBoxDesignation.Text;
                    string conditionnement = TextBoxPUTTC.Text;
                    int quantiteEcriteStock = int.Parse(txtBxQuantite.Text);
                    decimal puHT = Convert.ToDecimal(TextBoxPUNet?.Text ?? "0");
                    decimal puTTC = Convert.ToDecimal(TextBoxPUTTC.Text ?? "0");
                    decimal puNet = Convert.ToDecimal(TextBoxPUHT.Text ?? "0");
                    decimal montantHT = Convert.ToDecimal(TextBoxMontantTTC.Text ?? "0");
                    decimal montantTTC = Convert.ToDecimal(TextBoxMontantHT.Text ?? "0");

                    MettreAJourPoids();



                    // Ajout nouveau DOCLIGNE
                    if (changedIndex == -1)
                    {
                        // Mise à jour affichage
                        DataGridViewArticle.Rows.Add(arRef, arDesign, puHT, puTTC, quantiteEcriteStock, conditionnement, txtBxQuantite.Text, puNet, montantHT, montantTTC);
                        // Get all properties du docligne
                        F_DOCLIGNE docligne = new F_DOCLIGNE();
                        F_DOCENTETE docEnCours = _context.F_DOCENTETE.Where(doc => doc.DO_Piece == _currentDocPieceNo).FirstOrDefault();
                        short typeDoc = (short)GetDocTypeNo(_typeDocument);
                        docligne.DO_Type = typeDoc;
                        docligne.DO_Domaine = GetDocLigneDomaine(docligne.DO_Type);
                        docligne.CT_Num = _listeClients[comboBoxClient.SelectedIndex].CT_Num;
                        docligne.DO_Piece = _currentDocPieceNo;
                        docligne.DO_Date = docEnCours.DO_Date;
                        docligne.DL_DateBC = docEnCours.DO_Date;
                        docligne.DL_DateBL = docEnCours.DO_Date;
                        docligne.DL_Ligne = (DataGridViewArticle.Rows.Count + 1) * 1000;
                        docligne.DO_Ref = docEnCours.DO_Ref;
                        docligne.DL_TNomencl = 0;
                        docligne.DL_TRemPied = 0;
                        docligne.DL_TRemExep = 0;
                        docligne.AR_Ref = TextBoxReference.Text;
                        docligne.DL_Design = TextBoxDesignation.Text;
                        docligne.DL_Qte = Convert.ToInt32(txtBxQuantite.Text);
                        docligne.DL_QteBC = Convert.ToInt32(txtBxQuantite.Text);
                        if ((short)GetDocTypeNo(_typeDocument) == 0 || (short)GetDocTypeNo(_typeDocument) == 1)
                        {
                            docligne.DL_QteBL = 0;
                        }
                        else
                        {
                            docligne.DL_QteBL = 1;
                        }
                        F_ARTICLE articleChoisi = _listeArticle.Where(a => a.AR_Ref == TextBoxReference.Text).FirstOrDefault();
                        docligne.DL_PoidsNet = Convert.ToInt32(txtBxQuantite.Text) * articleChoisi.AR_PoidsNet;
                        docligne.DL_PoidsBrut = Convert.ToInt32(txtBxQuantite.Text) * articleChoisi.AR_PoidsBrut;
                        docligne.DL_Remise01REM_Valeur = (txtBxRemise.Text == "") ? 0 : Convert.ToDecimal(txtBxRemise.Text);
                        docligne.DL_Remise01REM_Type = 0; // (Remise en pourcent)
                        docligne.DL_Remise02REM_Valeur = 0;
                        docligne.DL_Remise02REM_Type = 0;
                        docligne.DL_Remise03REM_Valeur = 0;
                        docligne.DL_Remise03REM_Type = 0;
                        docligne.DL_PrixUnitaire = Convert.ToDecimal(TextBoxPUNet.Text);
                        docligne.DL_PUBC = 0;
                        docligne.DL_Taxe1 = 0;
                        docligne.DL_TypeTaux1 = 0;
                        docligne.DL_TypeTaxe1 = 0;
                        docligne.DL_Taxe2 = 0;
                        docligne.DL_TypeTaux2 = 0;
                        docligne.DL_TypeTaxe2 = 0;
                        docligne.DL_Taxe3 = 0;
                        docligne.DL_TypeTaux3 = 0;
                        docligne.DL_TypeTaxe3 = 0;
                        F_COLLABORATEUR collab = _listeCollaborateurs.Where(c => c.CO_Nom + " " + c.CO_Prenom == comboBoxRepresentant.Text).FirstOrDefault();
                        docligne.CO_No = collab != null ? collab.CO_No : 0;
                        docligne.AG_No1 = 0; // TODO: Gammes mbola tsy prise en compte
                        docligne.AG_No2 = 0; // TODO: Gammes mbola tsy prise en compte
                        docligne.DL_PrixRU = Convert.ToDecimal(TextBoxPUNet.Text);
                        docligne.DL_CMUP = Convert.ToDecimal(TextBoxPUNet.Text);
                        if (articleChoisi.AR_SuiviStock == 0)
                        {
                            docligne.DL_MvtStock = 0;
                        }
                        else
                        {

                            if (typeDoc == 0 || typeDoc == 1 || typeDoc == 2 || typeDoc == 5)
                            {
                                docligne.DL_MvtStock = 0;
                            }
                            else if (typeDoc == 3 || typeDoc == 6 || typeDoc == 7)
                            {
                                docligne.DL_MvtStock = 3;
                            }
                            else if (typeDoc == 4 || typeDoc == 16 || typeDoc == 17)
                            {
                                docligne.DL_MvtStock = 1;
                            }
                            else
                            {
                                docligne.DL_MvtStock = 0;
                            }
                        }
                        docligne.DT_No = 0;
                        F_ARTFOURNISS fournisseur = f_ARTFOURNISSService.GetByARRefAndPrincipal(articleChoisi.AR_Ref);
                        docligne.AF_RefFourniss = fournisseur.AF_RefFourniss;
                        if (articleChoisi.AR_Condition != 0)
                        {
                            // TODO: Mbola tsy choix avy amin'ny utilisateur ireto lignes ireot fa valeur par défaut.
                            F_CONDITION condition = _context.F_CONDITION.Where(cond => cond.AR_Ref == articleChoisi.AR_Ref).FirstOrDefault();
                            docligne.EU_Enumere = condition.EC_Enumere;
                        }
                        else
                        {
                            docligne.EU_Enumere = _context.P_UNITE.Where(unit => unit.cbMarq == articleChoisi.AR_UniteVen).Select(unit => unit.U_Intitule).FirstOrDefault();
                        }
                        docligne.EU_Qte = Convert.ToInt32(txtBxQuantite.Text);
                        docligne.DL_TTC = 0;
                        F_ARTSTOCK depotArtStock = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == articleChoisi.AR_Ref && artStck.AS_Principal == 1).FirstOrDefault();
                        docligne.DE_No = depotArtStock != null ? depotArtStock.DE_No : 0;
                        docligne.DL_NoRef = (short)(DataGridViewArticle.Rows.Count + 1);
                        docligne.DL_TypePL = 0;
                        docligne.DL_PUDevise = 0;
                        docligne.DL_PUTTC = Convert.ToDecimal(TextBoxPUTTC.Text ?? "0");
                        docligne.DL_No = _context.F_DOCLIGNE.Max(dl => dl.DL_No) + 1;
                        docligne.DO_DateLivr = dateTimePicker2.Value;
                        docligne.CA_Num = comboBoxAffaire.Text;
                        int indexEspace = comboBoxAffaire.Text.IndexOf(' ');
                        if (comboBoxAffaire.Text != "")
                        {
                            docligne.CA_Num = comboBoxAffaire.Text.Substring(0, indexEspace);
                        }
                        docligne.DL_Frais = 0;
                        docligne.DL_Valorise = 1;
                        docligne.AR_RefCompose = null;
                        docligne.DL_NonLivre = 0;
                        docligne.AC_RefClient = "";
                        docligne.DL_MontantHT = Convert.ToDecimal(TextBoxMontantTTC.Text);
                        docligne.DL_MontantTTC = Convert.ToDecimal(TextBoxMontantHT.Text);
                        docligne.DL_FactPoids = 0;
                        docligne.DL_Escompte = 0;
                        docligne.DL_PiecePL = "";
                        docligne.DL_DatePL = dateTimePicker3.Value;
                        if (typeDoc == 1 || typeDoc == 2 || typeDoc == 3 || typeDoc == 4 || typeDoc == 5 || typeDoc == 6 || typeDoc == 7)
                        {
                            docligne.DL_QtePL = Convert.ToInt32(txtBxQuantite.Text);
                        }
                        else
                        {
                            docligne.DL_QtePL = 0;
                        }
                        docligne.DL_NoColis = "";
                        docligne.DL_NoLink = 0;
                        docligne.RP_Code = null;
                        docligne.DL_QteRessource = 0;
                        docligne.DL_DateAvancement = new DateTime(1753, 01, 01, 00, 00, 00);
                        docligne.DL_PieceBL = "";
                        docligne.DL_CodeTaxe1 = null;
                        docligne.DL_CodeTaxe2 = null;
                        docligne.DL_CodeTaxe3 = null;
                        docligne.DL_PieceOFProd = 0;
                        docligne.DL_PieceDE = "";
                        docligne.DL_DateDE = docEnCours.DO_Date;
                        docligne.DL_QteDE = typeDoc == 0 ? Convert.ToInt32(txtBxQuantite.Text) : 0;
                        docligne.DL_Operation = "";
                        docligne.DL_NoSousTotal = 0;
                        docligne.CA_No = mainForm.CaisseNo;
                        docligne.Colisage = null;
                        docligne.Unité_de_colisage = null;
                        docligne.Commentaires = null;


                        // Insertion dans la base
                        _f_DOCLIGNERepository.Add(docligne);


                        // Update DO_TotalHT dans F_DOCENTETE (DOcument en cours)
                        decimal montantTotalHT = 0;
                        foreach (DataGridViewRow row in DataGridViewArticle.Rows)
                        {
                            if (row.Cells[8].Value != null)
                            {
                                montantTotalHT += Convert.ToDecimal(row.Cells[8].Value);
                            }
                        }
                        _f_DOCENTETERepository.UpdateTotalHT(montantTotalHT, _currentDocPieceNo);

                        // Mise à jour F_ARTSTOCK
                        int qteStockPrincip;
                        int qteStockSecond;
                        decimal montantStockPrincip;
                        decimal puStockPrincip;
                        decimal puStockSecond;
                        if (_typeDocument == "Devis")
                        {
                            // Type document "devis"
                            // Ne rien faire
                        }
                        else if (_typeDocument == "Bon de commande" || _typeDocument == "Préparation de livraison")
                        {
                            // Type document "commandes et prepa livraisons"
                            F_ARTSTOCK artStockPrincip = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == articleChoisi.AR_Ref && artStck.AS_Principal == 1).FirstOrDefault();
                            F_ARTSTOCK artStockSecond = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == articleChoisi.AR_Ref && artStck.AS_Principal == 0).FirstOrDefault();
                            if (Convert.ToInt32(txtBxQuantite.Text) > artStockPrincip.AS_QteSto)
                            {
                                // Cas stock principal insuffisant
                                int resteACompleter = Convert.ToInt32(txtBxQuantite.Text) - (int)artStockPrincip.AS_QteSto;
                                decimal newQteCommandePrincip = (decimal)(artStockPrincip.AS_QteCom + (int)artStockPrincip.AS_QteSto);
                                string queryUpdateAvecCommande = "UPDATE F_ARTSTOCK SET AS_QteSto = 0, AS_MontSto = 0, AS_QteCom = @newQteCommandePrincip where AR_Ref like @arRef AND AS_Principal = 1";
                                _context.Database.ExecuteSqlCommand(
                                        queryUpdateAvecCommande,
                                        new SqlParameter("@newQteCommandePrincip", newQteCommandePrincip),
                                        new SqlParameter("@arRef", "%" + articleChoisi.AR_Ref + "%")
                                );
                                if (resteACompleter > 0)
                                {
                                    puStockSecond = (decimal)(artStockSecond.AS_MontSto / artStockPrincip.AS_QteSto);
                                    qteStockSecond = (int)artStockSecond.AS_QteSto - resteACompleter;
                                    decimal nouvMontantStockSecond = (decimal)(qteStockSecond * artStockSecond.AS_MontSto);
                                    decimal newQteCommandeSecond = (decimal)(artStockSecond.AS_QteCom + resteACompleter);
                                    string queryUpdateStockSecondAvecCommande = "UPDATE F_ARTSTOCK SET AS_QteSto = @qteStockSecond, AS_MontSto = @nouvMontantStockSecond, AS_QteCom = @newQteCommandeSecond where AR_Ref like @arRef AND AS_Principal = 0";
                                    _context.Database.ExecuteSqlCommand(
                                        queryUpdateStockSecondAvecCommande,
                                        new SqlParameter("@qteStockSecond", Convert.ToDecimal(qteStockSecond.ToString("F2"))),
                                        new SqlParameter("@nouvMontantStockSecond", Convert.ToDecimal(nouvMontantStockSecond.ToString("F2"))),
                                        new SqlParameter("@newQteCommandeSecond", newQteCommandeSecond),
                                        new SqlParameter("@arRef", "%" + articleChoisi.AR_Ref + "%")
                                    );
                                }
                            }
                            else
                            {
                                // Cas stock principal suffisant
                                puStockPrincip = (decimal)(artStockPrincip.AS_MontSto / artStockPrincip.AS_QteSto);
                                qteStockPrincip = Convert.ToInt32(artStockPrincip.AS_QteSto) - Convert.ToInt32(txtBxQuantite.Text);
                                montantStockPrincip = qteStockPrincip * puStockPrincip;
                                string queryUptadeStockPrincip = "UPDATE F_ARTSTOCK SET AS_QteSto = @qteStockPrincip, AS_MontSto = @montantStockPrincip, AS_QteCom = @qteCommande where AR_Ref like @arRef AND AS_Principal = 1";
                                _context.Database.ExecuteSqlCommand(
                                    queryUptadeStockPrincip,
                                    new SqlParameter("@qteStockPrincip", Convert.ToDecimal(qteStockPrincip.ToString("F2"))),
                                    new SqlParameter("@montantStockPrincip", Convert.ToDecimal(montantStockPrincip.ToString("F2"))),
                                    new SqlParameter("@qteCommande", Convert.ToInt32(txtBxQuantite.Text)),
                                    new SqlParameter("@arRef", "%" + articleChoisi.AR_Ref + "%")
                                );
                            }
                            _context.Entry(artStockPrincip).Reload();
                            _context.Entry(artStockSecond).Reload();
                        }
                        else
                        // _typeDocument == "Bon de livraison" || _typeDocument == "Bon de retour" || _typeDocument == "Bon d'avoir finanicier" || _typeDocument == "Facture" || _typeDocument == "Facture comptabilisée" || _typeDocument == "Facture de retour" || _typeDocument == "Facture d'avoir"
                        {
                            F_ARTSTOCK artStockPrincip = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == articleChoisi.AR_Ref && artStck.AS_Principal == 1).FirstOrDefault();
                            F_ARTSTOCK artStockSecond = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == articleChoisi.AR_Ref && artStck.AS_Principal == 0).FirstOrDefault();
                            if (Convert.ToInt32(txtBxQuantite.Text) > artStockPrincip.AS_QteSto)
                            {
                                // Cas stock principal insuffisant
                                int resteACompleter = Convert.ToInt32(txtBxQuantite.Text) - (int)artStockPrincip.AS_QteSto;
                                _context.Database.ExecuteSqlCommand("UPDATE F_ARTSTOCK SET AS_QteSto = 0, AS_MontSto = 0 where AR_Ref = '" + articleChoisi.AR_Ref + "' AND AS_Principal = 1");
                                if (resteACompleter > 0)
                                {
                                    puStockSecond = (decimal)(artStockSecond.AS_MontSto / artStockPrincip.AS_QteSto);
                                    qteStockSecond = (int)artStockSecond.AS_QteSto - resteACompleter;
                                    decimal nouvMontantStockSecond = (decimal)(qteStockSecond * artStockSecond.AS_MontSto);
                                    string queryUpdateStockSecond = "UPDATE F_ARTSTOCK SET AS_QteSto = @qteStockSecond, AS_MontSto = @nouvMontantStockSecond where AR_Ref like @arRef AND AS_Principal = 0";
                                    _context.Database.ExecuteSqlCommand(
                                        queryUpdateStockSecond,
                                        new SqlParameter("@qteStockSecond", Convert.ToDecimal(qteStockSecond.ToString("F2"))),
                                        new SqlParameter("@nouvMontantStockSecond", Convert.ToDecimal(nouvMontantStockSecond.ToString("F2"))),
                                        new SqlParameter("@arRef", "%" + articleChoisi.AR_Ref + "%")
                                    );
                                }
                            }
                            else
                            {
                                // Cas stock principal suffisant
                                puStockPrincip = (decimal)(artStockPrincip.AS_MontSto / artStockPrincip.AS_QteSto);
                                qteStockPrincip = Convert.ToInt32(artStockPrincip.AS_QteSto) - Convert.ToInt32(txtBxQuantite.Text);
                                montantStockPrincip = qteStockPrincip * puStockPrincip;
                                string queryUptadeStockPrincip = "UPDATE F_ARTSTOCK SET AS_QteSto = @qteStockPrincip, AS_MontSto = @montantStockPrincip where AR_Ref like @arRef AND AS_Principal = 1";
                                _context.Database.ExecuteSqlCommand(
                                    queryUptadeStockPrincip,
                                    new SqlParameter("@qteStockPrincip", Convert.ToDecimal(qteStockPrincip.ToString("F2"))),
                                    new SqlParameter("@montantStockPrincip", Convert.ToDecimal(montantStockPrincip.ToString("F2"))),
                                    new SqlParameter("@arRef", "%" + articleChoisi.AR_Ref + "%")
                                );
                            }
                            //_context.Entry(artStockPrincip).Reload();
                            //_context.Entry(artStockSecond).Reload();
                        }


                        // Mise à jour F_ARTSTOCKEMPL (emplacement)
                        if (_typeDocument == "Préparation de livraison")
                        {
                            F_ARTSTOCKEMPL fArtstockEmpl = _context.F_ARTSTOCKEMPL.Where(artStckEmpl => artStckEmpl.AR_Ref == articleChoisi.AR_Ref).FirstOrDefault();
                            fArtstockEmpl.AE_QtePrepa = fArtstockEmpl.AE_QtePrepa + Convert.ToInt32(txtBxQuantite.Text);
                            _context.SaveChanges();
                        }
                        else
                        {
                            F_ARTSTOCKEMPL fArtstockEmpl = _context.F_ARTSTOCKEMPL.Where(artStckEmpl => artStckEmpl.AR_Ref == articleChoisi.AR_Ref).FirstOrDefault();
                            fArtstockEmpl.AE_QteSto = fArtstockEmpl.AE_QteSto - Convert.ToInt32(txtBxQuantite.Text);
                            _context.SaveChanges();
                        }

                    }
                    // Mise à jour DOCLIGNE
                    else
                    {
                        // Mise à jour affichage
                        DataGridViewArticle.Rows[changedIndex].Cells[0].Value = arRef;
                        DataGridViewArticle.Rows[changedIndex].Cells[1].Value = arDesign;
                        DataGridViewArticle.Rows[changedIndex].Cells[2].Value = puHT;
                        DataGridViewArticle.Rows[changedIndex].Cells[3].Value = puTTC;
                        DataGridViewArticle.Rows[changedIndex].Cells[4].Value = quantiteEcriteStock;
                        DataGridViewArticle.Rows[changedIndex].Cells[5].Value = conditionnement;
                        DataGridViewArticle.Rows[changedIndex].Cells[6].Value = txtBxQuantite.Text;
                        DataGridViewArticle.Rows[changedIndex].Cells[7].Value = puNet;
                        DataGridViewArticle.Rows[changedIndex].Cells[8].Value = montantHT;
                        DataGridViewArticle.Rows[changedIndex].Cells[9].Value = montantTTC;
                        changedIndex = -1;

                        // Mise à jour dans la base
                    }

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
                }
                else
                {
                    MessageBox.Show("La valeur entrée ne doit pas être nulle");
                    ControlTableLayoutPanel();
                }
            }

            else
            {
                MessageBox.Show("Veuillez remplir tout les champs");
                ControlTableLayoutPanel();
                TextBoxReference.Focus();
            }

            TextBoxReference.Focus();
        }

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

        private void txtBxRemise_TextChanged(object sender, EventArgs e)
        {
            string cultureName = "en-EN"; // Exemple pour la culture française
            CultureInfo culture = new CultureInfo(cultureName);
            if (decimal.TryParse(txtBxRemise.Text, NumberStyles.Number, culture, out pourcentageRemise))
            {
                if (pourcentageRemise <= 0)
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
        // ================= FIN RESET DATETIME PICKER (DATE PRÉVU ET RÉALISÉE) =================



        // ================================================ FIN EVENEMENTS ===================================================
        // ===================================================================================================================
    }
}
