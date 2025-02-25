using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_ARTCLIENTRepository
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
        public F_ARTCLIENTRepository(AppDbContext context)
        {
            _context = context;
        }
        // ==================================================================================
        // DEBUT CONSTRUCTEUR ===============================================================
        // ==================================================================================









        // ==================================================================================
        // DEBUT GET ========================================================================
        // ==================================================================================
        public F_ARTCLIENT GetBy_CT_Num_Et_AR_Ref(string CT_Num, string AR_Ref)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_ARTCLIENT.Where(artCli => artCli.CT_Num == CT_Num && artCli.AR_Ref == AR_Ref).FirstOrDefault();
            }
        }





        public List<ArtClient> GetAll()
        {
            return _context.F_ARTCLIENT
                .Select(a => new ArtClient
                {
                    AR_Ref = a.AR_Ref,
                    AC_PrixVen = a.AC_PrixVen,
                    AC_Categorie = a.AC_Categorie,
                }).ToList();
        }
        // ==================================================================================
        // FIN GET ==========================================================================
        // ==================================================================================



    }
}
