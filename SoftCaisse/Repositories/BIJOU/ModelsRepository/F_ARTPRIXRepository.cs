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


        // public void DeleteF_AGENDA(F_ARTPRIX f_AGENDAToDelete)
        // {
        //     string queryDeleteF_AGENDA = @"
        //         DISABLE TRIGGER [dbo].[TG_CBDEL_F_AGENDA] ON [dbo].[F_AGENDA];

        //         DELETE FROM F_AGENDA WHERE DL_No = @DL_No;

        //         ENABLE TRIGGER [dbo].[TG_CBDEL_F_AGENDA] ON [dbo].[F_AGENDA];
        //     ";


        //     using (var context = new AppDbContext())
        //     {
        //         context.Database.ExecuteSqlCommand(
        //             queryDeleteF_AGENDA,
        //             new SqlParameter("@DL_No", f_AGENDAToDelete.DL_No)
        //         );
        //     }

            
        // }
    }
}
