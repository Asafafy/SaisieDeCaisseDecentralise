using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.BIJOU.ModelsRepository
{
    public class F_ENUMGAMMERepository
    {
        // DECLARATION DES VARIABLES
        private readonly AppDbContext _context;





        public F_ENUMGAMMERepository(AppDbContext context)
        {
            _context = context;
        }





        //TODO: Mbola misy tsy milamina eto anh..... Mbola mila étudiena kely aloha vao mety.....
        public void Update(int cbMarq, string EG_Enumere)
        {
            string queryUpdateF_ENUMGAMME = @"
                UPDATE F_ENUMGAMME
                SET
                    EG_Enumere = @EG_Enumere
                WHERE cbMarq = @cbMarq
            ";

            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_UPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBUPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
            _context.Database.ExecuteSqlCommand(
            queryUpdateF_ENUMGAMME,
                new SqlParameter("@EG_Enumere", EG_Enumere),
                new SqlParameter("@cbMarq", cbMarq)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_UPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBUPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
        }



    }
}
