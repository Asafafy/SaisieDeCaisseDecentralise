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
    public class F_ARTGAMMERepository
    {
        // =======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES VARIABLES ===================================================
        // =======================================================================================================================================
        private readonly AppDbContext _context;
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================






        // ====================================================================================================================================
        // ======================================================== DEBUT CONSTRUCTEUR ========================================================
        // ====================================================================================================================================
        public F_ARTGAMMERepository(AppDbContext context)
        {
            _context = context;
        }
        // =====================================================================================================================================
        // =================================================== FIN DECLARATION DES VARIABLES ===================================================
        // =====================================================================================================================================





        // ======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES METHODES ===================================================
        // ======================================================================================================================================
        public void Create(F_ARTGAMME f_ARTGAMME)
        {
            string queryCreateF_ENUMGAMME = @"
                INSERT INTO [dbo].[F_ARTGAMME]
                (
                    AR_Ref,
                    AG_No,
                    EG_Enumere,
                    AG_Type,
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
                    @AG_No,
                    @EG_Enumere,
                    @AG_Type,
                    @cbProt,
                    @cbCreateur,
                    @cbModification,
                    @cbReplication,
                    @cbFlag,
                    @cbCreation
                )";

            //_context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBINS_F_ARTGAMME] ON [dbo].[F_ARTGAMME]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_INS_F_ARTGAMME] ON [dbo].[F_ARTGAMME]");
            _context.Database.ExecuteSqlCommand(
                queryCreateF_ENUMGAMME,
                new SqlParameter("@AR_Ref", f_ARTGAMME.AR_Ref),
                new SqlParameter("@AG_No", f_ARTGAMME.AG_No),
                new SqlParameter("@EG_Enumere", f_ARTGAMME.EG_Enumere),
                new SqlParameter("@AG_Type", f_ARTGAMME.AG_Type),
                new SqlParameter("@cbProt", f_ARTGAMME.cbProt),
                new SqlParameter("@cbCreateur", f_ARTGAMME.cbCreateur),
                new SqlParameter("@cbModification", f_ARTGAMME.cbModification),
                new SqlParameter("@cbReplication", f_ARTGAMME.cbReplication),
                new SqlParameter("@cbFlag", f_ARTGAMME.cbFlag),
                new SqlParameter("@cbCreation", f_ARTGAMME.cbCreation)
            );
            //_context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBINS_F_ARTGAMME] ON [dbo].[F_ARTGAMME]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_INS_F_ARTGAMME] ON [dbo].[F_ARTGAMME]");
        }





        //TODO: Mbola misy tsy milamina eto anh..... Mbola mila étudiena kely aloha vao mety.....
        //public void Update(int cbMarq, string EG_Enumere)
        //{
        //    string queryUpdateF_ENUMGAMME = @"
        //        UPDATE F_ENUMGAMME
        //        SET
        //            EG_Enumere = @EG_Enumere
        //        WHERE cbMarq = @cbMarq
        //    ";

        //    _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_UPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
        //    _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBUPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
        //    _context.Database.ExecuteSqlCommand(
        //    queryUpdateF_ENUMGAMME,
        //        new SqlParameter("@EG_Enumere", EG_Enumere),
        //        new SqlParameter("@cbMarq", cbMarq)
        //    );
        //    _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_UPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
        //    _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBUPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
        //}

        // ====================================================================================================================================
        // =================================================== FIN DECLARATION DES METHODES ===================================================
        // ====================================================================================================================================


    }
}
