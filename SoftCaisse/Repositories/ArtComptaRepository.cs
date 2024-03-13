using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class ArtComptaRepository : IRepository<F_ARTCOMPTA>
    {
        private readonly AppDbContext _context;
        public ArtComptaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(F_ARTCOMPTA entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F_ARTCOMPTA> GetAll()
        {
            return _context.F_ARTCOMPTA.Select(a => new
            {
                a.ACP_ComptaCPT_Taxe1,
                a.ACP_Champ,
                a.AR_Ref
            }).ToList()
            .Select(a => new F_ARTCOMPTA
            {
                ACP_ComptaCPT_Taxe1 = a.ACP_ComptaCPT_Taxe1,
                ACP_Champ = a.ACP_Champ,
                AR_Ref = a.AR_Ref
            });
        }

        public IEnumerable<F_ARTCOMPTA> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(F_ARTCOMPTA entity)
        {
            throw new NotImplementedException();
        }
    }
}
