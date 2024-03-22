using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class ArtStockRepository : IRepository<DTO.ArtStock>
    {
        private readonly AppDbContext _context;
        public ArtStockRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ArtStock entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArtStock> GetAll()
        {
            return _context.F_ARTSTOCK
                .Select(a => new ArtStock
                {
                    AR_Ref = a.AR_Ref,
                    AS_QteSto = a.AS_QteSto,
                    AS_QteRes = a.AS_QteRes,
                }
                ).ToList();
        }

        public IEnumerable<ArtStock> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ArtStock entity)
        {
            throw new NotImplementedException();
        }
    }
}
