using SoftCaisse.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SoftCaisse.Repositories.BIJOU
{
    internal class F_DOCENTETERepository
    {
        private readonly AppDbContext _context;





        public F_DOCENTETERepository(AppDbContext context)
        {
            _context = context;
        }





        public void Add(F_DOCENTETE f_DOCENTETE)
        {
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBINS_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_INS_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_INS_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE]");

            string query = @"
                Insert INTO [dbo].[F_DOCENTETE] (
					DO_Domaine,
					DO_Type,
					DO_Piece,
					DO_Date,
					DO_Ref,
					DO_Tiers,
					CO_No,
					cbCO_No,
					DO_Period,
					DO_Devise,
					DO_Cours,
					DE_No,
					cbDE_No,
					LI_No,
					cbLI_No,
					CT_NumPayeur,
					DO_Expedit,
					DO_NbFacture,
					DO_BLFact,
					DO_TxEscompte,
					DO_Reliquat,
					DO_Imprim,
					CA_Num,
					DO_Coord01,
					DO_Coord02,
					DO_Coord03,
					DO_Coord04,
					DO_Souche,
					DO_DateLivr,
					DO_Condition,
					DO_Tarif,
					DO_Colisage,
					DO_TypeColis,
					DO_Transaction,
					DO_Langue,
					DO_Ecart,
					DO_Regime,
					N_CatCompta,
					DO_Ventile,
					AB_No,
					DO_DebutAbo,
					DO_FinAbo,
					DO_DebutPeriod,
					DO_FinPeriod,
					CG_Num,
					DO_Statut,
					DO_Heure,
					CA_No,
					cbCA_No,
					CO_NoCaissier,
					cbCO_NoCaissier,
					DO_Transfere,
					DO_Cloture,
					DO_NoWeb,
					DO_Attente,
					DO_Provenance,
					CA_NumIFRS,
					MR_No,
					DO_TypeFrais,
					DO_ValFrais,
					DO_TypeLigneFrais,
					DO_TypeFranco,
					DO_ValFranco,
					DO_TypeLigneFranco,
					DO_Taxe1,
					DO_TypeTaux1,
					DO_TypeTaxe1,
					DO_Taxe2,
					DO_TypeTaux2,
					DO_TypeTaxe2,
					DO_Taxe3,
					DO_TypeTaux3,
					DO_TypeTaxe3,
					DO_MajCpta,
					DO_Motif,
					CT_NumCentrale,
					DO_Contact,
					DO_FactureElec,
					DO_TypeTransac,
					DO_DateLivrRealisee,
					DO_DateExpedition,
					DO_FactureFrs,
					DO_PieceOrig,
					DO_GUID,
					DO_EStatut,
					DO_DemandeRegul,
					ET_No,
					cbET_No,
					DO_Valide,
					DO_Coffre,
					DO_CodeTaxe1,
					DO_CodeTaxe2,
					DO_CodeTaxe3,
					DO_TotalHT,
					DO_StatutBAP,
					DO_Escompte,
					DO_DocType,
					DO_TypeCalcul,
					DO_FactureFile,
					DO_TotalHTNet,
					DO_TotalTTC,
					DO_NetAPayer,
					DO_MontantRegle,
					DO_RefPaiement,
					DO_AdressePaiement,
					DO_PaiementLigne,
					DO_MotifDevis,
					DO_Conversion,
					cbCreateur,
					Divers,
					Commentaires
				)
				values(
				    {0},
					{1},
					{2},
					{3},
					{4},
					{5},
					{6},
					{7},
					{8},
					{9},
					{10},
					{11},
					{12},
					{13},
					{14},
					{15},
					{16},
					{17},
					{18},
					{19},
					{20},
					{21},
					{22},
					{23},
					{24},
					{25},
					{26},
					{27},
					{28},
					{29},
					{30},
					{31},
					{32},
					{33},
					{34},
					{35},
					{36},
					{37},
					{38},
					{39},
					{40},
					{41},
					{42},
					{43},
					{44},
					{45},
					{46},
					{47},
					{48},
					{49},
					{50},
					{51},
					{52},
					{53},
					{54},
					{55},
					{56},
					{57},
					{58},
					{59},
					{60},
					{61},
					{62},
					{63},
					{64},
					{65},
					{66},
					{67},
					{68},
					{69},
					{70},
					{71},
					{72},
					{73},
					{74},
					{75},
					{76},
					{77},
					{78},
					{79},
					{80},
					{81},
					{82},
					{83},
					{84},
					{85},
					{86},
					{87},
					{88},
					{89},
					{90},
					{91},
					{92},
					{93},
					{94},
					{95},
					{96},
					{97},
					{98},
					{99},
					{100},
					{101},
					{102},
					{103},
					{104},
					{105},
					{106},
					{107},
					{108},
					{109},
					{110}
				)";


            _context.Database.ExecuteSqlCommand(query,
                f_DOCENTETE.DO_Domaine,
                f_DOCENTETE.DO_Type,
                f_DOCENTETE.DO_Piece,
                f_DOCENTETE.DO_Date,
                f_DOCENTETE.DO_Ref,
                f_DOCENTETE.DO_Tiers,
                f_DOCENTETE.CO_No,
                f_DOCENTETE.cbCO_No == 0 ? null : f_DOCENTETE.cbCO_No,
                f_DOCENTETE.DO_Period,
                f_DOCENTETE.DO_Devise,
                f_DOCENTETE.DO_Cours,
                f_DOCENTETE.DE_No,
                f_DOCENTETE.cbDE_No,
                f_DOCENTETE.LI_No,
                f_DOCENTETE.cbLI_No,
                f_DOCENTETE.CT_NumPayeur,
                f_DOCENTETE.DO_Expedit,
                f_DOCENTETE.DO_NbFacture,
                f_DOCENTETE.DO_BLFact,
                f_DOCENTETE.DO_TxEscompte,
                f_DOCENTETE.DO_Reliquat,
                f_DOCENTETE.DO_Imprim,
                f_DOCENTETE.CA_Num,
                f_DOCENTETE.DO_Coord01,
                f_DOCENTETE.DO_Coord02,
                f_DOCENTETE.DO_Coord03,
                f_DOCENTETE.DO_Coord04,
                f_DOCENTETE.DO_Souche,
                f_DOCENTETE.DO_DateLivr,
                f_DOCENTETE.DO_Condition,
                f_DOCENTETE.DO_Tarif,
                f_DOCENTETE.DO_Colisage,
                f_DOCENTETE.DO_TypeColis,
                f_DOCENTETE.DO_Transaction,
                f_DOCENTETE.DO_Langue,
                f_DOCENTETE.DO_Ecart,
                f_DOCENTETE.DO_Regime,
                f_DOCENTETE.N_CatCompta,
                f_DOCENTETE.DO_Ventile,
                f_DOCENTETE.AB_No,
                f_DOCENTETE.DO_DebutAbo,
                f_DOCENTETE.DO_FinAbo,
                f_DOCENTETE.DO_DebutPeriod,
                f_DOCENTETE.DO_FinPeriod,
                f_DOCENTETE.CG_Num,
                f_DOCENTETE.DO_Statut,
                f_DOCENTETE.DO_Heure,
                f_DOCENTETE.CA_No,				//TODO: Tsy mety
                f_DOCENTETE.cbCA_No == 0 ? null : f_DOCENTETE.cbCA_No,			//TODO: Tsy mety
                f_DOCENTETE.CO_NoCaissier,		//TODO: Tsy mety
                f_DOCENTETE.cbCO_NoCaissier,	//TODO: Tsy mety
                f_DOCENTETE.DO_Transfere,
                f_DOCENTETE.DO_Cloture,
                f_DOCENTETE.DO_NoWeb,
                f_DOCENTETE.DO_Attente,
                f_DOCENTETE.DO_Provenance,
                f_DOCENTETE.CA_NumIFRS,
                f_DOCENTETE.MR_No,
                f_DOCENTETE.DO_TypeFrais,
                f_DOCENTETE.DO_ValFrais,
                f_DOCENTETE.DO_TypeLigneFrais,
                f_DOCENTETE.DO_TypeFranco,
                f_DOCENTETE.DO_ValFranco,
                f_DOCENTETE.DO_TypeLigneFranco,
                f_DOCENTETE.DO_Taxe1,
                f_DOCENTETE.DO_TypeTaux1,
                f_DOCENTETE.DO_TypeTaxe1,
                f_DOCENTETE.DO_Taxe2,
                f_DOCENTETE.DO_TypeTaux2,
                f_DOCENTETE.DO_TypeTaxe2,
                f_DOCENTETE.DO_Taxe3,
                f_DOCENTETE.DO_TypeTaux3,
                f_DOCENTETE.DO_TypeTaxe3,
                f_DOCENTETE.DO_MajCpta,
                f_DOCENTETE.DO_Motif,
                f_DOCENTETE.CT_NumCentrale,
                f_DOCENTETE.DO_Contact,
                f_DOCENTETE.DO_FactureElec,
                f_DOCENTETE.DO_TypeTransac,
                f_DOCENTETE.DO_DateLivrRealisee,
                f_DOCENTETE.DO_DateExpedition,
                f_DOCENTETE.DO_FactureFrs,
                f_DOCENTETE.DO_PieceOrig,
                f_DOCENTETE.DO_GUID,
                f_DOCENTETE.DO_EStatut,
                f_DOCENTETE.DO_DemandeRegul,
                f_DOCENTETE.ET_No,
                f_DOCENTETE.cbET_No,
                f_DOCENTETE.DO_Valide,
                f_DOCENTETE.DO_Coffre,
                f_DOCENTETE.DO_CodeTaxe1,
                f_DOCENTETE.DO_CodeTaxe2,
                f_DOCENTETE.DO_CodeTaxe3,
                f_DOCENTETE.DO_TotalHT,
                f_DOCENTETE.DO_StatutBAP,
                f_DOCENTETE.DO_Escompte,
                f_DOCENTETE.DO_DocType,
                f_DOCENTETE.DO_TypeCalcul,
                f_DOCENTETE.DO_FactureFile,
                f_DOCENTETE.DO_TotalHTNet,
                f_DOCENTETE.DO_TotalTTC,
                f_DOCENTETE.DO_NetAPayer,
                f_DOCENTETE.DO_MontantRegle,
                f_DOCENTETE.DO_RefPaiement,
                f_DOCENTETE.DO_AdressePaiement,
                f_DOCENTETE.DO_PaiementLigne,
                f_DOCENTETE.DO_MotifDevis,
                f_DOCENTETE.DO_Conversion,
                f_DOCENTETE.cbCreateur,
				f_DOCENTETE.Divers,
				f_DOCENTETE.Commentaires
            );

            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_CBINS_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_INS_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_INS_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE]");
        }





        // ===============================================================================================================================
        // ==================================== DEBUT MISE A JOUR DU MONTANT TOTAL HT DANS F_DOCENTETE ===================================
        // ===============================================================================================================================
        public void UpdateTotalHT(string numDoPiece, decimal? doTotalHT)
        {
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_CBUPD_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_UPD_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER [dbo].[TG_UPD_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            string query = "UPDATE F_DOCENTETE SET DO_TotalHT = @doTotalHT WHERE DO_Piece LIKE @numDoPiece";
            _context.Database.ExecuteSqlCommand(
                query,
                new SqlParameter("@doTotalHT", doTotalHT),
                new SqlParameter("@numDoPiece", "%" + numDoPiece + "%")
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER[dbo].[TG_CBUPD_F_DOCENTETE] ON[dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_UPD_F_DOCENTETE] ON [dbo].[F_DOCENTETE]");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER [dbo].[TG_UPD_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE]");
        }
        // ===============================================================================================================================
        // ===================================== FIN MISE A JOUR DU MONTANT TOTAL HT DANS F_DOCENTETE ====================================
        // ===============================================================================================================================





        // ==============================================================================================================================
        // ==================================== DEBUT MISE A JOUR DU MONTANT REGLE AVEC DES ECHEANCES ===================================
        // ==============================================================================================================================
        public void UpdateDO_MontantRegle(decimal RC_Montant, string DO_Piece)
		{
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE");
            string queryFDocEntete = @"
                        UPDATE F_DOCENTETE
                        SET DO_MontantRegle = @DO_MontantRegle
                        WHERE DO_Piece = @DO_Piece
                    ";
            _context.Database.ExecuteSqlCommand(
                queryFDocEntete,
                new SqlParameter("@DO_MontantRegle", RC_Montant),
                new SqlParameter("@DO_Piece", DO_Piece)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE");
        }
        // ============================================================================================================================
        // ==================================== FIN MISE A JOUR DU MONTANT REGLE AVEC DES ECHEANCES ===================================
        // ============================================================================================================================





		public void UpdateProprietesF_DOCENTETE(F_DOCENTETE f_DOCENTETEToUpdate)
		{
			string queryUpdateProprietesF_DOCENTETE = @"
				UPDATE F_DOCENTETE

				SET
					DO_DateLivr = @DO_DateLivr,
					DO_DateLivrRealisee = @DO_DateLivrRealisee,
					DO_Ref = @DO_Ref,
					CA_Num = @CA_Num,
					CO_No = @CO_No,
					cbCO_No = @cbCO_No,
					DO_Expedit = @DO_Expedit,
					DO_ValFranco = @DO_ValFranco,
					DO_ValFrais = @DO_ValFrais,
					DO_Coord01 = @DO_Coord01,
					Commentaires = @Commentaires,
					Divers = @Divers,
					DE_No = @DE_No

				WHERE DO_Piece = @DO_Piece
			";

            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE");
			_context.Database.ExecuteSqlCommand(
				queryUpdateProprietesF_DOCENTETE,
				new SqlParameter("@DO_DateLivr", f_DOCENTETEToUpdate.DO_DateLivr),
				new SqlParameter("@DO_DateLivrRealisee", f_DOCENTETEToUpdate.DO_DateLivrRealisee),
				new SqlParameter("@DO_Ref", f_DOCENTETEToUpdate.DO_Ref),
				new SqlParameter("@CA_Num", f_DOCENTETEToUpdate.CA_Num),
				new SqlParameter("@CO_No", f_DOCENTETEToUpdate.CO_No),
				new SqlParameter("@cbCO_No", f_DOCENTETEToUpdate.cbCO_No),
				new SqlParameter("@DO_Expedit", f_DOCENTETEToUpdate.DO_Expedit),
				new SqlParameter("@DO_ValFranco", f_DOCENTETEToUpdate.DO_ValFranco),
				new SqlParameter("@DO_ValFrais", f_DOCENTETEToUpdate.DO_ValFrais),
				new SqlParameter("@DO_Coord01", f_DOCENTETEToUpdate.DO_Coord01),
				new SqlParameter("@Commentaires", f_DOCENTETEToUpdate.Commentaires),
				new SqlParameter("@Divers", f_DOCENTETEToUpdate.Divers),
				new SqlParameter("@DE_No", f_DOCENTETEToUpdate.DE_No),
				new SqlParameter("@DO_Piece", f_DOCENTETEToUpdate.DO_Piece)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE");
        }





		public void ValiderDocument(string DO_Piece, short? DO_Valide)
		{
            string queryValiderDocument = @"
				UPDATE F_DOCENTETE

				SET
					DO_Valide = @DO_Valide

				WHERE DO_Piece = @DO_Piece
			";

            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand(
                queryValiderDocument,
                new SqlParameter("@DO_Valide", DO_Valide),
                new SqlParameter("@DO_Piece", DO_Piece)
            );
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE");
        }




		public void Delete(string DO_Piece)
		{
            string query = "DELETE FROM F_DOCENTETE WHERE DO_Piece = @DO_Piece";

            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_CBDEL_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("DISABLE TRIGGER TG_DEL_F_DOCENTETE ON F_DOCENTETE");

            _context.Database.ExecuteSqlCommand(query, new SqlParameter("@DO_Piece", DO_Piece));

            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_CBDEL_F_DOCENTETE ON F_DOCENTETE");
            _context.Database.ExecuteSqlCommand("ENABLE TRIGGER TG_DEL_F_DOCENTETE ON F_DOCENTETE");
        }
    }
}
