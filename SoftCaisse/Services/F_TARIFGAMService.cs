using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU.IRepository;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Services
{
    internal class F_TARIFGAMService
    {
        private readonly AppDbContext _context;
        private readonly F_TARIFGAMRepository _f_TARIFGAMRepository;





        public F_TARIFGAMService(AppDbContext context, F_TARIFGAMRepository f_TARIFGAMRepository)
        {
            _context = context;
            _f_TARIFGAMRepository = f_TARIFGAMRepository;
        }





        public void NouveauTarifGamme(string AR_Ref, int numeroLigne, int? AG_No1, int? AG_No2, decimal? TG_Prix)
        {
            F_TARIFGAM f_TARIFGAMToCreate = new F_TARIFGAM();

            f_TARIFGAMToCreate.AR_Ref = AR_Ref;
            f_TARIFGAMToCreate.TG_RefCF = "a0" + numeroLigne.ToString();
            f_TARIFGAMToCreate.AG_No1 = AG_No1;
            f_TARIFGAMToCreate.AG_No2 = AG_No2;
            f_TARIFGAMToCreate.TG_Prix = TG_Prix;

            _f_TARIFGAMRepository.Nouveau(f_TARIFGAMToCreate);
        }





    }
}
