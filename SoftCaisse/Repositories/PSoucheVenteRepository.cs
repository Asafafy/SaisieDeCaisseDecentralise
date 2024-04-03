using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class PSoucheVenteRepository : IRepository<P_SOUCHEVENTE>
    {
        private readonly AppDbContext _context;
        public PSoucheVenteRepository(AppDbContext context)
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

        public IList<P_SOUCHEVENTE> GetAll()
        {
            return _context.P_SOUCHEVENTE.ToList();
        }

        IEnumerable<P_SOUCHEVENTE> IRepository<P_SOUCHEVENTE>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<P_SOUCHEVENTE>.Update(P_SOUCHEVENTE entity)
        {
            throw new NotImplementedException();
        }
    }
}
