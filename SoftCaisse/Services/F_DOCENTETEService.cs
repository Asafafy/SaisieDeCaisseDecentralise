using Objets100cLib;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
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
        // =====================================================================================================
        // DEBUT DECLARATION DES VARIABLES =====================================================================
        // =====================================================================================================
        private readonly AppDbContext _context;

        private readonly F_DOCENTETERepository _f_DOCENTETERepository;
        private readonly F_COMPTETRepository _f_COMPTETRepository;
        private readonly P_EXPEDITIONRepository _p_EXPEDITIONRepository;
        private readonly F_COLLABORATEURRepository _f_COLLABORATEURRepository;
        private readonly F_LIVRAISONRepository _f_LIVRAISONRepository;
        // =====================================================================================================
        // FIN DECLARATION DES VARIABLES =======================================================================
        // =====================================================================================================









        // ===================================================================================================
        // DEBUT CONSTRUCTEUR ================================================================================
        // ===================================================================================================
        public F_DOCENTETEService(F_DOCENTETERepository f_DOCENTETERepository, AppDbContext context)
        {
            _context = context;

            _f_DOCENTETERepository = f_DOCENTETERepository;
            _f_COMPTETRepository = new F_COMPTETRepository(_context);
            _p_EXPEDITIONRepository = new P_EXPEDITIONRepository(_context);
            _f_COLLABORATEURRepository = new F_COLLABORATEURRepository(_context);
            _f_LIVRAISONRepository = new F_LIVRAISONRepository(_context);
        }
        // ===================================================================================================
        // FIN CONSTRUCTEUR ==================================================================================
        // ===================================================================================================









        // ===================================================================================================
        // DEBUT FONCTIONS NE NECESSITANT LE REPOSITORY ======================================================
        // ===================================================================================================

        // FORMATTER LA PRESENTATION DU NUMERO DE PIECE ======================================================
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





        // TYPE DU DOCUMENT ==============================================================================
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




        
        // NUMERO DU TYPE DE DOCUMENT =======================================================================
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





        // NOM DU TYPE DE DOCUMENT =======================================================================
        public string GetDocTypeName(int docType, string DO_Piece)
        {
            if (docType == 0)
            {
                return "Devis";
            }
            else if (docType == 1)
            {
                return "Bon de commande";
            }
            else if (docType == 2)
            {
                return "Préparation de livraison";
            }
            else if (docType == 3)
            {
                return "Bon de livraison";
            }
            else if (docType == 4)
            {
                return "Bon de retour";
            }
            else if (docType == 5)
            {
                return "Bon d'avoir finanicier";
            }
            else if (docType == 6)
            {
                if (DO_Piece.StartsWith("FA"))
                    return "Facture";
                else if (DO_Piece.StartsWith("FR"))
                    return "Facture de retour";
                else
                    return "Facture d'avoir";
            }
            else if (docType == 7)
            {
                return "Facture comptabilisée";
            }
            else
            {
                return null;
            }
        }





        // NUMERO DU DOCUMENT A CREER ===================================================================
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





        // RECHERCHE DES VALEURS DE TRANSACTION ET REGIME ==============================================================
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
        // ===========================================================================================================
        // FIN FONCTIONS NE NECESSITANT LE REPOSITORY ================================================================
        // ===========================================================================================================










        // ===========================================================================================================
        // DEBUT FONCTIONS NECESSITANT LE REPOSITORY =================================================================
        // ===========================================================================================================
        public void InsertNewF_DOCENTETE(string typeDoc, string noPiece, F_COMPTET client, short? numExpedit, string caNum, int? numCaisse, int? numCaissier, string expeditInt, DateTime dateLivrPrev, DateTime dateLivrRealise, string refer, string DO_Coord01, string divers, string commentaires, string representant, int DE_No)
        {
            // Recherche des propriétés manquantes
            int? DO_Type = GetDocTypeNo(typeDoc);
            decimal? DO_Cours = _f_COMPTETRepository.GetF_COMPTET_Cours_N_Devise(client.CT_Num);
            (int, int) tupleTransactionRegime = GetTransacEtRegime(typeDoc);
            DateTime now = DateTime.Now;
            string heureNow = "000" + now.Hour + now.Minute + now.Second;

            F_LIVRAISON lieuLivrPrinc = _f_LIVRAISONRepository.Get_LI_Principal_Of_F_COMPTET(client.CT_Num, 1);
            F_COLLABORATEUR representantDOCENTETE = _f_COLLABORATEURRepository.GetBy_CO_Nom_And_CO_Prenom(representant);
            P_EXPEDITION expedit = _p_EXPEDITIONRepository.Get_P_EXPEDITIONBy_E_Intitule(expeditInt);

            // Création de l'entête de document (Instance F_DOCENTETE)
            F_DOCENTETE newDocEnTete = new F_DOCENTETE
            {
                DO_Type = (short)DO_Type,
                DO_Piece = noPiece,
                DO_Ref = refer,
                DO_Tiers = client.CT_Num,
                CO_No = representantDOCENTETE == null ? 0 : representantDOCENTETE.CO_No,
                cbCO_No = representantDOCENTETE == null ? null : representantDOCENTETE.CO_No,
                DO_Period = client.N_Period,
                DO_Devise = client.N_Devise,
                DO_Cours = DO_Cours,
                DE_No = DE_No,
                cbDE_No = DE_No,
                LI_No = lieuLivrPrinc == null ? 0 : lieuLivrPrinc.LI_No,
                cbLI_No = lieuLivrPrinc == null ? 0 : lieuLivrPrinc.LI_No,
                CT_NumPayeur = client.CT_NumPayeur,
                DO_Expedit = numExpedit,
                DO_NbFacture = client.CT_Facture,
                DO_BLFact = client.CT_BLFact,
                DO_TxEscompte = client.CT_Taux02,
                CA_Num = caNum,
                DO_Coord01 = DO_Coord01,
                DO_DateLivr = dateLivrPrev,
                DO_Condition = client.N_Condition,
                DO_Tarif = client.N_CatTarif,
                DO_Transaction = (short?)tupleTransactionRegime.Item1,
                DO_Langue = client.CT_Langue,
                DO_Regime = (short?)tupleTransactionRegime.Item2,
                N_CatCompta = client.N_CatCompta,
                CG_Num = client.CG_NumPrinc,
                DO_Heure = heureNow,
                CA_No = numCaisse,
                cbCA_No = numCaisse == 0 ? null : numCaisse,
                CO_NoCaissier = numCaissier,
                cbCO_NoCaissier = numCaissier == 0 ? null : numCaissier,
                CA_NumIFRS =  client.CA_NumIFRS == null ? "" : client.CA_NumIFRS,
                DO_TypeFrais = expedit.E_TypeFrais,
                DO_ValFrais = expedit.E_ValFrais,
                DO_TypeLigneFrais = expedit.E_TypeLigneFrais,
                DO_TypeFranco = expedit.E_TypeFranco,
                DO_ValFranco = expedit.E_ValFranco,
                DO_TypeLigneFranco = expedit.E_TypeLigneFranco,
                DO_Taxe1 = client.N_CatCompta == 2 ? 0 : 20,
                DO_DateLivrRealisee = dateLivrRealise,
                DO_CodeTaxe1 = client.N_CatCompta == 2 ? "C00" : "C20",
                Commentaires = commentaires,
                Divers = divers
                //DO_Domaine = 0,
                //DO_Date = DateTime.Now,
                //DO_Reliquat = 0,
                //DO_Imprim = 0,
                //DO_Coord02 = "",
                //DO_Coord03 = "",
                //DO_Coord04 = "",
                //DO_Souche = 0,
                //DO_Colisage = 1,
                //DO_TypeColis = 1,
                //DO_Ecart = 0,
                //DO_Ventile = 0,
                //AB_No = 0,
                //DO_DebutAbo = new DateTime(1753, 01, 01, 00, 00, 00),
                //DO_FinAbo = new DateTime(1753, 01, 01, 00, 00, 00),
                //DO_DebutPeriod = new DateTime(1753, 01, 01, 00, 00, 00),
                //DO_FinPeriod = new DateTime(1753, 01, 01, 00, 00, 00),
                //DO_Statut = 2,
                //DO_Transfere = 0,
                //DO_Cloture = 0,
                //DO_NoWeb = "",
                //DO_Attente = 0,
                //DO_Provenance = 0,
                //MR_No = 0,
                //DO_TypeTaux1 = 0,
                //DO_TypeTaxe1 = 0,
                //DO_Taxe2 = 0,
                //DO_TypeTaux2 = 0,
                //DO_TypeTaxe2 = 0,
                //DO_Taxe3 = 0,
                //DO_TypeTaux3 = 0,
                //DO_TypeTaxe3 = 0,
                //DO_MajCpta = 0,
                //DO_Motif = "",
                //CT_NumCentrale = null,
                //DO_Contact = "",
                //DO_FactureElec = 0,
                //DO_TypeTransac = 0,
                //DO_DateExpedition = new DateTime(1753, 01, 01, 00, 00, 00),
                //DO_FactureFrs = "",
                //DO_PieceOrig = "",
                //DO_GUID = null,
                //DO_EStatut = 0,
                //DO_DemandeRegul = 0,
                //ET_No = 0,
                //cbET_No = null,
                //DO_Valide = 0,
                //DO_Coffre = 0,
                //DO_CodeTaxe2 = null,
                //DO_CodeTaxe3 = null,
                //DO_TotalHT = 0,
                //DO_StatutBAP = 0,
                //DO_Escompte = 1,
                //DO_DocType = 6,
                //DO_TypeCalcul = 0,
                //DO_FactureFile = null,
                //DO_TotalHTNet = 0,
                //DO_TotalTTC = 0,
                //DO_NetAPayer = 0,
                //DO_MontantRegle = 0,
                //DO_RefPaiement = null,
                //DO_AdressePaiement = "",
                //DO_PaiementLigne = 0,
                //DO_MotifDevis = 0,
                //DO_Conversion = 0,
                //cbCreateur = "COLS",
            };

            // Ajout objet dans F_DOCENTETE utilisant le repository
            _f_DOCENTETERepository.Add(newDocEnTete);
        }




        public void UpdateProprietesF_DOCENTETE(string currentDocPieceNo, DateTime dateLivrPrevu, DateTime dateLivrReal, string reference, string caNum, string representant, short? numExpedit, string expeditInt, string entete, string commentaires, string divers, int DE_No)
        {
            F_DOCENTETE f_DOCENTETE = _context.F_DOCENTETE.Where(d => d.DO_Piece == currentDocPieceNo).FirstOrDefault();

            F_COLLABORATEUR representantDOCENTETE = _context.F_COLLABORATEUR.Where(coll => (coll.CO_Nom + " " + coll.CO_Prenom) == representant).FirstOrDefault();
            P_EXPEDITION expedit = _p_EXPEDITIONRepository.Get_P_EXPEDITIONBy_E_Intitule(expeditInt);

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
            f_DOCENTETE.DE_No = DE_No;

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




        // =========================================================================================================
        // FIN FONCTIONS NECESSITANT LE REPOSITORY =================================================================
        // =========================================================================================================
    }
}
