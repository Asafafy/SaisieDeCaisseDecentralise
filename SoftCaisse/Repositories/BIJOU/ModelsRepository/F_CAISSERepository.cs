using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_CAISSERepository
    {
        private readonly AppDbContext _context;




        public F_CAISSERepository(AppDbContext context)
        {
            _context = context;
        }




        public void Add(F_CAISSE entity)
        {
            _context.F_CAISSE.Add(entity);
            _context.SaveChanges();
        }





        public F_CAISSE GetF_CAISSE_By_CA_No(int? CA_No)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_CAISSE.Where(c => c.CA_No == CA_No).FirstOrDefault();
            }
        }


        public List<F_CAISSE> GetAll()
        {
            return _context.F_CAISSE.ToList();
        }





        public void Update(F_CAISSE entity)
        {
            _context.SaveChanges();
        }
    }
}
