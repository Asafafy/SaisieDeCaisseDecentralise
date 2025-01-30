using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class F_TARIFGAMRepository
    {
        //private readonly AppDbContext _context;
        public F_TARIFGAMRepository()
        {
            //_context = new AppDbContext();
        }





        public void Nouveau(F_TARIFGAM nouveau_F_TARIFGAM)
        {
            string queryCreateF_TARIFGAM = @"
                DISABLE TRIGGER [dbo].[TG_INS_F_TARIFGAM] ON [dbo].[F_TARIFGAM];
                DISABLE TRIGGER [dbo].[TG_CBINS_F_TARIFGAM] ON [dbo].[F_TARIFGAM];

                INSERT INTO [dbo].[F_TARIFGAM]
                (
                    AR_Ref,
                    TG_RefCF,
                    AG_No1,
                    AG_No2,
                    TG_Prix,
                    TG_Ref,
                    TG_CodeBarre,
                    TG_PrixNouv,
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
                    @TG_RefCF,
                    @AG_No1,
                    @AG_No2,
                    @TG_Prix,
                    '',
                    '',
                    0,
                    0,
                    'COLS',
                    GETDATE(),
                    0,
                    0,
                    GETDATE()
                );
                
                ENABLE TRIGGER [dbo].[TG_INS_F_TARIFGAM] ON [dbo].[F_TARIFGAM];
                ENABLE TRIGGER [dbo].[TG_CBINS_F_TARIFGAM] ON [dbo].[F_TARIFGAM];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryCreateF_TARIFGAM,
                    new SqlParameter("@AR_Ref", nouveau_F_TARIFGAM.AR_Ref),
                    new SqlParameter("@TG_RefCF", nouveau_F_TARIFGAM.TG_RefCF),
                    new SqlParameter("@AG_No1", nouveau_F_TARIFGAM.AG_No1),
                    new SqlParameter("@AG_No2", nouveau_F_TARIFGAM.AG_No2),
                    new SqlParameter("@TG_Prix", nouveau_F_TARIFGAM.TG_Prix)
                );
            }
        }





    }
}
