using SoftCaisse.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories.ScdDb
{
    internal class RoleAutorisationRepository : IRepository<RoleAutorisation>
    {
        private readonly SCDContext _scdContext;

        public RoleAutorisationRepository(SCDContext scdContext)
        {
            _scdContext = scdContext;
        }





        // ==================================================================================================================
        // ============================================== Méthodes IRepository ==============================================
        public void Add(RoleAutorisation entity)
        {
            _scdContext.RoleAutorisation.Add(entity);
            _scdContext.SaveChanges();
        }

        public void Delete(int id)
        {
            RoleAutorisation roleAutToDelete = _scdContext.RoleAutorisation.Find(id);
            if (roleAutToDelete != null)
            {
                _scdContext.RoleAutorisation.Remove(roleAutToDelete);
                _scdContext.SaveChanges();
            }
        }

        public List<RoleAutorisation> GetAll()
        {
            return _scdContext.RoleAutorisation.ToList();
        }

        public RoleAutorisation GetById(int id)
        {
            return _scdContext.RoleAutorisation.Find(id);
        }

        public void Update(RoleAutorisation entity)
        {
            RoleAutorisation roleAutorisationToUpdate = _scdContext.RoleAutorisation.Find(entity.Id);
            roleAutorisationToUpdate.EstAutorise = entity.EstAutorise;
            _scdContext.SaveChanges();
        }
        // ============================================== Méthodes IRepository ==============================================
        // ==================================================================================================================



        
    }
}
