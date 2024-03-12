using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class FDepotRepository : IRepository<F_DEPOT>
    {
        private readonly AppDbContext _context;
        public FDepotRepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<F_DEPOT>.Add(F_DEPOT entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_DEPOT>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F_DEPOT> GetAll()
        {
            return _context.F_DEPOT.ToList();
        }

        public IEnumerable<F_DEPOT> GetById(int id)
        {
            return _context.F_DEPOT.Where(x => x.DE_No == id).ToList();
        }

        void IRepository<F_DEPOT>.Update(F_DEPOT entity)
        {
            throw new NotImplementedException();
        }
    }
}
