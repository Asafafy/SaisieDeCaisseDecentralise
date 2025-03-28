﻿using SoftCaisse.DTO;
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
    internal class F_ARTICLEService
    {
        // =======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES VARIABLES ===================================================
        // =======================================================================================================================================
        private readonly F_ARTICLERepository _f_ARTICLERepository;
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // ====================================================================================================================================
        // ======================================================== DEBUT CONSTRUCTEUR ========================================================
        // ====================================================================================================================================
        public F_ARTICLEService(F_ARTICLERepository f_ARTICLERepository)
        {
            _f_ARTICLERepository = f_ARTICLERepository;
        }
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================







        // ====================================================================================================================================
        // ================================================== DEBUT DECLARATION DES METHODES ==================================================
        // ====================================================================================================================================
        public F_ARTICLE GetF_ARTICLE_ByAR_Ref_O_uAR_Design(string AR_RefouAR_Design)
        {
            F_ARTICLE articleSaisie = _f_ARTICLERepository.GetF_ARTICLEByAR_Ref(AR_RefouAR_Design);
            if (articleSaisie == null)
                articleSaisie = _f_ARTICLERepository.GetF_ARTICLEByAR_Design(AR_RefouAR_Design);
            return articleSaisie;
        }


        public void UpdateDateModifArticle(string AR_Ref)
        {
            F_ARTICLE f_ARTICLE = _f_ARTICLERepository.GetF_ARTICLEByAR_Ref(AR_Ref);

            _f_ARTICLERepository.UpdateDateModifArticle(f_ARTICLE.cbMarq);
        }
        // ====================================================================================================================================
        // =================================================== FIN DECLARATION DES METHODES ===================================================
        // ====================================================================================================================================

    }
}
