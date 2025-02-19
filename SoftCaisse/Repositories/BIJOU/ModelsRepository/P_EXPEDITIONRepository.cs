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
    public class P_EXPEDITIONRepository
    {
        // ============================================================================================
        // DEBUT DECLARATION DES VARIABLES ============================================================
        // ============================================================================================
        //private readonly AppDbContext _context;
        // ============================================================================================
        // FIN DECLARATION DES VARIABLES ==============================================================
        // ============================================================================================





        // ============================================================================================
        // DEBUT CONSTRUCTEUR =========================================================================
        // ============================================================================================
        public P_EXPEDITIONRepository(AppDbContext context)
        {
            //_context = context;
        }
        // ============================================================================================
        // FIN CONSTRUCTEUR ===========================================================================
        // ============================================================================================







        // ============================================================================================
        // DEBUT METHODES DES CONSTRUCTEURS ===========================================================
        // ============================================================================================
        public P_EXPEDITION Get_P_EXPEDITIONBy_E_Intitule(string E_Intitule)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.P_EXPEDITION.Where(exp => exp.E_Intitule == E_Intitule).FirstOrDefault();
            }
        }


        public P_EXPEDITION Get_P_EXPEDITION_By_cbMarq(int cbMarq)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.P_EXPEDITION.Where(exp => exp.cbMarq == cbMarq).FirstOrDefault();
            }
        }






        // ============================================================================================
        // FIN METHODES DES CONSTRUCTEURS =============================================================
        // ============================================================================================

    }
}
