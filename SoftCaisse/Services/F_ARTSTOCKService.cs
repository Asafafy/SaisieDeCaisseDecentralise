using SoftCaisse.Models;
using SoftCaisse.Models.Json;
using SoftCaisse.Repositories;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Services
{
    internal class F_ARTSTOCKService
    {
        // ====================================================================================================================================================================================================================================
        // ==================================================================================================== DECLARATION DES VARIABLES =====================================================================================================
        // ====================================================================================================================================================================================================================================
        private readonly AppDbContext _context;
        private readonly F_ARTSTOCKRepository _f_ARTSTOCKRepository;
        // ====================================================================================================================================================================================================================================
        // ==================================================================================================== DECLARATION DES VARIABLES =====================================================================================================
        // ====================================================================================================================================================================================================================================









        // ====================================================================================================================================================================================================================================
        // ======================================================================================================= DEBUT CONSTRUCTEUR =========================================================================================================
        // ====================================================================================================================================================================================================================================
        public F_ARTSTOCKService(AppDbContext context, F_ARTSTOCKRepository f_ARTSTOCKRepository)
        {
            _f_ARTSTOCKRepository = f_ARTSTOCKRepository;
            _context = context;
        }
        // ====================================================================================================================================================================================================================================
        // ======================================================================================================== FIN CONSTRUCTEUR ==========================================================================================================
        // ====================================================================================================================================================================================================================================









        // ====================================================================================================================================================================================================================================
        // ========================================================================================================== DEBUT UPDATE ============================================================================================================
        // ====================================================================================================================================================================================================================================

        public void UpdateMontantEtQuantiteStock(string typeDocument, string AR_Ref, int nouvQte, int previousQte)
        {
            // Identification du stock à mettre à jour
            var DP_NoPrincipal = _context.F_DEPOT
                                        .Where(depot => depot.DE_No == 1)
                                        .Select(depot => _context.F_ARTSTOCK
                                            .Where(artStock => artStock.DE_No == depot.DE_No && artStock.AR_Ref == AR_Ref)
                                            .Select(artStock => artStock.DP_NoPrincipal > 0 ? artStock.DP_NoPrincipal : depot.DP_NoDefaut)
                                            .FirstOrDefault())
                                        .FirstOrDefault();

            int nombreObjetsArtStock = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == AR_Ref).Count();
            F_ARTSTOCK f_ARTSTOCKToUpdate = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == AR_Ref && (nombreObjetsArtStock > 1 ? artStck.DP_NoPrincipal == DP_NoPrincipal : true)).FirstOrDefault();
            decimal? cmup = f_ARTSTOCKToUpdate.AS_MontSto / (f_ARTSTOCKToUpdate.AS_QteSto == 0 ? 1 : f_ARTSTOCKToUpdate.AS_QteSto);

            if (typeDocument == "Devis" || typeDocument == "Bon d'avoir finanicier" || typeDocument == "Facture d'avoir")
            {
                // Aucun interaction avec le stock pour ces types de documents
            }
            else if (typeDocument == "Bon de commande")
            {
                decimal? AS_QteRes = f_ARTSTOCKToUpdate.AS_QteRes - previousQte + nouvQte;
                _f_ARTSTOCKRepository.UpdateQuantiteReserve(AR_Ref, DP_NoPrincipal, AS_QteRes);
            }
            else if (typeDocument == "Préparation de livraison")
            {
                decimal? AS_QtePrepa = f_ARTSTOCKToUpdate.AS_QtePrepa  - previousQte + nouvQte;
                _f_ARTSTOCKRepository.UpdateQuantitePrepare(AR_Ref, DP_NoPrincipal, AS_QtePrepa);
            }
            else if (typeDocument == "Bon de livraison" || typeDocument == "Facture")
            {
                decimal? AS_QteSto = f_ARTSTOCKToUpdate.AS_QteSto + previousQte - nouvQte;
                decimal? AS_MontSto = AS_QteSto * cmup;
                _f_ARTSTOCKRepository.UpdateMontantEtQuantiteStock(AR_Ref, DP_NoPrincipal, AS_MontSto, AS_QteSto);
            }
            else // else if (typeDocument == "Facture de retour" || typeDocument == "Bon de retour")
            {
                decimal? AS_QteSto = f_ARTSTOCKToUpdate.AS_QteSto - previousQte + nouvQte;
                decimal? AS_MontSto = AS_QteSto * cmup;
                _f_ARTSTOCKRepository.UpdateMontantEtQuantiteStock(AR_Ref, DP_NoPrincipal, AS_MontSto, AS_QteSto);
            }
            
            _context.Entry(f_ARTSTOCKToUpdate).Reload();
        }


        // ====================================================================================================================================================================================================================================
        // ========================================================================================================== FIN UPDATE ============================================================================================================
        // ====================================================================================================================================================================================================================================
    }
}
