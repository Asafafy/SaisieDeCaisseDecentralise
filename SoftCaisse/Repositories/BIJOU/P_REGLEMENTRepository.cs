using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class P_REGLEMENTRepository : IRepository<DTO.ModeReglement>
    {
        private readonly AppDbContext _context;
        public P_REGLEMENTRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(DTO.ModeReglement entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DTO.ModeReglement> GetAll()
        {
            return _context.P_REGLEMENT.Where(u => !string.IsNullOrEmpty(u.R_Intitule))
            .Select(a => new DTO.ModeReglement
            {
                R_Intitule = a.R_Intitule,
                cbIndice = a.cbIndice
            }).ToList();
        }

        public DTO.ModeReglement GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DTO.ModeReglement entity)
        {
            throw new NotImplementedException();
        }
    }
}
