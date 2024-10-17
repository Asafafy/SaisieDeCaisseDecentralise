using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class UniteRepository : IRepository<DTO.Unite>
    {
        private readonly AppDbContext _context;

        public UniteRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Unite entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Unite> GetAll()
        {
            return _context.P_UNITE
                .Select(a => new Unite
                {
                    cbIndice = a.cbIndice,
                    U_Intitule = a.U_Intitule,
                }).ToList();
        }

        public Unite GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Unite entity)
        {
            throw new NotImplementedException();
        }
    }
}
