using SoftCaisse.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SoftCaisse.Repositories
{
    internal class F_DOCREGLRepository : IRepository<F_DOCREGL>
    {
        private readonly AppDbContext _context;

        public F_DOCREGLRepository(AppDbContext context)
        {
            _context = context;
        }


        // ========================== METHODES DE L'INTERFACE IREPOSITORY ==========================
        public void Add(F_DOCREGL docRegl)
        {
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_INS_F_DOCREGL] ON [dbo].[F_DOCREGL]");

            string query = @"
                Insert INTO [dbo].[F_DOCREGL] (
                    [DR_No],
                    [DO_Domaine],
                    [DO_Type],
                    [DO_Piece],
                    [DR_TypeRegl],
                    [DR_Date],
                    [DR_Libelle],
                    [DR_Pourcent],
                    [DR_Montant],
                    [DR_MontantDev],
                    [DR_Equil],
                    [EC_No],
                    [cbEC_No],
                    [DR_Regle],
                    [N_Reglement],
                    [CA_No],
                    [DO_DocType],
                    [cbCreateur],
                    [DR_RefPaiement],
                    [DR_AdressePaiement]
                )
                values(
                    {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}
                )";

            _context.Database.ExecuteSqlCommand(query,
                docRegl.DR_No,
                docRegl.DO_Domaine,
                docRegl.DO_Type,
                docRegl.DO_Piece,
                docRegl.DR_TypeRegl,
                docRegl.DR_Date,
                docRegl.DR_Libelle,
                docRegl.DR_Pourcent,
                docRegl.DR_Montant,
                docRegl.DR_MontantDev,
                docRegl.DR_Equil,
                docRegl.EC_No,
                docRegl.cbEC_No,
                docRegl.DR_Regle,
                docRegl.N_Reglement,
                docRegl.CA_No,
                docRegl.DO_DocType,
                docRegl.cbCreateur,
                docRegl.DR_RefPaiement,
                docRegl.DR_AdressePaiement
            );

            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_INS_F_DOCREGL] ON [dbo].[F_DOCREGL]");
        }

        public void Delete(int IdDocregl)
        {
            throw new System.NotImplementedException();
        }

        public List<F_DOCREGL> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public F_DOCREGL GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(F_DOCREGL entity)
        {
            throw new System.NotImplementedException();
        }

        // ========================== METHODES DE L'INTERFACE IREPOSITORY ==========================




        public void DeleteByDoPiece(string doPiece)
        {
            string queryDeleteAvecCommande = @"
                DELETE FROM [dbo].[F_DOCREGL] WHERE DO_Piece = @DO_Piece;
            ";

            _context.Database.ExecuteSqlCommand(
                queryDeleteAvecCommande,
                new SqlParameter("@DO_Piece", doPiece)
            );
        }
    }
}
