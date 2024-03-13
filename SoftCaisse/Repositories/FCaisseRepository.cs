using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class FCaisseRepository : IRepository<F_CAISSE>
    {
        private readonly AppDbContext _context;
        public FCaisseRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(F_CAISSE entity)
        {
            _context.F_CAISSE.Add(entity);
            _context.SaveChanges();
        }

        void IRepository<F_CAISSE>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<F_CAISSE> GetAll()
        {
            return _context.F_CAISSE.ToList();
        }

        IEnumerable<F_CAISSE> IRepository<F_CAISSE>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(F_CAISSE entity)
        {
            _context.SaveChanges();
        }
    }
}
