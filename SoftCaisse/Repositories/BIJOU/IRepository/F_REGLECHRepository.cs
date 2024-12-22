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
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBINS_F_REGLECH] ON [dbo].[F_REGLECH]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_INS_F_REGLECH] ON [dbo].[F_REGLECH]");

            string queryForAdd = @"
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
				values(
                    {0},
					{1},
					{2},
					{3},
					{4},
					{5},
					{6},
					{7}
                )
            ";

            _context.Database.ExecuteSqlCommand(queryForAdd,
                RG_No,
                drNo,
                0,
                6,
                doPieceNo,
                rcMontant,
                0,
                "COLS"
            );

            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBINS_F_REGLECH] ON [dbo].[F_REGLECH]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_INS_F_REGLECH] ON [dbo].[F_REGLECH]");


            string queryFDocRegl = @"
                                UPDATE F_DOCREGL
                                SET DR_Regle = @estRegle
                                WHERE DR_No = @DR_No
                            ";
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBUPD_F_DOCREGL ON F_DOCREGL");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_F_DOCREGL ON F_DOCREGL");
            _context.Database.ExecuteSqlCommand(
                queryFDocRegl,
                new SqlParameter("@estRegle", estRegle),
                new SqlParameter("@DR_No", drNo)
            );
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBUPD_F_DOCREGL ON F_DOCREGL");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_F_DOCREGL ON F_DOCREGL");
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
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBUPD_F_REGLECH ON F_REGLECH");
            string query = @"
                                UPDATE F_REGLECH
                                SET RC_Montant = @RC_Montant
                                WHERE RG_No = @RG_No AND DR_No = @DR_No
                            ";
            _context.Database.ExecuteSqlCommand(
            query,
                new SqlParameter("@RC_Montant", RC_Montant),
                new SqlParameter("@RG_No", RG_No),
                new SqlParameter("@DR_No", DR_No)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBUPD_F_REGLECH ON F_REGLECH");
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
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH");
            string queryDeleteAvecCommande = @"
                DELETE FROM [dbo].[F_REGLECH] WHERE DO_Piece = @DO_Piece;
            ";
            _context.Database.ExecuteSqlCommand(
                queryDeleteAvecCommande,
                new SqlParameter("@DO_Piece", DO_Piece)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH");
        }
        // ==================================== FIN SUPPRESSION D'UN REGLEMENT PAR NUMERO DE PIECE D'UN DOCUMENT ===================================
        // =========================================================================================================================================





        // =================================================================================================================================================
        // ==================================== DEBUT SUPPRESSION D'UN REGLEMENT PAR NUMERO DE REGLEMENT DE COMPTE TIERS ===================================
        public void DeleteByRG_No(int RG_No)
        {
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH");
            string queryDeleteAvecCommande = @"
                DELETE FROM [dbo].[F_REGLECH] WHERE RG_No = @RG_No;
            ";
            _context.Database.ExecuteSqlCommand(
                queryDeleteAvecCommande,
                new SqlParameter("@RG_No", RG_No)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBDEL_F_REGLECH ON F_REGLECH");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_DEL_F_REGLECH ON F_REGLECH");
        }
        // ==================================== FIN SUPPRESSION D'UN REGLEMENT PAR NUMERO DE REGLEMENT DE COMPTE TIERS ===================================
        // ===============================================================================================================================================

        // ========================================================================================================================================
        // ============================================================== FIN DELETE ==============================================================
        // ========================================================================================================================================
    }
}
