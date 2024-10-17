using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_ARTCOMPTARepository : IRepository<DTO.ArtCompta>
    {
        private readonly AppDbContext _context;
        public F_ARTCOMPTARepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(DTO.ArtCompta entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DTO.ArtCompta> GetAll()
        {
            return _context.F_ARTCOMPTA
            .Select(a => new DTO.ArtCompta
            {
                ACP_ComptaCPT_Taxe1 = a.ACP_ComptaCPT_Taxe1,
                ACP_Champ = a.ACP_Champ,
                AR_Ref = a.AR_Ref
            }).ToList();
        }

        public DTO.ArtCompta GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DTO.ArtCompta entity)
        {
            throw new NotImplementedException();
        }
    }
}
