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
    internal class P_GAMMEService
    {
        private readonly AppDbContext _context;
        private readonly P_GAMMERepository _p_GAMMERepository;



        public P_GAMMEService(AppDbContext context, P_GAMMERepository p_GAMMERepository)
        {
            _context = context;
            _p_GAMMERepository = p_GAMMERepository;
        }





        public string NouveauGamme(string G_Intitule)
        {
            List<P_GAMME> listeGammes = _p_GAMMERepository.GetAll();
            P_GAMME p_GAMME = listeGammes.Where(g => g.G_Intitule == "" && g.G_Type == 0).FirstOrDefault();
            if (p_GAMME == null)
            {
                return null;
            }
            else
            {
                _p_GAMMERepository.Update(p_GAMME.cbMarq, G_Intitule);
                return "success";
            }
        }





        public void UpdateGamme(string G_Intitule_Avant, string Nouveau_G_Intitule)
        {
            P_GAMME p_GAMME = _context.P_GAMME.Where(g => g.G_Intitule == G_Intitule_Avant).FirstOrDefault();
            _p_GAMMERepository.Update(p_GAMME.cbMarq, Nouveau_G_Intitule);
        }





        public void SupprimerGamme(string G_IntituleGammeToDelete)
        {
            P_GAMME p_GAMMEToDelete = _p_GAMMERepository.Get_P_GAMMEBy_G_Intitule(G_IntituleGammeToDelete);
            _p_GAMMERepository.Update(p_GAMMEToDelete.cbMarq, "");
        }




    }
}
