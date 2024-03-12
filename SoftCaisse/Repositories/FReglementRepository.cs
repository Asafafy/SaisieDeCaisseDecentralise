using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class FReglementRepository
    {
        private readonly AppDbContext _context;
        public FReglementRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<F_REGLECH> GetAll()
        {
            return _context.F_REGLECH.ToList();
        }
    }
}
