using SoftCaisse.Models;
using SoftCaisse.Repositories.BIJOU;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace SoftCaisse.Repositories
{
    public class F_CREGLEMENTRepository
    {
        // ===============================================================================================
        // DEBUT DECLARATION DES VARIABLES ===============================================================
        // ===============================================================================================
        private readonly AppDbContext _context;
        private readonly F_REGLECHRepository f_REGLECHRepository;
        // ===============================================================================================
        // FIN DECLARATION DES VARIABLES =================================================================
        // ===============================================================================================










        // ===============================================================================================
        // DEBUT CONSTRUCTEUR ============================================================================
        // ===============================================================================================
        public F_CREGLEMENTRepository(AppDbContext context)
        {
            _context = context;
            f_REGLECHRepository = new F_REGLECHRepository(context);
        }
        // ===============================================================================================
        // FIN CONSTRUCTEUR ==============================================================================
        // ===============================================================================================










        // ==============================================================================================
        // DÉBUT METHODE GET ============================================================================
        // ==============================================================================================
        public List<F_CREGLEMENT> GetAll()
        {
            return _context.F_CREGLEMENT.ToList();
        }



        public F_CREGLEMENT GetById(int id)
        {
            return _context.F_CREGLEMENT.FirstOrDefault(u => u.CA_No == id);
        }



        public F_CREGLEMENT GetBy_RG_No(int? RG_No)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.F_CREGLEMENT.Where(regl => regl.RG_No == RG_No).FirstOrDefault();
            }
        }
        // ==============================================================================================
        // FIN METHODE GET ==============================================================================
        // ==============================================================================================










        // ==============================================================================================
        // DÉBUT CREATE =================================================================================
        // ==============================================================================================
        public void Add(F_CREGLEMENT reglement)
        {
            string query = @"
                DISABLE TRIGGER [TG_CBINS_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];
                DISABLE TRIGGER [TG_INS_CPTAF_CREGLEMENT] ON [dbo].[F_CREGLEMENT];

                INSERT INTO [dbo].[F_CREGLEMENT] (
                        [RG_No],
                        [RG_Date],
                        [RG_Montant],
                        [N_Reglement],
                        [RG_Impute],
                        [RG_Libelle],
                        [RG_MontantDev], 
                        [RG_Reference],
                        [RG_Compta],
                        [EC_No],
                        [RG_Type],
                        [RG_Cours],
                        [RG_TypeReg],
                        [N_Devise], 
                        [JO_Num], 
                        [RG_Impaye], 
                        [RG_Heure],
                        [RG_Piece],
                        [CA_No],
                        [cbCA_No],
                        [CO_NoCaissier], 
                        [cbCO_NoCaissier],
                        [RG_Transfere],
                        [RG_Cloture],
                        [RG_Ticket],
                        [RG_Souche],
                        [RG_DateEchCont], 
                        [RG_MontantEcart],
                        [RG_NoBonAchat],
                        [RG_Valide],
                        [RG_Anterieur],
                        [RG_MontantCommission], 
                        [RG_MontantNet],
                        [cbProt],
                        [cbModification],
                        [cbReplication],
                        [cbFlag],
                        [cbCreation], 
                        [cbHashVersion],
                        [cbHashDate],
                        [RG_Banque],
                        [CG_Num],
                        [CT_NumPayeur],
                        [CT_NumPayeurOrig]
                ) VALUES (
                    {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 
                    {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, 
                    {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, 
                    {30}, {31}, {32}, {33}, {34}, {35}, {36}, {37}, {38}, {39},
                    {40}, {41}, {42}, {43}
                );

                ENABLE TRIGGER [TG_CBINS_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];
                ENABLE TRIGGER [TG_INS_CPTAF_CREGLEMENT] ON [dbo].[F_CREGLEMENT];
            ";


            using (var context = new AppDbContext())
            {
                context.Database.ExecuteSqlCommand(query,
                    reglement.RG_No,
                    reglement.RG_Date,
                    reglement.RG_Montant,
                    reglement.N_Reglement,
                    reglement.RG_Impute,
                    reglement.RG_Libelle,
                    reglement.RG_MontantDev,
                    reglement.RG_Reference,
                    reglement.RG_Compta,
                    reglement.EC_No,
                    reglement.RG_Type,
                    reglement.RG_Cours,
                    reglement.RG_TypeReg,
                    reglement.N_Devise,
                    reglement.JO_Num,
                    reglement.RG_Impaye,
                    reglement.RG_Heure,
                    reglement.RG_Piece,
                    reglement.CA_No,
                    reglement.cbCA_No,
                    reglement.CO_NoCaissier,
                    reglement.cbCO_NoCaissier,
                    reglement.RG_Transfere,
                    reglement.RG_Cloture,
                    reglement.RG_Ticket,
                    reglement.RG_Souche,
                    reglement.RG_DateEchCont,
                    reglement.RG_MontantEcart,
                    reglement.RG_NoBonAchat,
                    reglement.RG_Valide,
                    reglement.RG_Anterieur,
                    reglement.RG_MontantCommission,
                    reglement.RG_MontantNet,
                    reglement.cbProt,
                    reglement.cbModification,
                    reglement.cbReplication,
                    reglement.cbFlag,
                    reglement.cbCreation,
                    reglement.cbHashVersion,
                    reglement.cbHashDate,
                    reglement.RG_Banque,
                    reglement.CG_Num,
                    reglement.CT_NumPayeur,
                    reglement.CT_NumPayeurOrig
                );
            }
                

            // Mise à jour du dernier numéro de règlement dans P_COLREGLEMENT
            P_COLREGLEMENT pColRToUpdate = _context.P_COLREGLEMENT.FirstOrDefault();
            int currentRGNumber = (int)reglement.RG_No + 1;
            pColRToUpdate.CR_Numero01 = currentRGNumber.ToString();
            _context.SaveChanges();
        }
        // ==============================================================================================
        // FIN CREATE ===================================================================================
        // ==============================================================================================










        // ==============================================================================================
        // DÉBUT UPDATE =================================================================================
        // ==============================================================================================
        public async void Update(F_CREGLEMENT f_CREGLEMENT)
        {
            F_CREGLEMENT f_CREGLEMENTToUpdate = GetBy_RG_No(f_CREGLEMENT.RG_No);

            string queryUpdateF_CREGLEMENT = @"
                UPDATE [BIJOU].[dbo].[F_CREGLEMENT]
                SET
                    RG_Reference = @RG_Reference,
                    RG_Libelle = @RG_Libelle,
                    RG_Montant = @RG_Montant,
                    RG_MontantDev = @RG_MontantDev,
                    RG_Cours = @RG_Cours,
                    N_Devise = @N_Devise,
                    JO_Num = @JO_Num,
                    CG_NumCont = @CG_NumCont,
                    RG_Impaye = @RG_Impaye,
                    CG_Num = @CG_Num,
                    RG_TypeReg = @RG_TypeReg,
                    CA_No = @CA_No,
                    cbCA_No = @cbCA_No,
                    CO_NoCaissier = @CO_NoCaissier,
                    cbCO_NoCaissier = @cbCO_NoCaissier,
                    RG_DateEchCont = @RG_DateEchCont
                WHERE RG_No = @RG_No;
            ";

            using (AppDbContext context = new AppDbContext())
            {
                await context.Database.ExecuteSqlCommandAsync(
                    queryUpdateF_CREGLEMENT,
                    new SqlParameter("@RG_Reference", f_CREGLEMENT.RG_Reference),
                    new SqlParameter("@RG_Libelle", f_CREGLEMENT.RG_Libelle),
                    new SqlParameter("@RG_Montant", f_CREGLEMENT.RG_Montant),
                    new SqlParameter("@RG_MontantDev", f_CREGLEMENT.RG_MontantDev),
                    new SqlParameter("@RG_Cours", f_CREGLEMENT.RG_Cours),
                    new SqlParameter("@N_Devise", f_CREGLEMENT.N_Devise),
                    new SqlParameter("@JO_Num", f_CREGLEMENT.JO_Num),
                    new SqlParameter("@CG_NumCont", f_CREGLEMENT.CG_NumCont),
                    new SqlParameter("@RG_Impaye", f_CREGLEMENT.RG_Impaye),
                    new SqlParameter("@CG_Num", f_CREGLEMENT.CG_Num),
                    new SqlParameter("@RG_TypeReg", f_CREGLEMENT.RG_TypeReg),
                    new SqlParameter("@CA_No", f_CREGLEMENT.CA_No),
                    new SqlParameter("@cbCA_No", f_CREGLEMENT.cbCA_No),
                    new SqlParameter("@CO_NoCaissier", f_CREGLEMENT.CO_NoCaissier),
                    new SqlParameter("@cbCO_NoCaissier", f_CREGLEMENT.cbCO_NoCaissier),
                    new SqlParameter("@RG_DateEchCont", f_CREGLEMENT.RG_DateEchCont),
                    new SqlParameter("@RG_No", f_CREGLEMENT.RG_No)
                );
            } 
        }
        // ==============================================================================================
        // FIN UPDATE ===================================================================================
        // ==============================================================================================










        // ==============================================================================================
        // DEBUT DELETE =================================================================================
        // ==============================================================================================
        public void Delete(int RG_No)
        {
            // =================== Supprimer d'abord les payements des échéances avec ce reglement ================
            f_REGLECHRepository.DeleteByRG_No(RG_No);


            // =================== Suppression dans F_CREGLEMENT ================
            string queryDeleteFCReglement = @"
                DISABLE TRIGGER [TG_CBDEL_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];

                DELETE FROM [dbo].[F_CREGLEMENT] WHERE RG_No = @RG_No;

                ENABLE TRIGGER [TG_CBDEL_F_CREGLEMENT] ON [dbo].[F_CREGLEMENT];
            ";


            using (var context = new AppDbContext())
            {
                _context.Database.ExecuteSqlCommand(
                    queryDeleteFCReglement,
                    new SqlParameter("@RG_No", RG_No)
                );
            }
        }
        // ==============================================================================================
        // FIN DELETE ===================================================================================
        // ==============================================================================================









    }
}
