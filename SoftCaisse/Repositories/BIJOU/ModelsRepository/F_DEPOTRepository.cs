using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SoftCaisse.Repositories
{
    public class F_DEPOTRepository
    {
        private readonly AppDbContext _context;
        public F_DEPOTRepository(AppDbContext context)
        {
            _context = context;
        }
        

        public List<F_DEPOT> GetAll()
        {
            return _context.F_DEPOT.ToList();
        }



        public F_DEPOT GetById(int id)
        {
            return _context.F_DEPOT.FirstOrDefault(x => x.DE_No == id);
        }



        public int? GetDP_NoPrincipal(string AR_Ref, int? DE_No)
        {
            int nombreChoix = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == AR_Ref).Count();

            if (nombreChoix <= 1)
            {
                F_ARTSTOCK artstock = _context.F_ARTSTOCK.Where(artStck => artStck.AR_Ref == AR_Ref).FirstOrDefault();
                return artstock.DP_NoPrincipal;
            }
            else
            {
                string queryGetDP_No = @"
                    SELECT
                    	CASE WHEN ISNULL(fArtStock.DP_NoPrincipal,0) > 0 THEN
                    		fArtStock.DP_NoPrincipal
                    	ELSE
                    		fDepot.DP_NoDefaut
                    	END
                    DP_No
                    
                    FROM F_DEPOT fDepot
                    LEFT OUTER JOIN F_ARTSTOCK fArtStock ON (fDepot.DE_No = fArtStock.DE_No AND fArtStock.AR_Ref = @AR_Ref)
                    
                    WHERE fDepot.DE_No = @DE_No
                ";

                int? DP_No = _context.Database.SqlQuery<int?>(
                        queryGetDP_No,
                        new SqlParameter("@AR_Ref", AR_Ref),
                        new SqlParameter("@DE_No", DE_No)
                    ).FirstOrDefault();
                return DP_No;
            }
        }


        public int? GetDP_NoF_ARTSTOCKEMPL(string AR_Ref, int? DE_No)
        {
            int nombreChoix = _context.F_ARTSTOCKEMPL.Where(artStck => artStck.AR_Ref == AR_Ref).Count();

            if (nombreChoix <= 1)
            {
                F_ARTSTOCKEMPL artstock = _context.F_ARTSTOCKEMPL.Where(artStck => artStck.AR_Ref == AR_Ref).FirstOrDefault();
                return artstock.DP_No;
            }
            else
            {
                string queryGetDP_No = @"
                    SELECT
                    	CASE WHEN ISNULL(fArtStock.DP_NoPrincipal,0) > 0 THEN
                    		fArtStock.DP_NoPrincipal
                    	ELSE
                    		fDepot.DP_NoDefaut
                    	END
                    DP_No
                    
                    FROM F_DEPOT fDepot
                    LEFT OUTER JOIN F_ARTSTOCK fArtStock ON (fDepot.DE_No = fArtStock.DE_No AND fArtStock.AR_Ref = @AR_Ref)
                    
                    WHERE fDepot.DE_No = @DE_No
                ";

                int? DP_No = _context.Database.SqlQuery<int?>(
                        queryGetDP_No,
                        new SqlParameter("@AR_Ref", AR_Ref),
                        new SqlParameter("@DE_No", DE_No)
                    ).FirstOrDefault();
                return DP_No;
            }
        }
    }
}
