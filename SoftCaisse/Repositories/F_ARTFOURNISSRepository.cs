using SoftCaisse.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class F_ARTFOURNISSRepository : IRepository<F_ARTFOURNISS>
    {
        private readonly AppDbContext _context;

        public F_ARTFOURNISSRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(F_ARTFOURNISS entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<F_ARTFOURNISS> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public F_ARTFOURNISS GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(F_ARTFOURNISS entity)
        {
            throw new System.NotImplementedException();
        }

        public F_ARTFOURNISS GetByARRefAndPrincipal(string ArRef)
        {
            F_ARTFOURNISS fournisseurDeLArticle = _context.F_ARTFOURNISS.Where(artFr => artFr.AR_Ref == ArRef && artFr.AF_Principal == 1).FirstOrDefault();
            return fournisseurDeLArticle;
        }
    }
}
