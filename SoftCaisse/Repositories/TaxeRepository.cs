using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class TaxeRepository : IRepository<F_TAXE>
    {
        private readonly AppDbContext _context;
        public TaxeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(F_TAXE entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F_TAXE> GetAll()
        {
            return _context.F_TAXE.Select(a => new
            {
                a.TA_Taux,
                a.TA_Code
            })
            .ToList()
            .Select(a => new F_TAXE
            {
                TA_Taux = a.TA_Taux,
                TA_Code = a.TA_Code
            });
        }

        public IEnumerable<F_TAXE> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(F_TAXE entity)
        {
            throw new NotImplementedException();
        }
    }
}
