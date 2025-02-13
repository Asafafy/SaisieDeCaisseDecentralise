using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_ARTPRIXRepository
    {
        //private readonly AppDbContext _context;

        public F_ARTPRIXRepository(AppDbContext context)
        {
            //_context = context;
        }





        public F_ARTPRIX GetF_ARTPRIX(string AR_Ref, int? AG_No1, int? AG_No2)
        {
            F_ARTPRIX f_ARTPRIX = new F_ARTPRIX();
            using (AppDbContext context = new AppDbContext())
            {
                f_ARTPRIX = context.F_ARTPRIX.Where(f => f.AR_Ref == AR_Ref && f.AG_No1 == AG_No1 && f.AG_No2 == AG_No2).FirstOrDefault();
            }
            if (f_ARTPRIX == null)
            {
                f_ARTPRIX = new F_ARTPRIX();
                f_ARTPRIX.AR_Ref = AR_Ref;
                f_ARTPRIX.AG_No1 = AG_No1;
                f_ARTPRIX.AG_No2 = AG_No2;
                f_ARTPRIX.AR_CoutStd = 0;
                f_ARTPRIX.AR_PUNet = 0;
                return f_ARTPRIX;
            }
            else
            {
                return f_ARTPRIX;
            }
        }





        public void CreateF_ARTPRIX(F_ARTPRIX f_ARTPRIXToCreate)
        {
            string queryCreateF_ARTPRIX = @"
                BEGIN TRANSACTION;

                BEGIN TRY
                    -- Désactiver les triggers
                    DISABLE TRIGGER [TG_INS_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    DISABLE TRIGGER [TG_CBINS_F_ARTPRIX] ON [dbo].[F_ARTPRIX];

                    -- Insertion des données
                    INSERT INTO [dbo].[F_ARTPRIX] (
                        AR_Ref, AG_No1, AG_No2, AR_PUNet, AR_CoutStd, cbProt, cbCreateur, 
                        cbModification, cbReplication, cbFlag, cbCreation, cbCreationUser
                    )
                    VALUES (
                        @AR_Ref, @AG_No1, @AG_No2, @AR_PUNet, @AR_CoutStd,
                		0, 'COLS', GETDATE(), 0, 0, GETDATE(), NULL
                    );

                    -- Réactiver les triggers
                    ENABLE TRIGGER [TG_INS_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    ENABLE TRIGGER [TG_CBINS_F_ARTPRIX] ON [dbo].[F_ARTPRIX];

                    -- Valider la transaction
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- Annuler la transaction en cas d'erreur
                    ROLLBACK TRANSACTION;

                    -- Réactiver les triggers même en cas d'erreur
                    ENABLE TRIGGER [TG_INS_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    ENABLE TRIGGER [TG_CBINS_F_ARTPRIX] ON [dbo].[F_ARTPRIX];

                    -- Afficher l'erreur
                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
                    RAISERROR(@ErrorMessage, 16, 1);
                END CATCH;
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryCreateF_ARTPRIX,
                    new SqlParameter("@AR_Ref", f_ARTPRIXToCreate.AR_Ref),
                    new SqlParameter("@AG_No1", f_ARTPRIXToCreate.AG_No1),
                    new SqlParameter("@AG_No2", f_ARTPRIXToCreate.AG_No2),
                    new SqlParameter("@AR_PUNet", f_ARTPRIXToCreate.AR_PUNet),
                    new SqlParameter("@AR_CoutStd", f_ARTPRIXToCreate.AR_CoutStd)
                );
            }
        }


        public void DeleteF_ARTPRIXAG_No1(string AR_Ref, int? AG_No1)
        {
            string queryDeleteF_ARTPRIX = @"
                BEGIN TRY
                    -- Démarrer une transaction
                    BEGIN TRANSACTION;
                
                    -- Désactiver les triggers avant la suppression
                    DISABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    DISABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Suppression sécurisée avec vérification préalable
                    IF EXISTS (SELECT 1 FROM [dbo].[F_ARTPRIX] WHERE AR_Ref = @AR_Ref AND AG_No1 = @AG_No1)
                    BEGIN
                        DELETE FROM [dbo].[F_ARTPRIX] 
                		WHERE AR_Ref = @AR_Ref AND AG_No1 = @AG_No1;
                    END
                
                    -- Valider la transaction si tout s'est bien passé
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- Annuler la transaction en cas d'erreur
                    ROLLBACK TRANSACTION;
                
                    -- Réactiver les triggers même en cas d'erreur
                    ENABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    ENABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Capturer et afficher l'erreur
                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
                    DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
                    DECLARE @ErrorState INT = ERROR_STATE();
                
                    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                    RETURN;
                END CATCH;
                
                -- Réactiver les triggers si tout s'est bien passé
                ENABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                ENABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteF_ARTPRIX,
                    new SqlParameter("@AR_Ref", AR_Ref),
                    new SqlParameter("@AG_No1", AG_No1)
                );
            }
        }



        public void DeleteF_ARTPRIXAG_No2(string AR_Ref, int? AG_No2)
        {
            string queryDeleteF_ARTPRIX = @"
                BEGIN TRY
                    -- Démarrer une transaction
                    BEGIN TRANSACTION;
                
                    -- Désactiver les triggers avant la suppression
                    DISABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    DISABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Suppression sécurisée avec vérification préalable
                    IF EXISTS (SELECT 1 FROM [dbo].[F_ARTPRIX] WHERE AR_Ref = @AR_Ref AND AG_No2 = @AG_No2)
                    BEGIN
                        DELETE FROM [dbo].[F_ARTPRIX] 
                		WHERE AR_Ref = @AR_Ref AND AG_No2 = @AG_No2;
                    END
                
                    -- Valider la transaction si tout s'est bien passé
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- Annuler la transaction en cas d'erreur
                    ROLLBACK TRANSACTION;
                
                    -- Réactiver les triggers même en cas d'erreur
                    ENABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    ENABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Capturer et afficher l'erreur
                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
                    DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
                    DECLARE @ErrorState INT = ERROR_STATE();
                
                    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                    RETURN;
                END CATCH;
                
                -- Réactiver les triggers si tout s'est bien passé
                ENABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                ENABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteF_ARTPRIX,
                    new SqlParameter("@AR_Ref", AR_Ref),
                    new SqlParameter("@AG_No2", AG_No2)
                );
            }
        }


        public void DeleteF_ARTPRIXAyantAG_No1EtAG_No2(string AR_Ref, int? AG_No1, int? AG_No2)
        {
            string queryDeleteF_ARTPRIXAG_No1EtAG_No2 = @"
                BEGIN TRY
                    -- Démarrer une transaction
                    BEGIN TRANSACTION;
                
                    -- Désactiver les triggers avant la suppression
                    DISABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    DISABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Suppression sécurisée avec vérification préalable
                    IF EXISTS (SELECT 1 FROM [dbo].[F_ARTPRIX] WHERE AR_Ref = @AR_Ref AND AG_No1 = @AG_No1 AND AG_No2 = @AG_No2)
                    BEGIN
                        DELETE FROM [dbo].[F_ARTPRIX] 
                		WHERE AR_Ref = @AR_Ref AND AG_No1 = @AG_No1 AND AG_No2 = @AG_No2;
                    END
                
                    -- Valider la transaction si tout s'est bien passé
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- Annuler la transaction en cas d'erreur
                    ROLLBACK TRANSACTION;
                
                    -- Réactiver les triggers même en cas d'erreur
                    ENABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    ENABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Capturer et afficher l'erreur
                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
                    DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
                    DECLARE @ErrorState INT = ERROR_STATE();
                
                    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                    RETURN;
                END CATCH;
                
                -- Réactiver les triggers si tout s'est bien passé
                ENABLE TRIGGER [dbo].[TG_CBDEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                ENABLE TRIGGER [dbo].[TG_DEL_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteF_ARTPRIXAG_No1EtAG_No2,
                    new SqlParameter("@AR_Ref", AR_Ref),
                    new SqlParameter("@AG_No1", AG_No1),
                    new SqlParameter("@AG_No2", AG_No2)
                );
            }
        }




        public void UpdateAR_PUNet_Et_AR_CoutStdF_ARTPRIX(int cbMarq, decimal? AR_PUNet, decimal? AR_CoutStd)
        {
            string queryUpdateAR_PUNet_Et_AR_CoutStdF_ARTPRIX = @"
                BEGIN TRY
                    -- Démarrer une transaction
                    BEGIN TRANSACTION;
                
                    -- Désactiver les triggers avant la mise à jour
                    DISABLE TRIGGER [dbo].[TG_CBUPD_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    DISABLE TRIGGER [dbo].[TG_UPD_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Vérifier si la ligne existe avant d’exécuter l’UPDATE
                    IF EXISTS (SELECT 1 FROM [dbo].[F_ARTPRIX] WHERE cbMarq = @cbMarq)
                    BEGIN
                        UPDATE [dbo].[F_ARTPRIX]
                        SET AR_PUNet = @AR_PUNet,
                            AR_CoutStd = @AR_CoutStd
                        WHERE cbMarq = @cbMarq;
                    END
                
                    -- Valider la transaction si tout s'est bien passé
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    -- Annuler la transaction en cas d'erreur
                    ROLLBACK TRANSACTION;
                
                    -- Réactiver les triggers même en cas d'erreur
                    ENABLE TRIGGER [dbo].[TG_CBUPD_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                    ENABLE TRIGGER [dbo].[TG_UPD_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                
                    -- Lever l'erreur pour diagnostic
                    DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
                    DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
                    DECLARE @ErrorState INT = ERROR_STATE();
                
                    RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
                    RETURN;
                END CATCH;
                
                -- Réactiver les triggers si tout s'est bien passé
                ENABLE TRIGGER [dbo].[TG_CBUPD_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
                ENABLE TRIGGER [dbo].[TG_UPD_F_ARTPRIX] ON [dbo].[F_ARTPRIX];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryUpdateAR_PUNet_Et_AR_CoutStdF_ARTPRIX,
                    new SqlParameter("@AR_PUNet", AR_PUNet),
                    new SqlParameter("@AR_CoutStd", AR_CoutStd),
                    new SqlParameter("@cbMarq", cbMarq)
                );
            }
        }






    }
}
