using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_COMPTETRepository
    {
        // =====================================================================================
        // DEBUT DECLARATION DES VARIABLES =====================================================
        // =====================================================================================
        private readonly AppDbContext _context;
        // =====================================================================================
        // FIN DECLARATION DES VARIABLES =======================================================
        // =====================================================================================










        // =====================================================================================
        // DEBUT CONSTRUCTEUR ==================================================================
        // =====================================================================================
        public F_COMPTETRepository(AppDbContext context)
        {
            _context = context;
        }
        // =====================================================================================
        // FIN CONSTRUCTEUR ====================================================================
        // =====================================================================================










        // =====================================================================================
        // DEBUT METHODES GET ==================================================================
        // =====================================================================================
        public List<F_COMPTET> GetAll()
        {
            return _context.F_COMPTET.Where(ct => ct.CT_Type == 0).ToList();
        }



        public F_COMPTET GetByCT_Num(string CT_Num)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_COMPTET.FirstOrDefault(ct => ct.CT_Num == CT_Num);
            }
        }



        public List<string> GetCTNumF_CompteT()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_COMPTET.Where(cpt => cpt.CT_Type == 0).Select(u => u.CT_Num).ToList();
            }
        }



        //public short? Get_N_Period_By_CT_Num(string CT_Num)
        //{
        //    using (AppDbContext context = new AppDbContext())
        //    {
        //        return context.F_COMPTET.Where(cpt => cpt.CT_Num == CT_Num).Select(u => u.N_Period).FirstOrDefault();
        //    }
        //}



        public decimal? GetF_COMPTET_Cours_N_Devise(string CT_Num)
        {
            short? N_Devise = GetByCT_Num(CT_Num).N_Devise;
            using (AppDbContext context = new AppDbContext())
            {
                P_DEVISE p_DEVISE = context.P_DEVISE.FirstOrDefault(dv => dv.cbMarq == N_Devise);
                if (p_DEVISE != null)
                {
                    return p_DEVISE.D_Cours;
                }
                else
                {
                    return 0;
                }
            }
        }
        // =====================================================================================
        // FIN METHODES GET ====================================================================
        // =====================================================================================




    }
}
