using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories
{
    public class FBilletageRepository
    {
        private readonly AppDbContext _context;
        public FBilletageRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<F_BILLETPIECE> GetAll()
        {
            return _context.F_BILLETPIECE.ToList();
        }
    }
}
