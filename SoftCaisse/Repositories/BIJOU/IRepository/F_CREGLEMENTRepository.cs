using SoftCaisse.Models;
using SoftCaisse.Repositories.BIJOU;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_CREGLEMENTRepository
    {
        private readonly AppDbContext _context;
        private readonly F_REGLECHRepository f_REGLECHRepository;





        // ================================================================================================
        // ====================================== DEBUT CONSTRUCTEUR ======================================
        // ================================================================================================
        public F_CREGLEMENTRepository(AppDbContext context)
        {
            _context = context;
            f_REGLECHRepository = new F_REGLECHRepository(context);
        }
        // ================================================================================================
        // ====================================== FIN CONSTRUCTEUR ========================================
        // ================================================================================================





        // ================================================================================================
        // ============================= DÉBUT AJOUT D'UN NOUVEAU REGLEMENT ===============================
        // ================================================================================================
        public void Add(F_CREGLEMENT reglement)
        {
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [TG_CBINS_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [TG_INS_CPTAF_CREGLEMENT] ON [dbo].[F_CREGLEMENT];");

            string query = @"INSERT INTO [dbo].[F_CREGLEMENT]
                (
                        [RG_NO],
                        [RG_Date],
                        [RG_Montant],
                        [N_Reglement],
                        [RG_Impute],
                        [RG_Libelle],
                        [RG_MontantDev], 
                        [RG_Reference],
                        [RG_Compta],
                        [EC_No],
                        [RG_Type],
                        [RG_Cours],
                        [RG_TypeReg],
                        [N_Devise], 
                        [JO_Num], 
                        [RG_Impaye], 
                        [RG_Heure],
                        [RG_Piece],
                        [CA_No],
                        [cbCA_No],
                        [CO_NoCaissier], 
                        [cbCO_NoCaissier],
                        [RG_Transfere],
                        [RG_Cloture],
                        [RG_Ticket],
                        [RG_Souche],
                        [RG_DateEchCont], 
                        [RG_MontantEcart],
                        [RG_NoBonAchat],
                        [RG_Valide],
                        [RG_Anterieur],
                        [RG_MontantCommission], 
                        [RG_MontantNet],
                        [cbProt],
                        [cbModification],
                        [cbReplication],
                        [cbFlag],
                        [cbCreation], 
                        [cbHashVersion],
                        [cbHashDate],
                        [RG_Banque],
                        [CG_Num],
                        [CT_NumPayeur],
                        [CT_NumPayeurOrig]
                ) VALUES (
                {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 
                {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, 
                {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, 
                {30}, {31}, {32}, {33}, {34}, {35}, {36}, {37}, {38}, {39},
                {40}, {41}, {42}, {43}
            )";

            _context.Database.ExecuteSqlCommand(query,
                reglement.RG_No,
                reglement.RG_Date,
                reglement.RG_Montant,
                reglement.N_Reglement,
                reglement.RG_Impute,
                reglement.RG_Libelle,
                reglement.RG_MontantDev,
                reglement.RG_Reference,
                reglement.RG_Compta,
                reglement.EC_No,
                reglement.RG_Type,
                reglement.RG_Cours,
                reglement.RG_TypeReg,
                reglement.N_Devise,
                reglement.JO_Num,
                reglement.RG_Impaye,
                reglement.RG_Heure,
                reglement.RG_Piece,
                reglement.CA_No,
                reglement.cbCA_No,
                reglement.CO_NoCaissier,
                reglement.cbCO_NoCaissier,
                reglement.RG_Transfere,
                reglement.RG_Cloture,
                reglement.RG_Ticket,
                reglement.RG_Souche,
                reglement.RG_DateEchCont,
                reglement.RG_MontantEcart,
                reglement.RG_NoBonAchat,
                reglement.RG_Valide,
                reglement.RG_Anterieur,
                reglement.RG_MontantCommission,
                reglement.RG_MontantNet,
                reglement.cbProt,
                reglement.cbModification,
                reglement.cbReplication,
                reglement.cbFlag,
                reglement.cbCreation,
                reglement.cbHashVersion,
                reglement.cbHashDate,
                reglement.RG_Banque,
                reglement.CG_Num,
                reglement.CT_NumPayeur,
                reglement.CT_NumPayeurOrig
            );

            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [TG_CBINS_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [TG_INS_CPTAF_CREGLEMENT] ON [dbo].[F_CREGLEMENT];");
        }
        // ================================================================================================
        // ============================= DÉBUT AJOUT D'UN NOUVEAU REGLEMENT ===============================
        // ================================================================================================





        // ==============================================================================================
        // ============================= DÉBUT SUPPRESSION D'UN REGLEMENT ===============================
        // ==============================================================================================
        public void Delete(int RG_No)
        {
            // =================== Supprimer d'abord les payements des échéances avec ce reglement ================
            f_REGLECHRepository.DeleteByRG_No(RG_No);

            // =================== Suppression dans F_CREGLEMENT ================
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [TG_CBDEL_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];");
            string queryDeleteFCReglement = @"
                DELETE FROM [dbo].[F_CREGLEMENT] WHERE RG_No = @RG_No;
            ";
            _context.Database.ExecuteSqlCommand(
                queryDeleteFCReglement,
                new SqlParameter("@RG_No", RG_No)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [TG_CBDEL_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];");
        }
        // ============================================================================================
        // ============================= FIN SUPPRESSION D'UN REGLEMENT ===============================
        // ============================================================================================





        // ==============================================================================================
        // =================================== DÉBUT METHODE GET ALL ====================================
        // ==============================================================================================
        public List<F_CREGLEMENT> GetAll()
        {
            return _context.F_CREGLEMENT.ToList();
        }
        // ==============================================================================================
        // ==================================== FIN METHODE GET ALL =====================================
        // ==============================================================================================





        // ==============================================================================================
        // =================================== DEBUT METHODE GET BY ID ==================================
        // ==============================================================================================
        public F_CREGLEMENT GetById(int id)
        {
            return _context.F_CREGLEMENT.FirstOrDefault(u => u.CA_No == id);
        }
        // ==============================================================================================
        // ==================================== FIN METHODE GET BY ID ===================================
        // ==============================================================================================
    }
}
