using SoftCaisse.DTO;
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
        // =======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES VARIABLES ===================================================
        // =======================================================================================================================================
        //private readonly AppDbContext _context;
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // ====================================================================================================================================
        // ======================================================== DEBUT CONSTRUCTEUR ========================================================
        // ====================================================================================================================================
        public F_ARTENUMREFRepository(AppDbContext context)
        {
            //_context = context;
        }
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // ======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES METHODES ===================================================
        // ======================================================================================================================================
        public void Create(F_ARTENUMREF nouveauf_ARTENUMREF)
        {
            string queryCreateF_ARTENUMREF = @"
                DISABLE TRIGGER [dbo].[TG_INS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                DISABLE TRIGGER [dbo].[TG_CBINS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];

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
                    0,
                    NULL,
                    0,
                    0,
                    'COLS',
                    GETDATE(),
                    0,
                    0,
                    GETDATE()
                );
                
                ENABLE TRIGGER [dbo].[TG_INS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
                ENABLE TRIGGER [dbo].[TG_CBINS_F_ARTENUMREF] ON [dbo].[F_ARTENUMREF];
            ";


            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryCreateF_ARTENUMREF,
                    new SqlParameter("@AR_Ref", nouveauf_ARTENUMREF.AR_Ref),
                    new SqlParameter("@AG_No1", nouveauf_ARTENUMREF.AG_No1),
                    new SqlParameter("@AG_No2", nouveauf_ARTENUMREF.AG_No2),
                    new SqlParameter("@AE_Ref", nouveauf_ARTENUMREF.AE_Ref),
                    new SqlParameter("@AE_PrixAch", nouveauf_ARTENUMREF.AE_PrixAch),
                    new SqlParameter("@AE_CodeBarre", nouveauf_ARTENUMREF.AE_CodeBarre)
                );
            }


            
        }



        // ====================================================================================================================================
        // =================================================== FIN DECLARATION DES METHODES ===================================================
        // ====================================================================================================================================
    }
}
