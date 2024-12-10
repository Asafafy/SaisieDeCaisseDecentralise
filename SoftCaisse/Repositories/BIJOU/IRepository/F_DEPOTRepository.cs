using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_DEPOTRepository : IRepository<F_DEPOT>
    {
        private readonly AppDbContext _context;
        public F_DEPOTRepository(AppDbContext context)
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

        public List<F_DEPOT> GetAll()
        {
            return _context.F_DEPOT.ToList();
        }

        public F_DEPOT GetById(int id)
        {
            return _context.F_DEPOT.FirstOrDefault(x => x.DE_No == id);
        }

        void IRepository<F_DEPOT>.Update(F_DEPOT entity)
        {
            throw new NotImplementedException();
        }
    }
}
