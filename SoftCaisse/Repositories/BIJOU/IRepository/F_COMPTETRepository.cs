﻿using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_COMPTETRepository : IRepository<F_COMPTET>
    {
        private readonly AppDbContext _context;

        public F_COMPTETRepository(AppDbContext context)
        {
            _context = context;
        }
        void IRepository<F_COMPTET>.Add(F_COMPTET entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_COMPTET>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<F_COMPTET> GetAll()
        {
            return _context.F_COMPTET.Where(ct => ct.CT_Type == 0).ToList();
        }

        public F_COMPTET GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<F_COMPTET>.Update(F_COMPTET entity)
        {
            throw new NotImplementedException();
        }
        public List<string> GetCTNumF_CompteT()
        {
            return _context.F_COMPTET.Where(cpt => cpt.CT_Type == 0).Select(u => u.CT_Num).ToList();
        }

    }
}
