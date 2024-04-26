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
            //string[] tab_string= new string[]
            //{
            //    "Règlement",
            //    "Règlement",
            //    "Fond de caisse" ,
            //    "Sortie de caisse" ,
            //    "Sortie de caisse" ,
            //    "Entrée de caisse" ,
            //    "Remise à zéro" ,
            //    "Entrée de caisse" 
            //};

            var liste = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && u.RG_TypeReg != null).GroupBy(item => item.RG_TypeReg).ToList()
                .Select(u =>
                {
                    string intitul = "";
                    if(u.Key==0 || u.Key == 1)
                    {
                        intitul = "Règlement";
                    }
                    else if(u.Key==2)
                    {
                        intitul = "Fond de caisse";
                    }
                    else if(u.Key==3 || u.Key == 4)
                    {
                        intitul = "Sortie de caisse";
                    }
                    else if(u.Key==5 || u.Key == 7)
                    {
                        intitul = "Entrée de caisse";
                    }
                    else
                    {
                        intitul = "Remise à zéro";
                    }

                    return new CaisseControl()
                    {
                        intitule = intitul,
                        Montant = devise==0 ? u.Where(i=>i.N_Devise == 0 ).Sum(item => item.RG_Montant) : u.Where(i => i.N_Devise == devise).Sum(item => item.RG_MontantDev)
                    };

                }

            ).ToList();
            //liste.ForEach(u => u.intitule = tab_string[Convert.ToInt32(u.intitule)]);
            //var retour=new List<CaisseControl>();
            //foreach (var item in tab_string)
            //{
            //    var obj = liste.FirstOrDefault(u => u.intitule == item);
            //    retour.Add(new CaisseControl()
            //    {
            //        intitule = item,
            //        Montant = obj==null ? 0 : obj.Montant
            //    });
            //}

            return liste;
        }

        public List<CaisseControl> GetParModeReglement(DateTime date, string controle, int caisse, int devise)
        {
            var liste = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && u.RG_TypeReg!=6).GroupBy(item => item.N_Reglement).Select(u =>
                new CaisseControl()
                {
                    intitule = u.Key + "",
                    Montant = devise == 0 ? u.Where(i => i.N_Devise == 0).Sum(item => item.RG_Montant) : u.Where(i => i.N_Devise == devise).Sum(item => item.RG_MontantDev),
                    MontantConstate = devise == 0 ? u.Where(i => i.N_Devise == 0).Sum(item => item.RG_Montant) : u.Where(i => i.N_Devise == devise).Sum(item => item.RG_MontantDev),
                    Ecart = 0
                }
        
            ).ToList();
            liste.ForEach(u => u.intitule = _context.P_REGLEMENT.FirstOrDefault(aa=>aa.cbMarq+""==u.intitule).R_Intitule);
            decimal? somme = devise!=0? _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && (u.N_Devise == devise ) && u.RG_TypeReg == 6).Sum(u=>u.RG_MontantDev) : _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && (u.N_Devise == 0) && u.RG_TypeReg == 6).Sum(u => u.RG_Montant);
            liste.Add(
                new CaisseControl()
                {
                    intitule = "Remise à zéro",
                    Montant = somme,
                    MontantConstate = somme,
                    Ecart = 0
                }
            );

            return liste;
        }
        public decimal get_somme_constate(List<CaisseControl> caisses)
        {
            decimal valeur = 0;
            foreach (var item in caisses)
            {
                decimal montant = item.Montant != null ? item.Montant.Value : 0;
                if(item.intitule!= "Sortie de caisse" && item.intitule!= "Remise à zéro")
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
