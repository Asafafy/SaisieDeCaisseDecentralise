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
    public class P_GAMMERepository
    {
        // DECLARATION DES VARIABLES
        private readonly AppDbContext _context;



        public P_GAMMERepository(AppDbContext context)
        {
            _context = context;
        }


        public void Update(int cbMarq, string G_Intitule)
        {
            string queryUpdateP_GAMME = @"
                DISABLE TRIGGER [dbo].[TG_CBUPD_P_GAMME] ON [dbo].[P_GAMME];

                UPDATE P_GAMME
                SET
                    G_Intitule = @G_Intitule
                WHERE cbMarq = @cbMarq;

                ENABLE TRIGGER [dbo].[TG_CBUPD_P_GAMME] ON [dbo].[P_GAMME];
            ";

            using(var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryUpdateP_GAMME,
                    new SqlParameter("@G_Intitule", G_Intitule),
                    new SqlParameter("@cbMarq", cbMarq)
                );
            }
        }



    }
}
