using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_COLLABORATEURRepository
    {
        // =============================================================================
        // DEBUT DECLARATION DES VARIABLES =============================================
        // =============================================================================
        private readonly AppDbContext _context;
        // =============================================================================
        // FIN DECLARATION DES VARIABLES ===============================================
        // =============================================================================




        // =============================================================================
        // DEBUT CONSTRUCTEUR ==========================================================
        // =============================================================================
        public F_COLLABORATEURRepository(AppDbContext context)
        {
            _context = context;
        }
        // =============================================================================
        // FIN CONSTRUCTEUR ============================================================
        // =============================================================================






        // =============================================================================
        // DEBUT METHODES GET ==========================================================
        // =============================================================================
        public List<F_COLLABORATEUR> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_COLLABORATEUR.ToList();
            }
        }



        public F_COLLABORATEUR GetBy_CO_Nom_And_CO_Prenom(string CO_Nom_Prenom)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_COLLABORATEUR.Where(coll => coll.CO_Nom + " " + coll.CO_Prenom == CO_Nom_Prenom).FirstOrDefault();
            }
        }
        // =============================================================================
        // FIN METHODES GET ============================================================
        // =============================================================================

    }
}
