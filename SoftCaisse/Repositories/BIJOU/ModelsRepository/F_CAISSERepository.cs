using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_CAISSERepository
    {
        private readonly AppDbContext _context;
        public F_CAISSERepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(F_CAISSE entity)
        {
            _context.F_CAISSE.Add(entity);
            _context.SaveChanges();
        }

        public List<F_CAISSE> GetAll()
        {
            return _context.F_CAISSE.ToList();
        }

        public void Update(F_CAISSE entity)
        {
            _context.SaveChanges();
        }
    }
}
