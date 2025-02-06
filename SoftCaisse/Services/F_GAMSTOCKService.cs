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
    internal class F_GAMSTOCKService
    {
        private readonly AppDbContext _context;
        private readonly F_GAMSTOCKRepository _f_GAMSTOCKRepository;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        private readonly F_ARTICLERepository _f_ARTICLERepository;





        public F_GAMSTOCKService(AppDbContext context, F_GAMSTOCKRepository f_GAMSTOCKRepository)
        {
            _context = context;
            _f_GAMSTOCKRepository = f_GAMSTOCKRepository;
            _f_ARTGAMMERepository = new F_ARTGAMMERepository(_context);
            _f_ARTICLERepository = new F_ARTICLERepository(_context);
        }




        public List<(int?, int?)> GetCombinaisonsAG_No(F_ARTICLE article, bool estAG_No2, short? AG_No)
        {
            List<(int?, int?)> listeAG_No = new List<(int?, int?)>();

            List<int?> listeAG_No1 = new List<int?>();
            List<int?> listeAG_No2 = new List<int?>();

            
            if (estAG_No2)
            {
                listeAG_No1 = _context.F_ARTGAMME.Where(ag => ag.AG_Type == 0 && ag.AR_Ref == article.AR_Ref).Select(ag => ag.AG_No).ToList();
                listeAG_No2.Add(AG_No);
            }
            else
            {
                listeAG_No1.Add(AG_No);
                listeAG_No2 = _context.F_ARTGAMME.Where(ag => ag.AG_Type == 1 && ag.AR_Ref == article.AR_Ref && ag.AG_No != AG_No).Select(ag => ag.AG_No).ToList();
            }

            // Générer les combinaisons des AG_No dans une tuple
            foreach (var AG_No1 in listeAG_No1)
            {
                foreach (var AG_No2 in listeAG_No2)
                {
                    listeAG_No.Add((AG_No1, AG_No2));
                }
            }

            return listeAG_No;
        }





        public void CreateF_GAMSTOCKPourGamme1Uniquement(string AR_Ref)
        {
            F_GAMSTOCK f_GAMSTOCKToCreate1 = new F_GAMSTOCK();
            f_GAMSTOCKToCreate1.AR_Ref = AR_Ref;
            f_GAMSTOCKToCreate1.DE_No = 1;
            f_GAMSTOCKToCreate1.AG_No1 = _f_ARTGAMMERepository.GetLastAG_No1();
            f_GAMSTOCKToCreate1.AG_No2 = 0;
            _f_GAMSTOCKRepository.CreateF_GAMSTOCK(f_GAMSTOCKToCreate1);

            F_GAMSTOCK f_GAMSTOCKToCreate2 = new F_GAMSTOCK();
            f_GAMSTOCKToCreate2.AR_Ref = AR_Ref;
            f_GAMSTOCKToCreate2.DE_No = 2;
            f_GAMSTOCKToCreate2.AG_No1 = _f_ARTGAMMERepository.GetLastAG_No1();
            f_GAMSTOCKToCreate2.AG_No2 = 0;
            _f_GAMSTOCKRepository.CreateF_GAMSTOCK(f_GAMSTOCKToCreate2);
        }




        public void CreateF_GAMSTOCKPourArticleAyantDeuxGammes(string AR_Ref, bool estAG_No2)
        {
            F_ARTICLE f_ARTICLEConcerne = _f_ARTICLERepository.GetF_ARTICLEByAR_Ref(AR_Ref);
            int? AG_No = estAG_No2 ? _f_ARTGAMMERepository.GetLastAG_No2() : _f_ARTGAMMERepository.GetLastAG_No1();
            List<(int?, int?)> combinaisonsAG_No1EtAG_No2 = GetCombinaisonsAG_No(f_ARTICLEConcerne, estAG_No2, (short?)AG_No);

            foreach (var combinaisonsAG in combinaisonsAG_No1EtAG_No2)
            {
                F_GAMSTOCK f_GAMSTOCKToCreate1 = new F_GAMSTOCK();
                f_GAMSTOCKToCreate1.AR_Ref = AR_Ref;
                f_GAMSTOCKToCreate1.DE_No = 1;
                f_GAMSTOCKToCreate1.AG_No1 = combinaisonsAG.Item1;
                f_GAMSTOCKToCreate1.AG_No2 = combinaisonsAG.Item2;
                _f_GAMSTOCKRepository.CreateF_GAMSTOCK(f_GAMSTOCKToCreate1);

                F_GAMSTOCK f_GAMSTOCKToCreate2 = new F_GAMSTOCK();
                f_GAMSTOCKToCreate2.AR_Ref = AR_Ref;
                f_GAMSTOCKToCreate2.DE_No = 2;
                f_GAMSTOCKToCreate2.AG_No1 = combinaisonsAG.Item1;
                f_GAMSTOCKToCreate2.AG_No2 = combinaisonsAG.Item2;
                _f_GAMSTOCKRepository.CreateF_GAMSTOCK(f_GAMSTOCKToCreate2);
            }
        }

    }
}
