using SoftCaisse.CustomModel;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<CaisseControl> GetAllReglement(DateTime date, string controle, int caisse, int devise)
        {
            string[] type = new string[] { "Règlement", "Fond de caisse", "Sortie de caisse", "Entrée de caisse", "Remise à zéro" };
            decimal[] valeur = new decimal[5];
            _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && u.RG_Cloture == 0 && (u.N_Devise == devise || u.N_Devise == 0)).GroupBy(item => item.RG_TypeReg).ToList()
                .ForEach(u =>
                {
                    if (u.Key == 0 || u.Key == 1)
                    {
                        valeur[0] += u.Sum(item => item.RG_Montant.Value);
                    }
                    else if (u.Key == 2)
                    {
                        valeur[1] += u.Sum(item => item.RG_Montant.Value);
                    }
                    else if (u.Key == 3 || u.Key == 4)
                    {
                        valeur[2] += u.Sum(item => item.RG_Montant.Value);
                    }
                    else if (u.Key == 5 || u.Key == 7)
                    {
                        valeur[3] += u.Sum(item => item.RG_Montant.Value);
                    }
                    else
                    {
                        valeur[4] += u.Sum(item => item.RG_Montant.Value);
                    }
                }
            );
            List<CaisseControl> list = new List<CaisseControl>();
            for (int i = 0; i < type.Length; i++)
            {
                list.Add(new CaisseControl()
                {
                    intitule = type[i],
                    Montant = valeur[i]
                });
            }
            return list;
        }

        public List<CaisseControl> GetParModeReglement(DateTime date, string controle, int caisse, int devise)
        {
            var liste = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && (u.N_Devise == devise || u.N_Devise == 0) && u.RG_TypeReg != 6 && u.RG_Cloture == 0).GroupBy(item => item.N_Reglement).ToList().Select(u =>
            {
                decimal mont1 = u.Where(i => i.RG_TypeReg != 4 && i.RG_TypeReg != 3).Sum(item => item.RG_Montant.Value);
                decimal mont2 = u.Where(i => i.RG_TypeReg == 4 || i.RG_TypeReg == 3).Sum(item => item.RG_Montant.Value);
                return new CaisseControl()
                {
                    intitule = u.Key + "",
                    Montant = mont1 - mont2,
                    MontantConstate = mont1 - mont2,
                    Ecart = 0
                };
            }
            ).ToList();
            liste.ForEach(u => u.intitule = _context.P_REGLEMENT.FirstOrDefault(aa => aa.cbMarq + "" == u.intitule).R_Intitule);
            decimal? somme = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && (u.N_Devise == devise || u.N_Devise == 0) && u.RG_TypeReg == 6 && u.RG_Cloture == 0).Sum(u => u.RG_Montant);
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
        public decimal get_somme_constate(DateTime date, int caisse)
        {
            decimal valeur = 0;
            var liste = _context.F_CREGLEMENT.Where(u => u.CA_No == caisse && u.RG_Date <= date && u.RG_Cloture == 0).GroupBy(item => item.RG_TypeReg).ToList();

            foreach (var item in liste)
            {
                if (item.Key == 0 || item.Key == 1)
                {
                    valeur += item.Sum(u => u.RG_Montant.Value);
                }
                else if (item.Key == 2)
                {
                    valeur += item.Sum(u => u.RG_Montant.Value);
                }
                else if (item.Key == 3 || item.Key == 4)
                {
                    valeur -= item.Sum(u => u.RG_Montant.Value);
                }
                else if (item.Key == 5 || item.Key == 7)
                {
                    valeur += item.Sum(u => u.RG_Montant.Value);
                }
                else
                {
                    valeur -= item.Sum(u => u.RG_Montant.Value);
                }
            }
            return valeur;
        }
    }
}
