using SoftCaisse.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class F_DOCREGLRepository
    {
        // ==================================================================================
        // DEBUT DECLARATION DES VARIABLES ==================================================
        // ==================================================================================
        private readonly AppDbContext _context;
        // ==================================================================================
        // FIN DECLARATION DES VARIABLES ====================================================
        // ==================================================================================





        // ==================================================================================
        // DEBUT CONSTRUCTEUR ===============================================================
        // ==================================================================================
        public F_DOCREGLRepository(AppDbContext context)
        {
            _context = context;
        }
        // ==================================================================================
        // FIN CONSTRUCTEUR =================================================================
        // ==================================================================================











        // ==================================================================================
        // DEBUT GET ========================================================================
        // ==================================================================================
        public List<F_DOCREGL> GetAll_F_DOCREGL()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_DOCREGL.ToList();
            }
        }



        public List<F_DOCREGL> GetAll_F_DOCREGL_By_DO_Piece(string DO_Piece)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_DOCREGL.Where(dr => dr.DO_Piece == DO_Piece).ToList();
            }
        }
        // ==================================================================================
        // DEBUT GET ========================================================================
        // ==================================================================================










            // ==================================================================================
            // DEBUT CREATE =====================================================================
            // ==================================================================================
        public void Add(F_DOCREGL docRegl)
        {
            string query = @"
                DISABLE TRIGGER [dbo].[TG_INS_F_DOCREGL] ON [dbo].[F_DOCREGL];

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
                );

                ENABLE TRIGGER [dbo].[TG_INS_F_DOCREGL] ON [dbo].[F_DOCREGL];
            ";


            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(query,
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
            }
        }
        // ========================================================================================================================================
        // ============================================================== FIN CREATE ==============================================================
        // ========================================================================================================================================









        // ==========================================================================================================================================
        // ============================================================== DEBUT UPDATE ==============================================================
        // ==========================================================================================================================================
        public void UpdateEtatReglement(decimal soldeEcheanceSelect, int DR_No)
        {
            string queryFReglech = @"
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
                    queryFReglech,
                    new SqlParameter("@estRegle", soldeEcheanceSelect == 0 ? 1 : 0),
                    new SqlParameter("@DR_No", DR_No)
                );
            }
        }
        // ==========================================================================================================================================
        // ============================================================== DEBUT UPDATE ==============================================================
        // ==========================================================================================================================================









        // ==========================================================================================================================================
        // ============================================================== DEBUT DELETE ==============================================================
        // ==========================================================================================================================================
        public void DeleteByDoPiece(string doPiece)
        {
            string queryDeleteAvecCommande = @"
                DISABLE TRIGGER TG_CBDEL_F_DOCREGL ON F_DOCREGL;
                DISABLE TRIGGER TG_DEL_F_DOCREGL ON F_DOCREGL;

                DELETE FROM [dbo].[F_DOCREGL] WHERE DO_Piece = @DO_Piece;

                DISABLE TRIGGER TG_CBDEL_F_DOCREGL ON F_DOCREGL;
                DISABLE TRIGGER TG_DEL_F_DOCREGL ON F_DOCREGL;
            ";


            using(var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteAvecCommande,
                    new SqlParameter("@DO_Piece", doPiece)
                );
            }
        }
        // ========================================================================================================================================
        // ============================================================== FIN DELETE ==============================================================
        // ========================================================================================================================================
    }
}
