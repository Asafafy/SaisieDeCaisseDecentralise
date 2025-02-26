using SoftCaisse.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class RubriqueRepository
    {
        // ============================================================================================
        // DEBUT DECLARATION DES VARIABLES ============================================================
        // ============================================================================================
        // private readonly string _cheminVersAuthJson;
        private readonly SCDContext _scdContext;
        // ============================================================================================
        // FIN DECLARATION DES VARIABLES ==============================================================
        // ============================================================================================










        // ============================================================================================
        // DEBUT CONSTRUCTEUR =========================================================================
        // ============================================================================================
        public RubriqueRepository()
        {
            _scdContext = new SCDContext();
        }
        // ============================================================================================
        // FIN CONSTRUCTEUR ===========================================================================
        // ============================================================================================










        // ============================================================================================
        // DEBUT GET ==================================================================================
        // ============================================================================================
        public async Task<Rubrique> GetRubrique_by_IdRubrique(int IdRubrique)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Rubrique.Where(rub => rub.Id == IdRubrique).FirstOrDefaultAsync();
            }
        }




        public async Task<List<Rubrique>> GetRubriqueFils_by_IdParent(int IdParent)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Rubrique.Where(rub => rub.IdParent == IdParent).ToListAsync();
            }
        }



        public async Task<Rubrique> GetRubrique_by_Nom(string nom)
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Rubrique.Where(rub => rub.Nom == nom).FirstOrDefaultAsync();
            }
        }




        public async Task<int> CountRubriques()
        {
            using (SCDContext scdContext = new SCDContext())
            {
                return await scdContext.Rubrique.CountAsync();
            }
        }
        // ============================================================================================
        // FIN GET ====================================================================================
        // ============================================================================================


    }
}
