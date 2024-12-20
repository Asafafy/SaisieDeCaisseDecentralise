using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories.BIJOU
{
    internal class F_REGLECHRepository
    {
        private readonly AppDbContext _context;
        public F_REGLECHRepository(AppDbContext context)
        {
            _context = context;
        }





        // ===========================================================================================================
        // ==================================== DEBUT AJOUT D'UN NOUVEAU REGLEMENT ===================================
        // ===========================================================================================================
        public void AddReglech(int drNo, string doPieceNo, decimal rcMontant, int estRegle)
        {
            string lastRGNoStr = _context.P_COLREGLEMENT.Select(pc => pc.CR_Numero01).FirstOrDefault();
            int currentRGNumber = Convert.ToInt32(lastRGNoStr) + 1;

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
                currentRGNumber,
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

            P_COLREGLEMENT pColRToUpdate = _context.P_COLREGLEMENT.FirstOrDefault();
            pColRToUpdate.CR_Numero01 = currentRGNumber.ToString();
            _context.SaveChanges();
        }
        // =========================================================================================================
        // ==================================== FIN AJOUT D'UN NOUVEAU REGLEMENT ===================================
        // =========================================================================================================





        // ===========================================================================================================================================
        // ==================================== DEBUT SUPPRESSION D'UN REGLEMENT PAR NUMERO DE PIECE D'UN DOCUMENT ===================================
        // ===========================================================================================================================================
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
        // =========================================================================================================================================
        // ==================================== FIN SUPPRESSION D'UN REGLEMENT PAR NUMERO DE PIECE D'UN DOCUMENT ===================================
        // =========================================================================================================================================





        // =================================================================================================================================================
        // ==================================== DEBUT SUPPRESSION D'UN REGLEMENT PAR NUMERO DE REGLEMENT DE COMPTE TIERS ===================================
        // =================================================================================================================================================
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
        // ===============================================================================================================================================
        // ==================================== FIN SUPPRESSION D'UN REGLEMENT PAR NUMERO DE REGLEMENT DE COMPTE TIERS ===================================
        // ===============================================================================================================================================
    }
}
