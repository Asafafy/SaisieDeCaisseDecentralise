﻿using SoftCaisse.DTO;
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




        public List<F_ENUMGAMME> GetAllEnumGammeOfAGamme(short? EG_Champ_F_ENUMGAMMEs)
        {
            using (var context = new AppDbContext())
            {
                return context.F_ENUMGAMME.Where(variante => variante.EG_Champ == EG_Champ_F_ENUMGAMMEs).ToList();
            }
        }




        public F_ENUMGAMME GetByEG_Enumere(string EG_Enumere)
        {
            using (var context = new AppDbContext())
            {
                return context.F_ENUMGAMME.Where(eg => eg.EG_Enumere == EG_Enumere).FirstOrDefault();
            }
        }





        public void Create(F_ENUMGAMME f_ENUMGAMME)
        {
            string queryCreateF_ENUMGAMME = @"
                INSERT INTO [dbo].[F_ENUMGAMME]
                (
                    EG_Champ,
                    EG_Ligne,
                    EG_Enumere,
                    EG_BorneSup,
                    cbProt,
                    cbCreateur,
                    cbModification,
                    cbReplication,
                    cbFlag,
                    cbCreation
                )
                VALUES
                (
                    @EG_Champ,
                    @EG_Ligne,
                    @EG_Enumere,
                    @EG_BorneSup,
                    @cbProt,
                    @cbCreateur,
                    @cbModification,
                    @cbReplication,
                    @cbFlag,
                    @cbCreation
                )
            ";

            //_context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBINS_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
            //_context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_INS_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
            using(var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryCreateF_ENUMGAMME,
                    new SqlParameter("@EG_Champ", f_ENUMGAMME.EG_Champ),
                    new SqlParameter("@EG_Ligne", f_ENUMGAMME.EG_Ligne),
                    new SqlParameter("@EG_Enumere", f_ENUMGAMME.EG_Enumere),
                    new SqlParameter("@EG_BorneSup", f_ENUMGAMME.EG_BorneSup),
                    new SqlParameter("@cbProt", f_ENUMGAMME.cbProt),
                    new SqlParameter("@cbCreateur", f_ENUMGAMME.cbCreateur),
                    new SqlParameter("@cbModification", f_ENUMGAMME.cbModification),
                    new SqlParameter("@cbReplication", f_ENUMGAMME.cbReplication),
                    new SqlParameter("@cbFlag", f_ENUMGAMME.cbFlag),
                    new SqlParameter("@cbCreation", f_ENUMGAMME.cbCreation)
                );
            }
            //_context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBINS_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
            //_context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_INS_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME]");
        }






        public void DeleteEnumGamme(int cbMarq)
        {
            string queryDeleteF_ENUMGAMME = @"
                DISABLE TRIGGER [dbo].[TG_CBDEL_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME];
                DELETE FROM F_ENUMGAMME WHERE cbMarq = @cbMarq;
                DISABLE TRIGGER [dbo].[TG_CBDEL_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME];
            ";

            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryDeleteF_ENUMGAMME,
                    new SqlParameter("@cbMarq", cbMarq)
                );
            }
        }


        
        public void Update(int cbMarq, string EG_Enumere)
        {
            string queryUpdateF_ENUMGAMME = @"
                DISABLE TRIGGER [dbo].[TG_UPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME];
                DISABLE TRIGGER [dbo].[TG_CBUPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME];
                
                UPDATE F_ENUMGAMME
                SET
                    EG_Enumere = @EG_Enumere
                WHERE cbMarq = @cbMarq;
                
                ENABLE TRIGGER [dbo].[TG_UPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME];
                ENABLE TRIGGER [dbo].[TG_CBUPD_F_ENUMGAMME] ON [dbo].[F_ENUMGAMME];
            ";


            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(
                    queryUpdateF_ENUMGAMME,
                    new SqlParameter("@EG_Enumere", EG_Enumere),
                    new SqlParameter("@cbMarq", cbMarq)
                );
            }

        }



    }
}
