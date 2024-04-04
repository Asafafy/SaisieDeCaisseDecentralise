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


        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(user=>user.UserId==id);
        }

        public void Update(User user)
        {
            _context.SaveChanges();
        }
    }
}
