using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_GAMSTOCKRepository
    {
        //private readonly AppDbContext _context;

        public F_GAMSTOCKRepository(AppDbContext context)
        {
            //_context = context;
        }



        public void CreateF_GAMSTOCK(F_GAMSTOCK f_GAMSTOCKToCreate)
        {
            string queryCreateF_GAMSTOCK = @"
                -- Utilisation d'un bloc de transaction pour assurer l'intégrité des données
                BEGIN TRY
                    BEGIN TRANSACTION;
                    -- Variable pour stocker la date/heure actuelle
                    DECLARE @CurrentDateTime datetime2(0) = SYSDATETIME();
                    
                    -- Désactivation temporaire des triggers dans un bloc séparé
                    BEGIN
                        ALTER TABLE [dbo].[F_GAMSTOCK] DISABLE TRIGGER [TG_CBINS_F_GAMSTOCK];
                        ALTER TABLE [dbo].[F_GAMSTOCK] DISABLE TRIGGER [TG_INS_F_GAMSTOCK];
                    END;
                
                    -- Vérification de l'existence des données avant insertion
                    IF NOT EXISTS (
                        SELECT 1 
                        FROM [dbo].[F_GAMSTOCK] 
                        WHERE AR_Ref = @AR_Ref 
                          AND AG_No1 = @AG_No1 
                          AND AG_No2 = @AG_No2 
                          AND DE_No = @DE_No
                    )
                    BEGIN
                        INSERT INTO [dbo].[F_GAMSTOCK] (
                            AR_Ref,
                            AG_No1,
                            AG_No2,
                            DE_No,
                            GS_MontSto,
                            GS_QteSto,
                            GS_QteRes,
                            GS_QteCom,
                            GS_QteResCM,
                            GS_QteComCM,
                            GS_QteMini,
                            GS_QteMaxi,
                            GS_QtePrepa,
                            DP_NoPrincipal,
                            cbDP_NoPrincipal,
                            DP_NoControle,
                            cbDP_NoControle,
                            GS_QteAControler,
                            cbCreateur,
                            cbCreationUser,
                            cbModification    -- Nouveau champ pour tracer la modification
                        )
                        VALUES (
                            @AR_Ref,
                            @AG_No1,
                            @AG_No2,
                            @DE_No,
                            0,      -- GS_MontSto
                            0,      -- GS_QteSto
                            0,      -- GS_QteRes
                            0,      -- GS_QteCom
                            0,      -- GS_QteResCM
                            0,      -- GS_QteComCM
                            0,      -- GS_QteMini
                            0,      -- GS_QteMaxi
                            0,      -- GS_QtePrepa
                            0,      -- DP_NoPrincipal
                            NULL,   -- cbDP_NoPrincipal
                            0,      -- DP_NoControle
                            NULL,   -- cbDP_NoControle
                            0,      -- GS_QteAControler
                            'COLS', -- cbCreateur
                            NULL,   -- cbCreationUser
                            @CurrentDateTime  -- cbModification
                        );
                    END;
                
                    -- Réactivation des triggers
                    BEGIN
                        ALTER TABLE [dbo].[F_GAMSTOCK] ENABLE TRIGGER [TG_CBINS_F_GAMSTOCK];
                        ALTER TABLE [dbo].[F_GAMSTOCK] ENABLE TRIGGER [TG_INS_F_GAMSTOCK];
                    END;
                
                    -- Validation de la transaction si tout s'est bien passé
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- En cas d'erreur, annulation de la transaction
                    IF @@TRANCOUNT > 0
                        ROLLBACK TRANSACTION;
                
                    -- Réactivation des triggers en cas d'erreur
                    ALTER TABLE [dbo].[F_GAMSTOCK] ENABLE TRIGGER [TG_CBINS_F_GAMSTOCK];
                    ALTER TABLE [dbo].[F_GAMSTOCK] ENABLE TRIGGER [TG_INS_F_GAMSTOCK];
                
                    -- Affichage des informations d'erreur
                    DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
                    DECLARE @ErrorSeverity int = ERROR_SEVERITY();
                    DECLARE @ErrorState int = ERROR_STATE();
                
                    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                END CATCH;
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryCreateF_GAMSTOCK,
                    new SqlParameter("@AR_Ref", f_GAMSTOCKToCreate.AR_Ref),
                    new SqlParameter("@AG_No1", f_GAMSTOCKToCreate.AG_No1),
                    new SqlParameter("@AG_No2", f_GAMSTOCKToCreate.AG_No2),
                    new SqlParameter("@DE_No", f_GAMSTOCKToCreate.DE_No)
                );
            }
        }


    }
}
