﻿using SoftCaisse.Models;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class FArtilceRepository
    {
        private readonly AppDbContext dbContext;

        public FArtilceRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public F_ARTICLE GetByRefDes(string referenceArt, string designArt)
        {
            return dbContext.F_ARTICLE
                .Where(article => article.AR_Ref == referenceArt && article.AR_Design == designArt)
                .FirstOrDefault();
            //.Select(article => new F_ARTICLE
            // {
            //     AR_Ref = article.AR_Ref,
            //     cbAR_Ref = article.cbAR_Ref,
            //     AR_Design = article.AR_Design,
            //     cbAR_Design = article.cbAR_Design,
            //     FA_CodeFamille = article.FA_CodeFamille,
            //     cbFA_CodeFamille = article.cbFA_CodeFamille,
            //     AR_Substitut = article.AR_Substitut,
            //     cbAR_Substitut = article.cbAR_Substitut,
            //     AR_Raccourci = article.AR_Raccourci,
            //     cbAR_Raccourci = article.cbAR_Raccourci,
            //     AR_Garantie = article.AR_Garantie,
            //     AR_UnitePoids = article.AR_UnitePoids,
            //     AR_PoidsNet = article.AR_PoidsNet,
            //     AR_PoidsBrut = article.AR_PoidsBrut,
            //     AR_UniteVen = article.AR_UniteVen,
            //     AR_PrixAch = article.AR_PrixAch,
            //     AR_Coef = article.AR_Coef,
            //     AR_PrixVen = article.AR_PrixVen,
            //     AR_PrixTTC = article.AR_PrixTTC,
            //     AR_Gamme1 = article.AR_Gamme1,
            //     AR_Gamme2 = article.AR_Gamme2,
            //     AR_SuiviStock = article.AR_SuiviStock,
            //     AR_Nomencl = article.AR_Nomencl,
            //     AR_Stat01 = article.AR_Stat01,
            //     AR_Stat02 = article.AR_Stat02,
            //     AR_Stat03 = article.AR_Stat03,
            //     AR_Stat04 = article.AR_Stat04,
            //     AR_Stat05 = article.AR_Stat05,
            //     AR_Escompte = article.AR_Escompte,
            //     AR_Delai = article.AR_Delai,
            //     AR_HorsStat = article.AR_HorsStat,
            //     AR_VteDebit = article.AR_VteDebit,
            //     AR_NotImp = article.AR_NotImp,
            //     AR_Sommeil = article.AR_Sommeil,
            //     AR_Langue1 = article.AR_Langue1,
            //     AR_Langue2 = article.AR_Langue2,
            //     AR_EdiCode = article.AR_CodeBarre,
            //     cbAR_CodeBarre = article.cbAR_CodeBarre,
            //     AR_CodeFiscal = article.AR_CodeFiscal,
            //     AR_Pays = article.AR_Pays,
            //     AR_Frais01FR_Denomination = article.AR_Frais01FR_Denomination,
            //     AR_Frais01FR_Rem01REM_Valeur = article.AR_Frais01FR_Rem01REM_Valeur,
            //     AR_Frais01FR_Rem01REM_Type = article.AR_Frais01FR_Rem01REM_Type,
            //     AR_Frais01FR_Rem02REM_Valeur = article.AR_Frais01FR_Rem02REM_Valeur,
            //     AR_Frais01FR_Rem02REM_Type = article.AR_Frais01FR_Rem02REM_Type,
            //     AR_Frais01FR_Rem03REM_Valeur = article.AR_Frais01FR_Rem03REM_Valeur,
            //     AR_Frais01FR_Rem03REM_Type = article.AR_Frais01FR_Rem03REM_Type,
            //     AR_Frais02FR_Denomination = article.AR_Frais02FR_Denomination,
            //     AR_Frais02FR_Rem01REM_Valeur = article.AR_Frais02FR_Rem01REM_Valeur,
            //     AR_Frais02FR_Rem01REM_Type = article.AR_Frais02FR_Rem01REM_Type,
            //     AR_Frais02FR_Rem02REM_Valeur = article.AR_Frais02FR_Rem02REM_Valeur,
            //     AR_Frais02FR_Rem02REM_Type = article.AR_Frais02FR_Rem02REM_Type,
            //     AR_Frais02FR_Rem03REM_Valeur = article.AR_Frais02FR_Rem03REM_Valeur,
            //     AR_Frais02FR_Rem03REM_Type = article.AR_Frais02FR_Rem03REM_Type,
            //     AR_Frais03FR_Denomination = article.AR_Frais03FR_Denomination,
            //     AR_Frais03FR_Rem01REM_Valeur = article.AR_Frais03FR_Rem01REM_Valeur,
            //     AR_Frais03FR_Rem01REM_Type = article.AR_Frais03FR_Rem01REM_Type,
            //     AR_Frais03FR_Rem02REM_Valeur = article.AR_Frais03FR_Rem02REM_Valeur,
            //     AR_Frais03FR_Rem02REM_Type = article.AR_Frais03FR_Rem02REM_Type,
            //     AR_Frais03FR_Rem03REM_Valeur = article.AR_Frais03FR_Rem03REM_Valeur,
            //     AR_Frais03FR_Rem03REM_Type = article.AR_Frais03FR_Rem03REM_Type,
            //     AR_Condition = article.AR_Condition,
            //     AR_PUNet = article.AR_PUNet,
            //     AR_Contremarque = article.AR_Contremarque,
            //     AR_FactPoids = article.AR_FactPoids,
            //     AR_FactForfait = article.AR_FactForfait,
            //     AR_SaisieVar = article.AR_SaisieVar,
            //     AR_Transfere = article.AR_Transfere,
            //     AR_Publie = article.AR_Publie,
            //     AR_DateModif = article.AR_DateModif,
            //     AR_Photo = article.AR_Photo,
            //     AR_PrixAchNouv = article.AR_PrixAchNouv,
            //     AR_CoefNouv = article.AR_CoefNouv,
            //     AR_PrixVenNouv = article.AR_PrixVenNouv,
            //     AR_DateApplication = article.AR_DateApplication,
            //     AR_CoutStd = article.AR_CoutStd,
            //     AR_QteComp = article.AR_QteComp,
            //     AR_QteOperatoire = article.AR_QteOperatoire,
            //     CO_No = article.CO_No,
            //     cbCO_No = article.cbCO_No,
            //     AR_Prevision = article.AR_Prevision,
            //     CL_No1 = article.CL_No1,
            //     cbCL_No1 = article.cbCL_No1,
            //     CL_No2 = article.CL_No2,
            //     cbCL_No2 = article.cbCL_No2,
            //     CL_No3 = article.CL_No3,
            //     cbCL_No3 = article.cbCL_No3,
            //     CL_No4 = article.CL_No4,
            //     cbCL_No4 = article.cbCL_No4,
            //     AR_Type = article.AR_Type,
            //     RP_CodeDefaut = article.RP_CodeDefaut,
            //     AR_Nature = article.AR_Nature,
            //     AR_DelaiFabrication = article.AR_DelaiFabrication,
            //     AR_NbColis = article.AR_NbColis,
            //     AR_DelaiPeremption = article.AR_DelaiPeremption,
            //     AR_DelaiSecurite = article.AR_DelaiSecurite,
            //     AR_Fictif = article.AR_Fictif,
            //     AR_SousTraitance = article.AR_SousTraitance,
            //     AR_TypeLancement = article.AR_TypeLancement,
            //     AR_Cycle = article.AR_Cycle,
            //     AR_Criticite = article.AR_Criticite,
            //     cbProt = article.cbProt,
            //     cbMarq = article.cbMarq,
            //     cbCreateur = article.cbCreateur,
            //     cbModification = article.cbModification,
            //     cbReplication = article.cbReplication,
            //     cbFlag = article.cbFlag,
            //     cbCreation = article.cbCreation,
            //     cbCreationUser = article.cbCreationUser,
            //     Marque_commerciale = article.Marque_commerciale,
            //     Objectif___Qtés_vendues = article.Objectif___Qtés_vendues,
            //     Pourcentage_teneur_en_or = article.Pourcentage_teneur_en_or,
            //     C1ère_commercialisation = article.C1ère_commercialisation
            // })
        }
    }
}