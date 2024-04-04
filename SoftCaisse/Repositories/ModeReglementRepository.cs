using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    internal class ModeReglementRepository : IRepository<DTO.ModeReglement>
    {
        private readonly AppDbContext _context;
        public ModeReglementRepository(AppDbContext context) 
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
            return _context.P_REGLEMENT
            .Select(a => new DTO.ModeReglement
            {
                R_Intitule = a.R_Intitule,
                cbIndice = a.cbIndice
            }).ToList();
        }

        public IEnumerable<DTO.ModeReglement> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DTO.ModeReglement entity)
        {
            throw new NotImplementedException();
        }
    }
}
