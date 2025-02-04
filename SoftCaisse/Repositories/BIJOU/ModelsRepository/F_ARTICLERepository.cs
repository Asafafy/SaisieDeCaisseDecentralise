using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_ARTICLERepository
    {
        private readonly AppDbContext _context;

        public F_ARTICLERepository(AppDbContext context)
        {
            _context = context;
        }



        public List<DTO.Article> GetAll()
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


        public List<F_ARTICLE> GetAllF_ARTICLE()
        {
            using (var context = new AppDbContext())
            {
                return context.F_ARTICLE.ToList();
            }
        }
    }
}