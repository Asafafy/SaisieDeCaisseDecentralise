using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class TaxeRepository : IRepository<DTO.Taxe>
    {
        private readonly AppDbContext _context;
        public TaxeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(DTO.Taxe entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTO.Taxe> GetAll()
        {
            return _context.F_TAXE
            .Select(a => new DTO.Taxe
            {
                TA_Taux = a.TA_Taux,
                TA_Code = a.TA_Code
            }).ToList();
        }

        public IEnumerable<DTO.Taxe> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DTO.Taxe entity)
        {
            throw new NotImplementedException();
        }
    }
}
