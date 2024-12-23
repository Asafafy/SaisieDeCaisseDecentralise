﻿using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_CAISSERepository : IRepository<F_CAISSE>
    {
        private readonly AppDbContext _context;
        public F_CAISSERepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(F_CAISSE entity)
        {
            _context.F_CAISSE.Add(entity);
            _context.SaveChanges();
        }

        void IRepository<F_CAISSE>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<F_CAISSE> GetAll()
        {
            return _context.F_CAISSE.ToList();
        }

        F_CAISSE IRepository<F_CAISSE>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(F_CAISSE entity)
        {
            _context.SaveChanges();
        }
    }
}
