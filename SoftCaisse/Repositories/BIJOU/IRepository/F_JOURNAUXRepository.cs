﻿using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_JOURNAUXRepository : IRepository<F_JOURNAUX>
    {
        private readonly AppDbContext _context;
        public F_JOURNAUXRepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<F_JOURNAUX>.Add(F_JOURNAUX entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_JOURNAUX>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<F_JOURNAUX> GetAll()
        {
            return _context.F_JOURNAUX.ToList();
        }

        F_JOURNAUX IRepository<F_JOURNAUX>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_JOURNAUX>.Update(F_JOURNAUX entity)
        {
            throw new NotImplementedException();
        }
    }
}
