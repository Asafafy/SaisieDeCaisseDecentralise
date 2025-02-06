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
    internal class F_ARTENUMREFService
    {
        // =======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES VARIABLES ===================================================
        // =======================================================================================================================================
        private readonly AppDbContext _context;
        private readonly F_ARTENUMREFRepository _f_ARTENUMREFRepository;
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // ====================================================================================================================================
        // ======================================================== DEBUT CONSTRUCTEUR ========================================================
        // ====================================================================================================================================
        public F_ARTENUMREFService(AppDbContext context, F_ARTENUMREFRepository f_ARTENUMREFRepository)
        {
            _context = context;
            _f_ARTENUMREFRepository = f_ARTENUMREFRepository;
        }
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // =================================================================================================================================================
        // =================================================== DEBUT DES METHODES NE NECESSITANT LE REPO ===================================================
        // =================================================================================================================================================
        public List<(int?, int?)> GetCombinaisonsAG_No(F_ARTICLE article, int estAG_No2, short? AG_No)
        {
            List<(int?, int?)> listeAG_No = new List<(int?, int?)>();

            List<int?> listeAG_No1 = new List<int?>();
            List<int?> listeAG_No2 = new List<int?>();

            if (article.AR_Gamme2 == 0)
            {
                listeAG_No1.Add(AG_No);
                listeAG_No2.Add(0);
            }
            else
            {
                if (estAG_No2 == 1)
                {
                    listeAG_No1 = _context.F_ARTGAMME.Where(ag => ag.AG_Type == 0 && ag.AR_Ref == article.AR_Ref).Select(ag => ag.AG_No).ToList();
                    listeAG_No2.Add(AG_No);
                }
                else
                {
                    listeAG_No1.Add(AG_No);
                    listeAG_No2 = _context.F_ARTGAMME.Where(ag => ag.AG_Type == 1 && ag.AR_Ref == article.AR_Ref && ag.AG_No != AG_No).Select(ag => ag.AG_No).ToList();
                }
            }

            // Générer les combinaisons des AG_No dans une tuple
            foreach (var AG_No1 in listeAG_No1)
            {
                foreach (var AG_No2 in listeAG_No2)
                {
                    listeAG_No.Add((AG_No1, AG_No2));
                }
            }

            return listeAG_No;
        }
        // =================================================================================================================================================
        // ==================================================== FIN DES METHODES NE NECESSITANT LE REPO ====================================================
        // =================================================================================================================================================





        // ======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES METHODES ===================================================
        // ======================================================================================================================================
        public void NouveauGamme(string AR_Ref, int estAG_No2, short? AG_No, string AE_Ref, string AE_CodeBarre, decimal? AR_PrixAch)
        {
            F_ARTICLE article = _context.F_ARTICLE.Where(a => a.AR_Ref == AR_Ref).FirstOrDefault();

            List<(int?, int?)>  listeAG_No = GetCombinaisonsAG_No(article, estAG_No2, AG_No);

            foreach (var (AG_No1, AG_No2) in listeAG_No)
            {
                F_ARTENUMREF f_ARTENUMREFToCreate = new F_ARTENUMREF();

                f_ARTENUMREFToCreate.AR_Ref = article.AR_Ref;
                f_ARTENUMREFToCreate.AG_No1 = AG_No1;
                f_ARTENUMREFToCreate.AG_No2 = AG_No2;
                f_ARTENUMREFToCreate.AE_Ref = AE_Ref == "" ? null : AE_Ref;
                f_ARTENUMREFToCreate.AE_PrixAch = AR_PrixAch == null ? article.AR_PrixAch : AR_PrixAch;
                f_ARTENUMREFToCreate.AE_CodeBarre = AE_CodeBarre == "" ? null : AE_CodeBarre;

                _f_ARTENUMREFRepository.Create(f_ARTENUMREFToCreate);
            }
        }





        public void NouveauGammePasAPas(string AR_Ref, int? AG_No1, int? AG_No2, string AE_Ref, string AE_CodeBarre, decimal? AR_PrixAch)
        {
            F_ARTICLE article = _context.F_ARTICLE.Where(a => a.AR_Ref == AR_Ref).FirstOrDefault();
            F_ARTENUMREF f_ARTENUMREFToCreate = new F_ARTENUMREF();

            f_ARTENUMREFToCreate.AR_Ref = article.AR_Ref;
            f_ARTENUMREFToCreate.AG_No1 = AG_No1;
            f_ARTENUMREFToCreate.AG_No2 = AG_No2;
            f_ARTENUMREFToCreate.AE_Ref = AE_Ref == "" ? null : AE_Ref;
            f_ARTENUMREFToCreate.AE_PrixAch = AR_PrixAch;
            f_ARTENUMREFToCreate.AE_CodeBarre = AE_CodeBarre == "" ? null : AE_CodeBarre;

            _f_ARTENUMREFRepository.Create(f_ARTENUMREFToCreate);
        }


        // ====================================================================================================================================
        // =================================================== FIN DECLARATION DES METHODES ===================================================
        // ====================================================================================================================================

    }
}
