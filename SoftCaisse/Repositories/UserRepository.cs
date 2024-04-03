using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class UserRepository : IRepository<User>
    {
        private readonly SCDContext _context;
        public UserRepository(SCDContext context)
        {
            _context = context;
        }
        public void Add(User entity)
        {
            _context.Users.Add(entity); 
            _context.SaveChanges();
        }

        public IList<User> GetAll()
        {
            return _context.Users.ToList();
        }

        void IRepository<User>.Delete(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<User> GetById(int id)
        {
            return _context.Users.Where(user=>user.UserId==id).ToList();
        }

        public void Update(User user)
        {
            _context.SaveChanges();
        }
    }
}
