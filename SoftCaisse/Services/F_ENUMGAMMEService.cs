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
    internal class F_ENUMGAMMEService
    {
        private readonly AppDbContext _context;
        private readonly F_ENUMGAMMERepository _f_ENUMGAMMERepository;





        public F_ENUMGAMMEService(AppDbContext context, F_ENUMGAMMERepository f_ENUMGAMMERepository)
        {
            _context = context;
            _f_ENUMGAMMERepository = f_ENUMGAMMERepository;
        }





        public void NouveauGamme(short? EG_Champ, string EG_Enumere)
        {
            F_ENUMGAMME f_ENUMGAMMEToCreate = new F_ENUMGAMME();

            short? maxEG_Ligne = _context.F_ENUMGAMME.Where(eg => eg.EG_Champ == EG_Champ).Max(eg => eg.EG_Ligne);

            f_ENUMGAMMEToCreate.EG_Champ = EG_Champ;
            f_ENUMGAMMEToCreate.EG_Ligne = maxEG_Ligne == null ? (short?)1 : (short?)(maxEG_Ligne + 1);
            f_ENUMGAMMEToCreate.EG_Enumere = EG_Enumere;
            f_ENUMGAMMEToCreate.EG_BorneSup = 0;
            f_ENUMGAMMEToCreate.cbProt = 0;
            f_ENUMGAMMEToCreate.cbCreateur = "COLS";
            f_ENUMGAMMEToCreate.cbModification = DateTime.Now;
            f_ENUMGAMMEToCreate.cbReplication = 0;
            f_ENUMGAMMEToCreate.cbFlag = 0;
            f_ENUMGAMMEToCreate.cbCreation = DateTime.Now;

            _f_ENUMGAMMERepository.Create(f_ENUMGAMMEToCreate);
        }







        public void UpdateEnumGamme(string G_Intitule_Avant, string Nouveau_G_Intitule)
        {
            F_ENUMGAMME f_ENUMGAMMEToUpdate = _f_ENUMGAMMERepository.GetByEG_Enumere(G_Intitule_Avant);
            _f_ENUMGAMMERepository.Update(f_ENUMGAMMEToUpdate.cbMarq, Nouveau_G_Intitule);
        }



        public void DeleteEnumGamme(string EG_Enumere)
        {
            F_ENUMGAMME f_ENUMGAMMEToDelete = _f_ENUMGAMMERepository.GetByEG_Enumere(EG_Enumere);
            _f_ENUMGAMMERepository.DeleteEnumGamme(f_ENUMGAMMEToDelete.cbMarq);
        }



    }
}
