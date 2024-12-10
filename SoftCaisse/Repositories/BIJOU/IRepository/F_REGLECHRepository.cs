using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SoftCaisse.Repositories.BIJOU
{
    internal class F_REGLECHRepository : IRepository<F_REGLECH>
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
    }
}
