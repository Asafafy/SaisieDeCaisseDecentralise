using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class ArticleRepository : IRepository<DTO.Article>
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(DTO.Article entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

       public IList<DTO.Article> GetAll()
        {
            return _context.F_ARTICLE
                .Select(a => new DTO.Article
                {
                    AR_Ref = a.AR_Ref,
                    AR_Design = a.AR_Design,
                    FA_CodeFamille = a.FA_CodeFamille,
                    AR_UnitePoids = a.AR_UnitePoids,
                    AR_PrixVen = a.AR_PrixVen,
                    AR_PrixTTC = a.AR_PrixTTC,
                    AR_UniteVen = a.AR_UniteVen
                }).ToList();
        }

        public DTO.Article GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update( DTO.Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
