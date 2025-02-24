using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.BIJOU.ModelsRepository
{
    public class P_DEVISERepository
    {
        // DECLARATION DES VARIABLES
        //private readonly AppDbContext _context;



        public P_DEVISERepository(AppDbContext context)
        {
            //_context = context;
        }





        public P_DEVISE GetP_DEVISE_By_cbMarq(int cbMarq)
        {
            using (var context = new AppDbContext())
            {
                return context.P_DEVISE.Where(g => g.cbMarq == cbMarq).FirstOrDefault();
            }
        }








    }
}
