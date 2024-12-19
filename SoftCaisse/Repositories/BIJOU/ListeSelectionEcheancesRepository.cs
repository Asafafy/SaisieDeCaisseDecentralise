using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Repositories.BIJOU
{
    internal class ListeSelectionEcheancesRepository
    {
        private readonly AppDbContext _context;
        public ListeSelectionEcheancesRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ListeSelectionEcheances> ListerEcheances(string ct_Num, int rgNo)
        {
            // Déclaration de la requête SQL brute avec un paramètre
            string query = @"
                WITH CTE_Requete1 AS (
                    SELECT
                        DR_No,
                        SUM(RC_Montant) AS Total_RC_Montant
                    FROM
                        BIJOU.dbo.F_REGLECH
                    GROUP BY
                        DR_No
                ),

                CTE_RC_Montant AS (
                    SELECT
                        F_DOCREGL.DR_No,
                        -- Sélectionner RC_Montant selon la condition sur RG_No
                        ISNULL(
                            MAX(CASE 
                                    WHEN F_REGLECH.RG_No = @RG_No THEN F_REGLECH.RC_Montant
                                    ELSE 0 
                                END), 
                            0
                        ) AS RC_Montant,
                        -- Ajouter RG_No si la ligne correspond au paramètre
                        MAX(CASE 
                                WHEN F_REGLECH.RG_No = @RG_No THEN F_REGLECH.RG_No 
                                ELSE NULL 
                            END) AS RG_No
                    FROM F_DOCREGL
                    LEFT JOIN F_REGLECH ON F_DOCREGL.DR_No = F_REGLECH.DR_No
                    GROUP BY F_DOCREGL.DR_No
                )
                
                SELECT
                    F_DOCREGL.DR_Date AS DR_Date,
                    F_DOCREGL.DO_Piece AS DO_Piece,
                    F_DOCENTETE.CT_NumPayeur AS CT_NumPayeur,
                    F_DOCREGL.DR_Pourcent AS DR_Pourcent,
                    P_REGLEMENT.R_Intitule AS R_INTITULE,
                    F_DOCREGL.DR_No,
                    CTE_RC_Montant.RC_Montant, -- RC_Montant basé sur la condition RG_No
                    CTE_RC_Montant.RG_No,      -- Ajout de RG_No
                    F_DOCREGL.DR_Regle AS DR_Regle,
                
                    -- Calcul de A_Payer
                    CASE
                        WHEN F_DOCREGL.DR_Pourcent = 0 THEN 
                            F_DOCENTETE.DO_NetAPayer - SUM(F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100) 
                            OVER (PARTITION BY F_DOCREGL.DO_Piece)
                        ELSE 
                            F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100
                    END AS A_Payer,
                
                    -- Calcul de Solde
                    CASE
                        WHEN CTE_Requete1.Total_RC_Montant IS NULL THEN
                            CASE
                                WHEN F_DOCREGL.DR_Pourcent = 0 THEN 
                                    F_DOCENTETE.DO_NetAPayer - SUM(F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100) 
                                    OVER (PARTITION BY F_DOCREGL.DO_Piece)
                                ELSE 
                                    F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100
                            END
                        ELSE
                            CASE
                                WHEN F_DOCREGL.DR_Pourcent = 0 THEN 
                                    (F_DOCENTETE.DO_NetAPayer - SUM(F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100) OVER (PARTITION BY F_DOCREGL.DO_Piece)) -   CTE_Requete1.Total_RC_Montant
                                ELSE 
                                    (F_DOCREGL.DR_Pourcent * F_DOCENTETE.DO_NetAPayer / 100) - CTE_Requete1.Total_RC_Montant
                            END
                    END AS Solde
                
                FROM F_DOCREGL
                INNER JOIN F_DOCENTETE ON F_DOCREGL.DO_Piece = F_DOCENTETE.DO_Piece
                INNER JOIN P_REGLEMENT ON F_DOCREGL.N_Reglement = P_REGLEMENT.cbMarq
                LEFT JOIN CTE_Requete1 ON F_DOCREGL.DR_No = CTE_Requete1.DR_No -- Jointure avec la requête 1
                LEFT JOIN CTE_RC_Montant ON F_DOCREGL.DR_No = CTE_RC_Montant.DR_No -- Jointure avec CTE_RC_Montant
                
                WHERE 
                    F_DOCENTETE.CT_NumPayeur = @NumPayeur
                    AND (F_DOCENTETE.DO_Type = 7 OR F_DOCENTETE.DO_Type = 6)
                
                GROUP BY
                    F_DOCREGL.DR_Date,
                    F_DOCREGL.DO_Piece,
                    F_DOCENTETE.CT_NumPayeur,
                    F_DOCREGL.DR_No,
                    F_DOCREGL.DR_Pourcent,
                    P_REGLEMENT.R_Intitule,
                    F_DOCENTETE.DO_NetAPayer,
                    F_DOCREGL.DR_Regle,
                    CTE_Requete1.Total_RC_Montant,
                    CTE_RC_Montant.RC_Montant,
                    CTE_RC_Montant.RG_No;
            ";

            // Définition du paramètre SQL
            var param1 = new SqlParameter("@NumPayeur", ct_Num); // Assurez-vous que ct_Num est correctement défini
            var param2 = new SqlParameter("@RG_No", rgNo); // Assurez-vous que ct_Num est correctement défini

            // Exécution de la requête SQL avec le paramètre
            var result = _context.Database
                .SqlQuery<ListeSelectionEcheances>(query, param1, param2)
                .ToList();

            return result;


        }
    }
}
