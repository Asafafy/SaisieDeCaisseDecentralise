﻿using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.BIJOU.ModelsRepository
{
    public class F_ARTENUMREFRepository
    {
        // ===================================================================================
        // DEBUT DECLARATION DES VARIABLES ===================================================
        // ===================================================================================
        //private readonly AppDbContext _context;
        // ===================================================================================
        // FIN DECLARATION DES VARIABLES =====================================================
        // ===================================================================================





        // ===================================================================================
        // DEBUT CONSTRUCTEUR ================================================================
        // ===================================================================================
        public F_ARTENUMREFRepository(AppDbContext context)
        {
            //_context = context;
        }
        // ===================================================================================
        // FIN DECLARATION DES VARIABLES =====================================================
        // ===================================================================================





        // ===================================================================================
        // DEBUT DECLARATION DES METHODES ====================================================
        // ===================================================================================
        public F_ARTENUMREF GetF_ARTENUMREF(string AR_Ref, int? AG_No1, int? AG_No2)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_ARTENUMREF.Where(f => f.AR_Ref == AR_Ref && f.AG_No1 == AG_No1 && f.AG_No2 == AG_No2).FirstOrDefault();
            }
        }




        public void Create(F_ARTENUMREF nouveauf_ARTENUMREF)
        {
            string queryCreateF_ARTENUMREF = @"
                BEGIN TRANSACTION;

                BEGIN TRY
                    -- Désactivation des triggers
                    DISABLE TRIGGER [dbo].[TG_INS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                    DISABLE TRIGGER [dbo].[TG_CBINS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                
                    -- Insertion des données dans la table F_ARTENUMREF
                    INSERT INTO [dbo].[F_ARTENUMREF]
                    (
                        AR_Ref,
                        AG_No1,
                        AG_No2,
                        AE_Ref,
                        AE_PrixAch,
                        AE_CodeBarre,
                        AE_PrixAchNouv,
                        AE_EdiCode,
                        AE_Sommeil,
                        cbProt,
                        cbCreateur,
                        cbModification,
                        cbReplication,
                        cbFlag,
                        cbCreation
                    )
                    VALUES
                    (
                        @AR_Ref,
                        @AG_No1,
                        @AG_No2,
                        @AE_Ref,
                        @AE_PrixAch,
                        @AE_CodeBarre,
                        0,              -- AE_PrixAchNouv (par défaut)
                        NULL,           -- AE_EdiCode (par défaut)
                        0,              -- AE_Sommeil (par défaut)
                        0,              -- cbProt (par défaut)
                        'COLS',         -- cbCreateur
                        GETDATE(),      -- cbModification
                        0,              -- cbReplication (par défaut)
                        0,              -- cbFlag (par défaut)
                        GETDATE()       -- cbCreation
                    );
                
                    -- Réactivation des triggers après l'insertion
                    ENABLE TRIGGER [dbo].[TG_INS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                    ENABLE TRIGGER [dbo].[TG_CBINS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                
                    -- Validation de la transaction
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- Annulation de la transaction en cas d'erreur
                    ROLLBACK TRANSACTION;
                
                    -- Réactivation des triggers en cas d'erreur pour éviter qu'ils restent désactivés
                    ENABLE TRIGGER [dbo].[TG_INS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                    ENABLE TRIGGER [dbo].[TG_CBINS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                
                    -- Récupération et affichage du message d'erreur
                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
                    RAISERROR(@ErrorMessage, 16, 1);
                END CATCH;
            ";


            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryCreateF_ARTENUMREF,
                    new SqlParameter("@AR_Ref", nouveauf_ARTENUMREF.AR_Ref),
                    new SqlParameter("@AG_No1", nouveauf_ARTENUMREF.AG_No1),
                    new SqlParameter("@AG_No2", nouveauf_ARTENUMREF.AG_No2),
                    new SqlParameter("@AE_Ref", nouveauf_ARTENUMREF.AE_Ref ?? (object)DBNull.Value),
                    new SqlParameter("@AE_PrixAch", nouveauf_ARTENUMREF.AE_PrixAch),
                    new SqlParameter("@AE_CodeBarre", nouveauf_ARTENUMREF.AE_CodeBarre ?? (object)DBNull.Value)
                );
            }


            
        }




        public  void UpdateF_ARTENUMRF(decimal? AE_PrixAch, string AE_Ref, string AE_CodeBarre, string AE_EdiCode, int cbMarq)
        {
            string queryUpdateF_ARTENUMREF = @"                
                BEGIN TRANSACTION;
                
                IF EXISTS (SELECT 1 FROM F_ARTENUMREF WHERE cbMarq = @cbMarq)
                	BEGIN
                	    UPDATE F_ARTENUMREF
                	    SET AE_PrixAch   = @AE_PrixAch,
                	        AE_Ref       = @AE_Ref,
                	        AE_CodeBarre = @AE_CodeBarre,
                	        AE_EdiCode   = @AE_EdiCode
                	    WHERE cbMarq = @cbMarq;
                	
                	    COMMIT;
                	END
                ELSE
                	BEGIN
                	    ROLLBACK;
                	END;
            ";


            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryUpdateF_ARTENUMREF,
                    new SqlParameter("@AE_PrixAch", AE_PrixAch),
                    new SqlParameter("@AE_Ref", AE_Ref ?? (object)DBNull.Value),
                    new SqlParameter("@AE_CodeBarre", AE_CodeBarre ?? (object)DBNull.Value),
                    new SqlParameter("@AE_EdiCode", AE_EdiCode ?? (object)DBNull.Value),
                    new SqlParameter("@cbMarq", cbMarq)
                );
            }
        }




        public void DeleteF_ARTENUMREFAyantAG_No1(int? AG_No1, string AR_Ref)
        {
            string queryDeleteF_ARTENUMREFAG_No1 = @"
                DISABLE TRIGGER ALL ON [dbo].[F_ARTENUMREF];
                
                DELETE FROM [dbo].[F_ARTENUMREF]  
                WHERE AG_No1 = @AG_No1 AND AR_Ref = @AR_Ref;
                
                ENABLE TRIGGER ALL ON [dbo].[F_ARTENUMREF];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteF_ARTENUMREFAG_No1,
                    new SqlParameter("@AG_No1", AG_No1),
                    new SqlParameter("@AR_Ref", AR_Ref)
                );
            }
        }




        public void DeleteF_ARTENUMREFAyantAG_No2(int? AG_No2, string AR_Ref)
        {
            string queryDeleteF_ARTENUMREFAG_No2 = @"
                DISABLE TRIGGER ALL ON [dbo].[F_ARTENUMREF];
                
                DELETE FROM [dbo].[F_ARTENUMREF]  
                WHERE AG_No2 = @AG_No2 AND AR_Ref = @AR_Ref;
                
                ENABLE TRIGGER ALL ON [dbo].[F_ARTENUMREF];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteF_ARTENUMREFAG_No2,
                    new SqlParameter("@AG_No2", AG_No2),
                    new SqlParameter("@AR_Ref", AR_Ref)
                );
            }
        }
        // ================================================================================
        // FIN DECLARATION DES METHODES ===================================================
        // ================================================================================
    }
}
