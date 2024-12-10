using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class P_SOUCHEVENTERepository : IRepository<P_SOUCHEVENTE>
    {
        private readonly AppDbContext _context;
        public P_SOUCHEVENTERepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<P_SOUCHEVENTE>.Add(P_SOUCHEVENTE entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<P_SOUCHEVENTE>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<P_SOUCHEVENTE> GetAll()
        {
            return _context.P_SOUCHEVENTE.ToList();
        }

        P_SOUCHEVENTE IRepository<P_SOUCHEVENTE>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<P_SOUCHEVENTE>.Update(P_SOUCHEVENTE entity)
        {
            throw new NotImplementedException();
        }
    }
}
