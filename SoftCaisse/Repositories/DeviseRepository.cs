using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class DeviseRepository : IRepository<DTO.Devise>
    {
        private readonly AppDbContext _context;

        public DeviseRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(DTO.Devise entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DTO.Devise> GetAll()
        {
            return _context.P_DEVISE
                .Select( a => new DTO.Devise
                {
                    D_Intitule = a.D_Intitule,
                    D_Cours = a.D_Cours,
                    D_Monnaie = a.D_Monnaie,
                    D_CodeISO = a.D_CodeISO,
                    D_CodeISONum = a.D_CodeISONum,
                    cbMarq = a.cbMarq
                }).ToList();
        }

        public DTO.Devise GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DTO.Devise entity)
        {
            throw new NotImplementedException();
        }
    }
}
