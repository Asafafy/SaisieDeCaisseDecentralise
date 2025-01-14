using Objets100cLib;
using SoftCaisse.Models;
using SoftCaisse.Repositories.BIJOU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Services
{
    internal class F_DOCENTETEService
    {
        // ==========================================================================================================================================================================
        // ==================================================================== DEBUT DECLARATION DES VARIABLES =====================================================================
        // ==========================================================================================================================================================================
        private readonly F_DOCENTETERepository _f_DOCENTETERepository;
        private readonly AppDbContext _context;
        // ==========================================================================================================================================================================
        // ===================================================================== FIN DECLARATION DES VARIABLES ======================================================================
        // ==========================================================================================================================================================================









        // ==========================================================================================================================================================================
        // ========================================================================== DEBUT CONSTRUCTEUR ============================================================================
        // ==========================================================================================================================================================================
        public F_DOCENTETEService(F_DOCENTETERepository f_DOCENTETERepository, AppDbContext context)
        {
            _f_DOCENTETERepository = f_DOCENTETERepository;
            _context = context;
        }
        // ==========================================================================================================================================================================
        // ============================================================================ FIN CONSTRUCTEUR ============================================================================
        // ==========================================================================================================================================================================









        // ==========================================================================================================================================================================
        // ============================================================= DEBUT FONCTIONS NE NECESSITANT LE REPOSITORY ===============================================================
        // ==========================================================================================================================================================================

        // ============================================================== FORMATTER LA PRESENTATION DU NUMERO DE PIECE ==============================================================
        public string FormatPieceNo(int maxNo, string prefixe)
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





        // ============================================================================ TYPE DU DOCUMENT ============================================================================
        public DocumentType GetDocumentType(string docType)
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




        
        // ======================================================================= NUMERO DU TYPE DE DOCUMENT =======================================================================
        public int? GetDocTypeNo(string docType)
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
            else if (docType == "Facture" || docType == "Facture de retour" || docType == "Facture d'avoir")
            {
                return 6;
            }
            else if (docType == "Facture comptabilisée")
            {
                return 7;
            }
            else
            {
                return null;
            }
        }





        // ====================================================================== NUMERO DU DOCUMENT A CREER ========================================================================
        public string GetCurrentDocNumber(string docType, List<F_DOCENTETE> listeDocs)
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





        // ============================================================ RECHERCHE DES VALEURS DE TRANSACTION ET REGIME ==============================================================
        public (int transaction, int regime) GetTransacEtRegime(string typeDoc)
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
        // ==========================================================================================================================================================================
        // ============================================================== FIN FONCTIONS NE NECESSITANT LE REPOSITORY ================================================================
        // ==========================================================================================================================================================================










        // ==========================================================================================================================================================================
        // ============================================================== DEBUT FONCTIONS NECESSITANT LE REPOSITORY =================================================================
        // ==========================================================================================================================================================================
        public void InsertNewF_DOCENTETE(string typeDoc, string noPiece, F_COMPTET client, List<F_LIVRAISON> listeLivr, short? numExpedit, string caNum, int numCaisse, int numCaissier, string expeditInt, DateTime dateLivrPrev, DateTime dateLivrRealise, string refer, string DO_Coord01, string divers, string commentaires, string representant)
        {
            // Get properties (Recherche des propriétés manquantes)
            DocumentType typeDocument = GetDocumentType(typeDoc);
            F_LIVRAISON lieuLivrPrinc = listeLivr.Where(l => l.CT_Num == client.CT_Num && l.LI_Principal == 1).FirstOrDefault();
            F_COLLABORATEUR representantDOCENTETE = _context.F_COLLABORATEUR.Where(coll => coll.CO_Nom + " " + coll.CO_Prenom == representant).FirstOrDefault();
            P_EXPEDITION expedit = _context.P_EXPEDITION.Where(exp => exp.E_Intitule == expeditInt).FirstOrDefault();
            (int, int) tupleTransactionRegime = GetTransacEtRegime(typeDoc);
            int? typeNo = GetDocTypeNo(typeDoc);
            DateTime now = DateTime.Now;
            string heureNow = "000" + now.Hour + now.Minute + now.Second;

            // Création de l'entête de document (Instance F_DOCENTETE)
            F_DOCENTETE newDocEnTete = new F_DOCENTETE
            {
                DO_Domaine = 0,
                DO_Type = (short)typeNo,
                DO_Piece = noPiece,
                DO_Date = DateTime.Now,
                DO_Ref = refer,
                DO_Tiers = client.CT_Num,
                CO_No = representantDOCENTETE == null ? 0 : representantDOCENTETE.CO_No,
                cbCO_No = representantDOCENTETE == null ? null : representantDOCENTETE.CO_No,
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
                DO_Coord01 = DO_Coord01,
                DO_Coord02 = "",
                DO_Coord03 = "",
                DO_Coord04 = "",
                DO_Souche = 0,
                DO_DateLivr = dateLivrPrev,
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
                cbCreateur = "COLS",
                Commentaires = commentaires,
                Divers = divers
            };

            // Ajout objet dans F_DOCENTETE utilisant le repository
            _f_DOCENTETERepository.Add(newDocEnTete);
        }




        public void UpdateProprietesF_DOCENTETE(string currentDocPieceNo, DateTime dateLivrPrevu, DateTime dateLivrReal, string reference, string caNum, string representant, short? numExpedit, string expeditInt, string entete, string commentaires, string divers)
        {
            F_DOCENTETE f_DOCENTETE = _context.F_DOCENTETE.Where(d => d.DO_Piece == currentDocPieceNo).FirstOrDefault();

            F_COLLABORATEUR representantDOCENTETE = _context.F_COLLABORATEUR.Where(coll => (coll.CO_Nom + " " + coll.CO_Prenom) == representant).FirstOrDefault();
            P_EXPEDITION expedit = _context.P_EXPEDITION.Where(exp => exp.E_Intitule == expeditInt).FirstOrDefault();

            f_DOCENTETE.DO_DateLivr = dateLivrPrevu;
            f_DOCENTETE.DO_DateLivrRealisee = dateLivrReal;
            f_DOCENTETE.DO_Ref = reference;
            f_DOCENTETE.CA_Num = caNum;
            f_DOCENTETE.CO_No = representantDOCENTETE.CO_No;
            f_DOCENTETE.cbCO_No = representantDOCENTETE.CO_No;
            f_DOCENTETE.DO_Expedit = numExpedit;
            f_DOCENTETE.DO_ValFranco = expedit.E_ValFranco;
            f_DOCENTETE.DO_ValFrais = expedit.E_ValFrais;
            f_DOCENTETE.DO_Coord01 = entete;
            f_DOCENTETE.Commentaires = commentaires;
            f_DOCENTETE.Divers = divers;

            _f_DOCENTETERepository.UpdateProprietesF_DOCENTETE(f_DOCENTETE);
        }




        public void UpdateDO_TotalHT(string DO_Piece, decimal? currentPUNet, int currentQuantite, decimal? previousMontArt)
        {
            F_DOCENTETE document = _context.F_DOCENTETE.Where(d => d.DO_Piece == DO_Piece).FirstOrDefault();
            decimal? currentMontArt = currentQuantite * currentPUNet;
            decimal? newDO_TotalHT = document.DO_TotalHT - previousMontArt + currentMontArt;
            _f_DOCENTETERepository.UpdateTotalHT(DO_Piece, newDO_TotalHT);
        }




        public void UpdateDO_TotalHTAfterDelete(string DO_Piece, decimal? previousMontArt)
        {
            F_DOCENTETE document = _context.F_DOCENTETE.Where(d => d.DO_Piece == DO_Piece).FirstOrDefault();
            decimal? newDO_TotalHT = document.DO_TotalHT - previousMontArt;
            _f_DOCENTETERepository.UpdateTotalHT(DO_Piece, newDO_TotalHT);
        }




        // ==========================================================================================================================================================================
        // ================================================================ FIN FONCTIONS NECESSITANT LE REPOSITORY =================================================================
        // ==========================================================================================================================================================================
    }
}
