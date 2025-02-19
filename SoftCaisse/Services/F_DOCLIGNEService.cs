using SoftCaisse.Forms.Article;
using SoftCaisse.Models;
using SoftCaisse.Models.Json;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SoftCaisse.Services
{
    internal class F_DOCLIGNEService
    {
        // =============================================================================================================
        // DEBUT DECLARATION DES VARIABLES =============================================================================
        // =============================================================================================================
        private readonly AppDbContext _context;

        private readonly F_DOCLIGNERepository _f_DOCLIGNERepository;
        private readonly F_AGENDARepository _f_AGENDARepository;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        // =============================================================================================================
        // FIN DECLARATION DES VARIABLES ===============================================================================
        // =============================================================================================================









        // ==============================================================================================================
        // DEBUT CONSTRUCTEUR ===========================================================================================
        // ==============================================================================================================
        public F_DOCLIGNEService(AppDbContext context, F_DOCLIGNERepository fDOCLIGNERepository)
        {
            _context = context;
            _f_DOCLIGNERepository = fDOCLIGNERepository;
            _f_AGENDARepository = new F_AGENDARepository(_context);
            _f_ARTGAMMERepository =new F_ARTGAMMERepository(_context);
        }
        // ===============================================================================================================
        // FIN CONSTRUCTEUR ==============================================================================================
        // ===============================================================================================================









        // ================================================================================================================
        // DEBUT FONCTIONS NECESSITANT LES REPOSITORIES ===================================================================
        // ================================================================================================================
        public string GetF_DOCLIGNES_Lies_Au_AG_No_ToDelete(string EG_Enumere)
        {
            F_ARTGAMME f_ARTGAMME = _f_ARTGAMMERepository.GetByEG_Enumere(EG_Enumere);

            if (f_ARTGAMME != null)
            {
                List<F_DOCLIGNE> f_DOCLIGNEs;
                using (AppDbContext context = new AppDbContext())
                {
                    f_DOCLIGNEs = _f_DOCLIGNERepository.Get_F_DOCLIGNE_HavingAG_No(f_ARTGAMME.AG_No);
                }
                if (f_DOCLIGNEs.Count > 1)
                {
                    string DO_Piece = f_DOCLIGNEs[0].DO_Piece;
                    return DO_Piece;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }





        // ================================================================================================================
        // DEBUT INSERT ===================================================================================================
        public void AjouterF_DOCLIGNE(MainForm mainForm, F_DOCENTETEService _f_DOCENTETEService, F_ARTFOURNISSService _f_ARTFOURNISSService, short typeDoc, string CT_NumClient, string _currentDocPieceNo, DateTime DO_Date, int? numeroLigneDL_Ligne, F_DOCENTETE docEnCours, string AR_Ref, string DL_Design, int DL_Qte, string typeDocument, F_ARTICLE articleChoisi, string txtBxQuantiteText, string txtBxRemiseText, string TextBoxPUNetText, F_COLLABORATEUR collab, short DL_NoRef, decimal DL_PUTTC, DateTime DO_DateLivr, string CA_NumText, string TextBoxMontantTTCText, string TextBoxMontantHTText, DateTime dateTimePicker3Value, int? DE_No)
        {
            F_ARTFOURNISS fournisseur = _f_ARTFOURNISSService.GetByARRefAndPrincipal(articleChoisi.AR_Ref);
            F_ARTSTOCK depotArtStock = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == articleChoisi.AR_Ref && artStck.AS_Principal == 1).FirstOrDefault();


            F_DOCLIGNE docligne = new F_DOCLIGNE();



            // Valeurs qui ne sont pas par défauts =========================================================
            docligne.DO_Type = typeDoc;
            docligne.DO_Domaine = GetDocLigneDomaine(docligne.DO_Type);
            docligne.CT_Num = CT_NumClient;
            docligne.DO_Piece = _currentDocPieceNo;
            docligne.DO_Date = DO_Date;
            docligne.DL_DateBC = DO_Date;
            docligne.DL_DateBL = DO_Date;
            docligne.DO_Ref = docEnCours.DO_Ref;
            docligne.AR_Ref = AR_Ref;
            docligne.DL_Design = DL_Design;
            docligne.DL_Qte = DL_Qte;
            docligne.DL_QteBC = DL_Qte;
            docligne.AF_RefFourniss = fournisseur.AF_RefFourniss;
            docligne.DL_NoRef = DL_NoRef;
            docligne.DL_PUTTC = DL_PUTTC;
            docligne.DO_DateLivr = DO_DateLivr;
            docligne.CA_Num = CA_NumText;
            docligne.DL_DatePL = dateTimePicker3Value;
            docligne.DL_DateDE = docEnCours.DO_Date;
            docligne.CA_No = mainForm.CaisseNo;
            
            docligne.DL_Ligne = numeroLigneDL_Ligne;
            
            docligne.CO_No = collab != null ? collab.CO_No : 0;
            docligne.DE_No = DE_No;
            docligne.DL_No = _context.F_DOCLIGNE.Max(dl => dl.DL_No) + 1;

            docligne.EU_Qte = Convert.ToInt32(txtBxQuantiteText);
            
            docligne.DL_PoidsNet = Convert.ToInt32(txtBxQuantiteText) * articleChoisi.AR_PoidsNet;
            docligne.DL_PoidsBrut = Convert.ToInt32(txtBxQuantiteText) * articleChoisi.AR_PoidsBrut;

            docligne.DL_PrixUnitaire = Convert.ToDecimal(TextBoxPUNetText);
            docligne.DL_PrixRU = Convert.ToDecimal(TextBoxPUNetText);
            docligne.DL_CMUP = Convert.ToDecimal(TextBoxPUNetText);
            docligne.DL_MontantHT = Convert.ToDecimal(TextBoxMontantHTText);
            docligne.DL_MontantTTC = Convert.ToDecimal(TextBoxMontantTTCText);

            docligne.DL_QteDE = typeDoc == 0 ? Convert.ToInt32(txtBxQuantiteText) : 0;
            docligne.DL_Remise01REM_Valeur = (txtBxRemiseText == "") ? 0 : Convert.ToDecimal(txtBxRemiseText);



            // Valeurs par défauts ==========================================================================
            docligne.DL_DateAvancement = new DateTime(1753, 01, 01, 00, 00, 00);
            
            docligne.DL_Remise02REM_Valeur = 0;
            docligne.DL_Remise02REM_Type = 0;
            docligne.DL_Remise03REM_Valeur = 0;
            docligne.DL_Remise03REM_Type = 0;
            docligne.DL_TNomencl = 0;
            docligne.DL_TRemPied = 0;
            docligne.DL_TRemExep = 0;
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
            docligne.DT_No = 0;
            docligne.DL_TTC = 0;
            docligne.DL_TypePL = 0;
            docligne.DL_PUDevise = 0;
            docligne.DL_Frais = 0;
            docligne.DL_NonLivre = 0;
            docligne.DL_FactPoids = 0;
            docligne.DL_Escompte = 0;
            docligne.DL_NoLink = 0;
            docligne.DL_QteRessource = 0;
            docligne.DL_PieceOFProd = 0;
            docligne.DL_NoSousTotal = 0;

            docligne.DL_Remise01REM_Type = 0; // (Remise en pourcent) // MBOLA TSY MAINTSY MIOVA REHEFA PRISE EN COMPTE NY REMISES HAFA
            docligne.AG_No1 = 0; // TODO: Gammes mbola tsy prise en compte
            docligne.AG_No2 = 0; // TODO: Gammes mbola tsy prise en compte
            
            docligne.DL_Valorise = 1;

            docligne.AC_RefClient = "";
            docligne.DL_PiecePL = "";
            docligne.DL_NoColis = "";
            docligne.DL_PieceBL = "";
            docligne.DL_PieceDE = "";
            docligne.DL_Operation = "";

            docligne.AR_RefCompose = null;
            docligne.RP_Code = null;
            docligne.DL_CodeTaxe1 = null;
            docligne.DL_CodeTaxe2 = null;
            docligne.DL_CodeTaxe3 = null;
            docligne.Colisage = null;
            docligne.Unité_de_colisage = null;
            docligne.Commentaires = null;



            // Valeurs conditionnelles ==========================================================================
            if ((short)_f_DOCENTETEService.GetDocTypeNo(typeDocument) == 0 || (short)_f_DOCENTETEService.GetDocTypeNo(typeDocument) == 1)
                docligne.DL_QteBL = 0;
            else
                docligne.DL_QteBL = 1;
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
            if (CA_NumText != "")
            {
                int indexEspace = CA_NumText.IndexOf(' ');
                docligne.CA_Num = CA_NumText.Substring(0, indexEspace);
            }
            if (typeDoc == 1 || typeDoc == 2 || typeDoc == 3 || typeDoc == 4 || typeDoc == 5 || typeDoc == 6 || typeDoc == 7)
                docligne.DL_QtePL = Convert.ToInt32(txtBxQuantiteText);
            else
                docligne.DL_QtePL = 0;



            // Insertion dans la base ==================================================================
            _f_DOCLIGNERepository.Add(docligne);
        }
        // FIN INSERT =======================================================================================
        // ==================================================================================================





        // =================================================================================================
        // DEBUT UPDATE ====================================================================================
        public void UpdateF_DOCLIGNE(string DO_Piece, string AR_Ref, int? DL_Ligne, int quantite, string typeDocument)
        {
            F_DOCLIGNE f_DOCLIGNEToUpdate = _context.F_DOCLIGNE.Where(dl => dl.DO_Piece == DO_Piece && dl.AR_Ref == AR_Ref && dl.DL_Ligne == DL_Ligne).FirstOrDefault();
            var f_ARTICLE = _context.F_ARTICLE.Where(art => art.AR_Ref == AR_Ref).Select(art => new { art.AR_PoidsBrut, art.AR_PoidsNet }).FirstOrDefault();
            var QteEtMontantArticle = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == AR_Ref && artStck.DE_No == f_DOCLIGNEToUpdate.DE_No)
                                                .Select(artStck => new { artStck.AS_QteSto, artStck.AS_MontSto }).FirstOrDefault();

            // Mise à jour des propriétés concernant la quantité
            if (typeDocument == "Devis")
            {
                f_DOCLIGNEToUpdate.DL_Qte = quantite;
                f_DOCLIGNEToUpdate.EU_Qte = quantite;
                f_DOCLIGNEToUpdate.DL_QteBC = quantite;
                f_DOCLIGNEToUpdate.DL_QteDE = quantite;
                f_DOCLIGNEToUpdate.DL_QteBL = 0;
                f_DOCLIGNEToUpdate.DL_QtePL = 0;
            }
            else if (typeDocument == "Bon de commande")
            {
                f_DOCLIGNEToUpdate.DL_Qte = quantite;
                f_DOCLIGNEToUpdate.EU_Qte = quantite;
                f_DOCLIGNEToUpdate.DL_QteBC = quantite;
                f_DOCLIGNEToUpdate.DL_QteDE = quantite;
                f_DOCLIGNEToUpdate.DL_QteBL = quantite;
                f_DOCLIGNEToUpdate.DL_QtePL = 0;
            }
            else if (typeDocument == "Facture de retour" || typeDocument == "Facture d'avoir")
            {
                f_DOCLIGNEToUpdate.DL_Qte = -quantite;
                f_DOCLIGNEToUpdate.EU_Qte = -quantite;
                f_DOCLIGNEToUpdate.DL_QteBC = -quantite;
                f_DOCLIGNEToUpdate.DL_QteDE = -quantite;
                f_DOCLIGNEToUpdate.DL_QteBL = -quantite;
                f_DOCLIGNEToUpdate.DL_QtePL = -quantite;
            }
            else
            {
                f_DOCLIGNEToUpdate.DL_Qte = quantite;
                f_DOCLIGNEToUpdate.EU_Qte = quantite;
                f_DOCLIGNEToUpdate.DL_QteBC = quantite;
                f_DOCLIGNEToUpdate.DL_QteDE = quantite;
                f_DOCLIGNEToUpdate.DL_QteBL = quantite;
                f_DOCLIGNEToUpdate.DL_QtePL = quantite;
            }

            // Mise à jour des propriétés concernant le poids
            f_DOCLIGNEToUpdate.DL_PoidsBrut = quantite * f_ARTICLE.AR_PoidsBrut;
            f_DOCLIGNEToUpdate.DL_PoidsNet = quantite * f_ARTICLE.AR_PoidsNet;

            // Mise à jour DL_CMUP et DL_PrixRU
            decimal? CMUP = QteEtMontantArticle.AS_MontSto / (QteEtMontantArticle.AS_QteSto == 0 ? 1 : QteEtMontantArticle.AS_QteSto);
            f_DOCLIGNEToUpdate.DL_CMUP = CMUP;
            f_DOCLIGNEToUpdate.DL_PrixRU = CMUP;

            // Enregistrement des modifications via le Repository
            _f_DOCLIGNERepository.Update(f_DOCLIGNEToUpdate);

            _context.Entry(f_DOCLIGNEToUpdate).Reload();
        }



        public void DeleteF_DOCLIGNE(string DO_Piece, int? DL_Ligne)
        {
            F_DOCLIGNE f_DOCLIGNEToDelete = _context.F_DOCLIGNE.Where(dl => dl.DO_Piece == DO_Piece && dl.DL_Ligne == DL_Ligne).FirstOrDefault();
            F_AGENDA f_AGENDA = _context.F_AGENDA.Where(a => a.DL_No == f_DOCLIGNEToDelete.DL_No).FirstOrDefault();

            if (f_AGENDA != null)
            {
                _f_AGENDARepository.DeleteF_AGENDA(f_AGENDA);
            }

            _f_DOCLIGNERepository.Delete(f_DOCLIGNEToDelete);
        }




        // FIN UPDATE ====================================================================================================
        // ===============================================================================================================

        // ===============================================================================================================
        // FIN FONCTIONS NECESSITANT LES REPOSITORIES ====================================================================
        // ===============================================================================================================









        // ===================================================================================================================
        // DEBUT FONCTIONS NE NECESSITANT PAS LES REPOSITORIES ===============================================================
        // ===================================================================================================================
        public short? GetDocLigneDomaine(short docType)
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
        // ==================================================================================================================
        // FIN FONCTIONS NE NECESSITANT PAS LES REPOSITORIES ================================================================
        // ==================================================================================================================
    }
}
