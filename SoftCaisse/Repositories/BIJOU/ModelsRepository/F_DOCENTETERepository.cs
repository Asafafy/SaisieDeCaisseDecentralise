using SoftCaisse.Models;
using System;
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
            string query = @"
				DISABLE TRIGGER [dbo].[TG_CBINS_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				DISABLE TRIGGER [dbo].[TG_INS_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				DISABLE TRIGGER [dbo].[TG_INS_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE];

                Insert INTO [dbo].[F_DOCENTETE] (
					DO_Type,
					DO_Piece,
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
					CA_Num,
					DO_Coord01,
					DO_DateLivr,
					DO_Condition,
					DO_Tarif,
					DO_Transaction,
					DO_Langue,
					DO_Regime,
					N_CatCompta,
					CG_Num,
					DO_Heure,
					CA_No,
					cbCA_No,
					CO_NoCaissier,
					cbCO_NoCaissier,
					CA_NumIFRS,
					DO_TypeFrais,
					DO_ValFrais,
					DO_TypeLigneFrais,
					DO_TypeFranco,
					DO_ValFranco,
					DO_TypeLigneFranco,
					DO_Taxe1,
					DO_DateLivrRealisee,
					DO_CodeTaxe1,
					Divers,
					Commentaires,
				    DO_Domaine,
					DO_Date,
					DO_Reliquat,
					DO_Imprim,
					DO_Coord02,
					DO_Coord03,
					DO_Coord04,
					DO_Souche,
					DO_Colisage,
					DO_TypeColis,
					DO_Ecart,
					DO_Ventile,
					AB_No,
					DO_DebutAbo,
					DO_FinAbo,
					DO_DebutPeriod,
					DO_FinPeriod,
					DO_Statut,
					DO_Transfere,
					DO_Cloture,
					DO_NoWeb,
					DO_Attente,
					DO_Provenance,
					MR_No,
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
					cbCreateur
				)
				values(
					@DO_Type,
					@DO_Piece,
					@DO_Ref,
					@DO_Tiers,
					@CO_No,
					@cbCO_No,
					@DO_Period,
					@DO_Devise,
					@DO_Cours,
					@DE_No,
					@cbDE_No,
					@LI_No,
					@cbLI_No,
					@CT_NumPayeur,
					@DO_Expedit,
					@DO_NbFacture,
					@DO_BLFact,
					@DO_TxEscompte,
					@CA_Num,
					@DO_Coord01,
					@DO_DateLivr,
					@DO_Condition,
					@DO_Tarif,
					@DO_Transaction,
					@DO_Langue,
					@DO_Regime,
					@N_CatCompta,
					@CG_Num,
					@DO_Heure,
					@CA_No,
					@cbCA_No,
					@CO_NoCaissier,
					@cbCO_NoCaissier,
					@CA_NumIFRS,
					@DO_TypeFrais,
					@DO_ValFrais,
					@DO_TypeLigneFrais,
					@DO_TypeFranco,
					@DO_ValFranco,
					@DO_TypeLigneFranco,
					@DO_Taxe1,
					@DO_DateLivrRealisee,
					@DO_CodeTaxe1,
					@Divers,
					@Commentaires,
				    0,							--@DO_Domaine,
					GETDATE(),					--@DO_Date,
					0,							--@DO_Reliquat,
					0,							--@DO_Imprim,
					'',							--@DO_Coord02,
					'',							--@DO_Coord03,
					'',							--@DO_Coord04,
					0,							--@DO_Souche,
					1,							--@DO_Colisage,
					1,							--@DO_TypeColis,
					0,							--@DO_Ecart,
					0,							--@DO_Ventile,
					0,							--@AB_No,
					'1753-01-01 00:00:00',		--@DO_DebutAbo,
					'1753-01-01 00:00:00',		--@DO_FinAbo,
					'1753-01-01 00:00:00',		--@DO_DebutPeriod,
					'1753-01-01 00:00:00',		--@DO_FinPeriod,
					2,							--@DO_Statut,
					0,							--@DO_Transfere,
					0,							--@DO_Cloture,
					'',							--@DO_NoWeb,
					0,							--@DO_Attente,
					0,							--@DO_Provenance,
					0,							--@MR_No,
					0,							--@DO_TypeTaux1,
					0,							--@DO_TypeTaxe1,
					0,							--@DO_Taxe2,
					0,							--@DO_TypeTaux2,
					0,							--@DO_TypeTaxe2,
					0,							--@DO_Taxe3,
					0,							--@DO_TypeTaux3,
					0,							--@DO_TypeTaxe3,
					0,							--@DO_MajCpta,
					'',							--@DO_Motif,
					NULL,						--@CT_NumCentrale,
					0,							--@DO_Contact,
					0,							--@DO_FactureElec,
					0,							--@DO_TypeTransac,
					'1753-01-01 00:00:00',		--@DO_DateExpedition,
					'',							--@DO_FactureFrs,
					'',							--@DO_PieceOrig,
					NULL,						--@DO_GUID,
					0,							--@DO_EStatut,
					0,							--@DO_DemandeRegul,
					0,							--@ET_No,
					NULL,						--@cbET_No,
					0,							--@DO_Valide,
					0,							--@DO_Coffre,
					NULL,						--@DO_CodeTaxe2,
					NULL,						--@DO_CodeTaxe3,
					0,							--@DO_TotalHT,
					0,							--@DO_StatutBAP,
					1,							--@DO_Escompte,
					6,							--@DO_DocType,
					0,							--@DO_TypeCalcul,
					NULL,						--@DO_FactureFile,
					0,							--@DO_TotalHTNet,
					0,							--@DO_TotalTTC,
					0,							--@DO_NetAPayer,
					0,							--@DO_MontantRegle,
					NULL,						--@DO_RefPaiement,
					'',							--@DO_AdressePaiement,
					0,							--@DO_PaiementLigne,
					0,							--@DO_MotifDevis,
					0,							--@DO_Conversion,
					'COLS'						--@cbCreateur
				);

				ENABLE TRIGGER [dbo].[TG_CBINS_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				ENABLE TRIGGER [dbo].[TG_INS_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				ENABLE TRIGGER [dbo].[TG_INS_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE];
			";

			using (var context = new AppDbContext())
			{
                context.Database.ExecuteSqlCommand(
					query,
					new SqlParameter("@DO_Type", f_DOCENTETE.DO_Type),
					new SqlParameter("@DO_Piece", f_DOCENTETE.DO_Piece),
					new SqlParameter("@DO_Ref", f_DOCENTETE.DO_Ref),
					new SqlParameter("@DO_Tiers", f_DOCENTETE.DO_Tiers),
					new SqlParameter("@CO_No", f_DOCENTETE.CO_No),
					new SqlParameter("@cbCO_No ", f_DOCENTETE.cbCO_No ?? (object)DBNull.Value),
					new SqlParameter("@DO_Period", f_DOCENTETE.DO_Period),
					new SqlParameter("@DO_Devise", f_DOCENTETE.DO_Devise),
					new SqlParameter("@DO_Cours", f_DOCENTETE.DO_Cours),
					new SqlParameter("@DE_No", f_DOCENTETE.DE_No),
					new SqlParameter("@cbDE_No", f_DOCENTETE.cbDE_No),
					new SqlParameter("@LI_No", f_DOCENTETE.LI_No),
					new SqlParameter("@cbLI_No", f_DOCENTETE.cbLI_No),
					new SqlParameter("@CT_NumPayeur", f_DOCENTETE.CT_NumPayeur),
					new SqlParameter("@DO_Expedit", f_DOCENTETE.DO_Expedit),
					new SqlParameter("@DO_NbFacture", f_DOCENTETE.DO_NbFacture),
					new SqlParameter("@DO_BLFact", f_DOCENTETE.DO_BLFact),
					new SqlParameter("@DO_TxEscompte", f_DOCENTETE.DO_TxEscompte),
					new SqlParameter("@CA_Num", f_DOCENTETE.CA_Num),
					new SqlParameter("@DO_Coord01", f_DOCENTETE.DO_Coord01),
					new SqlParameter("@DO_DateLivr", f_DOCENTETE.DO_DateLivr),
					new SqlParameter("@DO_Condition", f_DOCENTETE.DO_Condition),
					new SqlParameter("@DO_Tarif", f_DOCENTETE.DO_Tarif),
					new SqlParameter("@DO_Transaction", f_DOCENTETE.DO_Transaction),
					new SqlParameter("@DO_Langue", f_DOCENTETE.DO_Langue),
					new SqlParameter("@DO_Regime", f_DOCENTETE.DO_Regime),
					new SqlParameter("@N_CatCompta", f_DOCENTETE.N_CatCompta),
					new SqlParameter("@CG_Num", f_DOCENTETE.CG_Num),
					new SqlParameter("@DO_Heure", f_DOCENTETE.DO_Heure),
					new SqlParameter("@CA_No", f_DOCENTETE.CA_No),
					new SqlParameter("@cbCA_No ", f_DOCENTETE.cbCA_No ?? (object)DBNull.Value),
					new SqlParameter("@CO_NoCaissier", f_DOCENTETE.CO_NoCaissier),
					new SqlParameter("@cbCO_NoCaissier ", f_DOCENTETE.cbCO_NoCaissier ?? (object)DBNull.Value),
					new SqlParameter("@CA_NumIFRS", f_DOCENTETE.CA_NumIFRS),
					new SqlParameter("@DO_TypeFrais", f_DOCENTETE.DO_TypeFrais),
					new SqlParameter("@DO_ValFrais", f_DOCENTETE.DO_ValFrais),
					new SqlParameter("@DO_TypeLigneFrais", f_DOCENTETE.DO_TypeLigneFrais),
					new SqlParameter("@DO_TypeFranco", f_DOCENTETE.DO_TypeFranco),
					new SqlParameter("@DO_ValFranco", f_DOCENTETE.DO_ValFranco),
					new SqlParameter("@DO_TypeLigneFranco", f_DOCENTETE.DO_TypeLigneFranco),
					new SqlParameter("@DO_Taxe1", f_DOCENTETE.DO_Taxe1),
					new SqlParameter("@DO_DateLivrRealisee", f_DOCENTETE.DO_DateLivrRealisee),
					new SqlParameter("@DO_CodeTaxe1", f_DOCENTETE.DO_CodeTaxe1),
					new SqlParameter("@Divers", f_DOCENTETE.Divers),
                    new SqlParameter("@Commentaires", f_DOCENTETE.Commentaires)
                );
            }
        }





        // ===============================================================================================================================
        // ==================================== DEBUT MISE A JOUR DU MONTANT TOTAL HT DANS F_DOCENTETE ===================================
        // ===============================================================================================================================
        public void UpdateTotalHT(string numDoPiece, decimal? doTotalHT)
        {
            string query = @"
				DISABLE TRIGGER [dbo].[TG_CBUPD_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				DISABLE TRIGGER [dbo].[TG_UPD_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				DISABLE TRIGGER [dbo].[TG_UPD_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE];

				UPDATE F_DOCENTETE SET DO_TotalHT = @doTotalHT WHERE DO_Piece LIKE @numDoPiece;

				ENABLE TRIGGER[dbo].[TG_CBUPD_F_DOCENTETE] ON[dbo].[F_DOCENTETE];
				ENABLE TRIGGER [dbo].[TG_UPD_F_DOCENTETE] ON [dbo].[F_DOCENTETE];
				ENABLE TRIGGER [dbo].[TG_UPD_CPTAF_DOCENTETE] ON [dbo].[F_DOCENTETE];
			";

            using (var context = new AppDbContext())
			{
                context.Database.ExecuteSqlCommand(
				    query,
				    new SqlParameter("@doTotalHT", doTotalHT),
				    new SqlParameter("@numDoPiece", "%" + numDoPiece + "%")
				);
            }
        }
        // ===============================================================================================================================
        // ===================================== FIN MISE A JOUR DU MONTANT TOTAL HT DANS F_DOCENTETE ====================================
        // ===============================================================================================================================





        // ==============================================================================================================================
        // ==================================== DEBUT MISE A JOUR DU MONTANT REGLE AVEC DES ECHEANCES ===================================
        // ==============================================================================================================================
        public void UpdateDO_MontantRegle(decimal RC_Montant, string DO_Piece)
		{
            string queryFDocEntete = @"
				DISABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE;

				UPDATE F_DOCENTETE SET DO_MontantRegle = @DO_MontantRegle WHERE DO_Piece = @DO_Piece;

				ENABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE;
            ";

            using (var context = new AppDbContext())
			{
				context.Database.ExecuteSqlCommand(
					queryFDocEntete,
					new SqlParameter("@DO_MontantRegle", RC_Montant),
					new SqlParameter("@DO_Piece", DO_Piece)
				);
            }
               
        }
        // ============================================================================================================================
        // ==================================== FIN MISE A JOUR DU MONTANT REGLE AVEC DES ECHEANCES ===================================
        // ============================================================================================================================





		public void UpdateProprietesF_DOCENTETE(F_DOCENTETE f_DOCENTETEToUpdate)
		{
			string queryUpdateProprietesF_DOCENTETE = @"
				DISABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE;

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
				WHERE DO_Piece = @DO_Piece;

				ENABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE;
			";


            using (var context = new AppDbContext())
			{
                context.Database.ExecuteSqlCommand(
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
            }
        }





		public void ValiderDocument(string DO_Piece, short? DO_Valide)
		{
            string queryValiderDocument = @"
				DISABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE;

				UPDATE F_DOCENTETE
				SET
					DO_Valide = @DO_Valide
				WHERE DO_Piece = @DO_Piece;

				ENABLE TRIGGER TG_CBUPD_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_UPD_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_UPD_CPTAF_DOCENTETE ON F_DOCENTETE;
			";

			using(var context = new AppDbContext())
			{
                context.Database.ExecuteSqlCommand(
				    queryValiderDocument,
				    new SqlParameter("@DO_Valide", DO_Valide),
				    new SqlParameter("@DO_Piece", DO_Piece)
				);
            }
        }




		public void Delete(string DO_Piece)
		{
            string query = @"
				DISABLE TRIGGER TG_CBDEL_F_DOCENTETE ON F_DOCENTETE;
				DISABLE TRIGGER TG_DEL_F_DOCENTETE ON F_DOCENTETE;

				DELETE FROM F_DOCENTETE WHERE DO_Piece = @DO_Piece;

				ENABLE TRIGGER TG_CBDEL_F_DOCENTETE ON F_DOCENTETE;
				ENABLE TRIGGER TG_DEL_F_DOCENTETE ON F_DOCENTETE;
			";

			using(var context = new AppDbContext())
			{
                context.Database.ExecuteSqlCommand(query, new SqlParameter("@DO_Piece", DO_Piece));
            }
        }
    }
}
