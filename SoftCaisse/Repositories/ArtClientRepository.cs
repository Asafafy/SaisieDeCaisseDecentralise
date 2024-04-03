using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class ArtClientRepository : IRepository<DTO.ArtClient>
    {
        private readonly AppDbContext _context;

        public ArtClientRepository(AppDbContext context)
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

        public IEnumerable<ArtClient> GetAll()
        {
            return _context.F_ARTCLIENT
                .Select(a => new ArtClient
                {
                    AR_Ref = a.AR_Ref,
                    AC_PrixVen = a.AC_PrixVen,
                    AC_Categorie = a.AC_Categorie,
                }).ToList();
        }

        public IEnumerable<ArtClient> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ArtClient entity)
        {
            throw new NotImplementedException();
        }
    }
}
