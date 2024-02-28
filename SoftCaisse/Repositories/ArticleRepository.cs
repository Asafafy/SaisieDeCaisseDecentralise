using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    internal class ArticleRepository : IRepository<F_ARTICLE>
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(F_ARTICLE entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

       public IEnumerable<F_ARTICLE> GetAll()
        {
            return _context.F_ARTICLE
                .Select(a => new
                {
                    a.AR_Ref,
                    a.AR_Design,
                    a.FA_CodeFamille,
                    a.AR_UnitePoids,
                    a.AR_PrixVen,
                    a.AR_PrixTTC,
                    a.AR_UniteVen
                })
                .ToList()
                .Select(a => new F_ARTICLE
                {
                    AR_Ref = a.AR_Ref,
                    AR_Design = a.AR_Design,
                    FA_CodeFamille = a.FA_CodeFamille,
                    AR_UnitePoids = a.AR_UnitePoids,
                    AR_PrixVen = a.AR_PrixVen,
                    AR_PrixTTC = a.AR_PrixTTC,
                    AR_UniteVen = a.AR_UniteVen
                });
        }

        public IEnumerable<F_ARTICLE> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(F_ARTICLE entity)
        {
            throw new NotImplementedException();
        }
    }
}
