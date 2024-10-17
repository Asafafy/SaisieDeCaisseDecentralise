using SoftCaisse.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class UserRepository : IRepository<Users>
    {
        private readonly SCDContext _scdContext;
        public UserRepository(SCDContext context)
        {
            _scdContext = context;
        }
        public void Add(Users entity)
        {
            _scdContext.Users.Add(entity);
            _scdContext.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return _scdContext.Users.ToList();
        }

        public void Delete(int id)
        {
            Users entity = _scdContext.Set<Users>().Find(id);
            if (entity != null)
            {
                _scdContext.Set<Users>().Remove(entity);
                _scdContext.SaveChanges();
            }
        }


        public Users GetById(int id)
        {
            return _scdContext.Users.FirstOrDefault(user => user.UserId == id);
        }

        public void Update(Users user)
        {
            _scdContext.SaveChanges();
        }
    }
}
