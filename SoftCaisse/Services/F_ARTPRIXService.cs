using SoftCaisse.DTO;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU.IRepository;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SoftCaisse.Services
{
    internal class F_ARTPRIXService
    {
        // =======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES VARIABLES ===================================================
        // =======================================================================================================================================
        private readonly AppDbContext _context;
        private readonly F_ARTPRIXRepository _f_ARTPRIXRepository;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // ====================================================================================================================================
        // ======================================================== DEBUT CONSTRUCTEUR ========================================================
        // ====================================================================================================================================
        public F_ARTPRIXService(AppDbContext context, F_ARTPRIXRepository f_ARTPRIXRepository)
        {
            _context = context;
            _f_ARTPRIXRepository = f_ARTPRIXRepository;
            _f_ARTGAMMERepository = new F_ARTGAMMERepository(_context);
        }
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // =================================================================================================================================================
        // =================================================== DEBUT DES METHODES NE NECESSITANT LE REPO ===================================================
        // =================================================================================================================================================
        
        // =================================================================================================================================================
        // ==================================================== FIN DES METHODES NE NECESSITANT LE REPO ====================================================
        // =================================================================================================================================================





        // ======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES METHODES ===================================================
        // ======================================================================================================================================
        public void CreerF_ARTPRIXGamme1Uniquement(string AR_Ref, decimal? AR_PUNet, decimal? AR_CoutStd)
        {
            int? AG_No1 = _f_ARTGAMMERepository.GetLastAG_No1();

            F_ARTPRIX _f_ARTPRIXToCreate = new F_ARTPRIX();
            _f_ARTPRIXToCreate.AR_Ref = AR_Ref;
            _f_ARTPRIXToCreate.AG_No1 = AG_No1;
            _f_ARTPRIXToCreate.AG_No2 = 0;
            _f_ARTPRIXToCreate.AR_PUNet = AR_PUNet;
            _f_ARTPRIXToCreate.AR_CoutStd = AR_CoutStd;

            _f_ARTPRIXRepository.CreateF_ARTPRIX(_f_ARTPRIXToCreate);
        }




        public void DeleteF_ARTPRIXAyantEG_Enumere(string AR_Ref, string EG_Enumere, bool estGamme2)
        {
            F_ARTGAMME f_ARTGAMME = _f_ARTGAMMERepository.GetByEG_Enumere(EG_Enumere);

            if (estGamme2)
            {
                _f_ARTPRIXRepository.DeleteF_ARTPRIXAG_No2(AR_Ref, f_ARTGAMME.AG_No);
            }
            else
            {
                _f_ARTPRIXRepository.DeleteF_ARTPRIXAG_No1(AR_Ref, f_ARTGAMME.AG_No);
            }
        }


        public void DeleteF_ARTPRIXAyantAG_No1EtAG_No2(string AR_Ref, int? AG_No1, int? AG_No2)
        {
            _f_ARTPRIXRepository.DeleteF_ARTPRIXAyantAG_No1EtAG_No2(AR_Ref, AG_No1, AG_No2);
        }





        public void UpdateF_ARTPRIX(string AR_Ref, int? AG_No1, int? AG_No2, decimal? AR_PUNet, decimal? AR_CoutStd)
        {
            F_ARTPRIX f_ARTPRIXToUpdate = _f_ARTPRIXRepository.GetF_ARTPRIX(AR_Ref, AG_No1, AG_No2);
            _f_ARTPRIXRepository.UpdateAR_PUNet_Et_AR_CoutStdF_ARTPRIX(f_ARTPRIXToUpdate.cbMarq, AR_PUNet, AR_CoutStd);
        }


        public void InsertF_ARTPRIX(string AR_Ref, int? AG_No1, int? AG_No2, decimal? AR_PUNet, decimal? AR_CoutStd)
        {
            F_ARTPRIX _f_ARTPRIXToCreate = new F_ARTPRIX();
            _f_ARTPRIXToCreate.AR_Ref = AR_Ref;
            _f_ARTPRIXToCreate.AG_No1 = AG_No1;
            _f_ARTPRIXToCreate.AG_No2 = AG_No2;
            _f_ARTPRIXToCreate.AR_PUNet = AR_PUNet;
            _f_ARTPRIXToCreate.AR_CoutStd = AR_CoutStd;

            _f_ARTPRIXRepository.CreateF_ARTPRIX(_f_ARTPRIXToCreate);
        }


        // ====================================================================================================================================
        // =================================================== FIN DECLARATION DES METHODES ===================================================
        // ====================================================================================================================================

    }
}
