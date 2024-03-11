using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class ModeReglementRepository : IRepository<P_REGLEMENT>
    {
        private readonly AppDbContext _context;
        public ModeReglementRepository(AppDbContext context) 
        {
            _context = context;
        }
        public void Add(P_REGLEMENT entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<P_REGLEMENT> GetAll()
        {
            return _context.P_REGLEMENT.Select(a => new
            {
                a.R_Intitule,
                a.cbIndice
            }).ToList()
            .Select(a => new P_REGLEMENT
            {
                R_Intitule = a.R_Intitule,
                cbIndice = a.cbIndice
            });
        }

        public IEnumerable<P_REGLEMENT> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(P_REGLEMENT entity)
        {
            throw new NotImplementedException();
        }
    }
}
