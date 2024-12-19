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

        public void Add(F_REGLECH entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<F_REGLECH> GetAll()
        {
            throw new NotImplementedException();
        }

        public F_REGLECH GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(F_REGLECH entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByDoPiece(string doPiece)
        {
            string queryDeleteAvecCommande = @"
                DELETE FROM [dbo].[F_REGLECH] WHERE DO_Piece = @DO_Piece;
            ";

            _context.Database.ExecuteSqlCommand(
                queryDeleteAvecCommande,
                new SqlParameter("@DO_Piece", doPiece)
            );
        }

        public void AddReglech(int drNo, string doPieceNo, decimal rcMontant)
        {
            int lastRGNo = 0;
            string lastRGNoStr = _context.P_COLREGLEMENT.Select(pc => pc.CR_Numero01).FirstOrDefault();
            lastRGNo = Convert.ToInt32(lastRGNoStr);
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
                lastRGNo + 1,
                drNo,
                0,
                6,
                doPieceNo,
                rcMontant,
                0,
                "COLS"
            );

            //P_COLREGLEMENT pColRToUpdate = _context.P_COLREGLEMENT.FirstOrDefault();
            //pColRToUpdate.CR_Numero01 = (lastRGNo + 1).ToString();
        }
    }
}
