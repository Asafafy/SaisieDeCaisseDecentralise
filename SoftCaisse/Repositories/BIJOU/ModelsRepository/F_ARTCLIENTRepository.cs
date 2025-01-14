using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_ARTCLIENTRepository : IRepository<DTO.ArtClient>
    {
        private readonly AppDbContext _context;

        public F_ARTCLIENTRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ArtClient entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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

        public ArtClient GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ArtClient entity)
        {
            throw new NotImplementedException();
        }
    }
}
