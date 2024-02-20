using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class RoleRepository : IRepository<Role>
    {
        private readonly SCDContext _context;
        public RoleRepository(SCDContext context)
        {
            _context =context;
        }
        void IRepository<Role>.Add(Role entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Role>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles.ToList(); ;
        }
        public IEnumerable<Role> GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Role>.Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
