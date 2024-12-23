﻿using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_BILLETPIECERepository
    {
        private readonly AppDbContext _context;
        public F_BILLETPIECERepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<F_BILLETPIECE> GetAll()
        {
            return _context.F_BILLETPIECE.ToList();
        }
        public bool deleteRow(int cbMarq)
        {
            F_BILLETPIECE billet = _context.F_BILLETPIECE.FirstOrDefault(u => u.cbMarq == cbMarq);
            if (billet != null)
            {
                _context.F_BILLETPIECE.Remove(billet);
                _context.SaveChanges();
            }
            return true;
        }
        public bool update(int cbMarq, decimal? valeur, string Intitule)
        {
            F_BILLETPIECE billet = _context.F_BILLETPIECE.FirstOrDefault(u => u.cbMarq == cbMarq);
            if (billet != null)
            {
                billet.BI_Valeur = valeur;
                billet.BI_Intitule = Intitule;
                _context.SaveChanges();
            }
            return true;
        }
        public bool insert(int cbMarq, decimal? valeur, string Intitule, short? devise)
        {
            F_BILLETPIECE bilet = new F_BILLETPIECE();
            bilet.BI_Intitule = Intitule;
            bilet.N_Devise = devise;
            bilet.cbMarq = cbMarq;
            bilet.BI_Valeur = valeur;
            bilet.cbCreateur = "COLS";
            bilet.cbFlag = 0;
            bilet.cbProt = 0;
            bilet.cbModification = DateTime.Now;
            _context.F_BILLETPIECE.Add(bilet);
            _context.SaveChanges();
            return true;
        }
    }
}
