using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class UserRepository : IRepository<Users>
    {
        private readonly SCDContext _context;
        public UserRepository(SCDContext context)
        {
            _context = context;
        }
        public void Add(Users entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public IList<Users> GetAll()
        {
            return _context.Users.ToList();
        }

        void IRepository<Users>.Delete(int id)
        {
            throw new NotImplementedException();
        }


        public Users GetById(int id)
        {
            return _context.Users.FirstOrDefault(user => user.UserId == id);
        }

        public void Update(Users user)
        {
            _context.SaveChanges();
        }
    }
}
