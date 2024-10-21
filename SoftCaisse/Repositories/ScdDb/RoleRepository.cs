using SoftCaisse.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class RoleRepository : IRepository<Role>
    {
        private readonly SCDContext _scdContext;

        public RoleRepository(SCDContext scdContext)
        {
            _scdContext = scdContext;
        }

        public void Add(Role entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            Role entity = _scdContext.Set<Role>().Find(id);
            if (entity != null)
            {
                _scdContext.Set<Role>().Remove(entity);
                _scdContext.SaveChanges();
            }
        }

        public List<Role> GetAll()
        {
            List<Role> listRoles = _scdContext.Role.ToList();
            return listRoles;
        }

        public Role GetById(int id)
        {
            Role role = _scdContext.Role.Where(r => r.IdRole == id).FirstOrDefault();
            return role;
        }

        public void Update(Role entity)
        {
            var existingRole = _scdContext.Role.Find(entity.IdRole);
            if (existingRole != null)
            {
                _scdContext.Entry(existingRole).CurrentValues.SetValues(entity);
                _scdContext.SaveChanges();
            }
        }

        public List<int> GetUsersNumber()
        {
            var nbrUserActifsParRole = _scdContext.Role
            .GroupJoin(
                _scdContext.Users.Where(u => u.EstActif == 1),
                r => r.IdRole,
                u => u.RoleId,
                (r, users) => users.Count()
            )
            .ToList();

            return nbrUserActifsParRole;
        }
    }
}
