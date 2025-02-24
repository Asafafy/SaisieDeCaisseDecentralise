using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace SoftCaisse.Repositories.BIJOU
{
    internal class F_REGLECHRepository
    {
        private readonly AppDbContext _context;
        public F_REGLECHRepository(AppDbContext context)
        {
            _context = context;
        }





        // ==========================================================================================================================================
        // ============================================================== DEBUT CREATE ==============================================================
        // ==========================================================================================================================================

        // ===========================================================================================================
        // ==================================== DEBUT AJOUT D'UN NOUVEAU REGLEMENT ===================================
        public void AddReglech(int RG_No, int drNo, string doPieceNo, decimal rcMontant, int estRegle)
        {
            string queryForAdd = @"
                DISABLE TRIGGER [dbo].[TG_CBINS_F_REGLECH] ON [dbo].[F_REGLECH];
                DISABLE TRIGGER [dbo].[TG_INS_F_REGLECH] ON [dbo].[F_REGLECH];

                Insert INTO [dbo].[F_REGLECH] (
                    RG_No,
                    DR_No,
                    DO_Domaine,
                    DO_Type,
                    DO_Piece,
                    RC_Montant,
                    RG_TypeReg,
                    cbCreateur
                )
				VALUES(
                    @RG_No,
                    @DR_No,
                    0,
                    6,
                    @DO_Piece,
                    @RC_Montant,
                    0,
                    'COLS'
                );

                ENABLE TRIGGER [dbo].[TG_CBINS_F_REGLECH] ON [dbo].[F_REGLECH];
                ENABLE TRIGGER [dbo].[TG_INS_F_REGLECH] ON [dbo].[F_REGLECH];
            ";

            using(var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryForAdd,
                    new SqlParameter("@RG_No", RG_No),
                    new SqlParameter("@DR_No", drNo),
                    new SqlParameter("@DO_Piece", doPieceNo),
                    new SqlParameter("@RC_Montant", rcMontant)
                );
            }


            string queryFDocRegl = @"
                DISABLE TRIGGER TG_CBUPD_F_DOCREGL ON F_DOCREGL;
                DISABLE TRIGGER TG_UPD_F_DOCREGL ON F_DOCREGL;

                UPDATE F_DOCREGL
                SET DR_Regle = @estRegle
                WHERE DR_No = @DR_No;

                DISABLE TRIGGER TG_CBUPD_F_DOCREGL ON F_DOCREGL;
                DISABLE TRIGGER TG_UPD_F_DOCREGL ON F_DOCREGL;
            ";

            using(var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryFDocRegl,
                    new SqlParameter("@estRegle", estRegle),
                    new SqlParameter("@DR_No", drNo)
                );
            }
        }
        // ==================================== FIN AJOUT D'UN NOUVEAU REGLEMENT ===================================
        // =========================================================================================================

        // ========================================================================================================================================
        // ============================================================== FIN CREATE ==============================================================
        // ========================================================================================================================================









        // ==========================================================================================================================================
        // ============================================================== DEBUT UPDATE ==============================================================
        // ==========================================================================================================================================
        public void UpdateRC_Montant(decimal RC_Montant, int RG_No, int DR_No)
        {
            string query = @"
                DISABLE TRIGGER TG_CBUPD_F_REGLECH ON F_REGLECH;

                UPDATE F_REGLECH
                SET RC_Montant = @RC_Montant
                WHERE RG_No = @RG_No AND DR_No = @DR_No;

                ENABLE TRIGGER TG_CBUPD_F_REGLECH ON F_REGLECH;
            ";

            using(var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    query,
                    new SqlParameter("@RC_Montant", RC_Montant),
                    new SqlParameter("@RG_No", RG_No),
                    new SqlParameter("@DR_No", DR_No)
                );
            }
        }


        // ========================================================================================================================================
        // ============================================================== FIN UPDATE ==============================================================
        // ========================================================================================================================================








        // ==========================================================================================================================================
        // ============================================================== DEBUT DELETE ==============================================================
        // ==========================================================================================================================================

        // ===========================================================================================================================================
        // ==================================== DEBUT SUPPRESSION D'UN REGLEMENT PAR NUMERO DE PIECE D'UN DOCUMENT ===================================
        public void DeleteByDoPiece(string DO_Piece)
        {
            string queryDeleteAvecCommande = @"
                DISABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH;
                DISABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH;

                DELETE FROM [dbo].[F_REGLECH] WHERE DO_Piece = @DO_Piece;

                ENABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH;
                ENABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH;
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteAvecCommande,
                    new SqlParameter("@DO_Piece", DO_Piece)
                );
            }
        }
        // ==================================== FIN SUPPRESSION D'UN REGLEMENT PAR NUMERO DE PIECE D'UN DOCUMENT ===================================
        // =========================================================================================================================================





        // =================================================================================================================================================
        // ==================================== DEBUT SUPPRESSION D'UN REGLEMENT PAR NUMERO DE REGLEMENT DE COMPTE TIERS ===================================
        public void DeleteByRG_No(int RG_No)
        {
            string queryDeleteAvecCommande = @"
                DISABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH;
                DISABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH;

                DELETE FROM [dbo].[F_REGLECH] WHERE RG_No = @RG_No;

                ENABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH;
                ENABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH;
            ";
            _context.Database.ExecuteSqlCommand(
                queryDeleteAvecCommande,
                new SqlParameter("@RG_No", RG_No)
            );
        }
        // ==================================== FIN SUPPRESSION D'UN REGLEMENT PAR NUMERO DE REGLEMENT DE COMPTE TIERS ===================================
        // ===============================================================================================================================================

        // ========================================================================================================================================
        // ============================================================== FIN DELETE ==============================================================
        // ========================================================================================================================================
    }
}
