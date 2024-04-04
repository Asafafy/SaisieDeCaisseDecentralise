using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class FCReglementRepository : IRepository<F_CREGLEMENT>
    {
        private readonly AppDbContext _context;
        public FCReglementRepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<F_CREGLEMENT>.Add(F_CREGLEMENT entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_CREGLEMENT>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<F_CREGLEMENT>GetAll()
        {
            return _context.F_CREGLEMENT.ToList();
        }

        public F_CREGLEMENT GetById(int id)
        {
            return _context.F_CREGLEMENT.FirstOrDefault(u=>u.CA_No==id);
        }

        void IRepository<F_CREGLEMENT>.Update(F_CREGLEMENT entity)
        {
            throw new NotImplementedException();
        }
    }
}
