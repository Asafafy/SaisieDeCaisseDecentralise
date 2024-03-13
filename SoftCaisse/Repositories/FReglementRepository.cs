using SoftCaisse.CustomModel;
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
        public List<CaisseControl> GetAllReglement(DateTime date,string controle,int caisse,int devise)
        {
            string[] tab_string= new string[]
            {
            "Règlement",
            "Acompte" ,
            "Fond de caisse" ,
            "Remise en banque" ,
            "Sortie de caisse" ,
            "Entrée de caisse" ,
            "Remise à zéro" ,
            "Contrôle de caisse" ,
            "Bon d'achat" 
            };

            var liste = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && u.N_Devise == devise && u.RG_TypeReg != null).GroupBy(item => item.RG_TypeReg).Select(u =>

                new CaisseControl()
                {
                    intitule = u.Key+"",
                    Montant = u.Sum(item => item.RG_Montant)
                }

            ).ToList();
            liste.ForEach(u => u.intitule = tab_string[Convert.ToInt32(u.intitule)]);
            var retour=new List<CaisseControl>();
            foreach (var item in tab_string)
            {
                var obj = liste.FirstOrDefault(u => u.intitule == item);
                retour.Add(new CaisseControl()
                {
                    intitule = item,
                    Montant = obj==null ? 0 : obj.Montant
                });
            }

            return retour;
        }
        public List<CaisseControl> GetParModeReglement(DateTime date,string controle,int caisse,int devise)
        {
            string[] tab_string= new string[]
            {
            "Règlement",
            "Acompte" ,
            "Fond de caisse" ,
            "Remise en banque" ,
            "Sortie de caisse" ,
            "Entrée de caisse" ,
            "Remise à zéro" ,
            "Contrôle de caisse" ,
            "Bon d'achat" 
            };

            var liste = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && u.N_Devise == devise && u.RG_TypeReg != null).GroupBy(item => item.RG_TypeReg).Select(u =>

                new CaisseControl()
                {
                    intitule = u.Key+"",
                    Montant = u.Sum(item => item.RG_Montant)
                }

            ).ToList();
            liste.ForEach(u => u.intitule = tab_string[Convert.ToInt32(u.intitule)]);

            return liste;
        }
        public decimal get_somme_constate(List<CaisseControl> caisses)
        {
            decimal valeur = 0;
            foreach (var item in caisses)
            {
                decimal montant = item.Montant != null ? item.Montant.Value : 0;
                if(item.intitule== "Règlement" || item.intitule=="Fond de caisse")
                {
                    valeur +=montant;
                }
                else
                {
                    valeur -= montant;
                }
            }
            return valeur;
        }
    }
}
