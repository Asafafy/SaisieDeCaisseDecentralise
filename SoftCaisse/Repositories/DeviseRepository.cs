using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class DeviseRepository : IRepository<P_DEVISE>
    {
        private readonly AppDbContext _context;

        public DeviseRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(P_DEVISE entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<P_DEVISE> GetAll()
        {
            return _context.P_DEVISE
                .Select(a => new
                {
                    a.D_Intitule,
                    a.D_Cours,
                    a.D_Monnaie,
                    a.D_CodeISO,
                    a.cbMarq
                })
                .ToList()
                .Select( a => new P_DEVISE
                {
                    D_Intitule = a.D_Intitule,
                    D_Cours = a.D_Cours,
                    D_Monnaie = a.D_Monnaie,
                    D_CodeISO = a.D_CodeISO,
                    cbMarq = a.cbMarq
                });
        }

        public IEnumerable<P_DEVISE> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(P_DEVISE entity)
        {
            throw new NotImplementedException();
        }
    }
}
