using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class ClientRepository : IRepository<F_COMPTET>
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<F_COMPTET>.Add(F_COMPTET entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_COMPTET>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<F_COMPTET> IRepository<F_COMPTET>.GetAll()
        {
            return _context.F_COMPTET.ToList();
        }

        public IEnumerable<F_COMPTET> GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_COMPTET>.Update(F_COMPTET entity)
        {
            throw new NotImplementedException();
        }
        public List<string> GetCTNumF_CompteT()
        {
            return _context.F_COMPTET.Where(cpt => cpt.CT_Type == 0).Select(u => u.CT_Num).ToList();
        }
        
    }
}
