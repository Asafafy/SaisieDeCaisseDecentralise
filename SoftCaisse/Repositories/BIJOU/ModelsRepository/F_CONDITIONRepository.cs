﻿using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_CONDITIONRepository
    {
        // =====================================================================================
        // DEBUT DECLARATION DES VARIABLES =====================================================
        // =====================================================================================
        private readonly AppDbContext _context;
        // =====================================================================================
        // FIN DECLARATION DES VARIABLES =======================================================
        // =====================================================================================










        // =====================================================================================
        // DEBUT CONSTRUCTEUR ==================================================================
        // =====================================================================================
        public F_CONDITIONRepository(AppDbContext context)
        {
            _context = context;
        }
        // =====================================================================================
        // FIN CONSTRUCTEUR ====================================================================
        // =====================================================================================










        // =====================================================================================
        // DEBUT METHODES GET ==================================================================
        // =====================================================================================
        public List<F_CONDITION> GetAll_F_CONDITION_By_AR_Ref(string AR_Ref)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_CONDITION.Where(c => c.AR_Ref == AR_Ref).ToList();
            }
        }
        // =====================================================================================
        // FIN METHODES GET ====================================================================
        // =====================================================================================




    }
}
