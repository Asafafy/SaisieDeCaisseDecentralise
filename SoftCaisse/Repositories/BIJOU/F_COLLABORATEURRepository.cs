using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_COLLABORATEURRepository : IRepository<F_COLLABORATEUR>
    {
        private readonly AppDbContext _context;
        public F_COLLABORATEURRepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<F_COLLABORATEUR>.Add(F_COLLABORATEUR entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_COLLABORATEUR>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<F_COLLABORATEUR> GetAll()
        {
            return _context.F_COLLABORATEUR.ToList();
        }

        public F_COLLABORATEUR GetById(int id)
        {
            return _context.F_COLLABORATEUR.FirstOrDefault(u => u.CO_No == id);
        }

        void IRepository<F_COLLABORATEUR>.Update(F_COLLABORATEUR entity)
        {
            throw new NotImplementedException();
        }
    }
}
