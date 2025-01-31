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
    internal class F_ARTGAMMEService
    {
        private readonly AppDbContext _context;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;





        public F_ARTGAMMEService(AppDbContext context, F_ARTGAMMERepository f_ARTGAMMERepository)
        {
            _context = context;
            _f_ARTGAMMERepository = f_ARTGAMMERepository;
        }





        public void NouveauGamme(string AR_Ref, string EG_Enumere, int estAG_No2)
        {
            F_ARTGAMME f_ARTGAMMEToCreate = new F_ARTGAMME();

            int? maxAG_No = _context.F_ARTGAMME.Max(eg => eg.AG_No);
            int? maxcbMarq = _context.F_ARTGAMME.Max(eg => eg.cbMarq);

            f_ARTGAMMEToCreate.AR_Ref = AR_Ref;
            f_ARTGAMMEToCreate.AG_No = maxAG_No + 1;
            f_ARTGAMMEToCreate.EG_Enumere = EG_Enumere;
            f_ARTGAMMEToCreate.AG_Type = estAG_No2 == 1 ? (short?)1 : (short?)0;
            f_ARTGAMMEToCreate.cbProt = 0;
            f_ARTGAMMEToCreate.cbCreateur = "COLS";
            f_ARTGAMMEToCreate.cbModification = DateTime.Now;
            f_ARTGAMMEToCreate.cbReplication = 0;
            f_ARTGAMMEToCreate.cbFlag = 0;
            f_ARTGAMMEToCreate.cbCreation = DateTime.Now;

            _f_ARTGAMMERepository.Create(f_ARTGAMMEToCreate);
        }





    }
}
