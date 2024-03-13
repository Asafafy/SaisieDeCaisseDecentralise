using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class FCollaborateurRepository : IRepository<F_COLLABORATEUR>
    {
        private readonly AppDbContext _context;
        public FCollaborateurRepository(AppDbContext context)
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

        public IEnumerable<F_COLLABORATEUR> GetAll()
        {
            return _context.F_COLLABORATEUR.ToList();
        }

        IEnumerable<F_COLLABORATEUR> IRepository<F_COLLABORATEUR>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_COLLABORATEUR>.Update(F_COLLABORATEUR entity)
        {
            throw new NotImplementedException();
        }
    }
}
